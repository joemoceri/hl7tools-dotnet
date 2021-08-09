using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRCL_I06
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentMSA msa{ get; init; }
public HL7V23SegmentQRD qrd{ get; init; }
public HL7V23SegmentQRF qrf{ get; init; }
public HL7V23SegmentPID pid{ get; init; }
public HL7V23SegmentDG1 dg1{ get; init; }
public HL7V23SegmentDRG drg{ get; init; }
public HL7V23SegmentAL1 al1{ get; init; }
public HL7V23SegmentNTE nte{ get; init; }
public HL7V23SegmentDSP dsp{ get; init; }
public HL7V23SegmentDSC dsc{ get; init; }


        public string Id { get { return @"RCL_I06"; } }
        public string MessageStructureId { get { return @"RCL_I06"; } }
        public string EventDescription { get { return @"Response of clinical data listing "; } }

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

        public HL7V23TriggerEventRCL_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.dg1 = new HL7V23SegmentDG1(this.message);
this.drg = new HL7V23SegmentDRG(this.message);
this.al1 = new HL7V23SegmentAL1(this.message);
this.nte = new HL7V23SegmentNTE(this.message);
this.dsp = new HL7V23SegmentDSP(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
