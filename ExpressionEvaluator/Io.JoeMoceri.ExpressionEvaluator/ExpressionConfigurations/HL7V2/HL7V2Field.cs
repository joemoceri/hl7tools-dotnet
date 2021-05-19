using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Field : List<HL7V2Field>, IHL7V2Field
    {
        public int DelimiterIndex { get; set; }

        public string Delimiter { get; set; }

        public string Value { get; set; }

        public IList<IHL7V2Field> Fields { get; set; }

        public new IHL7V2Field this[int id]
        {
            get
            {
                return Fields.FirstOrDefault(f => f.DelimiterIndex.Equals(id));
            }
        }
    }
}