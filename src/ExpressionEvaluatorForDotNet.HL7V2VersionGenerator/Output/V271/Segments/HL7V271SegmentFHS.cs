using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentFHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FHS"; } }

        public string SegmentId { get { return @"FHS"; } }
        
        public string LongName { get { return @"File Header"; } }
        
        public string Description { get { return @"The FHS segment is used to head a file (group of batches) as defined in Section 2.10.3, ""HL7 batch protocol""."; } }
        
        public string Sample { get { return @""; } }

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

        public HL7V271SegmentFHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field _fileFieldSeparator;

public HL7V271Field FileFieldSeparator
{
    get
    {
        if (_fileFieldSeparator != null)
        {
            return _fileFieldSeparator;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.1",
            Type = @"Field",
            Position = @"FHS.1",
            Name = @"File Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = null
        }

        _fileFieldSeparator = new HL7V271Field
        {
            field = message[@"FHS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileFieldSeparator.field.FieldRepetitions != null && _fileFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fileFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileFieldSeparator, fieldData);
        }

        return _fileFieldSeparator;
    } 
}

internal HL7V271Field _fileEncodingCharacters;

public HL7V271Field FileEncodingCharacters
{
    get
    {
        if (_fileEncodingCharacters != null)
        {
            return _fileEncodingCharacters;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.2",
            Type = @"Field",
            Position = @"FHS.2",
            Name = @"File Encoding Characters",
            Length = 5,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = null
        }

        _fileEncodingCharacters = new HL7V271Field
        {
            field = message[@"FHS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileEncodingCharacters.field.FieldRepetitions != null && _fileEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _fileEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileEncodingCharacters, fieldData);
        }

        return _fileEncodingCharacters;
    } 
}

internal HL7V271Field _fileSendingApplication;

public HL7V271Field FileSendingApplication
{
    get
    {
        if (_fileSendingApplication != null)
        {
            return _fileSendingApplication;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.3",
            Type = @"Field",
            Position = @"FHS.3",
            Name = @"File Sending Application",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.3.1",
                            Type = @"Component",
                            Position = @"FHS.3.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3.2",
                            Type = @"Component",
                            Position = @"FHS.3.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3.3",
                            Type = @"Component",
                            Position = @"FHS.3.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileSendingApplication = new HL7V271Field
        {
            field = message[@"FHS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSendingApplication.field.FieldRepetitions != null && _fileSendingApplication.field.FieldRepetitions.Count > 0)
        {
            _fileSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileSendingApplication, fieldData);
        }

        return _fileSendingApplication;
    } 
}

internal HL7V271Field _fileSendingFacility;

public HL7V271Field FileSendingFacility
{
    get
    {
        if (_fileSendingFacility != null)
        {
            return _fileSendingFacility;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.4",
            Type = @"Field",
            Position = @"FHS.4",
            Name = @"File Sending Facility",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.4.1",
                            Type = @"Component",
                            Position = @"FHS.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4.2",
                            Type = @"Component",
                            Position = @"FHS.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4.3",
                            Type = @"Component",
                            Position = @"FHS.4.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileSendingFacility = new HL7V271Field
        {
            field = message[@"FHS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSendingFacility.field.FieldRepetitions != null && _fileSendingFacility.field.FieldRepetitions.Count > 0)
        {
            _fileSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileSendingFacility, fieldData);
        }

        return _fileSendingFacility;
    } 
}

internal HL7V271Field _fileReceivingApplication;

public HL7V271Field FileReceivingApplication
{
    get
    {
        if (_fileReceivingApplication != null)
        {
            return _fileReceivingApplication;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.5",
            Type = @"Field",
            Position = @"FHS.5",
            Name = @"File Receiving Application",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.5.1",
                            Type = @"Component",
                            Position = @"FHS.5.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5.2",
                            Type = @"Component",
                            Position = @"FHS.5.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5.3",
                            Type = @"Component",
                            Position = @"FHS.5.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileReceivingApplication = new HL7V271Field
        {
            field = message[@"FHS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileReceivingApplication.field.FieldRepetitions != null && _fileReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            _fileReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileReceivingApplication, fieldData);
        }

        return _fileReceivingApplication;
    } 
}

internal HL7V271Field _fileReceivingFacility;

public HL7V271Field FileReceivingFacility
{
    get
    {
        if (_fileReceivingFacility != null)
        {
            return _fileReceivingFacility;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.6",
            Type = @"Field",
            Position = @"FHS.6",
            Name = @"File Receiving Facility",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.6.1",
                            Type = @"Component",
                            Position = @"FHS.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6.2",
                            Type = @"Component",
                            Position = @"FHS.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6.3",
                            Type = @"Component",
                            Position = @"FHS.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileReceivingFacility = new HL7V271Field
        {
            field = message[@"FHS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileReceivingFacility.field.FieldRepetitions != null && _fileReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            _fileReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileReceivingFacility, fieldData);
        }

        return _fileReceivingFacility;
    } 
}

internal HL7V271Field _fileCreationDateTime;

public HL7V271Field FileCreationDateTime
{
    get
    {
        if (_fileCreationDateTime != null)
        {
            return _fileCreationDateTime;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.7",
            Type = @"Field",
            Position = @"FHS.7",
            Name = @"File Creation Date/Time",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = null
        }

        _fileCreationDateTime = new HL7V271Field
        {
            field = message[@"FHS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileCreationDateTime.field.FieldRepetitions != null && _fileCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            _fileCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileCreationDateTime, fieldData);
        }

        return _fileCreationDateTime;
    } 
}

internal HL7V271Field _fileSecurity;

public HL7V271Field FileSecurity
{
    get
    {
        if (_fileSecurity != null)
        {
            return _fileSecurity;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.8",
            Type = @"Field",
            Position = @"FHS.8",
            Name = @"File Security",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment.",
            Sample = @"",
            Fields = null
        }

        _fileSecurity = new HL7V271Field
        {
            field = message[@"FHS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSecurity.field.FieldRepetitions != null && _fileSecurity.field.FieldRepetitions.Count > 0)
        {
            _fileSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileSecurity, fieldData);
        }

        return _fileSecurity;
    } 
}

internal HL7V271Field _fileNameId;

public HL7V271Field FileNameId
{
    get
    {
        if (_fileNameId != null)
        {
            return _fileNameId;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.9",
            Type = @"Field",
            Position = @"FHS.9",
            Name = @"File Name/Id",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing file. Its use is not further specified.",
            Sample = @"",
            Fields = null
        }

        _fileNameId = new HL7V271Field
        {
            field = message[@"FHS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileNameId.field.FieldRepetitions != null && _fileNameId.field.FieldRepetitions.Count > 0)
        {
            _fileNameId.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileNameId, fieldData);
        }

        return _fileNameId;
    } 
}

internal HL7V271Field _fileHeaderComment;

public HL7V271Field FileHeaderComment
{
    get
    {
        if (_fileHeaderComment != null)
        {
            return _fileHeaderComment;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.10",
            Type = @"Field",
            Position = @"FHS.10",
            Name = @"File Header Comment",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the free text field, the use of which is not further specified.",
            Sample = @"",
            Fields = null
        }

        _fileHeaderComment = new HL7V271Field
        {
            field = message[@"FHS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileHeaderComment.field.FieldRepetitions != null && _fileHeaderComment.field.FieldRepetitions.Count > 0)
        {
            _fileHeaderComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileHeaderComment, fieldData);
        }

        return _fileHeaderComment;
    } 
}

internal HL7V271Field _fileControlId;

public HL7V271Field FileControlId
{
    get
    {
        if (_fileControlId != null)
        {
            return _fileControlId;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.11",
            Type = @"Field",
            Position = @"FHS.11",
            Name = @"File Control Id",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to identify a particular file uniquely. It can be echoed back in FHS-12-reference file control ID.",
            Sample = @"",
            Fields = null
        }

        _fileControlId = new HL7V271Field
        {
            field = message[@"FHS"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileControlId.field.FieldRepetitions != null && _fileControlId.field.FieldRepetitions.Count > 0)
        {
            _fileControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileControlId, fieldData);
        }

        return _fileControlId;
    } 
}

internal HL7V271Field _referenceFileControlId;

public HL7V271Field ReferenceFileControlId
{
    get
    {
        if (_referenceFileControlId != null)
        {
            return _referenceFileControlId;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.12",
            Type = @"Field",
            Position = @"FHS.12",
            Name = @"Reference File Control Id",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted. Not present if this file is being transmitted for the first time.",
            Sample = @"",
            Fields = null
        }

        _referenceFileControlId = new HL7V271Field
        {
            field = message[@"FHS"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceFileControlId.field.FieldRepetitions != null && _referenceFileControlId.field.FieldRepetitions.Count > 0)
        {
            _referenceFileControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_referenceFileControlId, fieldData);
        }

        return _referenceFileControlId;
    } 
}

internal HL7V271Field _fileSendingNetworkAddress;

public HL7V271Field FileSendingNetworkAddress
{
    get
    {
        if (_fileSendingNetworkAddress != null)
        {
            return _fileSendingNetworkAddress;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.13",
            Type = @"Field",
            Position = @"FHS.13",
            Name = @"File Sending Network Address",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted from. Identified by an OID or text string (e.g., URI). The reader is referred to the ""Report from the Joint W3C/IETF URI Planning Interest Group: Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs): Clarifications and Recommendations"".",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.13.1",
                            Type = @"Component",
                            Position = @"FHS.13.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.13.2",
                            Type = @"Component",
                            Position = @"FHS.13.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.13.3",
                            Type = @"Component",
                            Position = @"FHS.13.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileSendingNetworkAddress = new HL7V271Field
        {
            field = message[@"FHS"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSendingNetworkAddress.field.FieldRepetitions != null && _fileSendingNetworkAddress.field.FieldRepetitions.Count > 0)
        {
            _fileSendingNetworkAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileSendingNetworkAddress, fieldData);
        }

        return _fileSendingNetworkAddress;
    } 
}

internal HL7V271Field _fileReceivingNetworkAddress;

public HL7V271Field FileReceivingNetworkAddress
{
    get
    {
        if (_fileReceivingNetworkAddress != null)
        {
            return _fileReceivingNetworkAddress;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FHS.14",
            Type = @"Field",
            Position = @"FHS.14",
            Name = @"File Receiving Network Address",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"Identifier of the network location the message was transmitted to. Identified by an OID or text string. (e.g., URL).

This is analogous with the Sending Network Address, however in the receiving role.

This field should only be populated when the underlying communication protocol does not support identification receiving network locations.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.14.1",
                            Type = @"Component",
                            Position = @"FHS.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.14.2",
                            Type = @"Component",
                            Position = @"FHS.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.14.3",
                            Type = @"Component",
                            Position = @"FHS.14.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileReceivingNetworkAddress = new HL7V271Field
        {
            field = message[@"FHS"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileReceivingNetworkAddress.field.FieldRepetitions != null && _fileReceivingNetworkAddress.field.FieldRepetitions.Count > 0)
        {
            _fileReceivingNetworkAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileReceivingNetworkAddress, fieldData);
        }

        return _fileReceivingNetworkAddress;
    } 
}
    }
}
