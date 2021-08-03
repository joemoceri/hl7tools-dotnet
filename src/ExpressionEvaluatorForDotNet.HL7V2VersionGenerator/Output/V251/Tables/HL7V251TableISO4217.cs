using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TableISO4217
    {
        public string Id { get { return @"ISO4217"; } }

        public string TableId { get { return @"ISO4217"; } }

        public string TableType { get { return @"Local"; } }

        public string Name { get { return @"Currency Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"",
                            Description = @"No universal currency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AED",
                            Description = @"UAE Dirham",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AFN",
                            Description = @"Afghani",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALL",
                            Description = @"Lek",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AMD",
                            Description = @"Armenian Dram",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANG",
                            Description = @"Netherlands Antillean Guilder",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AOA",
                            Description = @"Kwanza",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ARS",
                            Description = @"Argentine Peso",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AUD",
                            Description = @"Australian Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AWG",
                            Description = @"Aruban Florin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AZN",
                            Description = @"Azerbaijan Manat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAM",
                            Description = @"Convertible Mark",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BBD",
                            Description = @"Barbados Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BDT",
                            Description = @"Taka",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BGN",
                            Description = @"Bulgarian Lev",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BHD",
                            Description = @"Bahraini Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BIF",
                            Description = @"Burundi Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BMD",
                            Description = @"Bermudian Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BND",
                            Description = @"Brunei Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BOB",
                            Description = @"Boliviano",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BOV",
                            Description = @"Mvdol",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRL",
                            Description = @"Brazilian Real",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BSD",
                            Description = @"Bahamian Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BTN",
                            Description = @"Ngultrum",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BWP",
                            Description = @"Pula",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BYN",
                            Description = @"Belarusian Ruble",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BZD",
                            Description = @"Belize Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAD",
                            Description = @"Canadian Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDF",
                            Description = @"Congolese Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHE",
                            Description = @"WIR Euro",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHF",
                            Description = @"Swiss Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHW",
                            Description = @"WIR Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLF",
                            Description = @"Unidad de Fomento",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLP",
                            Description = @"Chilean Peso",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNY",
                            Description = @"Yuan Renminbi",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COP",
                            Description = @"Colombian Peso",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COU",
                            Description = @"Unidad de Valor Real",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CRC",
                            Description = @"Costa Rican Colon",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CUC",
                            Description = @"Peso Convertible",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CUP",
                            Description = @"Cuban Peso",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CVE",
                            Description = @"Cabo Verde Escudo",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CZK",
                            Description = @"Czech Koruna",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DJF",
                            Description = @"Djibouti Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DKK",
                            Description = @"Danish Krone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DOP",
                            Description = @"Dominican Peso",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DZD",
                            Description = @"Algerian Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EGP",
                            Description = @"Egyptian Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ERN",
                            Description = @"Nakfa",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ETB",
                            Description = @"Ethiopian Birr",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EUR",
                            Description = @"Euro",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FJD",
                            Description = @"Fiji Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FKP",
                            Description = @"Falkland Islands Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GBP",
                            Description = @"Pound Sterling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GEL",
                            Description = @"Lari",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GHS",
                            Description = @"Ghana Cedi",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GIP",
                            Description = @"Gibraltar Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMD",
                            Description = @"Dalasi",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GNF",
                            Description = @"Guinean Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GTQ",
                            Description = @"Quetzal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GYD",
                            Description = @"Guyana Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HKD",
                            Description = @"Hong Kong Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HNL",
                            Description = @"Lempira",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HRK",
                            Description = @"Kuna",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HTG",
                            Description = @"Gourde",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HUF",
                            Description = @"Forint",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IDR",
                            Description = @"Rupiah",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ILS",
                            Description = @"New Israeli Sheqel",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INR",
                            Description = @"Indian Rupee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IQD",
                            Description = @"Iraqi Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IRR",
                            Description = @"Iranian Rial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISK",
                            Description = @"Iceland Krona",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JMD",
                            Description = @"Jamaican Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JOD",
                            Description = @"Jordanian Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JPY",
                            Description = @"Yen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KES",
                            Description = @"Kenyan Shilling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KGS",
                            Description = @"Som",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KHR",
                            Description = @"Riel",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KMF",
                            Description = @"Comorian Franc ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KPW",
                            Description = @"North Korean Won",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KRW",
                            Description = @"Won",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KWD",
                            Description = @"Kuwaiti Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KYD",
                            Description = @"Cayman Islands Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KZT",
                            Description = @"Tenge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LAK",
                            Description = @"Lao Kip",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LBP",
                            Description = @"Lebanese Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LKR",
                            Description = @"Sri Lanka Rupee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LRD",
                            Description = @"Liberian Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LSL",
                            Description = @"Loti",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LYD",
                            Description = @"Libyan Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MAD",
                            Description = @"Moroccan Dirham",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDL",
                            Description = @"Moldovan Leu",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MGA",
                            Description = @"Malagasy Ariary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MKD",
                            Description = @"Denar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MMK",
                            Description = @"Kyat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MNT",
                            Description = @"Tugrik",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MOP",
                            Description = @"Pataca",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRU",
                            Description = @"Ouguiya",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MUR",
                            Description = @"Mauritius Rupee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MVR",
                            Description = @"Rufiyaa",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MWK",
                            Description = @"Malawi Kwacha",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MXN",
                            Description = @"Mexican Peso",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MXV",
                            Description = @"Mexican Unidad de Inversion (UDI)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MYR",
                            Description = @"Malaysian Ringgit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MZN",
                            Description = @"Mozambique Metical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAD",
                            Description = @"Namibia Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NGN",
                            Description = @"Naira",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NIO",
                            Description = @"Cordoba Oro",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NOK",
                            Description = @"Norwegian Krone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPR",
                            Description = @"Nepalese Rupee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NZD",
                            Description = @"New Zealand Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OMR",
                            Description = @"Rial Omani",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAB",
                            Description = @"Balboa",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PEN",
                            Description = @"Sol",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PGK",
                            Description = @"Kina",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PHP",
                            Description = @"Philippine Peso",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PKR",
                            Description = @"Pakistan Rupee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLN",
                            Description = @"Zloty",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PYG",
                            Description = @"Guarani",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QAR",
                            Description = @"Qatari Rial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RON",
                            Description = @"Romanian Leu",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RSD",
                            Description = @"Serbian Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RUB",
                            Description = @"Russian Ruble",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RWF",
                            Description = @"Rwanda Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAR",
                            Description = @"Saudi Riyal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SBD",
                            Description = @"Solomon Islands Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCR",
                            Description = @"Seychelles Rupee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SDG",
                            Description = @"Sudanese Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SEK",
                            Description = @"Swedish Krona",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SGD",
                            Description = @"Singapore Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SHP",
                            Description = @"Saint Helena Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SLL",
                            Description = @"Leone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SOS",
                            Description = @"Somali Shilling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SRD",
                            Description = @"Surinam Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SSP",
                            Description = @"South Sudanese Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STN",
                            Description = @"Dobra",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SVC",
                            Description = @"El Salvador Colon",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SYP",
                            Description = @"Syrian Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SZL",
                            Description = @"Lilangeni",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THB",
                            Description = @"Baht",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TJS",
                            Description = @"Somoni",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMT",
                            Description = @"Turkmenistan New Manat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TND",
                            Description = @"Tunisian Dinar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TOP",
                            Description = @"Pa’anga",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRY",
                            Description = @"Turkish Lira",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TTD",
                            Description = @"Trinidad and Tobago Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TWD",
                            Description = @"New Taiwan Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TZS",
                            Description = @"Tanzanian Shilling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UAH",
                            Description = @"Hryvnia",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UGX",
                            Description = @"Uganda Shilling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USD",
                            Description = @"US Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USN",
                            Description = @"US Dollar (Next day)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UYI",
                            Description = @"Uruguay Peso en Unidades Indexadas (UI)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UYU",
                            Description = @"Peso Uruguayo",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UYW",
                            Description = @"Unidad Previsional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UZS",
                            Description = @"Uzbekistan Sum",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VES",
                            Description = @"Bolívar Soberano",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VND",
                            Description = @"Dong",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VUV",
                            Description = @"Vatu",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WST",
                            Description = @"Tala",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XAF",
                            Description = @"CFA Franc BEAC",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XAG",
                            Description = @"Silver",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XAU",
                            Description = @"Gold",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XBA",
                            Description = @"Bond Markets Unit European Composite Unit (EURCO)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XBB",
                            Description = @"Bond Markets Unit European Monetary Unit (E.M.U.-6)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XBC",
                            Description = @"Bond Markets Unit European Unit of Account 9 (E.U.A.-9)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XBD",
                            Description = @"Bond Markets Unit European Unit of Account 17 (E.U.A.-17)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XCD",
                            Description = @"East Caribbean Dollar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XDR",
                            Description = @"SDR (Special Drawing Right)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XOF",
                            Description = @"CFA Franc BCEAO",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPD",
                            Description = @"Palladium",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPF",
                            Description = @"CFP Franc",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XPT",
                            Description = @"Platinum",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XSU",
                            Description = @"Sucre",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XTS",
                            Description = @"Codes specifically reserved for testing purposes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XUA",
                            Description = @"ADB Unit of Account",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XXX",
                            Description = @"The codes assigned for transactions where no currency is involved",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"YER",
                            Description = @"Yemeni Rial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ZAR",
                            Description = @"Rand",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ZMW",
                            Description = @"Zambian Kwacha",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ZWL",
                            Description = @"Zimbabwe Dollar",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
