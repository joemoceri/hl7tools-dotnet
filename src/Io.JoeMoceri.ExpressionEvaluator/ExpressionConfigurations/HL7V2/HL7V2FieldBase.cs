using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// This abstract base class is what all other 'field' like classes inherit from.
	/// </summary>
    public abstract class HL7V2FieldBase
    {
		/// <summary>
		/// The Id of the Field.
		/// </summary>
        public abstract int Id { get; set; }

		/// <summary>
		/// The Delimiter of the Field.
		/// </summary>
        public abstract string Delimiter { get; set; }

		/// <summary>
		/// The Value of the Field.
		/// </summary>
        public abstract string Value { get; set; }

		/// <summary>
		/// All classes must implement some kind of rebuild mechanism (except subcomponents).
		/// </summary>
		public abstract void Rebuild();

		/// <summary>
		/// Called by a field in order to rebuild it's Value.
		/// </summary>
		/// <param name="fields"></param>
		/// <returns></returns>
		protected string CombineHL7Fields(IList<HL7V2FieldBase> fields)
		{
			if (fields == null || fields.Count == 0)
			{
				return null;
			}

			var result = string.Empty;

			for (var i = 0; i < fields.Count; i++)
			{
				result += $"{(i == 0 ? "" : fields[i].Delimiter)}{fields[i].Value}";
			}

			return result;
		}
	}
}