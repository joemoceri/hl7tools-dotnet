namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// This class groups operand types with the expression type and is used internally.
	/// </summary>
	public class ExpressionOperandTypes
	{
		/// <summary>
		/// The expression type of the left operand.
		/// </summary>
		public ExpressionType LeftOperandType { get; set; }

		/// <summary>
		/// The expression type of the right operand.
		/// </summary>
		public ExpressionType RightOperandType { get; set; }

		/// <summary>
		/// The expression type of the expression.
		/// </summary>
		public ExpressionType ExpressionType { get; set; }
	}
}
