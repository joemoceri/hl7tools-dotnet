namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// This class groups operand types with the expression type and is used internally.
	/// </summary>
	public class ExpressionOperandTypes
	{
		/// <summary>
		/// The <see cref="ExpressionType"/> of the left operand.
		/// </summary>
		public ExpressionType LeftOperandType { get; set; }

		/// <summary>
		/// The <see cref="ExpressionType"/> of the right operand.
		/// </summary>
		public ExpressionType RightOperandType { get; set; }

		/// <summary>
		/// The <see cref="ExpressionType"/> of the expression.
		/// </summary>
		public ExpressionType ExpressionType { get; set; }
	}
}
