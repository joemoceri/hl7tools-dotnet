using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventADT_A37
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEVN evn{get; init;}
public HL7V24SegmentPID pid{get; init;}
public HL7V24SegmentPD1 pd1{get; init;}
public HL7V24SegmentPV1 pv1{get; init;}
public HL7V24SegmentDB1 db1{get; init;}
public HL7V24SegmentPID pid{get; init;}
public HL7V24SegmentPD1 pd1{get; init;}
public HL7V24SegmentPV1 pv1{get; init;}
public HL7V24SegmentDB1 db1{get; init;}


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

        public HL7V24TriggerEventADT_A37(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.pv1 = new HL7V24SegmentPV1(this.message);
this.db1 = new HL7V24SegmentDB1(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.pv1 = new HL7V24SegmentPV1(this.message);
this.db1 = new HL7V24SegmentDB1(this.message);

        }
    }
}
