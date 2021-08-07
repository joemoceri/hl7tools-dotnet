using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventADT_A47
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentEVN evn;
public readonly HL7V26SegmentPID pid;
public readonly HL7V26SegmentPD1 pd1;
public readonly HL7V26SegmentARV arv;
public readonly HL7V26SegmentMRG mrg;


        public string Id { get { return @"ADT_A47"; } }
        public string MessageStructureId { get { return @"ADT_A47"; } }
        public string EventDescription { get { return @"Change Patient Identifier List"; } }

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

        public HL7V26TriggerEventADT_A47(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pd1 = new HL7V26SegmentPD1(this.message);
this.arv = new HL7V26SegmentARV(this.message);
this.mrg = new HL7V26SegmentMRG(this.message);

        }
    }
}
