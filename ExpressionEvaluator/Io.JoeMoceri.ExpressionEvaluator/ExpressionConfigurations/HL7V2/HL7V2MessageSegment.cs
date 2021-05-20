using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	public class HL7V2MessageSegment
    {
		public string SegmentName { get; set; }

        public IList<HL7V2Field> Fields { get; set; }

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
					if (SegmentName.Equals("MSH") && i == 0)
                    {
						continue;
                    }

					result += $"{Fields[i].Delimiter}{Fields[i].Value}";
				}

				return result;
			}
		}

		public HL7V2Field GetField(int id)
		{
			return Fields.FirstOrDefault(f => f.Id.Equals(id));
		}
	}
}
