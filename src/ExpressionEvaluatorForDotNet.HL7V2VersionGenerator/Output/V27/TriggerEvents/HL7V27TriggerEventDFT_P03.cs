using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventDFT_P03
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentEVN evn{ get; init; }
public HL7V27SegmentPID pid{ get; init; }
public HL7V27SegmentPD1 pd1{ get; init; }
public HL7V27SegmentROL rol{ get; init; }
public HL7V27SegmentPV1 pv1{ get; init; }
public HL7V27SegmentPV2 pv2{ get; init; }
public HL7V27SegmentROL rol{ get; init; }
public HL7V27SegmentDB1 db1{ get; init; }
public HL7V27SegmentDG1 dg1{ get; init; }
public HL7V27SegmentDRG drg{ get; init; }
public HL7V27SegmentGT1 gt1{ get; init; }
public HL7V27SegmentACC acc{ get; init; }


        public string Id { get { return @"DFT_P03"; } }
        public string MessageStructureId { get { return @"DFT_P03"; } }
        public string EventDescription { get { return @"Post detail financial transaction"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V27TriggerEventDFT_P03(HL7V2Message message)
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
this.db1 = new HL7V27SegmentDB1(this.message);
this.dg1 = new HL7V27SegmentDG1(this.message);
this.drg = new HL7V27SegmentDRG(this.message);
this.gt1 = new HL7V27SegmentGT1(this.message);
this.acc = new HL7V27SegmentACC(this.message);

        }
    }
}
