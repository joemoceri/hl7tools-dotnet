using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventADT_A30
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentEVN evn{get; init;}
public HL7V231SegmentPID pid{get; init;}
public HL7V231SegmentPD1 pd1{get; init;}
public HL7V231SegmentMRG mrg{get; init;}


        public string Id { get { return @"ADT_A30"; } }
        public string MessageStructureId { get { return @"ADT_A30"; } }
        public string EventDescription { get { return @"Merge person information"; } }

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

        public HL7V231TriggerEventADT_A30(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.mrg = new HL7V231SegmentMRG(this.message);

        }
    }
}
