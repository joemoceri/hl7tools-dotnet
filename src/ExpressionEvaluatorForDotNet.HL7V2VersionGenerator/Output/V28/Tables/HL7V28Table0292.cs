using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0292
    {
        public string Id { get { return @"0292"; } }

        public string TableId { get { return @"0292"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Vaccines Administered"; } }

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
                            Value = @"01",
                            Description = @"DTP",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"OPV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"MMR",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"M/R",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"measles",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"rubella",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"07",
                            Description = @"mumps",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"08",
                            Description = @"Hep B, adolescent or pediatric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"09",
                            Description = @"Td (adult)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"IPV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"100",
                            Description = @"pneumococcal conjugate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"101",
                            Description = @"typhoid, ViCPs",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"102",
                            Description = @"DTP-Hib-Hep B",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"103",
                            Description = @"meningococcal C conjugate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"104",
                            Description = @"Hep A-Hep B",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"105",
                            Description = @"vaccinia (smallpox) diluted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"106",
                            Description = @"DTaP, 5 pertussis antigens6",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"107",
                            Description = @"DTaP, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"108",
                            Description = @"meningococcal, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"109",
                            Description = @"pneumococcal, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"pertussis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"110",
                            Description = @"DTaP-Hep B-IPV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"111",
                            Description = @"influenza, live, intranasal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"112",
                            Description = @"tetanus toxoid, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"113",
                            Description = @"Td (adult)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"114",
                            Description = @"meningococcal A,C,Y,W-135 diphtheria conjugate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"115",
                            Description = @"Tdap",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"116",
                            Description = @"rotavirus, pentavalent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"117",
                            Description = @"VZIG (IND)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"118",
                            Description = @"HPV, bivalent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"119",
                            Description = @"rotavirus, monovalent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12",
                            Description = @"diphtheria antitoxin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"120",
                            Description = @"DTaP-Hib-IPV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"121",
                            Description = @"zoster",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"122",
                            Description = @"rotavirus, NOS1",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"13",
                            Description = @"TIG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"14",
                            Description = @"IG, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"15",
                            Description = @"influenza, split (incl. purified surface antigen)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"16",
                            Description = @"influenza, whole",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"17",
                            Description = @"Hib, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"18",
                            Description = @"rabies, intramuscular injection",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"19",
                            Description = @"BCG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"20",
                            Description = @"DTaP",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21",
                            Description = @"varicella",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"22",
                            Description = @"DTP-Hib",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"23",
                            Description = @"plague",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"24",
                            Description = @"anthrax",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"25",
                            Description = @"typhoid, oral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"26",
                            Description = @"cholera",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"27",
                            Description = @"botulinum antitoxin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"28",
                            Description = @"DT (pediatric)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"29",
                            Description = @"CMVIG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30",
                            Description = @"HBIG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Hep A, pediatric, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"32",
                            Description = @"meningococcal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"33",
                            Description = @"pneumococcal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"34",
                            Description = @"RIG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"35",
                            Description = @"tetanus toxoid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"36",
                            Description = @"VZIG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"37",
                            Description = @"yellow fever",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"38",
                            Description = @"rubella/mumps",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"39",
                            Description = @"Japanese encephalitis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40",
                            Description = @"rabies, intradermal injection",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41",
                            Description = @"typhoid, parenteral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"42",
                            Description = @"Hep B, adolescent/high risk infant2",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"43",
                            Description = @"Hep B, adult4",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"44",
                            Description = @"Hep B, dialysis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"45",
                            Description = @"Hep B, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"46",
                            Description = @"Hib (PRP-D)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"47",
                            Description = @"Hib (HbOC)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"48",
                            Description = @"Hib (PRP-T)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"49",
                            Description = @"Hib (PRP-OMP)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"50",
                            Description = @"DTaP-Hib",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"51",
                            Description = @"Hib-Hep B",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"52",
                            Description = @"Hep A, adult",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"53",
                            Description = @"typhoid, parenteral, AKD (U.S. military)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"54",
                            Description = @"adenovirus, type 4",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"55",
                            Description = @"adenovirus, type 7",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"56",
                            Description = @"dengue fever",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"57",
                            Description = @"hantavirus",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"58",
                            Description = @"Hep C",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"59",
                            Description = @"Hep E",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"60",
                            Description = @"herpes simplex 2",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"61",
                            Description = @"HIV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"62",
                            Description = @"HPV, quadrivalent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"63",
                            Description = @"Junin virus",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"64",
                            Description = @"leishmaniasis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"65",
                            Description = @"leprosy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"66",
                            Description = @"Lyme disease",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"67",
                            Description = @"malaria",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"68",
                            Description = @"melanoma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"69",
                            Description = @"parainfluenza-3",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"70",
                            Description = @"Q fever",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"71",
                            Description = @"RSV-IGIV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"72",
                            Description = @"rheumatic fever",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"73",
                            Description = @"Rift Valley fever",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"74",
                            Description = @"rotavirus, tetravalent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"75",
                            Description = @"vaccinia (smallpox)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"76",
                            Description = @"Staphylococcus bacterio lysate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"77",
                            Description = @"tick-borne encephalitis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"78",
                            Description = @"tularemia vaccine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"79",
                            Description = @"vaccinia immune globulin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"80",
                            Description = @"VEE, live",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"81",
                            Description = @"VEE, inactivated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"82",
                            Description = @"adenovirus, NOS1",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"83",
                            Description = @"Hep A, ped/adol, 2 dose",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"84",
                            Description = @"Hep A, ped/adol, 3 dose",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"85",
                            Description = @"Hep A, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"86",
                            Description = @"IG",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"87",
                            Description = @"IGIV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"88",
                            Description = @"influenza, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"89",
                            Description = @"polio, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"90",
                            Description = @"rabies, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"91",
                            Description = @"typhoid, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"92",
                            Description = @"VEE, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"93",
                            Description = @"RSV-MAb",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"94",
                            Description = @"MMRV",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"95",
                            Description = @"TST-OT tine test",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"96",
                            Description = @"TST-PPD intradermal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"97",
                            Description = @"TST-PPD tine test",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"98",
                            Description = @"TST, NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"99",
                            Description = @"RESERVED - do not use3",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"998",
                            Description = @"no vaccine administered5",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"999",
                            Description = @"unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
