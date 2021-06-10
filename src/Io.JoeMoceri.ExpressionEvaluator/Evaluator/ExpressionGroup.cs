namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// 
	/// </summary>
	public class ExpressionGroup
	{
		/// <summary>
		/// 
		/// </summary>
		public string LeftOperand { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string RightOperand { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public Operator ExpressionOperator { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public ExpressionType ExpressionType { get; set; }
    }
}
