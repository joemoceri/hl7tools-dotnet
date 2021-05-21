using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	public class HL7V2MessageSegment
    {
		public string SegmentName { get; set; }

        public IList<IHL7V2Field> Fields { get; set; }

        public override string ToString()
        {
            return CombineHL7Fields(Fields);
		}

		private string CombineHL7Fields(IList<IHL7V2Field> fields, bool useSegmentName = true)
		{
			if (fields == null || fields.Count == 0)
			{
				return null;
			}

			var result = string.Empty;

			if (useSegmentName)
            {
				result = SegmentName;
            }

			for (var i = 0; i < fields.Count; i++)
			{
				if (SegmentName.Equals("MSH") && i == 0 && useSegmentName)
				{
					continue;
				}



				result += $"{(i == 0 && !useSegmentName ? "" : fields[i].Delimiter)}{fields[i].Value}";
			}

			return result;
		}

		public void Rebuild()
        {
			foreach (var field in Fields)
            {
				field.Rebuild(CombineHL7Fields);
            }
        }

        public HL7V2Field this[int id]
        {
            get
            {
				return (HL7V2Field)Fields.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

		public HL7V2Field GetField(int id)
		{
			return (HL7V2Field)Fields.FirstOrDefault(f => f.Id.Equals(id));
		}
	}
}
