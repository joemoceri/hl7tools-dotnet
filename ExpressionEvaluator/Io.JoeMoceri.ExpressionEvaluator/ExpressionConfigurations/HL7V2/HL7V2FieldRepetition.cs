using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2FieldRepetition : IHL7V2Field
    {
        public int Id { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public void Rebuild(Func<IList<IHL7V2Field>, bool, string> combine)
        {

        }
    }
}