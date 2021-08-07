using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentDG1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"DG1"; } }

        public string SegmentId { get { return @"DG1"; } }
        
        public string LongName { get { return @"Diagnosis"; } }
        
        public string Description { get { return @"The DG1 segment contains patient diagnosis information of various types.  For example: Admitting, Current, Primary, Final, etc.  Coding methodologies are also defined"; } }
        
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
                            Id = @"DG1.1",
                            Type = @"Field",
                            Position = @"DG1.1",
                            Name = @"Set Id - Diagnosis",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"sequence number that uniquely identifies the individual transaction for adding, deleting, and updating the diagnosis in the patient's record",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.2",
                            Type = @"Field",
                            Position = @"DG1.2",
                            Name = @"Diagnosis Coding Method",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0053",
                            TableName = @"DIAGNOSIS CODING METHOD",
                            Description = @"ICD9 is the recommended coding methodology.  Refer to user-defined table 0053- diagnosis coding method",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.3",
                            Type = @"Field",
                            Position = @"DG1.3",
                            Name = @"Diagnosis Code",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0051",
                            TableName = @"DIAGNOSIS CODE",
                            Description = @"diagnosis code assigned to this diagnosis.  Refer to user-defined table 0051- diagnosis code",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.4",
                            Type = @"Field",
                            Position = @"DG1.4",
                            Name = @"Diagnosis Description",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"description that best describes the diagnosis",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.5",
                            Type = @"Field",
                            Position = @"DG1.5",
                            Name = @"Diagnosis Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date/time the diagnosis was determined",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"DG1.5.1",
                            Type = @"Component",
                            Position = @"DG1.5.1",
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
                            Id = @"DG1.5.2",
                            Type = @"Component",
                            Position = @"DG1.5.2",
                            Name = @"Degree Of Precision",
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
                            Id = @"DG1.6",
                            Type = @"Field",
                            Position = @"DG1.6",
                            Name = @"Diagnosis / Drg Type",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0052",
                            TableName = @"DIAGNOSIS TYPE",
                            Description = @"code identifies the type of diagnosis being sent.  Valid types could include: Admitting, Final, etc.  Refer to user-defined table 0052- diagnosis type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7",
                            Type = @"Field",
                            Position = @"DG1.7",
                            Name = @"Major Diagnostic Category",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0118",
                            TableName = @"MAJOR DIAGNOSTIC CATEGORY",
                            Description = @"refer to user-defined table 0118 - major diagnostic category",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7.1",
                            Type = @"Component",
                            Position = @"DG1.7.1",
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
                            Id = @"DG1.7.2",
                            Type = @"Component",
                            Position = @"DG1.7.2",
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
                            Id = @"DG1.7.3",
                            Type = @"Component",
                            Position = @"DG1.7.3",
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
                            Id = @"DG1.7.4",
                            Type = @"Component",
                            Position = @"DG1.7.4",
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
                            Id = @"DG1.7.5",
                            Type = @"Component",
                            Position = @"DG1.7.5",
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
                            Id = @"DG1.7.6",
                            Type = @"Component",
                            Position = @"DG1.7.6",
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
                            Id = @"DG1.8",
                            Type = @"Field",
                            Position = @"DG1.8",
                            Name = @"Diagnostic Related Group",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0055",
                            TableName = @"DRG CODE",
                            Description = @"DRG for the transaction.  Interim DRG's could be determined for an encounter.  Refer to user-defined table 0055- DRG code",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.9",
                            Type = @"Field",
                            Position = @"DG1.9",
                            Name = @"Drg Approval Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = @"indicates if the DRG has been approved by a reviewing entity ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.10",
                            Type = @"Field",
                            Position = @"DG1.10",
                            Name = @"Drg Grouper Review Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0056",
                            TableName = @"DRG GROUPER REVIEW CODE",
                            Description = @"refer to user-defined table 0056 - DRG grouper review code.  This code indicates that the grouper results have been reviewed and approved",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.11",
                            Type = @"Field",
                            Position = @"DG1.11",
                            Name = @"Outlier Type",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0083",
                            TableName = @"OUTLIER TYPE",
                            Description = @"Refer to user-defined table 0083 - outlier type.  The type of outlier that has been paid",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.12",
                            Type = @"Field",
                            Position = @"DG1.12",
                            Name = @"Outlier Days",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"number of days that have been approved as an outlier payment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13",
                            Type = @"Field",
                            Position = @"DG1.13",
                            Name = @"Outlier Cost",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"amount of money that has been approved as a payment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.14",
                            Type = @"Field",
                            Position = @"DG1.14",
                            Name = @"Grouper Version And Type",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"grouper version and type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.15",
                            Type = @"Field",
                            Position = @"DG1.15",
                            Name = @"Diagnosis / Drg Priority",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"number which identifies the significance or priority of the diagnosis or DRG code",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16",
                            Type = @"Field",
                            Position = @"DG1.16",
                            Name = @"Diagnosing Clinician",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = @"individual responsible for generating the diagnosis information",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.1",
                            Type = @"Component",
                            Position = @"DG1.16.1",
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
                            Id = @"DG1.16.2",
                            Type = @"Component",
                            Position = @"DG1.16.2",
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
                            Id = @"DG1.16.3",
                            Type = @"Component",
                            Position = @"DG1.16.3",
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
                            Id = @"DG1.16.4",
                            Type = @"Component",
                            Position = @"DG1.16.4",
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
                            Id = @"DG1.16.5",
                            Type = @"Component",
                            Position = @"DG1.16.5",
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
                            Id = @"DG1.16.6",
                            Type = @"Component",
                            Position = @"DG1.16.6",
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
                            Id = @"DG1.16.7",
                            Type = @"Component",
                            Position = @"DG1.16.7",
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
                            Id = @"DG1.16.8",
                            Type = @"Component",
                            Position = @"DG1.16.8",
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
                        },
                        
                        },
                        };
            }
        }

        public HL7V22SegmentDG1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdDiagnosis;

public HL7V22Field SetIdDiagnosis
{
    get
    {
        if (setIdDiagnosis != null)
        {
            return setIdDiagnosis;
        }

        setIdDiagnosis = new HL7V22Field
        {
            field = message[@"DG1"][1],
            Id = @"DG1.1",
            Type = @"Field",
            Position = @"DG1.1",
            Name = @"Set Id - Diagnosis",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"sequence number that uniquely identifies the individual transaction for adding, deleting, and updating the diagnosis in the patient's record",
            Sample = @"",
        };

        

        

        

        return setIdDiagnosis;
    } 
}
internal HL7V22Field diagnosisCodingMethod;

public HL7V22Field DiagnosisCodingMethod
{
    get
    {
        if (diagnosisCodingMethod != null)
        {
            return diagnosisCodingMethod;
        }

        diagnosisCodingMethod = new HL7V22Field
        {
            field = message[@"DG1"][2],
            Id = @"DG1.2",
            Type = @"Field",
            Position = @"DG1.2",
            Name = @"Diagnosis Coding Method",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0053",
            TableName = @"DIAGNOSIS CODING METHOD",
            Description = @"ICD9 is the recommended coding methodology.  Refer to user-defined table 0053- diagnosis coding method",
            Sample = @"",
        };

        

        

        

        return diagnosisCodingMethod;
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
            field = message[@"DG1"][3],
            Id = @"DG1.3",
            Type = @"Field",
            Position = @"DG1.3",
            Name = @"Diagnosis Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0051",
            TableName = @"DIAGNOSIS CODE",
            Description = @"diagnosis code assigned to this diagnosis.  Refer to user-defined table 0051- diagnosis code",
            Sample = @"",
        };

        

        

        

        return diagnosisCode;
    } 
}
internal HL7V22Field diagnosisDescription;

public HL7V22Field DiagnosisDescription
{
    get
    {
        if (diagnosisDescription != null)
        {
            return diagnosisDescription;
        }

        diagnosisDescription = new HL7V22Field
        {
            field = message[@"DG1"][4],
            Id = @"DG1.4",
            Type = @"Field",
            Position = @"DG1.4",
            Name = @"Diagnosis Description",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"description that best describes the diagnosis",
            Sample = @"",
        };

        

        

        

        return diagnosisDescription;
    } 
}
internal HL7V22Field diagnosisDateTime;

public HL7V22Field DiagnosisDateTime
{
    get
    {
        if (diagnosisDateTime != null)
        {
            return diagnosisDateTime;
        }

        diagnosisDateTime = new HL7V22Field
        {
            field = message[@"DG1"][5],
            Id = @"DG1.5",
            Type = @"Field",
            Position = @"DG1.5",
            Name = @"Diagnosis Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time the diagnosis was determined",
            Sample = @"",
        };

        

        

        

        return diagnosisDateTime;
    } 
}
internal HL7V22Field diagnosisDrgType;

public HL7V22Field DiagnosisDrgType
{
    get
    {
        if (diagnosisDrgType != null)
        {
            return diagnosisDrgType;
        }

        diagnosisDrgType = new HL7V22Field
        {
            field = message[@"DG1"][6],
            Id = @"DG1.6",
            Type = @"Field",
            Position = @"DG1.6",
            Name = @"Diagnosis / Drg Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0052",
            TableName = @"DIAGNOSIS TYPE",
            Description = @"code identifies the type of diagnosis being sent.  Valid types could include: Admitting, Final, etc.  Refer to user-defined table 0052- diagnosis type",
            Sample = @"",
        };

        

        

        

        return diagnosisDrgType;
    } 
}
internal HL7V22Field majorDiagnosticCategory;

public HL7V22Field MajorDiagnosticCategory
{
    get
    {
        if (majorDiagnosticCategory != null)
        {
            return majorDiagnosticCategory;
        }

        majorDiagnosticCategory = new HL7V22Field
        {
            field = message[@"DG1"][7],
            Id = @"DG1.7",
            Type = @"Field",
            Position = @"DG1.7",
            Name = @"Major Diagnostic Category",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0118",
            TableName = @"MAJOR DIAGNOSTIC CATEGORY",
            Description = @"refer to user-defined table 0118 - major diagnostic category",
            Sample = @"",
        };

        

        

        

        return majorDiagnosticCategory;
    } 
}
internal HL7V22Field diagnosticRelatedGroup;

public HL7V22Field DiagnosticRelatedGroup
{
    get
    {
        if (diagnosticRelatedGroup != null)
        {
            return diagnosticRelatedGroup;
        }

        diagnosticRelatedGroup = new HL7V22Field
        {
            field = message[@"DG1"][8],
            Id = @"DG1.8",
            Type = @"Field",
            Position = @"DG1.8",
            Name = @"Diagnostic Related Group",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0055",
            TableName = @"DRG CODE",
            Description = @"DRG for the transaction.  Interim DRG's could be determined for an encounter.  Refer to user-defined table 0055- DRG code",
            Sample = @"",
        };

        

        

        

        return diagnosticRelatedGroup;
    } 
}
internal HL7V22Field drgApprovalIndicator;

public HL7V22Field DrgApprovalIndicator
{
    get
    {
        if (drgApprovalIndicator != null)
        {
            return drgApprovalIndicator;
        }

        drgApprovalIndicator = new HL7V22Field
        {
            field = message[@"DG1"][9],
            Id = @"DG1.9",
            Type = @"Field",
            Position = @"DG1.9",
            Name = @"Drg Approval Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"indicates if the DRG has been approved by a reviewing entity ",
            Sample = @"",
        };

        

        

        

        return drgApprovalIndicator;
    } 
}
internal HL7V22Field drgGrouperReviewCode;

public HL7V22Field DrgGrouperReviewCode
{
    get
    {
        if (drgGrouperReviewCode != null)
        {
            return drgGrouperReviewCode;
        }

        drgGrouperReviewCode = new HL7V22Field
        {
            field = message[@"DG1"][10],
            Id = @"DG1.10",
            Type = @"Field",
            Position = @"DG1.10",
            Name = @"Drg Grouper Review Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0056",
            TableName = @"DRG GROUPER REVIEW CODE",
            Description = @"refer to user-defined table 0056 - DRG grouper review code.  This code indicates that the grouper results have been reviewed and approved",
            Sample = @"",
        };

        

        

        

        return drgGrouperReviewCode;
    } 
}
internal HL7V22Field outlierType;

public HL7V22Field OutlierType
{
    get
    {
        if (outlierType != null)
        {
            return outlierType;
        }

        outlierType = new HL7V22Field
        {
            field = message[@"DG1"][11],
            Id = @"DG1.11",
            Type = @"Field",
            Position = @"DG1.11",
            Name = @"Outlier Type",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0083",
            TableName = @"OUTLIER TYPE",
            Description = @"Refer to user-defined table 0083 - outlier type.  The type of outlier that has been paid",
            Sample = @"",
        };

        

        

        

        return outlierType;
    } 
}
internal HL7V22Field outlierDays;

public HL7V22Field OutlierDays
{
    get
    {
        if (outlierDays != null)
        {
            return outlierDays;
        }

        outlierDays = new HL7V22Field
        {
            field = message[@"DG1"][12],
            Id = @"DG1.12",
            Type = @"Field",
            Position = @"DG1.12",
            Name = @"Outlier Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"number of days that have been approved as an outlier payment",
            Sample = @"",
        };

        

        

        

        return outlierDays;
    } 
}
internal HL7V22Field outlierCost;

public HL7V22Field OutlierCost
{
    get
    {
        if (outlierCost != null)
        {
            return outlierCost;
        }

        outlierCost = new HL7V22Field
        {
            field = message[@"DG1"][13],
            Id = @"DG1.13",
            Type = @"Field",
            Position = @"DG1.13",
            Name = @"Outlier Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount of money that has been approved as a payment",
            Sample = @"",
        };

        

        

        

        return outlierCost;
    } 
}
internal HL7V22Field grouperVersionAndType;

public HL7V22Field GrouperVersionAndType
{
    get
    {
        if (grouperVersionAndType != null)
        {
            return grouperVersionAndType;
        }

        grouperVersionAndType = new HL7V22Field
        {
            field = message[@"DG1"][14],
            Id = @"DG1.14",
            Type = @"Field",
            Position = @"DG1.14",
            Name = @"Grouper Version And Type",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"grouper version and type",
            Sample = @"",
        };

        

        

        

        return grouperVersionAndType;
    } 
}
internal HL7V22Field diagnosisDrgPriority;

public HL7V22Field DiagnosisDrgPriority
{
    get
    {
        if (diagnosisDrgPriority != null)
        {
            return diagnosisDrgPriority;
        }

        diagnosisDrgPriority = new HL7V22Field
        {
            field = message[@"DG1"][15],
            Id = @"DG1.15",
            Type = @"Field",
            Position = @"DG1.15",
            Name = @"Diagnosis / Drg Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"number which identifies the significance or priority of the diagnosis or DRG code",
            Sample = @"",
        };

        

        

        

        return diagnosisDrgPriority;
    } 
}
internal HL7V22Field diagnosingClinician;

public HL7V22Field DiagnosingClinician
{
    get
    {
        if (diagnosingClinician != null)
        {
            return diagnosingClinician;
        }

        diagnosingClinician = new HL7V22Field
        {
            field = message[@"DG1"][16],
            Id = @"DG1.16",
            Type = @"Field",
            Position = @"DG1.16",
            Name = @"Diagnosing Clinician",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"individual responsible for generating the diagnosis information",
            Sample = @"",
        };

        

        

        

        return diagnosingClinician;
    } 
}

    }
}
