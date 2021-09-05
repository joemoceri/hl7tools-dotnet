using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0376
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
                            Description = @"Ambient temperature",
                            Comment = @"Keep at ambient (room) temperature, approximately 22 ± 2 degrees C. Accidental refrigeration or freezing is of little consequence"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C37",
                            Description = @"Body temperature",
                            Comment = @"Critical to keep at body temperature: 36 - 38° C."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAMB",
                            Description = @"Critical ambient temperature",
                            Comment = @"Critical ambient - must not be refrigerated or frozen."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CATM",
                            Description = @"Protect from air",
                            Comment = @"Critical. Do not expose to atmosphere. Do not uncap."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CFRZ",
                            Description = @"Critical frozen temperature",
                            Comment = @"Critical frozen - must not be allowed to thaw until immediately prior to testing"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CREF",
                            Description = @"Critical refrigerated temperature",
                            Comment = @"Critical refrigerated -  must not be allowed to freeze or warm until immediately prior to testing"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DFRZ",
                            Description = @"Deep frozen",
                            Comment = @"Deep frozen: -16 to -20° C."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DRY",
                            Description = @"Dry",
                            Comment = @"Keep in a dry environment."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FRZ",
                            Description = @"Frozen temperature",
                            Comment = @"Keep at frozen temperature: -4° C. Accidental thawing is of little consequence"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MTLF",
                            Description = @"Metal Free",
                            Comment = @"Container is free of heavy metals including lead."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NTR",
                            Description = @"Liquid nitrogen",
                            Comment = @"Keep in liquid nitrogen."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRTL",
                            Description = @"Protect from light",
                            Comment = @"Protect from light (e.g., wrap in aluminum foil)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSA",
                            Description = @"Do not shake",
                            Comment = @"Do not shake."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSO",
                            Description = @"No shock",
                            Comment = @"Protect from shock."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REF",
                            Description = @"Refrigerated temperature",
                            Comment = @"Keep at refrigerated temperature: 4-8° C. Accidental warming or freezing is of little consequence"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UFRZ",
                            Description = @"Ultra frozen",
                            Comment = @"Ultra cold frozen: ~ -75 to -85° C. (ultra cold freezer is typically at temperature of dry ice)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPR",
                            Description = @"Upright",
                            Comment = @"Keep upright. Do not turn upside down."
                        },
                        
                    };
            } 
        }
    }
}
