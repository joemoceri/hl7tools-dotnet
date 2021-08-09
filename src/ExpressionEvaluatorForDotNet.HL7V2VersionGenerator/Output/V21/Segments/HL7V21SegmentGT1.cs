using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentGT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GT1"; } }

        public string SegmentId { get { return @"GT1"; } }
        
        public string LongName { get { return @"Guarantor"; } }
        
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
                            Id = @"GT1.1",
                            Type = @"Field",
                            Position = @"GT1.1",
                            Name = @"Set Id - Guarantor",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
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
                            Id = @"GT1.2",
                            Type = @"Field",
                            Position = @"GT1.2",
                            Name = @"Guarantor Number",
                            Length = 20,
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
                            Id = @"GT1.3",
                            Type = @"Field",
                            Position = @"GT1.3",
                            Name = @"Guarantor Name",
                            Length = 48,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4",
                            Type = @"Field",
                            Position = @"GT1.4",
                            Name = @"Guarantor Spouse Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PN",
                            DataTypeName = @"Person Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5",
                            Type = @"Field",
                            Position = @"GT1.5",
                            Name = @"Guarantor Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6",
                            Type = @"Field",
                            Position = @"GT1.6",
                            Name = @"Guarantor Ph. Num.- Home",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7",
                            Type = @"Field",
                            Position = @"GT1.7",
                            Name = @"Guarantor Ph. Num-business",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.8",
                            Type = @"Field",
                            Position = @"GT1.8",
                            Name = @"Guarantor Date Of Birth",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.9",
                            Type = @"Field",
                            Position = @"GT1.9",
                            Name = @"Guarantor Sex",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0001",
                            TableName = @"SEX",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.10",
                            Type = @"Field",
                            Position = @"GT1.10",
                            Name = @"Guarantor Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0068",
                            TableName = @"GUARANTOR TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.11",
                            Type = @"Field",
                            Position = @"GT1.11",
                            Name = @"Guarantor Relationship",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0063",
                            TableName = @"RELATIONSHIP",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.12",
                            Type = @"Field",
                            Position = @"GT1.12",
                            Name = @"Guarantor Ssn",
                            Length = 11,
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
                            Id = @"GT1.13",
                            Type = @"Field",
                            Position = @"GT1.13",
                            Name = @"Guarantor Date - Begin",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.14",
                            Type = @"Field",
                            Position = @"GT1.14",
                            Name = @"Guarantor Date - End",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.15",
                            Type = @"Field",
                            Position = @"GT1.15",
                            Name = @"Guarantor Priority",
                            Length = 2,
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
                            Id = @"GT1.16",
                            Type = @"Field",
                            Position = @"GT1.16",
                            Name = @"Guarantor Employer Name",
                            Length = 45,
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
                            Id = @"GT1.17",
                            Type = @"Field",
                            Position = @"GT1.17",
                            Name = @"Guarantor Employer Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18",
                            Type = @"Field",
                            Position = @"GT1.18",
                            Name = @"Guarantor Employ Phone #",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19",
                            Type = @"Field",
                            Position = @"GT1.19",
                            Name = @"Guarantor Employee Id Num",
                            Length = 20,
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
                            Id = @"GT1.20",
                            Type = @"Field",
                            Position = @"GT1.20",
                            Name = @"Guarantor Employment Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0066",
                            TableName = @"EMPLOYMENT STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentGT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdGuarantor;

public HL7V21Field SetIdGuarantor
{
    get
    {
        if (setIdGuarantor != null)
        {
            return setIdGuarantor;
        }

        setIdGuarantor = new HL7V21Field
        {
            field = message[@"GT1"][1],
            Id = @"GT1.1",
            Type = @"Field",
            Position = @"GT1.1",
            Name = @"Set Id - Guarantor",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (setIdGuarantor.field.FieldRepetitions != null && setIdGuarantor.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdGuarantor.Id));
            setIdGuarantor.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(setIdGuarantor, fieldData);
        }

        return setIdGuarantor;
    } 
}

internal HL7V21Field guarantorNumber;

public HL7V21Field GuarantorNumber
{
    get
    {
        if (guarantorNumber != null)
        {
            return guarantorNumber;
        }

        guarantorNumber = new HL7V21Field
        {
            field = message[@"GT1"][2],
            Id = @"GT1.2",
            Type = @"Field",
            Position = @"GT1.2",
            Name = @"Guarantor Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorNumber.field.FieldRepetitions != null && guarantorNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorNumber.Id));
            guarantorNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorNumber, fieldData);
        }

        return guarantorNumber;
    } 
}

internal HL7V21Field guarantorName;

public HL7V21Field GuarantorName
{
    get
    {
        if (guarantorName != null)
        {
            return guarantorName;
        }

        guarantorName = new HL7V21Field
        {
            field = message[@"GT1"][3],
            Id = @"GT1.3",
            Type = @"Field",
            Position = @"GT1.3",
            Name = @"Guarantor Name",
            Length = 48,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorName.field.FieldRepetitions != null && guarantorName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorName.Id));
            guarantorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorName, fieldData);
        }

        return guarantorName;
    } 
}

internal HL7V21Field guarantorSpouseName;

public HL7V21Field GuarantorSpouseName
{
    get
    {
        if (guarantorSpouseName != null)
        {
            return guarantorSpouseName;
        }

        guarantorSpouseName = new HL7V21Field
        {
            field = message[@"GT1"][4],
            Id = @"GT1.4",
            Type = @"Field",
            Position = @"GT1.4",
            Name = @"Guarantor Spouse Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorSpouseName.field.FieldRepetitions != null && guarantorSpouseName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorSpouseName.Id));
            guarantorSpouseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorSpouseName, fieldData);
        }

        return guarantorSpouseName;
    } 
}

internal HL7V21Field guarantorAddress;

public HL7V21Field GuarantorAddress
{
    get
    {
        if (guarantorAddress != null)
        {
            return guarantorAddress;
        }

        guarantorAddress = new HL7V21Field
        {
            field = message[@"GT1"][5],
            Id = @"GT1.5",
            Type = @"Field",
            Position = @"GT1.5",
            Name = @"Guarantor Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorAddress.field.FieldRepetitions != null && guarantorAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorAddress.Id));
            guarantorAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorAddress, fieldData);
        }

        return guarantorAddress;
    } 
}

internal HL7V21Field guarantorPhNumHome;

public HL7V21Field GuarantorPhNumHome
{
    get
    {
        if (guarantorPhNumHome != null)
        {
            return guarantorPhNumHome;
        }

        guarantorPhNumHome = new HL7V21Field
        {
            field = message[@"GT1"][6],
            Id = @"GT1.6",
            Type = @"Field",
            Position = @"GT1.6",
            Name = @"Guarantor Ph. Num.- Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorPhNumHome.field.FieldRepetitions != null && guarantorPhNumHome.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorPhNumHome.Id));
            guarantorPhNumHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorPhNumHome, fieldData);
        }

        return guarantorPhNumHome;
    } 
}

internal HL7V21Field guarantorPhNumbusiness;

public HL7V21Field GuarantorPhNumbusiness
{
    get
    {
        if (guarantorPhNumbusiness != null)
        {
            return guarantorPhNumbusiness;
        }

        guarantorPhNumbusiness = new HL7V21Field
        {
            field = message[@"GT1"][7],
            Id = @"GT1.7",
            Type = @"Field",
            Position = @"GT1.7",
            Name = @"Guarantor Ph. Num-business",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorPhNumbusiness.field.FieldRepetitions != null && guarantorPhNumbusiness.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorPhNumbusiness.Id));
            guarantorPhNumbusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorPhNumbusiness, fieldData);
        }

        return guarantorPhNumbusiness;
    } 
}

internal HL7V21Field guarantorDateOfBirth;

public HL7V21Field GuarantorDateOfBirth
{
    get
    {
        if (guarantorDateOfBirth != null)
        {
            return guarantorDateOfBirth;
        }

        guarantorDateOfBirth = new HL7V21Field
        {
            field = message[@"GT1"][8],
            Id = @"GT1.8",
            Type = @"Field",
            Position = @"GT1.8",
            Name = @"Guarantor Date Of Birth",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorDateOfBirth.field.FieldRepetitions != null && guarantorDateOfBirth.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorDateOfBirth.Id));
            guarantorDateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorDateOfBirth, fieldData);
        }

        return guarantorDateOfBirth;
    } 
}

internal HL7V21Field guarantorSex;

public HL7V21Field GuarantorSex
{
    get
    {
        if (guarantorSex != null)
        {
            return guarantorSex;
        }

        guarantorSex = new HL7V21Field
        {
            field = message[@"GT1"][9],
            Id = @"GT1.9",
            Type = @"Field",
            Position = @"GT1.9",
            Name = @"Guarantor Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorSex.field.FieldRepetitions != null && guarantorSex.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorSex.Id));
            guarantorSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorSex, fieldData);
        }

        return guarantorSex;
    } 
}

internal HL7V21Field guarantorType;

public HL7V21Field GuarantorType
{
    get
    {
        if (guarantorType != null)
        {
            return guarantorType;
        }

        guarantorType = new HL7V21Field
        {
            field = message[@"GT1"][10],
            Id = @"GT1.10",
            Type = @"Field",
            Position = @"GT1.10",
            Name = @"Guarantor Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0068",
            TableName = @"GUARANTOR TYPE",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorType.field.FieldRepetitions != null && guarantorType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorType.Id));
            guarantorType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorType, fieldData);
        }

        return guarantorType;
    } 
}

internal HL7V21Field guarantorRelationship;

public HL7V21Field GuarantorRelationship
{
    get
    {
        if (guarantorRelationship != null)
        {
            return guarantorRelationship;
        }

        guarantorRelationship = new HL7V21Field
        {
            field = message[@"GT1"][11],
            Id = @"GT1.11",
            Type = @"Field",
            Position = @"GT1.11",
            Name = @"Guarantor Relationship",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorRelationship.field.FieldRepetitions != null && guarantorRelationship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorRelationship.Id));
            guarantorRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorRelationship, fieldData);
        }

        return guarantorRelationship;
    } 
}

internal HL7V21Field guarantorSsn;

public HL7V21Field GuarantorSsn
{
    get
    {
        if (guarantorSsn != null)
        {
            return guarantorSsn;
        }

        guarantorSsn = new HL7V21Field
        {
            field = message[@"GT1"][12],
            Id = @"GT1.12",
            Type = @"Field",
            Position = @"GT1.12",
            Name = @"Guarantor Ssn",
            Length = 11,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorSsn.field.FieldRepetitions != null && guarantorSsn.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorSsn.Id));
            guarantorSsn.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorSsn, fieldData);
        }

        return guarantorSsn;
    } 
}

internal HL7V21Field guarantorDateBegin;

public HL7V21Field GuarantorDateBegin
{
    get
    {
        if (guarantorDateBegin != null)
        {
            return guarantorDateBegin;
        }

        guarantorDateBegin = new HL7V21Field
        {
            field = message[@"GT1"][13],
            Id = @"GT1.13",
            Type = @"Field",
            Position = @"GT1.13",
            Name = @"Guarantor Date - Begin",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorDateBegin.field.FieldRepetitions != null && guarantorDateBegin.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorDateBegin.Id));
            guarantorDateBegin.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorDateBegin, fieldData);
        }

        return guarantorDateBegin;
    } 
}

internal HL7V21Field guarantorDateEnd;

public HL7V21Field GuarantorDateEnd
{
    get
    {
        if (guarantorDateEnd != null)
        {
            return guarantorDateEnd;
        }

        guarantorDateEnd = new HL7V21Field
        {
            field = message[@"GT1"][14],
            Id = @"GT1.14",
            Type = @"Field",
            Position = @"GT1.14",
            Name = @"Guarantor Date - End",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorDateEnd.field.FieldRepetitions != null && guarantorDateEnd.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorDateEnd.Id));
            guarantorDateEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorDateEnd, fieldData);
        }

        return guarantorDateEnd;
    } 
}

internal HL7V21Field guarantorPriority;

public HL7V21Field GuarantorPriority
{
    get
    {
        if (guarantorPriority != null)
        {
            return guarantorPriority;
        }

        guarantorPriority = new HL7V21Field
        {
            field = message[@"GT1"][15],
            Id = @"GT1.15",
            Type = @"Field",
            Position = @"GT1.15",
            Name = @"Guarantor Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorPriority.field.FieldRepetitions != null && guarantorPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorPriority.Id));
            guarantorPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorPriority, fieldData);
        }

        return guarantorPriority;
    } 
}

internal HL7V21Field guarantorEmployerName;

public HL7V21Field GuarantorEmployerName
{
    get
    {
        if (guarantorEmployerName != null)
        {
            return guarantorEmployerName;
        }

        guarantorEmployerName = new HL7V21Field
        {
            field = message[@"GT1"][16],
            Id = @"GT1.16",
            Type = @"Field",
            Position = @"GT1.16",
            Name = @"Guarantor Employer Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployerName.field.FieldRepetitions != null && guarantorEmployerName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployerName.Id));
            guarantorEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorEmployerName, fieldData);
        }

        return guarantorEmployerName;
    } 
}

internal HL7V21Field guarantorEmployerAddress;

public HL7V21Field GuarantorEmployerAddress
{
    get
    {
        if (guarantorEmployerAddress != null)
        {
            return guarantorEmployerAddress;
        }

        guarantorEmployerAddress = new HL7V21Field
        {
            field = message[@"GT1"][17],
            Id = @"GT1.17",
            Type = @"Field",
            Position = @"GT1.17",
            Name = @"Guarantor Employer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployerAddress.field.FieldRepetitions != null && guarantorEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployerAddress.Id));
            guarantorEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorEmployerAddress, fieldData);
        }

        return guarantorEmployerAddress;
    } 
}

internal HL7V21Field guarantorEmployPhone#;

public HL7V21Field GuarantorEmployPhone#
{
    get
    {
        if (guarantorEmployPhone# != null)
        {
            return guarantorEmployPhone#;
        }

        guarantorEmployPhone# = new HL7V21Field
        {
            field = message[@"GT1"][18],
            Id = @"GT1.18",
            Type = @"Field",
            Position = @"GT1.18",
            Name = @"Guarantor Employ Phone #",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployPhone#.field.FieldRepetitions != null && guarantorEmployPhone#.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployPhone#.Id));
            guarantorEmployPhone#.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorEmployPhone#, fieldData);
        }

        return guarantorEmployPhone#;
    } 
}

internal HL7V21Field guarantorEmployeeIdNum;

public HL7V21Field GuarantorEmployeeIdNum
{
    get
    {
        if (guarantorEmployeeIdNum != null)
        {
            return guarantorEmployeeIdNum;
        }

        guarantorEmployeeIdNum = new HL7V21Field
        {
            field = message[@"GT1"][19],
            Id = @"GT1.19",
            Type = @"Field",
            Position = @"GT1.19",
            Name = @"Guarantor Employee Id Num",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmployeeIdNum.field.FieldRepetitions != null && guarantorEmployeeIdNum.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmployeeIdNum.Id));
            guarantorEmployeeIdNum.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorEmployeeIdNum, fieldData);
        }

        return guarantorEmployeeIdNum;
    } 
}

internal HL7V21Field guarantorEmploymentStatus;

public HL7V21Field GuarantorEmploymentStatus
{
    get
    {
        if (guarantorEmploymentStatus != null)
        {
            return guarantorEmploymentStatus;
        }

        guarantorEmploymentStatus = new HL7V21Field
        {
            field = message[@"GT1"][20],
            Id = @"GT1.20",
            Type = @"Field",
            Position = @"GT1.20",
            Name = @"Guarantor Employment Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0066",
            TableName = @"EMPLOYMENT STATUS",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (guarantorEmploymentStatus.field.FieldRepetitions != null && guarantorEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(guarantorEmploymentStatus.Id));
            guarantorEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(guarantorEmploymentStatus, fieldData);
        }

        return guarantorEmploymentStatus;
    } 
}
    }
}
