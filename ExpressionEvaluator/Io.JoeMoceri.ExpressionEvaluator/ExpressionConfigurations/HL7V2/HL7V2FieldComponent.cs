using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2FieldComponent
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
    }
}