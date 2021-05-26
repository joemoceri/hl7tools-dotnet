using System;
using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public abstract class HL7V2FieldBase
    {
        public abstract int Id { get; set; }

        public abstract string Delimiter { get; set; }

        public abstract string Value { get; set; }

		public abstract void Rebuild();

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