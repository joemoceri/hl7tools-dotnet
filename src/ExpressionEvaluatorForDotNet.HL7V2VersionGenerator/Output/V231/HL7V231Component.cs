using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V231SubComponent> subComponents { get; internal set; }

        public HL7V231FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
