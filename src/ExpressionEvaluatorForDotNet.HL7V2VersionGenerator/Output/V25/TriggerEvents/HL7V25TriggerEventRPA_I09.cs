using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRPA_I09
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentMSA msa{get; init;}
public HL7V25SegmentRF1 rf1{get; init;}
public HL7V25SegmentPID pid{get; init;}
public HL7V25SegmentNK1 nk1{get; init;}
public HL7V25SegmentGT1 gt1{get; init;}
public HL7V25SegmentACC acc{get; init;}
public HL7V25SegmentDG1 dg1{get; init;}
public HL7V25SegmentDRG drg{get; init;}
public HL7V25SegmentAL1 al1{get; init;}
public HL7V25SegmentNTE nte{get; init;}


        public string Id { get { return @"RPA_I09"; } }
        public string MessageStructureId { get { return @"RPA_I09"; } }
        public string EventDescription { get { return @"Request for modification to an authorization acknowledgement"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V25TriggerEventRPA_I09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.rf1 = new HL7V25SegmentRF1(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.nk1 = new HL7V25SegmentNK1(this.message);
this.gt1 = new HL7V25SegmentGT1(this.message);
this.acc = new HL7V25SegmentACC(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);
this.drg = new HL7V25SegmentDRG(this.message);
this.al1 = new HL7V25SegmentAL1(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
