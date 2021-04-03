using System;
using System.Collections.Generic;

namespace ExpressionEvaluator
{
	public class ArithmeticEvaluator
	{
		private readonly IArithmetic arithmetic;
		private VarType ExpressionVarType;

		public ArithmeticEvaluator() : this(new Arithmetic()) { }

		public ArithmeticEvaluator(IArithmetic arithmetic) 
		{
			this.arithmetic = arithmetic;
		}

		public ExpressionResult Evaluate(string expression)
		{
			arithmetic.SetDelimiterRange(DelimiterOperandType.Math);
			
			string result = SolvePrecedence(expression, new[] { "*", "/", "%" });
			result = SolvePrecedence(result, new[] { "-", "+" });
			ExpressionVarType = arithmetic.GetVarType(result);

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

			var opGroup = arithmetic.GetFirstSelection(expression, delimiters);

			while (opGroup.Location != int.MinValue)
			{
				var expGroup = GetHigestPrecedencePureExpression(result, opGroup);
				string answer = null;
				var expResult = new ExpressionResult { Value = null, Type = VarType.Null };
				if (expGroup.ExpressionType == ArithmeticType.Math)
				{
					expResult = new MathArithmetic(new Arithmetic()).Solve(expGroup);
				}
				else if (expGroup.ExpressionType == ArithmeticType.String)
				{
					expResult = new StringArithmetic(new Arithmetic()).Solve(expGroup);
				}

				answer = expResult.Value;
				ExpressionVarType = expResult.Type;

				result = result.ReplaceFirst(expGroup.Combine(), answer);
				opGroup = arithmetic.GetFirstSelection(result, delimiters);
			}

			return result;
		}

		public ExpressionGroup GetHigestPrecedencePureExpression(string expression, OperatorGroup opGroup) 
		{
			ExpressionGroup expGroup;
			string leftOperand = null, rightOperand = null;
			Operator op = Operator.Null;

			var arGroup = arithmetic.GetOperandTypes(expression, opGroup.Location);

			if (arGroup.LeftType == ArithmeticType.String) 
			{
				leftOperand = arithmetic.GetLeftStringOperand(expression, opGroup.Location);
			}
			else if (arGroup.LeftType == ArithmeticType.Math) 
			{
				leftOperand = arithmetic.GetLeftMathOperand(expression, opGroup.Location);
			}
			else if (arGroup.LeftType == ArithmeticType.None) 
			{
				var message = $"Left Operand Arithmetic Type not found for expression {expression}.{Environment.NewLine}Operator: {opGroup.Value}. Operator Location: {opGroup.Location}.{Environment.NewLine}";
				throw new ArgumentException(message, nameof(expression));
			}

			if (arGroup.RightType == ArithmeticType.String) 
			{
				rightOperand = arithmetic.GetRightStringOperand(expression, opGroup.Location);
			}
			else if (arGroup.RightType == ArithmeticType.Math) 
			{
				rightOperand = arithmetic.GetRightMathOperand(expression, opGroup.Location);
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
		}

	}
}
