using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate
{
    public class HL7Result
    {
		public string Segment { get; set; }

        public IList<HL7Part> Parts { get; set; }

        public override string ToString()
        {
            return CombineHL7Parts();

			string CombineHL7Parts()
			{
				if (Parts == null || Parts.Count == 0)
				{
					return null;
				}

				var result = Segment;

				for (var i = 0; i < Parts.Count; i++)
				{
					result += $"{Parts[i].Delimiter}{Parts[i].Value}";
				}

				return result;
			}
		}
    }
}
