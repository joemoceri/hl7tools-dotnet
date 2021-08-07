using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPR1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PR1"; } }

        public string SegmentId { get { return @"PR1"; } }
        
        public string LongName { get { return @"Procedures"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Id = @"PR1.1",
                            Type = @"Field",
                            Position = @"PR1.1",
                            Name = @"Set Id - Procedure",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"SI",
                            DataTypeName = @"Set Id",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.2",
                            Type = @"Field",
                            Position = @"PR1.2",
                            Name = @"Procedure Coding Method.",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0089",
                            TableName = @"PROCEDURE CODING METHOD",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3",
                            Type = @"Field",
                            Position = @"PR1.3",
                            Name = @"Procedure Code",
                            Length = 10,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0088",
                            TableName = @"PROCEDURE CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.4",
                            Type = @"Field",
                            Position = @"PR1.4",
                            Name = @"Procedure Description",
                            Length = 40,
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
                            Id = @"PR1.5",
                            Type = @"Field",
                            Position = @"PR1.5",
                            Name = @"Procedure Date/Time",
                            Length = 19,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.6",
                            Type = @"Field",
                            Position = @"PR1.6",
                            Name = @"Procedure Type",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0090",
                            TableName = @"PROCEDURE TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.7",
                            Type = @"Field",
                            Position = @"PR1.7",
                            Name = @"Procedure Minutes",
                            Length = 4,
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
                            Id = @"PR1.8",
                            Type = @"Field",
                            Position = @"PR1.8",
                            Name = @"Anesthesiologist",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = @"0010",
                            TableName = @"PHYSICIAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.9",
                            Type = @"Field",
                            Position = @"PR1.9",
                            Name = @"Anesthesia Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0019",
                            TableName = @"ANESTHESIA CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.10",
                            Type = @"Field",
                            Position = @"PR1.10",
                            Name = @"Anesthesia Minutes",
                            Length = 4,
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
                            Id = @"PR1.11",
                            Type = @"Field",
                            Position = @"PR1.11",
                            Name = @"Surgeon",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = @"0010",
                            TableName = @"PHYSICIAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12",
                            Type = @"Field",
                            Position = @"PR1.12",
                            Name = @"Resident Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite Id Number And Name",
                            TableId = @"0010",
                            TableName = @"PHYSICIAN ID",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13",
                            Type = @"Field",
                            Position = @"PR1.13",
                            Name = @"Consent Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0059",
                            TableName = @"CONSENT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentPR1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdProcedure;

public HL7V21Field SetIdProcedure
{
    get
    {
        if (setIdProcedure != null)
        {
            return setIdProcedure;
        }

        setIdProcedure = new HL7V21Field
        {
            field = message[@"PR1"][1],
            Id = @"PR1.1",
            Type = @"Field",
            Position = @"PR1.1",
            Name = @"Set Id - Procedure",
            Length = 4,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return setIdProcedure;
    } 
}
internal HL7V21Field procedureCodingMethod.;

public HL7V21Field ProcedureCodingMethod.
{
    get
    {
        if (procedureCodingMethod. != null)
        {
            return procedureCodingMethod.;
        }

        procedureCodingMethod. = new HL7V21Field
        {
            field = message[@"PR1"][2],
            Id = @"PR1.2",
            Type = @"Field",
            Position = @"PR1.2",
            Name = @"Procedure Coding Method.",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0089",
            TableName = @"PROCEDURE CODING METHOD",
            Description = null,
            Sample = @"",
        };

        

        

        

        return procedureCodingMethod.;
    } 
}
internal HL7V21Field procedureCode;

public HL7V21Field ProcedureCode
{
    get
    {
        if (procedureCode != null)
        {
            return procedureCode;
        }

        procedureCode = new HL7V21Field
        {
            field = message[@"PR1"][3],
            Id = @"PR1.3",
            Type = @"Field",
            Position = @"PR1.3",
            Name = @"Procedure Code",
            Length = 10,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0088",
            TableName = @"PROCEDURE CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return procedureCode;
    } 
}
internal HL7V21Field procedureDescription;

public HL7V21Field ProcedureDescription
{
    get
    {
        if (procedureDescription != null)
        {
            return procedureDescription;
        }

        procedureDescription = new HL7V21Field
        {
            field = message[@"PR1"][4],
            Id = @"PR1.4",
            Type = @"Field",
            Position = @"PR1.4",
            Name = @"Procedure Description",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return procedureDescription;
    } 
}
internal HL7V21Field procedureDateTime;

public HL7V21Field ProcedureDateTime
{
    get
    {
        if (procedureDateTime != null)
        {
            return procedureDateTime;
        }

        procedureDateTime = new HL7V21Field
        {
            field = message[@"PR1"][5],
            Id = @"PR1.5",
            Type = @"Field",
            Position = @"PR1.5",
            Name = @"Procedure Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return procedureDateTime;
    } 
}
internal HL7V21Field procedureType;

public HL7V21Field ProcedureType
{
    get
    {
        if (procedureType != null)
        {
            return procedureType;
        }

        procedureType = new HL7V21Field
        {
            field = message[@"PR1"][6],
            Id = @"PR1.6",
            Type = @"Field",
            Position = @"PR1.6",
            Name = @"Procedure Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0090",
            TableName = @"PROCEDURE TYPE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return procedureType;
    } 
}
internal HL7V21Field procedureMinutes;

public HL7V21Field ProcedureMinutes
{
    get
    {
        if (procedureMinutes != null)
        {
            return procedureMinutes;
        }

        procedureMinutes = new HL7V21Field
        {
            field = message[@"PR1"][7],
            Id = @"PR1.7",
            Type = @"Field",
            Position = @"PR1.7",
            Name = @"Procedure Minutes",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return procedureMinutes;
    } 
}
internal HL7V21Field anesthesiologist;

public HL7V21Field Anesthesiologist
{
    get
    {
        if (anesthesiologist != null)
        {
            return anesthesiologist;
        }

        anesthesiologist = new HL7V21Field
        {
            field = message[@"PR1"][8],
            Id = @"PR1.8",
            Type = @"Field",
            Position = @"PR1.8",
            Name = @"Anesthesiologist",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return anesthesiologist;
    } 
}
internal HL7V21Field anesthesiaCode;

public HL7V21Field AnesthesiaCode
{
    get
    {
        if (anesthesiaCode != null)
        {
            return anesthesiaCode;
        }

        anesthesiaCode = new HL7V21Field
        {
            field = message[@"PR1"][9],
            Id = @"PR1.9",
            Type = @"Field",
            Position = @"PR1.9",
            Name = @"Anesthesia Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0019",
            TableName = @"ANESTHESIA CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return anesthesiaCode;
    } 
}
internal HL7V21Field anesthesiaMinutes;

public HL7V21Field AnesthesiaMinutes
{
    get
    {
        if (anesthesiaMinutes != null)
        {
            return anesthesiaMinutes;
        }

        anesthesiaMinutes = new HL7V21Field
        {
            field = message[@"PR1"][10],
            Id = @"PR1.10",
            Type = @"Field",
            Position = @"PR1.10",
            Name = @"Anesthesia Minutes",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return anesthesiaMinutes;
    } 
}
internal HL7V21Field surgeon;

public HL7V21Field Surgeon
{
    get
    {
        if (surgeon != null)
        {
            return surgeon;
        }

        surgeon = new HL7V21Field
        {
            field = message[@"PR1"][11],
            Id = @"PR1.11",
            Type = @"Field",
            Position = @"PR1.11",
            Name = @"Surgeon",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return surgeon;
    } 
}
internal HL7V21Field residentCode;

public HL7V21Field ResidentCode
{
    get
    {
        if (residentCode != null)
        {
            return residentCode;
        }

        residentCode = new HL7V21Field
        {
            field = message[@"PR1"][12],
            Id = @"PR1.12",
            Type = @"Field",
            Position = @"PR1.12",
            Name = @"Resident Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
        };

        

        

        

        return residentCode;
    } 
}
internal HL7V21Field consentCode;

public HL7V21Field ConsentCode
{
    get
    {
        if (consentCode != null)
        {
            return consentCode;
        }

        consentCode = new HL7V21Field
        {
            field = message[@"PR1"][13],
            Id = @"PR1.13",
            Type = @"Field",
            Position = @"PR1.13",
            Name = @"Consent Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0059",
            TableName = @"CONSENT CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return consentCode;
    } 
}

    }
}
