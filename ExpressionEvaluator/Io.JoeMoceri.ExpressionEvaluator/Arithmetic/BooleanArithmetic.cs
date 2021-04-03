using System;

namespace ExpressionEvaluator
{
	public class BooleanArithmetic
	{
		private readonly ArithmeticService arithmetic;

		public BooleanArithmetic() : this(new ArithmeticService()) { }

		public BooleanArithmetic(ArithmeticService arithmetic) 
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
		}

		private string GetAnswer<T>(T left, T right, Operator op) where T : IComparable<T>
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
		}

		private string LessThan<T>(T left, T right) where T : IComparable<T>
		{
			return (left.CompareTo(right) < 0).ToString();
		}
		
		private string LessThanOrEqualTo<T>(T left, T right) where T : IComparable<T>
		{
			return (left.CompareTo(right) < 0 || left.Equals(right)).ToString();
		}

		private string GreaterThan<T>(T left, T right) where T : IComparable<T>
		{
			return (left.CompareTo(right) > 0).ToString();
		}

		private string GreaterThanOrEqualTo<T>(T left, T right) where T : IComparable<T>
		{
			return (left.CompareTo(right) > 0 || left.Equals(right)).ToString();
		}

		private string NotEqualTo<T>(T left, T right) where T : IComparable<T>
		{
			return (!left.Equals(right)).ToString();
		}

		private string EqualTo<T>(T left, T right) where T : IComparable<T>
		{
			return left.Equals(right).ToString();
		}

		private string And<T>(T left, T right) where T : IComparable<T>
		{
			return (ConvertBool(left) && ConvertBool(right)).ToString();
		}

		private string Or<T>(T left, T right) where T : IComparable<T>
		{
			return (ConvertBool(left) || ConvertBool(right)).ToString();
		}

		private bool ConvertBool<T>(T value) where T : IComparable<T>
		{
            if (bool.TryParse(value.ToString(), out bool boolean))
            {
                return boolean;
            }
            else
            {
                string message = string.Format("Couldn't convert {0} to its boolean equivalent." + Environment.NewLine, value.ToString());
                Log.Error(message);
                throw new ArgumentException(message, "value");
            }
        }

	}
}
