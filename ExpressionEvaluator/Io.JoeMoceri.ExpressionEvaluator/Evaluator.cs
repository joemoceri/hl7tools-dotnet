using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionEvaluator
{
	public interface IEvaluator
	{
		ExpressionResult Evaluate(string expression);
	}

	/// <summary>
	/// This is the main entry point for evaluating expressions. Use this class and its Evaluate method.
	/// </summary>
	public class Evaluator : IEvaluator
	{
		private IArithmetic arithmetic;

		private readonly IEnumerable<string> HigherPrecedenceOperators = new[] { "<=", ">=", "==", "!=", "<", ">", };
		private readonly IEnumerable<string> LowerPrecedenceOperators = new[] { "&&", "||", "and", "or" };

		public Evaluator() : this(new Arithmetic()) { }

		private Evaluator(IArithmetic arithmetic) 
		{
			this.arithmetic = arithmetic;
		}

		/// <summary>
		/// Evaluates the given expression, returning a ExpressionResult object that 
		/// contains its actual value (Value), the type (VarType), and the Exception (Error)
		/// if there are any issues.
		/// </summary>
		/// <param name="expression">The expression to evaluate</param>
		/// <returns>A ExpressionResult object.</returns>
		public ExpressionResult Evaluate(string expression)
		{
			ExpressionResult result = null;

			try
			{
				// if the expression is empty, return it and null
				if (string.IsNullOrWhiteSpace(expression.Trim()))
				{
					return new ExpressionResult 
					{ 
						Value = expression, 
						Type = VarType.Null 
					}; 
				};

				// get the whitespace outside of quotes out of the way
				expression = RemoveWhitespaceOutsideQuotes(expression);

				// an implicit negative is -1 or -(1)
				expression = HandleImplicitNegative(expression);

				int parenthesesAmount = GetCharCount(expression, '(') + GetCharCount(expression, ')');
				int doubleQuoteAmount = GetCharCount(expression, '"');

				// validate quotes and parentheses. There should never be an odd amount of actually used quotes and parentheses (inside strings doesn't matter)
				if (doubleQuoteAmount % 2 != 0)
				{
					string message = string.Format("Odd number of double quotes found: {0}. Are you missing a double quote?", doubleQuoteAmount);
					throw new ArithmeticException(message);
				}
				else if (parenthesesAmount % 2 != 0)
				{
					string message = string.Format("Odd number of parentheses found: {0}. Are you missing a parentheses?", parenthesesAmount);
					throw new ArithmeticException(message);
				}

				// recursively break down the expressions parentheses, then work your way back up
				while (parenthesesAmount != 0)
				{
					expression = GetOuterMostParentheticalExpression(expression, Evaluate);
					parenthesesAmount = GetCharCount(expression, '(') + GetCharCount(expression, ')');
				}

				// determine what kind of expression it is (math, string, boolean)
				var arithmeticExpType = GetArithmeticExpressionType(expression);

				// get the boolean evaluated result
				if (arithmeticExpType == ArithmeticExpressionType.Boolean)
				{
					result = EvaluateBooleanExpression(expression);
				}
				// get the math (same as string) evaluated result
				else if (arithmeticExpType == ArithmeticExpressionType.MathString)
				{
					result = EvaluateMathStringExpression(expression);
				}
				// not a valid expression
				else if (arithmeticExpType == ArithmeticExpressionType.Invalid)
				{
					var message = $"Type of Arithmetic Expression not found for {expression}.";
					throw new ArgumentException(message, nameof(expression));
				}
			}
			catch (Exception ex) 
			{
				return new ExpressionResult 
				{ 
					Value = null, 
					Type = VarType.Null, 
					Error = ex 
				};	
			}

			return result;

			ArithmeticExpressionType GetArithmeticExpressionType(string expression)
			{
				var delimiters = new[] { ">", ">=", "<", "<=", "==", "!=", "&&", "||", "and", "or" };
				for (int i = 0; i < delimiters.Length; i++)
				{
					if (expression.IndexOfOutsideQuotes(delimiters[i]) != -1)
					{
						return ArithmeticExpressionType.Boolean;
					}
				}

				delimiters = new[] { "+", "-", "/", "%", "*", "False", "True", "\"" };
				for (int i = 0; i < delimiters.Length; i++)
				{
					if (expression.IndexOfOutsideQuotes(delimiters[i]) != -1)
					{
						return ArithmeticExpressionType.MathString;
					}
				}

				int integer;
				float floatingPointNumber;
				if (int.TryParse(expression, out integer) || float.TryParse(expression, out floatingPointNumber))
				{
					return ArithmeticExpressionType.MathString;
				}

				return ArithmeticExpressionType.Invalid;
			}

			string RemoveWhitespaceOutsideQuotes(string str)
			{
				var result = new StringBuilder();
				bool inQuote = false;
				int start = 0, length = 0;
				char curQuote = char.MinValue;

				for (int i = 0; i < str.Length; i++)
				{
					if (str.CheckQuotes(i, curQuote))
					{
						curQuote = str[i];
						if (!inQuote)
						{
							start = i; length = 0;
						}
						else
						{
							length = (i + 1) - start; // + 1 to get the extra quote
							string temp = str.Substring(start, length);
							result.Append(temp);
							curQuote = char.MinValue;
						}
						inQuote = !inQuote;
					}
					else if (str[i] != ' ' && !inQuote)
					{
						result.Append(str[i]);
					}

				}

				return result.ToString();
			}

			string HandleImplicitNegative(string expression) 
			{ 
				return expression.Replace("-(", ("-1*(")); 
			}

			int GetCharCount(string original, char ch)
			{
				int result = 0;
				bool inQuote = false;
				char curQuote = char.MinValue;

				for (int i = 0; i < original.Length; i++)
				{
					if (original.CheckQuotes(i, curQuote))
					{
						curQuote = original[i];
						inQuote = !inQuote;
						if (!inQuote) { curQuote = char.MinValue; }
						if (curQuote == ch) { result++; }
					}
					if (!inQuote)
					{
						if (original[i] == ch)
						{
							result++;
						}
					}
				}

				return result;
			}

			string GetOuterMostParentheticalExpression(string expression, Func<string, ExpressionResult> action)
			{
				int start = expression.IndexOfOutsideQuotes('(') + 1;

				int length = GetParentheticalLength(expression); // always default to non same level

				if (length > expression.Length || start == 0)
				{
					var message = $"Couldn't get parenthetical expression for {expression}.";
					throw new ArgumentException(message, nameof(expression));
				}

				string outer = expression.Substring(start, length - start);

				return expression.ReplaceFirst("(" + outer + ")", action(outer).Value);

				int GetParentheticalLength(string str)
				{
					int result = 0, leftCount = 0;
					char curQuote = char.MinValue;
					bool inQuote = false;
					for (int i = 0; i < str.Length; i++)
					{
						if (str.CheckQuotes(i, curQuote))
						{
							curQuote = str[i];
							inQuote = !inQuote;
						}
						if (!inQuote)
						{
							if (str[i] == '(') { leftCount++; }
							else if (str[i] == ')')
							{
								leftCount--;
								if (leftCount == 0)
								{
									result = i;
									break;
								}

							}
						}
					}
					return result;
				}
			}

			ExpressionResult EvaluateBooleanExpression(string expression)
			{
				arithmetic.SetDelimiterRange(DelimiterOperandType.Boolean);
				string result = SolvePrecedence(expression, HigherPrecedenceOperators);
				result = SolvePrecedence(result, LowerPrecedenceOperators);

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = VarType.Boolean
				};

				return expResult;

				string SolvePrecedence(string expression, IEnumerable<string> delimiters)
				{
					string result = expression;
					var opGroup = arithmetic.GetFirstSelection(result, delimiters);

					while (opGroup.Location != int.MinValue)
					{
						var expGroup = GetHigestPrecedencePureExpression(result, opGroup);

						string originalLeft = expGroup.LeftOperand;
						string originalRight = expGroup.RightOperand;

						var leftResult = EvaluateMathStringExpression(expGroup.LeftOperand);
						expGroup.LeftOperand = leftResult.Value;
						
						var rightResult = EvaluateMathStringExpression(expGroup.RightOperand);
						expGroup.RightOperand = rightResult.Value;

						string answer = null;
						var expResult = SolveBooleanExpression(expGroup);

						answer = expResult.Value;

						expGroup.LeftOperand = originalLeft;
						expGroup.RightOperand = originalRight;

						result = result.ReplaceFirst(expGroup.Combine(), answer);
						opGroup = arithmetic.GetFirstSelection(result, delimiters);
					}

					return result;

					ExpressionResult SolveBooleanExpression(ExpressionGroup expGroup)
					{
						var Left = new Operand
						{
							Value = expGroup.LeftOperand,
							Type = arithmetic.GetVarType(expGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = arithmetic.GetVarType(expGroup.RightOperand)
						};

						string result;
						if (Left.Type == VarType.Float || Right.Type == VarType.Float) // floating point addition
						{
							float left = arithmetic.GetFloat(Left.Value), right = arithmetic.GetFloat(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}
						else if (Left.Type == VarType.Int && Right.Type == VarType.Int) // integer division
						{
							int left = arithmetic.GetInt(Left.Value), right = arithmetic.GetInt(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}
						else
						{ // Boolean and string 
							result = GetAnswer(Left.Value, Right.Value, expGroup.ExpressionOperator);
						}

						var expResult = new ExpressionResult { Value = result, Type = VarType.Boolean };

						return expResult;

						string GetAnswer<T>(T left, T right, Operator op) where T : IComparable<T>
						{
							switch (op)
							{
								case Operator.LessThan:
									return LessThan(left, right);
								case Operator.LessThanOrEqualTo:
									return LessThanOrEqualTo(left, right);
								case Operator.GreaterThan:
									return GreaterThan(left, right);
								case Operator.GreaterThanOrEqualTo:
									return GreaterThanOrEqualTo(left, right);
								case Operator.NotEqualTo:
									return NotEqualTo(left, right);
								case Operator.EqualTo:
									return EqualTo(left, right);
								case Operator.And:
									return And(left, right);
								case Operator.Or:
									return Or(left, right);
								default:
									return null;
							}

							string LessThan<T>(T left, T right) where T : IComparable<T>
							{
								return (left.CompareTo(right) < 0).ToString();
							}

							string LessThanOrEqualTo<T>(T left, T right) where T : IComparable<T>
							{
								return (left.CompareTo(right) < 0 || left.Equals(right)).ToString();
							}

							string GreaterThan<T>(T left, T right) where T : IComparable<T>
							{
								return (left.CompareTo(right) > 0).ToString();
							}

							string GreaterThanOrEqualTo<T>(T left, T right) where T : IComparable<T>
							{
								return (left.CompareTo(right) > 0 || left.Equals(right)).ToString();
							}

							string NotEqualTo<T>(T left, T right) where T : IComparable<T>
							{
								return (!left.Equals(right)).ToString();
							}

							string EqualTo<T>(T left, T right) where T : IComparable<T>
							{
								return left.Equals(right).ToString();
							}

							string And<T>(T left, T right) where T : IComparable<T>
							{
								return (ConvertBool(left) && ConvertBool(right)).ToString();
							}

							string Or<T>(T left, T right) where T : IComparable<T>
							{
								return (ConvertBool(left) || ConvertBool(right)).ToString();
							}

							bool ConvertBool<T>(T value) where T : IComparable<T>
							{
								if (bool.TryParse(value.ToString(), out bool boolean))
								{
									return boolean;
								}
								else
								{
									var message = $"Couldn't convert {value} to its boolean equivalent.{Environment.NewLine}";
									throw new ArgumentException(message, nameof(value));
								}
							}
						}
					}

					ExpressionGroup GetHigestPrecedencePureExpression(string expression, OperatorGroup opGroup)
					{
						ExpressionGroup expGroup;
						Operator op = Operator.Null;

						// TODO: Maybe a better way to do this?
						arithmetic.SetDelimiterRange(DelimiterOperandType.Boolean);
						string leftOperand = GetLeftBooleanOperand(expression, opGroup.Location);
						string rightOperand = GetRightBooleanOperand(expression, opGroup.Location, opGroup.Value.Length);
						arithmetic.SetDelimiterRange(DelimiterOperandType.Math);

						op = arithmetic.GetOperator(opGroup.Value);
						expGroup = new ExpressionGroup
						{
							LeftOperand = leftOperand,
							RightOperand = rightOperand,
							ExpressionOperator = op,
							ExpressionType = ArithmeticType.Boolean
						};

						return expGroup;

						string GetLeftBooleanOperand(string expression, int index)
						{
							string leftHalf = expression.Substring(0, index);
							int start = int.MinValue;
							int dIndex = int.MinValue;
							var Delimiters = arithmetic.GetBooleanDelimiters().ToList();
							for (int i = 0; i < Delimiters.Count(); i++)
							{
								int selection = leftHalf.LastIndexOfOutsideQuotes(Delimiters.ElementAt(i));
								if (selection > start && selection != -1)
								{
									start = selection;
									dIndex = i;
								}
							}

							if (start == int.MinValue)
							{
								start = 0;
							}
							else
							{
								start += Delimiters.ElementAt(dIndex).Length;
							}

							if (index > leftHalf.Length)
							{
								var message = $"Couldn't get left operand for expression {leftHalf} using operand {expression[index]}.";
								throw new ArgumentException(message, nameof(expression));
							}

							return leftHalf.Substring(start, index - start);
						}

						string GetRightBooleanOperand(string expression, int index, int opLength)
						{
							string rightHalf = expression.Substring(index + opLength);
							int end = int.MaxValue;
							var Delimiters = arithmetic.GetBooleanDelimiters().ToList();
							for (int i = 0; i < Delimiters.Count(); i++)
							{
								int selection = rightHalf.IndexOfOutsideQuotes(Delimiters.ElementAt(i));
								if (selection < end && selection != -1)
								{
									end = selection;
								}
							}
							if (end == int.MaxValue)
							{
								end = rightHalf.Length;
							}

							if (end > rightHalf.Length)
							{
								var message = $"Couldn't get right operand for expression {rightHalf} using operand {expression[index]}.";
								throw new ArgumentException(message, nameof(expression));
							}

							return rightHalf.Substring(0, end);
						}
					}
				}
			}

			ExpressionResult EvaluateMathStringExpression(string expression)
			{
				arithmetic.SetDelimiterRange(DelimiterOperandType.Math);

				string result = SolvePrecedence(expression, new[] { "*", "/", "%" });
				result = SolvePrecedence(result, new[] { "-", "+" });
				var ExpressionVarType = arithmetic.GetVarType(result);

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = ExpressionVarType
				};

				return expResult;

				string SolvePrecedence(string expression, IEnumerable<string> delimiters)
				{
					string result = expression;

					var opGroup = arithmetic.GetFirstSelection(expression, delimiters);

					while (opGroup.Location != int.MinValue)
					{
						var expGroup = GetHigestPrecedencePureExpression(result, opGroup);
						string answer = null;
						var expResult = new ExpressionResult { Value = null, Type = VarType.Null };
						if (expGroup.ExpressionType == ArithmeticType.Math)
						{
							expResult = SolveMathExpression(expGroup);
						}
						else if (expGroup.ExpressionType == ArithmeticType.String)
						{
							expResult = SolveStringExpression(expGroup);
						}

						answer = expResult.Value;
						ExpressionVarType = expResult.Type;

						result = result.ReplaceFirst(expGroup.Combine(), answer);
						opGroup = arithmetic.GetFirstSelection(result, delimiters);
					}

					return result;

					ExpressionResult SolveMathExpression(ExpressionGroup expGroup)
					{
						string result = null;
						var Left = new Operand
						{
							Value = expGroup.LeftOperand,
							Type = arithmetic.GetVarType(expGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = arithmetic.GetVarType(expGroup.RightOperand)
						};

						if (Left.Type == VarType.Float || Right.Type == VarType.Float) // floating point addition
						{
							float left = arithmetic.GetFloat(Left.Value), right = arithmetic.GetFloat(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}
						else // integer division
						{
							int left = arithmetic.GetInt(Left.Value), right = arithmetic.GetInt(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}

						var expResult = new ExpressionResult { Value = result, Type = UpdateVarType(Left.Type, Right.Type) };

						return expResult;

						VarType UpdateVarType(VarType leftOperandType, VarType rightOperandType)
						{
							if (leftOperandType == VarType.String || rightOperandType == VarType.String)
							{
								return VarType.String;
							}
							else if (leftOperandType == VarType.Boolean || rightOperandType == VarType.Boolean)
							{
								return VarType.Boolean;
							}
							else if (leftOperandType == VarType.Float || rightOperandType == VarType.Float)
							{
								return VarType.Float;
							}
							else if (leftOperandType == VarType.Int || rightOperandType == VarType.Int)
							{
								return VarType.Int;
							}

							return VarType.Null;
						}

						string GetAnswer<T>(T left, T right, Operator op)
						{
							switch (op)
							{
								case Operator.Addition:
									return Addition(left, right);
								case Operator.Division:
									return Divide(left, right);
								case Operator.Modulus:
									return Modulus(left, right);
								case Operator.Multiplication:
									return Multiply(left, right);
								case Operator.Subtraction:
									return Subtraction(left, right);
								default:
									return null;
							}

							string Addition<T>(T left, T right) { dynamic temp = left; temp += right; return temp.ToString(); }
							string Multiply<T>(T left, T right) { dynamic temp = left; temp *= right; return temp.ToString(); }
							string Divide<T>(T left, T right) { dynamic temp = left; temp /= right; return temp.ToString(); }
							string Modulus<T>(T left, T right) { dynamic temp = left; temp %= right; return temp.ToString(); }
							string Subtraction<T>(T left, T right) { dynamic temp = left; temp -= right; return temp.ToString(); }
						}
					}

					ExpressionResult SolveStringExpression(ExpressionGroup expGroup)
					{
						var Left = new Operand
						{
							Value = expGroup.LeftOperand,
							Type = arithmetic.GetVarType(expGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = arithmetic.GetVarType(expGroup.RightOperand)
						};

						string answer = null;
						Left.Value = TrimOperand(Left.Value);
						Right.Value = TrimOperand(Right.Value);
						if (expGroup.ExpressionOperator == Operator.Addition)
						{
							answer = Addition(Left.Value, Right.Value);
						}
						else if (expGroup.ExpressionOperator == Operator.Multiplication)
						{
							int number = int.MinValue;
							string expression = null;
							if (Left.Type == VarType.Int || Left.Type == VarType.Float)
							{
								number = arithmetic.GetInt(Left.Value);
								expression = Right.Value;
							}
							else if (Right.Type == VarType.Int || Right.Type == VarType.Float)
							{
								number = arithmetic.GetInt(Right.Value);
								expression = Left.Value;
							}
							answer = Multiply(number, expression);
						}

						var result = new StringBuilder("\"").Append(answer).Append("\"");
						ExpressionResult expResult = new ExpressionResult
						{
							Value = result.ToString(),
							Type = VarType.String
						};

						return expResult;

						string Addition(string left, string right)
						{
							return left + right;
						}

						string Multiply(int multiplier, string expression)
						{
							StringBuilder result = new StringBuilder();
							for (int i = 0; i < multiplier; i++)
							{
								result.Append(expression);
							}

							return result.ToString();
						}

						string TrimOperand(string operand)
						{
							string result = operand;
							if (operand[0] == '"')
							{
								result = result.Trim('"');
							}
							return result;
						}
					}

					ExpressionGroup GetHigestPrecedencePureExpression(string expression, OperatorGroup opGroup)
					{
						ExpressionGroup expGroup;
						string leftOperand = null, rightOperand = null;
						Operator op = Operator.Null;

						var arGroup = GetOperandTypes(expression, opGroup.Location);

						if (arGroup.LeftType == ArithmeticType.String)
						{
							leftOperand = GetLeftStringOperand(expression, opGroup.Location);
						}
						else if (arGroup.LeftType == ArithmeticType.Math)
						{
							leftOperand = GetLeftMathOperand(expression, opGroup.Location);
						}
						else if (arGroup.LeftType == ArithmeticType.None)
						{
							var message = $"Left Operand Arithmetic Type not found for expression {expression}.{Environment.NewLine}Operator: {opGroup.Value}. Operator Location: {opGroup.Location}.{Environment.NewLine}";
							throw new ArgumentException(message, nameof(expression));
						}

						if (arGroup.RightType == ArithmeticType.String)
						{
							rightOperand = GetRightStringOperand(expression, opGroup.Location);
						}
						else if (arGroup.RightType == ArithmeticType.Math)
						{
							rightOperand = GetRightMathOperand(expression, opGroup.Location);
						}
						else if (arGroup.RightType == ArithmeticType.None)
						{
							var message = $"Right Operand Arithmetic Type not found for expression {expression}.{Environment.NewLine}Operator: {opGroup.Value}. Operator Location: {opGroup.Location}.{Environment.NewLine}";
							throw new ArgumentException(message, nameof(expression));
						}

						op = arithmetic.GetOperator(opGroup.Value);
						expGroup = new ExpressionGroup
						{
							LeftOperand = leftOperand,
							RightOperand = rightOperand,
							ExpressionOperator = op,
							ExpressionType = arGroup.ExpressionType
						};

						return expGroup;

						ArithmeticGroup GetOperandTypes(string expression, int opIndex)
						{
							var leftType = ArithmeticType.None;
							var rightType = ArithmeticType.None;
							var expType = ArithmeticType.None;

							if (expression[opIndex - 1] == '"')
							{
								leftType = ArithmeticType.String;
							}
							else
							{
								leftType = ArithmeticType.Math;
							}

							if (expression[opIndex + 1] == '"')
							{
								rightType = ArithmeticType.String;
							}
							else
							{
								rightType = ArithmeticType.Math;
							}

							if (leftType == ArithmeticType.String || rightType == ArithmeticType.String)
							{
								expType = ArithmeticType.String;
							}
							else if (leftType == ArithmeticType.Math && rightType == ArithmeticType.Math)
							{
								expType = ArithmeticType.Math;
							}

							if (leftType == ArithmeticType.None)
							{
								var message = $"Couldn't find Arithmetic Type for left operand for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}
							else if (rightType == ArithmeticType.None)
							{
								var message = $"Couldn't find Arithmetic Type for right operand for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}
							else if (expType == ArithmeticType.None)
							{
								var message = $"Couldn't find Arithmetic Type for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}

							var arGroup = new ArithmeticGroup
							{
								LeftType = leftType,
								RightType = rightType,
								ExpressionType = expType,
							};

							return arGroup;
						}

						string GetRightMathOperand(string expression, int index)
						{
							string result = "";
							int start = index + 1, opIndex = index + 1;
							if (expression[start] == '-') { start++; result += '-'; }
							var Delimiters = arithmetic.GetMathDelimiters().ToList();
							for (int i = start; i < expression.Length; i++)
							{
								for (int j = 0; j < Delimiters.Count(); j++)
								{
									char delimStart = Delimiters.ElementAt(j)[0];
									if (expression[i] == delimStart)
									{
										if (CheckDelimiterForRight(i, Delimiters.ElementAt(j), expression))
										{
											if (i > expression.Length)
											{
												var message = $"Couldn't get right operand for expression {expression} using operand {expression[index]}.";
												throw new ArgumentException(message, nameof(expression));
											}
											return expression.Substring(opIndex, i - opIndex);
										}
									}
								}
							}
							if (result == "" || result == "-") { result = expression.Substring(opIndex); }

							return result;

							bool CheckDelimiterForRight(int index, string delimiter, string expression)
							{
								if (index > 0 && expression.Length > index + delimiter.Length)
								{
									var str = expression.Substring(index, delimiter.Length);
									return str == delimiter;
								}
								else
								{
									return false;
								}
							}
						}

						string GetRightStringOperand(string expression, int index)
						{
							string result = null;
							int start = index + 1, quoteCount = 0;
							char curQuote = char.MinValue;

							for (int i = start; i < expression.Length; i++)
							{
								if (expression.CheckQuotes(i, curQuote))
								{
									if (quoteCount == 0) { curQuote = expression[i]; }
									quoteCount++;
									if (quoteCount == 2)
									{
										if (i + 1 > expression.Length)
										{
											var message = $"Couldn't get right operand for expression {expression} using operand {expression[index]}.";
											throw new ArgumentException(message, nameof(expression));
										}
										result = expression.Substring(start, (i + 1) - start);
									}
								}
							}
							if (result == null) { result = expression.Substring(start); }
							return result.Trim();
						}

						string GetLeftStringOperand(string expression, int index)
						{
							string result = null;
							int start = index - 1, quoteCount = 0;
							char curQuote = char.MinValue;
							for (int i = start; i >= 0; i--)
							{
								if (expression.CheckQuotes(i, curQuote))
								{
									curQuote = expression[i];
									quoteCount++;
									if (quoteCount == 2)
									{
										if (index > expression.Length)
										{
											var message = $"Couldn't get right operand for expression {expression} using operand {expression[index]}.";
											throw new ArgumentException(message, nameof(expression));
										}
										result = expression.Substring(i, index - i);
									}
								}
							}
							if (result == null) { result = expression.Substring(0, index); }

							return result.Trim();
						}

						string GetLeftMathOperand(string expression, int index)
						{
							string result = "";
							int start = index - 1;
							var Delimiters = arithmetic.GetMathDelimiters().ToList();
							for (int i = start; i >= 0; i--)
							{
								for (int j = 0; j < Delimiters.Count(); j++)
								{
									char delimEnd = Delimiters.ElementAt(j).Last();
									if (expression[i] == delimEnd)
									{
										if (CheckDelimiterForLeft(i, Delimiters.ElementAt(j), expression))
										{
											int startSubstringIndex = i + 1, substringLength = start - i;
											if (i != 0)
											{
												if (CheckDelimiter(expression[i - 1], Delimiters, expression, i - 1)) // the one after the negative is an operator
												{
													startSubstringIndex = i; // then include the negative, otherwise default to normal i + 1
													substringLength++;
												}
											}
											else if (i == 0 || expression[i] == '-')
											{
												startSubstringIndex = i;
												substringLength++;
											}

											if (substringLength > expression.Length - startSubstringIndex)
											{
												var message = $"Couldn't get right operand for expression {expression} using operand {expression[index]}.";
												throw new ArgumentException(message, "expression");
											}

											return expression.Substring(startSubstringIndex, substringLength);
										}
									}
								}
							}
							if (result == "")
							{
								result = expression.Substring(0, index);
							}

							return result;

							bool CheckDelimiter(char ch, IEnumerable<string> delimiters, string expression, int opIndex)
							{
								bool result = false;
								for (int i = 0; i < Delimiters.Count(); i++)
								{
									char delimEnd = delimiters.ElementAt(i).Last();
									if (ch == delimEnd)
									{
										if (CheckDelimiterForLeft(opIndex, delimiters.ElementAt(i), expression))
										{
											result = true;
											break;
										}
									}
								}

								return result;
							}

							bool CheckDelimiterForLeft(int index, string delimiter, string expression)
							{
								int start = index - (delimiter.Length - 1);
								if (start >= 0 && expression.Length > start + delimiter.Length)
								{
									string result = expression.Substring(start, delimiter.Length);
									return result == delimiter;
								}
								else
								{
									return false;
								}
							}
						}

					}
				}
			}
		}
	}
}
