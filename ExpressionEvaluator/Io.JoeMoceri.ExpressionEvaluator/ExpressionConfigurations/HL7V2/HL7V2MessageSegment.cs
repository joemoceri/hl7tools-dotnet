using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	public class HL7V2MessageSegment
    {
		public string SegmentName { get; set; }

        public IList<HL7V2FieldBase> Fields { get; set; }

        public override string ToString()
        {
            return Combine(Fields);

			string Combine(IList<HL7V2FieldBase> fields, bool useSegmentName = true)
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
		}


		public void Rebuild()
        {
			foreach (var field in Fields)
            {
				field.Rebuild();
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
