using System;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// This class is what's returned after evaluating expressions. It contains three properties which hold information about the result of the evaluated expression.
	/// </summary>
	public class ExpressionResult
	{
		/// <summary>
		/// The evaluated value from the expression.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// The type of the value.
		/// </summary>
		public VariableType? Type { get; set; }
		/// <summary>
		/// The error if any. Will be null if completed successfully.
		/// </summary>
		public Exception Error { get; set; }

		/// <summary>
		/// Returns the <see cref="Value"/>.
		/// </summary>
		/// <returns><see cref="Value"/></returns>
		public override string ToString()
		{
			return Value;
		}

		/// <summary>
		/// Compares two <see cref="ExpressionResult"/> using the <see cref="Value"/> and <see cref="VariableType"/> for equality.
		/// </summary>
		/// <param name="expressionResult">The object to compare against.</param>
		/// <returns><see cref="bool"/></returns>
		public override bool Equals(object expressionResult)
		{
			if (expressionResult == null)
			{ 
				return false; 
			}

			if (expressionResult.GetType() != this.GetType())
			{
				return false;
			}

			var compareTo = (ExpressionResult)expressionResult;
			return compareTo.Value == this.Value && compareTo.Type == this.Type;
		}

		/// <summary>
		/// Gets the hash code using the <see cref="Value"/> and <see cref="VariableType"/>.
		/// </summary>
		/// <returns><see cref="int"/></returns>
		public override int GetHashCode()
		{
			unchecked
			{
				int hash = (int)2166136261;
				hash = hash * 16777619 ^ Value.GetHashCode();
				hash = hash * 16777619 ^ Type.GetHashCode();
				return hash;
			}
		}
	}
}
