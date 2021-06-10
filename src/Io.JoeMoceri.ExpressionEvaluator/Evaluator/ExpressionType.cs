namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// The expression type is used to identify either an operand or expression if it's <see cref="Math"/>, <see cref="String"/>, or <see cref="Boolean"/>.
	/// </summary>
	public enum ExpressionType
	{
		Math,
		String,
		Boolean
	}
}
