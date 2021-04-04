namespace ExpressionEvaluator
{
	public class ExpressionGroup
	{
		public string LeftOperand { get; set; }
		public string RightOperand { get; set; }
		public Operator ExpressionOperator { get; set; }
		public ArithmeticOperandType ExpressionType { get; set; }

		public string Combine() 
		{
			return LeftOperand + GetOperator(ExpressionOperator) + RightOperand;
		}

        private string GetOperator(Operator op)
        {
            switch (op)
            {
                case Operator.Addition:
                    return "+";
                case Operator.Division:
                    return "/";
                case Operator.Modulus:
                    return "%";
                case Operator.Multiplication:
                    return "*";
                case Operator.Subtraction:
                    return "-";
                case Operator.LessThan:
                    return "<";
                case Operator.LessThanOrEqualTo:
                    return "<=";
                case Operator.GreaterThan:
                    return ">";
                case Operator.GreaterThanOrEqualTo:
                    return ">=";
                case Operator.NotEqualTo:
                    return "!=";
                case Operator.EqualTo:
                    return "==";
                case Operator.And:
                    return "&&";
                case Operator.Or:
                    return "||";
                default:
                    return null;
            }
        }

    }
}
