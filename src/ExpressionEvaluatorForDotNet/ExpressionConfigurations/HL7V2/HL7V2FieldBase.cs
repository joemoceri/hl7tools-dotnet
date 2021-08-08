using System.Collections.Generic;
using System.Text;

namespace ExpressionEvaluatorForDotNet
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
		/// Called by a field in order to rebuild it's <see cref="Value"/>.
		/// </summary>
		/// <param name="fields">The <see cref="HL7V2FieldBase"/>'s to combine.</param>
		/// <returns><see cref="string"/> of the combined fields.</returns>
		protected string CombineHL7Fields(IList<HL7V2FieldBase> fields)
		{
			var result = new StringBuilder();

			for (var i = 0; i < fields.Count; i++)
			{
				result.Append($"{(i == 0 ? "" : fields[i].Delimiter)}{fields[i].Value}");
			}

			return result.ToString();
		}
	}
}