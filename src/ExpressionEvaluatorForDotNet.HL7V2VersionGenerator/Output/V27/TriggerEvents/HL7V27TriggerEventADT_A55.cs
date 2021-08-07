using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventADT_A55
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentEVN evn;
public readonly HL7V27SegmentPID pid;
public readonly HL7V27SegmentPD1 pd1;
public readonly HL7V27SegmentROL rol;
public readonly HL7V27SegmentPV1 pv1;
public readonly HL7V27SegmentPV2 pv2;
public readonly HL7V27SegmentROL rol;


        public string Id { get { return @"ADT_A55"; } }
        public string MessageStructureId { get { return @"ADT_A55"; } }
        public string EventDescription { get { return @"Cancel change attending doctor"; } }

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

        public HL7V27TriggerEventADT_A55(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.rol = new HL7V27SegmentROL(this.message);
this.pv1 = new HL7V27SegmentPV1(this.message);
this.pv2 = new HL7V27SegmentPV2(this.message);
this.rol = new HL7V27SegmentROL(this.message);

        }
    }
}
