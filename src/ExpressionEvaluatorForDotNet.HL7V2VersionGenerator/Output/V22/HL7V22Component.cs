using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V22SubComponent> subComponents { get; internal set; }

        public HL7V22FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
