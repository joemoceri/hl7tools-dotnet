using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Component
    {
        public readonly HL7V2Component component;
        public readonly IList<HL7V23SubComponent> subComponents;
        public readonly HL7V2FieldData fieldData;

        public HL7V23Component(HL7V2Component component, HL7V2FieldData fieldData, IList<HL7V23SubComponent> subComponents)
        {
            this.component = component;
            this.fieldData = fieldData;
            this.subComponents = subComponents;
        }

        public string Value { get { return component.Value; } }
    }
}
