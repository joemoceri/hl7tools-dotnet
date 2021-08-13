using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0261
    {
        public string Id { get { return @"0261"; } }

        public string TableId { get { return @"0261"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Location Equipment"; } }

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
                            Value = @"EEG",
                            Description = @"Electro-Encephalogram",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EKG",
                            Description = @"Electro-Cardiogram",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INF",
                            Description = @"Infusion pump",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IVP",
                            Description = @"IV pump",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OXY",
                            Description = @"Oxygen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUC",
                            Description = @"Suction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VEN",
                            Description = @"Ventilator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VIT",
                            Description = @"Vital signs monitor",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
