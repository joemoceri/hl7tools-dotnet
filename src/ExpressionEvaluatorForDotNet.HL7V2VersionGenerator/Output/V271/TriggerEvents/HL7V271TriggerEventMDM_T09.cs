using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventMDM_T09
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentEVN evn;
public readonly HL7V271SegmentPID pid;
public readonly HL7V271SegmentPV1 pv1;
public readonly HL7V271SegmentTXA txa;
public readonly HL7V271SegmentCON con;


        public string Id { get { return @"MDM_T09"; } }
        public string MessageStructureId { get { return @"MDM_T09"; } }
        public string EventDescription { get { return @"Document replacement notification"; } }

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

        public HL7V271TriggerEventMDM_T09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.txa = new HL7V271SegmentTXA(this.message);
this.con = new HL7V271SegmentCON(this.message);

        }
    }
}
