using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExpressionEvaluatorForDotNet
{
	/// <summary>
	/// This is the main class used for evaluating expressions.
	/// </summary>
	public class Evaluator
	{
		/// <summary>
		/// The configuration to use when evaluating expressions.
		/// </summary>
		public ExpressionConfigurationBase expressionConfiguration;

		/// <summary>
		/// The evaluator uses <see cref="CSharpExpressionConfiguration" /> as it's default expression configuration.
		/// </summary>
		public Evaluator(): this(new CSharpExpressionConfiguration()) { }

		/// <summary>
		/// You can override the default configuration by passing in your own.
		/// </summary>
		/// <param name="expressionConfiguration">The expression configuration the evaluator should use when evaluating expressions.</param>
		public Evaluator(ExpressionConfigurationBase expressionConfiguration)
        {
			this.expressionConfiguration = expressionConfiguration;
		}

		/// <summary>
		/// Accepts a path to an hl7v2 flat file message, parses it, and returns a structured <see cref="HL7V2Message"/> object.
		/// </summary>
		/// <param name="path">The path to the hl7v2 flat file message.</param>
		/// <returns><see cref="HL7V2Message"/>. <see cref="HL7V2Message.Error"/> will be null if successful.</returns>
		public HL7V2Message EvaluateHL7V2File(string path)
        {
			var result = new HL7V2Message();

            try
            {
				if (!File.Exists(path))
				{
					throw new ArgumentException($"File {path} doesn't exist.", nameof(path));
				}

				var expressions = File.ReadAllLines(path);

				result = EvaluateHL7V2File(expressions);
            }
			catch(Exception ex)
            {
				result.Error = ex;
            }

			return result;
        }

		/// <summary>
		/// Accepts an hl7v2 flat file message as an array of expressions and returns a structured <see cref="HL7V2Message"/> object.
		/// </summary>
		/// <param name="expressions">The hl7v2 message array of expressions.</param>
		/// <returns><see cref="HL7V2Message"/>. <see cref="HL7V2Message.Error"/> will be null if successful.</returns>
		public HL7V2Message EvaluateHL7V2File(string[] expressions)
        {
			var result = new HL7V2Message();

            try
            {
				if (!(expressionConfiguration is HL7V2ExpressionConfiguration))
				{
					throw new InvalidOperationException($"Expression Configuration must be of type {nameof(HL7V2ExpressionConfiguration)}");
				}

				var expConfig = ((HL7V2ExpressionConfiguration)expressionConfiguration);

				var additionOperator = expConfig.MathStringOperators.First(f => f.ExpressionOperator.Equals(Operator.Addition));

				var fieldDelimiter = expressions[0].Substring(3, 1);

				HL7V2ExpressionConfiguration.fieldDelimiter = fieldDelimiter;
				additionOperator.OperatorName = fieldDelimiter;

				HL7V2ExpressionConfiguration.componentDelimiter = expressions[0].Substring(4, 1);
				HL7V2ExpressionConfiguration.fieldRepetitionDelimiter = expressions[0].Substring(5, 1);
				HL7V2ExpressionConfiguration.escapeCharacter = expressions[0].Substring(6, 1);
				HL7V2ExpressionConfiguration.subComponentDelimiter = expressions[0].Substring(7, 1);

				foreach (var expression in expressions)
				{
					Evaluate(expression);

					var messageSegment = expConfig.GetHL7V2MessageSegment();

					result.MessageSegments.Add(messageSegment);
				}
            }
			catch (Exception ex)
            {
				result.Error = ex;
            }

			return result;
		}

		/// <summary>
		/// Accepts any kind of valid expression (csharp = math, boolean, string, hl7v2 = message segment) and returns a structured <see cref="ExpressionResult"/> object.
		/// </summary>
		/// <param name="expression">The expression to evaluate.</param>
		/// <returns><see cref="ExpressionResult"/>. <see cref="ExpressionResult.Error"/> will be null if successful.</returns>
		public ExpressionResult Evaluate(string expression)
        {
            if (expressionConfiguration is HL7V2ExpressionConfiguration)
            {
                if (
				expression.EndsWith(HL7V2ExpressionConfiguration.fieldDelimiter) ||
                expression.EndsWith(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter) ||
                expression.EndsWith(HL7V2ExpressionConfiguration.componentDelimiter) ||
                expression.EndsWith(HL7V2ExpressionConfiguration.subComponentDelimiter)
                )
                {
					var expConfig = ((HL7V2ExpressionConfiguration)expressionConfiguration);
                    expConfig.endCharacter = $"{{END_CHARACTER:{Guid.NewGuid()}}}";
                    expression += expConfig.endCharacter;
                }
            }

            var result = EvaluateInternal(expression);

            if (expressionConfiguration is HL7V2ExpressionConfiguration)
            {
                var expConfig = ((HL7V2ExpressionConfiguration)expressionConfiguration);
                expConfig.endCharacter = null;
            }

            return result;
        }

		/// <summary>
		/// Used internally for evaluating expressions.
		/// </summary>
		/// <param name="expression">The expression to evaluate.</param>
		/// <returns><see cref="ExpressionResult"/>. <see cref="ExpressionResult.Error"/> will be null if successful.</returns>
		private ExpressionResult EvaluateInternal(string expression)
		{
			try
			{
				// if the expression is empty, return it and null
				if (string.IsNullOrWhiteSpace(expression.Trim()))
				{
					return new ExpressionResult 
					{ 
						Value = expression, 
						Type = null
					}; 
				}

				if (expressionConfiguration is HL7V2ExpressionConfiguration)
                {
					var expConfig = ((HL7V2ExpressionConfiguration)expressionConfiguration);
					expConfig.Setup();

					if ((char.IsControl(expression[0]) && expression.Length == 1))
                    {
						return new ExpressionResult
						{
							Value = expression,
							Type = null
						};
					}
				}

				if (!expressionConfiguration.Options.IgnoreQuotesValidation)
				{
					var doubleQuoteAmount = GetCharacterCount(expression, '"');
					// validate quotes (inside strings doesn't matter)
					if (doubleQuoteAmount % 2 != 0)
					{
						throw new ArithmeticException($"Odd number of double quotes found: {doubleQuoteAmount}. Are you missing a double quote?");
					}
				}

				if (!expressionConfiguration.Options.IgnoreWhitespaceOutsideQuotes)
                {
					// get the whitespace outside of quotes out of the way
					expression = RemoveWhitespaceOutsideQuotes(expression);
                }

				// handle implicit negative
				expression = expression.Replace("-(", ("-1*("));

				if (!expressionConfiguration.Options.IgnoreParentheses)
                {
					var parenthesesAmount = GetCharacterCount(expression, '(') + GetCharacterCount(expression, ')');
					// validate parentheses (inside strings doesn't matter)
					if (parenthesesAmount % 2 != 0)
					{
						throw new ArithmeticException($"Odd number of parentheses found: {parenthesesAmount}. Are you missing a parentheses?");
					}

					// recursively break down the expressions parentheses, then work your way back up
					while (parenthesesAmount != 0)
					{
						expression = GetOuterMostParenthesesExpression(expression, EvaluateInternal);
						parenthesesAmount = GetCharacterCount(expression, '(') + GetCharacterCount(expression, ')');
					}
                }

				// determine what kind of expression it is (math, string, boolean)
				var isBooleanExpression = IsBooleanExpression(expression);

				// get the boolean evaluated result
				if (isBooleanExpression)
				{
					return EvaluateBooleanExpression(expression);
				}
				// get the math (same as string) evaluated result
				else
				{
					return EvaluateMathStringExpression(expression);
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

            #region Pre
            bool IsBooleanExpression(string expression)
			{
				// is the expression boolean?
				var operators = expressionConfiguration.BooleanOperators;
				for (int i = 0; i < operators.Count; i++)
				{
					if (IndexOfOutsideQuotes(expression, operators[i].OperatorName) != -1)
					{
						return true;
					}
				}

				// check for single bool expression
				if (bool.TryParse(expression, out bool boolean))
                {
					return true;
                }

				// default is math/string
				return false;
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

			string GetOuterMostParenthesesExpression(string expression, Func<string, ExpressionResult> action)
			{
				// get the starting point
				var start = IndexOfOutsideQuotes(expression, "(") + 1;

				// how far this set of parentheses goes
				var length = GetParenthesesExpressionLength(expression); // always default to non same level

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
				var higherPrecedenceOperators = expressionConfiguration.BooleanOperators.Where(o => o.ExpressionOperatorPrecedence == OperatorPrecedence.Higher ).ToList();
				var result = SolveExpressionPrecedence(expression, higherPrecedenceOperators);
				
				var lowerPrecedenceOperators = expressionConfiguration.BooleanOperators.Where(o => o.ExpressionOperatorPrecedence == OperatorPrecedence.Lower).ToList();
				result = SolveExpressionPrecedence(result, lowerPrecedenceOperators);

				if (result.Equals("true"))
				{
					result = "True";
				}
				else if (result.Equals("false"))
				{
					result = "False";
				}

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = VariableType.Boolean
				};

				return expResult;

				string SolveExpressionPrecedence(string expression, IList<ExpressionConfigurationOperator> precedenceOperators)
				{
					// start with the expression
					var result = expression;

					// get the next operator location. An operator location is a value of the operator and it's location in the current expression
					// this is used to build an expression group, the simplest form of an expression
					var operatorLocation = GetNextOperatorLocation(result, precedenceOperators);

					// if nothing is found, this is skipped, and the expression is returned.
					while (operatorLocation.Index != null)
					{

						ExpressionResult expResult;
						var expressionGroup = GetNextExpressionGroup(result, operatorLocation);

						var precedenceOperator = precedenceOperators.First(o => o.OperatorName.Equals(operatorLocation.Value));

						precedenceOperator.OnBeforeOperatorExpressionSolved?.Invoke(expressionGroup);

						if (precedenceOperator.SolveOperatorExpression != null)
                        {
							expResult = precedenceOperator.SolveOperatorExpression.Invoke(expressionGroup);
						}
                        else
                        {
							// store the originals to be able to copy over
							var originalLeft = expressionGroup.LeftOperand;
							var originalRight = expressionGroup.RightOperand;

							// boolean expressions broken down are composed of 2 math/string expressions that need to be evaluated (1>2, 1+2>3+4, etc)
							var leftResult = EvaluateInternal(expressionGroup.LeftOperand);
							expressionGroup.LeftOperand = leftResult.Value;

							var rightResult = EvaluateInternal(expressionGroup.RightOperand);
							expressionGroup.RightOperand = rightResult.Value;

							// then, after updating those values, solve THAT boolean expression
							expResult = SolveBooleanExpressionGroup(expressionGroup);
							
							// reset the values
							expressionGroup.LeftOperand = originalLeft;
							expressionGroup.RightOperand = originalRight;
                        }

						precedenceOperator.OnAfterOperatorExpressionSolved?.Invoke(expResult);

						// replace the original result with the new computed result
						result = ReplaceExpressionWithResult(result, CombineExpressionGroup(expressionGroup, precedenceOperator.OperatorName), expResult.Value);

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
							var booleanOperators = expressionConfiguration.BooleanOperators;

							for (int i = 0; i < booleanOperators.Count; i++)
							{
								var operatorIndex = LastIndexOfOutsideQuotes(leftHalf, booleanOperators[i].OperatorName);

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
								startIndex += booleanOperators.ElementAt(booleanOperatorIndex.Value).OperatorName.Length;
							}

							return leftHalf.Substring(startIndex.Value, operatorLocationIndex - startIndex.Value);
						}

						string GetRightBooleanOperand(string expression, int operatorLocationIndex, int operatorValueLength)
						{
							var rightHalf = expression.Substring(operatorLocationIndex + operatorValueLength);
							int? endIndex = null;
							var booleanOperators = expressionConfiguration.BooleanOperators;
							for (int i = 0; i < booleanOperators.Count; i++)
							{
								var operatorIndex = IndexOfOutsideQuotes(rightHalf, booleanOperators[i].OperatorName);

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
							var result = string.Empty;
							switch (expressionOperator)
							{
								case Operator.LessThan:
									result = LessThan(leftOperand, rightOperand);
									break;
								case Operator.LessThanOrEqualTo:
									result = LessThanOrEqualTo(leftOperand, rightOperand);
									break;
								case Operator.GreaterThan:
									result = GreaterThan(leftOperand, rightOperand);
									break;
								case Operator.GreaterThanOrEqualTo:
									result = GreaterThanOrEqualTo(leftOperand, rightOperand);
									break;
								case Operator.NotEqualTo:
									result = NotEqualTo(leftOperand, rightOperand);
									break;
								case Operator.EqualTo:
									result = EqualTo(leftOperand, rightOperand);
									break;
								case Operator.And:
									result = And(leftOperand, rightOperand);
									break;
								case Operator.Or:
									result = Or(leftOperand, rightOperand);
									break;
							}

							return result;

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
								return bool.Parse(value.ToString());
							}
						}
					}
				}
			}

			ExpressionResult EvaluateMathStringExpression(string expression)
			{
				var higherPrecedenceOperators = expressionConfiguration.MathStringOperators.Where(o => o.ExpressionOperatorPrecedence == OperatorPrecedence.Higher).ToList();
				string result = SolveExpressionPrecedence(expression, higherPrecedenceOperators);

				var lowerPrecedenceOperators = expressionConfiguration.MathStringOperators.Where(o => o.ExpressionOperatorPrecedence == OperatorPrecedence.Lower).ToList();
				result = SolveExpressionPrecedence(result, lowerPrecedenceOperators);

				var expResult = new ExpressionResult
				{
					Value = result,
					Type = GetVariableType(result)
				};

				return expResult;

				string SolveExpressionPrecedence(string expression, IList<ExpressionConfigurationOperator> precedenceOperators)
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

						var precedenceOperator = precedenceOperators.First(o => o.OperatorName.Equals(operatorLocation.Value));

						precedenceOperator.OnBeforeOperatorExpressionSolved?.Invoke(expressionGroup);

						if (precedenceOperator.SolveOperatorExpression != null)
						{
							expressionResult = precedenceOperator.SolveOperatorExpression.Invoke(expressionGroup);
						}
						// solve math 
						else if (expressionGroup.ExpressionType == ExpressionType.Math)
						{
							expressionResult = SolveMathExpression(expressionGroup);
						}
						// or solve string
						else
						{
							expressionResult = SolveStringExpression(expressionGroup);
						}

						precedenceOperator.OnAfterOperatorExpressionSolved?.Invoke(expressionResult);

						// replace it with the original, re-create the new expression
						result = ReplaceExpressionWithResult(result, CombineExpressionGroup(expressionGroup, precedenceOperator.OperatorName), expressionResult.Value);

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
							if (leftOperandType == VariableType.Float || rightOperandType == VariableType.Float)
							{
								return VariableType.Float;
							}
							else
							{
								return VariableType.Int;
							}
						}

						string CalculateExpression<T>(T left, T right, Operator op)
						{
							var result = string.Empty;
							switch (op)
							{
								case Operator.Addition:
									result = Addition(left, right);
									break;
								case Operator.Division:
									result = Divide(left, right);
									break;
								case Operator.Modulus:
									result = Modulus(left, right);
									break;
								case Operator.Multiplication:
									result = Multiply(left, right);
									break;
								case Operator.Subtraction:
									result = Subtraction(left, right);
									break;
							}

							return result;

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
						//else if (expGroup.ExpressionOperator == Operator.Multiplication)
						//{
						//	int number = int.MinValue;
						//	string expression = null;
						//	if (Left.Type == VariableType.Int || Left.Type == VariableType.Float)
						//	{
						//		number = GetInt(Left.Value);
						//		expression = Right.Value;
						//	}
						//	else if (Right.Type == VariableType.Int || Right.Type == VariableType.Float)
						//	{
						//		number = GetInt(Right.Value);
						//		expression = Left.Value;
						//	}
						//	answer = Multiply(number, expression);
						//}

						var result = new StringBuilder("\"").Append(answer).Append("\"");
						var expResult = new ExpressionResult
						{
							Value = result.ToString(),
							Type = VariableType.String
						};

						return expResult;

						string Addition(string left, string right)
						{
							return left + right;
						}

						//string Multiply(int multiplier, string expression)
						//{
						//	var result = new StringBuilder();
						//	for (int i = 0; i < multiplier; i++)
						//	{
						//		result.Append(expression);
						//	}

						//	return result.ToString();
						//}

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

						ExpressionOperandTypes GetOperandTypes(string expression, int operatorLocationIndex)
						{
							ExpressionType leftType;
							ExpressionType rightType;
							ExpressionType expType;

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
							// otherwise assume math
							else 
							{
								expType = ExpressionType.Math;
							}

							var result = new ExpressionOperandTypes
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

							var mathOperators = expressionConfiguration.MathStringOperators;
							for (int i = start; i < expression.Length; i++)
							{
								for (int j = 0; j < mathOperators.Count(); j++)
								{
									// get the first character of the operator
									char operatorStartIndex = mathOperators[j].OperatorName[0];

									// wait until it's found
									if (expression[i] != operatorStartIndex)
									{
										continue;
									}

									return expression.Substring(startIndex, i - startIndex);
								}
							}

							return expression.Substring(startIndex);
						}

						string GetRightStringOperand(string expression, int operatorLocationIndex)
						{
							var start = operatorLocationIndex + 1;
							var quoteCount = 0;
							char? currentQuote = null;
							var result = string.Empty;

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
										result = expression.Substring(start, (i + 1) - start);
										break;
									}
								}
							}

							return result;
						}

						string GetLeftStringOperand(string expression, int index)
						{
							var start = index - 1;
							var quoteCount = 0;
							char? currentQuote = null;
							var result = string.Empty;

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
										result = expression.Substring(i, index - i);
										break;
									}
								}
							}

							return result;
						}

						string GetLeftMathOperand(string expression, int operatorLocationIndex)
						{
							var start = operatorLocationIndex - 1;
							var mathOperators = expressionConfiguration.MathStringOperators;
							for (var i = start; i >= 0; i--)
							{
								// for each character behind the location of the operator
								for (var j = 0; j < mathOperators.Count(); j++)
								{
									// get the last character index of the current math operator
									var operatorEndIndex = mathOperators[j].OperatorName.Last();

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

									return expression.Substring(startSubstringIndex, substringLength);
								}
							}

							return expression.Substring(0, operatorLocationIndex);

							bool CheckNextCharacterForOperator(char ch, IList<ExpressionConfigurationOperator> mathOperators, string expression, int opIndex)
							{
								bool result = false;
								for (int i = 0; i < mathOperators.Count(); i++)
								{
									char delimEnd = mathOperators[i].OperatorName.Last();
									if (ch == delimEnd)
									{
										result = true;
										break;
									}
								}

								return result;
							}

						}

					}
				}
			}

            #region Post
            OperatorLocation GetNextOperatorLocation(string expression, IList<ExpressionConfigurationOperator> operators)
			{
				string nextOperatorValue = null;

				// start at the maximum, work your way down
				var currentMaxOperatorIndex = int.MaxValue;
				int? index = null;
				var isNegative = false;

				// check for implicit negatives
				if (expression[0] == '-')
				{
					// remove the negative, easier to handle later
					expression = expression.Substring(1); 
					isNegative = true;
				}

				// iterate over the operators
				for (int i = 0; i < operators.Count(); i++)
				{
					// look for the operator
					var operatorIndex = IndexOfOutsideQuotes(expression, operators[i].OperatorName);
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
						nextOperatorValue = operators[i].OperatorName.ToString();
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
				else if (expression == "True" || expression == "False" || expression == "true" || expression == "false")
				{
					return VariableType.Boolean;
				}
				else
				{
					// invalid expressions usually break here first
					var message = $"Variable Type not found for expression {expression}.";
					throw new ArgumentException(message, nameof(expression));
				}
			}

			Operator GetOperator(string op)
			{
				return expressionConfiguration.Operators.First(o => o.OperatorName.Equals(op)).ExpressionOperator;
			}

			float GetFloat(string expression)
			{
				return float.Parse(expression);
			}

			int GetInt(string expression)
			{
				return int.Parse(expression);
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
				// get the start and end points
				var startPoint = expression.IndexOf(expressionSearchingFor);
				var endPoint = startPoint + expressionSearchingFor.Length;

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
				
				// go backwards on it
				for (int i = expression.Length - 1; i >= 0; i--)
				{
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

			string CombineExpressionGroup(ExpressionGroup expressionGroup, string operatorName)
			{
				return expressionGroup.LeftOperand + operatorName + expressionGroup.RightOperand;
			}
			#endregion
		}
    }
}
