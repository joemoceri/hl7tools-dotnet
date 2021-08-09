using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentTCD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"TCD"; } }

        public string SegmentId { get { return @"TCD"; } }
        
        public string LongName { get { return @"Test Code Detail"; } }
        
        public string Description { get { return @"The test code detail segment contains the data necessary to perform operations or calculations, or execute decisions by the laboratory automation system, and which are not supported by the original HL7 segments related to orders (ORC, OBR). For detail of use see messages of laboratory orders and observations in chapters 4 and 7."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

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
                            Id = @"TCD.1",
                            Type = @"Field",
                            Position = @"TCD.1",
                            Name = @"Universal Service Identifier",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the test code that information is being transmitted about",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCD.1.1",
                            Type = @"Component",
                            Position = @"TCD.1.1",
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
                            Id = @"TCD.1.2",
                            Type = @"Component",
                            Position = @"TCD.1.2",
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
                            Id = @"TCD.1.3",
                            Type = @"Component",
                            Position = @"TCD.1.3",
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
                            Id = @"TCD.1.4",
                            Type = @"Component",
                            Position = @"TCD.1.4",
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
                            Id = @"TCD.1.5",
                            Type = @"Component",
                            Position = @"TCD.1.5",
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
                            Id = @"TCD.1.6",
                            Type = @"Component",
                            Position = @"TCD.1.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2",
                            Type = @"Field",
                            Position = @"TCD.2",
                            Name = @"Auto-Dilution Factor",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen by an instrument for this particular test code. (See examples in definition of “Dilution factor” in the “Specimen and Container Detail Segment”.)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCD.2.1",
                            Type = @"Component",
                            Position = @"TCD.2.1",
                            Name = @"Comparator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= > or < or >= or <= or = or <>",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2.2",
                            Type = @"Component",
                            Position = @"TCD.2.2",
                            Name = @"Num1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2.3",
                            Type = @"Component",
                            Position = @"TCD.2.3",
                            Name = @"Separator/Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"- or + or / or . or :",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.2.4",
                            Type = @"Component",
                            Position = @"TCD.2.4",
                            Name = @"Num2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3",
                            Type = @"Field",
                            Position = @"TCD.3",
                            Name = @"Rerun Dilution Factor",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen in case of rerun for this particular test code.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCD.3.1",
                            Type = @"Component",
                            Position = @"TCD.3.1",
                            Name = @"Comparator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= > or < or >= or <= or = or <>",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3.2",
                            Type = @"Component",
                            Position = @"TCD.3.2",
                            Name = @"Num1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3.3",
                            Type = @"Component",
                            Position = @"TCD.3.3",
                            Name = @"Separator/Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"- or + or / or . or :",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.3.4",
                            Type = @"Component",
                            Position = @"TCD.3.4",
                            Name = @"Num2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4",
                            Type = @"Field",
                            Position = @"TCD.4",
                            Name = @"Pre-Dilution Factor",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the value that is to be used as the factor for a particular specimen that is delivered to the automated system as pre-diluted for this particular test code.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCD.4.1",
                            Type = @"Component",
                            Position = @"TCD.4.1",
                            Name = @"Comparator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= > or < or >= or <= or = or <>",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4.2",
                            Type = @"Component",
                            Position = @"TCD.4.2",
                            Name = @"Num1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4.3",
                            Type = @"Component",
                            Position = @"TCD.4.3",
                            Name = @"Separator/Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"- or + or / or . or :",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.4.4",
                            Type = @"Component",
                            Position = @"TCD.4.4",
                            Name = @"Num2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5",
                            Type = @"Field",
                            Position = @"TCD.5",
                            Name = @"Endogenous Content of Pre-Dilution Diluent",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SN",
                            DataTypeName = @"Structured Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field represents the rest concentration of the measured test in the diluent. It is the value that is to be used for calculation of the concentration of pre-diluted specimens for this particular test code",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCD.5.1",
                            Type = @"Component",
                            Position = @"TCD.5.1",
                            Name = @"Comparator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= > or < or >= or <= or = or <>",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5.2",
                            Type = @"Component",
                            Position = @"TCD.5.2",
                            Name = @"Num1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5.3",
                            Type = @"Component",
                            Position = @"TCD.5.3",
                            Name = @"Separator/Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"- or + or / or . or :",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.5.4",
                            Type = @"Component",
                            Position = @"TCD.5.4",
                            Name = @"Num2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.6",
                            Type = @"Field",
                            Position = @"TCD.6",
                            Name = @"Automatic Repeat Allowed",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field identifies whether or not automatic repeats are to be initiated for this particular specimen for this particular test code.  Refer to HL7 Table 0136 -Yes/no indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.7",
                            Type = @"Field",
                            Position = @"TCD.7",
                            Name = @"Reflex Allowed",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field identifies whether or not automatic or manual reflex testing is to be initiated for this particular specimen.  Refer to HL7 Table 0136 -Yes/no indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCD.8",
                            Type = @"Field",
                            Position = @"TCD.8",
                            Name = @"Analyte Repeat Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0389",
                            TableName = @"Analyte repeat status",
                            Description = @"This field identifies the repeat status for the analyte/result (e.g. original, rerun, repeat, reflex). Refer to HL7 Table 0389 – Analyte repeat status for valid values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCD.8.1",
                            Type = @"Component",
                            Position = @"TCD.8.1",
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
                            Id = @"TCD.8.2",
                            Type = @"Component",
                            Position = @"TCD.8.2",
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
                            Id = @"TCD.8.3",
                            Type = @"Component",
                            Position = @"TCD.8.3",
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
                            Id = @"TCD.8.4",
                            Type = @"Component",
                            Position = @"TCD.8.4",
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
                            Id = @"TCD.8.5",
                            Type = @"Component",
                            Position = @"TCD.8.5",
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
                            Id = @"TCD.8.6",
                            Type = @"Component",
                            Position = @"TCD.8.6",
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
                        },}
                        },
                        };
            }
        }

        public HL7V24SegmentTCD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field universalServiceIdentifier;

public HL7V24Field UniversalServiceIdentifier
{
    get
    {
        if (universalServiceIdentifier != null)
        {
            return universalServiceIdentifier;
        }

        universalServiceIdentifier = new HL7V24Field
        {
            field = message[@"TCD"][1],
            Id = @"TCD.1",
            Type = @"Field",
            Position = @"TCD.1",
            Name = @"Universal Service Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the test code that information is being transmitted about",
            Sample = @"",
        };

        // check for repetitions
        if (universalServiceIdentifier.field.FieldRepetitions != null && universalServiceIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(universalServiceIdentifier.Id));
            universalServiceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(universalServiceIdentifier, fieldData);
        }

        return universalServiceIdentifier;
    } 
}

internal HL7V24Field autoDilutionFactor;

public HL7V24Field AutoDilutionFactor
{
    get
    {
        if (autoDilutionFactor != null)
        {
            return autoDilutionFactor;
        }

        autoDilutionFactor = new HL7V24Field
        {
            field = message[@"TCD"][2],
            Id = @"TCD.2",
            Type = @"Field",
            Position = @"TCD.2",
            Name = @"Auto-Dilution Factor",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen by an instrument for this particular test code. (See examples in definition of “Dilution factor” in the “Specimen and Container Detail Segment”.)",
            Sample = @"",
        };

        // check for repetitions
        if (autoDilutionFactor.field.FieldRepetitions != null && autoDilutionFactor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(autoDilutionFactor.Id));
            autoDilutionFactor.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(autoDilutionFactor, fieldData);
        }

        return autoDilutionFactor;
    } 
}

internal HL7V24Field rerunDilutionFactor;

public HL7V24Field RerunDilutionFactor
{
    get
    {
        if (rerunDilutionFactor != null)
        {
            return rerunDilutionFactor;
        }

        rerunDilutionFactor = new HL7V24Field
        {
            field = message[@"TCD"][3],
            Id = @"TCD.3",
            Type = @"Field",
            Position = @"TCD.3",
            Name = @"Rerun Dilution Factor",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the factor for automatically diluting a particular specimen in case of rerun for this particular test code.",
            Sample = @"",
        };

        // check for repetitions
        if (rerunDilutionFactor.field.FieldRepetitions != null && rerunDilutionFactor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rerunDilutionFactor.Id));
            rerunDilutionFactor.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(rerunDilutionFactor, fieldData);
        }

        return rerunDilutionFactor;
    } 
}

internal HL7V24Field preDilutionFactor;

public HL7V24Field PreDilutionFactor
{
    get
    {
        if (preDilutionFactor != null)
        {
            return preDilutionFactor;
        }

        preDilutionFactor = new HL7V24Field
        {
            field = message[@"TCD"][4],
            Id = @"TCD.4",
            Type = @"Field",
            Position = @"TCD.4",
            Name = @"Pre-Dilution Factor",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the factor for a particular specimen that is delivered to the automated system as pre-diluted for this particular test code.",
            Sample = @"",
        };

        // check for repetitions
        if (preDilutionFactor.field.FieldRepetitions != null && preDilutionFactor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(preDilutionFactor.Id));
            preDilutionFactor.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(preDilutionFactor, fieldData);
        }

        return preDilutionFactor;
    } 
}

internal HL7V24Field endogenousContentofPreDilutionDiluent;

public HL7V24Field EndogenousContentofPreDilutionDiluent
{
    get
    {
        if (endogenousContentofPreDilutionDiluent != null)
        {
            return endogenousContentofPreDilutionDiluent;
        }

        endogenousContentofPreDilutionDiluent = new HL7V24Field
        {
            field = message[@"TCD"][5],
            Id = @"TCD.5",
            Type = @"Field",
            Position = @"TCD.5",
            Name = @"Endogenous Content of Pre-Dilution Diluent",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field represents the rest concentration of the measured test in the diluent. It is the value that is to be used for calculation of the concentration of pre-diluted specimens for this particular test code",
            Sample = @"",
        };

        // check for repetitions
        if (endogenousContentofPreDilutionDiluent.field.FieldRepetitions != null && endogenousContentofPreDilutionDiluent.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(endogenousContentofPreDilutionDiluent.Id));
            endogenousContentofPreDilutionDiluent.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(endogenousContentofPreDilutionDiluent, fieldData);
        }

        return endogenousContentofPreDilutionDiluent;
    } 
}

internal HL7V24Field automaticRepeatAllowed;

public HL7V24Field AutomaticRepeatAllowed
{
    get
    {
        if (automaticRepeatAllowed != null)
        {
            return automaticRepeatAllowed;
        }

        automaticRepeatAllowed = new HL7V24Field
        {
            field = message[@"TCD"][6],
            Id = @"TCD.6",
            Type = @"Field",
            Position = @"TCD.6",
            Name = @"Automatic Repeat Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies whether or not automatic repeats are to be initiated for this particular specimen for this particular test code.  Refer to HL7 Table 0136 -Yes/no indicator for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (automaticRepeatAllowed.field.FieldRepetitions != null && automaticRepeatAllowed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(automaticRepeatAllowed.Id));
            automaticRepeatAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(automaticRepeatAllowed, fieldData);
        }

        return automaticRepeatAllowed;
    } 
}

internal HL7V24Field reflexAllowed;

public HL7V24Field ReflexAllowed
{
    get
    {
        if (reflexAllowed != null)
        {
            return reflexAllowed;
        }

        reflexAllowed = new HL7V24Field
        {
            field = message[@"TCD"][7],
            Id = @"TCD.7",
            Type = @"Field",
            Position = @"TCD.7",
            Name = @"Reflex Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies whether or not automatic or manual reflex testing is to be initiated for this particular specimen.  Refer to HL7 Table 0136 -Yes/no indicator for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (reflexAllowed.field.FieldRepetitions != null && reflexAllowed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reflexAllowed.Id));
            reflexAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(reflexAllowed, fieldData);
        }

        return reflexAllowed;
    } 
}

internal HL7V24Field analyteRepeatStatus;

public HL7V24Field AnalyteRepeatStatus
{
    get
    {
        if (analyteRepeatStatus != null)
        {
            return analyteRepeatStatus;
        }

        analyteRepeatStatus = new HL7V24Field
        {
            field = message[@"TCD"][8],
            Id = @"TCD.8",
            Type = @"Field",
            Position = @"TCD.8",
            Name = @"Analyte Repeat Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0389",
            TableName = @"Analyte repeat status",
            Description = @"This field identifies the repeat status for the analyte/result (e.g. original, rerun, repeat, reflex). Refer to HL7 Table 0389 – Analyte repeat status for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (analyteRepeatStatus.field.FieldRepetitions != null && analyteRepeatStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(analyteRepeatStatus.Id));
            analyteRepeatStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(analyteRepeatStatus, fieldData);
        }

        return analyteRepeatStatus;
    } 
}
    }
}
