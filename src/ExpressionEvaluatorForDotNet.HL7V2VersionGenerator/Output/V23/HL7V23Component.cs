using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V23SubComponent> subComponents { get; internal set; }

        public HL7V23FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
