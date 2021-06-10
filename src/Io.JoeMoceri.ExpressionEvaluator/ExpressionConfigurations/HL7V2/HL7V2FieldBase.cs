using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	/// <summary>
	/// 
	/// </summary>
    public abstract class HL7V2FieldBase
    {
		/// <summary>
		/// 
		/// </summary>
        public abstract int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public abstract string Delimiter { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public abstract string Value { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public abstract void Rebuild();

		/// <summary>
		/// 
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