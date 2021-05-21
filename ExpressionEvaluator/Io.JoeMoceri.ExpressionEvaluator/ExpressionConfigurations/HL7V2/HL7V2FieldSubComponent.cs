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
    }
}