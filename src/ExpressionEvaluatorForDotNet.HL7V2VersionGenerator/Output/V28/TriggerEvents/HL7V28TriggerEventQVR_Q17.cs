using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventQVR_Q17
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentQPD qpd;
public readonly HL7V28SegmentRCP rcp;
public readonly HL7V28SegmentDSC dsc;


        public string Id { get { return @"QVR_Q17"; } }
        public string MessageStructureId { get { return @"QVR_Q17"; } }
        public string EventDescription { get { return @"Query for previous events"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V28TriggerEventQVR_Q17(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.qpd = new HL7V28SegmentQPD(this.message);
this.rcp = new HL7V28SegmentRCP(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
