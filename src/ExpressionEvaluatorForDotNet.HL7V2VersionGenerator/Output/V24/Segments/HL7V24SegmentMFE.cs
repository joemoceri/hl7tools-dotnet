using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentMFE
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"MFE"; } }

        public string SegmentId { get { return @"MFE"; } }
        
        public string LongName { get { return @"Master File Entry"; } }
        
        public string Description { get { return @"The Technical Steward for the MFE segment is CQ."; } }
        
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
                            Id = @"MFE.1",
                            Type = @"Field",
                            Position = @"MFE.1",
                            Name = @"Record-Level Event Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0180",
                            TableName = @"Record-level event code",
                            Description = @"This field defines the record-level event for the master file record identified by the MFI segment and the primary key field in this segment. Refer to HL7 table 0180 - Record level event code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.2",
                            Type = @"Field",
                            Position = @"MFE.2",
                            Name = @"MFN Control ID",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or other identifier that uniquely identifies this change to this record from the point of view of the originating system. When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged. It is only required if the MFI response level code requires responses at the record level (any value other than NE).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.3",
                            Type = @"Field",
                            Position = @"MFE.3",
                            Name = @"Effective Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"An optional effective date/time can be included for the record-level action specified. It is the date/time the originating system expects that the event is to have been completed on the receiving system. If this field is not present, the effective date/time should default to the current date/time (when the message is received).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MFE.3.1",
                            Type = @"Component",
                            Position = @"MFE.3.1",
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
                            Id = @"MFE.3.2",
                            Type = @"Component",
                            Position = @"MFE.3.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4",
                            Type = @"Field",
                            Position = @"MFE.4",
                            Name = @"Primary Key Value - MFE",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"VARIES",
                            DataTypeName = @"Variable Datatype",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the record of the master file (identified in the MFI segment) to be changed (as defined by the record-level event code). The data type of field is defined by the value of MFE-5 - Value type, and may take on the format of any of the HL7 data types defined in HL7 table 0355 - Primary key value type. The PL data type is used only on Location master transactions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.5",
                            Type = @"Field",
                            Position = @"MFE.5",
                            Name = @"Primary Key Value Type",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0355",
                            TableName = @"Primary key value type",
                            Description = @"This field contains the HL7 data type of MFE-4 - Primary key value . The valid values for the data type of a primary key are listed in HL7 table 0355 - Primary key value type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentMFE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field recordLevelEventCode;

public HL7V24Field RecordLevelEventCode
{
    get
    {
        if (recordLevelEventCode != null)
        {
            return recordLevelEventCode;
        }

        recordLevelEventCode = new HL7V24Field
        {
            field = message[@"MFE"][1],
            Id = @"MFE.1",
            Type = @"Field",
            Position = @"MFE.1",
            Name = @"Record-Level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0180",
            TableName = @"Record-level event code",
            Description = @"This field defines the record-level event for the master file record identified by the MFI segment and the primary key field in this segment. Refer to HL7 table 0180 - Record level event code for valid values.",
            Sample = @"",
        };

        

        

        

        return recordLevelEventCode;
    } 
}
internal HL7V24Field mFNControlID;

public HL7V24Field MFNControlID
{
    get
    {
        if (mFNControlID != null)
        {
            return mFNControlID;
        }

        mFNControlID = new HL7V24Field
        {
            field = message[@"MFE"][2],
            Id = @"MFE.2",
            Type = @"Field",
            Position = @"MFE.2",
            Name = @"MFN Control ID",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"A number or other identifier that uniquely identifies this change to this record from the point of view of the originating system. When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged. It is only required if the MFI response level code requires responses at the record level (any value other than NE).",
            Sample = @"",
        };

        

        

        

        return mFNControlID;
    } 
}
internal HL7V24Field effectiveDateTime;

public HL7V24Field EffectiveDateTime
{
    get
    {
        if (effectiveDateTime != null)
        {
            return effectiveDateTime;
        }

        effectiveDateTime = new HL7V24Field
        {
            field = message[@"MFE"][3],
            Id = @"MFE.3",
            Type = @"Field",
            Position = @"MFE.3",
            Name = @"Effective Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"An optional effective date/time can be included for the record-level action specified. It is the date/time the originating system expects that the event is to have been completed on the receiving system. If this field is not present, the effective date/time should default to the current date/time (when the message is received).",
            Sample = @"",
        };

        

        

        

        return effectiveDateTime;
    } 
}
internal HL7V24Field primaryKeyValueMFE;

public HL7V24Field PrimaryKeyValueMFE
{
    get
    {
        if (primaryKeyValueMFE != null)
        {
            return primaryKeyValueMFE;
        }

        primaryKeyValueMFE = new HL7V24Field
        {
            field = message[@"MFE"][4],
            Id = @"MFE.4",
            Type = @"Field",
            Position = @"MFE.4",
            Name = @"Primary Key Value - MFE",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the record of the master file (identified in the MFI segment) to be changed (as defined by the record-level event code). The data type of field is defined by the value of MFE-5 - Value type, and may take on the format of any of the HL7 data types defined in HL7 table 0355 - Primary key value type. The PL data type is used only on Location master transactions.",
            Sample = @"",
        };

        

        

        

        return primaryKeyValueMFE;
    } 
}
internal HL7V24Field primaryKeyValueType;

public HL7V24Field PrimaryKeyValueType
{
    get
    {
        if (primaryKeyValueType != null)
        {
            return primaryKeyValueType;
        }

        primaryKeyValueType = new HL7V24Field
        {
            field = message[@"MFE"][5],
            Id = @"MFE.5",
            Type = @"Field",
            Position = @"MFE.5",
            Name = @"Primary Key Value Type",
            Length = 3,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0355",
            TableName = @"Primary key value type",
            Description = @"This field contains the HL7 data type of MFE-4 - Primary key value . The valid values for the data type of a primary key are listed in HL7 table 0355 - Primary key value type.",
            Sample = @"",
        };

        

        

        

        return primaryKeyValueType;
    } 
}

    }
}
