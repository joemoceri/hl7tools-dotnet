using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0203
    {
        public string Id { get { return @"0203"; } }

        public string TableId { get { return @"0203"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Identifier type"; } }

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
                            Value = @"AM",
                            Description = @"American Express",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AN",
                            Description = @"Account number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BR",
                            Description = @"Birth registry number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Diners Club card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DL",
                            Description = @"Drivers license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DN",
                            Description = @"Doctor number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DS",
                            Description = @"Discover Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EI",
                            Description = @"Employee number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EN",
                            Description = @"Employer number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FI",
                            Description = @"Facility ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GI",
                            Description = @"Guarantor internal identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GN",
                            Description = @"Guarantor external identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LN",
                            Description = @"License number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LR",
                            Description = @"Local Registry ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Medicaid number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Medicare number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MR",
                            Description = @"Medical record number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MS",
                            Description = @"MasterCard",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"National employer identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NH",
                            Description = @"National Health Plan Identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NI",
                            Description = @"National unique individual identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NNxxx",
                            Description = @"National Person Identifier where the xxx is the ISO table 3166 3-character (alphabetic) country code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPI",
                            Description = @"National provider identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PI",
                            Description = @"Patient internal identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Person number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRN",
                            Description = @"Provider number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Patient external identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RR",
                            Description = @"Railroad Retirement number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRI",
                            Description = @"Regional registry ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SL",
                            Description = @"State license",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"State registry ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"Social Security number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unspecified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPIN",
                            Description = @"Medicare/HCFAs Universal Physician Identification numbers",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VN",
                            Description = @"Visit number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VS",
                            Description = @"VISA",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WC",
                            Description = @"WIC identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XX",
                            Description = @"Organization identifier",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
