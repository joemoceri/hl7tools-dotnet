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
        public HL7V2Field AddField(string value)
        {
            var result = new HL7V2Field
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldDelimiter,
                Id = Fields.Count > 0 ? Fields.Last().Id + 1 : 1,
                Value = value,
            };

            var fieldRepetition = new HL7V2FieldRepetition
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                Value = value,
                Id = 1
            };

            result.FieldRepetitions.Add(fieldRepetition);

            var component = new HL7V2Component
            {
                Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                Value = value,
                Id = 1
            };

            fieldRepetition.Components.Add(component);

            var subComponent = new HL7V2SubComponent
            {
                Delimiter = HL7V2ExpressionConfiguration.subComponentDelimiter,
                Value = value,
                Id = 1
            };

            component.SubComponents.Add(subComponent);

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

            if (Fields.Count == 0)
            {
                var fieldRepetition = new HL7V2FieldRepetition
                {
                    Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                    Value = value,
                    Id = 1
                };

                field.FieldRepetitions.Add(fieldRepetition);

                var component = new HL7V2Component
                {
                    Delimiter = HL7V2ExpressionConfiguration.componentDelimiter,
                    Value = value,
                    Id = 1
                };

                fieldRepetition.Components.Add(component);

                var subComponent = new HL7V2SubComponent
                {
                    Delimiter = HL7V2ExpressionConfiguration.subComponentDelimiter,
                    Value = value,
                    Id = 1
                };

                component.SubComponents.Add(subComponent);
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

            return fr;
        }
        #endregion
    }
}
