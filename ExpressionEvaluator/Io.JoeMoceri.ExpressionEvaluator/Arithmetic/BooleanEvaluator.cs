using ExpressionEvaluator.Models;
using ExpressionEvaluator.Services;
using ExpressionEvaluator.Utilities;
using System.Collections.Generic;

namespace ExpressionEvaluator.Arithmetic
{
	public class BooleanEvaluator
	{
		private const VarType ExpressionVarType = VarType.Boolean;
		private readonly ArithmeticService arithmetic;
		private readonly IEnumerable<string> HigherPrecedenceOperators = new[] { "<=", ">=", "==", "!=", "<", ">", };
		private readonly IEnumerable<string> LowerPrecedenceOperators = new[] { "&&", "||", "and", "or" };

		public BooleanEvaluator() : this(new ArithmeticService()) { }

		public BooleanEvaluator(ArithmeticService arithmetic) 
		{
			this.arithmetic = arithmetic;
		}

		public ExpressionResult Evaluate(string expression)
		{
			arithmetic.SetDelimiterRange(DelimiterOperandType.Boolean);
			string result = SolvePrecedence(expression, HigherPrecedenceOperators);
			result = SolvePrecedence(result, LowerPrecedenceOperators);

			var expResult = new ExpressionResult
			{
				Value = result,
				Type = ExpressionVarType
			};

			return expResult;
		}

		public string SolvePrecedence(string expression, IEnumerable<string> delimiters)
		{
			string result = expression;
			var opGroup = arithmetic.GetFirstSelection(result, delimiters);

			while (opGroup.Location != int.MinValue)
			{
				var expGroup = GetHigestPrecedencePureExpression(result, opGroup);

				string originalLeft = expGroup.LeftOperand;
				string originalRight = expGroup.RightOperand;

				var leftResult = new Evaluator(new ArithmeticService()).Evaluate(expGroup.LeftOperand);
				expGroup.LeftOperand = leftResult.Value;

				var rightResult = new Evaluator(new ArithmeticService()).Evaluate(expGroup.RightOperand);
				expGroup.RightOperand = rightResult.Value;
				
				string answer = null;
				var expResult = new BooleanArithmetic(new ArithmeticService()).Solve(expGroup);

				answer = expResult.Value;
				
				expGroup.LeftOperand = originalLeft;
				expGroup.RightOperand = originalRight;

				result = result.ReplaceFirst(expGroup.Combine(), answer);
				opGroup = arithmetic.GetFirstSelection(result, delimiters);
			}
				
			return result;
		}

		public ExpressionGroup GetHigestPrecedencePureExpression(string expression, OperatorGroup opGroup)
		{
			ExpressionGroup expGroup;
			Operator op = Operator.Null;

			string leftOperand = arithmetic.GetLeftBooleanOperand(expression, opGroup.Location);
			string rightOperand = arithmetic.GetRightBooleanOperand(expression, opGroup.Location, opGroup.Value.Length);

			op = arithmetic.GetOperator(opGroup.Value);
			expGroup = new ExpressionGroup
			{
				LeftOperand = leftOperand,
				RightOperand = rightOperand,
				ExpressionOperator = op,
				ExpressionType = ArithmeticType.Boolean
			};

			return expGroup;
		}

	}
}
