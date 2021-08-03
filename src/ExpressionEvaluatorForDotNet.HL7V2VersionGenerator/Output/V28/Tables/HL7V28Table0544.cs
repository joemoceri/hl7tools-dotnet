using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0544
    {
        public string Id { get { return @"0544"; } }

        public string TableId { get { return @"0544"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Container Condition"; } }

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
                            Value = @"CC",
                            Description = @"Container Cracked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CL",
                            Description = @"Container Leaking",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CT",
                            Description = @"Container Torn",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SB",
                            Description = @"Seal Broken",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XAMB",
                            Description = @"Not Ambient temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XC37",
                            Description = @"Not Body temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCAMB",
                            Description = @"Not Critical ambient temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCATM",
                            Description = @"Exposed to Air",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCFRZ",
                            Description = @"Not Critical frozen temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCREF",
                            Description = @"Not Critical refrigerated temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XDFRZ",
                            Description = @"Not Deep frozen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XDRY",
                            Description = @"Not Dry",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XFRZ",
                            Description = @"Not Frozen temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XMTLF",
                            Description = @"Metal Exposed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XNTR",
                            Description = @"Not Liquid nitrogen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPRTL",
                            Description = @"Not Protected from light",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPSA",
                            Description = @"Shaken",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPSO",
                            Description = @"Exposed to shock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XREF",
                            Description = @"Not Refrigerated temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XUFRZ",
                            Description = @"Not Ultra frozen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XUPR",
                            Description = @"Not Upright",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
