using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	public class HL7V2MessageSegment : List<IHL7V2Field>, IHL7V2MessageSegment
    {
		public string SegmentName { get; set; }

        public IList<IHL7V2Field> Fields { get; set; }

        public override string ToString()
        {
            return CombineHL7Fields();

			string CombineHL7Fields()
			{
				if (Fields == null || Fields.Count == 0)
				{
					return null;
				}

				var result = SegmentName;

				for (var i = 0; i < Fields.Count; i++)
				{
					result += $"{Fields[i].Delimiter}{Fields[i].Value}";
				}

				return result;
			}
		}

		public new IHL7V2Field this[int id]
		{
			get
			{
				return Fields.FirstOrDefault(f => f.DelimiterIndex.Equals(id));
			}
		}
	}
}
