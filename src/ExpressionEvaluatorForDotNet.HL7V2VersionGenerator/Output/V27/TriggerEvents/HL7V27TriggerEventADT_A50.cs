using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventADT_A50
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentEVN evn{get; init;}
public HL7V27SegmentPID pid{get; init;}
public HL7V27SegmentPD1 pd1{get; init;}
public HL7V27SegmentMRG mrg{get; init;}
public HL7V27SegmentPV1 pv1{get; init;}


        public string Id { get { return @"ADT_A50"; } }
        public string MessageStructureId { get { return @"ADT_A50"; } }
        public string EventDescription { get { return @"Change visit number"; } }

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

        public HL7V27TriggerEventADT_A50(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.mrg = new HL7V27SegmentMRG(this.message);
this.pv1 = new HL7V27SegmentPV1(this.message);

        }
    }
}
