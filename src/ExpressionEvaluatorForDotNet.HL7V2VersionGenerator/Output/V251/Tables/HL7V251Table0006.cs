using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0006
    {
        public string Id { get { return @"0006"; } }

        public string TableId { get { return @"0006"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Religion"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Value = @"ABC",
                            Description = @"Christian: American Baptist Church",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AGN",
                            Description = @"Agnostic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AME",
                            Description = @"Christian: African Methodist Episcopal Zion",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AMT",
                            Description = @"Christian: African Methodist Episcopal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANG",
                            Description = @"Christian: Anglican",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AOG",
                            Description = @"Christian: Assembly of God",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ATH",
                            Description = @"Atheist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAH",
                            Description = @"Baha'i",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAP",
                            Description = @"Christian: Baptist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BMA",
                            Description = @"Buddhist: Mahayana",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BOT",
                            Description = @"Buddhist: Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BTA",
                            Description = @"Buddhist: Tantrayana",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BTH",
                            Description = @"Buddhist: Theravada",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BUD",
                            Description = @"Buddhist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAT",
                            Description = @"Christian: Roman Catholic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CFR",
                            Description = @"Chinese Folk Religionist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHR",
                            Description = @"Christian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHS",
                            Description = @"Christian: Christian Science",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CMA",
                            Description = @"Christian: Christian Missionary Alliance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNF",
                            Description = @"Confucian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COC",
                            Description = @"Christian: Church of Christ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COG",
                            Description = @"Christian: Church of God",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COI",
                            Description = @"Christian: Church of God in Christ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COL",
                            Description = @"Christian: Congregational",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COM",
                            Description = @"Christian: Community",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COP",
                            Description = @"Christian: Other Pentecostal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COT",
                            Description = @"Christian: Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CRR",
                            Description = @"Christian: Christian Reformed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EOT",
                            Description = @"Christian: Eastern Orthodox",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EPI",
                            Description = @"Christian: Episcopalian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ERL",
                            Description = @"Ethnic Religionist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EVC",
                            Description = @"Christian: Evangelical Church",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FRQ",
                            Description = @"Christian: Friends",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FWB",
                            Description = @"Christian: Free Will Baptist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GRE",
                            Description = @"Christian: Greek Orthodox",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HIN",
                            Description = @"Hindu",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HOT",
                            Description = @"Hindu: Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HSH",
                            Description = @"Hindu: Shaivites",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HVA",
                            Description = @"Hindu: Vaishnavites",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JAI",
                            Description = @"Jain",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JCO",
                            Description = @"Jewish: Conservative",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JEW",
                            Description = @"Jewish",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JOR",
                            Description = @"Jewish: Orthodox",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JOT",
                            Description = @"Jewish: Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JRC",
                            Description = @"Jewish: Reconstructionist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JRF",
                            Description = @"Jewish: Reform",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JRN",
                            Description = @"Jewish: Renewal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JWN",
                            Description = @"Christian: Jehovah's Witness",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LMS",
                            Description = @"Christian: Lutheran Missouri Synod",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LUT",
                            Description = @"Christian: Lutheran",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEN",
                            Description = @"Christian: Mennonite",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MET",
                            Description = @"Christian: Methodist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MOM",
                            Description = @"Christian: Latter-day Saints",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MOS",
                            Description = @"Muslim",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MOT",
                            Description = @"Muslim: Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MSH",
                            Description = @"Muslim: Shiite",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MSU",
                            Description = @"Muslim: Sunni",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAM",
                            Description = @"Native American",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAZ",
                            Description = @"Christian: Church of the Nazarene",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NOE",
                            Description = @"Nonreligious",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NRL",
                            Description = @"New Religionist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORT",
                            Description = @"Christian: Orthodox",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PEN",
                            Description = @"Christian: Pentecostal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRC",
                            Description = @"Christian: Other Protestant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRE",
                            Description = @"Christian: Presbyterian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRO",
                            Description = @"Christian: Protestant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QUA",
                            Description = @"Christian: Friends",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REC",
                            Description = @"Christian: Reformed Church",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REO",
                            Description = @"Christian: Reorganized Church of Jesus Christ-LDS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAA",
                            Description = @"Christian: Salvation Army",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SEV",
                            Description = @"Christian: Seventh Day Adventist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SHN",
                            Description = @"Shintoist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SIK",
                            Description = @"Sikh",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SOU",
                            Description = @"Christian: Southern Baptist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPI",
                            Description = @"Spiritist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UCC",
                            Description = @"Christian: United Church of Christ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UMD",
                            Description = @"Christian: United Methodist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNI",
                            Description = @"Christian: Unitarian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNU",
                            Description = @"Christian: Unitarian Universalist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VAR",
                            Description = @"Unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WES",
                            Description = @"Christian: Wesleyan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WMC",
                            Description = @"Christian: Wesleyan Methodist",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
