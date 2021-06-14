namespace ExpressionEvaluatorForDotNet
{
	/// <summary>
	/// This class is used internally to identify the next operators location when evaluating inner expressions.
	/// </summary>
	public class OperatorLocation
	{
		/// <summary>
		/// The value of the operator.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// The index of the operator within the expression. If null, there are no more operators and therefore expressions to evaluate.
		/// </summary>
		public int? Index { get; set; }
	}
}
