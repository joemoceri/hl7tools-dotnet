using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Field : IHL7V2Field
    {
        public HL7V2Field()
        {
            Components = new List<HL7V2FieldComponent>();

            FieldRepetitions = new List<HL7V2FieldRepetition>();
        }

        public int Id { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public IList<HL7V2FieldComponent> Components { get; set; }

        public IList<HL7V2FieldRepetition> FieldRepetitions { get; set; }

        public HL7V2FieldRepetition GetFieldRepetition(int id)
        {
            return FieldRepetitions.FirstOrDefault(fr => fr.Id.Equals(id));
        }


        public HL7V2FieldComponent GetComponent(int id)
        {
            return Components.FirstOrDefault(f => f.Id.Equals(id));
        }

        public void Rebuild(Func<IList<IHL7V2Field>, bool, string> combine)
        {
            if (Components.Count > 0)
            {
                foreach (var component in Components)
                {
                    component.Rebuild(combine);
                }

                Value = combine(Components.Cast<IHL7V2Field>().ToList(), false);
            }
        }

        public HL7V2FieldComponent this[int id]
        {
            get
            {
                return Components.FirstOrDefault(f => f.Id.Equals(id));
            }
        }
    }
}