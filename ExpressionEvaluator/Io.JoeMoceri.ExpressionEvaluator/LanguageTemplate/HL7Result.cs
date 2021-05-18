using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate
{
    public class HL7Result
    {
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

				var result = Parts[0].Segment;

				for (var i = 0; i < Parts.Count; i++)
				{
					result += $"{Parts[i].Delimiter}{Parts[i].Value}";
				}

				return result;
			}
		}
    }
}
