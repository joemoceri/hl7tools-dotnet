using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TableNSC1
    {
        public string Id { get { return @"NSC1"; } }

        public string TableId { get { return @"NSC1"; } }

        public string TableType { get { return @"Local"; } }

        public string Name { get { return @"Network Change Type"; } }

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
                            Value = @"M",
                            Description = @"Migrates to different CPU",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SD",
                            Description = @"Shut down",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Start up",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
