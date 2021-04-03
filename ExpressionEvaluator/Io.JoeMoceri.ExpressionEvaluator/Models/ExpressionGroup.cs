namespace ExpressionEvaluator
{
	public class ExpressionGroup
	{
		public string LeftOperand { get; set; }
		public string RightOperand { get; set; }
		public Operator ExpressionOperator { get; set; }
		public ArithmeticType ExpressionType { get; set; }

		public string Combine() 
		{
			return LeftOperand + Arithmetic.GetOperator(ExpressionOperator) + RightOperand;
		}
	
	}
}
