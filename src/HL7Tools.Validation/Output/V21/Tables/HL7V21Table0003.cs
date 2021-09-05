using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0003
    {
        public string Id { get { return @"0003"; } }

        public string TableId { get { return @"0003"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"EVENT TYPE CODE"; } }

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
                            Value = @"A01",
                            Description = @"Admit a patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A02",
                            Description = @"Transfer a Patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A03",
                            Description = @"Discharge a Patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A04",
                            Description = @"Register a Patient",
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
                            Description = @"Transfer an Inpatient to Outpatient",
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
                            Description = @"Swap Patients",
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
                            Description = @"Bed status updates",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A21",
                            Description = @"Leave of Absence - Out (leaving)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A22",
                            Description = @"Leave of Absence - In (returning)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A23",
                            Description = @"Delete a Patient Record",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A24",
                            Description = @"Link Patient Records",
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
                            Description = @"Add and update patient account",
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
                            Description = @"Generate bills and A/R statements",
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
                            Description = @"Deferred Access",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R01",
                            Description = @"Unsolicited transmission of requested Observ.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R03",
                            Description = @"Display oriented results, query/unsol. update",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
