using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public interface IHL7V2Field
    {
        int DelimiterIndex { get; set; }

        string Delimiter { get; set; }

        string Value { get; set; }

        IList<IHL7V2Field> Fields { get; set; }

        IHL7V2Field this[int id]
        {
            get;
        }
    }
}
