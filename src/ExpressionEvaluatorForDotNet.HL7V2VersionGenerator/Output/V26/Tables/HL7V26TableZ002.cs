using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TableZ002
    {
        public string Id { get { return @"Z002"; } }

        public string TableId { get { return @"Z002"; } }

        public string TableType { get { return @"Local"; } }

        public string Name { get { return @"Major Diagnostic Category Coding Systems"; } }

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
                            Value = @"GMDC2006",
                            Description = @"German Major Diagnostic Category codes for 2006",
                            Comment = @"Source: German Handbook  for DRGs. version 2006"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMDC2007",
                            Description = @"German Major Diagnostic Category codes for 2007",
                            Comment = @"Source: German Handbook  for DRGs. version 2007"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMDC2008",
                            Description = @"German Major Diagnostic Category codes for 2008",
                            Comment = @"Source: German Handbook  for DRGs. version 2008"
                        },
                    };
            } 
        }
    }
}
