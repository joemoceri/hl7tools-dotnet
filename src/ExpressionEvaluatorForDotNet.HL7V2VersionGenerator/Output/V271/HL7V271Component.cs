using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V271SubComponent> subComponents { get; internal set; }

        public HL7V271FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
