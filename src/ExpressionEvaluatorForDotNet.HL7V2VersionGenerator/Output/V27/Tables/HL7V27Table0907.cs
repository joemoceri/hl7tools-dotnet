using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0907
    {
        public string Id { get { return @"0907"; } }

        public string TableId { get { return @"0907"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Confidentiality"; } }

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
                            Value = @"B",
                            Description = @"Business - Since the service class can represent knowledge structures that may be considered a trade or business secret, there is sometimes (though rarely) the need to flag those items as of business level confidentiality.  However, no patient related inf",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Celebrity - Celebrities are people of public interest (VIP) including employees, whose information require special protection.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Clinician - Only clinicians may see this item, billing and administration persons can not access this item without special permission.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ETH",
                            Description = @"Substance abuse related - Alcohol/drug-abuse related item",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HIV",
                            Description = @"HIV Related - HIV and AIDS related item",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Individual - Access only to individual persons who are mentioned explicitly as actors of this service and whose actor type warrants that access (cf. to actor typed code).",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Low - No patient record item can be of low confidentiality.  However, some service objects are not patient related and therefore may have low confidentiality.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Normal - Normal confidentiality rules (according to good health care practice) apply, that is, only authorized individuals with a legitimate medical or business need may access this item.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSY",
                            Description = @"Psychiatry related - Psychiatry related item",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Restricted - Restricted access, e.g. only to providers having a current care relationship to the patient.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Sensitive - Information for which the patient seeks heightened confidentiality.  Sensitive information is not to be shared with family members.  Information reported by the patient about family members is sensitive by default.  Flag can be set or cleared ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SDV",
                            Description = @"Sexual and domestic violence related - Sexual assault / domestic violence related item",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Taboo - Information not to be disclosed or discussed with patient except through physician assigned to patient in this case.  This is usually a temporary constraint only; example use is a new fatal diagnosis or finding, such as malignancy or HIV.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Very restricted - Very restricted access as declared by the Privacy Officer of the record holder.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
