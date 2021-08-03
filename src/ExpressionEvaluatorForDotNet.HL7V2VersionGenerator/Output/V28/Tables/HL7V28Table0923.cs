using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0923
    {
        public string Id { get { return @"0923"; } }

        public string TableId { get { return @"0923"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Process Interruption"; } }

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
                            Value = @"ABR",
                            Description = @"Aborted Run: Process interrupted after the Phlebotomist inserts the needle in the Donor’s arm",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NIN",
                            Description = @"Process was not interrupted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WOT",
                            Description = @"Walk Out: Process interrupted before the Phlebotomist inserts the needle in the Donor’s arm",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
