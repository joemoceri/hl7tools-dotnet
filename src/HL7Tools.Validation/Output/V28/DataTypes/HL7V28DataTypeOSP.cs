using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypeOSP
    {
        public string Id { get { return @"OSP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Occurrence Span Code And Date"; } }

        public string Description { get { return @"A code and the related dates that identify an event that relates to the payment of the claim. For example, Prior Stay Dates which is the from/through dates given by the patient of any hospital stay that ended within 60 days of this hospital or SNF admission.

Note: Replaces the CM data type used in section 6.5.11.8 UB2-8, as of v 2.5.

Use case: The patient was admitted for minor surgery (1/6/03) and discharged the following day (1/7/03). Complications ensured and the patient was readmitted the following day (1/8/03). When the claim for 1/8/03 is filed, the prior stay dates (1/6/03-1/7/03) must be reported (per the Health Plan) using Occurrence Span Code and Dates 71 - Prior Stay Date. 

Example:
|71&Prior Stay Date&NUBC^20030106^20030107|"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OSP.1",
                            Type = @"DataTypeComponent",
                            Position = @"OSP.1",
                            Name = @"Occurrence Span Code",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded With No Exceptions",
                            TableId = @"0351",
                            TableName = @"Occurrence Span",
                            Description = @"The NUBC code itself that identifies an event that relates to the payment of a claim.

Refer to HL7 Table 0351 – Occurrence Span for valid values. Values for this component need to come from National Uniform Billing Committee (NUBC). No extensions are allowed.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OSP.2",
                            Type = @"DataTypeComponent",
                            Position = @"OSP.2",
                            Name = @"Occurrence Span Start Date",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date an event started that relates to the payment of a claim.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OSP.3",
                            Type = @"DataTypeComponent",
                            Position = @"OSP.3",
                            Name = @"Occurrence Span Stop Date",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date an event ended that relates to the payment of a claim.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
