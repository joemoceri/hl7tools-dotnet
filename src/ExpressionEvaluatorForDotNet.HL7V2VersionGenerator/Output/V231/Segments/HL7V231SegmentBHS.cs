using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentBHS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BHS"; } }

        public string SegmentId { get { return @"BHS"; } }
        
        public string LongName { get { return @"Batch Header Segment"; } }
        
        public string Description { get { return @"The BHS segment defines the start of a batch."; } }
        
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
                            Id = @"BHS.1",
                            Type = @"Field",
                            Position = @"BHS.1",
                            Name = @"Batch Field Separator",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the separator between the segment ID and the first real field, BHS-2-batch encoding characters.  As such it serves as the separator and defines the character to be used as a separator for the rest of the message.  Recommended value is |,(ASCII 124).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.2",
                            Type = @"Field",
                            Position = @"BHS.2",
                            Name = @"Batch Encoding Characters",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the four characters in the following order:  the component separator, repetition separator, escape characters, and subcomponent separator.  Recommended values are ^~\&, (ASCII 94, 126, 92, and 38, respectively.  See Section 2.7, “MESSAGE DELIMITERS.” ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.3",
                            Type = @"Field",
                            Position = @"BHS.3",
                            Name = @"Batch Sending Application",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.4",
                            Type = @"Field",
                            Position = @"BHS.4",
                            Name = @"Batch Sending Facility",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the address of one of several occurrences of the same application within the sending system.  Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component.  Entirely user-defined",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.5",
                            Type = @"Field",
                            Position = @"BHS.5",
                            Name = @"Batch Receiving Application",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the receiving applications among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.6",
                            Type = @"Field",
                            Position = @"BHS.6",
                            Name = @"Batch Receiving Facility",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations.  See comments BSH-4-batch sending facility.  Entirely site-defined",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.7",
                            Type = @"Field",
                            Position = @"BHS.7",
                            Name = @"Batch Creation Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This  field contains the date/time that the sending system created the message.  If the time zone is specified, it will be used throughout the message as the default time zone. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BHS.7.1",
                            Type = @"Component",
                            Position = @"BHS.7.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.8",
                            Type = @"Field",
                            Position = @"BHS.8",
                            Name = @"Batch Security",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"In some applications of HL7, this field is used to implement security features.  Its use is not yet further specified",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.9",
                            Type = @"Field",
                            Position = @"BHS.9",
                            Name = @"Batch Name/ID/Type",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field can be used by the application processing the batch.  It can have extra components if needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.10",
                            Type = @"Field",
                            Position = @"BHS.10",
                            Name = @"Batch Comment",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a comment field that is not further defined in the HL7 protocol",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.11",
                            Type = @"Field",
                            Position = @"BHS.11",
                            Name = @"Batch Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to uniquely identify a particular batch.  It can be echoed back in BHS-12reference batch control ID if an answering batch is needed",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.12",
                            Type = @"Field",
                            Position = @"BHS.12",
                            Name = @"Reference Batch Control ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the value of BHS-11-batch control ID when this batch was originally transmitted.  Not present if this batch is being sent for the first time.  See definition for BHS-11-batch control ID",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V231SegmentBHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field batchFieldSeparator;

public HL7V231Field BatchFieldSeparator
{
    get
    {
        if (batchFieldSeparator != null)
        {
            return batchFieldSeparator;
        }

        batchFieldSeparator = new HL7V231Field
        {
            field = message[@"BHS"][1],
            Id = @"BHS.1",
            Type = @"Field",
            Position = @"BHS.1",
            Name = @"Batch Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the separator between the segment ID and the first real field, BHS-2-batch encoding characters.  As such it serves as the separator and defines the character to be used as a separator for the rest of the message.  Recommended value is |,(ASCII 124).",
            Sample = @"",
        };

        // check for repetitions
        if (batchFieldSeparator.field.FieldRepetitions != null && batchFieldSeparator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchFieldSeparator.Id));
            batchFieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchFieldSeparator, fieldData);
        }

        return batchFieldSeparator;
    } 
}

internal HL7V231Field batchEncodingCharacters;

public HL7V231Field BatchEncodingCharacters
{
    get
    {
        if (batchEncodingCharacters != null)
        {
            return batchEncodingCharacters;
        }

        batchEncodingCharacters = new HL7V231Field
        {
            field = message[@"BHS"][2],
            Id = @"BHS.2",
            Type = @"Field",
            Position = @"BHS.2",
            Name = @"Batch Encoding Characters",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the four characters in the following order:  the component separator, repetition separator, escape characters, and subcomponent separator.  Recommended values are ^~\&, (ASCII 94, 126, 92, and 38, respectively.  See Section 2.7, “MESSAGE DELIMITERS.” ",
            Sample = @"",
        };

        // check for repetitions
        if (batchEncodingCharacters.field.FieldRepetitions != null && batchEncodingCharacters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchEncodingCharacters.Id));
            batchEncodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchEncodingCharacters, fieldData);
        }

        return batchEncodingCharacters;
    } 
}

internal HL7V231Field batchSendingApplication;

public HL7V231Field BatchSendingApplication
{
    get
    {
        if (batchSendingApplication != null)
        {
            return batchSendingApplication;
        }

        batchSendingApplication = new HL7V231Field
        {
            field = message[@"BHS"][3],
            Id = @"BHS.3",
            Type = @"Field",
            Position = @"BHS.3",
            Name = @"Batch Sending Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined",
            Sample = @"",
        };

        // check for repetitions
        if (batchSendingApplication.field.FieldRepetitions != null && batchSendingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchSendingApplication.Id));
            batchSendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchSendingApplication, fieldData);
        }

        return batchSendingApplication;
    } 
}

internal HL7V231Field batchSendingFacility;

public HL7V231Field BatchSendingFacility
{
    get
    {
        if (batchSendingFacility != null)
        {
            return batchSendingFacility;
        }

        batchSendingFacility = new HL7V231Field
        {
            field = message[@"BHS"][4],
            Id = @"BHS.4",
            Type = @"Field",
            Position = @"BHS.4",
            Name = @"Batch Sending Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of one of several occurrences of the same application within the sending system.  Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component.  Entirely user-defined",
            Sample = @"",
        };

        // check for repetitions
        if (batchSendingFacility.field.FieldRepetitions != null && batchSendingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchSendingFacility.Id));
            batchSendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchSendingFacility, fieldData);
        }

        return batchSendingFacility;
    } 
}

internal HL7V231Field batchReceivingApplication;

public HL7V231Field BatchReceivingApplication
{
    get
    {
        if (batchReceivingApplication != null)
        {
            return batchReceivingApplication;
        }

        batchReceivingApplication = new HL7V231Field
        {
            field = message[@"BHS"][5],
            Id = @"BHS.5",
            Type = @"Field",
            Position = @"BHS.5",
            Name = @"Batch Receiving Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the receiving applications among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined",
            Sample = @"",
        };

        // check for repetitions
        if (batchReceivingApplication.field.FieldRepetitions != null && batchReceivingApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchReceivingApplication.Id));
            batchReceivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchReceivingApplication, fieldData);
        }

        return batchReceivingApplication;
    } 
}

internal HL7V231Field batchReceivingFacility;

public HL7V231Field BatchReceivingFacility
{
    get
    {
        if (batchReceivingFacility != null)
        {
            return batchReceivingFacility;
        }

        batchReceivingFacility = new HL7V231Field
        {
            field = message[@"BHS"][6],
            Id = @"BHS.6",
            Type = @"Field",
            Position = @"BHS.6",
            Name = @"Batch Receiving Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations.  See comments BSH-4-batch sending facility.  Entirely site-defined",
            Sample = @"",
        };

        // check for repetitions
        if (batchReceivingFacility.field.FieldRepetitions != null && batchReceivingFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchReceivingFacility.Id));
            batchReceivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchReceivingFacility, fieldData);
        }

        return batchReceivingFacility;
    } 
}

internal HL7V231Field batchCreationDateTime;

public HL7V231Field BatchCreationDateTime
{
    get
    {
        if (batchCreationDateTime != null)
        {
            return batchCreationDateTime;
        }

        batchCreationDateTime = new HL7V231Field
        {
            field = message[@"BHS"][7],
            Id = @"BHS.7",
            Type = @"Field",
            Position = @"BHS.7",
            Name = @"Batch Creation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This  field contains the date/time that the sending system created the message.  If the time zone is specified, it will be used throughout the message as the default time zone. ",
            Sample = @"",
        };

        // check for repetitions
        if (batchCreationDateTime.field.FieldRepetitions != null && batchCreationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchCreationDateTime.Id));
            batchCreationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchCreationDateTime, fieldData);
        }

        return batchCreationDateTime;
    } 
}

internal HL7V231Field batchSecurity;

public HL7V231Field BatchSecurity
{
    get
    {
        if (batchSecurity != null)
        {
            return batchSecurity;
        }

        batchSecurity = new HL7V231Field
        {
            field = message[@"BHS"][8],
            Id = @"BHS.8",
            Type = @"Field",
            Position = @"BHS.8",
            Name = @"Batch Security",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"In some applications of HL7, this field is used to implement security features.  Its use is not yet further specified",
            Sample = @"",
        };

        // check for repetitions
        if (batchSecurity.field.FieldRepetitions != null && batchSecurity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchSecurity.Id));
            batchSecurity.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchSecurity, fieldData);
        }

        return batchSecurity;
    } 
}

internal HL7V231Field batchNameIDType;

public HL7V231Field BatchNameIDType
{
    get
    {
        if (batchNameIDType != null)
        {
            return batchNameIDType;
        }

        batchNameIDType = new HL7V231Field
        {
            field = message[@"BHS"][9],
            Id = @"BHS.9",
            Type = @"Field",
            Position = @"BHS.9",
            Name = @"Batch Name/ID/Type",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field can be used by the application processing the batch.  It can have extra components if needed.",
            Sample = @"",
        };

        // check for repetitions
        if (batchNameIDType.field.FieldRepetitions != null && batchNameIDType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchNameIDType.Id));
            batchNameIDType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchNameIDType, fieldData);
        }

        return batchNameIDType;
    } 
}

internal HL7V231Field batchComment;

public HL7V231Field BatchComment
{
    get
    {
        if (batchComment != null)
        {
            return batchComment;
        }

        batchComment = new HL7V231Field
        {
            field = message[@"BHS"][10],
            Id = @"BHS.10",
            Type = @"Field",
            Position = @"BHS.10",
            Name = @"Batch Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is a comment field that is not further defined in the HL7 protocol",
            Sample = @"",
        };

        // check for repetitions
        if (batchComment.field.FieldRepetitions != null && batchComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchComment.Id));
            batchComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchComment, fieldData);
        }

        return batchComment;
    } 
}

internal HL7V231Field batchControlID;

public HL7V231Field BatchControlID
{
    get
    {
        if (batchControlID != null)
        {
            return batchControlID;
        }

        batchControlID = new HL7V231Field
        {
            field = message[@"BHS"][11],
            Id = @"BHS.11",
            Type = @"Field",
            Position = @"BHS.11",
            Name = @"Batch Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to uniquely identify a particular batch.  It can be echoed back in BHS-12reference batch control ID if an answering batch is needed",
            Sample = @"",
        };

        // check for repetitions
        if (batchControlID.field.FieldRepetitions != null && batchControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(batchControlID.Id));
            batchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(batchControlID, fieldData);
        }

        return batchControlID;
    } 
}

internal HL7V231Field referenceBatchControlID;

public HL7V231Field ReferenceBatchControlID
{
    get
    {
        if (referenceBatchControlID != null)
        {
            return referenceBatchControlID;
        }

        referenceBatchControlID = new HL7V231Field
        {
            field = message[@"BHS"][12],
            Id = @"BHS.12",
            Type = @"Field",
            Position = @"BHS.12",
            Name = @"Reference Batch Control ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value of BHS-11-batch control ID when this batch was originally transmitted.  Not present if this batch is being sent for the first time.  See definition for BHS-11-batch control ID",
            Sample = @"",
        };

        // check for repetitions
        if (referenceBatchControlID.field.FieldRepetitions != null && referenceBatchControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referenceBatchControlID.Id));
            referenceBatchControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(referenceBatchControlID, fieldData);
        }

        return referenceBatchControlID;
    } 
}
    }
}
