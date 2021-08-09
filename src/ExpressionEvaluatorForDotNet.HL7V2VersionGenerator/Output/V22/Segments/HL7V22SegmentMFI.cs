using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentMFI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFI"; } }

        public string SegmentId { get { return @"MFI"; } }
        
        public string LongName { get { return @"Master File Identification"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MFI.1",
                            Type = @"Field",
                            Position = @"MFI.1",
                            Name = @"Master File Identifier",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0175",
                            TableName = @"MASTER FILE IDENTIFIER CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFI.1.1",
                            Type = @"Component",
                            Position = @"MFI.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.2",
                            Type = @"Component",
                            Position = @"MFI.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.3",
                            Type = @"Component",
                            Position = @"MFI.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.4",
                            Type = @"Component",
                            Position = @"MFI.1.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.5",
                            Type = @"Component",
                            Position = @"MFI.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.6",
                            Type = @"Component",
                            Position = @"MFI.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.2",
                            Type = @"Field",
                            Position = @"MFI.2",
                            Name = @"Master File Application Identifier",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0176",
                            TableName = @"MASTER FILE APPLICATION IDENTIFIER",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.3",
                            Type = @"Field",
                            Position = @"MFI.3",
                            Name = @"File-level Event Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0178",
                            TableName = @"FILE-LEVEL EVENT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.4",
                            Type = @"Field",
                            Position = @"MFI.4",
                            Name = @"Entered Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFI.4.1",
                            Type = @"Component",
                            Position = @"MFI.4.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.4.2",
                            Type = @"Component",
                            Position = @"MFI.4.2",
                            Name = @"Degree Of Precision",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.5",
                            Type = @"Field",
                            Position = @"MFI.5",
                            Name = @"Effective Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFI.5.1",
                            Type = @"Component",
                            Position = @"MFI.5.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.5.2",
                            Type = @"Component",
                            Position = @"MFI.5.2",
                            Name = @"Degree Of Precision",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.6",
                            Type = @"Field",
                            Position = @"MFI.6",
                            Name = @"Response Level Code",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0179",
                            TableName = @"RESPONSE LEVEL",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentMFI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field masterFileIdentifier;

public HL7V22Field MasterFileIdentifier
{
    get
    {
        if (masterFileIdentifier != null)
        {
            return masterFileIdentifier;
        }

        masterFileIdentifier = new HL7V22Field
        {
            field = message[@"MFI"][1],
            Id = @"MFI.1",
            Type = @"Field",
            Position = @"MFI.1",
            Name = @"Master File Identifier",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0175",
            TableName = @"MASTER FILE IDENTIFIER CODE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (masterFileIdentifier.field.FieldRepetitions != null && masterFileIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(masterFileIdentifier.Id));
            masterFileIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(masterFileIdentifier, fieldData);
        }

        return masterFileIdentifier;
    } 
}

internal HL7V22Field masterFileApplicationIdentifier;

public HL7V22Field MasterFileApplicationIdentifier
{
    get
    {
        if (masterFileApplicationIdentifier != null)
        {
            return masterFileApplicationIdentifier;
        }

        masterFileApplicationIdentifier = new HL7V22Field
        {
            field = message[@"MFI"][2],
            Id = @"MFI.2",
            Type = @"Field",
            Position = @"MFI.2",
            Name = @"Master File Application Identifier",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0176",
            TableName = @"MASTER FILE APPLICATION IDENTIFIER",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (masterFileApplicationIdentifier.field.FieldRepetitions != null && masterFileApplicationIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(masterFileApplicationIdentifier.Id));
            masterFileApplicationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(masterFileApplicationIdentifier, fieldData);
        }

        return masterFileApplicationIdentifier;
    } 
}

internal HL7V22Field filelevelEventCode;

public HL7V22Field FilelevelEventCode
{
    get
    {
        if (filelevelEventCode != null)
        {
            return filelevelEventCode;
        }

        filelevelEventCode = new HL7V22Field
        {
            field = message[@"MFI"][3],
            Id = @"MFI.3",
            Type = @"Field",
            Position = @"MFI.3",
            Name = @"File-level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0178",
            TableName = @"FILE-LEVEL EVENT CODE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (filelevelEventCode.field.FieldRepetitions != null && filelevelEventCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(filelevelEventCode.Id));
            filelevelEventCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(filelevelEventCode, fieldData);
        }

        return filelevelEventCode;
    } 
}

internal HL7V22Field enteredDateTime;

public HL7V22Field EnteredDateTime
{
    get
    {
        if (enteredDateTime != null)
        {
            return enteredDateTime;
        }

        enteredDateTime = new HL7V22Field
        {
            field = message[@"MFI"][4],
            Id = @"MFI.4",
            Type = @"Field",
            Position = @"MFI.4",
            Name = @"Entered Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (enteredDateTime.field.FieldRepetitions != null && enteredDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(enteredDateTime.Id));
            enteredDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(enteredDateTime, fieldData);
        }

        return enteredDateTime;
    } 
}

internal HL7V22Field effectiveDateTime;

public HL7V22Field EffectiveDateTime
{
    get
    {
        if (effectiveDateTime != null)
        {
            return effectiveDateTime;
        }

        effectiveDateTime = new HL7V22Field
        {
            field = message[@"MFI"][5],
            Id = @"MFI.5",
            Type = @"Field",
            Position = @"MFI.5",
            Name = @"Effective Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (effectiveDateTime.field.FieldRepetitions != null && effectiveDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(effectiveDateTime.Id));
            effectiveDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(effectiveDateTime, fieldData);
        }

        return effectiveDateTime;
    } 
}

internal HL7V22Field responseLevelCode;

public HL7V22Field ResponseLevelCode
{
    get
    {
        if (responseLevelCode != null)
        {
            return responseLevelCode;
        }

        responseLevelCode = new HL7V22Field
        {
            field = message[@"MFI"][6],
            Id = @"MFI.6",
            Type = @"Field",
            Position = @"MFI.6",
            Name = @"Response Level Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0179",
            TableName = @"RESPONSE LEVEL",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (responseLevelCode.field.FieldRepetitions != null && responseLevelCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(responseLevelCode.Id));
            responseLevelCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(responseLevelCode, fieldData);
        }

        return responseLevelCode;
    } 
}
    }
}
