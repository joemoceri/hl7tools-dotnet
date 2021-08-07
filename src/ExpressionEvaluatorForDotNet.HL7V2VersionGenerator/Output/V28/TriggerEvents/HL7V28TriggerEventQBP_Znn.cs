using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventQBP_Znn
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentQPD qpd;
public readonly HL7V28SegmentRDF rdf;
public readonly HL7V28SegmentRCP rcp;
public readonly HL7V28SegmentDSC dsc;


        public string Id { get { return @"QBP_Znn"; } }
        public string MessageStructureId { get { return @"QBP_Znn"; } }
        public string EventDescription { get { return null; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V28TriggerEventQBP_Znn(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.qpd = new HL7V28SegmentQPD(this.message);
this.rdf = new HL7V28SegmentRDF(this.message);
this.rcp = new HL7V28SegmentRCP(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}