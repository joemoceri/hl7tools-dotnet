using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventPEX_P08
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentEVN evn;
public readonly HL7V27SegmentPID pid;
public readonly HL7V27SegmentPD1 pd1;
public readonly HL7V27SegmentPRT prt;
public readonly HL7V27SegmentNTE nte;


        public string Id { get { return @"PEX_P08"; } }
        public string MessageStructureId { get { return @"PEX_P08"; } }
        public string EventDescription { get { return @"Unsolicited update individual product experience report"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
                    };
            }
        }

        public HL7V27TriggerEventPEX_P08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.prt = new HL7V27SegmentPRT(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
