using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventEAC_U07
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEQU equ{get; init;}
public HL7V24SegmentECD ecd{get; init;}
public HL7V24SegmentSAC sac{get; init;}
public HL7V24SegmentCNS cns{get; init;}
public HL7V24SegmentROL rol{get; init;}


        public string Id { get { return @"EAC_U07"; } }
        public string MessageStructureId { get { return @"EAC_U07"; } }
        public string EventDescription { get { return @"Automated equipment command"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

                    };
            }
        }

        public HL7V24TriggerEventEAC_U07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.ecd = new HL7V24SegmentECD(this.message);
this.sac = new HL7V24SegmentSAC(this.message);
this.cns = new HL7V24SegmentCNS(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
