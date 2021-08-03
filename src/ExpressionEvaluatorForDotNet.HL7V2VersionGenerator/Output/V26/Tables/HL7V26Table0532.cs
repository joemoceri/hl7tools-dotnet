using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0532
    {
        public string Id { get { return @"0532"; } }

        public string TableId { get { return @"0532"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Expanded yes/no indicator"; } }

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
                            Value = @"ASKU",
                            Description = @"asked but unknown",
                            Comment = @"Information was sought but not found (e.g., patient was asked but didn't know"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"No",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"not applicable",
                            Comment = @"No proper value is applicable in this context (e.g., last menstrual period for a male)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NASK",
                            Description = @"not asked",
                            Comment = @"This information has not been sought (e.g., patient was not asked"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAV",
                            Description = @"temporarily unavailable",
                            Comment = @"Information is not available at this time but it is expected that it will be available later"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NI",
                            Description = @"No Information",
                            Comment = @"No information whatsoever can be inferred from this exceptional value. This is the most general exceptional value. It is also the default exceptional value"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"not present",
                            Comment = @"Value is not present in a message. This is only defined in messages, never in application data!  All values not present in the message must be replaced by the applicable default, or no-information (NI) as the default of all defaults"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNK",
                            Description = @"unknown",
                            Comment = @"A proper value is applicable, but not known"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"Yes",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
