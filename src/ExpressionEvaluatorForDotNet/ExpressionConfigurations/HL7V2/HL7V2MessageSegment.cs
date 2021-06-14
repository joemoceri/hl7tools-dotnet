using System.Collections.Generic;
using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// This class refers to HL7V2 Message Segments defined in V2 specification. Message Segments make up an HL7V2Message.
    /// </summary>
	public class HL7V2MessageSegment
    {
        /// <summary>
        /// Initializes the <see cref="Fields"/>.
        /// </summary>s
		public HL7V2MessageSegment()
        {
			Fields = new List<HL7V2Field>();
        }

        /// <summary>
        /// The name of this segment.
        /// </summary>
		public string SegmentName { get; set; }

        /// <summary>
        /// The fields of this segment.
        /// </summary>
        public IList<HL7V2Field> Fields { get; set; }

        /// <summary>
        /// Converts this message segment to a string.
        /// </summary>
        /// <returns><see cref="string"/> of all fields combined to form a valid hl7v2 message segment.</returns>
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

        /// <summary>
        /// Rebuilds the message segment by rebuilding each of it's Fields <see cref="HL7V2FieldBase.Rebuild"/>.
        /// </summary>
		public void Rebuild()
        {
			for (var i = 0; i < Fields.Count; i++)
            {
				Fields[i].Rebuild();
                Fields[i].Id = i + 1;
            }
        }

        /// <summary>
        /// Get a field by it's <see cref="HL7V2Field.Id"/> via indexer.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Field.Id"/>.</param>
        /// <returns><see cref="HL7V2Field"/> if found, otherwise <see cref="null"/>.</returns>
        public HL7V2Field this[int id]
        {
            get
            {
				return Fields.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

        /// <summary>
        /// Get a field by it's <see cref="HL7V2Field.Id"/> from this message segments <see cref="Fields"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Field.Id"/>.</param>
        /// <returns><see cref="HL7V2Field"/> if found, otherwise <see cref="null"/>.</returns>
		public HL7V2Field GetField(int id)
		{
			return Fields.FirstOrDefault(f => f.Id.Equals(id));
		}

        #region Field Operations
        /// <summary>
        /// Add a <see cref="HL7V2Field"/> to this message segments <see cref="Fields"/>.
        /// </summary>
        /// <param name="value">The <see cref="HL7V2Field.Value"/>.</param>
        /// <param name="includeFieldRepetition">Whether to include field repetition. Default is <see cref="true"/>.</param>
        /// <returns><see cref="HL7V2Field"/> if successful, otherwise <see cref="null"/>.</returns>
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

        /// <summary>
        /// Remove a <see cref="HL7V2Field"/> from this message segments <see cref="Fields"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Field.Id"/>.</param>
        /// <returns><see cref="true"/> if successful, otherwise <see cref="false"/>.</returns>
        public bool RemoveField(int id)
        {
            var fr = Fields.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return false;
            }

            var result = Fields.Remove(fr);

            Rebuild();

            return result;
        }

        /// <summary>
        /// Insert a <see cref="HL7V2Field"/> into this message segments <see cref="Fields"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Field.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2Field.Value"/>.</param>
        /// <returns><see cref="HL7V2Field"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Field InsertField(int id, string value)
        {
            if (Fields.Count == 0)
            {
                return null;
            }

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

            Fields.Insert(previousIndex, field);

            Rebuild();

            return field;
        }

        /// <summary>
        /// Update a <see cref="HL7V2Field"/> from this message segments <see cref="Fields"/>.
        /// </summary>
        /// <param name="id">The <see cref="HL7V2Field.Id"/>.</param>
        /// <param name="value">The <see cref="HL7V2Field.Value"/>.</param>
        /// <returns><see cref="HL7V2Field"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2Field UpdateField(int id, string value)
        {
            if (Fields.Count == 0)
            {
                return null;
            }

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
