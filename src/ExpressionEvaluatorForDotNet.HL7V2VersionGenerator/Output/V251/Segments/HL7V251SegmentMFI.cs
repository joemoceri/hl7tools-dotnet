using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentMFI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFI"; } }

        public string SegmentId { get { return @"MFI"; } }
        
        public string LongName { get { return @"Master File Identification"; } }
        
        public string Description { get { return @"The Technical Steward for the MFI segment is CQ."; } }
        
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
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0175",
                            TableName = @"Master file identifier code",
                            Description = @"This field is a CE data type that identifies a standard HL7 master file. This table may be extended by local agreement during implementation to cover site-specific master files (z-master files). HL7 recommends use of the HL7 assigned table number as the master file identifier code if one is not specified in Table 0175. For example, a master file of Marital Status codes would be identified by HL70002 as the MFI-1 - Master file identifier. Refer to HL7 table 0175 - Master file identifier code for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFI.1.1",
                            Type = @"Component",
                            Position = @"MFI.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.2",
                            Type = @"Component",
                            Position = @"MFI.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.3",
                            Type = @"Component",
                            Position = @"MFI.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.4",
                            Type = @"Component",
                            Position = @"MFI.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.5",
                            Type = @"Component",
                            Position = @"MFI.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.1.6",
                            Type = @"Component",
                            Position = @"MFI.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
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
                            Length = 180,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0361",
                            TableName = @"Application",
                            Description = @"This field contains an optional code of up to 180 characters which (if applicable) uniquely identifies the application responsible for maintaining this file at a particular site. A group of intercommunicating applications may use more than a single instance of a master file of certain type (e.g., charge master or physician master). The particular instance of the file is identified by this field. Refer to User defined table 0361 - Applications.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFI.2.1",
                            Type = @"Component",
                            Position = @"MFI.2.1",
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
                            Id = @"MFI.2.2",
                            Type = @"Component",
                            Position = @"MFI.2.2",
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
                            Id = @"MFI.2.3",
                            Type = @"Component",
                            Position = @"MFI.2.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.3",
                            Type = @"Field",
                            Position = @"MFI.3",
                            Name = @"File-Level Event Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0178",
                            TableName = @"File level event code",
                            Description = @"This field defines the file-level event code. Refer to HL7 table 0178 - File level event code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.4",
                            Type = @"Field",
                            Position = @"MFI.4",
                            Name = @"Entered Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the time stamp for file-level event on originating system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFI.4.1",
                            Type = @"Component",
                            Position = @"MFI.4.1",
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
                            Id = @"MFI.4.2",
                            Type = @"Component",
                            Position = @"MFI.4.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFI.5",
                            Type = @"Field",
                            Position = @"MFI.5",
                            Name = @"Effective Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This optional field contains the effective date/time, which can be included for file-level action specified. It is the date/time the originating system expects that the event is to have been completed on the receiving system. If this field is not present, the action date/time should default to the current date/time (when the message is received).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFI.5.1",
                            Type = @"Component",
                            Position = @"MFI.5.1",
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
                            Id = @"MFI.5.2",
                            Type = @"Component",
                            Position = @"MFI.5.2",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0179",
                            TableName = @"Response level",
                            Description = @"These codes specify the application response level defined for a given Master File Message at the MFE segment level as defined in HL7 table 0179 - Response level. Required for MFN-Master File Notification message. Specifies additional detail (beyond MSH-15 - Accept Acknowledgment Type and MSH-16 - Application Acknowledgment Type) for application-level acknowledgment paradigms for Master Files transactions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentMFI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field masterFileIdentifier;

public HL7V251Field MasterFileIdentifier
{
    get
    {
        if (masterFileIdentifier != null)
        {
            return masterFileIdentifier;
        }

        masterFileIdentifier = new HL7V251Field
        {
            field = message[@"MFI"][1],
            Id = @"MFI.1",
            Type = @"Field",
            Position = @"MFI.1",
            Name = @"Master File Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0175",
            TableName = @"Master file identifier code",
            Description = @"This field is a CE data type that identifies a standard HL7 master file. This table may be extended by local agreement during implementation to cover site-specific master files (z-master files). HL7 recommends use of the HL7 assigned table number as the master file identifier code if one is not specified in Table 0175. For example, a master file of Marital Status codes would be identified by HL70002 as the MFI-1 - Master file identifier. Refer to HL7 table 0175 - Master file identifier code for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (masterFileIdentifier.field.FieldRepetitions != null && masterFileIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(masterFileIdentifier.Id));
            masterFileIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(masterFileIdentifier, fieldData);
        }

        return masterFileIdentifier;
    } 
}

internal HL7V251Field masterFileApplicationIdentifier;

public HL7V251Field MasterFileApplicationIdentifier
{
    get
    {
        if (masterFileApplicationIdentifier != null)
        {
            return masterFileApplicationIdentifier;
        }

        masterFileApplicationIdentifier = new HL7V251Field
        {
            field = message[@"MFI"][2],
            Id = @"MFI.2",
            Type = @"Field",
            Position = @"MFI.2",
            Name = @"Master File Application Identifier",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Application",
            Description = @"This field contains an optional code of up to 180 characters which (if applicable) uniquely identifies the application responsible for maintaining this file at a particular site. A group of intercommunicating applications may use more than a single instance of a master file of certain type (e.g., charge master or physician master). The particular instance of the file is identified by this field. Refer to User defined table 0361 - Applications.",
            Sample = @"",
        };

        // check for repetitions
        if (masterFileApplicationIdentifier.field.FieldRepetitions != null && masterFileApplicationIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(masterFileApplicationIdentifier.Id));
            masterFileApplicationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(masterFileApplicationIdentifier, fieldData);
        }

        return masterFileApplicationIdentifier;
    } 
}

internal HL7V251Field fileLevelEventCode;

public HL7V251Field FileLevelEventCode
{
    get
    {
        if (fileLevelEventCode != null)
        {
            return fileLevelEventCode;
        }

        fileLevelEventCode = new HL7V251Field
        {
            field = message[@"MFI"][3],
            Id = @"MFI.3",
            Type = @"Field",
            Position = @"MFI.3",
            Name = @"File-Level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0178",
            TableName = @"File level event code",
            Description = @"This field defines the file-level event code. Refer to HL7 table 0178 - File level event code for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (fileLevelEventCode.field.FieldRepetitions != null && fileLevelEventCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileLevelEventCode.Id));
            fileLevelEventCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(fileLevelEventCode, fieldData);
        }

        return fileLevelEventCode;
    } 
}

internal HL7V251Field enteredDateTime;

public HL7V251Field EnteredDateTime
{
    get
    {
        if (enteredDateTime != null)
        {
            return enteredDateTime;
        }

        enteredDateTime = new HL7V251Field
        {
            field = message[@"MFI"][4],
            Id = @"MFI.4",
            Type = @"Field",
            Position = @"MFI.4",
            Name = @"Entered Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time stamp for file-level event on originating system.",
            Sample = @"",
        };

        // check for repetitions
        if (enteredDateTime.field.FieldRepetitions != null && enteredDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(enteredDateTime.Id));
            enteredDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(enteredDateTime, fieldData);
        }

        return enteredDateTime;
    } 
}

internal HL7V251Field effectiveDateTime;

public HL7V251Field EffectiveDateTime
{
    get
    {
        if (effectiveDateTime != null)
        {
            return effectiveDateTime;
        }

        effectiveDateTime = new HL7V251Field
        {
            field = message[@"MFI"][5],
            Id = @"MFI.5",
            Type = @"Field",
            Position = @"MFI.5",
            Name = @"Effective Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This optional field contains the effective date/time, which can be included for file-level action specified. It is the date/time the originating system expects that the event is to have been completed on the receiving system. If this field is not present, the action date/time should default to the current date/time (when the message is received).",
            Sample = @"",
        };

        // check for repetitions
        if (effectiveDateTime.field.FieldRepetitions != null && effectiveDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(effectiveDateTime.Id));
            effectiveDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(effectiveDateTime, fieldData);
        }

        return effectiveDateTime;
    } 
}

internal HL7V251Field responseLevelCode;

public HL7V251Field ResponseLevelCode
{
    get
    {
        if (responseLevelCode != null)
        {
            return responseLevelCode;
        }

        responseLevelCode = new HL7V251Field
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
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0179",
            TableName = @"Response level",
            Description = @"These codes specify the application response level defined for a given Master File Message at the MFE segment level as defined in HL7 table 0179 - Response level. Required for MFN-Master File Notification message. Specifies additional detail (beyond MSH-15 - Accept Acknowledgment Type and MSH-16 - Application Acknowledgment Type) for application-level acknowledgment paradigms for Master Files transactions.",
            Sample = @"",
        };

        // check for repetitions
        if (responseLevelCode.field.FieldRepetitions != null && responseLevelCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(responseLevelCode.Id));
            responseLevelCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(responseLevelCode, fieldData);
        }

        return responseLevelCode;
    } 
}
    }
}
