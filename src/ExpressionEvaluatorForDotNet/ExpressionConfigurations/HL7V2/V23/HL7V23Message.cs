using System;
using System.Collections.Generic;
using System.Linq;
 
namespace ExpressionEvaluatorForDotNet 
{
    public class HL7V23Message
    {
        public readonly HL7V2Message message;
        public readonly HL7V23MshSegment msh;

        public HL7V23Message(HL7V2Message message)
        {
            this.message = message;
            msh = new HL7V23MshSegment(message);
        }

        public HL7V23ADT_A01TriggerEvent GetADT_A01()
        {
            // TODO: Fill this out, validate
            return new HL7V23ADT_A01TriggerEvent();
        }
    }
}
