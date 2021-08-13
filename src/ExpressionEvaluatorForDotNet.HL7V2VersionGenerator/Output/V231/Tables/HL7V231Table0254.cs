using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0254
    {
        public string Id { get { return @"0254"; } }

        public string TableId { get { return @"0254"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Kind of quantity"; } }

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
                            Value = @"ABS",
                            Description = @"Absorbance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACNC",
                            Description = @"Concentration, Arbitrary Substance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACT",
                            Description = @"*Activity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APER",
                            Description = @"Appearance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ARB",
                            Description = @"*Arbitrary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AREA",
                            Description = @"Area",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ASPECT",
                            Description = @"Aspect",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CACT",
                            Description = @"*Catalytic Activity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCNT",
                            Description = @"*Catalytic Content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCRTO",
                            Description = @"Catalytic Concentration Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CFR",
                            Description = @"*Catalytic Fraction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLAS",
                            Description = @"Class",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNC",
                            Description = @"*Catalytic Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNST",
                            Description = @"*Constant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COEF",
                            Description = @"*Coefficient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COLOR",
                            Description = @"Color",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CONS",
                            Description = @"Consistency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CRAT",
                            Description = @"*Catalytic Rate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CRTO",
                            Description = @"Catalytic Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEN",
                            Description = @"Density",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEV",
                            Description = @"Device",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DIFF",
                            Description = @"*Difference",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ELAS",
                            Description = @"Elasticity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ELPOT",
                            Description = @"Electrical Potential (Voltage)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ELRAT",
                            Description = @"Electrical current (amperage)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ELRES",
                            Description = @"Electrical Resistance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENGR",
                            Description = @"Energy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENT",
                            Description = @"*Entitic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENTCAT",
                            Description = @"*Entitic Catalytic Activity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENTNUM",
                            Description = @"*Entitic Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENTSUB",
                            Description = @"*Entitic Substance of Amount",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENTVOL",
                            Description = @"*Entitic Volume",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EQL",
                            Description = @"Equilibrium",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FORCE",
                            Description = @"Mechanical force",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FREQ",
                            Description = @"Frequency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IMP",
                            Description = @"Impression/ interpretation of study",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KINV",
                            Description = @"*Kinematic Viscosity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LEN",
                            Description = @"Length",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LINC",
                            Description = @"*Length Increment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LIQ",
                            Description = @"*Liquefaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MASS",
                            Description = @"*Mass",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCNC",
                            Description = @"*Mass Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCNT",
                            Description = @"Mass Content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCRTO",
                            Description = @"*Mass Concentration Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MFR",
                            Description = @"*Mass Fraction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MGFLUX",
                            Description = @"Magnetic flux",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MINC",
                            Description = @"*Mass Increment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MORPH",
                            Description = @"Morphology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MOTIL",
                            Description = @"Motility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRAT",
                            Description = @"*Mass Rate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRTO",
                            Description = @"*Mass Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NCNC",
                            Description = @"*Number Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NCNT",
                            Description = @"*Number Content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NFR",
                            Description = @"*Number Fraction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NRTO",
                            Description = @"*Number Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NUM",
                            Description = @"*Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OD",
                            Description = @"Optical density",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSMOL",
                            Description = @"*Osmolality",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRES",
                            Description = @"*Pressure (Partial)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRID",
                            Description = @"Presence/Identity/Existence",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PWR",
                            Description = @"Power (wattage)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RANGE",
                            Description = @"*Ranges",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RATIO",
                            Description = @"*Ratios",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RCRLTM",
                            Description = @"*Reciprocal Relative Time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RDEN",
                            Description = @"*Relative Density",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REL",
                            Description = @"*Relative",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RLMCNC",
                            Description = @"*Relative Mass Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RLSCNC",
                            Description = @"*Relative Substance Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RLTM",
                            Description = @"*Relative Time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SATFR",
                            Description = @"*Saturation Fraction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCNC",
                            Description = @"*Substance Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCNCIN",
                            Description = @"*Substance Concentration Increment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCNT",
                            Description = @"*Substance Content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCNTR",
                            Description = @"*Substance Content Rate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCRTO",
                            Description = @"*Substance Concentration Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SFR",
                            Description = @"*Substance Fraction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SHAPE",
                            Description = @"Shape",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SMELL",
                            Description = @"Smell",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRAT",
                            Description = @"*Substance Rate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRTO",
                            Description = @"*Substance Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUB",
                            Description = @"*Substance Amount",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUSC",
                            Description = @"*Susceptibility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TASTE",
                            Description = @"Taste",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEMP",
                            Description = @"*Temperature",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEMPDF",
                            Description = @"*Temperature Difference",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEMPIN",
                            Description = @"*Temperature Increment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THRMCNC",
                            Description = @"*Threshold Mass Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THRSCNC",
                            Description = @"*Threshold Substance Concentration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TIME",
                            Description = @"*Time (e.g. seconds)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TITR",
                            Description = @"*Dilution Factor (Titer)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMDF",
                            Description = @"*Time Difference",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMSTP",
                            Description = @"*Time Stamp -- Date and Time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRTO",
                            Description = @"*Time Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TYPE",
                            Description = @"*Type",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VCNT",
                            Description = @"*Volume Content",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VEL",
                            Description = @"*Velocity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VELRT",
                            Description = @"*Velocity Ratio",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VFR",
                            Description = @"*Volume Fraction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VISC",
                            Description = @"*Viscosity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VOL",
                            Description = @"*Volume",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VRAT",
                            Description = @"*Volume Rate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VRTO",
                            Description = @"*Volume Ratio",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
