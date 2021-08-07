using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentPTH
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PTH"; } }

        public string SegmentId { get { return @"PTH"; } }
        
        public string LongName { get { return @"Pathway"; } }
        
        public string Description { get { return @"The pathway segment contains the data necessary to add, update, correct, and delete from the record pathways that are utilized to address an individuals health care."; } }
        
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
                            Id = @"PTH.1",
                            Type = @"Field",
                            Position = @"PTH.1",
                            Name = @"Action Code",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0287",
                            TableName = @"Problem/goal action code",
                            Description = @"This field reveals the intent of the message. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2",
                            Type = @"Field",
                            Position = @"PTH.2",
                            Name = @"Pathway ID",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the pathway master data identifier associated with the referenced problem or goal. Examples; open heart pathway, new diabetic, total hip replace.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2.1",
                            Type = @"Component",
                            Position = @"PTH.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2.2",
                            Type = @"Component",
                            Position = @"PTH.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2.3",
                            Type = @"Component",
                            Position = @"PTH.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2.4",
                            Type = @"Component",
                            Position = @"PTH.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2.5",
                            Type = @"Component",
                            Position = @"PTH.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2.6",
                            Type = @"Component",
                            Position = @"PTH.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.3",
                            Type = @"Field",
                            Position = @"PTH.3",
                            Name = @"Pathway Instance ID",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a value generated by the originating application that represents an associated order placer group number, or other unique identifier assigned to the grouping of pathway directives.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PTH.3.1",
                            Type = @"Component",
                            Position = @"PTH.3.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.3.2",
                            Type = @"Component",
                            Position = @"PTH.3.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.3.3",
                            Type = @"Component",
                            Position = @"PTH.3.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.3.4",
                            Type = @"Component",
                            Position = @"PTH.3.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.4",
                            Type = @"Field",
                            Position = @"PTH.4",
                            Name = @"Pathway Established Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identification of the event time for the current pathway record.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PTH.4.1",
                            Type = @"Component",
                            Position = @"PTH.4.1",
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
                            Id = @"PTH.4.2",
                            Type = @"Component",
                            Position = @"PTH.4.2",
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
                            Id = @"PTH.5",
                            Type = @"Field",
                            Position = @"PTH.5",
                            Name = @"Pathway Life Cycle Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an application-specific set of state identifiers (e.g., Active, Suspended, Complete, Canceled, Delayed, Scheduled).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5.1",
                            Type = @"Component",
                            Position = @"PTH.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5.2",
                            Type = @"Component",
                            Position = @"PTH.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5.3",
                            Type = @"Component",
                            Position = @"PTH.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5.4",
                            Type = @"Component",
                            Position = @"PTH.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5.5",
                            Type = @"Component",
                            Position = @"PTH.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5.6",
                            Type = @"Component",
                            Position = @"PTH.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.6",
                            Type = @"Field",
                            Position = @"PTH.6",
                            Name = @"Change Pathway Life Cycle Status Date/Time",
                            Length = 26,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time when pathway has been modified or deactivated. (Marked as conditional - must be filled in if trigger event is update or terminate pathway)",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PTH.6.1",
                            Type = @"Component",
                            Position = @"PTH.6.1",
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
                            Id = @"PTH.6.2",
                            Type = @"Component",
                            Position = @"PTH.6.2",
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
                        };
            }
        }

        public HL7V24SegmentPTH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field actionCode;

public HL7V24Field ActionCode
{
    get
    {
        if (actionCode != null)
        {
            return actionCode;
        }

        actionCode = new HL7V24Field
        {
            field = message[@"PTH"][1],
            Id = @"PTH.1",
            Type = @"Field",
            Position = @"PTH.1",
            Name = @"Action Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0287",
            TableName = @"Problem/goal action code",
            Description = @"This field reveals the intent of the message. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
            Sample = @"",
        };

        

        

        

        return actionCode;
    } 
}
internal HL7V24Field pathwayID;

public HL7V24Field PathwayID
{
    get
    {
        if (pathwayID != null)
        {
            return pathwayID;
        }

        pathwayID = new HL7V24Field
        {
            field = message[@"PTH"][2],
            Id = @"PTH.2",
            Type = @"Field",
            Position = @"PTH.2",
            Name = @"Pathway ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the pathway master data identifier associated with the referenced problem or goal. Examples; open heart pathway, new diabetic, total hip replace.",
            Sample = @"",
        };

        

        

        

        return pathwayID;
    } 
}
internal HL7V24Field pathwayInstanceID;

public HL7V24Field PathwayInstanceID
{
    get
    {
        if (pathwayInstanceID != null)
        {
            return pathwayInstanceID;
        }

        pathwayInstanceID = new HL7V24Field
        {
            field = message[@"PTH"][3],
            Id = @"PTH.3",
            Type = @"Field",
            Position = @"PTH.3",
            Name = @"Pathway Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a value generated by the originating application that represents an associated order placer group number, or other unique identifier assigned to the grouping of pathway directives.",
            Sample = @"",
        };

        

        

        

        return pathwayInstanceID;
    } 
}
internal HL7V24Field pathwayEstablishedDateTime;

public HL7V24Field PathwayEstablishedDateTime
{
    get
    {
        if (pathwayEstablishedDateTime != null)
        {
            return pathwayEstablishedDateTime;
        }

        pathwayEstablishedDateTime = new HL7V24Field
        {
            field = message[@"PTH"][4],
            Id = @"PTH.4",
            Type = @"Field",
            Position = @"PTH.4",
            Name = @"Pathway Established Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identification of the event time for the current pathway record.",
            Sample = @"",
        };

        

        

        

        return pathwayEstablishedDateTime;
    } 
}
internal HL7V24Field pathwayLifeCycleStatus;

public HL7V24Field PathwayLifeCycleStatus
{
    get
    {
        if (pathwayLifeCycleStatus != null)
        {
            return pathwayLifeCycleStatus;
        }

        pathwayLifeCycleStatus = new HL7V24Field
        {
            field = message[@"PTH"][5],
            Id = @"PTH.5",
            Type = @"Field",
            Position = @"PTH.5",
            Name = @"Pathway Life Cycle Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an application-specific set of state identifiers (e.g., Active, Suspended, Complete, Canceled, Delayed, Scheduled).",
            Sample = @"",
        };

        

        

        

        return pathwayLifeCycleStatus;
    } 
}
internal HL7V24Field changePathwayLifeCycleStatusDateTime;

public HL7V24Field ChangePathwayLifeCycleStatusDateTime
{
    get
    {
        if (changePathwayLifeCycleStatusDateTime != null)
        {
            return changePathwayLifeCycleStatusDateTime;
        }

        changePathwayLifeCycleStatusDateTime = new HL7V24Field
        {
            field = message[@"PTH"][6],
            Id = @"PTH.6",
            Type = @"Field",
            Position = @"PTH.6",
            Name = @"Change Pathway Life Cycle Status Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when pathway has been modified or deactivated. (Marked as conditional - must be filled in if trigger event is update or terminate pathway)",
            Sample = @"",
        };

        

        

        

        return changePathwayLifeCycleStatusDateTime;
    } 
}

    }
}
