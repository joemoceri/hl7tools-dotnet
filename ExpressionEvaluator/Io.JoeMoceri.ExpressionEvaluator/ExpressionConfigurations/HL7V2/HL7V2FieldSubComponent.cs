using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2FieldSubComponent : IHL7V2Field
    {
        public HL7V2FieldSubComponent()
        {
            FieldRepetitions = new List<HL7V2FieldRepetition>();
        }

        public int Id { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public IList<HL7V2FieldRepetition> FieldRepetitions { get; set; }

        public HL7V2FieldRepetition GetFieldRepetition(int id)
        {
            return FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(id));
        }

        public void Rebuild(Func<IList<IHL7V2Field>, bool, string> combine)
        {
            // &CYTO~JOE~TEST&JANE
            if (FieldRepetitions.Count > 0)
            {
                Value = combine(FieldRepetitions.Cast<IHL7V2Field>().ToList(), false);
            }
        }

        public HL7V2FieldRepetition this[int id]
        {
            get
            {
                return FieldRepetitions.FirstOrDefault(f => f.Id.Equals(id));
            }
        }

        public void AddFieldRepetition(string value)
        {
            FieldRepetitions.Add(new HL7V2FieldRepetition
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                Id = FieldRepetitions.Count > 0 ? FieldRepetitions.Last().Id + 1 : 1,
                Value = value,
            });
        }

        public void RemoveFieldRepetition(int id)
        {
            var fr = FieldRepetitions.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return;
            }

            FieldRepetitions.Remove(fr);
        }

        public void InsertFieldRepetition(int id, string value)
        {
            if (id >= FieldRepetitions.Max(fr => fr.Id) || id <= 0)
            {
                return;
            }

            var fieldRepetition = new HL7V2FieldRepetition
            {
                Delimiter = HL7V2ExpressionConfiguration.fieldRepetitionDelimiter,
                Id = id,
                Value = value
            };

            var pFr = FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(id));

            if (pFr == null)
            {
                return;
            }

            var previousIndex = FieldRepetitions.IndexOf(pFr);

            foreach (var f in FieldRepetitions)
            {
                if (f.Id > previousIndex)
                {
                    f.Id++;
                }
            }

            FieldRepetitions.Insert(previousIndex, fieldRepetition);
        }

        public void UpdateFieldRepetition(int id, string value)
        {
            if (id >= FieldRepetitions.Max(fr => fr.Id) || id <= 0)
            {
                return;
            }

            var fr = FieldRepetitions.FirstOrDefault(f => f.Id.Equals(id));

            if (fr == null)
            {
                return;
            }

            fr.Value = value;
        }
    }
}