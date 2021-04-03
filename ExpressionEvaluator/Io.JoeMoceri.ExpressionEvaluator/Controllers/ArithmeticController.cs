using ExpressionEvaluator.Arithmetic;
using ExpressionEvaluator.Models;
using ExpressionEvaluator.Services;
using ExpressionEvaluator.Utilities;
using System;

namespace ExpressionEvaluator.Controllers
{
	public interface IArithmeticController
	{
		ExpressionResult Evaluate(string expression);
	}

	/// <summary>
	/// This is the main entry point for evaluating expressions. Use this class and its Evaluate method.
	/// </summary>
	public class ArithmeticController : IArithmeticController
	{

		private ArithmeticService arithmetic;

		public ArithmeticController() : this(new ArithmeticService()) { }

		public ArithmeticController(ArithmeticService arithmetic) 
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
				if (expression.Trim() == "") { return new ExpressionResult { Value = expression, Type = VarType.Null }; };
				expression = expression.RemoveWhitespaceOutsideQuotes();
				expression = arithmetic.HandleImplicitNegative(expression);

				int parenthesesAmount = arithmetic.GetCharCount(expression, '(') + arithmetic.GetCharCount(expression, ')');
				int doubleQuoteAmount = arithmetic.GetCharCount(expression, '"');

				if (doubleQuoteAmount % 2 != 0)
				{
					string message = string.Format("Odd number of double quotes found: {0}. Are you missing a double quote?", doubleQuoteAmount);
					Log.Error(message);
					throw new ArithmeticException(message);
				}
				else if (parenthesesAmount % 2 != 0)
				{
					string message = string.Format("Odd number of parentheses found: {0}. Are you missing a parentheses?", parenthesesAmount);
					Log.Error(message);
					throw new ArithmeticException(message);
				}

				while (parenthesesAmount != 0)
				{
					expression = arithmetic.GetOuterMostParentheticalExpression(expression, Evaluate);
					parenthesesAmount = arithmetic.GetCharCount(expression, '(') + arithmetic.GetCharCount(expression, ')');
				}

				var arithmeticExpType = GetArithmeticExpressionType(expression);

				if (arithmeticExpType == ArithmeticExpressionType.Boolean)
				{
					result = new BooleanEvaluator(new ArithmeticService()).Evaluate(expression);
				}
				else if (arithmeticExpType == ArithmeticExpressionType.MathAndString)
				{
					result = new Evaluator(new ArithmeticService()).Evaluate(expression);
				}
				else if (arithmeticExpType == ArithmeticExpressionType.Null)
				{
					string message = string.Format("Type of Arithmetic Expression not found for {0}.", expression);
					Log.Error(message);
					throw new ArgumentException(message, "expression");
				}
			}
			catch (Exception ex) 
			{
				return new ExpressionResult { Value = null, Type = VarType.Null, Error = ex };	
			}

			return result;
		}

		private ArithmeticExpressionType GetArithmeticExpressionType(string expression) 
		{
			var delimiters = new[] { ">", ">=", "<", "<=", "==", "!=", "&&", "||", "and", "or" };
			for (int i = 0; i < delimiters.Length; i++) 
			{
				if (expression.IndexOfOutsideQuotes(delimiters[i]) != -1) 
				{
					return ArithmeticExpressionType.Boolean;
				}
			}

			delimiters = new[] {"+", "-", "/", "%", "*", "False", "True", "\"" };
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
