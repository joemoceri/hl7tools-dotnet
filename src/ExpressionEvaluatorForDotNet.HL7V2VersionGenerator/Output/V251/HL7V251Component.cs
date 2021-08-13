using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V251SubComponent> subComponents { get; internal set; }

        public HL7V251FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
