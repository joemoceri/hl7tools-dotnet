using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentOM4
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"OM4"; } }

        public string SegmentId { get { return @"OM4"; } }
        
        public string LongName { get { return @"Observations that Require Specimens"; } }
        
        public string Description { get { return @"This segment applies to observations/batteries that require a specimen for their performance.  When an observation or battery requires multiple specimens for their performance (e.g., creatinine clearance requires a 24-hour urine specimen and a serum specimen), multiple segments may be included, one for each specimen type."; } }
        
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
                            Id = @"OM4.1",
                            Type = @"Field",
                            Position = @"OM4.1",
                            Name = @"Sequence Number - Test/Observation Master File",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the same value as the sequence number of the associated OM1 segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.2",
                            Type = @"Field",
                            Position = @"OM4.2",
                            Name = @"Derived Specimen",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0170",
                            TableName = @"Derived specimen",
                            Description = @"This field contains the codes that identify the parents and children for diagnostic studies -- especially in microbiology -- where the initial specimen (e.g., blood) is processed to produce results (e.g., the identity of the bacteria grown out of the culture). The process also produces new ""specimens"" (e.g., pure culture of staphylococcus, and E. coli), and these are studied by a second order process (bacterial sensitivities). The parents (e.g., blood culture) and children (e.g., penicillin MIC) are identified in such cases. Refer to HL7 Table 0170 - Derived specimen for valid values:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.3",
                            Type = @"Field",
                            Position = @"OM4.3",
                            Name = @"Container Description",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the physical appearance, including color of tube tops, shape, and material composition (e.g., red-top glass tube). Note that the color is not necessarily a unique identifier of the additive and/or use of the tube. This is especially true for black and some blue tube tops, as can be seen above. Color is included here for user convenience.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.4",
                            Type = @"Field",
                            Position = @"OM4.4",
                            Name = @"Container Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the capacity of the container.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.5",
                            Type = @"Field",
                            Position = @"OM4.5",
                            Name = @"Container Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the units of measure of the container volume. If the units are ISO+ units, they should be recorded as single case abbreviations. If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters. For example, 1 indicates liters, whereas pt&&ANS+ indicates pints (ANSI units). The default unit is milliliters (ml), which should be assumed if no units are reported.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.5.1",
                            Type = @"Component",
                            Position = @"OM4.5.1",
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
                            Id = @"OM4.5.2",
                            Type = @"Component",
                            Position = @"OM4.5.2",
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
                            Id = @"OM4.5.3",
                            Type = @"Component",
                            Position = @"OM4.5.3",
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
                            Id = @"OM4.5.4",
                            Type = @"Component",
                            Position = @"OM4.5.4",
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
                            Id = @"OM4.5.5",
                            Type = @"Component",
                            Position = @"OM4.5.5",
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
                            Id = @"OM4.5.6",
                            Type = @"Component",
                            Position = @"OM4.5.6",
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
                            Id = @"OM4.6",
                            Type = @"Field",
                            Position = @"OM4.6",
                            Name = @"Specimen",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field reports the specimen as one of the specimen codes described in ASTM Table 14 of 1238-91. If multiple kinds of specimen are associated with this observation (as in the case for a creatinine clearance), multiple segments may be included, one for each specimen type.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.6.1",
                            Type = @"Component",
                            Position = @"OM4.6.1",
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
                            Id = @"OM4.6.2",
                            Type = @"Component",
                            Position = @"OM4.6.2",
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
                            Id = @"OM4.6.3",
                            Type = @"Component",
                            Position = @"OM4.6.3",
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
                            Id = @"OM4.6.4",
                            Type = @"Component",
                            Position = @"OM4.6.4",
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
                            Id = @"OM4.6.5",
                            Type = @"Component",
                            Position = @"OM4.6.5",
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
                            Id = @"OM4.6.6",
                            Type = @"Component",
                            Position = @"OM4.6.6",
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
                            Id = @"OM4.7",
                            Type = @"Field",
                            Position = @"OM4.7",
                            Name = @"Additive",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0371",
                            TableName = @"Additive/Preservative",
                            Description = @"This field contains the codes that should be those provided by NCCLS[3]. Refer to HL7 table 0371 - Additive/Preservative for valid values. The tables values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.1",
                            Type = @"Component",
                            Position = @"OM4.7.1",
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
                            Id = @"OM4.7.2",
                            Type = @"Component",
                            Position = @"OM4.7.2",
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
                            Id = @"OM4.7.3",
                            Type = @"Component",
                            Position = @"OM4.7.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.4",
                            Type = @"Component",
                            Position = @"OM4.7.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.5",
                            Type = @"Component",
                            Position = @"OM4.7.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.6",
                            Type = @"Component",
                            Position = @"OM4.7.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.7",
                            Type = @"Component",
                            Position = @"OM4.7.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.8",
                            Type = @"Component",
                            Position = @"OM4.7.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.7.9",
                            Type = @"Component",
                            Position = @"OM4.7.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.8",
                            Type = @"Field",
                            Position = @"OM4.8",
                            Name = @"Preparation",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the special processing that should be applied to the container, e.g., add acidifying tablets before sending.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.9",
                            Type = @"Field",
                            Position = @"OM4.9",
                            Name = @"Special Handling Requirements",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the special handling requirements here (e.g., ice specimen, deliver within two hours of obtaining).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.10",
                            Type = @"Field",
                            Position = @"OM4.10",
                            Name = @"Normal Collection Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the normal specimen volume required by the lab. This is the amount used by the normal methods and provides enough specimens to repeat the procedure at least once if needed. The default unit is milliliters (ml).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.10.1",
                            Type = @"Component",
                            Position = @"OM4.10.1",
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
                            Id = @"OM4.10.2",
                            Type = @"Component",
                            Position = @"OM4.10.2",
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
                            Id = @"OM4.10.2.1",
                            Type = @"SubComponent",
                            Position = @"OM4.10.2.1",
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
                            Id = @"OM4.10.2.2",
                            Type = @"SubComponent",
                            Position = @"OM4.10.2.2",
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
                            Id = @"OM4.10.2.3",
                            Type = @"SubComponent",
                            Position = @"OM4.10.2.3",
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
                            Id = @"OM4.10.2.4",
                            Type = @"SubComponent",
                            Position = @"OM4.10.2.4",
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
                            Id = @"OM4.10.2.5",
                            Type = @"SubComponent",
                            Position = @"OM4.10.2.5",
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
                            Id = @"OM4.10.2.6",
                            Type = @"SubComponent",
                            Position = @"OM4.10.2.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.11",
                            Type = @"Field",
                            Position = @"OM4.11",
                            Name = @"Minimum Collection Volume",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount of specimen needed by the most specimen sparing method (e.g., using micro techniques). The minimum amount allows for only one determination. The default unit is milliliters (ml).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.11.1",
                            Type = @"Component",
                            Position = @"OM4.11.1",
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
                            Id = @"OM4.11.2",
                            Type = @"Component",
                            Position = @"OM4.11.2",
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
                            Id = @"OM4.11.2.1",
                            Type = @"SubComponent",
                            Position = @"OM4.11.2.1",
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
                            Id = @"OM4.11.2.2",
                            Type = @"SubComponent",
                            Position = @"OM4.11.2.2",
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
                            Id = @"OM4.11.2.3",
                            Type = @"SubComponent",
                            Position = @"OM4.11.2.3",
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
                            Id = @"OM4.11.2.4",
                            Type = @"SubComponent",
                            Position = @"OM4.11.2.4",
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
                            Id = @"OM4.11.2.5",
                            Type = @"SubComponent",
                            Position = @"OM4.11.2.5",
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
                            Id = @"OM4.11.2.6",
                            Type = @"SubComponent",
                            Position = @"OM4.11.2.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.12",
                            Type = @"Field",
                            Position = @"OM4.12",
                            Name = @"Specimen Requirements",
                            Length = 10240,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the other requirements for specimen delivery and special handling (e.g., delivery within one hour, iced).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.13",
                            Type = @"Field",
                            Position = @"OM4.13",
                            Name = @"Specimen Priorities",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0027",
                            TableName = @"Priority",
                            Description = @"This field contains the allowed priorities for obtaining the specimen. Note that they may be different from the processing priorities given in OM1-25 - Processing Priority . When a test is requested, the specimen priority given in TQ1-9 - Priority should be one of the priorities listed here. Multiple priorities are separated by repeat delimiters. Refer to HL7 Table 0027 - Priority for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM4.14",
                            Type = @"Field",
                            Position = @"OM4.14",
                            Name = @"Specimen Retention Time",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the usual time that a specimen for this observation is retained after the observation is completed, for the purpose of additional testing. The first component is the duration, and the second component is an ISO time unit.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM4.14.1",
                            Type = @"Component",
                            Position = @"OM4.14.1",
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
                            Id = @"OM4.14.2",
                            Type = @"Component",
                            Position = @"OM4.14.2",
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
                            Id = @"OM4.14.2.1",
                            Type = @"SubComponent",
                            Position = @"OM4.14.2.1",
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
                            Id = @"OM4.14.2.2",
                            Type = @"SubComponent",
                            Position = @"OM4.14.2.2",
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
                            Id = @"OM4.14.2.3",
                            Type = @"SubComponent",
                            Position = @"OM4.14.2.3",
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
                            Id = @"OM4.14.2.4",
                            Type = @"SubComponent",
                            Position = @"OM4.14.2.4",
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
                            Id = @"OM4.14.2.5",
                            Type = @"SubComponent",
                            Position = @"OM4.14.2.5",
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
                            Id = @"OM4.14.2.6",
                            Type = @"SubComponent",
                            Position = @"OM4.14.2.6",
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
                        
                        },
                        };
            }
        }

        public HL7V251SegmentOM4(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field sequenceNumberTestObservationMasterFile;

public HL7V251Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (sequenceNumberTestObservationMasterFile != null)
        {
            return sequenceNumberTestObservationMasterFile;
        }

        sequenceNumberTestObservationMasterFile = new HL7V251Field
        {
            field = message[@"OM4"][1],
            Id = @"OM4.1",
            Type = @"Field",
            Position = @"OM4.1",
            Name = @"Sequence Number - Test/Observation Master File",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment.",
            Sample = @"",
        };

        

        

        

        return sequenceNumberTestObservationMasterFile;
    } 
}
internal HL7V251Field derivedSpecimen;

public HL7V251Field DerivedSpecimen
{
    get
    {
        if (derivedSpecimen != null)
        {
            return derivedSpecimen;
        }

        derivedSpecimen = new HL7V251Field
        {
            field = message[@"OM4"][2],
            Id = @"OM4.2",
            Type = @"Field",
            Position = @"OM4.2",
            Name = @"Derived Specimen",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0170",
            TableName = @"Derived specimen",
            Description = @"This field contains the codes that identify the parents and children for diagnostic studies -- especially in microbiology -- where the initial specimen (e.g., blood) is processed to produce results (e.g., the identity of the bacteria grown out of the culture). The process also produces new ""specimens"" (e.g., pure culture of staphylococcus, and E. coli), and these are studied by a second order process (bacterial sensitivities). The parents (e.g., blood culture) and children (e.g., penicillin MIC) are identified in such cases. Refer to HL7 Table 0170 - Derived specimen for valid values:",
            Sample = @"",
        };

        

        

        

        return derivedSpecimen;
    } 
}
internal HL7V251Field containerDescription;

public HL7V251Field ContainerDescription
{
    get
    {
        if (containerDescription != null)
        {
            return containerDescription;
        }

        containerDescription = new HL7V251Field
        {
            field = message[@"OM4"][3],
            Id = @"OM4.3",
            Type = @"Field",
            Position = @"OM4.3",
            Name = @"Container Description",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the physical appearance, including color of tube tops, shape, and material composition (e.g., red-top glass tube). Note that the color is not necessarily a unique identifier of the additive and/or use of the tube. This is especially true for black and some blue tube tops, as can be seen above. Color is included here for user convenience.",
            Sample = @"",
        };

        

        

        

        return containerDescription;
    } 
}
internal HL7V251Field containerVolume;

public HL7V251Field ContainerVolume
{
    get
    {
        if (containerVolume != null)
        {
            return containerVolume;
        }

        containerVolume = new HL7V251Field
        {
            field = message[@"OM4"][4],
            Id = @"OM4.4",
            Type = @"Field",
            Position = @"OM4.4",
            Name = @"Container Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the capacity of the container.",
            Sample = @"",
        };

        

        

        

        return containerVolume;
    } 
}
internal HL7V251Field containerUnits;

public HL7V251Field ContainerUnits
{
    get
    {
        if (containerUnits != null)
        {
            return containerUnits;
        }

        containerUnits = new HL7V251Field
        {
            field = message[@"OM4"][5],
            Id = @"OM4.5",
            Type = @"Field",
            Position = @"OM4.5",
            Name = @"Container Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units of measure of the container volume. If the units are ISO+ units, they should be recorded as single case abbreviations. If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters. For example, 1 indicates liters, whereas pt&&ANS+ indicates pints (ANSI units). The default unit is milliliters (ml), which should be assumed if no units are reported.",
            Sample = @"",
        };

        

        

        

        return containerUnits;
    } 
}
internal HL7V251Field specimen;

public HL7V251Field Specimen
{
    get
    {
        if (specimen != null)
        {
            return specimen;
        }

        specimen = new HL7V251Field
        {
            field = message[@"OM4"][6],
            Id = @"OM4.6",
            Type = @"Field",
            Position = @"OM4.6",
            Name = @"Specimen",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field reports the specimen as one of the specimen codes described in ASTM Table 14 of 1238-91. If multiple kinds of specimen are associated with this observation (as in the case for a creatinine clearance), multiple segments may be included, one for each specimen type.",
            Sample = @"",
        };

        

        

        

        return specimen;
    } 
}
internal HL7V251Field additive;

public HL7V251Field Additive
{
    get
    {
        if (additive != null)
        {
            return additive;
        }

        additive = new HL7V251Field
        {
            field = message[@"OM4"][7],
            Id = @"OM4.7",
            Type = @"Field",
            Position = @"OM4.7",
            Name = @"Additive",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0371",
            TableName = @"Additive/Preservative",
            Description = @"This field contains the codes that should be those provided by NCCLS[3]. Refer to HL7 table 0371 - Additive/Preservative for valid values. The tables values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
            Sample = @"",
        };

        

        

        

        return additive;
    } 
}
internal HL7V251Field preparation;

public HL7V251Field Preparation
{
    get
    {
        if (preparation != null)
        {
            return preparation;
        }

        preparation = new HL7V251Field
        {
            field = message[@"OM4"][8],
            Id = @"OM4.8",
            Type = @"Field",
            Position = @"OM4.8",
            Name = @"Preparation",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the special processing that should be applied to the container, e.g., add acidifying tablets before sending.",
            Sample = @"",
        };

        

        

        

        return preparation;
    } 
}
internal HL7V251Field specialHandlingRequirements;

public HL7V251Field SpecialHandlingRequirements
{
    get
    {
        if (specialHandlingRequirements != null)
        {
            return specialHandlingRequirements;
        }

        specialHandlingRequirements = new HL7V251Field
        {
            field = message[@"OM4"][9],
            Id = @"OM4.9",
            Type = @"Field",
            Position = @"OM4.9",
            Name = @"Special Handling Requirements",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the special handling requirements here (e.g., ice specimen, deliver within two hours of obtaining).",
            Sample = @"",
        };

        

        

        

        return specialHandlingRequirements;
    } 
}
internal HL7V251Field normalCollectionVolume;

public HL7V251Field NormalCollectionVolume
{
    get
    {
        if (normalCollectionVolume != null)
        {
            return normalCollectionVolume;
        }

        normalCollectionVolume = new HL7V251Field
        {
            field = message[@"OM4"][10],
            Id = @"OM4.10",
            Type = @"Field",
            Position = @"OM4.10",
            Name = @"Normal Collection Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the normal specimen volume required by the lab. This is the amount used by the normal methods and provides enough specimens to repeat the procedure at least once if needed. The default unit is milliliters (ml).",
            Sample = @"",
        };

        

        

        

        return normalCollectionVolume;
    } 
}
internal HL7V251Field minimumCollectionVolume;

public HL7V251Field MinimumCollectionVolume
{
    get
    {
        if (minimumCollectionVolume != null)
        {
            return minimumCollectionVolume;
        }

        minimumCollectionVolume = new HL7V251Field
        {
            field = message[@"OM4"][11],
            Id = @"OM4.11",
            Type = @"Field",
            Position = @"OM4.11",
            Name = @"Minimum Collection Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount of specimen needed by the most specimen sparing method (e.g., using micro techniques). The minimum amount allows for only one determination. The default unit is milliliters (ml).",
            Sample = @"",
        };

        

        

        

        return minimumCollectionVolume;
    } 
}
internal HL7V251Field specimenRequirements;

public HL7V251Field SpecimenRequirements
{
    get
    {
        if (specimenRequirements != null)
        {
            return specimenRequirements;
        }

        specimenRequirements = new HL7V251Field
        {
            field = message[@"OM4"][12],
            Id = @"OM4.12",
            Type = @"Field",
            Position = @"OM4.12",
            Name = @"Specimen Requirements",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the other requirements for specimen delivery and special handling (e.g., delivery within one hour, iced).",
            Sample = @"",
        };

        

        

        

        return specimenRequirements;
    } 
}
internal HL7V251Field specimenPriorities;

public HL7V251Field SpecimenPriorities
{
    get
    {
        if (specimenPriorities != null)
        {
            return specimenPriorities;
        }

        specimenPriorities = new HL7V251Field
        {
            field = message[@"OM4"][13],
            Id = @"OM4.13",
            Type = @"Field",
            Position = @"OM4.13",
            Name = @"Specimen Priorities",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0027",
            TableName = @"Priority",
            Description = @"This field contains the allowed priorities for obtaining the specimen. Note that they may be different from the processing priorities given in OM1-25 - Processing Priority . When a test is requested, the specimen priority given in TQ1-9 - Priority should be one of the priorities listed here. Multiple priorities are separated by repeat delimiters. Refer to HL7 Table 0027 - Priority for valid values.",
            Sample = @"",
        };

        

        

        

        return specimenPriorities;
    } 
}
internal HL7V251Field specimenRetentionTime;

public HL7V251Field SpecimenRetentionTime
{
    get
    {
        if (specimenRetentionTime != null)
        {
            return specimenRetentionTime;
        }

        specimenRetentionTime = new HL7V251Field
        {
            field = message[@"OM4"][14],
            Id = @"OM4.14",
            Type = @"Field",
            Position = @"OM4.14",
            Name = @"Specimen Retention Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the usual time that a specimen for this observation is retained after the observation is completed, for the purpose of additional testing. The first component is the duration, and the second component is an ISO time unit.",
            Sample = @"",
        };

        

        

        

        return specimenRetentionTime;
    } 
}

    }
}
