using System.Text;

namespace ExpressionEvaluator
{
	public class StringArithmetic
	{
		private ArithmeticService arithmetic;
		private VarType ExpressionVarType;

		public StringArithmetic() : this(new ArithmeticService()) { }

		public StringArithmetic(ArithmeticService arithmetic) 
		{
			this.arithmetic = arithmetic;
		}

		public ExpressionResult Solve(ExpressionGroup expGroup)
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
			
			ExpressionVarType = arithmetic.UpdateVarType(ExpressionVarType, Left.Type, Right.Type);

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

			StringBuilder result = new StringBuilder("\"").Append(answer).Append("\"");
			ExpressionResult expResult = new ExpressionResult 
			{
				Value = result.ToString(),
				Type = ExpressionVarType
			};

			return expResult;
		}

		private string TrimOperand(string operand)
		{
			string result = operand;
			if (operand[0] == '"')
			{
				result = result.Trim('"');
			}
			return result;
		}

		private string Addition(string left, string right) 
		{
			return left + right;
		}

		private string Multiply(int multiplier, string expression) 
		{
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < multiplier; i++) 
			{
				result.Append(expression);
			}
			return result.ToString();
		}

	}
}
