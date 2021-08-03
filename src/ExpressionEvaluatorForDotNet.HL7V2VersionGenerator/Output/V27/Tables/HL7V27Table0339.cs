using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0339
    {
        public string Id { get { return @"0339"; } }

        public string TableId { get { return @"0339"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Advanced Beneficiary Notice Code"; } }

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
                            Value = @"1",
                            Description = @"Service is subject to medical necessity procedures",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Patient has been informed of responsibility, and agrees to pay for service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Patient has been informed of responsibility, and asks that the payer be billed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Advanced Beneficiary Notice has not been signed",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
