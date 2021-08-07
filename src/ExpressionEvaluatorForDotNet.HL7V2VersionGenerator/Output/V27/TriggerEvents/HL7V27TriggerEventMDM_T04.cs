using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventMDM_T04
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentEVN evn;
public readonly HL7V27SegmentPID pid;
public readonly HL7V27SegmentPV1 pv1;
public readonly HL7V27SegmentTXA txa;
public readonly HL7V27SegmentCON con;


        public string Id { get { return @"MDM_T04"; } }
        public string MessageStructureId { get { return @"MDM_T04"; } }
        public string EventDescription { get { return @"Document status change notification and content"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
                    };
            }
        }

        public HL7V27TriggerEventMDM_T04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pv1 = new HL7V27SegmentPV1(this.message);
this.txa = new HL7V27SegmentTXA(this.message);
this.con = new HL7V27SegmentCON(this.message);

        }
    }
}
