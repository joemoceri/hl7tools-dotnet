using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentOM2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM2"; } }

        public string SegmentId { get { return @"OM2"; } }
        
        public string LongName { get { return @"Numeric Observation"; } }
        
        public string Description { get { return @"This segment contains the attributes of observations with continuous values (including those with data types of numeric, date, or time stamp).  It can be applied to observation batteries of type A and C (see OM1-18 - Nature of Service/Test/Observation)"; } }
        
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
                            Id = @"OM2.1",
                            Type = @"Field",
                            Position = @"OM2.1",
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
                            Id = @"OM2.2",
                            Type = @"Field",
                            Position = @"OM2.2",
                            Name = @"Units of Measure",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the single tests/observations (those with a nature code of A or C, as described in OM1-18 - Nature of Service/Test/Observation) that have numeric values. This field contains their customary units of measure.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.2.1",
                            Type = @"Component",
                            Position = @"OM2.2.1",
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
                            Id = @"OM2.2.2",
                            Type = @"Component",
                            Position = @"OM2.2.2",
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
                            Id = @"OM2.2.3",
                            Type = @"Component",
                            Position = @"OM2.2.3",
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
                            Id = @"OM2.2.4",
                            Type = @"Component",
                            Position = @"OM2.2.4",
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
                            Id = @"OM2.2.5",
                            Type = @"Component",
                            Position = @"OM2.2.5",
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
                            Id = @"OM2.2.6",
                            Type = @"Component",
                            Position = @"OM2.2.6",
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
                            Id = @"OM2.3",
                            Type = @"Field",
                            Position = @"OM2.3",
                            Name = @"Range of Decimal Precision",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the numerically valued single observations (code A or C as described in OM1-18 - Nature of Service/Test/Observation), specifies the total length in characters of the field needed to display the observation, and the number of digits displayed to the right of the decimal point. This is coded as a single number in the format <length>.<decimal-digits>. For example, a value of 6.2 implies 6 characters total (including the sign and decimal point) with 2 digits after the decimal point. For integer values, the period and <decimal-digits> portion may be omitted (that is, 5.0 and 5 are equivalent). More than one such mask may be transmitted (separated by repeat delimiters) when it is necessary to define multiple display formats that are possible.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.4",
                            Type = @"Field",
                            Position = @"OM2.4",
                            Name = @"Corresponding SI Units of Measure",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the single tests/observations - the corresponding SI units of measure in the format, when these differ from the customary units of measure given in the previous field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.4.1",
                            Type = @"Component",
                            Position = @"OM2.4.1",
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
                            Id = @"OM2.4.2",
                            Type = @"Component",
                            Position = @"OM2.4.2",
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
                            Id = @"OM2.4.3",
                            Type = @"Component",
                            Position = @"OM2.4.3",
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
                            Id = @"OM2.4.4",
                            Type = @"Component",
                            Position = @"OM2.4.4",
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
                            Id = @"OM2.4.5",
                            Type = @"Component",
                            Position = @"OM2.4.5",
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
                            Id = @"OM2.4.6",
                            Type = @"Component",
                            Position = @"OM2.4.6",
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
                            Id = @"OM2.5",
                            Type = @"Field",
                            Position = @"OM2.5",
                            Name = @"SI Conversion Factor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the continuous, numerically valued tests/observations, with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). This is a factor for converting the customary units to SI units.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6",
                            Type = @"Field",
                            Position = @"OM2.6",
                            Name = @"Reference (Normal) Range - Ordinal and Continuous Observations",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"RFR",
                            DataTypeName = @"Reference Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the reference (normal) ranges for ""numeric"" observations/tests with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). It can identify different reference (normal) ranges for different categories of patients according to age, sex, race, and other conditions.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.1",
                            Type = @"Component",
                            Position = @"OM2.6.1",
                            Name = @"Numeric Range",
                            Length = 33,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric interval of the reference data. Range is taken to be inclusive (i.e., the range includes the end points). Units are context sensitive and are defined in the usage note for the field where this data type is used.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.1.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.1.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.2",
                            Type = @"Component",
                            Position = @"OM2.6.2",
                            Name = @"Administrative Sex",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0001",
                            TableName = @"Administrative Sex",
                            Description = @"This component specifies which gender for which the reference range is valid. Refer to User-defined Table 0001 - Administrative Sex for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.3",
                            Type = @"Component",
                            Position = @"OM2.6.3",
                            Name = @"Age Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the age range for which the reference range is valid. Ages of less than one year should be specified as a fraction (e.g., 1 month = 0.0830, 1 week = 0.01920, 1 day = 0.0027300). However, for most purposes involving infants, the gestational age (measured in weeks) is preferred. The lower end of the range is not indicated; the upper end is, assuring that series of ranges do not overlap.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.3.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.3.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.3.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.3.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.4",
                            Type = @"Component",
                            Position = @"OM2.6.4",
                            Name = @"Gestational Age Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the gestational age range for which the reference range is valid. Gestational age is relevant only when the reference range is influenced by the stage of pregnancy. The gestational age is measured in weeks from conception. For example, |1&4| implies that the normals apply to gestational ages from 1 week to 4 weeks inclusive. The lower end of the range is not included; the upper end is, assuring that series of age ranges do not overlap.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.4.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.4.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.4.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.4.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.5",
                            Type = @"Component",
                            Position = @"OM2.6.5",
                            Name = @"Species",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the species for which the reference range is valid. Species is assumed to be human unless otherwise stated. Example values are rabbit, mouse, and rat.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.6",
                            Type = @"Component",
                            Position = @"OM2.6.6",
                            Name = @"Race/Subspecies",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the race or subspecies for which the reference range is valid. In the case of humans (the default species), the race is specified when race influences the reference range. When normal ranges for animals are being described, this component can be used to describe subspecies or special breeds of animals.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.7",
                            Type = @"Component",
                            Position = @"OM2.6.7",
                            Name = @"Conditions",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any arbitrary condition for which the reference range is valid. This may include such conditions as phase of menstrual cycle or dose of a particular drug. It is provided as a way to communicate the normal ranges for special conditions. It does not allow automatic checking of these text conditions.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7",
                            Type = @"Field",
                            Position = @"OM2.7",
                            Name = @"Critical Range for Ordinal and Continuous Observations",
                            Length = 205,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"RFR",
                            DataTypeName = @"Reference Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This field applies only to single tests/observations (i.e., a nature code of A or C, as described in OM1-18 - Nature of Service/Test/Observation) with numeric results. When a critical range is defined for such observations, it should be recorded here in the same format as the normal range (see OM2-6 - Reference (Normal) Range - Ordinal and Continuous Observations ).

Note:  This field is not backward compatible from v2.5.  Prior to v2.5, the narrative conflicted with the component model.  There was an ARB decision to bring the component model into conformity with the narrative. For versions prior to v2.5, the expected format would utilize the component separator (|10^20|); however for v2.5 the format will utilize the sub-component separator (|10&20|). 
8",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.1",
                            Type = @"Component",
                            Position = @"OM2.7.1",
                            Name = @"Numeric Range",
                            Length = 33,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric interval of the reference data. Range is taken to be inclusive (i.e., the range includes the end points). Units are context sensitive and are defined in the usage note for the field where this data type is used.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.7.1.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.7.1.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.2",
                            Type = @"Component",
                            Position = @"OM2.7.2",
                            Name = @"Administrative Sex",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0001",
                            TableName = @"Administrative Sex",
                            Description = @"This component specifies which gender for which the reference range is valid. Refer to User-defined Table 0001 - Administrative Sex for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.3",
                            Type = @"Component",
                            Position = @"OM2.7.3",
                            Name = @"Age Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the age range for which the reference range is valid. Ages of less than one year should be specified as a fraction (e.g., 1 month = 0.0830, 1 week = 0.01920, 1 day = 0.0027300). However, for most purposes involving infants, the gestational age (measured in weeks) is preferred. The lower end of the range is not indicated; the upper end is, assuring that series of ranges do not overlap.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.3.1",
                            Type = @"SubComponent",
                            Position = @"OM2.7.3.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.3.2",
                            Type = @"SubComponent",
                            Position = @"OM2.7.3.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.4",
                            Type = @"Component",
                            Position = @"OM2.7.4",
                            Name = @"Gestational Age Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the gestational age range for which the reference range is valid. Gestational age is relevant only when the reference range is influenced by the stage of pregnancy. The gestational age is measured in weeks from conception. For example, |1&4| implies that the normals apply to gestational ages from 1 week to 4 weeks inclusive. The lower end of the range is not included; the upper end is, assuring that series of age ranges do not overlap.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.4.1",
                            Type = @"SubComponent",
                            Position = @"OM2.7.4.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.4.2",
                            Type = @"SubComponent",
                            Position = @"OM2.7.4.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.5",
                            Type = @"Component",
                            Position = @"OM2.7.5",
                            Name = @"Species",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the species for which the reference range is valid. Species is assumed to be human unless otherwise stated. Example values are rabbit, mouse, and rat.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.6",
                            Type = @"Component",
                            Position = @"OM2.7.6",
                            Name = @"Race/Subspecies",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the race or subspecies for which the reference range is valid. In the case of humans (the default species), the race is specified when race influences the reference range. When normal ranges for animals are being described, this component can be used to describe subspecies or special breeds of animals.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.7",
                            Type = @"Component",
                            Position = @"OM2.7.7",
                            Name = @"Conditions",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any arbitrary condition for which the reference range is valid. This may include such conditions as phase of menstrual cycle or dose of a particular drug. It is provided as a way to communicate the normal ranges for special conditions. It does not allow automatic checking of these text conditions.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8",
                            Type = @"Field",
                            Position = @"OM2.8",
                            Name = @"Absolute Range for Ordinal and Continuous Observations",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RFR",
                            DataTypeName = @"Reference Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This field applies only to single tests/observations with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). It defines the range of possible results. Results outside this range are not possible. The field should be recorded in the same format as the normal and critical ranges.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.1",
                            Type = @"Component",
                            Position = @"OM2.8.1",
                            Name = @"Numeric Range",
                            Length = 33,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric interval of the reference data. Range is taken to be inclusive (i.e., the range includes the end points). Units are context sensitive and are defined in the usage note for the field where this data type is used.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.8.1.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.8.1.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.2",
                            Type = @"Component",
                            Position = @"OM2.8.2",
                            Name = @"Administrative Sex",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0001",
                            TableName = @"Administrative Sex",
                            Description = @"This component specifies which gender for which the reference range is valid. Refer to User-defined Table 0001 - Administrative Sex for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.3",
                            Type = @"Component",
                            Position = @"OM2.8.3",
                            Name = @"Age Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the age range for which the reference range is valid. Ages of less than one year should be specified as a fraction (e.g., 1 month = 0.0830, 1 week = 0.01920, 1 day = 0.0027300). However, for most purposes involving infants, the gestational age (measured in weeks) is preferred. The lower end of the range is not indicated; the upper end is, assuring that series of ranges do not overlap.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.3.1",
                            Type = @"SubComponent",
                            Position = @"OM2.8.3.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.3.2",
                            Type = @"SubComponent",
                            Position = @"OM2.8.3.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.4",
                            Type = @"Component",
                            Position = @"OM2.8.4",
                            Name = @"Gestational Age Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the gestational age range for which the reference range is valid. Gestational age is relevant only when the reference range is influenced by the stage of pregnancy. The gestational age is measured in weeks from conception. For example, |1&4| implies that the normals apply to gestational ages from 1 week to 4 weeks inclusive. The lower end of the range is not included; the upper end is, assuring that series of age ranges do not overlap.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.4.1",
                            Type = @"SubComponent",
                            Position = @"OM2.8.4.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.4.2",
                            Type = @"SubComponent",
                            Position = @"OM2.8.4.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.5",
                            Type = @"Component",
                            Position = @"OM2.8.5",
                            Name = @"Species",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the species for which the reference range is valid. Species is assumed to be human unless otherwise stated. Example values are rabbit, mouse, and rat.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.6",
                            Type = @"Component",
                            Position = @"OM2.8.6",
                            Name = @"Race/Subspecies",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the race or subspecies for which the reference range is valid. In the case of humans (the default species), the race is specified when race influences the reference range. When normal ranges for animals are being described, this component can be used to describe subspecies or special breeds of animals.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.7",
                            Type = @"Component",
                            Position = @"OM2.8.7",
                            Name = @"Conditions",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any arbitrary condition for which the reference range is valid. This may include such conditions as phase of menstrual cycle or dose of a particular drug. It is provided as a way to communicate the normal ranges for special conditions. It does not allow automatic checking of these text conditions.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9",
                            Type = @"Field",
                            Position = @"OM2.9",
                            Name = @"Delta Check Criteria",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"DLT",
                            DataTypeName = @"Delta",
                            TableId = null,
                            TableName = null,
                            Description = @"This field applies to numeric tests/observations with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). The field describes the information that controls delta check warnings and includes four components.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.9.1",
                            Type = @"Component",
                            Position = @"OM2.9.1",
                            Name = @"Normal Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the normal interval of the reference data",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.9.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.9.1.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.9.1.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.2",
                            Type = @"Component",
                            Position = @"OM2.9.2",
                            Name = @"Numeric Threshold",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The numeric threshold of the change that is detected.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.3",
                            Type = @"Component",
                            Position = @"OM2.9.3",
                            Name = @"Change Computation",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0523",
                            TableName = @"Computation type",
                            Description = @"Specifies if the change is computed as a percent change or as an absolute change. Refer to HL7 Table 0523 - Computation type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.4",
                            Type = @"Component",
                            Position = @"OM2.9.4",
                            Name = @"Days Retained",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The length of time in days that the value is retained for computing delta checks.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.10",
                            Type = @"Field",
                            Position = @"OM2.10",
                            Name = @"Minimum Meaningful Increments",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the numerically valued single observations (a nature code of A or C, as described in OM1-18 - Nature of Service/Test/Observation) and specifies the smallest meaningful difference between reported values (the effective resolution of the measuring instrument or technique for continuous data, or the smallest discrete interval that can occur for discrete data).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentOM2(HL7V2Message message)
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
            field = message[@"OM2"][1],
            Id = @"OM2.1",
            Type = @"Field",
            Position = @"OM2.1",
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

        // check for repetitions
        if (sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceNumberTestObservationMasterFile.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = sequenceNumberTestObservationMasterFile.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sequenceNumberTestObservationMasterFile.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = sequenceNumberTestObservationMasterFile.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < sequenceNumberTestObservationMasterFile.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = sequenceNumberTestObservationMasterFile.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            sequenceNumberTestObservationMasterFile.fieldRepetitions = fieldRepetitions;
        }

        return sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V251Field unitsofMeasure;

public HL7V251Field UnitsofMeasure
{
    get
    {
        if (unitsofMeasure != null)
        {
            return unitsofMeasure;
        }

        unitsofMeasure = new HL7V251Field
        {
            field = message[@"OM2"][2],
            Id = @"OM2.2",
            Type = @"Field",
            Position = @"OM2.2",
            Name = @"Units of Measure",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the single tests/observations (those with a nature code of A or C, as described in OM1-18 - Nature of Service/Test/Observation) that have numeric values. This field contains their customary units of measure.",
            Sample = @"",
        };

        // check for repetitions
        if (unitsofMeasure.field.FieldRepetitions != null && unitsofMeasure.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(unitsofMeasure.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < unitsofMeasure.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = unitsofMeasure.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < unitsofMeasure.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = unitsofMeasure.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < unitsofMeasure.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = unitsofMeasure.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            unitsofMeasure.fieldRepetitions = fieldRepetitions;
        }

        return unitsofMeasure;
    } 
}

internal HL7V251Field rangeofDecimalPrecision;

public HL7V251Field RangeofDecimalPrecision
{
    get
    {
        if (rangeofDecimalPrecision != null)
        {
            return rangeofDecimalPrecision;
        }

        rangeofDecimalPrecision = new HL7V251Field
        {
            field = message[@"OM2"][3],
            Id = @"OM2.3",
            Type = @"Field",
            Position = @"OM2.3",
            Name = @"Range of Decimal Precision",
            Length = 10,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the numerically valued single observations (code A or C as described in OM1-18 - Nature of Service/Test/Observation), specifies the total length in characters of the field needed to display the observation, and the number of digits displayed to the right of the decimal point. This is coded as a single number in the format <length>.<decimal-digits>. For example, a value of 6.2 implies 6 characters total (including the sign and decimal point) with 2 digits after the decimal point. For integer values, the period and <decimal-digits> portion may be omitted (that is, 5.0 and 5 are equivalent). More than one such mask may be transmitted (separated by repeat delimiters) when it is necessary to define multiple display formats that are possible.",
            Sample = @"",
        };

        // check for repetitions
        if (rangeofDecimalPrecision.field.FieldRepetitions != null && rangeofDecimalPrecision.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rangeofDecimalPrecision.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < rangeofDecimalPrecision.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = rangeofDecimalPrecision.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rangeofDecimalPrecision.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = rangeofDecimalPrecision.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < rangeofDecimalPrecision.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = rangeofDecimalPrecision.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            rangeofDecimalPrecision.fieldRepetitions = fieldRepetitions;
        }

        return rangeofDecimalPrecision;
    } 
}

internal HL7V251Field correspondingSIUnitsofMeasure;

public HL7V251Field CorrespondingSIUnitsofMeasure
{
    get
    {
        if (correspondingSIUnitsofMeasure != null)
        {
            return correspondingSIUnitsofMeasure;
        }

        correspondingSIUnitsofMeasure = new HL7V251Field
        {
            field = message[@"OM2"][4],
            Id = @"OM2.4",
            Type = @"Field",
            Position = @"OM2.4",
            Name = @"Corresponding SI Units of Measure",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the single tests/observations - the corresponding SI units of measure in the format, when these differ from the customary units of measure given in the previous field.",
            Sample = @"",
        };

        // check for repetitions
        if (correspondingSIUnitsofMeasure.field.FieldRepetitions != null && correspondingSIUnitsofMeasure.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(correspondingSIUnitsofMeasure.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < correspondingSIUnitsofMeasure.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = correspondingSIUnitsofMeasure.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < correspondingSIUnitsofMeasure.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = correspondingSIUnitsofMeasure.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < correspondingSIUnitsofMeasure.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = correspondingSIUnitsofMeasure.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            correspondingSIUnitsofMeasure.fieldRepetitions = fieldRepetitions;
        }

        return correspondingSIUnitsofMeasure;
    } 
}

internal HL7V251Field sIConversionFactor;

public HL7V251Field SIConversionFactor
{
    get
    {
        if (sIConversionFactor != null)
        {
            return sIConversionFactor;
        }

        sIConversionFactor = new HL7V251Field
        {
            field = message[@"OM2"][5],
            Id = @"OM2.5",
            Type = @"Field",
            Position = @"OM2.5",
            Name = @"SI Conversion Factor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the continuous, numerically valued tests/observations, with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). This is a factor for converting the customary units to SI units.",
            Sample = @"",
        };

        // check for repetitions
        if (sIConversionFactor.field.FieldRepetitions != null && sIConversionFactor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sIConversionFactor.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < sIConversionFactor.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = sIConversionFactor.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sIConversionFactor.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = sIConversionFactor.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < sIConversionFactor.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = sIConversionFactor.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            sIConversionFactor.fieldRepetitions = fieldRepetitions;
        }

        return sIConversionFactor;
    } 
}

internal HL7V251Field referenceNormalRangeOrdinalandContinuousObservations;

public HL7V251Field ReferenceNormalRangeOrdinalandContinuousObservations
{
    get
    {
        if (referenceNormalRangeOrdinalandContinuousObservations != null)
        {
            return referenceNormalRangeOrdinalandContinuousObservations;
        }

        referenceNormalRangeOrdinalandContinuousObservations = new HL7V251Field
        {
            field = message[@"OM2"][6],
            Id = @"OM2.6",
            Type = @"Field",
            Position = @"OM2.6",
            Name = @"Reference (Normal) Range - Ordinal and Continuous Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"RFR",
            DataTypeName = @"Reference Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reference (normal) ranges for ""numeric"" observations/tests with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). It can identify different reference (normal) ranges for different categories of patients according to age, sex, race, and other conditions.",
            Sample = @"",
        };

        // check for repetitions
        if (referenceNormalRangeOrdinalandContinuousObservations.field.FieldRepetitions != null && referenceNormalRangeOrdinalandContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referenceNormalRangeOrdinalandContinuousObservations.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < referenceNormalRangeOrdinalandContinuousObservations.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = referenceNormalRangeOrdinalandContinuousObservations.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < referenceNormalRangeOrdinalandContinuousObservations.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = referenceNormalRangeOrdinalandContinuousObservations.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < referenceNormalRangeOrdinalandContinuousObservations.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = referenceNormalRangeOrdinalandContinuousObservations.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            referenceNormalRangeOrdinalandContinuousObservations.fieldRepetitions = fieldRepetitions;
        }

        return referenceNormalRangeOrdinalandContinuousObservations;
    } 
}

internal HL7V251Field criticalRangeforOrdinalandContinuousObservations;

public HL7V251Field CriticalRangeforOrdinalandContinuousObservations
{
    get
    {
        if (criticalRangeforOrdinalandContinuousObservations != null)
        {
            return criticalRangeforOrdinalandContinuousObservations;
        }

        criticalRangeforOrdinalandContinuousObservations = new HL7V251Field
        {
            field = message[@"OM2"][7],
            Id = @"OM2.7",
            Type = @"Field",
            Position = @"OM2.7",
            Name = @"Critical Range for Ordinal and Continuous Observations",
            Length = 205,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"RFR",
            DataTypeName = @"Reference Range",
            TableId = null,
            TableName = null,
            Description = @"This field applies only to single tests/observations (i.e., a nature code of A or C, as described in OM1-18 - Nature of Service/Test/Observation) with numeric results. When a critical range is defined for such observations, it should be recorded here in the same format as the normal range (see OM2-6 - Reference (Normal) Range - Ordinal and Continuous Observations ).

Note:  This field is not backward compatible from v2.5.  Prior to v2.5, the narrative conflicted with the component model.  There was an ARB decision to bring the component model into conformity with the narrative. For versions prior to v2.5, the expected format would utilize the component separator (|10^20|); however for v2.5 the format will utilize the sub-component separator (|10&20|). 
8",
            Sample = @"",
        };

        // check for repetitions
        if (criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions != null && criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(criticalRangeforOrdinalandContinuousObservations.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < criticalRangeforOrdinalandContinuousObservations.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < criticalRangeforOrdinalandContinuousObservations.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            criticalRangeforOrdinalandContinuousObservations.fieldRepetitions = fieldRepetitions;
        }

        return criticalRangeforOrdinalandContinuousObservations;
    } 
}

internal HL7V251Field absoluteRangeforOrdinalandContinuousObservations;

public HL7V251Field AbsoluteRangeforOrdinalandContinuousObservations
{
    get
    {
        if (absoluteRangeforOrdinalandContinuousObservations != null)
        {
            return absoluteRangeforOrdinalandContinuousObservations;
        }

        absoluteRangeforOrdinalandContinuousObservations = new HL7V251Field
        {
            field = message[@"OM2"][8],
            Id = @"OM2.8",
            Type = @"Field",
            Position = @"OM2.8",
            Name = @"Absolute Range for Ordinal and Continuous Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"RFR",
            DataTypeName = @"Reference Range",
            TableId = null,
            TableName = null,
            Description = @"This field applies only to single tests/observations with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). It defines the range of possible results. Results outside this range are not possible. The field should be recorded in the same format as the normal and critical ranges.",
            Sample = @"",
        };

        // check for repetitions
        if (absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions != null && absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(absoluteRangeforOrdinalandContinuousObservations.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < absoluteRangeforOrdinalandContinuousObservations.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < absoluteRangeforOrdinalandContinuousObservations.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            absoluteRangeforOrdinalandContinuousObservations.fieldRepetitions = fieldRepetitions;
        }

        return absoluteRangeforOrdinalandContinuousObservations;
    } 
}

internal HL7V251Field deltaCheckCriteria;

public HL7V251Field DeltaCheckCriteria
{
    get
    {
        if (deltaCheckCriteria != null)
        {
            return deltaCheckCriteria;
        }

        deltaCheckCriteria = new HL7V251Field
        {
            field = message[@"OM2"][9],
            Id = @"OM2.9",
            Type = @"Field",
            Position = @"OM2.9",
            Name = @"Delta Check Criteria",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DLT",
            DataTypeName = @"Delta",
            TableId = null,
            TableName = null,
            Description = @"This field applies to numeric tests/observations with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation). The field describes the information that controls delta check warnings and includes four components.",
            Sample = @"",
        };

        // check for repetitions
        if (deltaCheckCriteria.field.FieldRepetitions != null && deltaCheckCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deltaCheckCriteria.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < deltaCheckCriteria.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = deltaCheckCriteria.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < deltaCheckCriteria.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = deltaCheckCriteria.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < deltaCheckCriteria.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = deltaCheckCriteria.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            deltaCheckCriteria.fieldRepetitions = fieldRepetitions;
        }

        return deltaCheckCriteria;
    } 
}

internal HL7V251Field minimumMeaningfulIncrements;

public HL7V251Field MinimumMeaningfulIncrements
{
    get
    {
        if (minimumMeaningfulIncrements != null)
        {
            return minimumMeaningfulIncrements;
        }

        minimumMeaningfulIncrements = new HL7V251Field
        {
            field = message[@"OM2"][10],
            Id = @"OM2.10",
            Type = @"Field",
            Position = @"OM2.10",
            Name = @"Minimum Meaningful Increments",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the numerically valued single observations (a nature code of A or C, as described in OM1-18 - Nature of Service/Test/Observation) and specifies the smallest meaningful difference between reported values (the effective resolution of the measuring instrument or technique for continuous data, or the smallest discrete interval that can occur for discrete data).",
            Sample = @"",
        };

        // check for repetitions
        if (minimumMeaningfulIncrements.field.FieldRepetitions != null && minimumMeaningfulIncrements.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(minimumMeaningfulIncrements.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < minimumMeaningfulIncrements.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = minimumMeaningfulIncrements.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < minimumMeaningfulIncrements.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = minimumMeaningfulIncrements.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < minimumMeaningfulIncrements.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = minimumMeaningfulIncrements.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            minimumMeaningfulIncrements.fieldRepetitions = fieldRepetitions;
        }

        return minimumMeaningfulIncrements;
    } 
}
    }
}
