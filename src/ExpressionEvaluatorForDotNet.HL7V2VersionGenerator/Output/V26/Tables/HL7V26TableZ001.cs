using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226TableZ001
    {
        public string Id { get { return @"Z001"; } }

        public string TableId { get { return @"Z001"; } }

        public string TableType { get { return @"Local"; } }

        public string Name { get { return @"Diagnostic Related Group Coding Systems"; } }

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
                            Description = @"US DRG codes",
                            Comment = @"Source: CMS"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2006",
                            Description = @"German DRG codes for 2006",
                            Comment = @"Source: German Handbook  for DRGs. v2006"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2007",
                            Description = @"German DRG codes for 2007",
                            Comment = @"Source: German Handbook  for DRGs. v2007"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2008",
                            Description = @"German DRG codes for 2008",
                            Comment = @"Source: German Handbook  for DRGs. v2008"
                        },
                    };
            } 
        }
    }
}
