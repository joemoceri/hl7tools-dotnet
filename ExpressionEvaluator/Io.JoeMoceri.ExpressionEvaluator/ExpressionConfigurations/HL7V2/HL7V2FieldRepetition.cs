using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2FieldRepetition
    {
        public int DelimiterIndex { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }
    }
}