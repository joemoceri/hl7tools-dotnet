using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0909
    {
        public string Id { get { return @"0909"; } }

        public string TableId { get { return @"0909"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Patient Results Release Categorization Scheme"; } }

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
                            Value = @"SID",
                            Description = @"Share In1 Day -<p>Share result regardless of reference/therapeutic range after 1 or more business day as agreed to by the systems in play.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SIDC",
                            Description = @"Share in 1 Day Conditionally -<p>Share result in reference ranges/therapeutic with patient after 1 or more business day as agreed to by the systems in play.<p>Withhold result out of reference/therapeutic range until physician release",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SIMM",
                            Description = @"Share Immediately -<p>Share result with patient immediately",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STBD",
                            Description = @"Share To Be Determined -<p>Category to be determined",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SWNL",
                            Description = @"Share Within Normal Limits -<p>Share result in reference/therapeutic range with patient immediately<p>Share result out of reference/therapeutic ranges with patient after 1 or more business day as agreed to by the systems in play.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SWTH",
                            Description = @"Share Withhold -<p>Withhold result regardless of reference/therapeutic ranges",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
