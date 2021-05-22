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
        }

        public int Id { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public IList<HL7V2FieldSubComponent> SubComponents { get; set; }

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
        }
    }
}