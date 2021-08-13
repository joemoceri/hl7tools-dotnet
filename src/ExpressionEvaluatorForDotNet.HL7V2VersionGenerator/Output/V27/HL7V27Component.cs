using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V27SubComponent> subComponents { get; internal set; }

        public HL7V27FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
