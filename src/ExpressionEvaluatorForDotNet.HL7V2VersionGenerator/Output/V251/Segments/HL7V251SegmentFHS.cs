using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentFHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FHS"; } }

        public string SegmentId { get { return @"FHS"; } }
        
        public string LongName { get { return @"File Header Segment"; } }
        
        public string Description { get { return @"The FHS segment is used to head a file (group of batches)."; } }
        
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

        public HL7V251SegmentFHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _fileFieldSeparator;

public HL7V251Field FileFieldSeparator
{
    get
    {
        if (_fileFieldSeparator != null)
        {
            return _fileFieldSeparator;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field has the same definition as the corresponding field in the MSH segment. ",
            Sample = @"",
            Fields = null
        }

        _fileFieldSeparator = new HL7V251Field
        {
            field = message[@"FHS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileFieldSeparator.field.FieldRepetitions != null && _fileFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fileFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileFieldSeparator, fieldData);
        }

        return _fileFieldSeparator;
    } 
}

internal HL7V251Field _fileEncodingCharacters;

public HL7V251Field FileEncodingCharacters
{
    get
    {
        if (_fileEncodingCharacters != null)
        {
            return _fileEncodingCharacters;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.2",
            Type = @"Field",
            Position = @"FHS.2",
            Name = @"File Encoding Characters",
            Length = 4,
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

        _fileEncodingCharacters = new HL7V251Field
        {
            field = message[@"FHS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileEncodingCharacters.field.FieldRepetitions != null && _fileEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _fileEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileEncodingCharacters, fieldData);
        }

        return _fileEncodingCharacters;
    } 
}

internal HL7V251Field _fileSendingApplication;

public HL7V251Field FileSendingApplication
{
    get
    {
        if (_fileSendingApplication != null)
        {
            return _fileSendingApplication;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.3",
            Type = @"Field",
            Position = @"FHS.3",
            Name = @"File Sending Application",
            Length = 227,
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
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

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
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileSendingApplication = new HL7V251Field
        {
            field = message[@"FHS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSendingApplication.field.FieldRepetitions != null && _fileSendingApplication.field.FieldRepetitions.Count > 0)
        {
            _fileSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileSendingApplication, fieldData);
        }

        return _fileSendingApplication;
    } 
}

internal HL7V251Field _fileSendingFacility;

public HL7V251Field FileSendingFacility
{
    get
    {
        if (_fileSendingFacility != null)
        {
            return _fileSendingFacility;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.4",
            Type = @"Field",
            Position = @"FHS.4",
            Name = @"File Sending Facility",
            Length = 227,
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
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

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
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileSendingFacility = new HL7V251Field
        {
            field = message[@"FHS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSendingFacility.field.FieldRepetitions != null && _fileSendingFacility.field.FieldRepetitions.Count > 0)
        {
            _fileSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileSendingFacility, fieldData);
        }

        return _fileSendingFacility;
    } 
}

internal HL7V251Field _fileReceivingApplication;

public HL7V251Field FileReceivingApplication
{
    get
    {
        if (_fileReceivingApplication != null)
        {
            return _fileReceivingApplication;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.5",
            Type = @"Field",
            Position = @"FHS.5",
            Name = @"File Receiving Application",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.5.1",
                            Type = @"Component",
                            Position = @"FHS.5.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

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
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileReceivingApplication = new HL7V251Field
        {
            field = message[@"FHS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileReceivingApplication.field.FieldRepetitions != null && _fileReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            _fileReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileReceivingApplication, fieldData);
        }

        return _fileReceivingApplication;
    } 
}

internal HL7V251Field _fileReceivingFacility;

public HL7V251Field FileReceivingFacility
{
    get
    {
        if (_fileReceivingFacility != null)
        {
            return _fileReceivingFacility;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.6",
            Type = @"Field",
            Position = @"FHS.6",
            Name = @"File Receiving Facility",
            Length = 227,
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
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

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
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileReceivingFacility = new HL7V251Field
        {
            field = message[@"FHS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileReceivingFacility.field.FieldRepetitions != null && _fileReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            _fileReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileReceivingFacility, fieldData);
        }

        return _fileReceivingFacility;
    } 
}

internal HL7V251Field _fileCreationDateTime;

public HL7V251Field FileCreationDateTime
{
    get
    {
        if (_fileCreationDateTime != null)
        {
            return _fileCreationDateTime;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.7",
            Type = @"Field",
            Position = @"FHS.7",
            Name = @"File Creation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"FHS.7.1",
                            Type = @"Component",
                            Position = @"FHS.7.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.7.2",
                            Type = @"Component",
                            Position = @"FHS.7.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fileCreationDateTime = new HL7V251Field
        {
            field = message[@"FHS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileCreationDateTime.field.FieldRepetitions != null && _fileCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            _fileCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileCreationDateTime, fieldData);
        }

        return _fileCreationDateTime;
    } 
}

internal HL7V251Field _fileSecurity;

public HL7V251Field FileSecurity
{
    get
    {
        if (_fileSecurity != null)
        {
            return _fileSecurity;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.8",
            Type = @"Field",
            Position = @"FHS.8",
            Name = @"File Security",
            Length = 40,
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

        _fileSecurity = new HL7V251Field
        {
            field = message[@"FHS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileSecurity.field.FieldRepetitions != null && _fileSecurity.field.FieldRepetitions.Count > 0)
        {
            _fileSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileSecurity, fieldData);
        }

        return _fileSecurity;
    } 
}

internal HL7V251Field _fileNameID;

public HL7V251Field FileNameID
{
    get
    {
        if (_fileNameID != null)
        {
            return _fileNameID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.9",
            Type = @"Field",
            Position = @"FHS.9",
            Name = @"File Name/ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing file. Its use is not further specified. ",
            Sample = @"",
            Fields = null
        }

        _fileNameID = new HL7V251Field
        {
            field = message[@"FHS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileNameID.field.FieldRepetitions != null && _fileNameID.field.FieldRepetitions.Count > 0)
        {
            _fileNameID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileNameID, fieldData);
        }

        return _fileNameID;
    } 
}

internal HL7V251Field _fileHeaderComment;

public HL7V251Field FileHeaderComment
{
    get
    {
        if (_fileHeaderComment != null)
        {
            return _fileHeaderComment;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.10",
            Type = @"Field",
            Position = @"FHS.10",
            Name = @"File Header Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the free text field, the use of which is not further specified.  ",
            Sample = @"",
            Fields = null
        }

        _fileHeaderComment = new HL7V251Field
        {
            field = message[@"FHS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileHeaderComment.field.FieldRepetitions != null && _fileHeaderComment.field.FieldRepetitions.Count > 0)
        {
            _fileHeaderComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileHeaderComment, fieldData);
        }

        return _fileHeaderComment;
    } 
}

internal HL7V251Field _fileControlID;

public HL7V251Field FileControlID
{
    get
    {
        if (_fileControlID != null)
        {
            return _fileControlID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.11",
            Type = @"Field",
            Position = @"FHS.11",
            Name = @"File Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to identify a particular file uniquely. It can be echoed back in FHS-12reference file control ID. ",
            Sample = @"",
            Fields = null
        }

        _fileControlID = new HL7V251Field
        {
            field = message[@"FHS"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileControlID.field.FieldRepetitions != null && _fileControlID.field.FieldRepetitions.Count > 0)
        {
            _fileControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fileControlID, fieldData);
        }

        return _fileControlID;
    } 
}

internal HL7V251Field _referenceFileControlID;

public HL7V251Field ReferenceFileControlID
{
    get
    {
        if (_referenceFileControlID != null)
        {
            return _referenceFileControlID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"FHS.12",
            Type = @"Field",
            Position = @"FHS.12",
            Name = @"Reference File Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted. Not present if this file is being transmitted for the first time. ",
            Sample = @"",
            Fields = null
        }

        _referenceFileControlID = new HL7V251Field
        {
            field = message[@"FHS"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceFileControlID.field.FieldRepetitions != null && _referenceFileControlID.field.FieldRepetitions.Count > 0)
        {
            _referenceFileControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_referenceFileControlID, fieldData);
        }

        return _referenceFileControlID;
    } 
}
    }
}
