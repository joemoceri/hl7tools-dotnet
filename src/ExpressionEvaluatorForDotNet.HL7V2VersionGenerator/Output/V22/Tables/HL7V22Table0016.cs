using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0016
    {
        public string Id { get { return @"0016"; } }

        public string TableId { get { return @"0016"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"ISOLATION"; } }

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
                            Value = @"0",
                            Description = @"Antibiotic Resistance Precautions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Blood and Needle Precautions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Enteric Precautions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Neutropenic Precautions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Pregnant Women Precautions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Respiratory Isolation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6",
                            Description = @"Secretion / Excretion Precautions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"7",
                            Description = @"Strict Isolation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8",
                            Description = @"Wound and skin Precautions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9",
                            Description = @"Precautions",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
