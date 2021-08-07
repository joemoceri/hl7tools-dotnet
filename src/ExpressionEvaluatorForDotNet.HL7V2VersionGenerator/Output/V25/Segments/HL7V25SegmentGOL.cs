using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentGOL
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"GOL"; } }

        public string SegmentId { get { return @"GOL"; } }
        
        public string LongName { get { return @"Goal Detail"; } }
        
        public string Description { get { return @"The goal detail segment contains the data necessary to add, update, correct, and delete the goals for an individual."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GOL.1",
                            Type = @"Field",
                            Position = @"GOL.1",
                            Name = @"Action Code",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0287",
                            TableName = @"Problem/goal action code",
                            Description = @"The action code field gives the intent of the problem or goal. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.2",
                            Type = @"Field",
                            Position = @"GOL.2",
                            Name = @"Action Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the operation represented by the action code was performed.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.2.1",
                            Type = @"Component",
                            Position = @"GOL.2.1",
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
                            Id = @"GOL.2.2",
                            Type = @"Component",
                            Position = @"GOL.2.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.3",
                            Type = @"Field",
                            Position = @"GOL.3",
                            Name = @"Goal ID",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the goal. This is the identifier from an institutions master list of goals.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.3.1",
                            Type = @"Component",
                            Position = @"GOL.3.1",
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
                            Id = @"GOL.3.2",
                            Type = @"Component",
                            Position = @"GOL.3.2",
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
                            Id = @"GOL.3.3",
                            Type = @"Component",
                            Position = @"GOL.3.3",
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
                            Id = @"GOL.3.4",
                            Type = @"Component",
                            Position = @"GOL.3.4",
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
                            Id = @"GOL.3.5",
                            Type = @"Component",
                            Position = @"GOL.3.5",
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
                            Id = @"GOL.3.6",
                            Type = @"Component",
                            Position = @"GOL.3.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.4",
                            Type = @"Field",
                            Position = @"GOL.4",
                            Name = @"Goal Instance ID",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the unique identifier assigned by an initiating system to this instance of the goal.

Note:  It is required that the value in this field be unique over time.  This instance ID identifies a specific instance for a specific patient and is unique across all patients.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.4.1",
                            Type = @"Component",
                            Position = @"GOL.4.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.4.2",
                            Type = @"Component",
                            Position = @"GOL.4.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.4.3",
                            Type = @"Component",
                            Position = @"GOL.4.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"GOL.4.4",
                            Type = @"Component",
                            Position = @"GOL.4.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.5",
                            Type = @"Field",
                            Position = @"GOL.5",
                            Name = @"Episode of Care ID",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the episode of care to which this goal applies.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.5.1",
                            Type = @"Component",
                            Position = @"GOL.5.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.5.2",
                            Type = @"Component",
                            Position = @"GOL.5.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.5.3",
                            Type = @"Component",
                            Position = @"GOL.5.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"GOL.5.4",
                            Type = @"Component",
                            Position = @"GOL.5.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.6",
                            Type = @"Field",
                            Position = @"GOL.6",
                            Name = @"Goal List Priority",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field prioritizes this goal on a list that is maintained for an individual.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.7",
                            Type = @"Field",
                            Position = @"GOL.7",
                            Name = @"Goal Established Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the date/time when the stated goal was initially created.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.7.1",
                            Type = @"Component",
                            Position = @"GOL.7.1",
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
                            Id = @"GOL.7.2",
                            Type = @"Component",
                            Position = @"GOL.7.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.8",
                            Type = @"Field",
                            Position = @"GOL.8",
                            Name = @"Expected Goal Achieve Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the projected date/time for achieving the stated goal.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.8.1",
                            Type = @"Component",
                            Position = @"GOL.8.1",
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
                            Id = @"GOL.8.2",
                            Type = @"Component",
                            Position = @"GOL.8.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.9",
                            Type = @"Field",
                            Position = @"GOL.9",
                            Name = @"Goal Classification",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the kind of goal. This field can be used to categorize goals so that they may be managed and viewed independently within different applications (e.g., admission, final, post-operative, pre-operative, outpatient, discharge, etc.).

Note:  This field can be used to differentiate separate goal lists that may be managed independently within applications. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.9.1",
                            Type = @"Component",
                            Position = @"GOL.9.1",
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
                            Id = @"GOL.9.2",
                            Type = @"Component",
                            Position = @"GOL.9.2",
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
                            Id = @"GOL.9.3",
                            Type = @"Component",
                            Position = @"GOL.9.3",
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
                            Id = @"GOL.9.4",
                            Type = @"Component",
                            Position = @"GOL.9.4",
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
                            Id = @"GOL.9.5",
                            Type = @"Component",
                            Position = @"GOL.9.5",
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
                            Id = @"GOL.9.6",
                            Type = @"Component",
                            Position = @"GOL.9.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.10",
                            Type = @"Field",
                            Position = @"GOL.10",
                            Name = @"Goal Management Discipline",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the category of caregiver with responsibility for managing this specific goal (e.g., care team, nursing, medicine, respiratory therapy, occupational therapy, dietary etc.). This is a repeating field to allow identification of all disciplines that may have the responsibility for this goal.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.10.1",
                            Type = @"Component",
                            Position = @"GOL.10.1",
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
                            Id = @"GOL.10.2",
                            Type = @"Component",
                            Position = @"GOL.10.2",
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
                            Id = @"GOL.10.3",
                            Type = @"Component",
                            Position = @"GOL.10.3",
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
                            Id = @"GOL.10.4",
                            Type = @"Component",
                            Position = @"GOL.10.4",
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
                            Id = @"GOL.10.5",
                            Type = @"Component",
                            Position = @"GOL.10.5",
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
                            Id = @"GOL.10.6",
                            Type = @"Component",
                            Position = @"GOL.10.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.11",
                            Type = @"Field",
                            Position = @"GOL.11",
                            Name = @"Current Goal Review Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the current point in the continuum of a goal review cycle (e.g., due, initiated, reviewed, overdue, verified, etc.).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.11.1",
                            Type = @"Component",
                            Position = @"GOL.11.1",
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
                            Id = @"GOL.11.2",
                            Type = @"Component",
                            Position = @"GOL.11.2",
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
                            Id = @"GOL.11.3",
                            Type = @"Component",
                            Position = @"GOL.11.3",
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
                            Id = @"GOL.11.4",
                            Type = @"Component",
                            Position = @"GOL.11.4",
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
                            Id = @"GOL.11.5",
                            Type = @"Component",
                            Position = @"GOL.11.5",
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
                            Id = @"GOL.11.6",
                            Type = @"Component",
                            Position = @"GOL.11.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.12",
                            Type = @"Field",
                            Position = @"GOL.12",
                            Name = @"Current Goal Review Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time of the current review of the goal.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.12.1",
                            Type = @"Component",
                            Position = @"GOL.12.1",
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
                            Id = @"GOL.12.2",
                            Type = @"Component",
                            Position = @"GOL.12.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.13",
                            Type = @"Field",
                            Position = @"GOL.13",
                            Name = @"Next Goal Review Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time of the next scheduled goal review.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.13.1",
                            Type = @"Component",
                            Position = @"GOL.13.1",
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
                            Id = @"GOL.13.2",
                            Type = @"Component",
                            Position = @"GOL.13.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.14",
                            Type = @"Field",
                            Position = @"GOL.14",
                            Name = @"Previous Goal Review Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the goal was reviewed prior to the current review.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.14.1",
                            Type = @"Component",
                            Position = @"GOL.14.1",
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
                            Id = @"GOL.14.2",
                            Type = @"Component",
                            Position = @"GOL.14.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15",
                            Type = @"Field",
                            Position = @"GOL.15",
                            Name = @"Goal Review Interval",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TQ",
                            DataTypeName = @"Timing Quantity",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the interval used to calculate the next goal review date.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1",
                            Type = @"Component",
                            Position = @"GOL.15.1",
                            Name = @"Quantity",
                            Length = 267,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be 2. If three units of blood are to be typed and cross-matched, the quantity would be 3. The default value is 1. When units are required, they can be added, specified by a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.2",
                            Name = @"Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.3",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.4",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.5",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.1.6",
                            Type = @"SubComponent",
                            Position = @"GOL.15.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.2",
                            Type = @"Component",
                            Position = @"GOL.15.2",
                            Name = @"Interval",
                            Length = 206,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"Determines the interval between repeated services.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.2.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.2.1",
                            Name = @"Repeat Pattern",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered. It is similar to the frequency and SIG code tables used in order entry systems.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.2.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component explicitly lists the actual times referenced by the code in the first component, in the following format: HHMM,HHMM,HHMM,. This second component will be used to clarify the first component in cases where the actual times vary within an institution. If the time of the order spans more than a single day, this new component is only practical if the same times of administration occur for each day of the order. If the actual start time of the order (as given by the fourth component of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time. In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.3",
                            Type = @"Component",
                            Position = @"GOL.15.3",
                            Name = @"Duration",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component indicates how long the service should continue after it is started. The default is INDEF (do indefinitely). This component is coded as follows:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.4",
                            Type = @"Component",
                            Position = @"GOL.15.4",
                            Name = @"Start Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This component may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started. In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT). In such a case, this field will be empty.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.4.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.4.1",
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
                            Id = @"GOL.15.4.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.4.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.5",
                            Type = @"Component",
                            Position = @"GOL.15.5",
                            Name = @"End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this component should contain the latest date/time that the service should be performed. If it has not been performed by the specified time, it should not be performed at all. The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.5.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.5.1",
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
                            Id = @"GOL.15.5.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.5.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.6",
                            Type = @"Component",
                            Position = @"GOL.15.6",
                            Name = @"Priority",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes the urgency of the request. The following values are suggested (the default for Priority is R):",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.7",
                            Type = @"Component",
                            Position = @"GOL.15.7",
                            Name = @"Condition",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text component that describes the conditions under which the drug is to be given. For example, PRN pain , or to keep blood pressure below 110. The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.8",
                            Type = @"Component",
                            Position = @"GOL.15.8",
                            Name = @"Text",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is a full text version of the instruction (optional).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.9",
                            Type = @"Component",
                            Position = @"GOL.15.9",
                            Name = @"Conjunction",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0472",
                            TableName = @"TQ conjunction ID",
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter. Refer to HL7 table 0472 - TQ Conjunction ID for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10",
                            Type = @"Component",
                            Position = @"GOL.15.10",
                            Name = @"Order Sequencing",
                            Length = 110,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"OSD",
                            DataTypeName = @"Order Sequence Definition",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.1",
                            Name = @"Sequence/Results Flag",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0524",
                            TableName = @"Sequence condition",
                            Description = @"Identifies whether sequence conditions or a repeating cycle of orders is defined. Refer to HL7-defined Table 0524 - Sequence condition for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.2",
                            Name = @"Placer Order Number: Entity Identifier",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first component of the placer order number, entity identifier .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.3",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.3",
                            Name = @"Placer Order Number: Namespace Id",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"Contains the second component of the placer order number, namespace ID. Refer to user-defined table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.4",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.4",
                            Name = @"Filler Order Number: Entity Identifier",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first component of the filler order number, entity identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.5",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.5",
                            Name = @"Filler Order Number: Namespace Id",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"Contains the second component of the filler order number, namespace ID. Refer to user-defined table 0363 - Assigning Authority for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.6",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the relationship between the start/end of the related predecessor or successor order and the current order from ORC-2, 3 or 4.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.7",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups. The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.8",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.8",
                            Name = @"Placer Order Number: Universal Id",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the next to the last component of the placer order number, universal ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.9",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.9",
                            Name = @"Placer Order Number: Universal Id Type",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Contains the last component of the placer order number. Refer to HL7 table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.10",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.10",
                            Name = @"Filler Order Number: Universal Id",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the next to the last component of the filler order number, universal ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.10.11",
                            Type = @"SubComponent",
                            Position = @"GOL.15.10.11",
                            Name = @"Filler Order Number: Universal Id Type",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Contains the last component of the placer order number. Refer to HL7 table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.11",
                            Type = @"Component",
                            Position = @"GOL.15.11",
                            Name = @"Occurrence Duration",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the duration for a single performance of a service, e.g., whirlpool twenty minutes three times per day for three days. It is optional within TQ and does not repeat.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.11.1",
                            Type = @"SubComponent",
                            Position = @"GOL.15.11.1",
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
                            Id = @"GOL.15.11.2",
                            Type = @"SubComponent",
                            Position = @"GOL.15.11.2",
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
                            Id = @"GOL.15.11.3",
                            Type = @"SubComponent",
                            Position = @"GOL.15.11.3",
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
                            Id = @"GOL.15.11.4",
                            Type = @"SubComponent",
                            Position = @"GOL.15.11.4",
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
                            Id = @"GOL.15.11.5",
                            Type = @"SubComponent",
                            Position = @"GOL.15.11.5",
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
                            Id = @"GOL.15.11.6",
                            Type = @"SubComponent",
                            Position = @"GOL.15.11.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.15.12",
                            Type = @"Component",
                            Position = @"GOL.15.12",
                            Name = @"Total Occurrences",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the total number of occurrences of a service that should result from this order. It is optional within TQ and does not repeat. If both the end date/time and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence. Otherwise the number of occurrences takes precedence.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.16",
                            Type = @"Field",
                            Position = @"GOL.16",
                            Name = @"Goal Evaluation",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field provides an indicator of progress towards achievement of the goal (e.g., achieved, ahead of schedule, delayed, failed to achieve, etc.).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.16.1",
                            Type = @"Component",
                            Position = @"GOL.16.1",
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
                            Id = @"GOL.16.2",
                            Type = @"Component",
                            Position = @"GOL.16.2",
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
                            Id = @"GOL.16.3",
                            Type = @"Component",
                            Position = @"GOL.16.3",
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
                            Id = @"GOL.16.4",
                            Type = @"Component",
                            Position = @"GOL.16.4",
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
                            Id = @"GOL.16.5",
                            Type = @"Component",
                            Position = @"GOL.16.5",
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
                            Id = @"GOL.16.6",
                            Type = @"Component",
                            Position = @"GOL.16.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.17",
                            Type = @"Field",
                            Position = @"GOL.17",
                            Name = @"Goal Evaluation Comment",
                            Length = 300,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the comments associated with the goal evaluation. Examples of comments that might be entered in this field include: a reason for delay in achieving goal, or a clinical footnote about progress made towards the goal, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.18",
                            Type = @"Field",
                            Position = @"GOL.18",
                            Name = @"Goal Life Cycle Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an indication of the state of the goal (e.g., Active, Canceled, Inactive, Suspended, etc.).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.18.1",
                            Type = @"Component",
                            Position = @"GOL.18.1",
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
                            Id = @"GOL.18.2",
                            Type = @"Component",
                            Position = @"GOL.18.2",
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
                            Id = @"GOL.18.3",
                            Type = @"Component",
                            Position = @"GOL.18.3",
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
                            Id = @"GOL.18.4",
                            Type = @"Component",
                            Position = @"GOL.18.4",
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
                            Id = @"GOL.18.5",
                            Type = @"Component",
                            Position = @"GOL.18.5",
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
                            Id = @"GOL.18.6",
                            Type = @"Component",
                            Position = @"GOL.18.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.19",
                            Type = @"Field",
                            Position = @"GOL.19",
                            Name = @"Goal Life Cycle Status Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the effective date/time of the current goal life cycle status.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.19.1",
                            Type = @"Component",
                            Position = @"GOL.19.1",
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
                            Id = @"GOL.19.2",
                            Type = @"Component",
                            Position = @"GOL.19.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.20",
                            Type = @"Field",
                            Position = @"GOL.20",
                            Name = @"Goal Target Type",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the individual/group for whom the goal has been established (e.g., family group, family member, patient, etc.).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.20.1",
                            Type = @"Component",
                            Position = @"GOL.20.1",
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
                            Id = @"GOL.20.2",
                            Type = @"Component",
                            Position = @"GOL.20.2",
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
                            Id = @"GOL.20.3",
                            Type = @"Component",
                            Position = @"GOL.20.3",
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
                            Id = @"GOL.20.4",
                            Type = @"Component",
                            Position = @"GOL.20.4",
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
                            Id = @"GOL.20.5",
                            Type = @"Component",
                            Position = @"GOL.20.5",
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
                            Id = @"GOL.20.6",
                            Type = @"Component",
                            Position = @"GOL.20.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21",
                            Type = @"Field",
                            Position = @"GOL.21",
                            Name = @"Goal Target Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identification of the person(s) on whom the goal is focused. This is a repeating field which allows for the identification of a group of individuals.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.1",
                            Type = @"Component",
                            Position = @"GOL.21.1",
                            Name = @"Family Name",
                            Length = 194,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.A.30, ""FN - family name"".",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.1.1",
                            Type = @"SubComponent",
                            Position = @"GOL.21.1.1",
                            Name = @"Surname",
                            Length = 50,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = @"The atomic element of the person's family name. In most Western usage, this is the person's last name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.1.2",
                            Type = @"SubComponent",
                            Position = @"GOL.21.1.2",
                            Name = @"Own Surname Prefix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the ""van"" in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.1.3",
                            Type = @"SubComponent",
                            Position = @"GOL.21.1.3",
                            Name = @"Own Surname",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.1.4",
                            Type = @"SubComponent",
                            Position = @"GOL.21.1.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.1.5",
                            Type = @"SubComponent",
                            Position = @"GOL.21.1.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.2",
                            Type = @"Component",
                            Position = @"GOL.21.2",
                            Name = @"Given Name",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = @"First name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.3",
                            Type = @"Component",
                            Position = @"GOL.21.3",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Multiple middle names may be included by separating them with spaces.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.4",
                            Type = @"Component",
                            Position = @"GOL.21.4",
                            Name = @"Suffix (e.g., Jr Or Iii)",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.5",
                            Type = @"Component",
                            Position = @"GOL.21.5",
                            Name = @"Prefix (e.g., Dr)",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.6",
                            Type = @"Component",
                            Position = @"GOL.21.6",
                            Name = @"Degree (e.g., Md)",
                            Length = 6,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree/license/certificate",
                            Description = @"Retained for backward compatibility only as of v 2.5. See Professional Suffix component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.7",
                            Type = @"Component",
                            Position = @"GOL.21.7",
                            Name = @"Name Type Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.8",
                            Type = @"Component",
                            Position = @"GOL.21.8",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.9",
                            Type = @"Component",
                            Position = @"GOL.21.9",
                            Name = @"Name Context",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.9.1",
                            Type = @"SubComponent",
                            Position = @"GOL.21.9.1",
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
                            Id = @"GOL.21.9.2",
                            Type = @"SubComponent",
                            Position = @"GOL.21.9.2",
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
                            Id = @"GOL.21.9.3",
                            Type = @"SubComponent",
                            Position = @"GOL.21.9.3",
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
                            Id = @"GOL.21.9.4",
                            Type = @"SubComponent",
                            Position = @"GOL.21.9.4",
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
                            Id = @"GOL.21.9.5",
                            Type = @"SubComponent",
                            Position = @"GOL.21.9.5",
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
                            Id = @"GOL.21.9.6",
                            Type = @"SubComponent",
                            Position = @"GOL.21.9.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.10",
                            Type = @"Component",
                            Position = @"GOL.21.10",
                            Name = @"Name Validity Range",
                            Length = 53,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component cannot be fully expressed. Identified as v 2.4 erratum. Retained for backward compatibility only as of v 2.5. Refer to Effective Date and Expiration Date components.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.10.1",
                            Type = @"SubComponent",
                            Position = @"GOL.21.10.1",
                            Name = @"Range Start Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.10.1",
                            Type = @"SubComponent",
                            Position = @"GOL.21.10.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.10.2",
                            Type = @"SubComponent",
                            Position = @"GOL.21.10.2",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.10.2",
                            Type = @"SubComponent",
                            Position = @"GOL.21.10.2",
                            Name = @"Range End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.10.1",
                            Type = @"SubComponent",
                            Position = @"GOL.21.10.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.10.2",
                            Type = @"SubComponent",
                            Position = @"GOL.21.10.2",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.11",
                            Type = @"Component",
                            Position = @"GOL.21.11",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 0444 - Name assembly order for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.12",
                            Type = @"Component",
                            Position = @"GOL.21.12",
                            Name = @"Effective Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.12.1",
                            Type = @"SubComponent",
                            Position = @"GOL.21.12.1",
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
                            Id = @"GOL.21.12.2",
                            Type = @"SubComponent",
                            Position = @"GOL.21.12.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.13",
                            Type = @"Component",
                            Position = @"GOL.21.13",
                            Name = @"Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.13.1",
                            Type = @"SubComponent",
                            Position = @"GOL.21.13.1",
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
                            Id = @"GOL.21.13.2",
                            Type = @"SubComponent",
                            Position = @"GOL.21.13.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GOL.21.14",
                            Type = @"Component",
                            Position = @"GOL.21.14",
                            Name = @"Professional Suffix",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, Personnel Management.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V25SegmentGOL(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field actionCode;

public HL7V25Field ActionCode
{
    get
    {
        if (actionCode != null)
        {
            return actionCode;
        }

        actionCode = new HL7V25Field
        {
            field = message[@"GOL"][1],
            Id = @"GOL.1",
            Type = @"Field",
            Position = @"GOL.1",
            Name = @"Action Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0287",
            TableName = @"Problem/goal action code",
            Description = @"The action code field gives the intent of the problem or goal. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
            Sample = @"",
        };

        

        

        

        return actionCode;
    } 
}
internal HL7V25Field actionDateTime;

public HL7V25Field ActionDateTime
{
    get
    {
        if (actionDateTime != null)
        {
            return actionDateTime;
        }

        actionDateTime = new HL7V25Field
        {
            field = message[@"GOL"][2],
            Id = @"GOL.2",
            Type = @"Field",
            Position = @"GOL.2",
            Name = @"Action Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the operation represented by the action code was performed.",
            Sample = @"",
        };

        

        

        

        return actionDateTime;
    } 
}
internal HL7V25Field goalID;

public HL7V25Field GoalID
{
    get
    {
        if (goalID != null)
        {
            return goalID;
        }

        goalID = new HL7V25Field
        {
            field = message[@"GOL"][3],
            Id = @"GOL.3",
            Type = @"Field",
            Position = @"GOL.3",
            Name = @"Goal ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the goal. This is the identifier from an institutions master list of goals.",
            Sample = @"",
        };

        

        

        

        return goalID;
    } 
}
internal HL7V25Field goalInstanceID;

public HL7V25Field GoalInstanceID
{
    get
    {
        if (goalInstanceID != null)
        {
            return goalInstanceID;
        }

        goalInstanceID = new HL7V25Field
        {
            field = message[@"GOL"][4],
            Id = @"GOL.4",
            Type = @"Field",
            Position = @"GOL.4",
            Name = @"Goal Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique identifier assigned by an initiating system to this instance of the goal.

Note:  It is required that the value in this field be unique over time.  This instance ID identifies a specific instance for a specific patient and is unique across all patients.",
            Sample = @"",
        };

        

        

        

        return goalInstanceID;
    } 
}
internal HL7V25Field episodeofCareID;

public HL7V25Field EpisodeofCareID
{
    get
    {
        if (episodeofCareID != null)
        {
            return episodeofCareID;
        }

        episodeofCareID = new HL7V25Field
        {
            field = message[@"GOL"][5],
            Id = @"GOL.5",
            Type = @"Field",
            Position = @"GOL.5",
            Name = @"Episode of Care ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the episode of care to which this goal applies.",
            Sample = @"",
        };

        

        

        

        return episodeofCareID;
    } 
}
internal HL7V25Field goalListPriority;

public HL7V25Field GoalListPriority
{
    get
    {
        if (goalListPriority != null)
        {
            return goalListPriority;
        }

        goalListPriority = new HL7V25Field
        {
            field = message[@"GOL"][6],
            Id = @"GOL.6",
            Type = @"Field",
            Position = @"GOL.6",
            Name = @"Goal List Priority",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field prioritizes this goal on a list that is maintained for an individual.",
            Sample = @"",
        };

        

        

        

        return goalListPriority;
    } 
}
internal HL7V25Field goalEstablishedDateTime;

public HL7V25Field GoalEstablishedDateTime
{
    get
    {
        if (goalEstablishedDateTime != null)
        {
            return goalEstablishedDateTime;
        }

        goalEstablishedDateTime = new HL7V25Field
        {
            field = message[@"GOL"][7],
            Id = @"GOL.7",
            Type = @"Field",
            Position = @"GOL.7",
            Name = @"Goal Established Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the date/time when the stated goal was initially created.",
            Sample = @"",
        };

        

        

        

        return goalEstablishedDateTime;
    } 
}
internal HL7V25Field expectedGoalAchieveDateTime;

public HL7V25Field ExpectedGoalAchieveDateTime
{
    get
    {
        if (expectedGoalAchieveDateTime != null)
        {
            return expectedGoalAchieveDateTime;
        }

        expectedGoalAchieveDateTime = new HL7V25Field
        {
            field = message[@"GOL"][8],
            Id = @"GOL.8",
            Type = @"Field",
            Position = @"GOL.8",
            Name = @"Expected Goal Achieve Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the projected date/time for achieving the stated goal.",
            Sample = @"",
        };

        

        

        

        return expectedGoalAchieveDateTime;
    } 
}
internal HL7V25Field goalClassification;

public HL7V25Field GoalClassification
{
    get
    {
        if (goalClassification != null)
        {
            return goalClassification;
        }

        goalClassification = new HL7V25Field
        {
            field = message[@"GOL"][9],
            Id = @"GOL.9",
            Type = @"Field",
            Position = @"GOL.9",
            Name = @"Goal Classification",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the kind of goal. This field can be used to categorize goals so that they may be managed and viewed independently within different applications (e.g., admission, final, post-operative, pre-operative, outpatient, discharge, etc.).

Note:  This field can be used to differentiate separate goal lists that may be managed independently within applications. ",
            Sample = @"",
        };

        

        

        

        return goalClassification;
    } 
}
internal HL7V25Field goalManagementDiscipline;

public HL7V25Field GoalManagementDiscipline
{
    get
    {
        if (goalManagementDiscipline != null)
        {
            return goalManagementDiscipline;
        }

        goalManagementDiscipline = new HL7V25Field
        {
            field = message[@"GOL"][10],
            Id = @"GOL.10",
            Type = @"Field",
            Position = @"GOL.10",
            Name = @"Goal Management Discipline",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the category of caregiver with responsibility for managing this specific goal (e.g., care team, nursing, medicine, respiratory therapy, occupational therapy, dietary etc.). This is a repeating field to allow identification of all disciplines that may have the responsibility for this goal.",
            Sample = @"",
        };

        

        

        

        return goalManagementDiscipline;
    } 
}
internal HL7V25Field currentGoalReviewStatus;

public HL7V25Field CurrentGoalReviewStatus
{
    get
    {
        if (currentGoalReviewStatus != null)
        {
            return currentGoalReviewStatus;
        }

        currentGoalReviewStatus = new HL7V25Field
        {
            field = message[@"GOL"][11],
            Id = @"GOL.11",
            Type = @"Field",
            Position = @"GOL.11",
            Name = @"Current Goal Review Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the current point in the continuum of a goal review cycle (e.g., due, initiated, reviewed, overdue, verified, etc.).",
            Sample = @"",
        };

        

        

        

        return currentGoalReviewStatus;
    } 
}
internal HL7V25Field currentGoalReviewDateTime;

public HL7V25Field CurrentGoalReviewDateTime
{
    get
    {
        if (currentGoalReviewDateTime != null)
        {
            return currentGoalReviewDateTime;
        }

        currentGoalReviewDateTime = new HL7V25Field
        {
            field = message[@"GOL"][12],
            Id = @"GOL.12",
            Type = @"Field",
            Position = @"GOL.12",
            Name = @"Current Goal Review Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time of the current review of the goal.",
            Sample = @"",
        };

        

        

        

        return currentGoalReviewDateTime;
    } 
}
internal HL7V25Field nextGoalReviewDateTime;

public HL7V25Field NextGoalReviewDateTime
{
    get
    {
        if (nextGoalReviewDateTime != null)
        {
            return nextGoalReviewDateTime;
        }

        nextGoalReviewDateTime = new HL7V25Field
        {
            field = message[@"GOL"][13],
            Id = @"GOL.13",
            Type = @"Field",
            Position = @"GOL.13",
            Name = @"Next Goal Review Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time of the next scheduled goal review.",
            Sample = @"",
        };

        

        

        

        return nextGoalReviewDateTime;
    } 
}
internal HL7V25Field previousGoalReviewDateTime;

public HL7V25Field PreviousGoalReviewDateTime
{
    get
    {
        if (previousGoalReviewDateTime != null)
        {
            return previousGoalReviewDateTime;
        }

        previousGoalReviewDateTime = new HL7V25Field
        {
            field = message[@"GOL"][14],
            Id = @"GOL.14",
            Type = @"Field",
            Position = @"GOL.14",
            Name = @"Previous Goal Review Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the goal was reviewed prior to the current review.",
            Sample = @"",
        };

        

        

        

        return previousGoalReviewDateTime;
    } 
}
internal HL7V25Field goalReviewInterval;

public HL7V25Field GoalReviewInterval
{
    get
    {
        if (goalReviewInterval != null)
        {
            return goalReviewInterval;
        }

        goalReviewInterval = new HL7V25Field
        {
            field = message[@"GOL"][15],
            Id = @"GOL.15",
            Type = @"Field",
            Position = @"GOL.15",
            Name = @"Goal Review Interval",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field contains the interval used to calculate the next goal review date.",
            Sample = @"",
        };

        

        

        

        return goalReviewInterval;
    } 
}
internal HL7V25Field goalEvaluation;

public HL7V25Field GoalEvaluation
{
    get
    {
        if (goalEvaluation != null)
        {
            return goalEvaluation;
        }

        goalEvaluation = new HL7V25Field
        {
            field = message[@"GOL"][16],
            Id = @"GOL.16",
            Type = @"Field",
            Position = @"GOL.16",
            Name = @"Goal Evaluation",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field provides an indicator of progress towards achievement of the goal (e.g., achieved, ahead of schedule, delayed, failed to achieve, etc.).",
            Sample = @"",
        };

        

        

        

        return goalEvaluation;
    } 
}
internal HL7V25Field goalEvaluationComment;

public HL7V25Field GoalEvaluationComment
{
    get
    {
        if (goalEvaluationComment != null)
        {
            return goalEvaluationComment;
        }

        goalEvaluationComment = new HL7V25Field
        {
            field = message[@"GOL"][17],
            Id = @"GOL.17",
            Type = @"Field",
            Position = @"GOL.17",
            Name = @"Goal Evaluation Comment",
            Length = 300,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the comments associated with the goal evaluation. Examples of comments that might be entered in this field include: a reason for delay in achieving goal, or a clinical footnote about progress made towards the goal, etc.",
            Sample = @"",
        };

        

        

        

        return goalEvaluationComment;
    } 
}
internal HL7V25Field goalLifeCycleStatus;

public HL7V25Field GoalLifeCycleStatus
{
    get
    {
        if (goalLifeCycleStatus != null)
        {
            return goalLifeCycleStatus;
        }

        goalLifeCycleStatus = new HL7V25Field
        {
            field = message[@"GOL"][18],
            Id = @"GOL.18",
            Type = @"Field",
            Position = @"GOL.18",
            Name = @"Goal Life Cycle Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an indication of the state of the goal (e.g., Active, Canceled, Inactive, Suspended, etc.).",
            Sample = @"",
        };

        

        

        

        return goalLifeCycleStatus;
    } 
}
internal HL7V25Field goalLifeCycleStatusDateTime;

public HL7V25Field GoalLifeCycleStatusDateTime
{
    get
    {
        if (goalLifeCycleStatusDateTime != null)
        {
            return goalLifeCycleStatusDateTime;
        }

        goalLifeCycleStatusDateTime = new HL7V25Field
        {
            field = message[@"GOL"][19],
            Id = @"GOL.19",
            Type = @"Field",
            Position = @"GOL.19",
            Name = @"Goal Life Cycle Status Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the effective date/time of the current goal life cycle status.",
            Sample = @"",
        };

        

        

        

        return goalLifeCycleStatusDateTime;
    } 
}
internal HL7V25Field goalTargetType;

public HL7V25Field GoalTargetType
{
    get
    {
        if (goalTargetType != null)
        {
            return goalTargetType;
        }

        goalTargetType = new HL7V25Field
        {
            field = message[@"GOL"][20],
            Id = @"GOL.20",
            Type = @"Field",
            Position = @"GOL.20",
            Name = @"Goal Target Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual/group for whom the goal has been established (e.g., family group, family member, patient, etc.).",
            Sample = @"",
        };

        

        

        

        return goalTargetType;
    } 
}
internal HL7V25Field goalTargetName;

public HL7V25Field GoalTargetName
{
    get
    {
        if (goalTargetName != null)
        {
            return goalTargetName;
        }

        goalTargetName = new HL7V25Field
        {
            field = message[@"GOL"][21],
            Id = @"GOL.21",
            Type = @"Field",
            Position = @"GOL.21",
            Name = @"Goal Target Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identification of the person(s) on whom the goal is focused. This is a repeating field which allows for the identification of a group of individuals.",
            Sample = @"",
        };

        

        

        

        return goalTargetName;
    } 
}

    }
}
