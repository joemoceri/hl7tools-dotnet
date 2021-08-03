using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0036
    {
        public string Id { get { return @"0036"; } }

        public string TableId { get { return @"0036"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"UNITS OF MEASURE - ISO528,1977"; } }

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
                            Value = @"BT",
                            Description = @"Bottle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EA",
                            Description = @"Each",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GM",
                            Description = @"Grams",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KG",
                            Description = @"Kilograms",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEQ",
                            Description = @"Milliequivalent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MG",
                            Description = @"Milligrams",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OZ",
                            Description = @"Ounces",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SC",
                            Description = @"Square centimeters",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TB",
                            Description = @"Tablet",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VL",
                            Description = @"Vial",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
