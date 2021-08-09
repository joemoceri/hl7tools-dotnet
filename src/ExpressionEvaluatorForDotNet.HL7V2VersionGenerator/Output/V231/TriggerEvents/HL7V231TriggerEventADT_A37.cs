using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventADT_A37
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentEVN evn{get; init;}
public HL7V231SegmentPID pid{get; init;}
public HL7V231SegmentPD1 pd1{get; init;}
public HL7V231SegmentPV1 pv1{get; init;}
public HL7V231SegmentDB1 db1{get; init;}
public HL7V231SegmentPID pid{get; init;}
public HL7V231SegmentPD1 pd1{get; init;}
public HL7V231SegmentPV1 pv1{get; init;}
public HL7V231SegmentDB1 db1{get; init;}


        public string Id { get { return @"ADT_A37"; } }
        public string MessageStructureId { get { return @"ADT_A37"; } }
        public string EventDescription { get { return @"Unlink patient information"; } }

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

        public HL7V231TriggerEventADT_A37(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);
this.db1 = new HL7V231SegmentDB1(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);
this.db1 = new HL7V231SegmentDB1(this.message);

        }
    }
}
