using System;

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

		public Evaluator() : this(new Arithmetic()) { }

		public Evaluator(IArithmetic arithmetic) 
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
					return new ExpressionResult { Value = expression, Type = VarType.Null }; 
				};

				// get the whitespace outside of quotes out of the way
				expression = expression.RemoveWhitespaceOutsideQuotes();

				// an implicit negative is -1 or -(1)
				expression = arithmetic.HandleImplicitNegative(expression);


				int parenthesesAmount = arithmetic.GetCharCount(expression, '(') + arithmetic.GetCharCount(expression, ')');
				int doubleQuoteAmount = arithmetic.GetCharCount(expression, '"');

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

				// recursively break down the expressions parentheses, then work your way back up, like most interpreters do :)
				while (parenthesesAmount != 0)
				{
					expression = arithmetic.GetOuterMostParentheticalExpression(expression, Evaluate);
					parenthesesAmount = arithmetic.GetCharCount(expression, '(') + arithmetic.GetCharCount(expression, ')');
				}

				// determine what kind of expression it is (math, string, boolean)
				var arithmeticExpType = GetArithmeticExpressionType(expression);

				// get the boolean evaluated result
				if (arithmeticExpType == ArithmeticExpressionType.Boolean)
				{
					result = new BooleanEvaluator(arithmetic).Evaluate(expression);
				}
				// get the math (same as string) evaluated result
				else if (arithmeticExpType == ArithmeticExpressionType.MathAndString)
				{
					result = new ArithmeticEvaluator(arithmetic).Evaluate(expression);
				}
				else if (arithmeticExpType == ArithmeticExpressionType.Null)
				{
					var message = $"Type of Arithmetic Expression not found for {expression}.";
					throw new ArgumentException(message, nameof(expression));
				}
			}
			catch (Exception ex) 
			{
				return new ExpressionResult { Value = null, Type = VarType.Null, Error = ex };	
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
						return ArithmeticExpressionType.MathAndString;
					}
				}

				int integer;
				float floatingPointNumber;
				if (int.TryParse(expression, out integer) || float.TryParse(expression, out floatingPointNumber))
				{
					return ArithmeticExpressionType.MathAndString;
				}

				return ArithmeticExpressionType.Null;
			}
		}
	}
}
