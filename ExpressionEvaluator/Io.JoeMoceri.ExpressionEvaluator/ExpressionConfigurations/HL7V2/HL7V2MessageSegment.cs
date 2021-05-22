using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	public class HL7V2MessageSegment
    {
		public HL7V2MessageSegment()
        {
			Fields = new List<HL7V2FieldBase>();
        }

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

        #region Field Operations
        public HL7V2Field AddField(string value)
        {
            var result = new HL7V2Field
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                Id = Fields.Count > 0 ? Fields.Last().Id + 1 : 1,
                Value = value,
            };

            Fields.Add(result);

            return result;
        }

        public bool RemoveField(int id)
        {
            var fr = Fields.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return false;
            }

            return Fields.Remove(fr);
        }

        public HL7V2Field InsertField(int id, string value)
        {
            if (id >= Fields.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var field = new HL7V2Field
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldDelimiter,
                Id = id,
                Value = value
            };

            var pFr = Fields.FirstOrDefault(fr => fr.Id.Equals(id));

            if (pFr == null)
            {
                return null;
            }

            var previousIndex = Fields.IndexOf(pFr);

            foreach (var f in Fields)
            {
                if (f.Id > previousIndex)
                {
                    f.Id++;
                }
            }

            Fields.Insert(previousIndex, field);

            return field;
        }

        public HL7V2Field UpdateField(int id, string value)
        {
            if (id >= Fields.Max(fr => fr.Id) || id <= 0)
            {
                return null;
            }

            var fr = Fields.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return null;
            }

            fr.Value = value;

            return (HL7V2Field)fr;
        }
        #endregion
    }
}
