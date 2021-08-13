using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0617
    {
        public string Id { get { return @"0617"; } }

        public string TableId { get { return @"0617"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Address Usage"; } }

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
                            Value = @"C",
                            Description = @"Classification",
                            Comment = @"Identifies an address used for the purpose of demographic classification or searching.  Such addresses frequently contain insufficient information to be used as mailing or visit addresses.  For example, they may only indicate country and postal code, without providing a street address."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Mailing",
                            Comment = @"Identifies an address for mail correspondence from a healthcare provider as stipulated by the subject. For example, under the tenets of certain privacy regulations, it is exclusive to the patient and is typically maintained at the encounter or visit level versus the person level as it only has relevance to the specifics of a given encounter.  This is an exception category of address in that the patient has stipulated that they want all correspondence relevant to a given encounter sent to this address in lieu of any other address on file.  Providers are required to accommodate such requests under HIPAA promulgated regulation.  Note that mailing and legal address may be mutually exclusive as defined below.  (Implementors are reminded that although the privacy regulation requires the provider to honor such requests, it does require the provider to enquire whether the patient has a preferred address other than the one volunteered.)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Visit",
                            Comment = @"Identifies an address at which the individual is physically located and may be visited."
                        },
                        
                    };
            } 
        }
    }
}
