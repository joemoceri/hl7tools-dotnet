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
		public readonly IEnumerable<string> MathOperators = new[] { "+", "-", "*", "/", "%" };
		public readonly IEnumerable<string> BooleanOperators = new[] { "<=", ">=", "!=", "==", "&&", "||", "and", "or", ">", "<" };

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
						Type = VariableType.Null 
					}; 
				};

				// get the whitespace outside of quotes out of the way
				expression = RemoveWhitespaceOutsideQuotes(expression);

				// handle implicit negative. an implicit negative is -1 or -(1)
				expression = expression.Replace("-(", ("-1*("));

				int parenthesesAmount = GetCharacterCount(expression, '(') + GetCharacterCount(expression, ')');
				int doubleQuoteAmount = GetCharacterCount(expression, '"');

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
					parenthesesAmount = GetCharacterCount(expression, '(') + GetCharacterCount(expression, ')');
				}

				// determine what kind of expression it is (math, string, boolean)
				var inputExpressionType = GetInputExpressionType(expression);

				// get the boolean evaluated result
				if (inputExpressionType == InputExpressionType.Boolean)
				{
					result = EvaluateBooleanExpression(expression);
				}
				// get the math (same as string) evaluated result
				else if (inputExpressionType == InputExpressionType.MathString)
				{
					result = EvaluateMathStringExpression(expression);
				}
				// not a valid expression
				else if (inputExpressionType == InputExpressionType.Invalid)
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

            #region Pre
            InputExpressionType GetInputExpressionType(string expression)
			{
				// is the expression boolean?
				var operators = new[] { ">", ">=", "<", "<=", "==", "!=", "&&", "||", "and", "or", "False", "True" };
				for (int i = 0; i < operators.Length; i++)
				{
					if (IndexOfOutsideQuotes(expression, operators[i]) != -1)
					{
						return InputExpressionType.Boolean;
					}
				}

				// or math?
				operators = new[] { "+", "-", "/", "%", "*", "\"" };
				for (int i = 0; i < operators.Length; i++)
				{
					if (IndexOfOutsideQuotes(expression, operators[i]) != -1)
					{
						return InputExpressionType.MathString;
					}
				}

				if (int.TryParse(expression, out int integer) || float.TryParse(expression, out float floatingPointNumber))
				{
					return InputExpressionType.MathString;
				}

				return InputExpressionType.Invalid;
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
					if (FoundAQuote(expression, i, currentQuote))
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
					// if it's not in a quote, and it's not white space, add the character to the final result
					else if (expression[i] != ' ' && !inQuote)
					{
						result.Append(expression[i]);
					}
				}

				return result.ToString();
			}

			int GetCharacterCount(string expression, char characterSearchingFor)
			{
				var result = 0;
				var inQuote = false;
				char? currentQuote = null;

				for (int i = 0; i < expression.Length; i++)
				{
					// handle quotes
					if (FoundAQuote(expression, i, currentQuote))
					{
						currentQuote = expression[i];
						inQuote = !inQuote;
						if (!inQuote)
						{ 
							currentQuote = null;
						}

						if (currentQuote == characterSearchingFor)
						{ 
							result++; 
						}
					}

					// in a quote, skip iteration
					if (inQuote)
					{
						continue;
					}

					// was it found?
					if (expression[i] == characterSearchingFor)
					{
						result++;
					}
				}

				// let 'em know
				return result;
			}

			string GetOuterMostParentheticalExpression(string expression, Func<string, ExpressionResult> action)
			{
				// get the starting point
				var start = IndexOfOutsideQuotes(expression, "(") + 1;

				// how far this set of parentheses goes
				var length = GetParenthesesExpressionLength(expression); // always default to non same level

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

				int GetParenthesesExpressionLength(string expression)
				{
					var result = 0;
					var leftCount = 0;
					char? currentQuote = null;
					bool inQuote = false;

					for (var i = 0; i < expression.Length; i++)
					{
						// handle quotes
						if (FoundAQuote(expression, i, currentQuote))
						{
							currentQuote = expression[i];
							inQuote = !inQuote;
						}

						// in a quote, skip
						if (inQuote)
						{
							continue;
						}

						// get the length
						if (expression[i] == '(') 
						{
							leftCount++; 
						}
						else if (expression[i] == ')')
						{
							leftCount--;
							if (leftCount == 0)
							{
								result = i;
								break;
							}
						}
					}

					return result;
				}
			}
            #endregion

            ExpressionResult EvaluateBooleanExpression(string expression)
			{
				var higherPrecedenceOperators = new[] { "<=", ">=", "==", "!=", "<", ">", };
				var result = SolveExpressionPrecedence(expression, higherPrecedenceOperators);
				
				var lowerPrecedenceOperators = new[] { "&&", "||", "and", "or" };
				result = SolveExpressionPrecedence(result, lowerPrecedenceOperators);

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = VariableType.Boolean
				};

				return expResult;

				string SolveExpressionPrecedence(string expression, IEnumerable<string> precedenceOperators)
				{
					// start with the expression
					var result = expression;

					// get the next operator location. An operator location is a value of the operator and it's location in the current expression
					// this is used to build an expression group, the simplest form of an expression
					var operatorLocation = GetNextOperatorLocation(result, precedenceOperators);

					// if nothing is found, this is skipped, and the expression is returned.
					while (operatorLocation.Index != null)
					{
						var expressionGroup = GetNextExpressionGroup(result, operatorLocation);

						// store the originals to be able to copy over
						var originalLeft = expressionGroup.LeftOperand;
						var originalRight = expressionGroup.RightOperand;

						// boolean expressions broken down are composed of 2 math/string expressions that need to be evaluated (1>2, 1+2>3+4, etc)
						var leftResult = EvaluateMathStringExpression(expressionGroup.LeftOperand);
						expressionGroup.LeftOperand = leftResult.Value;
						
						var rightResult = EvaluateMathStringExpression(expressionGroup.RightOperand);
						expressionGroup.RightOperand = rightResult.Value;

						// then, after updating those values, solve THAT boolean expression
						var expResult = SolveBooleanExpressionGroup(expressionGroup);

						// get the answer
						var answer = expResult.Value;

						// reset the values
						expressionGroup.LeftOperand = originalLeft;
						expressionGroup.RightOperand = originalRight;

						// replace the original result with the new computed result
						result = ReplaceExpressionWithResult(result, expressionGroup.Combine(), answer);

						// any more left?
						operatorLocation = GetNextOperatorLocation(result, precedenceOperators);
					}

					return result;

					ExpressionGroup GetNextExpressionGroup(string expression, OperatorLocation operatorLocation)
					{
						var leftOperand = GetLeftBooleanOperand(expression, operatorLocation.Index.Value);
						var rightOperand = GetRightBooleanOperand(expression, operatorLocation.Index.Value, operatorLocation.Value.Length);

						var op = GetOperator(operatorLocation.Value);
						var expGroup = new ExpressionGroup
						{
							LeftOperand = leftOperand,
							RightOperand = rightOperand,
							ExpressionOperator = op,
							ExpressionType = ExpressionType.Boolean
						};

						return expGroup;

						string GetLeftBooleanOperand(string expression, int operatorLocationIndex)
						{
							var leftHalf = expression.Substring(0, operatorLocationIndex);
							int? startIndex = null;
							int? booleanOperatorIndex = null;
							var booleanOperators = BooleanOperators.ToList();

							for (int i = 0; i < booleanOperators.Count(); i++)
							{
								var operatorIndex = LastIndexOfOutsideQuotes(leftHalf, booleanOperators[i]);

								if (operatorIndex == -1)
								{
									continue;
								}

								// get the furthest away operator to get the correct left operand
								if (startIndex == null || operatorIndex > startIndex)
								{
									startIndex = operatorIndex;
									booleanOperatorIndex = i;
								}
							}

							if (startIndex == null)
							{
								startIndex = 0;
							}
							else
							{
								startIndex += booleanOperators.ElementAt(booleanOperatorIndex.Value).Length;
							}

							if (operatorLocationIndex > leftHalf.Length)
							{
								var message = $"Couldn't get left operand for expression {leftHalf} using operand {expression[operatorLocationIndex]}.";
								throw new ArgumentException(message, nameof(expression));
							}

							return leftHalf.Substring(startIndex.Value, operatorLocationIndex - startIndex.Value);
						}

						string GetRightBooleanOperand(string expression, int operatorLocationIndex, int operatorValueLength)
						{
							var rightHalf = expression.Substring(operatorLocationIndex + operatorValueLength);
							int? endIndex = null;
							var booleanOperators = BooleanOperators.ToList();
							for (int i = 0; i < booleanOperators.Count(); i++)
							{
								var operatorIndex = IndexOfOutsideQuotes(rightHalf, booleanOperators.ElementAt(i));

								if (operatorIndex == -1)
								{
									continue;
								}

								// get the closest one
								if (endIndex == null || operatorIndex < endIndex)
								{
									endIndex = operatorIndex;
								}
							}

							if (endIndex == null)
							{
								endIndex = rightHalf.Length;
							}

							if (endIndex > rightHalf.Length)
							{
								var message = $"Couldn't get right operand for expression {rightHalf} using operand {expression[operatorLocationIndex]}.";
								throw new ArgumentException(message, nameof(expression));
							}

							return rightHalf.Substring(0, endIndex.Value);
						}
					}

					ExpressionResult SolveBooleanExpressionGroup(ExpressionGroup expGroup)
					{
						var Left = new Operand
						{
							Value = expGroup.LeftOperand,
							Type = GetVariableType(expGroup.LeftOperand)
						};

						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = GetVariableType(expGroup.RightOperand)
						};

						string result;
						if (Left.Type == VariableType.Float || Right.Type == VariableType.Float) // floating point addition
						{
							float left = GetFloat(Left.Value), right = GetFloat(Right.Value);
							result = CalculateExpression(left, right, expGroup.ExpressionOperator);
						}
						else if (Left.Type == VariableType.Int && Right.Type == VariableType.Int) // integer division
						{
							int left = GetInt(Left.Value), right = GetInt(Right.Value);
							result = CalculateExpression(left, right, expGroup.ExpressionOperator);
						}
						else
						{ // Boolean and string 
							result = CalculateExpression(Left.Value, Right.Value, expGroup.ExpressionOperator);
						}

						var expResult = new ExpressionResult 
						{
							Value = result, 
							Type = VariableType.Boolean 
						};

						return expResult;

						string CalculateExpression<T>(T leftOperand, T rightOperand, Operator expressionOperator) where T : IComparable<T>
						{
							switch (expressionOperator)
							{
								case Operator.LessThan:
									return LessThan(leftOperand, rightOperand);
								case Operator.LessThanOrEqualTo:
									return LessThanOrEqualTo(leftOperand, rightOperand);
								case Operator.GreaterThan:
									return GreaterThan(leftOperand, rightOperand);
								case Operator.GreaterThanOrEqualTo:
									return GreaterThanOrEqualTo(leftOperand, rightOperand);
								case Operator.NotEqualTo:
									return NotEqualTo(leftOperand, rightOperand);
								case Operator.EqualTo:
									return EqualTo(leftOperand, rightOperand);
								case Operator.And:
									return And(leftOperand, rightOperand);
								case Operator.Or:
									return Or(leftOperand, rightOperand);
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
				}
			}

			ExpressionResult EvaluateMathStringExpression(string expression)
			{
				var higherPrecedenceOperators = new[] { "*", "/", "%" };
				string result = SolveExpressionPrecedence(expression, higherPrecedenceOperators);

				var lowerPrecedenceOperators = new[] { "-", "+" };
				result = SolveExpressionPrecedence(result, lowerPrecedenceOperators);

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = GetVariableType(result)
				};

				return expResult;

				string SolveExpressionPrecedence(string expression, IEnumerable<string> precedenceOperators)
				{
					// start with the expression
					var result = expression;

					// get the next operator location. An operator location is a value of the operator and it's location in the current expression
					// this is used to build an expression group, the simplest form of an expression
					var operatorLocation = GetNextOperatorLocation(result, precedenceOperators);

					while (operatorLocation.Index != null)
					{
						// get the next expression to solve
						var expressionGroup = GetNextExpressionGroup(result, operatorLocation);

						ExpressionResult expressionResult;

						// solve math 
						if (expressionGroup.ExpressionType == ExpressionType.Math)
						{
							expressionResult = SolveMathExpression(expressionGroup);
						}
						// or solve string
						else
						{
							expressionResult = SolveStringExpression(expressionGroup);
						}

						var answer = expressionResult.Value;

						// replace it with the original, re-create the new expression
						result = ReplaceExpressionWithResult(result, expressionGroup.Combine(), answer);

						// get the next operator, if any
						operatorLocation = GetNextOperatorLocation(result, precedenceOperators);
					}

					return result;

					ExpressionResult SolveMathExpression(ExpressionGroup expressionGroup)
					{
						var Left = new Operand
						{
							Value = expressionGroup.LeftOperand,
							Type = GetVariableType(expressionGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expressionGroup.RightOperand,
							Type = GetVariableType(expressionGroup.RightOperand)
						};

						string answer = null;

						if (Left.Type == VariableType.Float || Right.Type == VariableType.Float) // floating point addition
						{
							var left = GetFloat(Left.Value);
							var right = GetFloat(Right.Value);
							answer = CalculateExpression(left, right, expressionGroup.ExpressionOperator);
						}
						else // integer division
						{
							var left = GetInt(Left.Value);
							var right = GetInt(Right.Value);
							answer = CalculateExpression(left, right, expressionGroup.ExpressionOperator);
						}

						var result = new ExpressionResult 
						{ 
							Value = answer, 
							Type = UpdateVariableType(Left.Type, Right.Type) 
						};

						return result;

						VariableType UpdateVariableType(VariableType leftOperandType, VariableType rightOperandType)
						{
							if (leftOperandType == VariableType.String || rightOperandType == VariableType.String)
							{
								return VariableType.String;
							}
							else if (leftOperandType == VariableType.Boolean || rightOperandType == VariableType.Boolean)
							{
								return VariableType.Boolean;
							}
							else if (leftOperandType == VariableType.Float || rightOperandType == VariableType.Float)
							{
								return VariableType.Float;
							}
							else if (leftOperandType == VariableType.Int || rightOperandType == VariableType.Int)
							{
								return VariableType.Int;
							}

							return VariableType.Null;
						}

						string CalculateExpression<T>(T left, T right, Operator op)
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
							Type = GetVariableType(expGroup.LeftOperand)
						};
						var Right = new Operand
						{
							Value = expGroup.RightOperand,
							Type = GetVariableType(expGroup.RightOperand)
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
							if (Left.Type == VariableType.Int || Left.Type == VariableType.Float)
							{
								number = GetInt(Left.Value);
								expression = Right.Value;
							}
							else if (Right.Type == VariableType.Int || Right.Type == VariableType.Float)
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
							Type = VariableType.String
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

					ExpressionGroup GetNextExpressionGroup(string expression, OperatorLocation operatorLocation)
					{
						string leftOperand = null, rightOperand = null;

						// get the types for each operand and the expression itself, whether it's math or string
						var expressionTypesGroup = GetOperandTypes(expression, operatorLocation.Index.Value);

						// Check the left side
						if (expressionTypesGroup.LeftOperandType == ExpressionType.String)
						{
							leftOperand = GetLeftStringOperand(expression, operatorLocation.Index.Value);
						}
						else if (expressionTypesGroup.LeftOperandType == ExpressionType.Math)
						{
							leftOperand = GetLeftMathOperand(expression, operatorLocation.Index.Value);
						}

						// check the right side
						if (expressionTypesGroup.RightOperandType == ExpressionType.String)
						{
							rightOperand = GetRightStringOperand(expression, operatorLocation.Index.Value);
						}
						else if (expressionTypesGroup.RightOperandType == ExpressionType.Math)
						{
							rightOperand = GetRightMathOperand(expression, operatorLocation.Index.Value);
						}

						var expressionOperator = GetOperator(operatorLocation.Value);
						var result = new ExpressionGroup
						{
							LeftOperand = leftOperand,
							RightOperand = rightOperand,
							ExpressionOperator = expressionOperator,
							ExpressionType = expressionTypesGroup.ExpressionType
						};

						return result;

						ExpressionTypesGroup GetOperandTypes(string expression, int operatorLocationIndex)
						{
							var leftType = ExpressionType.None;
							var rightType = ExpressionType.None;
							var expType = ExpressionType.None;

							// if it starts with a quote
							if (expression[operatorLocationIndex - 1] == '"')
							{
								leftType = ExpressionType.String;
							}
							// otherwise assume math
							else
							{
								leftType = ExpressionType.Math;
							}

							// if it ends with a quote
							if (expression[operatorLocationIndex + 1] == '"')
							{
								rightType = ExpressionType.String;
							}
							// otherwise assume math
							else
							{
								rightType = ExpressionType.Math;
							}

							// string takes precedence over math when determining expression type
							if (leftType == ExpressionType.String || rightType == ExpressionType.String)
							{
								expType = ExpressionType.String;
							}
							// both have to be type math to be math
							else if (leftType == ExpressionType.Math && rightType == ExpressionType.Math)
							{
								expType = ExpressionType.Math;
							}

							// validate
							if (leftType == ExpressionType.None)
							{
								var message = $"Couldn't find Arithmetic Type for left operand for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}
							else if (rightType == ExpressionType.None)
							{
								var message = $"Couldn't find Arithmetic Type for right operand for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}
							else if (expType == ExpressionType.None)
							{
								var message = $"Couldn't find Arithmetic Type for expression {expression}.";
								throw new ArgumentException(message, nameof(expression));
							}

							var result = new ExpressionTypesGroup
							{
								LeftOperandType = leftType,
								RightOperandType = rightType,
								ExpressionType = expType,
							};

							return result;
						}

						string GetRightMathOperand(string expression, int operatorLocationIndex)
						{
							var start = operatorLocationIndex + 1;
							var startIndex = operatorLocationIndex + 1;

							// handle implicit negatives
							if (expression[start] == '-')
							{
								start++; 
							}

							var mathOperators = MathOperators.ToList();
							for (int i = start; i < expression.Length; i++)
							{
								for (int j = 0; j < mathOperators.Count(); j++)
								{
									// get the first character of the operator
									char operatorStartIndex = mathOperators[j][0];

									// wait until it's found
									if (expression[i] != operatorStartIndex)
									{
										continue;
									}

									// operator signals the end
									if (!CheckForOperatorOnRight(i, mathOperators[j], expression))
									{
										continue;
									}

									// validate
									if (i > expression.Length)
									{
										var message = $"Couldn't get right operand for expression {expression} using operand {expression[operatorLocationIndex]}.";
										throw new ArgumentException(message, nameof(expression));
									}

									return expression.Substring(startIndex, i - startIndex);
								}
							}

							return expression.Substring(startIndex);

							bool CheckForOperatorOnRight(int index, string mathOperator, string expression)
							{
								if (index > 0 && expression.Length > index + mathOperator.Length)
								{
									var str = expression.Substring(index, mathOperator.Length);
									return str == mathOperator;
								}

								return false;
							}
						}

						string GetRightStringOperand(string expression, int operatorLocationIndex)
						{
							var start = operatorLocationIndex + 1;
							var quoteCount = 0;
							char? currentQuote = null;

							for (int i = start; i < expression.Length; i++)
							{
								// strings start and end with quotes
								if (FoundAQuote(expression, i, currentQuote))
								{
									if (quoteCount == 0) 
									{
										currentQuote = expression[i]; 
									}

									quoteCount++;

									// 2 quotes, end of string
									if (quoteCount == 2)
									{
										if (i + 1 > expression.Length)
										{
											var message = $"Couldn't get right operand for expression {expression} using operand {expression[operatorLocationIndex]}.";
											throw new ArgumentException(message, nameof(expression));
										}
										return expression.Substring(start, (i + 1) - start);
									}
								}
							}

							throw new Exception($"Couldn't get right string operand using expression {expression} with index {operatorLocationIndex}");
						}

						string GetLeftStringOperand(string expression, int index)
						{
							var start = index - 1;
							var quoteCount = 0;
							char? currentQuote = null;
							for (int i = start; i >= 0; i--)
							{
								// strings work within quotes
								if (FoundAQuote(expression, i, currentQuote))
								{
									currentQuote = expression[i];
									quoteCount++;

									// once 2 quotes hit, that's the end
									if (quoteCount == 2)
									{
										if (index > expression.Length)
										{
											var message = $"Couldn't get right operand for expression {expression} using operand {expression[index]}.";
											throw new ArgumentException(message, nameof(expression));
										}
										return expression.Substring(i, index - i);
									}
								}
							}

							throw new Exception($"Couldn't get left string operand using expression {expression} with index {index}");
						}

						string GetLeftMathOperand(string expression, int operatorLocationIndex)
						{
							var start = operatorLocationIndex - 1;
							var mathOperators = MathOperators.ToList();
							for (var i = start; i >= 0; i--)
							{
								// for each character behind the location of the operator
								for (var j = 0; j < mathOperators.Count(); j++)
								{
									// get the last character index of the current math operator
									var operatorEndIndex = mathOperators[j].Last();

									// wait until it hits one
									if (expression[i] != operatorEndIndex)
									{
										continue;
									}

									// found a match
									var startSubstringIndex = i + 1;
									var substringLength = start - i;

									if (i != 0)
									{
										// if the one after the negative is an operator
										if (CheckNextCharacterForOperator(expression[i - 1], mathOperators, expression, i - 1))
										{
											startSubstringIndex = i; // then include the negative, otherwise default to normal i + 1
											substringLength++;
										}
									}
									// if it's at the start or implicit negative, account for it
									else if (i == 0 || expression[i] == '-')
									{
										startSubstringIndex = i;
										substringLength++;
									}

									if (substringLength > expression.Length - startSubstringIndex)
									{
										var message = $"Couldn't get right operand for expression {expression} using operand {expression[operatorLocationIndex]}.";
										throw new ArgumentException(message, "expression");
									}

									return expression.Substring(startSubstringIndex, substringLength);
								}
							}

							return expression.Substring(0, operatorLocationIndex);

							bool CheckNextCharacterForOperator(char ch, IEnumerable<string> delimiters, string expression, int opIndex)
							{
								bool result = false;
								for (int i = 0; i < mathOperators.Count(); i++)
								{
									char delimEnd = delimiters.ElementAt(i).Last();
									if (ch == delimEnd)
									{
										if (CheckForOperatorOnTheLeft(opIndex, delimiters.ElementAt(i), expression))
										{
											result = true;
											break;
										}
									}
								}

								return result;

								bool CheckForOperatorOnTheLeft(int index, string mathOperator, string expression)
								{
									var start = index - (mathOperator.Length - 1);

									if (start >= 0 && expression.Length > start + mathOperator.Length)
									{
										string result = expression.Substring(start, mathOperator.Length);
										return result == mathOperator;
									}

									return false;
								}

							}

						}

					}
				}
			}

            #region Post
            OperatorLocation GetNextOperatorLocation(string expression, IEnumerable<string> operators)
			{
				string nextOperatorValue = null;

				// start at the maximum, work your way down
				var currentMaxOperatorIndex = int.MaxValue;
				int? index = null;
				var isNegative = false;

				// check for implicit negatives
				if (expression[0] == '-')
				{
					// too short of an expression
					if (expression.Length < 2)
					{
						var message = $"Couldn't find operand for expression {expression}.";
						throw new ArgumentException(message, nameof(expression));
					}

					// remove the negative, easier to handle later
					expression = expression.Substring(1); 
					isNegative = true;
				}

				// iterate over the operators
				for (int i = 0; i < operators.Count(); i++)
				{
					// look for the operator
					var operatorIndex = IndexOfOutsideQuotes(expression, operators.ElementAt(i));
					if (operatorIndex == -1) 
					{
						continue;
					}

					// find the next closest one, left to right
					if (currentMaxOperatorIndex > operatorIndex)
					{
						// keep track of the max
						currentMaxOperatorIndex = operatorIndex;

						// update the values
						nextOperatorValue = operators.ElementAt(i).ToString();
						index = isNegative ? operatorIndex + 1 : operatorIndex;
					}
				}

				var result = new OperatorLocation 
				{
					Value = nextOperatorValue,
					Index = index.HasValue ? index.Value : null
				};

				return result;
			}

			VariableType GetVariableType(string expression)
			{
				if (int.TryParse(expression, out int tempInteger))
				{
					return VariableType.Int;
				}
				else if (float.TryParse(expression, out float tempFloat))
				{
					return VariableType.Float;
				}
				else if (expression[0] == '"' && expression[expression.Length - 1] == '"')
				{
					return VariableType.String;
				}
				else if (expression == "True" || expression == "False")
				{
					return VariableType.Boolean;
				}
				else
				{
					var message = $"Variable Type not found for expression {expression}.";
					throw new ArgumentException(message, nameof(expression));
				}
			}

			Operator GetOperator(string op)
			{
				Operator? result = null;
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

				if (result == null)
				{
					var message = $"Operator not found for {op}.";
					throw new ArgumentException(message, nameof(op));
				}

				return result.Value;
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

			bool FoundAQuote(string expression, int index, char? currentQuote)
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
					return currentCharacter == '"'; // default
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
					// handle quotes
					if (FoundAQuote(expression, i, currentQuote))
					{
						currentQuote = expression[i];
						inQuote = !inQuote;
						searchIndex = 0;
						if (!inQuote) 
						{
							currentQuote = null; 
						}
					}

					// in a quote, skip the iteration
					if (inQuote)
                    {
						continue;
                    }

					// not matching at the first character
					if (expression[i] != searchingFor[searchIndex])
					{
						continue;
					}

					// if it reached the end, the index is found, break out
					if (searchIndex == searchingFor.Length - 1)
					{
						result = i - (searchingFor.Length - 1);
						break;
					}

					// otherwise keep going until it does
					searchIndex++;
				}

				return result;
			}

			int LastIndexOfOutsideQuotes(string expression, string searchingFor)
			{
				var result = -1;
				var searchIndex = searchingFor.Length - 1;
				var inQuote = false;
				char? currentQuote = null;

				// go backwards on it
				for (int i = expression.Length - 1; i >= 0; i--)
				{
					// handle quotes
					if (FoundAQuote(expression, i, currentQuote))
					{
						currentQuote = expression[i];
						inQuote = !inQuote;
						searchIndex = 0;
						if (!inQuote) 
						{
							currentQuote = null; 
						}
					}

					// in a quote, skip the iteration
					if (inQuote)
					{
						continue;
					}

					// haven't found a match on the last character
					if (expression[i] != searchingFor[searchIndex])
					{
						continue;
					}
					
					// if it reached the end of the searchingFor string, the index is found
					if (searchIndex == 0)
					{
						result = i;
						break;
					}

					// otherwise reduce and continue
					searchIndex--;
				}

				return result;
			}
            #endregion
        }
    }
}
