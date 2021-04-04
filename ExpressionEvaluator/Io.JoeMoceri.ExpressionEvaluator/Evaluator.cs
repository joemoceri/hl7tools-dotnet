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

	public class Evaluator : IEvaluator
	{
		public readonly IEnumerable<string> MathDelimiters = new[] { "+", "-", "*", "/", "%" };
		public readonly IEnumerable<string> BooleanDelimiters = new[] { "<=", ">=", "!=", "==", "&&", "||", "and", "or", ">", "<" };

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

				// handle implicit negative. an implicit negative is -1 or -(1)
				expression = expression.Replace("-(", ("-1*("));

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
				var expressionType = GetExpressionType(expression);

				// get the boolean evaluated result
				if (expressionType == ExpressionType.Boolean)
				{
					result = EvaluateBooleanExpression(expression);
				}
				// get the math (same as string) evaluated result
				else if (expressionType == ExpressionType.MathString)
				{
					result = EvaluateMathStringExpression(expression);
				}
				// not a valid expression
				else if (expressionType == ExpressionType.Invalid)
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
					Type = null, 
					Error = ex 
				};	
			}

			return result;

			ExpressionType GetExpressionType(string expression)
			{
				// is the expression boolean?
				var operators = new[] { ">", ">=", "<", "<=", "==", "!=", "&&", "||", "and", "or", "False", "True" };
				for (int i = 0; i < operators.Length; i++)
				{
					if (IndexOfOutsideQuotes(expression, operators[i]) != -1)
					{
						return ExpressionType.Boolean;
					}
				}

				// or math?
				operators = new[] { "+", "-", "/", "%", "*", "\"" };
				for (int i = 0; i < operators.Length; i++)
				{
					if (IndexOfOutsideQuotes(expression, operators[i]) != -1)
					{
						return ExpressionType.MathString;
					}
				}

				if (int.TryParse(expression, out int integer) || float.TryParse(expression, out float floatingPointNumber))
				{
					return ExpressionType.MathString;
				}

				return ExpressionType.Invalid;
			}

			// Removing whitespace outside of quotes is necessary since expressions are still valid with infinite white space between operators and operands.
			string RemoveWhitespaceOutsideQuotes(string expression)
			{
				var result = new StringBuilder();

				// keep track of whether we're inside a quote (it's a user inputted string)
				var inQuote = false;
				var start = 0;
				var length = 0;
				char? currentQuote = null;

				for (int i = 0; i < expression.Length; i++)
				{
					// did it run into a quote?
					if (QuoteMatched(expression, i, currentQuote))
					{
						// set the current quote
						currentQuote = expression[i];

						// if it's not inside a quoted string, set the start and length
						if (!inQuote)
						{
							start = i; 
							length = 0;
						}
						// if it's inside a quoted string, grab it and add it to the result. Do it this way to not remove whitespace from quoted strings
						else
						{
							length = (i + 1) - start; // + 1 to get the extra quote

							// grab the quoted string, add it, reset the process
							var quotedString = expression.Substring(start, length);
							result.Append(quotedString);
							currentQuote = null;
						}

						// invert it
						inQuote = !inQuote;
					}
					// if we're not in a quote, and it's not white space, add the character to the final result
					else if (expression[i] != ' ' && !inQuote)
					{
						result.Append(expression[i]);
					}
				}

				return result.ToString();
			}

			int GetCharCount(string original, char ch)
			{
				int result = 0;
				bool inQuote = false;
				char? currentQuote = null;

				for (int i = 0; i < original.Length; i++)
				{
					if (QuoteMatched(original, i, currentQuote))
					{
						currentQuote = original[i];
						inQuote = !inQuote;
						if (!inQuote) 
						{ 
							currentQuote = null;
						}

						if (currentQuote == ch) 
						{ 
							result++; 
						}
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
				// get the starting point
				var start = IndexOfOutsideQuotes(expression, "(") + 1;

				// how far this set of parentheses goes
				var length = GetParentheticalLength(expression); // always default to non same level

				// invalid length
				if (length > expression.Length || start == 0)
				{
					var message = $"Couldn't get parenthetical expression for {expression}.";
					throw new ArgumentException(message, nameof(expression));
				}

				// get the expression inside this set of parentheses
				var outer = expression.Substring(start, length - start);

				// then, take the result of evaluating that inner expression, and replace it's original representation with the new result, and keep doing that until there's no parentheses, and read it left-to-right
				return ReplaceExpressionWithResult(expression, "(" + outer + ")", action(outer).Value);

				int GetParentheticalLength(string str)
				{
					int result = 0, leftCount = 0;
					char? currentQuote = null;
					bool inQuote = false;
					for (int i = 0; i < str.Length; i++)
					{
						if (QuoteMatched(str, i, currentQuote))
						{
							currentQuote = str[i];
							inQuote = !inQuote;
						}
						if (!inQuote)
						{
							if (str[i] == '(') 
							{
								leftCount++; 
							}
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
				var higherPrecedenceOperators = new[] { "<=", ">=", "==", "!=", "<", ">", };
				var result = SolveExpressionPrecedence(expression, higherPrecedenceOperators);
				var lowerPrecedenceOperators = new[] { "&&", "||", "and", "or" };
				result = SolveExpressionPrecedence(result, lowerPrecedenceOperators);

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = VarType.Boolean
				};

				return expResult;

				string SolveExpressionPrecedence(string expression, IEnumerable<string> precedenceOperators)
				{
					// start with the expression
					var result = expression;

					// get the next operator group. A group is a value of the operator and it's location in the current expression (result)
					var operatorGroup = GetNextOperatorGroup(result, precedenceOperators);

					// the default value is int.MinValue
					while (operatorGroup.Location != int.MinValue)
					{
						var expressionGroup = GetNextPrecedenceExpressionGroup(result, operatorGroup);

						var originalLeft = expressionGroup.LeftOperand;
						var originalRight = expressionGroup.RightOperand;

						var leftResult = EvaluateMathStringExpression(expressionGroup.LeftOperand);
						expressionGroup.LeftOperand = leftResult.Value;
						
						var rightResult = EvaluateMathStringExpression(expressionGroup.RightOperand);
						expressionGroup.RightOperand = rightResult.Value;

						string answer = null;
						var expResult = SolveBooleanExpression(expressionGroup);

						answer = expResult.Value;

						expressionGroup.LeftOperand = originalLeft;
						expressionGroup.RightOperand = originalRight;

						result = ReplaceExpressionWithResult(result, expressionGroup.Combine(), answer);
						operatorGroup = GetNextOperatorGroup(result, precedenceOperators);
					}

					return result;

					ExpressionResult SolveBooleanExpression(ExpressionGroup expGroup)
					{
						var Left = new Operand
						{
							Value = expGroup.LeftOperand,
							Type = GetVarType(expGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = GetVarType(expGroup.RightOperand)
						};

						string result;
						if (Left.Type == VarType.Float || Right.Type == VarType.Float) // floating point addition
						{
							float left = GetFloat(Left.Value), right = GetFloat(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}
						else if (Left.Type == VarType.Int && Right.Type == VarType.Int) // integer division
						{
							int left = GetInt(Left.Value), right = GetInt(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}
						else
						{ // Boolean and string 
							result = GetAnswer(Left.Value, Right.Value, expGroup.ExpressionOperator);
						}

						var expResult = new ExpressionResult 
						{
							Value = result, 
							Type = VarType.Boolean 
						};

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

							string LessThan(T left, T right)
							{
								return (left.CompareTo(right) < 0).ToString();
							}

							string LessThanOrEqualTo(T left, T right)
							{
								return (left.CompareTo(right) < 0 || left.Equals(right)).ToString();
							}

							string GreaterThan(T left, T right)
							{
								return (left.CompareTo(right) > 0).ToString();
							}

							string GreaterThanOrEqualTo(T left, T right)
							{
								return (left.CompareTo(right) > 0 || left.Equals(right)).ToString();
							}

							string NotEqualTo(T left, T right)
							{
								return (!left.Equals(right)).ToString();
							}

							string EqualTo(T left, T right)
							{
								return left.Equals(right).ToString();
							}

							string And(T left, T right)
							{
								return (ConvertBool(left) && ConvertBool(right)).ToString();
							}

							string Or(T left, T right)
							{
								return (ConvertBool(left) || ConvertBool(right)).ToString();
							}

							bool ConvertBool(T value)
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

					ExpressionGroup GetNextPrecedenceExpressionGroup(string expression, OperatorGroup opGroup)
					{
						ExpressionGroup expGroup;
						Operator op = Operator.Null;

						string leftOperand = GetLeftBooleanOperand(expression, opGroup.Location);
						string rightOperand = GetRightBooleanOperand(expression, opGroup.Location, opGroup.Value.Length);

						op = GetOperator(opGroup.Value);
						expGroup = new ExpressionGroup
						{
							LeftOperand = leftOperand,
							RightOperand = rightOperand,
							ExpressionOperator = op,
							ExpressionType = ArithmeticOperandType.Boolean
						};

						return expGroup;

						string GetLeftBooleanOperand(string expression, int index)
						{
							string leftHalf = expression.Substring(0, index);
							int start = int.MinValue;
							int dIndex = int.MinValue;
							var Delimiters = BooleanDelimiters.ToList();
							for (int i = 0; i < Delimiters.Count(); i++)
							{
								int selection = LastIndexOfOutsideQuotes(leftHalf, Delimiters.ElementAt(i));
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
							var Delimiters = BooleanDelimiters.ToList();
							for (int i = 0; i < Delimiters.Count(); i++)
							{
								int selection = IndexOfOutsideQuotes(rightHalf, Delimiters.ElementAt(i));
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
				string result = SolvePrecedence(expression, new[] { "*", "/", "%" });
				result = SolvePrecedence(result, new[] { "-", "+" });

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = GetVarType(result)
				};

				return expResult;

				string SolvePrecedence(string expression, IEnumerable<string> delimiters)
				{
					string result = expression;

					var opGroup = GetNextOperatorGroup(expression, delimiters);

					while (opGroup.Location != int.MinValue)
					{
						var expGroup = GetHigestPrecedencePureExpression(result, opGroup);
						string answer = null;
						var expResult = new ExpressionResult { Value = null, Type = VarType.Null };
						if (expGroup.ExpressionType == ArithmeticOperandType.Math)
						{
							expResult = SolveMathExpression(expGroup);
						}
						else if (expGroup.ExpressionType == ArithmeticOperandType.String)
						{
							expResult = SolveStringExpression(expGroup);
						}

						answer = expResult.Value;

						result = ReplaceExpressionWithResult(result, expGroup.Combine(), answer);
						opGroup = GetNextOperatorGroup(result, delimiters);
					}

					return result;

					ExpressionResult SolveMathExpression(ExpressionGroup expGroup)
					{
						string result = null;
						var Left = new Operand
						{
							Value = expGroup.LeftOperand,
							Type = GetVarType(expGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = GetVarType(expGroup.RightOperand)
						};

						if (Left.Type == VarType.Float || Right.Type == VarType.Float) // floating point addition
						{
							float left = GetFloat(Left.Value), right = GetFloat(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}
						else // integer division
						{
							int left = GetInt(Left.Value), right = GetInt(Right.Value);
							result = GetAnswer(left, right, expGroup.ExpressionOperator);
						}

						var expResult = new ExpressionResult 
						{ 
							Value = result, 
							Type = UpdateVarType(Left.Type, Right.Type) 
						};

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

							string Addition(T left, T right) 
							{ 
								dynamic temp = left; 
								temp += right; 
								return temp.ToString(); 
							}

							string Multiply(T left, T right) 
							{
								dynamic temp = left; 
								temp *= right; 
								return temp.ToString(); 
							}

							string Divide(T left, T right) 
							{ 
								dynamic temp = left; 
								temp /= right; 
								return temp.ToString(); 
							}

							string Modulus(T left, T right) 
							{ 
								dynamic temp = left; 
								temp %= right; 
								return temp.ToString(); 
							}

							string Subtraction(T left, T right) 
							{ 
								dynamic temp = left; 
								temp -= right; 
								return temp.ToString(); 
							}
						}
					}

					ExpressionResult SolveStringExpression(ExpressionGroup expGroup)
					{
						var Left = new Operand
						{
							Value = expGroup.LeftOperand,
							Type = GetVarType(expGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = GetVarType(expGroup.RightOperand)
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
								number = GetInt(Left.Value);
								expression = Right.Value;
							}
							else if (Right.Type == VarType.Int || Right.Type == VarType.Float)
							{
								number = GetInt(Right.Value);
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
							var result = new StringBuilder();
							for (int i = 0; i < multiplier; i++)
							{
								result.Append(expression);
							}

							return result.ToString();
						}

						string TrimOperand(string operand)
						{
							var result = operand;
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

						if (arGroup.LeftType == ArithmeticOperandType.String)
						{
							leftOperand = GetLeftStringOperand(expression, opGroup.Location);
						}
						else if (arGroup.LeftType == ArithmeticOperandType.Math)
						{
							leftOperand = GetLeftMathOperand(expression, opGroup.Location);
						}
						else if (arGroup.LeftType == ArithmeticOperandType.None)
						{
							var message = $"Left Operand Arithmetic Type not found for expression {expression}.{Environment.NewLine}Operator: {opGroup.Value}. Operator Location: {opGroup.Location}.{Environment.NewLine}";
							throw new ArgumentException(message, nameof(expression));
						}

						if (arGroup.RightType == ArithmeticOperandType.String)
						{
							rightOperand = GetRightStringOperand(expression, opGroup.Location);
						}
						else if (arGroup.RightType == ArithmeticOperandType.Math)
						{
							rightOperand = GetRightMathOperand(expression, opGroup.Location);
						}
						else if (arGroup.RightType == ArithmeticOperandType.None)
						{
							var message = $"Right Operand Arithmetic Type not found for expression {expression}.{Environment.NewLine}Operator: {opGroup.Value}. Operator Location: {opGroup.Location}.{Environment.NewLine}";
							throw new ArgumentException(message, nameof(expression));
						}

						op = GetOperator(opGroup.Value);
						expGroup = new ExpressionGroup
						{
							LeftOperand = leftOperand,
							RightOperand = rightOperand,
							ExpressionOperator = op,
							ExpressionType = arGroup.ExpressionType
						};

						return expGroup;

						ExpressionTypesGroup GetOperandTypes(string expression, int opIndex)
						{
							var leftType = ArithmeticOperandType.None;
							var rightType = ArithmeticOperandType.None;
							var expType = ArithmeticOperandType.None;

							if (expression[opIndex - 1] == '"')
							{
								leftType = ArithmeticOperandType.String;
							}
							else
							{
								leftType = ArithmeticOperandType.Math;
							}

							if (expression[opIndex + 1] == '"')
							{
								rightType = ArithmeticOperandType.String;
							}
							else
							{
								rightType = ArithmeticOperandType.Math;
							}

							if (leftType == ArithmeticOperandType.String || rightType == ArithmeticOperandType.String)
							{
								expType = ArithmeticOperandType.String;
							}
							else if (leftType == ArithmeticOperandType.Math && rightType == ArithmeticOperandType.Math)
							{
								expType = ArithmeticOperandType.Math;
							}

							if (leftType == ArithmeticOperandType.None)
							{
								var message = $"Couldn't find Arithmetic Type for left operand for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}
							else if (rightType == ArithmeticOperandType.None)
							{
								var message = $"Couldn't find Arithmetic Type for right operand for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}
							else if (expType == ArithmeticOperandType.None)
							{
								var message = $"Couldn't find Arithmetic Type for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}

							var arGroup = new ExpressionTypesGroup
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
							if (expression[start] == '-') 
							{
								start++; 
								result += '-'; 
							}

							var Delimiters = MathDelimiters.ToList();
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

							if (result == "" || result == "-") 
							{
								result = expression.Substring(opIndex); 
							}

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
							char? currentQuote = null;

							for (int i = start; i < expression.Length; i++)
							{
								if (QuoteMatched(expression, i, currentQuote))
								{
									if (quoteCount == 0) 
									{
										currentQuote = expression[i]; 
									}
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

							if (result == null) 
							{
								result = expression.Substring(start); 
							}

							return result.Trim();
						}

						string GetLeftStringOperand(string expression, int index)
						{
							string result = null;
							int start = index - 1, quoteCount = 0;
							char? currentQuote = null;
							for (int i = start; i >= 0; i--)
							{
								if (QuoteMatched(expression, i, currentQuote))
								{
									currentQuote = expression[i];
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

							if (result == null) 
							{ 
								result = expression.Substring(0, index); 
							}

							return result.Trim();
						}

						string GetLeftMathOperand(string expression, int index)
						{
							string result = "";
							int start = index - 1;
							var Delimiters = MathDelimiters.ToList();
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

			OperatorGroup GetNextOperatorGroup(string expression, IEnumerable<string> delimiters)
			{
				string result = null;
				int min = int.MaxValue, index = int.MinValue;
				bool isNegative = false;

				if (expression[0] == '-')
				{
					if (expression.Length < 2)
					{
						var message = $"Couldn't find operand for expression {expression}.";
						throw new ArgumentException(message, nameof(expression));
					}
					expression = expression.Substring(1); isNegative = true;
				}

				for (int i = 0; i < delimiters.Count(); i++)
				{
					int selection = IndexOfOutsideQuotes(expression, delimiters.ElementAt(i));
					if (selection == -1) 
					{
						continue; 
					}
					if (min > selection)
					{
						min = selection;
						result = delimiters.ElementAt(i).ToString();
						index = isNegative ? selection + 1 : selection;
					}
				}

				var opGroup = new OperatorGroup { Value = result, Location = index };

				return opGroup;
			}

			VarType GetVarType(string expression)
			{
				if (int.TryParse(expression, out int tempInteger))
				{
					return VarType.Int;
				}
				else if (float.TryParse(expression, out float tempFloat))
				{
					return VarType.Float;
				}
				else if (expression[0] == '"' && expression[expression.Length - 1] == '"')
				{
					return VarType.String;
				}
				else if (expression == "True" || expression == "False")
				{
					return VarType.Boolean;
				}
				else
				{
					var message = $"Variable Type not found for expression {expression}.";
					throw new ArgumentException(message, nameof(expression));
				}
			}

			Operator GetOperator(string op)
			{
				Operator result = Operator.Null;
				switch (op)
				{
					case "+":
						result = Operator.Addition;
						break;
					case "-":
						result = Operator.Subtraction;
						break;
					case "*":
						result = Operator.Multiplication;
						break;
					case "/":
						result = Operator.Division;
						break;
					case "%":
						result = Operator.Modulus;
						break;
					case "<":
						result = Operator.LessThan;
						break;
					case "<=":
						result = Operator.LessThanOrEqualTo;
						break;
					case ">":
						result = Operator.GreaterThan;
						break;
					case ">=":
						result = Operator.GreaterThanOrEqualTo;
						break;
					case "!=":
						result = Operator.NotEqualTo;
						break;
					case "==":
						result = Operator.EqualTo;
						break;
					case "&&":
						result = Operator.And;
						break;
					case "||":
						result = Operator.Or;
						break;
					case "and":
						result = Operator.And;
						break;
					case "or":
						result = Operator.Or;
						break;
				}
				if (result == Operator.Null)
				{
					var message = $"Operator not found for {op}.";
					throw new ArgumentException(message, nameof(op));
				}

				return result;
			}

			float GetFloat(string expression)
			{
				if (!float.TryParse(expression, out float result))
				{
					var message = $"Could not parse float for {expression}.";
					throw new FormatException(message);
				}

				return result;
			}

			int GetInt(string expression)
			{
				if (!int.TryParse(expression, out int result))
				{
					var message = $"Could not parse int for {expression}.";
					throw new FormatException(message);
				}

				return result;
			}

			bool QuoteMatched(string expression, int index, char? currentQuote)
			{
				// get the current character
				var currentCharacter = expression[index];

				// get the previous character, if any
				char? previousCharacter = index - 1 >= 0 ? expression[index - 1] : null;

				// is it prepended by an escape backslash?
				if (previousCharacter != null && previousCharacter == '\\')
				{
					return false; // skip over escaped quotes
				}
				// the current quote doesn't exist? check if it's a double quote
				else if (currentQuote == null)
				{
					return currentCharacter == '"'; // || currentCharacter == '\''; // default
				}

				// otherwise check if the current character is equal to the current quote, single or double
				return currentCharacter == currentQuote;
			}

			string ReplaceExpressionWithResult(string expression, string expressionSearchingFor, string expressionResultToReplace)
			{
				// nothing to do
				if (expressionSearchingFor == null || expressionResultToReplace == null || expression == null)
				{
					return null;
				}

				// get the start and end points
				var startPoint = expression.IndexOf(expressionSearchingFor);
				var endPoint = startPoint + expressionSearchingFor.Length;

				// nothing found
				if (startPoint < 0)
				{
					return expression;
				}

				// get everything before the searching strings starting point, add it to the new replace, and append everything after the searching strings ending point
				return expression.Substring(0, startPoint) + expressionResultToReplace + expression.Substring(endPoint);
			}

			int IndexOfOutsideQuotes(string expression, string searchingFor)
			{
				var result = -1;
				var searchIndex = 0;
				var inQuote = false;
				char? currentQuote = null;

				for (int i = 0; i < expression.Length; i++)
				{
					if (QuoteMatched(expression, i, currentQuote))
					{
						currentQuote = expression[i];
						inQuote = !inQuote;
						searchIndex = 0;
						if (!inQuote) 
						{
							currentQuote = null; 
						}
					}
					if (!inQuote)
					{
						if (expression[i] == searchingFor[searchIndex])
						{
							if (searchIndex == searchingFor.Length - 1)
							{
								result = i - (searchingFor.Length - 1);
								break;
							}
							searchIndex++;
						}
						else
						{
							searchIndex = 0;
						}
					}
				}

				return result;
			}

			int LastIndexOfOutsideQuotes(string expression, string searchingFor)
			{
				var result = -1;
				var searchIndex = searchingFor.Length - 1;
				var inQuote = false;
				char? currentQuote = null;

				for (int i = expression.Length - 1; i >= 0; i--)
				{
					if (QuoteMatched(expression, i, currentQuote))
					{
						currentQuote = expression[i];
						inQuote = !inQuote;
						searchIndex = 0;
						if (!inQuote) 
						{
							currentQuote = null; 
						}
					}
					if (!inQuote)
					{
						if (expression[i] == searchingFor[searchIndex])
						{
							if (searchIndex == 0)
							{
								result = i;
								break;
							}
							searchIndex--;
						}
						else
						{
							searchIndex = searchingFor.Length - 1;
						}
					}
				}

				return result;
			}
		}
	}
}
