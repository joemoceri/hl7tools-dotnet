namespace Io.JoeMoceri.ExpressionEvaluator
{
	public class ExpressionGroup
	{
		public string LeftOperand { get; set; }
		public string RightOperand { get; set; }
		public Operator ExpressionOperator { get; set; }
		public ExpressionType ExpressionType { get; set; }
    }
}
