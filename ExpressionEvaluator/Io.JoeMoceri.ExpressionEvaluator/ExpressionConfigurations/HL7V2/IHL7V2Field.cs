using System;
using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public interface IHL7V2Field
    {
        int Id { get; set; }

        string Delimiter { get; set; }

        string Value { get; set; }

        void Rebuild(Func<IList<IHL7V2Field>, bool, string> combine);
    }
}