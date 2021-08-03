using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0914
    {
        public string Id { get { return @"0914"; } }

        public string TableId { get { return @"0914"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Root Cause"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"AP",
                            Description = @"Analysis Process",
                            Comment = @"Enter (AP) when ANALYSIS PROCESS is the reason due to:
- Product or supply failure (reagents, calibrators, QC material)
- Equipment or instrumentation failure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IM",
                            Description = @"Information Management",
                            Comment = @"Enter (IM) when INFORMATION MANAGEMENT is the reason due to:
- Database or Programming issues
- Overriding of test results
- Inaccurate calculations
- Inaccurate flagging, reference ranges, units of measure
- Incomplete/inaccurate transmission of test results
- Other"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Laboratory",
                            Comment = @"Enter (L) when LABORATORY is the reason due to:
- Data Entry error
- Testing/Technical error
- Repeat testing causing change to test result"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Not Applicable",
                            Comment = @"Enter (NA) when NOT-APPLICABLE is the reason due to:
- If no revisions performed or 
- unable to determine reason for revision
Note:  Do not use NA if result code status is not corrected (revised) or if a preliminary release of results with a correction (revision)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PD",
                            Description = @"Placer Data",
                            Comment = @"Enter (PD) when new or changed PLACER DATA information is the reason due to:
- Changed patient demographics or
- Result code data provided by the client on the requisition or specimen manifest that will be entered during order entry (i.e. Previous Biopsy Date, Clinical Information, Source, etc...)"
                        },
                    };
            } 
        }
    }
}
