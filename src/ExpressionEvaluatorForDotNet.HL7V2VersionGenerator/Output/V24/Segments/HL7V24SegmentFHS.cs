using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentFHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FHS"; } }

        public string SegmentId { get { return @"FHS"; } }
        
        public string LongName { get { return @"File Header Segment"; } }
        
        public string Description { get { return @"The FHS segment is used to head a file (group of batches) as defined in Section 2.15.3, “HL7 batch protocol.”"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

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
                            Id = @"FHS.1",
                            Type = @"Field",
                            Position = @"FHS.1",
                            Name = @"File Field Separator",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.2",
                            Type = @"Field",
                            Position = @"FHS.2",
                            Name = @"File Encoding Characters",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.3",
                            Type = @"Field",
                            Position = @"FHS.3",
                            Name = @"File Sending Application",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.4",
                            Type = @"Field",
                            Position = @"FHS.4",
                            Name = @"File Sending Facility",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.5",
                            Type = @"Field",
                            Position = @"FHS.5",
                            Name = @"File Receiving Application",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.6",
                            Type = @"Field",
                            Position = @"FHS.6",
                            Name = @"File Receiving Facility",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.7",
                            Type = @"Field",
                            Position = @"FHS.7",
                            Name = @"File Creation Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"FHS.7.1",
                            Type = @"Component",
                            Position = @"FHS.7.1",
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
                            Id = @"FHS.7.2",
                            Type = @"Component",
                            Position = @"FHS.7.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.8",
                            Type = @"Field",
                            Position = @"FHS.8",
                            Name = @"File Security",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.9",
                            Type = @"Field",
                            Position = @"FHS.9",
                            Name = @"File Name/ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field can be used by the application processing file.  Its use is not further specified",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.10",
                            Type = @"Field",
                            Position = @"FHS.10",
                            Name = @"File Header Comment",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the free text field, the use of which is not further specified",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.11",
                            Type = @"Field",
                            Position = @"FHS.11",
                            Name = @"File Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to identify a particular file uniquely.  It can be echoed back in FHS-12-reference file control ID",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FHS.12",
                            Type = @"Field",
                            Position = @"FHS.12",
                            Name = @"Reference File Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted.  Not present if this file is being transmitted for the first time",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentFHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field fileFieldSeparator;

public HL7V24Field FileFieldSeparator
{
    get
    {
        if (fileFieldSeparator != null)
        {
            return fileFieldSeparator;
        }

        fileFieldSeparator = new HL7V24Field
        {
            field = message[@"FHS"][1],
            Id = @"FHS.1",
            Type = @"Field",
            Position = @"FHS.1",
            Name = @"File Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileFieldSeparator.field.FieldRepetitions != null && fileFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileFieldSeparator.Id));
            fileFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileFieldSeparator, fieldData);
        }

        return fileFieldSeparator;
    } 
}

internal HL7V24Field fileEncodingCharacters;

public HL7V24Field FileEncodingCharacters
{
    get
    {
        if (fileEncodingCharacters != null)
        {
            return fileEncodingCharacters;
        }

        fileEncodingCharacters = new HL7V24Field
        {
            field = message[@"FHS"][2],
            Id = @"FHS.2",
            Type = @"Field",
            Position = @"FHS.2",
            Name = @"File Encoding Characters",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileEncodingCharacters.field.FieldRepetitions != null && fileEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileEncodingCharacters.Id));
            fileEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileEncodingCharacters, fieldData);
        }

        return fileEncodingCharacters;
    } 
}

internal HL7V24Field fileSendingApplication;

public HL7V24Field FileSendingApplication
{
    get
    {
        if (fileSendingApplication != null)
        {
            return fileSendingApplication;
        }

        fileSendingApplication = new HL7V24Field
        {
            field = message[@"FHS"][3],
            Id = @"FHS.3",
            Type = @"Field",
            Position = @"FHS.3",
            Name = @"File Sending Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileSendingApplication.field.FieldRepetitions != null && fileSendingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileSendingApplication.Id));
            fileSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileSendingApplication, fieldData);
        }

        return fileSendingApplication;
    } 
}

internal HL7V24Field fileSendingFacility;

public HL7V24Field FileSendingFacility
{
    get
    {
        if (fileSendingFacility != null)
        {
            return fileSendingFacility;
        }

        fileSendingFacility = new HL7V24Field
        {
            field = message[@"FHS"][4],
            Id = @"FHS.4",
            Type = @"Field",
            Position = @"FHS.4",
            Name = @"File Sending Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileSendingFacility.field.FieldRepetitions != null && fileSendingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileSendingFacility.Id));
            fileSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileSendingFacility, fieldData);
        }

        return fileSendingFacility;
    } 
}

internal HL7V24Field fileReceivingApplication;

public HL7V24Field FileReceivingApplication
{
    get
    {
        if (fileReceivingApplication != null)
        {
            return fileReceivingApplication;
        }

        fileReceivingApplication = new HL7V24Field
        {
            field = message[@"FHS"][5],
            Id = @"FHS.5",
            Type = @"Field",
            Position = @"FHS.5",
            Name = @"File Receiving Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileReceivingApplication.field.FieldRepetitions != null && fileReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileReceivingApplication.Id));
            fileReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileReceivingApplication, fieldData);
        }

        return fileReceivingApplication;
    } 
}

internal HL7V24Field fileReceivingFacility;

public HL7V24Field FileReceivingFacility
{
    get
    {
        if (fileReceivingFacility != null)
        {
            return fileReceivingFacility;
        }

        fileReceivingFacility = new HL7V24Field
        {
            field = message[@"FHS"][6],
            Id = @"FHS.6",
            Type = @"Field",
            Position = @"FHS.6",
            Name = @"File Receiving Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileReceivingFacility.field.FieldRepetitions != null && fileReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileReceivingFacility.Id));
            fileReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileReceivingFacility, fieldData);
        }

        return fileReceivingFacility;
    } 
}

internal HL7V24Field fileCreationDateTime;

public HL7V24Field FileCreationDateTime
{
    get
    {
        if (fileCreationDateTime != null)
        {
            return fileCreationDateTime;
        }

        fileCreationDateTime = new HL7V24Field
        {
            field = message[@"FHS"][7],
            Id = @"FHS.7",
            Type = @"Field",
            Position = @"FHS.7",
            Name = @"File Creation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileCreationDateTime.field.FieldRepetitions != null && fileCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileCreationDateTime.Id));
            fileCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileCreationDateTime, fieldData);
        }

        return fileCreationDateTime;
    } 
}

internal HL7V24Field fileSecurity;

public HL7V24Field FileSecurity
{
    get
    {
        if (fileSecurity != null)
        {
            return fileSecurity;
        }

        fileSecurity = new HL7V24Field
        {
            field = message[@"FHS"][8],
            Id = @"FHS.8",
            Type = @"Field",
            Position = @"FHS.8",
            Name = @"File Security",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        // check for repetitions
        if (fileSecurity.field.FieldRepetitions != null && fileSecurity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileSecurity.Id));
            fileSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileSecurity, fieldData);
        }

        return fileSecurity;
    } 
}

internal HL7V24Field fileNameID;

public HL7V24Field FileNameID
{
    get
    {
        if (fileNameID != null)
        {
            return fileNameID;
        }

        fileNameID = new HL7V24Field
        {
            field = message[@"FHS"][9],
            Id = @"FHS.9",
            Type = @"Field",
            Position = @"FHS.9",
            Name = @"File Name/ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing file.  Its use is not further specified",
            Sample = @"",
        };

        // check for repetitions
        if (fileNameID.field.FieldRepetitions != null && fileNameID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileNameID.Id));
            fileNameID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileNameID, fieldData);
        }

        return fileNameID;
    } 
}

internal HL7V24Field fileHeaderComment;

public HL7V24Field FileHeaderComment
{
    get
    {
        if (fileHeaderComment != null)
        {
            return fileHeaderComment;
        }

        fileHeaderComment = new HL7V24Field
        {
            field = message[@"FHS"][10],
            Id = @"FHS.10",
            Type = @"Field",
            Position = @"FHS.10",
            Name = @"File Header Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the free text field, the use of which is not further specified",
            Sample = @"",
        };

        // check for repetitions
        if (fileHeaderComment.field.FieldRepetitions != null && fileHeaderComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileHeaderComment.Id));
            fileHeaderComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileHeaderComment, fieldData);
        }

        return fileHeaderComment;
    } 
}

internal HL7V24Field fileControlID;

public HL7V24Field FileControlID
{
    get
    {
        if (fileControlID != null)
        {
            return fileControlID;
        }

        fileControlID = new HL7V24Field
        {
            field = message[@"FHS"][11],
            Id = @"FHS.11",
            Type = @"Field",
            Position = @"FHS.11",
            Name = @"File Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to identify a particular file uniquely.  It can be echoed back in FHS-12-reference file control ID",
            Sample = @"",
        };

        // check for repetitions
        if (fileControlID.field.FieldRepetitions != null && fileControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileControlID.Id));
            fileControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(fileControlID, fieldData);
        }

        return fileControlID;
    } 
}

internal HL7V24Field referenceFileControlID;

public HL7V24Field ReferenceFileControlID
{
    get
    {
        if (referenceFileControlID != null)
        {
            return referenceFileControlID;
        }

        referenceFileControlID = new HL7V24Field
        {
            field = message[@"FHS"][12],
            Id = @"FHS.12",
            Type = @"Field",
            Position = @"FHS.12",
            Name = @"Reference File Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of FHS-11-file control ID when this file was originally transmitted.  Not present if this file is being transmitted for the first time",
            Sample = @"",
        };

        // check for repetitions
        if (referenceFileControlID.field.FieldRepetitions != null && referenceFileControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referenceFileControlID.Id));
            referenceFileControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(referenceFileControlID, fieldData);
        }

        return referenceFileControlID;
    } 
}
    }
}
