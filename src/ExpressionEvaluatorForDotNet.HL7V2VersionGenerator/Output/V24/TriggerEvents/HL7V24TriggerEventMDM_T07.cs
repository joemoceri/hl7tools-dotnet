using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMDM_T07
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEVN evn{get; init;}
public HL7V24SegmentPID pid{get; init;}
public HL7V24SegmentPV1 pv1{get; init;}
public HL7V24SegmentTXA txa{get; init;}


        public string Id { get { return @"MDM_T07"; } }
        public string MessageStructureId { get { return @"MDM_T07"; } }
        public string EventDescription { get { return @"Document edit  notification"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V24TriggerEventMDM_T07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pv1 = new HL7V24SegmentPV1(this.message);
this.txa = new HL7V24SegmentTXA(this.message);

        }
    }
}
