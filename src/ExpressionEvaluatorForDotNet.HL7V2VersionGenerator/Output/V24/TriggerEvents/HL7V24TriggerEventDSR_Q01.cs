using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventDSR_Q01
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentMSA msa{ get; init; }
public HL7V24SegmentERR err{ get; init; }
public HL7V24SegmentQAK qak{ get; init; }
public HL7V24SegmentQRD qrd{ get; init; }
public HL7V24SegmentQRF qrf{ get; init; }
public HL7V24SegmentDSP dsp{ get; init; }
public HL7V24SegmentDSC dsc{ get; init; }


        public string Id { get { return @"DSR_Q01"; } }
        public string MessageStructureId { get { return @"DSR_Q01"; } }
        public string EventDescription { get { return @"Display response message"; } }

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

        public HL7V24TriggerEventDSR_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);
this.dsp = new HL7V24SegmentDSP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
