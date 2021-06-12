namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// This class is used for encapsulating an operand as part of an expression.
	/// </summary>
	public class Operand
	{
		/// <summary>
		/// The value of the operand.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// The <see cref="VariableType"/> of the operand.
		/// </summary>
		public VariableType Type { get; set; }
	}
}
