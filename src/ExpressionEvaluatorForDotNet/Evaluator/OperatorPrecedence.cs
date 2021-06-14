namespace ExpressionEvaluatorForDotNet
{
	/// <summary>
	/// This enumeration describes the precedence for how expressions should be evaluated. Options are <see cref="Higher"/> and <see cref="Lower"/>. Higher precedence operator expressions are solved before Lower.
	/// </summary>
	public enum OperatorPrecedence
	{
		Higher,
		Lower
	};
}