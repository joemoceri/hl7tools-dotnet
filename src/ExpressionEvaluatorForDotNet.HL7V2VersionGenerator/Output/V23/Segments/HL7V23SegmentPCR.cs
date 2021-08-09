using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPCR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PCR"; } }

        public string SegmentId { get { return @"PCR"; } }
        
        public string LongName { get { return @"Possible Causal Relationship"; } }
        
        public string Description { get { return @"The PCR segment is used to communicate a potential or suspected relationship between a product (drug or device) or test and an event with detrimental effect on a patient.  This segment identifies a potential causal relationship between the product identified in this segment and the event identified in the PEO segment.

More than one PCR segment can be included in the message if more than one product is possibly causally related to the event. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Id = @"PCR.1",
                            Type = @"Field",
                            Position = @"PCR.1",
                            Name = @"Implicated Product",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the coded identity of the product (drug, device, etc.) which is possibly causally related to the event.  Includes the product identity number such as NDC,  model or catalogue numbers.  If a coded value is not available for the product a text description can be included as the second component of the CE data.  See Chapter 2 for a listing of some recognized coding systems for drugs and devicesé",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.1.1",
                            Type = @"Component",
                            Position = @"PCR.1.1",
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
                            Id = @"PCR.1.2",
                            Type = @"Component",
                            Position = @"PCR.1.2",
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
                            Id = @"PCR.1.3",
                            Type = @"Component",
                            Position = @"PCR.1.3",
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
                            Id = @"PCR.1.4",
                            Type = @"Component",
                            Position = @"PCR.1.4",
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
                            Id = @"PCR.1.5",
                            Type = @"Component",
                            Position = @"PCR.1.5",
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
                            Id = @"PCR.1.6",
                            Type = @"Component",
                            Position = @"PCR.1.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.2",
                            Type = @"Field",
                            Position = @"PCR.2",
                            Name = @"Generic Product",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0249",
                            TableName = @"Generic product",
                            Description = @"This field indicates whether the product used was a generic or a branded product.  Refer to userdefined  table 0239 - Event expected  for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.3",
                            Type = @"Field",
                            Position = @"PCR.3",
                            Name = @"Product Class",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the coded classification of the implicated product. For drugs, this would usually be the drug class - calcium channel blocking agents for nifedipine for example.  For other products it would be the generic type of device, e.g., urinary catheter, cardiac pacemaker.  If a coded value is not available for the class, a text description can be included.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.3.1",
                            Type = @"Component",
                            Position = @"PCR.3.1",
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
                            Id = @"PCR.3.2",
                            Type = @"Component",
                            Position = @"PCR.3.2",
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
                            Id = @"PCR.3.3",
                            Type = @"Component",
                            Position = @"PCR.3.3",
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
                            Id = @"PCR.3.4",
                            Type = @"Component",
                            Position = @"PCR.3.4",
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
                            Id = @"PCR.3.5",
                            Type = @"Component",
                            Position = @"PCR.3.5",
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
                            Id = @"PCR.3.6",
                            Type = @"Component",
                            Position = @"PCR.3.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.4",
                            Type = @"Field",
                            Position = @"PCR.4",
                            Name = @"Total Duration Of Therapy",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field represents the total duration of therapy with product listed.  The treatment at the current dose and schedule are indicted in the quantity timing attribute of the RXE segment but the patient may have been treated for some time previously at a different dose or on a different schedule.  The quantity in the second component of the CQ should be a time quantity.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.4.1",
                            Type = @"Component",
                            Position = @"PCR.4.1",
                            Name = @"Quantity",
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
                            Id = @"PCR.4.2",
                            Type = @"Component",
                            Position = @"PCR.4.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.5",
                            Type = @"Field",
                            Position = @"PCR.5",
                            Name = @"Product Manufacture Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the date the product was manufactured",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.5.1",
                            Type = @"Component",
                            Position = @"PCR.5.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.6",
                            Type = @"Field",
                            Position = @"PCR.6",
                            Name = @"Product Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the expiration date indicated on the product packaging",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.6.1",
                            Type = @"Component",
                            Position = @"PCR.6.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.7",
                            Type = @"Field",
                            Position = @"PCR.7",
                            Name = @"Product Implantation Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If an implantable medical device, this field identifies the date device was implanted",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.7.1",
                            Type = @"Component",
                            Position = @"PCR.7.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.8",
                            Type = @"Field",
                            Position = @"PCR.8",
                            Name = @"Product Explantation Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If an implantable medical device and it was removed, the field identifies the date it was removed",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.8.1",
                            Type = @"Component",
                            Position = @"PCR.8.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.9",
                            Type = @"Field",
                            Position = @"PCR.9",
                            Name = @"Single Use Device",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0244",
                            TableName = @"Single use device",
                            Description = @"This field indicates whether the product was designed for a single use.  Refer to user-defined  table 0239 - Event expected for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.10",
                            Type = @"Field",
                            Position = @"PCR.10",
                            Name = @"Indication For Product Use",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains coded representation of the problem or diagnosis for which the product was used.  See Chapter 2 for some coding systems which might be chosen to transmit diagnoses or problems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.10.1",
                            Type = @"Component",
                            Position = @"PCR.10.1",
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
                            Id = @"PCR.10.2",
                            Type = @"Component",
                            Position = @"PCR.10.2",
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
                            Id = @"PCR.10.3",
                            Type = @"Component",
                            Position = @"PCR.10.3",
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
                            Id = @"PCR.10.4",
                            Type = @"Component",
                            Position = @"PCR.10.4",
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
                            Id = @"PCR.10.5",
                            Type = @"Component",
                            Position = @"PCR.10.5",
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
                            Id = @"PCR.10.6",
                            Type = @"Component",
                            Position = @"PCR.10.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.11",
                            Type = @"Field",
                            Position = @"PCR.11",
                            Name = @"Product Problem",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0245",
                            TableName = @"Product problem",
                            Description = @"A product problem would exist if a product malfunction could lead to death or serious injury.  Refer to user-defined  table 0239 - Event expected for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.12",
                            Type = @"Field",
                            Position = @"PCR.12",
                            Name = @"Product Serial/Lot Number",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is an alphanumeric descriptor which identifies the specific item or lot of drug.  This descriptor would normally be obtained from the package labeling or item itself",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.13",
                            Type = @"Field",
                            Position = @"PCR.13",
                            Name = @"Product Available For Inspection",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0246",
                            TableName = @"Product available for inspection",
                            Description = @"This field indicates that the product is available for analysis.  Refer to user-defined table 0239 Event expected for suggested values.  If the product was returned to the manufacturer, this would be indicated by including the date it was returned in the date product returned to manufacturer element",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.14",
                            Type = @"Field",
                            Position = @"PCR.14",
                            Name = @"Product Evaluation Performed",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the type of product evaluation performed.  The evaluation codes listed in SubPart B of the Coding Manual for FDA Form 3500A, “Type of Evaluation Performed” may be used.  If no codes are available, text may be sent in the second component of the field",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.14.1",
                            Type = @"Component",
                            Position = @"PCR.14.1",
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
                            Id = @"PCR.14.2",
                            Type = @"Component",
                            Position = @"PCR.14.2",
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
                            Id = @"PCR.14.3",
                            Type = @"Component",
                            Position = @"PCR.14.3",
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
                            Id = @"PCR.14.4",
                            Type = @"Component",
                            Position = @"PCR.14.4",
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
                            Id = @"PCR.14.5",
                            Type = @"Component",
                            Position = @"PCR.14.5",
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
                            Id = @"PCR.14.6",
                            Type = @"Component",
                            Position = @"PCR.14.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.15",
                            Type = @"Field",
                            Position = @"PCR.15",
                            Name = @"Product Evaluation Status",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0247",
                            TableName = @"Status of evaluation",
                            Description = @"This field identifies the status of product evaluation.  Subpart A Item H.3 of the Coding Manual for FDA Form 3500A may also be used.  If no codes are available, text may be sent in the second component of the field.  Refer to HL7 table 0247 - Status of evaluation for valid values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.15.1",
                            Type = @"Component",
                            Position = @"PCR.15.1",
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
                            Id = @"PCR.15.2",
                            Type = @"Component",
                            Position = @"PCR.15.2",
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
                            Id = @"PCR.15.3",
                            Type = @"Component",
                            Position = @"PCR.15.3",
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
                            Id = @"PCR.15.4",
                            Type = @"Component",
                            Position = @"PCR.15.4",
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
                            Id = @"PCR.15.5",
                            Type = @"Component",
                            Position = @"PCR.15.5",
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
                            Id = @"PCR.15.6",
                            Type = @"Component",
                            Position = @"PCR.15.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.16",
                            Type = @"Field",
                            Position = @"PCR.16",
                            Name = @"Product Evaluation Results",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the results of the product evaluation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.16.1",
                            Type = @"Component",
                            Position = @"PCR.16.1",
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
                            Id = @"PCR.16.2",
                            Type = @"Component",
                            Position = @"PCR.16.2",
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
                            Id = @"PCR.16.3",
                            Type = @"Component",
                            Position = @"PCR.16.3",
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
                            Id = @"PCR.16.4",
                            Type = @"Component",
                            Position = @"PCR.16.4",
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
                            Id = @"PCR.16.5",
                            Type = @"Component",
                            Position = @"PCR.16.5",
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
                            Id = @"PCR.16.6",
                            Type = @"Component",
                            Position = @"PCR.16.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.17",
                            Type = @"Field",
                            Position = @"PCR.17",
                            Name = @"Evaluated Product Source",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0248",
                            TableName = @"Product source",
                            Description = @"This field contains the source of the product evaluated.  Refer to HL7 table 0248 - Product source for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.18",
                            Type = @"Field",
                            Position = @"PCR.18",
                            Name = @"Date Product Returned To Manufacturer",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"If the product was returned to the manufacturer, this field contains the date it was returned may be reported",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.18.1",
                            Type = @"Component",
                            Position = @"PCR.18.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.19",
                            Type = @"Field",
                            Position = @"PCR.19",
                            Name = @"Device Operator Qualifications",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0242",
                            TableName = @"Primary observer’s qualification",
                            Description = @"This field identifies the qualification of the person operating the device when the event occurred.  Refer to HL7 table 0242 - Primary observers qualification for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.20",
                            Type = @"Field",
                            Position = @"PCR.20",
                            Name = @"Relatedness Assessment",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0250",
                            TableName = @"Relatedness assessment",
                            Description = @"This field represents the assessment of relatedness of the product to the event.  Refer to HL7 table 0250 - Relatedness assessment for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.21",
                            Type = @"Field",
                            Position = @"PCR.21",
                            Name = @"Action Taken In Response To The Event",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"6",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0251",
                            TableName = @"Action taken in response to the event",
                            Description = @"This field indicates the action taken as a result of the event.  Segment may repeat if multiple categories of evidence are relevant.  Refer to HL7 table 0251 - Action taken in response to the event for valid values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.22",
                            Type = @"Field",
                            Position = @"PCR.22",
                            Name = @"Event Causality Observations",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"6",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0252",
                            TableName = @"Causality observations",
                            Description = @"This field contains observations made about the event which may bear on causality.  Refer to HL7 table 0252 - Causality observations for valid values.  Segment may repeat if multiple categories of evidence are relevant",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.23",
                            Type = @"Field",
                            Position = @"PCR.23",
                            Name = @"Indirect Exposure Mechanism",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"3",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0253",
                            TableName = @"Indirect exposure mechanism",
                            Description = @"The patient identified in the PID segment, who experienced the event, might have been exposed to the potential causal product via an intermediary, e.g., a child might be exposed to a product through the placenta or in breast milk, or a transfusion recipient might be exposed via a blood product.  If this is the case, the mechanism of product transmission is identified in this field, using the valid values in HL7 table 0253 - Indirect exposure mechanism.  If this field is populated, the identity of the person through whom the product was transmitted is contained in NK1 and RXE segments which follow",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentPCR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field implicatedProduct;

public HL7V23Field ImplicatedProduct
{
    get
    {
        if (implicatedProduct != null)
        {
            return implicatedProduct;
        }

        implicatedProduct = new HL7V23Field
        {
            field = message[@"PCR"][1],
            Id = @"PCR.1",
            Type = @"Field",
            Position = @"PCR.1",
            Name = @"Implicated Product",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coded identity of the product (drug, device, etc.) which is possibly causally related to the event.  Includes the product identity number such as NDC,  model or catalogue numbers.  If a coded value is not available for the product a text description can be included as the second component of the CE data.  See Chapter 2 for a listing of some recognized coding systems for drugs and devicesé",
            Sample = @"",
        };

        // check for repetitions
        if (implicatedProduct.field.FieldRepetitions != null && implicatedProduct.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(implicatedProduct.Id));
            implicatedProduct.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(implicatedProduct, fieldData);
        }

        return implicatedProduct;
    } 
}

internal HL7V23Field genericProduct;

public HL7V23Field GenericProduct
{
    get
    {
        if (genericProduct != null)
        {
            return genericProduct;
        }

        genericProduct = new HL7V23Field
        {
            field = message[@"PCR"][2],
            Id = @"PCR.2",
            Type = @"Field",
            Position = @"PCR.2",
            Name = @"Generic Product",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0249",
            TableName = @"Generic product",
            Description = @"This field indicates whether the product used was a generic or a branded product.  Refer to userdefined  table 0239 - Event expected  for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (genericProduct.field.FieldRepetitions != null && genericProduct.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(genericProduct.Id));
            genericProduct.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(genericProduct, fieldData);
        }

        return genericProduct;
    } 
}

internal HL7V23Field productClass;

public HL7V23Field ProductClass
{
    get
    {
        if (productClass != null)
        {
            return productClass;
        }

        productClass = new HL7V23Field
        {
            field = message[@"PCR"][3],
            Id = @"PCR.3",
            Type = @"Field",
            Position = @"PCR.3",
            Name = @"Product Class",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coded classification of the implicated product. For drugs, this would usually be the drug class - calcium channel blocking agents for nifedipine for example.  For other products it would be the generic type of device, e.g., urinary catheter, cardiac pacemaker.  If a coded value is not available for the class, a text description can be included.",
            Sample = @"",
        };

        // check for repetitions
        if (productClass.field.FieldRepetitions != null && productClass.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productClass.Id));
            productClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productClass, fieldData);
        }

        return productClass;
    } 
}

internal HL7V23Field totalDurationOfTherapy;

public HL7V23Field TotalDurationOfTherapy
{
    get
    {
        if (totalDurationOfTherapy != null)
        {
            return totalDurationOfTherapy;
        }

        totalDurationOfTherapy = new HL7V23Field
        {
            field = message[@"PCR"][4],
            Id = @"PCR.4",
            Type = @"Field",
            Position = @"PCR.4",
            Name = @"Total Duration Of Therapy",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field represents the total duration of therapy with product listed.  The treatment at the current dose and schedule are indicted in the quantity timing attribute of the RXE segment but the patient may have been treated for some time previously at a different dose or on a different schedule.  The quantity in the second component of the CQ should be a time quantity.",
            Sample = @"",
        };

        // check for repetitions
        if (totalDurationOfTherapy.field.FieldRepetitions != null && totalDurationOfTherapy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(totalDurationOfTherapy.Id));
            totalDurationOfTherapy.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(totalDurationOfTherapy, fieldData);
        }

        return totalDurationOfTherapy;
    } 
}

internal HL7V23Field productManufactureDate;

public HL7V23Field ProductManufactureDate
{
    get
    {
        if (productManufactureDate != null)
        {
            return productManufactureDate;
        }

        productManufactureDate = new HL7V23Field
        {
            field = message[@"PCR"][5],
            Id = @"PCR.5",
            Type = @"Field",
            Position = @"PCR.5",
            Name = @"Product Manufacture Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date the product was manufactured",
            Sample = @"",
        };

        // check for repetitions
        if (productManufactureDate.field.FieldRepetitions != null && productManufactureDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productManufactureDate.Id));
            productManufactureDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productManufactureDate, fieldData);
        }

        return productManufactureDate;
    } 
}

internal HL7V23Field productExpirationDate;

public HL7V23Field ProductExpirationDate
{
    get
    {
        if (productExpirationDate != null)
        {
            return productExpirationDate;
        }

        productExpirationDate = new HL7V23Field
        {
            field = message[@"PCR"][6],
            Id = @"PCR.6",
            Type = @"Field",
            Position = @"PCR.6",
            Name = @"Product Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date indicated on the product packaging",
            Sample = @"",
        };

        // check for repetitions
        if (productExpirationDate.field.FieldRepetitions != null && productExpirationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productExpirationDate.Id));
            productExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productExpirationDate, fieldData);
        }

        return productExpirationDate;
    } 
}

internal HL7V23Field productImplantationDate;

public HL7V23Field ProductImplantationDate
{
    get
    {
        if (productImplantationDate != null)
        {
            return productImplantationDate;
        }

        productImplantationDate = new HL7V23Field
        {
            field = message[@"PCR"][7],
            Id = @"PCR.7",
            Type = @"Field",
            Position = @"PCR.7",
            Name = @"Product Implantation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If an implantable medical device, this field identifies the date device was implanted",
            Sample = @"",
        };

        // check for repetitions
        if (productImplantationDate.field.FieldRepetitions != null && productImplantationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productImplantationDate.Id));
            productImplantationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productImplantationDate, fieldData);
        }

        return productImplantationDate;
    } 
}

internal HL7V23Field productExplantationDate;

public HL7V23Field ProductExplantationDate
{
    get
    {
        if (productExplantationDate != null)
        {
            return productExplantationDate;
        }

        productExplantationDate = new HL7V23Field
        {
            field = message[@"PCR"][8],
            Id = @"PCR.8",
            Type = @"Field",
            Position = @"PCR.8",
            Name = @"Product Explantation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If an implantable medical device and it was removed, the field identifies the date it was removed",
            Sample = @"",
        };

        // check for repetitions
        if (productExplantationDate.field.FieldRepetitions != null && productExplantationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productExplantationDate.Id));
            productExplantationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productExplantationDate, fieldData);
        }

        return productExplantationDate;
    } 
}

internal HL7V23Field singleUseDevice;

public HL7V23Field SingleUseDevice
{
    get
    {
        if (singleUseDevice != null)
        {
            return singleUseDevice;
        }

        singleUseDevice = new HL7V23Field
        {
            field = message[@"PCR"][9],
            Id = @"PCR.9",
            Type = @"Field",
            Position = @"PCR.9",
            Name = @"Single Use Device",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0244",
            TableName = @"Single use device",
            Description = @"This field indicates whether the product was designed for a single use.  Refer to user-defined  table 0239 - Event expected for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (singleUseDevice.field.FieldRepetitions != null && singleUseDevice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(singleUseDevice.Id));
            singleUseDevice.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(singleUseDevice, fieldData);
        }

        return singleUseDevice;
    } 
}

internal HL7V23Field indicationForProductUse;

public HL7V23Field IndicationForProductUse
{
    get
    {
        if (indicationForProductUse != null)
        {
            return indicationForProductUse;
        }

        indicationForProductUse = new HL7V23Field
        {
            field = message[@"PCR"][10],
            Id = @"PCR.10",
            Type = @"Field",
            Position = @"PCR.10",
            Name = @"Indication For Product Use",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains coded representation of the problem or diagnosis for which the product was used.  See Chapter 2 for some coding systems which might be chosen to transmit diagnoses or problems",
            Sample = @"",
        };

        // check for repetitions
        if (indicationForProductUse.field.FieldRepetitions != null && indicationForProductUse.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(indicationForProductUse.Id));
            indicationForProductUse.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(indicationForProductUse, fieldData);
        }

        return indicationForProductUse;
    } 
}

internal HL7V23Field productProblem;

public HL7V23Field ProductProblem
{
    get
    {
        if (productProblem != null)
        {
            return productProblem;
        }

        productProblem = new HL7V23Field
        {
            field = message[@"PCR"][11],
            Id = @"PCR.11",
            Type = @"Field",
            Position = @"PCR.11",
            Name = @"Product Problem",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0245",
            TableName = @"Product problem",
            Description = @"A product problem would exist if a product malfunction could lead to death or serious injury.  Refer to user-defined  table 0239 - Event expected for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (productProblem.field.FieldRepetitions != null && productProblem.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productProblem.Id));
            productProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productProblem, fieldData);
        }

        return productProblem;
    } 
}

internal HL7V23Field productSerialLotNumber;

public HL7V23Field ProductSerialLotNumber
{
    get
    {
        if (productSerialLotNumber != null)
        {
            return productSerialLotNumber;
        }

        productSerialLotNumber = new HL7V23Field
        {
            field = message[@"PCR"][12],
            Id = @"PCR.12",
            Type = @"Field",
            Position = @"PCR.12",
            Name = @"Product Serial/Lot Number",
            Length = 30,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is an alphanumeric descriptor which identifies the specific item or lot of drug.  This descriptor would normally be obtained from the package labeling or item itself",
            Sample = @"",
        };

        // check for repetitions
        if (productSerialLotNumber.field.FieldRepetitions != null && productSerialLotNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productSerialLotNumber.Id));
            productSerialLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productSerialLotNumber, fieldData);
        }

        return productSerialLotNumber;
    } 
}

internal HL7V23Field productAvailableForInspection;

public HL7V23Field ProductAvailableForInspection
{
    get
    {
        if (productAvailableForInspection != null)
        {
            return productAvailableForInspection;
        }

        productAvailableForInspection = new HL7V23Field
        {
            field = message[@"PCR"][13],
            Id = @"PCR.13",
            Type = @"Field",
            Position = @"PCR.13",
            Name = @"Product Available For Inspection",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0246",
            TableName = @"Product available for inspection",
            Description = @"This field indicates that the product is available for analysis.  Refer to user-defined table 0239 Event expected for suggested values.  If the product was returned to the manufacturer, this would be indicated by including the date it was returned in the date product returned to manufacturer element",
            Sample = @"",
        };

        // check for repetitions
        if (productAvailableForInspection.field.FieldRepetitions != null && productAvailableForInspection.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productAvailableForInspection.Id));
            productAvailableForInspection.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productAvailableForInspection, fieldData);
        }

        return productAvailableForInspection;
    } 
}

internal HL7V23Field productEvaluationPerformed;

public HL7V23Field ProductEvaluationPerformed
{
    get
    {
        if (productEvaluationPerformed != null)
        {
            return productEvaluationPerformed;
        }

        productEvaluationPerformed = new HL7V23Field
        {
            field = message[@"PCR"][14],
            Id = @"PCR.14",
            Type = @"Field",
            Position = @"PCR.14",
            Name = @"Product Evaluation Performed",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the type of product evaluation performed.  The evaluation codes listed in SubPart B of the Coding Manual for FDA Form 3500A, “Type of Evaluation Performed” may be used.  If no codes are available, text may be sent in the second component of the field",
            Sample = @"",
        };

        // check for repetitions
        if (productEvaluationPerformed.field.FieldRepetitions != null && productEvaluationPerformed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productEvaluationPerformed.Id));
            productEvaluationPerformed.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productEvaluationPerformed, fieldData);
        }

        return productEvaluationPerformed;
    } 
}

internal HL7V23Field productEvaluationStatus;

public HL7V23Field ProductEvaluationStatus
{
    get
    {
        if (productEvaluationStatus != null)
        {
            return productEvaluationStatus;
        }

        productEvaluationStatus = new HL7V23Field
        {
            field = message[@"PCR"][15],
            Id = @"PCR.15",
            Type = @"Field",
            Position = @"PCR.15",
            Name = @"Product Evaluation Status",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0247",
            TableName = @"Status of evaluation",
            Description = @"This field identifies the status of product evaluation.  Subpart A Item H.3 of the Coding Manual for FDA Form 3500A may also be used.  If no codes are available, text may be sent in the second component of the field.  Refer to HL7 table 0247 - Status of evaluation for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (productEvaluationStatus.field.FieldRepetitions != null && productEvaluationStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productEvaluationStatus.Id));
            productEvaluationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productEvaluationStatus, fieldData);
        }

        return productEvaluationStatus;
    } 
}

internal HL7V23Field productEvaluationResults;

public HL7V23Field ProductEvaluationResults
{
    get
    {
        if (productEvaluationResults != null)
        {
            return productEvaluationResults;
        }

        productEvaluationResults = new HL7V23Field
        {
            field = message[@"PCR"][16],
            Id = @"PCR.16",
            Type = @"Field",
            Position = @"PCR.16",
            Name = @"Product Evaluation Results",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the results of the product evaluation",
            Sample = @"",
        };

        // check for repetitions
        if (productEvaluationResults.field.FieldRepetitions != null && productEvaluationResults.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(productEvaluationResults.Id));
            productEvaluationResults.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(productEvaluationResults, fieldData);
        }

        return productEvaluationResults;
    } 
}

internal HL7V23Field evaluatedProductSource;

public HL7V23Field EvaluatedProductSource
{
    get
    {
        if (evaluatedProductSource != null)
        {
            return evaluatedProductSource;
        }

        evaluatedProductSource = new HL7V23Field
        {
            field = message[@"PCR"][17],
            Id = @"PCR.17",
            Type = @"Field",
            Position = @"PCR.17",
            Name = @"Evaluated Product Source",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0248",
            TableName = @"Product source",
            Description = @"This field contains the source of the product evaluated.  Refer to HL7 table 0248 - Product source for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (evaluatedProductSource.field.FieldRepetitions != null && evaluatedProductSource.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(evaluatedProductSource.Id));
            evaluatedProductSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(evaluatedProductSource, fieldData);
        }

        return evaluatedProductSource;
    } 
}

internal HL7V23Field dateProductReturnedToManufacturer;

public HL7V23Field DateProductReturnedToManufacturer
{
    get
    {
        if (dateProductReturnedToManufacturer != null)
        {
            return dateProductReturnedToManufacturer;
        }

        dateProductReturnedToManufacturer = new HL7V23Field
        {
            field = message[@"PCR"][18],
            Id = @"PCR.18",
            Type = @"Field",
            Position = @"PCR.18",
            Name = @"Date Product Returned To Manufacturer",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If the product was returned to the manufacturer, this field contains the date it was returned may be reported",
            Sample = @"",
        };

        // check for repetitions
        if (dateProductReturnedToManufacturer.field.FieldRepetitions != null && dateProductReturnedToManufacturer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateProductReturnedToManufacturer.Id));
            dateProductReturnedToManufacturer.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(dateProductReturnedToManufacturer, fieldData);
        }

        return dateProductReturnedToManufacturer;
    } 
}

internal HL7V23Field deviceOperatorQualifications;

public HL7V23Field DeviceOperatorQualifications
{
    get
    {
        if (deviceOperatorQualifications != null)
        {
            return deviceOperatorQualifications;
        }

        deviceOperatorQualifications = new HL7V23Field
        {
            field = message[@"PCR"][19],
            Id = @"PCR.19",
            Type = @"Field",
            Position = @"PCR.19",
            Name = @"Device Operator Qualifications",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0242",
            TableName = @"Primary observer’s qualification",
            Description = @"This field identifies the qualification of the person operating the device when the event occurred.  Refer to HL7 table 0242 - Primary observers qualification for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (deviceOperatorQualifications.field.FieldRepetitions != null && deviceOperatorQualifications.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deviceOperatorQualifications.Id));
            deviceOperatorQualifications.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(deviceOperatorQualifications, fieldData);
        }

        return deviceOperatorQualifications;
    } 
}

internal HL7V23Field relatednessAssessment;

public HL7V23Field RelatednessAssessment
{
    get
    {
        if (relatednessAssessment != null)
        {
            return relatednessAssessment;
        }

        relatednessAssessment = new HL7V23Field
        {
            field = message[@"PCR"][20],
            Id = @"PCR.20",
            Type = @"Field",
            Position = @"PCR.20",
            Name = @"Relatedness Assessment",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0250",
            TableName = @"Relatedness assessment",
            Description = @"This field represents the assessment of relatedness of the product to the event.  Refer to HL7 table 0250 - Relatedness assessment for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (relatednessAssessment.field.FieldRepetitions != null && relatednessAssessment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relatednessAssessment.Id));
            relatednessAssessment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(relatednessAssessment, fieldData);
        }

        return relatednessAssessment;
    } 
}

internal HL7V23Field actionTakenInResponseToTheEvent;

public HL7V23Field ActionTakenInResponseToTheEvent
{
    get
    {
        if (actionTakenInResponseToTheEvent != null)
        {
            return actionTakenInResponseToTheEvent;
        }

        actionTakenInResponseToTheEvent = new HL7V23Field
        {
            field = message[@"PCR"][21],
            Id = @"PCR.21",
            Type = @"Field",
            Position = @"PCR.21",
            Name = @"Action Taken In Response To The Event",
            Length = 2,
            Usage = @"O",
            Rpt = @"6",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0251",
            TableName = @"Action taken in response to the event",
            Description = @"This field indicates the action taken as a result of the event.  Segment may repeat if multiple categories of evidence are relevant.  Refer to HL7 table 0251 - Action taken in response to the event for valid values. ",
            Sample = @"",
        };

        // check for repetitions
        if (actionTakenInResponseToTheEvent.field.FieldRepetitions != null && actionTakenInResponseToTheEvent.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(actionTakenInResponseToTheEvent.Id));
            actionTakenInResponseToTheEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(actionTakenInResponseToTheEvent, fieldData);
        }

        return actionTakenInResponseToTheEvent;
    } 
}

internal HL7V23Field eventCausalityObservations;

public HL7V23Field EventCausalityObservations
{
    get
    {
        if (eventCausalityObservations != null)
        {
            return eventCausalityObservations;
        }

        eventCausalityObservations = new HL7V23Field
        {
            field = message[@"PCR"][22],
            Id = @"PCR.22",
            Type = @"Field",
            Position = @"PCR.22",
            Name = @"Event Causality Observations",
            Length = 2,
            Usage = @"O",
            Rpt = @"6",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0252",
            TableName = @"Causality observations",
            Description = @"This field contains observations made about the event which may bear on causality.  Refer to HL7 table 0252 - Causality observations for valid values.  Segment may repeat if multiple categories of evidence are relevant",
            Sample = @"",
        };

        // check for repetitions
        if (eventCausalityObservations.field.FieldRepetitions != null && eventCausalityObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventCausalityObservations.Id));
            eventCausalityObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(eventCausalityObservations, fieldData);
        }

        return eventCausalityObservations;
    } 
}

internal HL7V23Field indirectExposureMechanism;

public HL7V23Field IndirectExposureMechanism
{
    get
    {
        if (indirectExposureMechanism != null)
        {
            return indirectExposureMechanism;
        }

        indirectExposureMechanism = new HL7V23Field
        {
            field = message[@"PCR"][23],
            Id = @"PCR.23",
            Type = @"Field",
            Position = @"PCR.23",
            Name = @"Indirect Exposure Mechanism",
            Length = 1,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0253",
            TableName = @"Indirect exposure mechanism",
            Description = @"The patient identified in the PID segment, who experienced the event, might have been exposed to the potential causal product via an intermediary, e.g., a child might be exposed to a product through the placenta or in breast milk, or a transfusion recipient might be exposed via a blood product.  If this is the case, the mechanism of product transmission is identified in this field, using the valid values in HL7 table 0253 - Indirect exposure mechanism.  If this field is populated, the identity of the person through whom the product was transmitted is contained in NK1 and RXE segments which follow",
            Sample = @"",
        };

        // check for repetitions
        if (indirectExposureMechanism.field.FieldRepetitions != null && indirectExposureMechanism.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(indirectExposureMechanism.Id));
            indirectExposureMechanism.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(indirectExposureMechanism, fieldData);
        }

        return indirectExposureMechanism;
    } 
}
    }
}
