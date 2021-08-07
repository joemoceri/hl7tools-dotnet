using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOM4
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"OM4"; } }

        public string SegmentId { get { return @"OM4"; } }
        
        public string LongName { get { return @"Observation That Require Specimens"; } }
        
        public string Description { get { return @""; } }
        
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
                            Id = @"OM4.1",
                            Type = @"Field",
                            Position = @"OM4.1",
                            Name = @"Segment Type Id",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"this segment applies to observations/batteries that require a specimen for their performance.  When an observation or battery requires multiple specimens for their performance (e.g., creatinine clearance requires a 24-hour urine specimen and a serum specimen), multiple segments may be included, one for each specimen type. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.2",
                            Type = @"Field",
                            Position = @"OM4.2",
                            Name = @"Sequence Number - Test/ Observation Master File",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"the same value as the sequence number of the associated OM1 segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.3",
                            Type = @"Field",
                            Position = @"OM4.3",
                            Name = @"Derived Specimen",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0170",
                            TableName = @"DERIVED SPECIMEN",
                            Description = @"for some diagnostic studies -- especially in microbiology -- the initial specimen (e.g., blood) is processed to produce results (e.g., the identity of the bacteria grown out of the culture).  The process also produces new ""specimens"" (e.g., pure culture of staphylococcus, and E. Coli), and these are studied by a second order process (bacterial sensitivities).  This field contains codes that identify the parents (e.g., blood culture) and children (e.g., penicillin MIC) in such cases.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.4",
                            Type = @"Field",
                            Position = @"OM4.4",
                            Name = @"Container Description",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the physical appearance, including color of tube tops, shape, and material composition (e.g., red-top glass tube).  Note that the color is not necessarily a unique identifier of the additive and/or use of the tube.  This is especially true for black and some blue tube tops, as can be seen above.  Color is included here for user convenience. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.5",
                            Type = @"Field",
                            Position = @"OM4.5",
                            Name = @"Container Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"the capacity of the container",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.6",
                            Type = @"Field",
                            Position = @"OM4.6",
                            Name = @"Container Units",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"reports the units of measure of the container volume.  If the units are ISO+ units, they should be recorded as single case abbreviations.  If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters.  For example, 1 indicates liters, whereas pt&&ANS+ indicates pints (ANSI units).  The default unit is milliliters (ml), which should be assumed if no units are reported",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.6.1",
                            Type = @"Component",
                            Position = @"OM4.6.1",
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
                            Id = @"OM4.6.2",
                            Type = @"Component",
                            Position = @"OM4.6.2",
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
                            Id = @"OM4.6.3",
                            Type = @"Component",
                            Position = @"OM4.6.3",
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
                            Id = @"OM4.6.4",
                            Type = @"Component",
                            Position = @"OM4.6.4",
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
                            Id = @"OM4.6.5",
                            Type = @"Component",
                            Position = @"OM4.6.5",
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
                            Id = @"OM4.6.6",
                            Type = @"Component",
                            Position = @"OM4.6.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7",
                            Type = @"Field",
                            Position = @"OM4.7",
                            Name = @"Specimen",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"the specimen should be reported as one of the specimen codes described in ASTM Table 14 of 1238-91.  If multiple kinds of specimen are associated with this observation (as in the case for a creatinine clearance), separate them with repeat delimiters",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.1",
                            Type = @"Component",
                            Position = @"OM4.7.1",
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
                            Id = @"OM4.7.2",
                            Type = @"Component",
                            Position = @"OM4.7.2",
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
                            Id = @"OM4.7.3",
                            Type = @"Component",
                            Position = @"OM4.7.3",
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
                            Id = @"OM4.7.4",
                            Type = @"Component",
                            Position = @"OM4.7.4",
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
                            Id = @"OM4.7.5",
                            Type = @"Component",
                            Position = @"OM4.7.5",
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
                            Id = @"OM4.7.6",
                            Type = @"Component",
                            Position = @"OM4.7.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.8",
                            Type = @"Field",
                            Position = @"OM4.8",
                            Name = @"Additive",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"codes should be those provided by NCCLS.  The following list is not exhaustive; it includes only examples",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.8.1",
                            Type = @"Component",
                            Position = @"OM4.8.1",
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
                            Id = @"OM4.8.2",
                            Type = @"Component",
                            Position = @"OM4.8.2",
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
                            Id = @"OM4.8.3",
                            Type = @"Component",
                            Position = @"OM4.8.3",
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
                            Id = @"OM4.8.4",
                            Type = @"Component",
                            Position = @"OM4.8.4",
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
                            Id = @"OM4.8.5",
                            Type = @"Component",
                            Position = @"OM4.8.5",
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
                            Id = @"OM4.8.6",
                            Type = @"Component",
                            Position = @"OM4.8.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.9",
                            Type = @"Field",
                            Position = @"OM4.9",
                            Name = @"Preparation",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the special processing that should be applied to the container, e.g., add acidifying tablets before sending",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.10",
                            Type = @"Field",
                            Position = @"OM4.10",
                            Name = @"Special Handling Requirements",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"record special handling requirements here (e.g., ice specimen, deliver within 2 hours of obtaining).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.11",
                            Type = @"Field",
                            Position = @"OM4.11",
                            Name = @"Normal Collection Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"record the normal specimen volume required by the lab.  This is the amount used by the normal methods and provides enough specimens to repeat the procedure at least once if needed.  The default unit is milliliters (ml).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.11.1",
                            Type = @"Component",
                            Position = @"OM4.11.1",
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
                            Id = @"OM4.11.2",
                            Type = @"Component",
                            Position = @"OM4.11.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.12",
                            Type = @"Field",
                            Position = @"OM4.12",
                            Name = @"Minimum Collection Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"the amount of specimen needed by the most specimen sparing method (e.g., using micro techniques).  The minimum amount allows for only one determination.  The default unit is milliliters (ml).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.12.1",
                            Type = @"Component",
                            Position = @"OM4.12.1",
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
                            Id = @"OM4.12.2",
                            Type = @"Component",
                            Position = @"OM4.12.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.13",
                            Type = @"Field",
                            Position = @"OM4.13",
                            Name = @"Specimen Requirements",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"other requirements for specimen delivery and special handling (e.g., delivery within one hour, iced).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.14",
                            Type = @"Field",
                            Position = @"OM4.14",
                            Name = @"Specimen Priorities",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0027",
                            TableName = @"PRIORITY",
                            Description = @"the allowed priorities for obtaining the specimen.  Note that they may be different from the processing priorities given in OM1-26-processing priority.  When a test is requested, the specimen priority given in OBR-27-quantity/timing should be one of the priorities listed here.  Multiple priorities are separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.15",
                            Type = @"Field",
                            Position = @"OM4.15",
                            Name = @"Specimen Retention Time",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"record the usual time that a specimen for this observation is retained after the observation is completed, for the purpose of additional testing.  The first component is the duration, and the second component is an ISO time unit",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.15.1",
                            Type = @"Component",
                            Position = @"OM4.15.1",
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
                            Id = @"OM4.15.2",
                            Type = @"Component",
                            Position = @"OM4.15.2",
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
                        },
                        
                        },
                        };
            }
        }

        public HL7V22SegmentOM4(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field segmentTypeId;

public HL7V22Field SegmentTypeId
{
    get
    {
        if (segmentTypeId != null)
        {
            return segmentTypeId;
        }

        segmentTypeId = new HL7V22Field
        {
            field = message[@"OM4"][1],
            Id = @"OM4.1",
            Type = @"Field",
            Position = @"OM4.1",
            Name = @"Segment Type Id",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"this segment applies to observations/batteries that require a specimen for their performance.  When an observation or battery requires multiple specimens for their performance (e.g., creatinine clearance requires a 24-hour urine specimen and a serum specimen), multiple segments may be included, one for each specimen type. ",
            Sample = @"",
        };

        

        

        

        return segmentTypeId;
    } 
}
internal HL7V22Field sequenceNumberTestObservationMasterFile;

public HL7V22Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (sequenceNumberTestObservationMasterFile != null)
        {
            return sequenceNumberTestObservationMasterFile;
        }

        sequenceNumberTestObservationMasterFile = new HL7V22Field
        {
            field = message[@"OM4"][2],
            Id = @"OM4.2",
            Type = @"Field",
            Position = @"OM4.2",
            Name = @"Sequence Number - Test/ Observation Master File",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
        };

        

        

        

        return sequenceNumberTestObservationMasterFile;
    } 
}
internal HL7V22Field derivedSpecimen;

public HL7V22Field DerivedSpecimen
{
    get
    {
        if (derivedSpecimen != null)
        {
            return derivedSpecimen;
        }

        derivedSpecimen = new HL7V22Field
        {
            field = message[@"OM4"][3],
            Id = @"OM4.3",
            Type = @"Field",
            Position = @"OM4.3",
            Name = @"Derived Specimen",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0170",
            TableName = @"DERIVED SPECIMEN",
            Description = @"for some diagnostic studies -- especially in microbiology -- the initial specimen (e.g., blood) is processed to produce results (e.g., the identity of the bacteria grown out of the culture).  The process also produces new ""specimens"" (e.g., pure culture of staphylococcus, and E. Coli), and these are studied by a second order process (bacterial sensitivities).  This field contains codes that identify the parents (e.g., blood culture) and children (e.g., penicillin MIC) in such cases.",
            Sample = @"",
        };

        

        

        

        return derivedSpecimen;
    } 
}
internal HL7V22Field containerDescription;

public HL7V22Field ContainerDescription
{
    get
    {
        if (containerDescription != null)
        {
            return containerDescription;
        }

        containerDescription = new HL7V22Field
        {
            field = message[@"OM4"][4],
            Id = @"OM4.4",
            Type = @"Field",
            Position = @"OM4.4",
            Name = @"Container Description",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"the physical appearance, including color of tube tops, shape, and material composition (e.g., red-top glass tube).  Note that the color is not necessarily a unique identifier of the additive and/or use of the tube.  This is especially true for black and some blue tube tops, as can be seen above.  Color is included here for user convenience. ",
            Sample = @"",
        };

        

        

        

        return containerDescription;
    } 
}
internal HL7V22Field containerVolume;

public HL7V22Field ContainerVolume
{
    get
    {
        if (containerVolume != null)
        {
            return containerVolume;
        }

        containerVolume = new HL7V22Field
        {
            field = message[@"OM4"][5],
            Id = @"OM4.5",
            Type = @"Field",
            Position = @"OM4.5",
            Name = @"Container Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"the capacity of the container",
            Sample = @"",
        };

        

        

        

        return containerVolume;
    } 
}
internal HL7V22Field containerUnits;

public HL7V22Field ContainerUnits
{
    get
    {
        if (containerUnits != null)
        {
            return containerUnits;
        }

        containerUnits = new HL7V22Field
        {
            field = message[@"OM4"][6],
            Id = @"OM4.6",
            Type = @"Field",
            Position = @"OM4.6",
            Name = @"Container Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"reports the units of measure of the container volume.  If the units are ISO+ units, they should be recorded as single case abbreviations.  If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters.  For example, 1 indicates liters, whereas pt&&ANS+ indicates pints (ANSI units).  The default unit is milliliters (ml), which should be assumed if no units are reported",
            Sample = @"",
        };

        

        

        

        return containerUnits;
    } 
}
internal HL7V22Field specimen;

public HL7V22Field Specimen
{
    get
    {
        if (specimen != null)
        {
            return specimen;
        }

        specimen = new HL7V22Field
        {
            field = message[@"OM4"][7],
            Id = @"OM4.7",
            Type = @"Field",
            Position = @"OM4.7",
            Name = @"Specimen",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"the specimen should be reported as one of the specimen codes described in ASTM Table 14 of 1238-91.  If multiple kinds of specimen are associated with this observation (as in the case for a creatinine clearance), separate them with repeat delimiters",
            Sample = @"",
        };

        

        

        

        return specimen;
    } 
}
internal HL7V22Field additive;

public HL7V22Field Additive
{
    get
    {
        if (additive != null)
        {
            return additive;
        }

        additive = new HL7V22Field
        {
            field = message[@"OM4"][8],
            Id = @"OM4.8",
            Type = @"Field",
            Position = @"OM4.8",
            Name = @"Additive",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"codes should be those provided by NCCLS.  The following list is not exhaustive; it includes only examples",
            Sample = @"",
        };

        

        

        

        return additive;
    } 
}
internal HL7V22Field preparation;

public HL7V22Field Preparation
{
    get
    {
        if (preparation != null)
        {
            return preparation;
        }

        preparation = new HL7V22Field
        {
            field = message[@"OM4"][9],
            Id = @"OM4.9",
            Type = @"Field",
            Position = @"OM4.9",
            Name = @"Preparation",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"the special processing that should be applied to the container, e.g., add acidifying tablets before sending",
            Sample = @"",
        };

        

        

        

        return preparation;
    } 
}
internal HL7V22Field specialHandlingRequirements;

public HL7V22Field SpecialHandlingRequirements
{
    get
    {
        if (specialHandlingRequirements != null)
        {
            return specialHandlingRequirements;
        }

        specialHandlingRequirements = new HL7V22Field
        {
            field = message[@"OM4"][10],
            Id = @"OM4.10",
            Type = @"Field",
            Position = @"OM4.10",
            Name = @"Special Handling Requirements",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"record special handling requirements here (e.g., ice specimen, deliver within 2 hours of obtaining).",
            Sample = @"",
        };

        

        

        

        return specialHandlingRequirements;
    } 
}
internal HL7V22Field normalCollectionVolume;

public HL7V22Field NormalCollectionVolume
{
    get
    {
        if (normalCollectionVolume != null)
        {
            return normalCollectionVolume;
        }

        normalCollectionVolume = new HL7V22Field
        {
            field = message[@"OM4"][11],
            Id = @"OM4.11",
            Type = @"Field",
            Position = @"OM4.11",
            Name = @"Normal Collection Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"record the normal specimen volume required by the lab.  This is the amount used by the normal methods and provides enough specimens to repeat the procedure at least once if needed.  The default unit is milliliters (ml).",
            Sample = @"",
        };

        

        

        

        return normalCollectionVolume;
    } 
}
internal HL7V22Field minimumCollectionVolume;

public HL7V22Field MinimumCollectionVolume
{
    get
    {
        if (minimumCollectionVolume != null)
        {
            return minimumCollectionVolume;
        }

        minimumCollectionVolume = new HL7V22Field
        {
            field = message[@"OM4"][12],
            Id = @"OM4.12",
            Type = @"Field",
            Position = @"OM4.12",
            Name = @"Minimum Collection Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"the amount of specimen needed by the most specimen sparing method (e.g., using micro techniques).  The minimum amount allows for only one determination.  The default unit is milliliters (ml).",
            Sample = @"",
        };

        

        

        

        return minimumCollectionVolume;
    } 
}
internal HL7V22Field specimenRequirements;

public HL7V22Field SpecimenRequirements
{
    get
    {
        if (specimenRequirements != null)
        {
            return specimenRequirements;
        }

        specimenRequirements = new HL7V22Field
        {
            field = message[@"OM4"][13],
            Id = @"OM4.13",
            Type = @"Field",
            Position = @"OM4.13",
            Name = @"Specimen Requirements",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"other requirements for specimen delivery and special handling (e.g., delivery within one hour, iced).",
            Sample = @"",
        };

        

        

        

        return specimenRequirements;
    } 
}
internal HL7V22Field specimenPriorities;

public HL7V22Field SpecimenPriorities
{
    get
    {
        if (specimenPriorities != null)
        {
            return specimenPriorities;
        }

        specimenPriorities = new HL7V22Field
        {
            field = message[@"OM4"][14],
            Id = @"OM4.14",
            Type = @"Field",
            Position = @"OM4.14",
            Name = @"Specimen Priorities",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0027",
            TableName = @"PRIORITY",
            Description = @"the allowed priorities for obtaining the specimen.  Note that they may be different from the processing priorities given in OM1-26-processing priority.  When a test is requested, the specimen priority given in OBR-27-quantity/timing should be one of the priorities listed here.  Multiple priorities are separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return specimenPriorities;
    } 
}
internal HL7V22Field specimenRetentionTime;

public HL7V22Field SpecimenRetentionTime
{
    get
    {
        if (specimenRetentionTime != null)
        {
            return specimenRetentionTime;
        }

        specimenRetentionTime = new HL7V22Field
        {
            field = message[@"OM4"][15],
            Id = @"OM4.15",
            Type = @"Field",
            Position = @"OM4.15",
            Name = @"Specimen Retention Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"record the usual time that a specimen for this observation is retained after the observation is completed, for the purpose of additional testing.  The first component is the duration, and the second component is an ISO time unit",
            Sample = @"",
        };

        

        

        

        return specimenRetentionTime;
    } 
}

    }
}
