using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventMDM_T07
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentEVN evn;
public readonly HL7V28SegmentPID pid;
public readonly HL7V28SegmentPV1 pv1;
public readonly HL7V28SegmentTXA txa;
public readonly HL7V28SegmentCON con;


        public string Id { get { return @"MDM_T07"; } }
        public string MessageStructureId { get { return @"MDM_T07"; } }
        public string EventDescription { get { return @"Document edit notification"; } }

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

        public HL7V28TriggerEventMDM_T07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.pv1 = new HL7V28SegmentPV1(this.message);
this.txa = new HL7V28SegmentTXA(this.message);
this.con = new HL7V28SegmentCON(this.message);

        }
    }
}
