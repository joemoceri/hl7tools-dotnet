using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0702
    {
        public string Id { get { return @"0702"; } }

        public string TableId { get { return @"0702"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Cycle Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Value = @"2RS",
                            Description = @"Second Rinse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANR",
                            Description = @"Anesthesia/Respiratory",
                            Comment = @"Special Wash cycle"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BDP",
                            Description = @"Bedpans",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BWD",
                            Description = @"Bowie-Dick Test",
                            Comment = @"A Bowie-Dick test cycle is a special cycle used to test the integrity of the sterilizer chamber to hold a vacuum."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CMW",
                            Description = @"Chemical Wash",
                            Comment = @"A chemical wash cycle."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COD",
                            Description = @"Code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CRT",
                            Description = @"Cart Wash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEC",
                            Description = @"Decontamination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DRT",
                            Description = @"Dart",
                            Comment = @"A dart cycle is a special cycle used to test the integrity of the sterilizer chamber to hold a vacuum."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DRW",
                            Description = @"Dart Warm-up Cycle",
                            Comment = @"A dart warm-up cycle is used to bring the sterilizer chamber up to operating temperature in order to run a dart test cycle."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EOH",
                            Description = @"EO High Temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EOL",
                            Description = @"EO Low Temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXP",
                            Description = @"Express",
                            Comment = @"An express cycle is similar to a flash cycle but the supply item is wrapped."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FLS",
                            Description = @"Flash",
                            Comment = @"Used to quickly sterilize instruments that were dropped during surgery."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GLS",
                            Description = @"Glassware",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GNP",
                            Description = @"Gen. Purpose",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GRV",
                            Description = @"Gravity",
                            Comment = @"A gravity cycle is executed at atmospheric pressure."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GTL",
                            Description = @"Gentle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO",
                            Description = @"Isothermal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IST",
                            Description = @"Instrument Wash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LKT",
                            Description = @"Leak Test",
                            Comment = @"A leak test cycle tests the integrity of the sterilizer chamber to hold a vacuum over a specific period of time."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LQD",
                            Description = @"Liquid",
                            Comment = @"A cycle specific to sterilizing liquids."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OPW",
                            Description = @"Optional Wash",
                            Comment = @"Any Optional Wash cycle"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PEA",
                            Description = @"Peracetic Acid",
                            Comment = @"A peracetic acid cycle."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLA",
                            Description = @"Plastic Goods Wash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRV",
                            Description = @"Prevac",
                            Comment = @"A prevac cycle is vacuum assisted."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RNS",
                            Description = @"Rinse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SFP",
                            Description = @"Steam Flush Pressure Pulse",
                            Comment = @"An SFPP cycle uses steam pulses instead of a vacuum during the conditioning phase of the cycle when the supply item is wrapped."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THR",
                            Description = @"Thermal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRB",
                            Description = @"Tray/Basin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UTL",
                            Description = @"Utensil Wash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WFP",
                            Description = @"Wrap/Steam Flush Pressure Pulse (Wrap/SFPP)",
                            Comment = @"A Wrap/SFPP cycle uses steam pulses instead of a vacuum during the conditioning phase of the cycle when the supply item is unwrapped."
                        },
                    };
            } 
        }
    }
}
