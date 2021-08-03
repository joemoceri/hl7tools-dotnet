using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0038
    {
        public string Id { get { return @"0038"; } }

        public string TableId { get { return @"0038"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ORDER STATUS"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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
                            Value = @"CA",
                            Description = @"Order was canceled",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM",
                            Description = @"Order is completed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DC",
                            Description = @"Order was discontinued",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ER",
                            Description = @"Error - order not found",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HD",
                            Description = @"Order is on hold",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IP",
                            Description = @"In process - unspecified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Order has been replaced",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SC",
                            Description = @"In process - scheduled",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
