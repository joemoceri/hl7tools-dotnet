using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentOM2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM2"; } }

        public string SegmentId { get { return @"OM2"; } }
        
        public string LongName { get { return @"Numeric observation"; } }
        
        public string Description { get { return @"This segment contains the attributes of observations with continuous values (including those with data types of numeric, date, or time stamp).  It can be applied to observation batteries of type A and C (see OM119-nature of test/observation)."; } }
        
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
                            Name = @"Sequence Number",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the same value as the sequence number of the associated OM1 segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.2",
                            Type = @"Field",
                            Position = @"OM2.2",
                            Name = @"Units of Measure",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the single tests/observations (those with a nature code of A or C, as described in OM1-18-nature of test/observation) that have numeric values.  This field contains their customary units of measure",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.2.1",
                            Type = @"Component",
                            Position = @"OM2.2.1",
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
                            Id = @"OM2.2.2",
                            Type = @"Component",
                            Position = @"OM2.2.2",
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
                            Id = @"OM2.2.3",
                            Type = @"Component",
                            Position = @"OM2.2.3",
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
                            Id = @"OM2.2.4",
                            Type = @"Component",
                            Position = @"OM2.2.4",
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
                            Id = @"OM2.2.5",
                            Type = @"Component",
                            Position = @"OM2.2.5",
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
                            Id = @"OM2.2.6",
                            Type = @"Component",
                            Position = @"OM2.2.6",
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
                            Description = @"This field contains the numerically valued single observations (code A or C as described in OM1-18-nature of test/observation), specifies the total length in characters of the field needed to display the observation, and the number of digits displayed to the right of the decimal point.  This is coded as a single number in the format <length>.<decimal-digits>.  For example, a value of 6.2 implies 6 characters total (including the sign and decimal point) with 2 digits after the decimal point.  For integer values, the period and <decimal-digits> portion may be omitted (that is, 5.0 and 5 are equivalent).  More than one such mask may be transmitted (separated by repeat delimiters) when it is necessary to define multiple display formats that are possible. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.4",
                            Type = @"Field",
                            Position = @"OM2.4",
                            Name = @"Corresponding SI Units of Measure",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the single tests/observations - the corresponding SI units of measure in the format, when these differ from the customary units of measure given in the previous field",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.4.1",
                            Type = @"Component",
                            Position = @"OM2.4.1",
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
                            Id = @"OM2.4.2",
                            Type = @"Component",
                            Position = @"OM2.4.2",
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
                            Id = @"OM2.4.3",
                            Type = @"Component",
                            Position = @"OM2.4.3",
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
                            Id = @"OM2.4.4",
                            Type = @"Component",
                            Position = @"OM2.4.4",
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
                            Id = @"OM2.4.5",
                            Type = @"Component",
                            Position = @"OM2.4.5",
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
                            Id = @"OM2.4.6",
                            Type = @"Component",
                            Position = @"OM2.4.6",
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
                            Description = @"This field contains the continuous, numerically valued tests/observations, with a nature code of A or C (see OM1-18-nature of test/observation). This is a factor for converting the customary units to SI units.

In the case that the observation units are not SI units, this field provides the formula needed to convert from the reported units to SI units, this shall include the equation needed to convert from the reporting to the SI units. 

In the case that the relation is simply multiplicative, this field shall include only the conversion factor.  For example., if (results SI units) = c * (results reporting units),then only c would be stored in this field.  In the case of any other functional relationship, the entire equation would be stored as a test.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6",
                            Type = @"Field",
                            Position = @"OM2.6",
                            Name = @"Reference",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RFR",
                            DataTypeName = @"Reference Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the reference (normal) ranges for “numeric” observations/tests with a nature code of A or C (see OM1-18-nature of test/observation). It can identify different reference (normal) ranges for different categories of patients according to age, sex, race, and other conditions.

The general format is 
<ref. (normal) range1>^<sex1>^<age range1>^<age gestation1>^<species1>^<race/subspecies1>^<text condition1>~ 
<ref. (normal) range2>^<sex2>^<age range2>^<age gestation2>^<species2>^<race/subspecies2>^<text condition2>~ 
<ref. (normal) rangen>^<sexn>^<age rangen>^<age gestationn>^<speciesn>^<race/subspeciesn>^<text conditionn> 

The components are defined in the following sections",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.1",
                            Type = @"Component",
                            Position = @"OM2.6.1",
                            Name = @"Reference Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = @"This subcomponent contains the reference (:normal) range.  The format of this field is where the range is taken to be inclusive (i.e., the range includes the end points).  In this specification, the units are assumed to be identical to the reporting units given in OM2-3-units of measure)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.1.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.6.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.1.2",
                            Name = @"High Value",
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
                            Id = @"OM2.6.2",
                            Type = @"Component",
                            Position = @"OM2.6.2",
                            Name = @"Sex",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0001",
                            TableName = @"Sex",
                            Description = @"This subcomponent contains the sex of the patient.  Refer to user-defined table 0001 - Sex for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.3",
                            Type = @"Component",
                            Position = @"OM2.6.3",
                            Name = @"Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the age range (in years or fractions thereof) specified as two values separated by a subcomponent delimiter (in order to allow a simple and consistent machine interpretation of this component).  Ages of less than one year should be specified as a fraction (e.g., 1 month = 0.0830, 1 week = 0.01920, 1 day = 0.0027300).  However, for most purposes involving infants, the gestational age (measured in weeks) is preferred.  The lower end of the range is not indicated; the upper end is, assuring that series of ranges do not overlap",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.3.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.3.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.6.3.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.3.2",
                            Name = @"High Value",
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
                            Id = @"OM2.6.4",
                            Type = @"Component",
                            Position = @"OM2.6.4",
                            Name = @"Age Gestation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the gestational age and is relevant only when the reference range is influenced by the stage of pregnancy.  A range of values is required.  The gestational age is measured in weeks from conception.  For example, <1&10> implies that the normals apply to gestational ages from 1 week to 4 weeks inclusive (1&4).  The lower end of the range is not included; the upper end is, assuring  that series of age ranges do not overlap",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.4.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.4.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.6.4.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.4.2",
                            Name = @"High Value",
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
                            Id = @"OM2.6.5",
                            Type = @"Component",
                            Position = @"OM2.6.5",
                            Name = @"Species",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is assumed to be human unless otherwise stated.  The species should be represented as text (e.g., rabbit, mouse, rat). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.6",
                            Type = @"Component",
                            Position = @"OM2.6.6",
                            Name = @"Race/subspecies",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"n the case of humans (the default), the race is specified when race influences the reference range.  When normal ranges for animals are being described, this component can be used to describe subspecies or special breeds of animals",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.7",
                            Type = @"Component",
                            Position = @"OM2.6.7",
                            Name = @"Conditions",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the condition as simply free text.  This component allows for definition of normal ranges based on any arbitrary condition, e.g., phase of menstrual cycle or dose of a particular drug.  It is provided as a way to communicate the normal ranges for special conditions.  It does not allow automatic checking of these text conditions",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7",
                            Type = @"Field",
                            Position = @"OM2.7",
                            Name = @"Critical Range for Ordinal & Continuous Obs",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = @"This field applies only to single tests/observations (i.e., a nature code of A or C, as described in OM1-19-nature of test/observations) with numeric results.  When a critical range is defined for such observations, it should be recorded here in the same format as the normal range (see OM2-7-reference (normal) range-ordinal and continuous obs). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.1",
                            Type = @"Component",
                            Position = @"OM2.7.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.7.2",
                            Type = @"Component",
                            Position = @"OM2.7.2",
                            Name = @"High Value",
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
                            Id = @"OM2.8",
                            Type = @"Field",
                            Position = @"OM2.8",
                            Name = @"Absolute Range for Ordinal & Continuous Obs",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_ABS_RANGE",
                            DataTypeName = @"Absolute Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This field applies only to single tests/observations with a nature code of A or C (see OM1-19nature of test/observation).  It defines the range of possible results.  Results outside this range are not possible.  The field should be recorded in the same format as the normal and critical ranges.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.1",
                            Type = @"Component",
                            Position = @"OM2.8.1",
                            Name = @"Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.8.1.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.8.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.8.1.2",
                            Name = @"High Value",
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
                            Id = @"OM2.8.2",
                            Type = @"Component",
                            Position = @"OM2.8.2",
                            Name = @"Numeric Change",
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
                            Id = @"OM2.8.3",
                            Type = @"Component",
                            Position = @"OM2.8.3",
                            Name = @"Percent Per Change",
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
                            Id = @"OM2.8.4",
                            Type = @"Component",
                            Position = @"OM2.8.4",
                            Name = @"Days",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9",
                            Type = @"Field",
                            Position = @"OM2.9",
                            Name = @"Delta Check Criteria",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_DLT",
                            DataTypeName = @"Delta Check",
                            TableId = null,
                            TableName = null,
                            Description = @"This field applies only to single tests/observations with a nature code of A or C (see OM1-19nature of test/observation).  It defines the range of possible results.  Results outside this range are not possible.  The field should be recorded in the same format as the normal and critical ranges.

More than one delta check rule can apply.  13&16^10^%^100~16.1&20^2^a^100 implies that the delta check will trigger on a 10% change when the value of the observation is between 13 and 16.  The check will trigger on an absolute change of 2 when the value is between 16.1 and 20.  In both cases, the system will keep the last result for 100 days.  In this example, beyond 100 days, the computer will not compute a delta check because it will not have a comparison value",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.9.1",
                            Type = @"Component",
                            Position = @"OM2.9.1",
                            Name = @"Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = @"The range to which the following applies: <low & high>. 
All the ranges are defined in terms of the customary reporting units given in OM2-3-units of measure.  If no value range is given, the check applies to all values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.9.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.9.1.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.9.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.9.1.2",
                            Name = @"High Value",
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
                            Id = @"OM2.9.2",
                            Type = @"Component",
                            Position = @"OM2.9.2",
                            Name = @"Numeric Threshold",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The numeric threshold of the change that is detected, e.g., 10. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.3",
                            Type = @"Component",
                            Position = @"OM2.9.3",
                            Name = @"Change",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Whether the change is computed as a percent change or an absolute change.  This component can have two possible values: 
    % Indicates a percent change 
    a  Absolute change ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.4",
                            Type = @"Component",
                            Position = @"OM2.9.4",
                            Name = @"Length Of Time-days",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The length of time that the service retains a value for computing delta checks.  This is recorded in number of days",
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
                            Description = @"This field contains the numerically valued single observations (a nature code of A or C, as described in OM1-19-nature of test/observation) and specifies the smallest meaningful difference between reported values (the effective resolution of the measuring instrument or technique for continuous data, or the smallest discrete interval that can occur for discrete data). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentOM2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field sequenceNumber;

public HL7V23Field SequenceNumber
{
    get
    {
        if (sequenceNumber != null)
        {
            return sequenceNumber;
        }

        sequenceNumber = new HL7V23Field
        {
            field = message[@"OM2"][1],
            Id = @"OM2.1",
            Type = @"Field",
            Position = @"OM2.1",
            Name = @"Sequence Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
        };

        // check for repetitions
        if (sequenceNumber.field.FieldRepetitions != null && sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sequenceNumber.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < sequenceNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = sequenceNumber.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sequenceNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = sequenceNumber.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < sequenceNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = sequenceNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sequenceNumber.fieldRepetitions = fieldRepetitions;
        }

        return sequenceNumber;
    } 
}

internal HL7V23Field unitsofMeasure;

public HL7V23Field UnitsofMeasure
{
    get
    {
        if (unitsofMeasure != null)
        {
            return unitsofMeasure;
        }

        unitsofMeasure = new HL7V23Field
        {
            field = message[@"OM2"][2],
            Id = @"OM2.2",
            Type = @"Field",
            Position = @"OM2.2",
            Name = @"Units of Measure",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the single tests/observations (those with a nature code of A or C, as described in OM1-18-nature of test/observation) that have numeric values.  This field contains their customary units of measure",
            Sample = @"",
        };

        // check for repetitions
        if (unitsofMeasure.field.FieldRepetitions != null && unitsofMeasure.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(unitsofMeasure.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < unitsofMeasure.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < unitsofMeasure.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < unitsofMeasure.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
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

internal HL7V23Field rangeofDecimalPrecision;

public HL7V23Field RangeofDecimalPrecision
{
    get
    {
        if (rangeofDecimalPrecision != null)
        {
            return rangeofDecimalPrecision;
        }

        rangeofDecimalPrecision = new HL7V23Field
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
            Description = @"This field contains the numerically valued single observations (code A or C as described in OM1-18-nature of test/observation), specifies the total length in characters of the field needed to display the observation, and the number of digits displayed to the right of the decimal point.  This is coded as a single number in the format <length>.<decimal-digits>.  For example, a value of 6.2 implies 6 characters total (including the sign and decimal point) with 2 digits after the decimal point.  For integer values, the period and <decimal-digits> portion may be omitted (that is, 5.0 and 5 are equivalent).  More than one such mask may be transmitted (separated by repeat delimiters) when it is necessary to define multiple display formats that are possible. ",
            Sample = @"",
        };

        // check for repetitions
        if (rangeofDecimalPrecision.field.FieldRepetitions != null && rangeofDecimalPrecision.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rangeofDecimalPrecision.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < rangeofDecimalPrecision.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < rangeofDecimalPrecision.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < rangeofDecimalPrecision.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
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

internal HL7V23Field correspondingSIUnitsofMeasure;

public HL7V23Field CorrespondingSIUnitsofMeasure
{
    get
    {
        if (correspondingSIUnitsofMeasure != null)
        {
            return correspondingSIUnitsofMeasure;
        }

        correspondingSIUnitsofMeasure = new HL7V23Field
        {
            field = message[@"OM2"][4],
            Id = @"OM2.4",
            Type = @"Field",
            Position = @"OM2.4",
            Name = @"Corresponding SI Units of Measure",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the single tests/observations - the corresponding SI units of measure in the format, when these differ from the customary units of measure given in the previous field",
            Sample = @"",
        };

        // check for repetitions
        if (correspondingSIUnitsofMeasure.field.FieldRepetitions != null && correspondingSIUnitsofMeasure.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(correspondingSIUnitsofMeasure.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < correspondingSIUnitsofMeasure.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < correspondingSIUnitsofMeasure.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < correspondingSIUnitsofMeasure.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
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

internal HL7V23Field sIConversionFactor;

public HL7V23Field SIConversionFactor
{
    get
    {
        if (sIConversionFactor != null)
        {
            return sIConversionFactor;
        }

        sIConversionFactor = new HL7V23Field
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
            Description = @"This field contains the continuous, numerically valued tests/observations, with a nature code of A or C (see OM1-18-nature of test/observation). This is a factor for converting the customary units to SI units.

In the case that the observation units are not SI units, this field provides the formula needed to convert from the reported units to SI units, this shall include the equation needed to convert from the reporting to the SI units. 

In the case that the relation is simply multiplicative, this field shall include only the conversion factor.  For example., if (results SI units) = c * (results reporting units),then only c would be stored in this field.  In the case of any other functional relationship, the entire equation would be stored as a test.",
            Sample = @"",
        };

        // check for repetitions
        if (sIConversionFactor.field.FieldRepetitions != null && sIConversionFactor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sIConversionFactor.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < sIConversionFactor.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sIConversionFactor.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < sIConversionFactor.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
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

internal HL7V23Field reference;

public HL7V23Field Reference
{
    get
    {
        if (reference != null)
        {
            return reference;
        }

        reference = new HL7V23Field
        {
            field = message[@"OM2"][6],
            Id = @"OM2.6",
            Type = @"Field",
            Position = @"OM2.6",
            Name = @"Reference",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_RFR",
            DataTypeName = @"Reference Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reference (normal) ranges for “numeric” observations/tests with a nature code of A or C (see OM1-18-nature of test/observation). It can identify different reference (normal) ranges for different categories of patients according to age, sex, race, and other conditions.

The general format is 
<ref. (normal) range1>^<sex1>^<age range1>^<age gestation1>^<species1>^<race/subspecies1>^<text condition1>~ 
<ref. (normal) range2>^<sex2>^<age range2>^<age gestation2>^<species2>^<race/subspecies2>^<text condition2>~ 
<ref. (normal) rangen>^<sexn>^<age rangen>^<age gestationn>^<speciesn>^<race/subspeciesn>^<text conditionn> 

The components are defined in the following sections",
            Sample = @"",
        };

        // check for repetitions
        if (reference.field.FieldRepetitions != null && reference.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(reference.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < reference.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = reference.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < reference.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = reference.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < reference.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = reference.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            reference.fieldRepetitions = fieldRepetitions;
        }

        return reference;
    } 
}

internal HL7V23Field criticalRangeforOrdinalAndContinuousObs;

public HL7V23Field CriticalRangeforOrdinalAndContinuousObs
{
    get
    {
        if (criticalRangeforOrdinalAndContinuousObs != null)
        {
            return criticalRangeforOrdinalAndContinuousObs;
        }

        criticalRangeforOrdinalAndContinuousObs = new HL7V23Field
        {
            field = message[@"OM2"][7],
            Id = @"OM2.7",
            Type = @"Field",
            Position = @"OM2.7",
            Name = @"Critical Range for Ordinal & Continuous Obs",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_RANGE",
            DataTypeName = @"Wertebereich",
            TableId = null,
            TableName = null,
            Description = @"This field applies only to single tests/observations (i.e., a nature code of A or C, as described in OM1-19-nature of test/observations) with numeric results.  When a critical range is defined for such observations, it should be recorded here in the same format as the normal range (see OM2-7-reference (normal) range-ordinal and continuous obs). ",
            Sample = @"",
        };

        // check for repetitions
        if (criticalRangeforOrdinalAndContinuousObs.field.FieldRepetitions != null && criticalRangeforOrdinalAndContinuousObs.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(criticalRangeforOrdinalAndContinuousObs.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < criticalRangeforOrdinalAndContinuousObs.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = criticalRangeforOrdinalAndContinuousObs.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < criticalRangeforOrdinalAndContinuousObs.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = criticalRangeforOrdinalAndContinuousObs.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < criticalRangeforOrdinalAndContinuousObs.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = criticalRangeforOrdinalAndContinuousObs.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            criticalRangeforOrdinalAndContinuousObs.fieldRepetitions = fieldRepetitions;
        }

        return criticalRangeforOrdinalAndContinuousObs;
    } 
}

internal HL7V23Field absoluteRangeforOrdinalAndContinuousObs;

public HL7V23Field AbsoluteRangeforOrdinalAndContinuousObs
{
    get
    {
        if (absoluteRangeforOrdinalAndContinuousObs != null)
        {
            return absoluteRangeforOrdinalAndContinuousObs;
        }

        absoluteRangeforOrdinalAndContinuousObs = new HL7V23Field
        {
            field = message[@"OM2"][8],
            Id = @"OM2.8",
            Type = @"Field",
            Position = @"OM2.8",
            Name = @"Absolute Range for Ordinal & Continuous Obs",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_ABS_RANGE",
            DataTypeName = @"Absolute Range",
            TableId = null,
            TableName = null,
            Description = @"This field applies only to single tests/observations with a nature code of A or C (see OM1-19nature of test/observation).  It defines the range of possible results.  Results outside this range are not possible.  The field should be recorded in the same format as the normal and critical ranges.",
            Sample = @"",
        };

        // check for repetitions
        if (absoluteRangeforOrdinalAndContinuousObs.field.FieldRepetitions != null && absoluteRangeforOrdinalAndContinuousObs.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(absoluteRangeforOrdinalAndContinuousObs.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < absoluteRangeforOrdinalAndContinuousObs.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = absoluteRangeforOrdinalAndContinuousObs.field.FieldRepetitions[i],
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < absoluteRangeforOrdinalAndContinuousObs.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = absoluteRangeforOrdinalAndContinuousObs.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < absoluteRangeforOrdinalAndContinuousObs.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = absoluteRangeforOrdinalAndContinuousObs.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            absoluteRangeforOrdinalAndContinuousObs.fieldRepetitions = fieldRepetitions;
        }

        return absoluteRangeforOrdinalAndContinuousObs;
    } 
}

internal HL7V23Field deltaCheckCriteria;

public HL7V23Field DeltaCheckCriteria
{
    get
    {
        if (deltaCheckCriteria != null)
        {
            return deltaCheckCriteria;
        }

        deltaCheckCriteria = new HL7V23Field
        {
            field = message[@"OM2"][9],
            Id = @"OM2.9",
            Type = @"Field",
            Position = @"OM2.9",
            Name = @"Delta Check Criteria",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_DLT",
            DataTypeName = @"Delta Check",
            TableId = null,
            TableName = null,
            Description = @"This field applies only to single tests/observations with a nature code of A or C (see OM1-19nature of test/observation).  It defines the range of possible results.  Results outside this range are not possible.  The field should be recorded in the same format as the normal and critical ranges.

More than one delta check rule can apply.  13&16^10^%^100~16.1&20^2^a^100 implies that the delta check will trigger on a 10% change when the value of the observation is between 13 and 16.  The check will trigger on an absolute change of 2 when the value is between 16.1 and 20.  In both cases, the system will keep the last result for 100 days.  In this example, beyond 100 days, the computer will not compute a delta check because it will not have a comparison value",
            Sample = @"",
        };

        // check for repetitions
        if (deltaCheckCriteria.field.FieldRepetitions != null && deltaCheckCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deltaCheckCriteria.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < deltaCheckCriteria.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < deltaCheckCriteria.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < deltaCheckCriteria.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
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

internal HL7V23Field minimumMeaningfulIncrements;

public HL7V23Field MinimumMeaningfulIncrements
{
    get
    {
        if (minimumMeaningfulIncrements != null)
        {
            return minimumMeaningfulIncrements;
        }

        minimumMeaningfulIncrements = new HL7V23Field
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
            Description = @"This field contains the numerically valued single observations (a nature code of A or C, as described in OM1-19-nature of test/observation) and specifies the smallest meaningful difference between reported values (the effective resolution of the measuring instrument or technique for continuous data, or the smallest discrete interval that can occur for discrete data). ",
            Sample = @"",
        };

        // check for repetitions
        if (minimumMeaningfulIncrements.field.FieldRepetitions != null && minimumMeaningfulIncrements.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(minimumMeaningfulIncrements.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < minimumMeaningfulIncrements.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
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
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < minimumMeaningfulIncrements.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
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
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < minimumMeaningfulIncrements.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
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
