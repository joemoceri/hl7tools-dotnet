using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V28SubComponent> subComponents { get; internal set; }

        public HL7V28FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
