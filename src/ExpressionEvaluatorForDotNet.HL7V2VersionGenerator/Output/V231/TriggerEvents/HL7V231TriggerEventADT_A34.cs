using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventADT_A34
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentEVN evn;
public readonly HL7V231SegmentPID pid;
public readonly HL7V231SegmentPD1 pd1;
public readonly HL7V231SegmentMRG mrg;


        public string Id { get { return @"ADT_A34"; } }
        public string MessageStructureId { get { return @"ADT_A34"; } }
        public string EventDescription { get { return @"Merge patient information - patient id only"; } }

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

        public HL7V231TriggerEventADT_A34(HL7V2Message message)
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
