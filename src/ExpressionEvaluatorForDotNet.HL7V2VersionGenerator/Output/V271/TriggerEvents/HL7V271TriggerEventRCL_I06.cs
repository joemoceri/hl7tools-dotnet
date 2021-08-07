using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRCL_I06
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentMSA msa;
public readonly HL7V271SegmentQRD qrd;
public readonly HL7V271SegmentQRF qrf;
public readonly HL7V271SegmentPID pid;
public readonly HL7V271SegmentDG1 dg1;
public readonly HL7V271SegmentDRG drg;
public readonly HL7V271SegmentAL1 al1;
public readonly HL7V271SegmentNTE nte;
public readonly HL7V271SegmentDSP dsp;
public readonly HL7V271SegmentDSC dsc;


        public string Id { get { return @"RCL_I06"; } }
        public string MessageStructureId { get { return @"RCL_I06"; } }
        public string EventDescription { get { return @"Return clinical list"; } }

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

        public HL7V271TriggerEventRCL_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.qrd = new HL7V271SegmentQRD(this.message);
this.qrf = new HL7V271SegmentQRF(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.dg1 = new HL7V271SegmentDG1(this.message);
this.drg = new HL7V271SegmentDRG(this.message);
this.al1 = new HL7V271SegmentAL1(this.message);
this.nte = new HL7V271SegmentNTE(this.message);
this.dsp = new HL7V271SegmentDSP(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}
