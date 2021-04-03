using ExpressionEvaluator.Models;
using ExpressionEvaluator.Services;
using ExpressionEvaluator.Utilities;

namespace ExpressionEvaluator.Arithmetic
{
	public class MathArithmetic
	{
		private readonly ArithmeticService arithmetic;
		private VarType ExpressionVarType;

		public MathArithmetic() : this(new ArithmeticService()) { }

		public MathArithmetic(ArithmeticService arithmetic) 
		{
			this.arithmetic = arithmetic;
		}

		public ExpressionResult Solve(ExpressionGroup expGroup)
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
			
			ExpressionVarType = arithmetic.UpdateVarType(ExpressionVarType, Left.Type, Right.Type);

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

			var expResult = new ExpressionResult { Value = result, Type = ExpressionVarType };

			return expResult;
		}

		public string GetAnswer<T>(T left, T right, Operator op)
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
		}

		private string Addition<T>(T left, T right) { dynamic temp = left; temp += right; return temp.ToString(); }
		private string Multiply<T>(T left, T right) { dynamic temp = left; temp *= right; return temp.ToString(); }
		private string Divide<T>(T left, T right) { dynamic temp = left; temp /= right; return temp.ToString(); }
		private string Modulus<T>(T left, T right) { dynamic temp = left; temp %= right; return temp.ToString(); }
		private string Subtraction<T>(T left, T right) { dynamic temp = left; temp -= right; return temp.ToString(); }

	}
}