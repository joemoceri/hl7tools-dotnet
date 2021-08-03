using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0227
    {
        public string Id { get { return @"0227"; } }

        public string TableId { get { return @"0227"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Manufacturers of Vaccines"; } }

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
                            Value = @"AB",
                            Description = @"Abbott Laboratories",
                            Comment = @"(includes Ross Products Division)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AD",
                            Description = @"Adams Laboratories, Inc.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALP",
                            Description = @"Alpha Therapeutic Corporation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AR",
                            Description = @"Armour",
                            Comment = @"[Inactive-use CEN]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AVB",
                            Description = @"Aventis Behring L.L.C.",
                            Comment = @"(formerly Centeon L.L.C.; includes Armour Pharmaceutical Company)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AVI",
                            Description = @"Aviron",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BA",
                            Description = @"Baxter Healthcare Coporation]",
                            Comment = @"[Inactive-use BAH"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAH",
                            Description = @"Baxter Health Corporation",
                            Comment = @"(includes Hyland Immuno, Immuno International AG, and North American Vaccine, Inc.)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAY",
                            Description = @"Bayer Corporation",
                            Comment = @"(includes Miles, Inc. and Cutter Laboratories)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BP",
                            Description = @"Berna Products",
                            Comment = @"[Inactive-use BPC]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BPC",
                            Description = @"Berna Products Corporation",
                            Comment = @"(includes Swiss Serum and Vaccine Institute Berne)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CEN",
                            Description = @"Centeon L.L.C.",
                            Comment = @"[Inactive--use AVB]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHI",
                            Description = @"Chiron Corporation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CMP",
                            Description = @"Celltech Medeva Pharmaceuticals",
                            Comment = @"[Inactive--use PWJ]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CON",
                            Description = @"Connaught",
                            Comment = @"[Inactive-use PMC]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EVN",
                            Description = @"Evans Medical Limited",
                            Comment = @"[Inactive--use PWJ]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GRE",
                            Description = @"Greer Laboratories, Inc.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IAG",
                            Description = @"Immuno International AG",
                            Comment = @"[Inactive-use BAH]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IM",
                            Description = @"Merieux",
                            Comment = @"[Inactive-use PMC]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IUS",
                            Description = @"Immuno-U.S., Inc.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JPN",
                            Description = @"The Research Foundation for Microbial Diseases of Osaka University",
                            Comment = @"(BIKEN)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KGC",
                            Description = @"Korea Green Cross Corporation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LED",
                            Description = @"Lederle",
                            Comment = @"[Inactive-use WAL]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Massachusetts Public Health Biologic Laboratories",
                            Comment = @"[Inactive-use MBL]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MBL",
                            Description = @"Massachusetts Biologic Laboratories",
                            Comment = @"(formerly Massachusetts Public Health Biologic Laboratories)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MED",
                            Description = @"MedImmune, Inc.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MIL",
                            Description = @"Miles",
                            Comment = @"[Inactive-use BAY]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MIP",
                            Description = @"Bioport Corporation",
                            Comment = @"(formerly Michigan Biologic Products Institute)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MSD",
                            Description = @"Merck & Co., Inc.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAB",
                            Description = @"NABI",
                            Comment = @"(formerly North American Biologicals, Inc.)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAV",
                            Description = @"North American Vaccine, Inc.",
                            Comment = @"[Inactive-use BAH]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NOV",
                            Description = @"Novartis Pharmaceutical Corporation",
                            Comment = @"(includes Ciba-Geigy Limited and Sandoz Limited)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NYB",
                            Description = @"New York Blood Center",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORT",
                            Description = @"Ortho-Clinical Diagnostics.",
                            Comment = @"(formerly Ortho Diagnostics Systems, Inc.)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTC",
                            Description = @"Organon Teknika Corporation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other manufacturer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PD",
                            Description = @"Parkedale Pharmaceuticals",
                            Comment = @"(formerly Parke-Davis)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PMC",
                            Description = @"Aventis Pasteur Inc.",
                            Comment = @"(formerly Pasteur Merieux Connaught; includes Connaught Laboratories and Pasteur Merieux)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRX",
                            Description = @"Praxis Biologics",
                            Comment = @"[Inactive-use WAL]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PWJ",
                            Description = @"PowerJect Pharamaceuticals",
                            Comment = @"(includes Celltech Medeva Vaccines and Evans Medical Limited)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCL",
                            Description = @"Sclavo, Inc.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Swiss Serum and Vaccine Inst.",
                            Comment = @"[Inactive-use BPC]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SKB",
                            Description = @"GlaxoSmithKline",
                            Comment = @"(formerly SmithKline Beecham; includes SmithKline Beecham and Glaxo Wellcome)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNK",
                            Description = @"Unknown manufacturer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USA",
                            Description = @"United States Army Medical Research and Material Command",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WA",
                            Description = @"Wyeth-Ayerst",
                            Comment = @"[Inactive-use WAL]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WAL",
                            Description = @"Wyeth-Ayerst",
                            Comment = @"(includes Weyth-Lederle Vaccines and Pediatrics, Wyeth Laboratories, Lederle Laboratories, and Praxis Biologics)"
                        },
                    };
            } 
        }
    }
}
