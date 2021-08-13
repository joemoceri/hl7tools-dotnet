using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0530
    {
        public string Id { get { return @"0530"; } }

        public string TableId { get { return @"0530"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Organization, agency, department"; } }

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
                            Value = @"AE",
                            Description = @"American Express",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEA",
                            Description = @"Drug Enforcement Agency",
                            Comment = @"The US Drug Enforcement Administration does not solely assign DEA numbers in the United States. Hospitals have the authority to issue DEA numbers to their medical residents. These DEA numbers are based upon the hospital’s DEA number, but the authority rests with the hospital on the assignment to the residents. Thus, DEA as an Assigning Authority is necessary in addition to DEA as an Identifier Type."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DOD",
                            Description = @"Department of Defense",
                            Comment = @"In some countries e.g., the US, more than one department may issue a military identifier. Hence, US is not sufficient as the Assigning Authority."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Master Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VA",
                            Description = @"Veterans Affairs",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VI",
                            Description = @"Visa",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
