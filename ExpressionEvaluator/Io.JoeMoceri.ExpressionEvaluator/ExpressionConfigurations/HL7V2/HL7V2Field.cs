using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Field
    {
        public int DelimiterIndex { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public IList<HL7V2Field> Fields { get; set; }

        public HL7V2Field GetField(int id)
        {
            return Fields.FirstOrDefault(f => f.DelimiterIndex.Equals(id));
        }
    }
}