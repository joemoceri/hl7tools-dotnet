using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0357
    {
        public string Id { get { return @"0357"; } }

        public string TableId { get { return @"0357"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Message error condition codes"; } }

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
                            Value = @"0",
                            Description = @"Message accepted",
                            Comment = @"Success. Optional, as the AA conveys success. Used for systems that must always return a status code."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"100",
                            Description = @"Segment sequence error",
                            Comment = @"Error: The message segments were not in the proper order, or required segments are missing."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"101",
                            Description = @"Required field missing",
                            Comment = @"Error: A required field is missing from a segment"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"102",
                            Description = @"Data type error",
                            Comment = @"Error: The field contained data of the wrong data type, e.g. an NM field contained ""FOO""."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"103",
                            Description = @"Table value not found",
                            Comment = @"Error: A field of data type ID or IS was compared against the corresponding table, and no match was found."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"200",
                            Description = @"Unsupported message type",
                            Comment = @"Rejection: The Message Type is not supported."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"201",
                            Description = @"Unsupported event code",
                            Comment = @"Rejection: The Event Code is not supported."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"202",
                            Description = @"Unsupported processing id",
                            Comment = @"Rejection: The Processing ID is not supported."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"203",
                            Description = @"Unsupported version id",
                            Comment = @"Rejection:  The Version ID is not supported."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"204",
                            Description = @"Unknown key identifier",
                            Comment = @"Rejection: The ID of the patient, order, etc., was not found. Used for transactions other than additions, e.g. transfer of a non-existent patient."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"205",
                            Description = @"Duplicate key identifier",
                            Comment = @"Rejection: The ID of the patient, order, etc., already exists. Used in response to addition transactions (Admit, New Order, etc.)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"206",
                            Description = @"Application record locked",
                            Comment = @"Rejection: The transaction could not be performed at the application storage level, e.g., database locked."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"207",
                            Description = @"Application internal error",
                            Comment = @"Rejection: A catchall for internal errors not explicitly covered by other codes."
                        },
                        
                    };
            } 
        }
    }
}
