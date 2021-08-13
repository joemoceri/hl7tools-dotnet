using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentVAR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"VAR"; } }

        public string SegmentId { get { return @"VAR"; } }
        
        public string LongName { get { return @"Variance"; } }
        
        public string Description { get { return @"The variance segment contains the data necessary to describes differences that may have occurred at the time when a healthcare event was documented. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V23SegmentVAR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _varianceInstanceID;

public HL7V23Field VarianceInstanceID
{
    get
    {
        if (_varianceInstanceID != null)
        {
            return _varianceInstanceID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"VAR.1",
            Type = @"Field",
            Position = @"VAR.1",
            Name = @"Variance Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique identifier of the specific variance record",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VAR.1.1",
                            Type = @"Component",
                            Position = @"VAR.1.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.1.2",
                            Type = @"Component",
                            Position = @"VAR.1.2",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.1.3",
                            Type = @"Component",
                            Position = @"VAR.1.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.1.4",
                            Type = @"Component",
                            Position = @"VAR.1.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _varianceInstanceID = new HL7V23Field
        {
            field = message[@"VAR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_varianceInstanceID.field.FieldRepetitions != null && _varianceInstanceID.field.FieldRepetitions.Count > 0)
        {
            _varianceInstanceID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_varianceInstanceID, fieldData);
        }

        return _varianceInstanceID;
    } 
}

internal HL7V23Field _documentedDateTime;

public HL7V23Field DocumentedDateTime
{
    get
    {
        if (_documentedDateTime != null)
        {
            return _documentedDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"VAR.2",
            Type = @"Field",
            Position = @"VAR.2",
            Name = @"Documented Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time stamp that identifies the timed occurrence of the variance documentation",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VAR.2.1",
                            Type = @"Component",
                            Position = @"VAR.2.1",
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
                        }
        }

        _documentedDateTime = new HL7V23Field
        {
            field = message[@"VAR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_documentedDateTime.field.FieldRepetitions != null && _documentedDateTime.field.FieldRepetitions.Count > 0)
        {
            _documentedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_documentedDateTime, fieldData);
        }

        return _documentedDateTime;
    } 
}

internal HL7V23Field _statedVarianceDateTime;

public HL7V23Field StatedVarianceDateTime
{
    get
    {
        if (_statedVarianceDateTime != null)
        {
            return _statedVarianceDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"VAR.3",
            Type = @"Field",
            Position = @"VAR.3",
            Name = @"Stated Variance Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time stamp that identifies a stated time of the variance which may be different than the time it was documented",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VAR.3.1",
                            Type = @"Component",
                            Position = @"VAR.3.1",
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
                        }
        }

        _statedVarianceDateTime = new HL7V23Field
        {
            field = message[@"VAR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statedVarianceDateTime.field.FieldRepetitions != null && _statedVarianceDateTime.field.FieldRepetitions.Count > 0)
        {
            _statedVarianceDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_statedVarianceDateTime, fieldData);
        }

        return _statedVarianceDateTime;
    } 
}

internal HL7V23Field _varianceOriginator;

public HL7V23Field VarianceOriginator
{
    get
    {
        if (_varianceOriginator != null)
        {
            return _varianceOriginator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"VAR.4",
            Type = @"Field",
            Position = @"VAR.4",
            Name = @"Variance Originator",
            Length = 860,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the originator (person or system) documenting the variance",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VAR.4.1",
                            Type = @"Component",
                            Position = @"VAR.4.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.2",
                            Type = @"Component",
                            Position = @"VAR.4.2",
                            Name = @"Family Name",
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
                            Id = @"VAR.4.3",
                            Type = @"Component",
                            Position = @"VAR.4.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.4",
                            Type = @"Component",
                            Position = @"VAR.4.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"VAR.4.5",
                            Type = @"Component",
                            Position = @"VAR.4.5",
                            Name = @"Suffix",
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
                            Id = @"VAR.4.6",
                            Type = @"Component",
                            Position = @"VAR.4.6",
                            Name = @"Prefix",
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
                            Id = @"VAR.4.7",
                            Type = @"Component",
                            Position = @"VAR.4.7",
                            Name = @"Degree",
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
                            Id = @"VAR.4.8",
                            Type = @"Component",
                            Position = @"VAR.4.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.9",
                            Type = @"Component",
                            Position = @"VAR.4.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VAR.4.9.1",
                            Type = @"SubComponent",
                            Position = @"VAR.4.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.9.2",
                            Type = @"SubComponent",
                            Position = @"VAR.4.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.9.3",
                            Type = @"SubComponent",
                            Position = @"VAR.4.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.10",
                            Type = @"Component",
                            Position = @"VAR.4.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.11",
                            Type = @"Component",
                            Position = @"VAR.4.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.12",
                            Type = @"Component",
                            Position = @"VAR.4.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.13",
                            Type = @"Component",
                            Position = @"VAR.4.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.14",
                            Type = @"Component",
                            Position = @"VAR.4.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VAR.4.14.1",
                            Type = @"SubComponent",
                            Position = @"VAR.4.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.14.2",
                            Type = @"SubComponent",
                            Position = @"VAR.4.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.4.14.3",
                            Type = @"SubComponent",
                            Position = @"VAR.4.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _varianceOriginator = new HL7V23Field
        {
            field = message[@"VAR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_varianceOriginator.field.FieldRepetitions != null && _varianceOriginator.field.FieldRepetitions.Count > 0)
        {
            _varianceOriginator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_varianceOriginator, fieldData);
        }

        return _varianceOriginator;
    } 
}

internal HL7V23Field _varianceClassification;

public HL7V23Field VarianceClassification
{
    get
    {
        if (_varianceClassification != null)
        {
            return _varianceClassification;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"VAR.5",
            Type = @"Field",
            Position = @"VAR.5",
            Name = @"Variance Classification",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies a categorical set of variances.  Classification may be used by applications for presentation and processing functions",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VAR.5.1",
                            Type = @"Component",
                            Position = @"VAR.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.5.2",
                            Type = @"Component",
                            Position = @"VAR.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.5.3",
                            Type = @"Component",
                            Position = @"VAR.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.5.4",
                            Type = @"Component",
                            Position = @"VAR.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.5.5",
                            Type = @"Component",
                            Position = @"VAR.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VAR.5.6",
                            Type = @"Component",
                            Position = @"VAR.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _varianceClassification = new HL7V23Field
        {
            field = message[@"VAR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_varianceClassification.field.FieldRepetitions != null && _varianceClassification.field.FieldRepetitions.Count > 0)
        {
            _varianceClassification.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_varianceClassification, fieldData);
        }

        return _varianceClassification;
    } 
}

internal HL7V23Field _varianceDescription;

public HL7V23Field VarianceDescription
{
    get
    {
        if (_varianceDescription != null)
        {
            return _varianceDescription;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"VAR.6",
            Type = @"Field",
            Position = @"VAR.6",
            Name = @"Variance Description",
            Length = 512,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the details of a variance.  The content of the field is a string with optional formatting",
            Sample = @"",
            Fields = null
        }

        _varianceDescription = new HL7V23Field
        {
            field = message[@"VAR"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_varianceDescription.field.FieldRepetitions != null && _varianceDescription.field.FieldRepetitions.Count > 0)
        {
            _varianceDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_varianceDescription, fieldData);
        }

        return _varianceDescription;
    } 
}
    }
}
