using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentMRG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MRG"; } }

        public string SegmentId { get { return @"MRG"; } }
        
        public string LongName { get { return @"Merge Patient Information"; } }
        
        public string Description { get { return @"The MRG segment provides receiving applications with information necessary to initiate the merging of patient data as well as groups of records.  It is intended that this segment be used throughout the standard to allow the merging of registration, accounting, and clinical records within specific applications"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Id = @"MRG.1",
                            Type = @"Field",
                            Position = @"MRG.1",
                            Name = @"Prior Patient Id - Internal",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CM_PAT_ID",
                            DataTypeName = @"Patient Id",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MRG.1.1",
                            Type = @"Component",
                            Position = @"MRG.1.1",
                            Name = @"Patient Id",
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
                            Id = @"MRG.1.2",
                            Type = @"Component",
                            Position = @"MRG.1.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.1.3",
                            Type = @"Component",
                            Position = @"MRG.1.3",
                            Name = @"Check Digit Scheme",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.1.4",
                            Type = @"Component",
                            Position = @"MRG.1.4",
                            Name = @"Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.1.5",
                            Type = @"Component",
                            Position = @"MRG.1.5",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.2",
                            Type = @"Field",
                            Position = @"MRG.2",
                            Name = @"Prior Alternate Patient Id",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_PAT_ID",
                            DataTypeName = @"Patient Id",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MRG.2.1",
                            Type = @"Component",
                            Position = @"MRG.2.1",
                            Name = @"Patient Id",
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
                            Id = @"MRG.2.2",
                            Type = @"Component",
                            Position = @"MRG.2.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.2.3",
                            Type = @"Component",
                            Position = @"MRG.2.3",
                            Name = @"Check Digit Scheme",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.2.4",
                            Type = @"Component",
                            Position = @"MRG.2.4",
                            Name = @"Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.2.5",
                            Type = @"Component",
                            Position = @"MRG.2.5",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.3",
                            Type = @"Field",
                            Position = @"MRG.3",
                            Name = @"Prior Patient Account Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MRG.3.1",
                            Type = @"Component",
                            Position = @"MRG.3.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.3.2",
                            Type = @"Component",
                            Position = @"MRG.3.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.3.3",
                            Type = @"Component",
                            Position = @"MRG.3.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.3.4",
                            Type = @"Component",
                            Position = @"MRG.3.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.4",
                            Type = @"Field",
                            Position = @"MRG.4",
                            Name = @"Prior Patient Id - External",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MRG.4.1",
                            Type = @"Component",
                            Position = @"MRG.4.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.4.2",
                            Type = @"Component",
                            Position = @"MRG.4.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.4.3",
                            Type = @"Component",
                            Position = @"MRG.4.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.4.4",
                            Type = @"Component",
                            Position = @"MRG.4.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentMRG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field priorPatientIdInternal;

public HL7V22Field PriorPatientIdInternal
{
    get
    {
        if (priorPatientIdInternal != null)
        {
            return priorPatientIdInternal;
        }

        priorPatientIdInternal = new HL7V22Field
        {
            field = message[@"MRG"][1],
            Id = @"MRG.1",
            Type = @"Field",
            Position = @"MRG.1",
            Name = @"Prior Patient Id - Internal",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CM_PAT_ID",
            DataTypeName = @"Patient Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (priorPatientIdInternal.field.FieldRepetitions != null && priorPatientIdInternal.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priorPatientIdInternal.Id));
            priorPatientIdInternal.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(priorPatientIdInternal, fieldData);
        }

        return priorPatientIdInternal;
    } 
}

internal HL7V22Field priorAlternatePatientId;

public HL7V22Field PriorAlternatePatientId
{
    get
    {
        if (priorAlternatePatientId != null)
        {
            return priorAlternatePatientId;
        }

        priorAlternatePatientId = new HL7V22Field
        {
            field = message[@"MRG"][2],
            Id = @"MRG.2",
            Type = @"Field",
            Position = @"MRG.2",
            Name = @"Prior Alternate Patient Id",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PAT_ID",
            DataTypeName = @"Patient Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (priorAlternatePatientId.field.FieldRepetitions != null && priorAlternatePatientId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priorAlternatePatientId.Id));
            priorAlternatePatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(priorAlternatePatientId, fieldData);
        }

        return priorAlternatePatientId;
    } 
}

internal HL7V22Field priorPatientAccountNumber;

public HL7V22Field PriorPatientAccountNumber
{
    get
    {
        if (priorPatientAccountNumber != null)
        {
            return priorPatientAccountNumber;
        }

        priorPatientAccountNumber = new HL7V22Field
        {
            field = message[@"MRG"][3],
            Id = @"MRG.3",
            Type = @"Field",
            Position = @"MRG.3",
            Name = @"Prior Patient Account Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (priorPatientAccountNumber.field.FieldRepetitions != null && priorPatientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priorPatientAccountNumber.Id));
            priorPatientAccountNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(priorPatientAccountNumber, fieldData);
        }

        return priorPatientAccountNumber;
    } 
}

internal HL7V22Field priorPatientIdExternal;

public HL7V22Field PriorPatientIdExternal
{
    get
    {
        if (priorPatientIdExternal != null)
        {
            return priorPatientIdExternal;
        }

        priorPatientIdExternal = new HL7V22Field
        {
            field = message[@"MRG"][4],
            Id = @"MRG.4",
            Type = @"Field",
            Position = @"MRG.4",
            Name = @"Prior Patient Id - External",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (priorPatientIdExternal.field.FieldRepetitions != null && priorPatientIdExternal.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priorPatientIdExternal.Id));
            priorPatientIdExternal.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(priorPatientIdExternal, fieldData);
        }

        return priorPatientIdExternal;
    } 
}
    }
}
