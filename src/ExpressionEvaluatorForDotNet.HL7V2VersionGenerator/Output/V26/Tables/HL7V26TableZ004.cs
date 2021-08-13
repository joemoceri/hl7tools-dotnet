using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TableZ004
    {
        public string Id { get { return @"Z004"; } }

        public string TableId { get { return @"Z004"; } }

        public string TableType { get { return @"Local"; } }

        public string Name { get { return @"Procedure Code Modifier Coding Systems"; } }

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
                            Value = @"CPTM",
                            Description = @"CPT Modifier Code",
                            Comment = @"Available for the AMA at the address listed for CPT above. These codes are found in Appendix A of CPT 2000 Standard Edition. (CPT 2000 Standard Edition, American Medical Association, Chicago, IL)"
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
