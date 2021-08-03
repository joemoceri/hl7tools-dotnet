using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2251Table0376
    {
        public string Id { get { return @"0376"; } }

        public string TableId { get { return @"0376"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Special Handling Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Value = @"AMB",
                            Description = @"Tool",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C37",
                            Description = @"Body temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAMB",
                            Description = @"Critical ambient temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CATM",
                            Description = @"Protect from air",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CFRZ",
                            Description = @"Critical frozen temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CREF",
                            Description = @"Critical refrigerated temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DFRZ",
                            Description = @"Deep frozen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DRY",
                            Description = @"Dry",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FRZ",
                            Description = @"Frozen temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MTLF",
                            Description = @"Metal Free",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NTR",
                            Description = @"Liquid nitrogen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRTL",
                            Description = @"Protect from light",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSA",
                            Description = @"Do not shake",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSO",
                            Description = @"No shock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REF",
                            Description = @"Refrigerated temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UFRZ",
                            Description = @"Ultra frozen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPR",
                            Description = @"Upright",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
