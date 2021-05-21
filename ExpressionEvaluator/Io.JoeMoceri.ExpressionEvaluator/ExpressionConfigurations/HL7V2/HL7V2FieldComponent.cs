using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2FieldComponent : IHL7V2Field
    {
        public HL7V2FieldComponent()
        {
            SubComponents = new List<HL7V2FieldSubComponent>();

            FieldRepetitions = new List<HL7V2FieldRepetition>();
        }

        public int Id { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public IList<HL7V2FieldSubComponent> SubComponents { get; set; }

        public IList<HL7V2FieldRepetition> FieldRepetitions { get; set; }

        public HL7V2FieldSubComponent this[int id]
        {
            get
            {
                return SubComponents.FirstOrDefault(sc => sc.Id.Equals(id));
            }
        }

        public HL7V2FieldSubComponent GetSubComponent(int id)
        {
            return SubComponents.FirstOrDefault(sc => sc.Id.Equals(id));
        }

        public HL7V2FieldRepetition GetFieldRepetition(int id)
        {
            return FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(id));
        }

        public void Rebuild(Func<IList<IHL7V2Field>, bool, string> combine)
        {
            // Components can have sub components or field repetition, check for both

            // |A&CYTO~JOE~TEST&JANE~JOE~TEST^201410060929
            if (SubComponents.Count > 0)
            {
                foreach (var sc in SubComponents)
                {
                    sc.Rebuild(combine);
                }

                Value = combine(SubComponents.Cast<IHL7V2Field>().ToList(), false);
            }

            // handle field repetitions
            // 168 ~219~C~PMA^101^1~2~3^1^^^S
            if (FieldRepetitions.Count > 0)
            {
                Value = combine(FieldRepetitions.Cast<IHL7V2Field>().ToList(), false);
            }
        }

        public void AddFieldRepetition(string delimiter, string value)
        {
            FieldRepetitions.Add(new HL7V2FieldRepetition
            {
                Delimiter = delimiter,
                Id = FieldRepetitions.Count > 0 ? FieldRepetitions.Last().Id + 1 : 1,
                Value = value,
            });
        }
    }
}