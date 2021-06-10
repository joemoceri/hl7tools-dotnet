namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// A class that represents an inner expression. Contains the Left and Right Operands, the Operator type, and the Expression type.
	/// </summary>
	public class ExpressionGroup
	{
		/// <summary>
		/// The left operand of the inner expression.
		/// </summary>
		public string LeftOperand { get; set; }
		
		/// <summary>
		/// The right operand of the inner expression.
		/// </summary>
		public string RightOperand { get; set; }
		/// <summary>
		/// The operator for the inner expression.
		/// </summary>
		public Operator ExpressionOperator { get; set; }
		/// <summary>
		/// The type of the inner expression.
		/// </summary>
		public ExpressionType ExpressionType { get; set; }
    }
}
