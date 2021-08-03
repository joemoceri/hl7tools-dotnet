using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TableZ003
    {
        public string Id { get { return @"Z003"; } }

        public string TableId { get { return @"Z003"; } }

        public string TableType { get { return @"Local"; } }

        public string Name { get { return @"Procedure Code Coding Systems"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"C4",
                            Description = @"CPT-4",
                            Comment = @"American Medical Association, P.O. Box 10946, Chicago IL  60610."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C5",
                            Description = @"CPT-5  ",
                            Comment = @"(under development – same contact as above)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCPCS",
                            Description = @"CMS (formerly HCFA)  Common Procedure Coding System",
                            Comment = @"HCPCS: contains codes for medical equipment, injectable drugs, transportation services, and other services not found in CPT4."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HPC",
                            Description = @"CMS (formerly HCFA) Procedure Codes (HCPCS)",
                            Comment = @"Health Care Financing Administration (HCFA) Common Procedure Coding System (HCPCS) including modifiers.[1]"
                        },
                    };
            } 
        }
    }
}
