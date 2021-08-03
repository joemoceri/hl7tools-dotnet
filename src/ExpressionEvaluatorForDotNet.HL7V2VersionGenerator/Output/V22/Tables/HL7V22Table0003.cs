using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0003
    {
        public string Id { get { return @"0003"; } }

        public string TableId { get { return @"0003"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"EVENT TYPE CODE"; } }

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
                            Value = @"A01",
                            Description = @"Admit a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A02",
                            Description = @"Transfer a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A03",
                            Description = @"Discharge a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A04",
                            Description = @"Register a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A05",
                            Description = @"Pre-admit a Patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A06",
                            Description = @"Transfer an outpatient to inpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A07",
                            Description = @"Transfer an inpatient to outpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A08",
                            Description = @"Update patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A09",
                            Description = @"Patient departing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A10",
                            Description = @"Patient arriving",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A11",
                            Description = @"Cancel admit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A12",
                            Description = @"Cancel transfer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A13",
                            Description = @"Cancel discharge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A14",
                            Description = @"Pending admit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A15",
                            Description = @"Pending transfer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A16",
                            Description = @"Pending discharge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A17",
                            Description = @"Swap patients",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A18",
                            Description = @"Merge patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A19",
                            Description = @"Patient query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A20",
                            Description = @"Bed Status Update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A21",
                            Description = @"Leave of absence - out (leaving)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A22",
                            Description = @"Leave of absence - in (returning)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A23",
                            Description = @"Delete a patient record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A24",
                            Description = @"Link patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A25",
                            Description = @"Cancel pending discharge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A26",
                            Description = @"Cancel pending transfer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A27",
                            Description = @"Cancel pending admit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A28",
                            Description = @"Add person information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A29",
                            Description = @"Delete person information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A30",
                            Description = @"Merge Patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A31",
                            Description = @"Update person information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A32",
                            Description = @"Cancel patient arriving",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A33",
                            Description = @"Cancel patient departing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A34",
                            Description = @"Merge patient information - patient ID only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A35",
                            Description = @"Merge patient information - account number only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A36",
                            Description = @"Merge patient information - patient ID and account number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A37",
                            Description = @"Unlink patient information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M01",
                            Description = @"Master file not otherwise specified (for backwards compatibility only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M02",
                            Description = @"Master file - Staff Practioner",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M03",
                            Description = @"Master file - test / observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O01",
                            Description = @"Order message",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O02",
                            Description = @"Order response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P01",
                            Description = @"Add and Update Patient Accounts",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P02",
                            Description = @"Purge Patient Accounts",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P03",
                            Description = @"Post detail financial transaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P04",
                            Description = @"Generate bill and accounts receivable statements",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q01",
                            Description = @"Immediate access",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q02",
                            Description = @"Deferred access",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q03",
                            Description = @"Deferred response to query",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q05",
                            Description = @"Unsolicited display update",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R01",
                            Description = @"Unsolicited transmission of requested observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R02",
                            Description = @"Query for results of observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R03",
                            Description = @"Display-oriented results (query / unsolicited update)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R04",
                            Description = @"Response to query / transmission of requested observation",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
