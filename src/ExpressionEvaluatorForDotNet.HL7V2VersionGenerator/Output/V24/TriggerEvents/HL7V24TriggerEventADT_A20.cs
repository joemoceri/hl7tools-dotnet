using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventADT_A20
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEVN evn{get; init;}
public HL7V24SegmentNPU npu{get; init;}


        public string Id { get { return @"ADT_A20"; } }
        public string MessageStructureId { get { return @"ADT_A20"; } }
        public string EventDescription { get { return @"Bed status update"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V24TriggerEventADT_A20(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.npu = new HL7V24SegmentNPU(this.message);

        }
    }
}
