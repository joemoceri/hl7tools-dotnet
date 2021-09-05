using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0292
    {
        public string Id { get { return @"0292"; } }

        public string TableId { get { return @"0292"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Vaccines administered"; } }

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
                            Value = @"01",
                            Description = @"DTP",
                            Comment = @"diphtheria, tetanus toxoids and pertussis vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"OPV",
                            Comment = @"poliovirus vaccine, live, oral"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"MMR",
                            Comment = @"measles, mumps and rubella virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"M/R",
                            Comment = @"measles and rubella virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"measles",
                            Comment = @"measles virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"rubella",
                            Comment = @"rubella virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"07",
                            Description = @"mumps",
                            Comment = @"mumps virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"08",
                            Description = @"Hep B, adolescent or pediatric",
                            Comment = @"hepatitis B vaccine, pediatric or pediatric/adolescent dosage"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"09",
                            Description = @"Td (adult)",
                            Comment = @"tetanus and diphtheria toxoids, adsorbed for adult use"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"IPV",
                            Comment = @"poliovirus vaccine, inactivated"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"100",
                            Description = @"pneumococcal conjugate",
                            Comment = @"pneumococcal conjugate vaccine, polyvalent"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"101",
                            Description = @"typhoid, ViCPs",
                            Comment = @"Typhoid Vi capsular polysaccharide vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"pertussis",
                            Comment = @"pertussis vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12",
                            Description = @"diphtheria antitoxin",
                            Comment = @"diphtheria antitoxin"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"13",
                            Description = @"TIG",
                            Comment = @"tetanus immune globulin"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"14",
                            Description = @"IG, NOS",
                            Comment = @"immune globulin, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"15",
                            Description = @"influenza, split  (incl. purified surface antigen)",
                            Comment = @"influenza virus vaccine, split virus (incl. purified surface antigen)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"16",
                            Description = @"influenza, whole",
                            Comment = @"influenza virus vaccine, whole virus"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"17",
                            Description = @"Hib, NOS",
                            Comment = @"Haemophilus influenzae type b vaccine, conjugate NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"18",
                            Description = @"rabies, intramuscular injection",
                            Comment = @"rabies vaccine, for intramuscular injection"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"19",
                            Description = @"BCG",
                            Comment = @"Bacillus Calmette-Guerin vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"20",
                            Description = @"DTaP",
                            Comment = @"diphtheria, tetanus toxoids and acellular pertussis vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21",
                            Description = @"varicella",
                            Comment = @"varicella virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"22",
                            Description = @"DTP-Hib",
                            Comment = @"DTP-Haemophilus influenzae type b conjugate vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"23",
                            Description = @"plague",
                            Comment = @"plague vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"24",
                            Description = @"anthrax",
                            Comment = @"anthrax vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"25",
                            Description = @"typhoid, oral",
                            Comment = @"typhoid vaccine, live, oral"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"26",
                            Description = @"cholera",
                            Comment = @"cholera vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"27",
                            Description = @"botulinum antitoxin",
                            Comment = @"botulinum antitoxin"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"28",
                            Description = @"DT (pediatric)",
                            Comment = @"diphtheria and tetanus toxoids, adsorbed for pediatric use"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"29",
                            Description = @"CMVIG",
                            Comment = @"cytomegalovirus immune globulin, intravenous"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30",
                            Description = @"HBIG",
                            Comment = @"hepatitis B immune globulin"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Hep A, pediatric, NOS",
                            Comment = @"hepatitis A vaccine, pediatric dosage, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"32",
                            Description = @"meningococcal",
                            Comment = @"meningococcal polysaccharide vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"33",
                            Description = @"pneumococcal",
                            Comment = @"pneumococcal  polysaccharide vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"34",
                            Description = @"RIG",
                            Comment = @"rabies immune globulin"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"35",
                            Description = @"tetanus toxoid",
                            Comment = @"tetanus toxoid"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"36",
                            Description = @"VZIG",
                            Comment = @"varicella zoster immune globulin"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"37",
                            Description = @"yellow fever",
                            Comment = @"yellow fever vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"38",
                            Description = @"rubella/mumps",
                            Comment = @"rubella and mumps virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"39",
                            Description = @"Japanese encephalitis",
                            Comment = @"Japanese encephalitis vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40",
                            Description = @"rabies, intradermal injection",
                            Comment = @"rabies vaccine, for intradermal injection"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41",
                            Description = @"typhoid, parenteral",
                            Comment = @"typhoid vaccine, parenteral, other than acetone-killed, dried"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"42",
                            Description = @"Hep B, adolescent/high risk infant2",
                            Comment = @"hepatitis B vaccine, adolescent/high risk infant dosage"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"43",
                            Description = @"Hep B, adult4",
                            Comment = @"hepatitis B vaccine, adult dosage"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"44",
                            Description = @"Hep B, dialysis",
                            Comment = @"hepatitis B vaccine, dialysis patient dosage"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"45",
                            Description = @"Hep B, NOS",
                            Comment = @"hepatitis B vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"46",
                            Description = @"Hib (PRP-D)",
                            Comment = @"Haemophilus influenzae type b vaccine, PRP-D conjugate"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"47",
                            Description = @"Hib (HbOC)",
                            Comment = @"Haemophilus influenzae type b vaccine, HbOC conjugate"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"48",
                            Description = @"Hib (PRP-T)",
                            Comment = @"Haemophilus influenzae type b vaccine, PRP-T conjugate"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"49",
                            Description = @"Hib (PRP-OMP)",
                            Comment = @"Haemophilus influenzae type b vaccine, PRP-OMP conjugate"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"50",
                            Description = @"DTaP-Hib",
                            Comment = @"DTaP-Haemophilus influenzae type b conjugate vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"51",
                            Description = @"Hib-Hep B",
                            Comment = @"Haemophilus influenzae type b conjugate and Hepatitis B vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"52",
                            Description = @"Hep A, adult",
                            Comment = @"hepatitis A vaccine, adult dosage"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"53",
                            Description = @"typhoid, parenteral, AKD (U.S. military)",
                            Comment = @"typhoid vaccine, parenteral, acetone-killed, dried (U.S. military)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"54",
                            Description = @"adenovirus, type 4",
                            Comment = @"adenovirus vaccine, type 4, live, oral"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"55",
                            Description = @"adenovirus, type 7",
                            Comment = @"adenovirus vaccine, type 7, live, oral"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"56",
                            Description = @"dengue fever",
                            Comment = @"dengue fever vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"57",
                            Description = @"hantavirus",
                            Comment = @"hantavirus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"58",
                            Description = @"Hep C",
                            Comment = @"hepatitis C vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"59",
                            Description = @"Hep E",
                            Comment = @"hepatitis E vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"60",
                            Description = @"herpes simplex 2",
                            Comment = @"herpes simplex virus, type 2 vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"61",
                            Description = @"HIV",
                            Comment = @"human immunodeficiency virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"62",
                            Description = @"HPV",
                            Comment = @"human papilloma virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"63",
                            Description = @"Junin virus",
                            Comment = @"Junin virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"64",
                            Description = @"leishmaniasis",
                            Comment = @"leishmaniasis vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"65",
                            Description = @"leprosy",
                            Comment = @"leprosy vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"66",
                            Description = @"Lyme disease",
                            Comment = @"Lyme disease vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"67",
                            Description = @"malaria",
                            Comment = @"malaria vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"68",
                            Description = @"melanoma",
                            Comment = @"melanoma vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"69",
                            Description = @"parainfluenza-3",
                            Comment = @"parainfluenza-3 virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"70",
                            Description = @"Q fever",
                            Comment = @"Q fever vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"71",
                            Description = @"RSV-IGIV",
                            Comment = @"respiratory syncytial virus immune globulin, intravenous"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"72",
                            Description = @"rheumatic fever",
                            Comment = @"rheumatic fever vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"73",
                            Description = @"Rift Valley fever",
                            Comment = @"Rift Valley fever vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"74",
                            Description = @"rotavirus",
                            Comment = @"rotavirus vaccine, tetravalent, live, oral"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"75",
                            Description = @"smallpox",
                            Comment = @"smallpox vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"76",
                            Description = @"Staphylococcus bacterio lysate",
                            Comment = @"Staphylococcus bacteriophage lysate"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"77",
                            Description = @"tick-borne encephalitis",
                            Comment = @"tick-borne encephalitis vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"78",
                            Description = @"tularemia vaccine",
                            Comment = @"tularemia vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"79",
                            Description = @"vaccinia immune globulin",
                            Comment = @"vaccinia immune globulin"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"80",
                            Description = @"VEE, live",
                            Comment = @"Venezuelan equine encephalitis, live, attenuated"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"81",
                            Description = @"VEE, inactivated",
                            Comment = @"Venezuelan equine encephalitis, inactivated"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"82",
                            Description = @"adenovirus, NOS1",
                            Comment = @"adenovirus vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"83",
                            Description = @"Hep A, ped/adol, 2 dose",
                            Comment = @"hepatitis A vaccine, pediatric/adolescent dosage, 2 dose schedule"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"84",
                            Description = @"Hep A, ped/adol, 3 dose",
                            Comment = @"hepatitis A vaccine, pediatric/adolescent dosage, 3 dose schedule"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"85",
                            Description = @"Hep A, NOS",
                            Comment = @"hepatitis A vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"86",
                            Description = @"IG",
                            Comment = @"immune globulin, intramuscular"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"87",
                            Description = @"IGIV",
                            Comment = @"immune globulin, intravenous"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"88",
                            Description = @"influenza, NOS",
                            Comment = @"influenza virus vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"89",
                            Description = @"polio, NOS",
                            Comment = @"poliovirus vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"90",
                            Description = @"rabies, NOS",
                            Comment = @"rabies vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"91",
                            Description = @"typhoid, NOS",
                            Comment = @"typhoid vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"92",
                            Description = @"VEE, NOS",
                            Comment = @"Venezuelan equine encephalitis vaccine, NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"93",
                            Description = @"RSV-Mab",
                            Comment = @"respiratory syncytial virus monoclonal antibody (palivizumab), intramuscular"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"94",
                            Description = @"MMRV",
                            Comment = @"measles, mumps, rubella, and varicella virus vaccine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"95",
                            Description = @"TST-OT tine test",
                            Comment = @"tuberculin skin test; old tuberculin, multipuncture device"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"96",
                            Description = @"TST-PPD intradermal",
                            Comment = @"tuberculin skin test; purified protein derivative solution, intradermal"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"97",
                            Description = @"TST-PPD tine test",
                            Comment = @"tuberculin skin test; purified protein derivative, multipuncture device"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"98",
                            Description = @"TST, NOS",
                            Comment = @"tuberculin skin test; NOS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"99",
                            Description = @"RESERVED - do not use3",
                            Comment = @"RESERVED - do not use"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"999",
                            Description = @"unknown",
                            Comment = @"unknown vaccine or immune globulin"
                        },
                        
                    };
            } 
        }
    }
}
