using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentRQD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RQD"; } }

        public string SegmentId { get { return @"RQD"; } }
        
        public string LongName { get { return @"Requisition Detail"; } }
        
        public string Description { get { return @"RQD contains the detail for each requisitioned item."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Id = @"RQD.1",
                            Type = @"Field",
                            Position = @"RQD.1",
                            Name = @"Requisition Line Number",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this line in the requisition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.2",
                            Type = @"Field",
                            Position = @"RQD.2",
                            Name = @"Item Code - Internal",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier and description that uniquely identify the item on the application sending the requisition. This field is conditional because at least one of the three fields RQD-2-item code- internal, RQD-3-item code-external, or RQD-4-hospital item code must be valued.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RQD.2.1",
                            Type = @"Component",
                            Position = @"RQD.2.1",
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
                            Id = @"RQD.2.2",
                            Type = @"Component",
                            Position = @"RQD.2.2",
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
                            Id = @"RQD.2.3",
                            Type = @"Component",
                            Position = @"RQD.2.3",
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
                            Id = @"RQD.2.4",
                            Type = @"Component",
                            Position = @"RQD.2.4",
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
                            Id = @"RQD.2.5",
                            Type = @"Component",
                            Position = @"RQD.2.5",
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
                            Id = @"RQD.2.6",
                            Type = @"Component",
                            Position = @"RQD.2.6",
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
                            Id = @"RQD.3",
                            Type = @"Field",
                            Position = @"RQD.3",
                            Name = @"Item Code - External",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier and description that uniquely identify the item on the application receiving the requisition. This field is conditional because at least one of the three fields -- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code -- must be valued.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RQD.3.1",
                            Type = @"Component",
                            Position = @"RQD.3.1",
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
                            Id = @"RQD.3.2",
                            Type = @"Component",
                            Position = @"RQD.3.2",
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
                            Id = @"RQD.3.3",
                            Type = @"Component",
                            Position = @"RQD.3.3",
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
                            Id = @"RQD.3.4",
                            Type = @"Component",
                            Position = @"RQD.3.4",
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
                            Id = @"RQD.3.5",
                            Type = @"Component",
                            Position = @"RQD.3.5",
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
                            Id = @"RQD.3.6",
                            Type = @"Component",
                            Position = @"RQD.3.6",
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
                            Id = @"RQD.4",
                            Type = @"Field",
                            Position = @"RQD.4",
                            Name = @"Hospital Item Code",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier and description that uniquely identify the item on all applications in the hospital. The identifier is usually controlled by the hospital financial application in the charge description master file. This field is conditional because at least one of the three fields-- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code-- must be valued.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RQD.4.1",
                            Type = @"Component",
                            Position = @"RQD.4.1",
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
                            Id = @"RQD.4.2",
                            Type = @"Component",
                            Position = @"RQD.4.2",
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
                            Id = @"RQD.4.3",
                            Type = @"Component",
                            Position = @"RQD.4.3",
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
                            Id = @"RQD.4.4",
                            Type = @"Component",
                            Position = @"RQD.4.4",
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
                            Id = @"RQD.4.5",
                            Type = @"Component",
                            Position = @"RQD.4.5",
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
                            Id = @"RQD.4.6",
                            Type = @"Component",
                            Position = @"RQD.4.6",
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
                            Id = @"RQD.5",
                            Type = @"Field",
                            Position = @"RQD.5",
                            Name = @"Requisition Quantity",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity requisitioned for this item.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.6",
                            Type = @"Field",
                            Position = @"RQD.6",
                            Name = @"Requisition Unit of Measure",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the unit of measure for this item.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RQD.6.1",
                            Type = @"Component",
                            Position = @"RQD.6.1",
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
                            Id = @"RQD.6.2",
                            Type = @"Component",
                            Position = @"RQD.6.2",
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
                            Id = @"RQD.6.3",
                            Type = @"Component",
                            Position = @"RQD.6.3",
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
                            Id = @"RQD.6.4",
                            Type = @"Component",
                            Position = @"RQD.6.4",
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
                            Id = @"RQD.6.5",
                            Type = @"Component",
                            Position = @"RQD.6.5",
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
                            Id = @"RQD.6.6",
                            Type = @"Component",
                            Position = @"RQD.6.6",
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
                            Id = @"RQD.7",
                            Type = @"Field",
                            Position = @"RQD.7",
                            Name = @"Dept. Cost Center",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0319",
                            TableName = @"Department Cost Center",
                            Description = @"This field contains the accounting code that identifies this department in order to charge for this item . User-Defined Table 0319 - Department Cost Center is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.8",
                            Type = @"Field",
                            Position = @"RQD.8",
                            Name = @"Item Natural Account Code",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0320",
                            TableName = @"Item Natural Account Code",
                            Description = @"This field contains the accounting code that identifies this item in order to charge for this item. User-Defined Table 0320 - Item Natural Account Code is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQD.9",
                            Type = @"Field",
                            Position = @"RQD.9",
                            Name = @"Deliver To ID",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the unique identifier and descriptive name of the department/location where the item should be delivered.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RQD.9.1",
                            Type = @"Component",
                            Position = @"RQD.9.1",
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
                            Id = @"RQD.9.2",
                            Type = @"Component",
                            Position = @"RQD.9.2",
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
                            Id = @"RQD.9.3",
                            Type = @"Component",
                            Position = @"RQD.9.3",
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
                            Id = @"RQD.9.4",
                            Type = @"Component",
                            Position = @"RQD.9.4",
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
                            Id = @"RQD.9.5",
                            Type = @"Component",
                            Position = @"RQD.9.5",
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
                            Id = @"RQD.9.6",
                            Type = @"Component",
                            Position = @"RQD.9.6",
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
                            Id = @"RQD.10",
                            Type = @"Field",
                            Position = @"RQD.10",
                            Name = @"Date Needed",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date this item is required.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V25SegmentRQD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field requisitionLineNumber;

public HL7V25Field RequisitionLineNumber
{
    get
    {
        if (requisitionLineNumber != null)
        {
            return requisitionLineNumber;
        }

        requisitionLineNumber = new HL7V25Field
        {
            field = message[@"RQD"][1],
            Id = @"RQD.1",
            Type = @"Field",
            Position = @"RQD.1",
            Name = @"Requisition Line Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this line in the requisition.",
            Sample = @"",
        };

        // check for repetitions
        if (requisitionLineNumber.field.FieldRepetitions != null && requisitionLineNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requisitionLineNumber.Id));
            requisitionLineNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(requisitionLineNumber, fieldData);
        }

        return requisitionLineNumber;
    } 
}

internal HL7V25Field itemCodeInternal;

public HL7V25Field ItemCodeInternal
{
    get
    {
        if (itemCodeInternal != null)
        {
            return itemCodeInternal;
        }

        itemCodeInternal = new HL7V25Field
        {
            field = message[@"RQD"][2],
            Id = @"RQD.2",
            Type = @"Field",
            Position = @"RQD.2",
            Name = @"Item Code - Internal",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier and description that uniquely identify the item on the application sending the requisition. This field is conditional because at least one of the three fields RQD-2-item code- internal, RQD-3-item code-external, or RQD-4-hospital item code must be valued.",
            Sample = @"",
        };

        // check for repetitions
        if (itemCodeInternal.field.FieldRepetitions != null && itemCodeInternal.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(itemCodeInternal.Id));
            itemCodeInternal.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(itemCodeInternal, fieldData);
        }

        return itemCodeInternal;
    } 
}

internal HL7V25Field itemCodeExternal;

public HL7V25Field ItemCodeExternal
{
    get
    {
        if (itemCodeExternal != null)
        {
            return itemCodeExternal;
        }

        itemCodeExternal = new HL7V25Field
        {
            field = message[@"RQD"][3],
            Id = @"RQD.3",
            Type = @"Field",
            Position = @"RQD.3",
            Name = @"Item Code - External",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier and description that uniquely identify the item on the application receiving the requisition. This field is conditional because at least one of the three fields -- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code -- must be valued.",
            Sample = @"",
        };

        // check for repetitions
        if (itemCodeExternal.field.FieldRepetitions != null && itemCodeExternal.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(itemCodeExternal.Id));
            itemCodeExternal.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(itemCodeExternal, fieldData);
        }

        return itemCodeExternal;
    } 
}

internal HL7V25Field hospitalItemCode;

public HL7V25Field HospitalItemCode
{
    get
    {
        if (hospitalItemCode != null)
        {
            return hospitalItemCode;
        }

        hospitalItemCode = new HL7V25Field
        {
            field = message[@"RQD"][4],
            Id = @"RQD.4",
            Type = @"Field",
            Position = @"RQD.4",
            Name = @"Hospital Item Code",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier and description that uniquely identify the item on all applications in the hospital. The identifier is usually controlled by the hospital financial application in the charge description master file. This field is conditional because at least one of the three fields-- RQD-2-item code-internal, RQD-3-item code-external or RQD-4-hospital item code-- must be valued.",
            Sample = @"",
        };

        // check for repetitions
        if (hospitalItemCode.field.FieldRepetitions != null && hospitalItemCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(hospitalItemCode.Id));
            hospitalItemCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(hospitalItemCode, fieldData);
        }

        return hospitalItemCode;
    } 
}

internal HL7V25Field requisitionQuantity;

public HL7V25Field RequisitionQuantity
{
    get
    {
        if (requisitionQuantity != null)
        {
            return requisitionQuantity;
        }

        requisitionQuantity = new HL7V25Field
        {
            field = message[@"RQD"][5],
            Id = @"RQD.5",
            Type = @"Field",
            Position = @"RQD.5",
            Name = @"Requisition Quantity",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity requisitioned for this item.",
            Sample = @"",
        };

        // check for repetitions
        if (requisitionQuantity.field.FieldRepetitions != null && requisitionQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requisitionQuantity.Id));
            requisitionQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(requisitionQuantity, fieldData);
        }

        return requisitionQuantity;
    } 
}

internal HL7V25Field requisitionUnitofMeasure;

public HL7V25Field RequisitionUnitofMeasure
{
    get
    {
        if (requisitionUnitofMeasure != null)
        {
            return requisitionUnitofMeasure;
        }

        requisitionUnitofMeasure = new HL7V25Field
        {
            field = message[@"RQD"][6],
            Id = @"RQD.6",
            Type = @"Field",
            Position = @"RQD.6",
            Name = @"Requisition Unit of Measure",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unit of measure for this item.",
            Sample = @"",
        };

        // check for repetitions
        if (requisitionUnitofMeasure.field.FieldRepetitions != null && requisitionUnitofMeasure.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requisitionUnitofMeasure.Id));
            requisitionUnitofMeasure.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(requisitionUnitofMeasure, fieldData);
        }

        return requisitionUnitofMeasure;
    } 
}

internal HL7V25Field deptCostCenter;

public HL7V25Field DeptCostCenter
{
    get
    {
        if (deptCostCenter != null)
        {
            return deptCostCenter;
        }

        deptCostCenter = new HL7V25Field
        {
            field = message[@"RQD"][7],
            Id = @"RQD.7",
            Type = @"Field",
            Position = @"RQD.7",
            Name = @"Dept. Cost Center",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0319",
            TableName = @"Department Cost Center",
            Description = @"This field contains the accounting code that identifies this department in order to charge for this item . User-Defined Table 0319 - Department Cost Center is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        // check for repetitions
        if (deptCostCenter.field.FieldRepetitions != null && deptCostCenter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deptCostCenter.Id));
            deptCostCenter.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(deptCostCenter, fieldData);
        }

        return deptCostCenter;
    } 
}

internal HL7V25Field itemNaturalAccountCode;

public HL7V25Field ItemNaturalAccountCode
{
    get
    {
        if (itemNaturalAccountCode != null)
        {
            return itemNaturalAccountCode;
        }

        itemNaturalAccountCode = new HL7V25Field
        {
            field = message[@"RQD"][8],
            Id = @"RQD.8",
            Type = @"Field",
            Position = @"RQD.8",
            Name = @"Item Natural Account Code",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0320",
            TableName = @"Item Natural Account Code",
            Description = @"This field contains the accounting code that identifies this item in order to charge for this item. User-Defined Table 0320 - Item Natural Account Code is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        // check for repetitions
        if (itemNaturalAccountCode.field.FieldRepetitions != null && itemNaturalAccountCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(itemNaturalAccountCode.Id));
            itemNaturalAccountCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(itemNaturalAccountCode, fieldData);
        }

        return itemNaturalAccountCode;
    } 
}

internal HL7V25Field deliverToID;

public HL7V25Field DeliverToID
{
    get
    {
        if (deliverToID != null)
        {
            return deliverToID;
        }

        deliverToID = new HL7V25Field
        {
            field = message[@"RQD"][9],
            Id = @"RQD.9",
            Type = @"Field",
            Position = @"RQD.9",
            Name = @"Deliver To ID",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique identifier and descriptive name of the department/location where the item should be delivered.",
            Sample = @"",
        };

        // check for repetitions
        if (deliverToID.field.FieldRepetitions != null && deliverToID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deliverToID.Id));
            deliverToID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(deliverToID, fieldData);
        }

        return deliverToID;
    } 
}

internal HL7V25Field dateNeeded;

public HL7V25Field DateNeeded
{
    get
    {
        if (dateNeeded != null)
        {
            return dateNeeded;
        }

        dateNeeded = new HL7V25Field
        {
            field = message[@"RQD"][10],
            Id = @"RQD.10",
            Type = @"Field",
            Position = @"RQD.10",
            Name = @"Date Needed",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date this item is required.",
            Sample = @"",
        };

        // check for repetitions
        if (dateNeeded.field.FieldRepetitions != null && dateNeeded.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateNeeded.Id));
            dateNeeded.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(dateNeeded, fieldData);
        }

        return dateNeeded;
    } 
}
    }
}
