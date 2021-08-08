using System;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2ValidationResult
    {
        public bool Result { get; set; }

        public IDictionary<string, string> Issues { get; set; }

        public Exception Error { get; set; }
    }
}
