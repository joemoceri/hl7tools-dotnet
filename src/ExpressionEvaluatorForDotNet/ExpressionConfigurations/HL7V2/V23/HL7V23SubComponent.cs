using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SubComponent
    {
        public readonly HL7V2SubComponent subComponent;
        public readonly HL7V2FieldData fieldData;

        public HL7V23SubComponent(HL7V2SubComponent subComponent, HL7V2FieldData fieldData)
        {
            this.subComponent = subComponent;
            this.fieldData = fieldData;
        }

        public string Value { get { return subComponent.Value; } }
    }
}
