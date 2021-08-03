using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0175
    {
        public string Id { get { return @"0175"; } }

        public string TableId { get { return @"0175"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"MASTER FILE IDENTIFIER CODE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"CDM",
                            Description = @"Charge description master file (see chapter 6, appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM1",
                            Description = @"Observation text master file (i.e., Lab) (see Chapter 7, Appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM2",
                            Description = @"Observation text master file (i.e., Lab) (see Chapter 7, Appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM3",
                            Description = @"Observation text master file (i.e., Lab) (see Chapter 7, Appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM4",
                            Description = @"Observation text master file (i.e., Lab) (see Chapter 7, Appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM5",
                            Description = @"Observation text master file (i.e., Lab) (see Chapter 7, Appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM6",
                            Description = @"Observation text master file (i.e., Lab) (see Chapter 7, Appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRA",
                            Description = @"Practitioner master file (see chapter 8, appendix)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STF",
                            Description = @"Staff master file (see chapter 8, Appendix)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
