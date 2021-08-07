using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentACC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ACC"; } }

        public string SegmentId { get { return @"ACC"; } }
        
        public string LongName { get { return @"Accident"; } }
        
        public string Description { get { return @"The ACC segment contains patient information relative to an accident in which the patient has been involved. "; } }
        
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
                            Id = @"ACC.1",
                            Type = @"Field",
                            Position = @"ACC.1",
                            Name = @"Accident Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time of the accident",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ACC.1.1",
                            Type = @"Component",
                            Position = @"ACC.1.1",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ACC.2",
                            Type = @"Field",
                            Position = @"ACC.2",
                            Name = @"Accident Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0050",
                            TableName = @"Accident code",
                            Description = @"This field contains the type of accident.  Refer to user-defined table 0050 - Accident code for suggested values.  ICD10 accident codes are recommended.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ACC.2.1",
                            Type = @"Component",
                            Position = @"ACC.2.1",
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
                            Id = @"ACC.2.2",
                            Type = @"Component",
                            Position = @"ACC.2.2",
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
                            Id = @"ACC.2.3",
                            Type = @"Component",
                            Position = @"ACC.2.3",
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
                            Id = @"ACC.2.4",
                            Type = @"Component",
                            Position = @"ACC.2.4",
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
                            Id = @"ACC.2.5",
                            Type = @"Component",
                            Position = @"ACC.2.5",
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
                            Id = @"ACC.2.6",
                            Type = @"Component",
                            Position = @"ACC.2.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ACC.3",
                            Type = @"Field",
                            Position = @"ACC.3",
                            Name = @"Accident Location",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the location of the accident",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ACC.4",
                            Type = @"Field",
                            Position = @"ACC.4",
                            Name = @"Auto Accident State",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the state in which the auto accident occurred.  (HCFA 1500 requirement.)",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ACC.4.1",
                            Type = @"Component",
                            Position = @"ACC.4.1",
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
                            Id = @"ACC.4.2",
                            Type = @"Component",
                            Position = @"ACC.4.2",
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
                            Id = @"ACC.4.3",
                            Type = @"Component",
                            Position = @"ACC.4.3",
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
                            Id = @"ACC.4.4",
                            Type = @"Component",
                            Position = @"ACC.4.4",
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
                            Id = @"ACC.4.5",
                            Type = @"Component",
                            Position = @"ACC.4.5",
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
                            Id = @"ACC.4.6",
                            Type = @"Component",
                            Position = @"ACC.4.6",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ACC.5",
                            Type = @"Field",
                            Position = @"ACC.5",
                            Name = @"Accident Job Related Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates if the accident was related to a job.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the accident was job related 
N the accident was not job related ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ACC.6",
                            Type = @"Field",
                            Position = @"ACC.6",
                            Name = @"Accident Death Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether or not a patient has died as a result of an accident.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the patient has died as a result of an accident
N the patient has not died as a result of an accident",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentACC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field accidentDateTime;

public HL7V23Field AccidentDateTime
{
    get
    {
        if (accidentDateTime != null)
        {
            return accidentDateTime;
        }

        accidentDateTime = new HL7V23Field
        {
            field = message[@"ACC"][1],
            Id = @"ACC.1",
            Type = @"Field",
            Position = @"ACC.1",
            Name = @"Accident Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time of the accident",
            Sample = @"",
        };

        

        

        

        return accidentDateTime;
    } 
}
internal HL7V23Field accidentCode;

public HL7V23Field AccidentCode
{
    get
    {
        if (accidentCode != null)
        {
            return accidentCode;
        }

        accidentCode = new HL7V23Field
        {
            field = message[@"ACC"][2],
            Id = @"ACC.2",
            Type = @"Field",
            Position = @"ACC.2",
            Name = @"Accident Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0050",
            TableName = @"Accident code",
            Description = @"This field contains the type of accident.  Refer to user-defined table 0050 - Accident code for suggested values.  ICD10 accident codes are recommended.",
            Sample = @"",
        };

        

        

        

        return accidentCode;
    } 
}
internal HL7V23Field accidentLocation;

public HL7V23Field AccidentLocation
{
    get
    {
        if (accidentLocation != null)
        {
            return accidentLocation;
        }

        accidentLocation = new HL7V23Field
        {
            field = message[@"ACC"][3],
            Id = @"ACC.3",
            Type = @"Field",
            Position = @"ACC.3",
            Name = @"Accident Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the location of the accident",
            Sample = @"",
        };

        

        

        

        return accidentLocation;
    } 
}
internal HL7V23Field autoAccidentState;

public HL7V23Field AutoAccidentState
{
    get
    {
        if (autoAccidentState != null)
        {
            return autoAccidentState;
        }

        autoAccidentState = new HL7V23Field
        {
            field = message[@"ACC"][4],
            Id = @"ACC.4",
            Type = @"Field",
            Position = @"ACC.4",
            Name = @"Auto Accident State",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the state in which the auto accident occurred.  (HCFA 1500 requirement.)",
            Sample = @"",
        };

        

        

        

        return autoAccidentState;
    } 
}
internal HL7V23Field accidentJobRelatedIndicator;

public HL7V23Field AccidentJobRelatedIndicator
{
    get
    {
        if (accidentJobRelatedIndicator != null)
        {
            return accidentJobRelatedIndicator;
        }

        accidentJobRelatedIndicator = new HL7V23Field
        {
            field = message[@"ACC"][5],
            Id = @"ACC.5",
            Type = @"Field",
            Position = @"ACC.5",
            Name = @"Accident Job Related Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the accident was related to a job.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the accident was job related 
N the accident was not job related ",
            Sample = @"",
        };

        

        

        

        return accidentJobRelatedIndicator;
    } 
}
internal HL7V23Field accidentDeathIndicator;

public HL7V23Field AccidentDeathIndicator
{
    get
    {
        if (accidentDeathIndicator != null)
        {
            return accidentDeathIndicator;
        }

        accidentDeathIndicator = new HL7V23Field
        {
            field = message[@"ACC"][6],
            Id = @"ACC.6",
            Type = @"Field",
            Position = @"ACC.6",
            Name = @"Accident Death Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not a patient has died as a result of an accident.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the patient has died as a result of an accident
N the patient has not died as a result of an accident",
            Sample = @"",
        };

        

        

        

        return accidentDeathIndicator;
    } 
}

    }
}
