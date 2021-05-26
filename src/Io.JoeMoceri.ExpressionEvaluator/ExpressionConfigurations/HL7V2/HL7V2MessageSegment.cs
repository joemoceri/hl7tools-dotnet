using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
	public class HL7V2MessageSegment
    {
		public HL7V2MessageSegment()
        {
			Fields = new List<HL7V2Field>();
        }

		public string SegmentName { get; set; }

        public IList<HL7V2Field> Fields { get; set; }

        public override string ToString()
        {
            return Combine(Fields);

			string Combine(IList<HL7V2Field> fields, bool useSegmentName = true)
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
					if (HL7V2ExpressionConfiguration.specialSegmentHeaders.Any(a => a.Equals(SegmentName)) && i == 0 && useSegmentName)
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
			for (var i = 0; i < Fields.Count; i++)
            {
				Fields[i].Rebuild();
            }
        }

        public HL7V2Field this[int id]
        {
            get
            {
				return Fields.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

		public HL7V2Field GetField(int id)
		{
			return Fields.FirstOrDefault(f => f.Id.Equals(id));
		}

        #region Field Operations
        public HL7V2Field AddField(string value, bool includeFieldRepetition = true)
        {
            var field = new HL7V2Field
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldDelimiter,
                Id = Fields.Count > 0 ? Fields.Last().Id + 1 : 1,
                Value = value,
            };

            Fields.Add(field);

            if (includeFieldRepetition)
            {
                if (value.Contains(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter))
                {
                    var fieldRepetitions = field.Value.Split(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);
                    for (var i = 0; i < fieldRepetitions.Length; i++)
                    {
                        field.AddFieldRepetition(fieldRepetitions[i]);
                    }
                }
                else
                {
                    field.AddFieldRepetition(field.Value);
                }
            }

            return field;
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

            var f = Fields.FirstOrDefault(f => f.Id.Equals(id));

            if (f == null)
            {
                return null;
            }

            var previousIndex = Fields.IndexOf(f);

            foreach (var fi in Fields)
            {
                if (fi.Id > previousIndex)
                {
                    fi.Id++;
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

            var f = Fields.FirstOrDefault(f => f.Id.Equals(id));

            if (f == null)
            {
                return null;
            }

            f.Value = value;

            return f;
        }
        #endregion
    }
}
