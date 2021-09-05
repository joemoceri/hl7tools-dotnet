using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0265
    {
        public string Id { get { return @"0265"; } }

        public string TableId { get { return @"0265"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Specialty Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

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
                            Value = @"ALC",
                            Description = @"Allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AMB",
                            Description = @"Ambulatory",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAN",
                            Description = @"Cancer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAR",
                            Description = @"Coronary/cardiac care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCR",
                            Description = @"Critical care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHI",
                            Description = @"Chiropractic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDI",
                            Description = @"Education",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMR",
                            Description = @"Emergency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FPC",
                            Description = @"Family planning",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INT",
                            Description = @"Intensive care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO",
                            Description = @"Isolation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAT",
                            Description = @"Naturopathic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NBI",
                            Description = @"Newborn, nursery, infants",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OBG",
                            Description = @"Obstetrics, gynecology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OBS",
                            Description = @"Observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other specialty",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PED",
                            Description = @"Pediatrics",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PHY",
                            Description = @"General/family practice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PIN",
                            Description = @"Pediatric/neonatal intensive care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPS",
                            Description = @"Pediatric psychiatric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRE",
                            Description = @"Pediatric rehabilitation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSI",
                            Description = @"Psychiatric intensive care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSY",
                            Description = @"Psychiatric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REH",
                            Description = @"Rehabilitation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUR",
                            Description = @"Surgery",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WIC",
                            Description = @"Walk-in clinic",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
