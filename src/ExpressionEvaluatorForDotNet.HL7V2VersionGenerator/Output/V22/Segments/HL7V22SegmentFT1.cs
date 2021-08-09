using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentFT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FT1"; } }

        public string SegmentId { get { return @"FT1"; } }
        
        public string LongName { get { return @"Financial Transaction"; } }
        
        public string Description { get { return @"The FT1 segment contains detail data necessary to post charges, payments, adjustments, etc. to patient accounting records."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Id = @"FT1.1",
                            Type = @"Field",
                            Position = @"FT1.1",
                            Name = @"Set Id - Financial Transaction",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.2",
                            Type = @"Field",
                            Position = @"FT1.2",
                            Name = @"Transaction Id",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"number assigned by the sending system for control purposes.  The number can be returned by the receiving to identify errors",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.3",
                            Type = @"Field",
                            Position = @"FT1.3",
                            Name = @"Transaction Batch Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"uniquely identifies the batch in which this transaction belongs",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.4",
                            Type = @"Field",
                            Position = @"FT1.4",
                            Name = @"Transaction Date",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"uniquely identifies the batch in which this transaction belongs",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.5",
                            Type = @"Field",
                            Position = @"FT1.5",
                            Name = @"Transaction Posting Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"date the transaction was sent to the financial system for posting",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.6",
                            Type = @"Field",
                            Position = @"FT1.6",
                            Name = @"Transaction Type",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0017",
                            TableName = @"TRANSACTION TYPE",
                            Description = @"code that identifies the type of transaction. e.g., charge, credit, payment, etc. Refer to user-defined table 0017 - transaction type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.7",
                            Type = @"Field",
                            Position = @"FT1.7",
                            Name = @"Transaction Code",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0132",
                            TableName = @"TRANSACTION CODE",
                            Description = @"code assigned by the institution for the purpose of uniquely identifying the transaction. For example, this field would be used to uniquely identify a procedure, item, or test for charging purposes.  Refer to user-defined table 0132 - transaction code.  See Chapter 7 for discussion on the univeral service ID",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.7.1",
                            Type = @"Component",
                            Position = @"FT1.7.1",
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
                            Id = @"FT1.7.2",
                            Type = @"Component",
                            Position = @"FT1.7.2",
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
                            Id = @"FT1.7.3",
                            Type = @"Component",
                            Position = @"FT1.7.3",
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
                            Id = @"FT1.7.4",
                            Type = @"Component",
                            Position = @"FT1.7.4",
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
                            Id = @"FT1.7.5",
                            Type = @"Component",
                            Position = @"FT1.7.5",
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
                            Id = @"FT1.7.6",
                            Type = @"Component",
                            Position = @"FT1.7.6",
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
                            Id = @"FT1.8",
                            Type = @"Field",
                            Position = @"FT1.8",
                            Name = @"Transaction Description",
                            Length = 40,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"description of the transaction associated with the code entered in FT1-7-transaction code.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.9",
                            Type = @"Field",
                            Position = @"FT1.9",
                            Name = @"Transaction Description - Alternate",
                            Length = 40,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"alternate financial transaction description to be used on a site specific basis.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.10",
                            Type = @"Field",
                            Position = @"FT1.10",
                            Name = @"Transaction Quantity",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"quantity of items associated with this transaction.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.11",
                            Type = @"Field",
                            Position = @"FT1.11",
                            Name = @"Transaction Amount - Extended",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"amount of transaction.  This field may be blank if the transaction is automatically priced.  Total price for multiple items",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.12",
                            Type = @"Field",
                            Position = @"FT1.12",
                            Name = @"Transaction Amount - Unit",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"unit price of transaction.  Price of a single item",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.13",
                            Type = @"Field",
                            Position = @"FT1.13",
                            Name = @"Department Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0049",
                            TableName = @"DEPARTMENT CODE",
                            Description = @"department code which controls the transaction code described above.  Refer to user-defined table 0049 - department code",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.13.1",
                            Type = @"Component",
                            Position = @"FT1.13.1",
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
                            Id = @"FT1.13.2",
                            Type = @"Component",
                            Position = @"FT1.13.2",
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
                            Id = @"FT1.13.3",
                            Type = @"Component",
                            Position = @"FT1.13.3",
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
                            Id = @"FT1.13.4",
                            Type = @"Component",
                            Position = @"FT1.13.4",
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
                            Id = @"FT1.13.5",
                            Type = @"Component",
                            Position = @"FT1.13.5",
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
                            Id = @"FT1.13.6",
                            Type = @"Component",
                            Position = @"FT1.13.6",
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
                            Id = @"FT1.14",
                            Type = @"Field",
                            Position = @"FT1.14",
                            Name = @"Insurance Plan Id",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0072",
                            TableName = @"INS. PLAN ID",
                            Description = @"ID of the primary insurance plan this transaction should be associated with.  Refer to user-defined table 0072 - insurance plan ID",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.15",
                            Type = @"Field",
                            Position = @"FT1.15",
                            Name = @"Insurance Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"amount to be posted to the insurance plan referenced above",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.16",
                            Type = @"Field",
                            Position = @"FT1.16",
                            Name = @"Assigned Patient Location",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_INTERNAL_LOCATION",
                            DataTypeName = @"Cm For Location Information In Hospital",
                            TableId = @"0079",
                            TableName = @"LOCATION",
                            Description = @"current patient location.  Refer to user-defined table 0079-location",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.16.1",
                            Type = @"Component",
                            Position = @"FT1.16.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"FT1.16.2",
                            Type = @"Component",
                            Position = @"FT1.16.2",
                            Name = @"Room",
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
                            Id = @"FT1.16.3",
                            Type = @"Component",
                            Position = @"FT1.16.3",
                            Name = @"Bed",
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
                            Id = @"FT1.16.4",
                            Type = @"Component",
                            Position = @"FT1.16.4",
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
                            Id = @"FT1.16.5",
                            Type = @"Component",
                            Position = @"FT1.16.5",
                            Name = @"Bed Status",
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
                            Id = @"FT1.17",
                            Type = @"Field",
                            Position = @"FT1.17",
                            Name = @"Fee Schedule",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0024",
                            TableName = @"FEE SCHEDULE",
                            Description = @"code used to select the appropriate fee schedule to be used for this transaction posting. Refer to userdefined table 0024 - fee schedule",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.18",
                            Type = @"Field",
                            Position = @"FT1.18",
                            Name = @"Patient Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0018",
                            TableName = @"PATIENT TYPE",
                            Description = @"type code assigned to the patient for this visit.  Refer to user-defined table 0018 - patient type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.19",
                            Type = @"Field",
                            Position = @"FT1.19",
                            Name = @"Diagnosis Code",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0051",
                            TableName = @"DIAGNOSIS CODE",
                            Description = @" ICD9-CM is assumed for all diagnosis codes.  This diagnosis code is the most current diagnosis code assigned to the patient.  ICD10 can also be used.  Refer to user-defined table 0051 - diagnosis code",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.19.1",
                            Type = @"Component",
                            Position = @"FT1.19.1",
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
                            Id = @"FT1.19.2",
                            Type = @"Component",
                            Position = @"FT1.19.2",
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
                            Id = @"FT1.19.3",
                            Type = @"Component",
                            Position = @"FT1.19.3",
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
                            Id = @"FT1.19.4",
                            Type = @"Component",
                            Position = @"FT1.19.4",
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
                            Id = @"FT1.19.5",
                            Type = @"Component",
                            Position = @"FT1.19.5",
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
                            Id = @"FT1.19.6",
                            Type = @"Component",
                            Position = @"FT1.19.6",
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
                            Id = @"FT1.20",
                            Type = @"Field",
                            Position = @"FT1.20",
                            Name = @"Performed By Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = @"0084",
                            TableName = @"PERFORMED BY CODE",
                            Description = @"composite number/name of the person/group which performed the test/procedure/transaction, etc. Refer to user defined table 0084 - performed by table",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.20.1",
                            Type = @"Component",
                            Position = @"FT1.20.1",
                            Name = @"Id Number",
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
                            Id = @"FT1.20.2",
                            Type = @"Component",
                            Position = @"FT1.20.2",
                            Name = @"Familiy Name",
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
                            Id = @"FT1.20.3",
                            Type = @"Component",
                            Position = @"FT1.20.3",
                            Name = @"Given Name",
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
                            Id = @"FT1.20.4",
                            Type = @"Component",
                            Position = @"FT1.20.4",
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
                            Id = @"FT1.20.5",
                            Type = @"Component",
                            Position = @"FT1.20.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"FT1.20.6",
                            Type = @"Component",
                            Position = @"FT1.20.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"FT1.20.7",
                            Type = @"Component",
                            Position = @"FT1.20.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"FT1.20.8",
                            Type = @"Component",
                            Position = @"FT1.20.8",
                            Name = @"Source Table Id",
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
                            Id = @"FT1.21",
                            Type = @"Field",
                            Position = @"FT1.21",
                            Name = @"Ordered By Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"composite number/name of person/group which ordered the test/procedure/transaction, etc",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.21.1",
                            Type = @"Component",
                            Position = @"FT1.21.1",
                            Name = @"Id Number",
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
                            Id = @"FT1.21.2",
                            Type = @"Component",
                            Position = @"FT1.21.2",
                            Name = @"Familiy Name",
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
                            Id = @"FT1.21.3",
                            Type = @"Component",
                            Position = @"FT1.21.3",
                            Name = @"Given Name",
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
                            Id = @"FT1.21.4",
                            Type = @"Component",
                            Position = @"FT1.21.4",
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
                            Id = @"FT1.21.5",
                            Type = @"Component",
                            Position = @"FT1.21.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"FT1.21.6",
                            Type = @"Component",
                            Position = @"FT1.21.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"FT1.21.7",
                            Type = @"Component",
                            Position = @"FT1.21.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"FT1.21.8",
                            Type = @"Component",
                            Position = @"FT1.21.8",
                            Name = @"Source Table Id",
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
                            Id = @"FT1.22",
                            Type = @"Field",
                            Position = @"FT1.22",
                            Name = @"Unit Cost",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"unit price of transaction.  The cost of a single item",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.23",
                            Type = @"Field",
                            Position = @"FT1.23",
                            Name = @"Filler Order Number",
                            Length = 75,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CM_FILLER",
                            DataTypeName = @"Number Of Processing Power Point",
                            TableId = null,
                            TableName = null,
                            Description = @"used when the billing system is requesting observational reporting justification for a charge.  This is the number used by a filler to uniquely identify a result. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FT1.23.1",
                            Type = @"Component",
                            Position = @"FT1.23.1",
                            Name = @"Unique Filler Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Its first component is a string of up to 15 characters that identifies an order detail segment (e.g., OBR). It is assigned by the order filler (receiving) application. This string must uniquely identify the order (as specified in the order detail segment) from other orders in a particular filling application (e.g., clinical laboratory).  This uniqueness must persist over time. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FT1.23.2",
                            Type = @"Component",
                            Position = @"FT1.23.2",
                            Name = @"Filler Application Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the filler application ID.  The filler application ID is a string of up to six characters that uniquely defines the application from other applications on the network.  The second component of the filler order number always identifies the actual filler of an order. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentFT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdFinancialTransaction;

public HL7V22Field SetIdFinancialTransaction
{
    get
    {
        if (setIdFinancialTransaction != null)
        {
            return setIdFinancialTransaction;
        }

        setIdFinancialTransaction = new HL7V22Field
        {
            field = message[@"FT1"][1],
            Id = @"FT1.1",
            Type = @"Field",
            Position = @"FT1.1",
            Name = @"Set Id - Financial Transaction",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction",
            Sample = @"",
        };

        // check for repetitions
        if (setIdFinancialTransaction.field.FieldRepetitions != null && setIdFinancialTransaction.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdFinancialTransaction.Id));
            setIdFinancialTransaction.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(setIdFinancialTransaction, fieldData);
        }

        return setIdFinancialTransaction;
    } 
}

internal HL7V22Field transactionId;

public HL7V22Field TransactionId
{
    get
    {
        if (transactionId != null)
        {
            return transactionId;
        }

        transactionId = new HL7V22Field
        {
            field = message[@"FT1"][2],
            Id = @"FT1.2",
            Type = @"Field",
            Position = @"FT1.2",
            Name = @"Transaction Id",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"number assigned by the sending system for control purposes.  The number can be returned by the receiving to identify errors",
            Sample = @"",
        };

        // check for repetitions
        if (transactionId.field.FieldRepetitions != null && transactionId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionId.Id));
            transactionId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionId, fieldData);
        }

        return transactionId;
    } 
}

internal HL7V22Field transactionBatchId;

public HL7V22Field TransactionBatchId
{
    get
    {
        if (transactionBatchId != null)
        {
            return transactionBatchId;
        }

        transactionBatchId = new HL7V22Field
        {
            field = message[@"FT1"][3],
            Id = @"FT1.3",
            Type = @"Field",
            Position = @"FT1.3",
            Name = @"Transaction Batch Id",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the batch in which this transaction belongs",
            Sample = @"",
        };

        // check for repetitions
        if (transactionBatchId.field.FieldRepetitions != null && transactionBatchId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionBatchId.Id));
            transactionBatchId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionBatchId, fieldData);
        }

        return transactionBatchId;
    } 
}

internal HL7V22Field transactionDate;

public HL7V22Field TransactionDate
{
    get
    {
        if (transactionDate != null)
        {
            return transactionDate;
        }

        transactionDate = new HL7V22Field
        {
            field = message[@"FT1"][4],
            Id = @"FT1.4",
            Type = @"Field",
            Position = @"FT1.4",
            Name = @"Transaction Date",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the batch in which this transaction belongs",
            Sample = @"",
        };

        // check for repetitions
        if (transactionDate.field.FieldRepetitions != null && transactionDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionDate.Id));
            transactionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionDate, fieldData);
        }

        return transactionDate;
    } 
}

internal HL7V22Field transactionPostingDate;

public HL7V22Field TransactionPostingDate
{
    get
    {
        if (transactionPostingDate != null)
        {
            return transactionPostingDate;
        }

        transactionPostingDate = new HL7V22Field
        {
            field = message[@"FT1"][5],
            Id = @"FT1.5",
            Type = @"Field",
            Position = @"FT1.5",
            Name = @"Transaction Posting Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date the transaction was sent to the financial system for posting",
            Sample = @"",
        };

        // check for repetitions
        if (transactionPostingDate.field.FieldRepetitions != null && transactionPostingDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionPostingDate.Id));
            transactionPostingDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionPostingDate, fieldData);
        }

        return transactionPostingDate;
    } 
}

internal HL7V22Field transactionType;

public HL7V22Field TransactionType
{
    get
    {
        if (transactionType != null)
        {
            return transactionType;
        }

        transactionType = new HL7V22Field
        {
            field = message[@"FT1"][6],
            Id = @"FT1.6",
            Type = @"Field",
            Position = @"FT1.6",
            Name = @"Transaction Type",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0017",
            TableName = @"TRANSACTION TYPE",
            Description = @"code that identifies the type of transaction. e.g., charge, credit, payment, etc. Refer to user-defined table 0017 - transaction type",
            Sample = @"",
        };

        // check for repetitions
        if (transactionType.field.FieldRepetitions != null && transactionType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionType.Id));
            transactionType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionType, fieldData);
        }

        return transactionType;
    } 
}

internal HL7V22Field transactionCode;

public HL7V22Field TransactionCode
{
    get
    {
        if (transactionCode != null)
        {
            return transactionCode;
        }

        transactionCode = new HL7V22Field
        {
            field = message[@"FT1"][7],
            Id = @"FT1.7",
            Type = @"Field",
            Position = @"FT1.7",
            Name = @"Transaction Code",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0132",
            TableName = @"TRANSACTION CODE",
            Description = @"code assigned by the institution for the purpose of uniquely identifying the transaction. For example, this field would be used to uniquely identify a procedure, item, or test for charging purposes.  Refer to user-defined table 0132 - transaction code.  See Chapter 7 for discussion on the univeral service ID",
            Sample = @"",
        };

        // check for repetitions
        if (transactionCode.field.FieldRepetitions != null && transactionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionCode.Id));
            transactionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionCode, fieldData);
        }

        return transactionCode;
    } 
}

internal HL7V22Field transactionDescription;

public HL7V22Field TransactionDescription
{
    get
    {
        if (transactionDescription != null)
        {
            return transactionDescription;
        }

        transactionDescription = new HL7V22Field
        {
            field = message[@"FT1"][8],
            Id = @"FT1.8",
            Type = @"Field",
            Position = @"FT1.8",
            Name = @"Transaction Description",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"description of the transaction associated with the code entered in FT1-7-transaction code.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility",
            Sample = @"",
        };

        // check for repetitions
        if (transactionDescription.field.FieldRepetitions != null && transactionDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionDescription.Id));
            transactionDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionDescription, fieldData);
        }

        return transactionDescription;
    } 
}

internal HL7V22Field transactionDescriptionAlternate;

public HL7V22Field TransactionDescriptionAlternate
{
    get
    {
        if (transactionDescriptionAlternate != null)
        {
            return transactionDescriptionAlternate;
        }

        transactionDescriptionAlternate = new HL7V22Field
        {
            field = message[@"FT1"][9],
            Id = @"FT1.9",
            Type = @"Field",
            Position = @"FT1.9",
            Name = @"Transaction Description - Alternate",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"alternate financial transaction description to be used on a site specific basis.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility",
            Sample = @"",
        };

        // check for repetitions
        if (transactionDescriptionAlternate.field.FieldRepetitions != null && transactionDescriptionAlternate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionDescriptionAlternate.Id));
            transactionDescriptionAlternate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionDescriptionAlternate, fieldData);
        }

        return transactionDescriptionAlternate;
    } 
}

internal HL7V22Field transactionQuantity;

public HL7V22Field TransactionQuantity
{
    get
    {
        if (transactionQuantity != null)
        {
            return transactionQuantity;
        }

        transactionQuantity = new HL7V22Field
        {
            field = message[@"FT1"][10],
            Id = @"FT1.10",
            Type = @"Field",
            Position = @"FT1.10",
            Name = @"Transaction Quantity",
            Length = 4,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"quantity of items associated with this transaction.  This field is no longer needed as it is now part of FT1-7-transaction code.  It has been kept for backwards compatibility.",
            Sample = @"",
        };

        // check for repetitions
        if (transactionQuantity.field.FieldRepetitions != null && transactionQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionQuantity.Id));
            transactionQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionQuantity, fieldData);
        }

        return transactionQuantity;
    } 
}

internal HL7V22Field transactionAmountExtended;

public HL7V22Field TransactionAmountExtended
{
    get
    {
        if (transactionAmountExtended != null)
        {
            return transactionAmountExtended;
        }

        transactionAmountExtended = new HL7V22Field
        {
            field = message[@"FT1"][11],
            Id = @"FT1.11",
            Type = @"Field",
            Position = @"FT1.11",
            Name = @"Transaction Amount - Extended",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount of transaction.  This field may be blank if the transaction is automatically priced.  Total price for multiple items",
            Sample = @"",
        };

        // check for repetitions
        if (transactionAmountExtended.field.FieldRepetitions != null && transactionAmountExtended.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionAmountExtended.Id));
            transactionAmountExtended.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionAmountExtended, fieldData);
        }

        return transactionAmountExtended;
    } 
}

internal HL7V22Field transactionAmountUnit;

public HL7V22Field TransactionAmountUnit
{
    get
    {
        if (transactionAmountUnit != null)
        {
            return transactionAmountUnit;
        }

        transactionAmountUnit = new HL7V22Field
        {
            field = message[@"FT1"][12],
            Id = @"FT1.12",
            Type = @"Field",
            Position = @"FT1.12",
            Name = @"Transaction Amount - Unit",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"unit price of transaction.  Price of a single item",
            Sample = @"",
        };

        // check for repetitions
        if (transactionAmountUnit.field.FieldRepetitions != null && transactionAmountUnit.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(transactionAmountUnit.Id));
            transactionAmountUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(transactionAmountUnit, fieldData);
        }

        return transactionAmountUnit;
    } 
}

internal HL7V22Field departmentCode;

public HL7V22Field DepartmentCode
{
    get
    {
        if (departmentCode != null)
        {
            return departmentCode;
        }

        departmentCode = new HL7V22Field
        {
            field = message[@"FT1"][13],
            Id = @"FT1.13",
            Type = @"Field",
            Position = @"FT1.13",
            Name = @"Department Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0049",
            TableName = @"DEPARTMENT CODE",
            Description = @"department code which controls the transaction code described above.  Refer to user-defined table 0049 - department code",
            Sample = @"",
        };

        // check for repetitions
        if (departmentCode.field.FieldRepetitions != null && departmentCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(departmentCode.Id));
            departmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(departmentCode, fieldData);
        }

        return departmentCode;
    } 
}

internal HL7V22Field insurancePlanId;

public HL7V22Field InsurancePlanId
{
    get
    {
        if (insurancePlanId != null)
        {
            return insurancePlanId;
        }

        insurancePlanId = new HL7V22Field
        {
            field = message[@"FT1"][14],
            Id = @"FT1.14",
            Type = @"Field",
            Position = @"FT1.14",
            Name = @"Insurance Plan Id",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0072",
            TableName = @"INS. PLAN ID",
            Description = @"ID of the primary insurance plan this transaction should be associated with.  Refer to user-defined table 0072 - insurance plan ID",
            Sample = @"",
        };

        // check for repetitions
        if (insurancePlanId.field.FieldRepetitions != null && insurancePlanId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insurancePlanId.Id));
            insurancePlanId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(insurancePlanId, fieldData);
        }

        return insurancePlanId;
    } 
}

internal HL7V22Field insuranceAmount;

public HL7V22Field InsuranceAmount
{
    get
    {
        if (insuranceAmount != null)
        {
            return insuranceAmount;
        }

        insuranceAmount = new HL7V22Field
        {
            field = message[@"FT1"][15],
            Id = @"FT1.15",
            Type = @"Field",
            Position = @"FT1.15",
            Name = @"Insurance Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount to be posted to the insurance plan referenced above",
            Sample = @"",
        };

        // check for repetitions
        if (insuranceAmount.field.FieldRepetitions != null && insuranceAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(insuranceAmount.Id));
            insuranceAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(insuranceAmount, fieldData);
        }

        return insuranceAmount;
    } 
}

internal HL7V22Field assignedPatientLocation;

public HL7V22Field AssignedPatientLocation
{
    get
    {
        if (assignedPatientLocation != null)
        {
            return assignedPatientLocation;
        }

        assignedPatientLocation = new HL7V22Field
        {
            field = message[@"FT1"][16],
            Id = @"FT1.16",
            Type = @"Field",
            Position = @"FT1.16",
            Name = @"Assigned Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = @"current patient location.  Refer to user-defined table 0079-location",
            Sample = @"",
        };

        // check for repetitions
        if (assignedPatientLocation.field.FieldRepetitions != null && assignedPatientLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(assignedPatientLocation.Id));
            assignedPatientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(assignedPatientLocation, fieldData);
        }

        return assignedPatientLocation;
    } 
}

internal HL7V22Field feeSchedule;

public HL7V22Field FeeSchedule
{
    get
    {
        if (feeSchedule != null)
        {
            return feeSchedule;
        }

        feeSchedule = new HL7V22Field
        {
            field = message[@"FT1"][17],
            Id = @"FT1.17",
            Type = @"Field",
            Position = @"FT1.17",
            Name = @"Fee Schedule",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0024",
            TableName = @"FEE SCHEDULE",
            Description = @"code used to select the appropriate fee schedule to be used for this transaction posting. Refer to userdefined table 0024 - fee schedule",
            Sample = @"",
        };

        // check for repetitions
        if (feeSchedule.field.FieldRepetitions != null && feeSchedule.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(feeSchedule.Id));
            feeSchedule.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(feeSchedule, fieldData);
        }

        return feeSchedule;
    } 
}

internal HL7V22Field patientType;

public HL7V22Field PatientType
{
    get
    {
        if (patientType != null)
        {
            return patientType;
        }

        patientType = new HL7V22Field
        {
            field = message[@"FT1"][18],
            Id = @"FT1.18",
            Type = @"Field",
            Position = @"FT1.18",
            Name = @"Patient Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0018",
            TableName = @"PATIENT TYPE",
            Description = @"type code assigned to the patient for this visit.  Refer to user-defined table 0018 - patient type",
            Sample = @"",
        };

        // check for repetitions
        if (patientType.field.FieldRepetitions != null && patientType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientType.Id));
            patientType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(patientType, fieldData);
        }

        return patientType;
    } 
}

internal HL7V22Field diagnosisCode;

public HL7V22Field DiagnosisCode
{
    get
    {
        if (diagnosisCode != null)
        {
            return diagnosisCode;
        }

        diagnosisCode = new HL7V22Field
        {
            field = message[@"FT1"][19],
            Id = @"FT1.19",
            Type = @"Field",
            Position = @"FT1.19",
            Name = @"Diagnosis Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0051",
            TableName = @"DIAGNOSIS CODE",
            Description = @" ICD9-CM is assumed for all diagnosis codes.  This diagnosis code is the most current diagnosis code assigned to the patient.  ICD10 can also be used.  Refer to user-defined table 0051 - diagnosis code",
            Sample = @"",
        };

        // check for repetitions
        if (diagnosisCode.field.FieldRepetitions != null && diagnosisCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisCode.Id));
            diagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(diagnosisCode, fieldData);
        }

        return diagnosisCode;
    } 
}

internal HL7V22Field performedByCode;

public HL7V22Field PerformedByCode
{
    get
    {
        if (performedByCode != null)
        {
            return performedByCode;
        }

        performedByCode = new HL7V22Field
        {
            field = message[@"FT1"][20],
            Id = @"FT1.20",
            Type = @"Field",
            Position = @"FT1.20",
            Name = @"Performed By Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = @"0084",
            TableName = @"PERFORMED BY CODE",
            Description = @"composite number/name of the person/group which performed the test/procedure/transaction, etc. Refer to user defined table 0084 - performed by table",
            Sample = @"",
        };

        // check for repetitions
        if (performedByCode.field.FieldRepetitions != null && performedByCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(performedByCode.Id));
            performedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(performedByCode, fieldData);
        }

        return performedByCode;
    } 
}

internal HL7V22Field orderedByCode;

public HL7V22Field OrderedByCode
{
    get
    {
        if (orderedByCode != null)
        {
            return orderedByCode;
        }

        orderedByCode = new HL7V22Field
        {
            field = message[@"FT1"][21],
            Id = @"FT1.21",
            Type = @"Field",
            Position = @"FT1.21",
            Name = @"Ordered By Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"composite number/name of person/group which ordered the test/procedure/transaction, etc",
            Sample = @"",
        };

        // check for repetitions
        if (orderedByCode.field.FieldRepetitions != null && orderedByCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderedByCode.Id));
            orderedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(orderedByCode, fieldData);
        }

        return orderedByCode;
    } 
}

internal HL7V22Field unitCost;

public HL7V22Field UnitCost
{
    get
    {
        if (unitCost != null)
        {
            return unitCost;
        }

        unitCost = new HL7V22Field
        {
            field = message[@"FT1"][22],
            Id = @"FT1.22",
            Type = @"Field",
            Position = @"FT1.22",
            Name = @"Unit Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"unit price of transaction.  The cost of a single item",
            Sample = @"",
        };

        // check for repetitions
        if (unitCost.field.FieldRepetitions != null && unitCost.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(unitCost.Id));
            unitCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(unitCost, fieldData);
        }

        return unitCost;
    } 
}

internal HL7V22Field fillerOrderNumber;

public HL7V22Field FillerOrderNumber
{
    get
    {
        if (fillerOrderNumber != null)
        {
            return fillerOrderNumber;
        }

        fillerOrderNumber = new HL7V22Field
        {
            field = message[@"FT1"][23],
            Id = @"FT1.23",
            Type = @"Field",
            Position = @"FT1.23",
            Name = @"Filler Order Number",
            Length = 75,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_FILLER",
            DataTypeName = @"Number Of Processing Power Point",
            TableId = null,
            TableName = null,
            Description = @"used when the billing system is requesting observational reporting justification for a charge.  This is the number used by a filler to uniquely identify a result. ",
            Sample = @"",
        };

        // check for repetitions
        if (fillerOrderNumber.field.FieldRepetitions != null && fillerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fillerOrderNumber.Id));
            fillerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(fillerOrderNumber, fieldData);
        }

        return fillerOrderNumber;
    } 
}
    }
}
