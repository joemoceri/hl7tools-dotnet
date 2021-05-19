using System;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// Contains three properties which hold information about the result of the expression evaluation.
	/// </summary>
	public class ExpressionResult
	{
		/// <summary>
		/// The actual value
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// The type of the value
		/// </summary>
		public VariableType? Type { get; set; }
		/// <summary>
		/// The error, if any. Will be null if completed successfully.
		/// </summary>
		public Exception Error { get; set; }

		public override string ToString()
		{
			return Value;
		}

		public override bool Equals(object x)
		{
			if (x == null)
			{ 
				return false; 
			}

			if (x.GetType() != this.GetType())
			{
				return false;
			}

			var compareTo = (ExpressionResult)x;
			return compareTo.Value == this.Value && compareTo.Type == this.Type;
		}

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
