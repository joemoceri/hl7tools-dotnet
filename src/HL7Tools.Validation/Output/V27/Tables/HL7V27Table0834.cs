using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0834
    {
        public string Id { get { return @"0834"; } }

        public string TableId { get { return @"0834"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"MIME Types"; } }

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
                            Value = @"application",
                            Description = @"Application data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"audio",
                            Description = @"Audio data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"image",
                            Description = @"Image data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"model",
                            Description = @"Model data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"multipart",
                            Description = @"MIME multipart package",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"text",
                            Description = @"Text data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"video",
                            Description = @"Video data",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
