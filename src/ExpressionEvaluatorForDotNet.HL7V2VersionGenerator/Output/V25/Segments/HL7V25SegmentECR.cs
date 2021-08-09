using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentECR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ECR"; } }

        public string SegmentId { get { return @"ECR"; } }
        
        public string LongName { get { return @"Equipment Command Response"; } }
        
        public string Description { get { return @"The equipment command response segment contains the receiving component's response to the previously received command."; } }
        
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
                            Id = @"ECR.1",
                            Type = @"Field",
                            Position = @"ECR.1",
                            Name = @"Command Response",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0387",
                            TableName = @"Command response",
                            Description = @"This field identifies the response of the previously issued command. Refer to User-defined Table 0387 - Command response for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ECR.1.1",
                            Type = @"Component",
                            Position = @"ECR.1.1",
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
                            Id = @"ECR.1.2",
                            Type = @"Component",
                            Position = @"ECR.1.2",
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
                            Id = @"ECR.1.3",
                            Type = @"Component",
                            Position = @"ECR.1.3",
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
                            Id = @"ECR.1.4",
                            Type = @"Component",
                            Position = @"ECR.1.4",
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
                            Id = @"ECR.1.5",
                            Type = @"Component",
                            Position = @"ECR.1.5",
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
                            Id = @"ECR.1.6",
                            Type = @"Component",
                            Position = @"ECR.1.6",
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
                            Id = @"ECR.2",
                            Type = @"Field",
                            Position = @"ECR.2",
                            Name = @"Date/Time Completed",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time that the receiving component completed the requested command.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ECR.2.1",
                            Type = @"Component",
                            Position = @"ECR.2.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECR.2.2",
                            Type = @"Component",
                            Position = @"ECR.2.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision.

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECR.3",
                            Type = @"Field",
                            Position = @"ECR.3",
                            Name = @"Command Response Parameters",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies any associated parameters that relate to the returned response command message.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V25SegmentECR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field commandResponse;

public HL7V25Field CommandResponse
{
    get
    {
        if (commandResponse != null)
        {
            return commandResponse;
        }

        commandResponse = new HL7V25Field
        {
            field = message[@"ECR"][1],
            Id = @"ECR.1",
            Type = @"Field",
            Position = @"ECR.1",
            Name = @"Command Response",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0387",
            TableName = @"Command response",
            Description = @"This field identifies the response of the previously issued command. Refer to User-defined Table 0387 - Command response for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (commandResponse.field.FieldRepetitions != null && commandResponse.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(commandResponse.Id));
            commandResponse.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(commandResponse, fieldData);
        }

        return commandResponse;
    } 
}

internal HL7V25Field dateTimeCompleted;

public HL7V25Field DateTimeCompleted
{
    get
    {
        if (dateTimeCompleted != null)
        {
            return dateTimeCompleted;
        }

        dateTimeCompleted = new HL7V25Field
        {
            field = message[@"ECR"][2],
            Id = @"ECR.2",
            Type = @"Field",
            Position = @"ECR.2",
            Name = @"Date/Time Completed",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the receiving component completed the requested command.",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeCompleted.field.FieldRepetitions != null && dateTimeCompleted.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeCompleted.Id));
            dateTimeCompleted.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(dateTimeCompleted, fieldData);
        }

        return dateTimeCompleted;
    } 
}

internal HL7V25Field commandResponseParameters;

public HL7V25Field CommandResponseParameters
{
    get
    {
        if (commandResponseParameters != null)
        {
            return commandResponseParameters;
        }

        commandResponseParameters = new HL7V25Field
        {
            field = message[@"ECR"][3],
            Id = @"ECR.3",
            Type = @"Field",
            Position = @"ECR.3",
            Name = @"Command Response Parameters",
            Length = 65536,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies any associated parameters that relate to the returned response command message.",
            Sample = @"",
        };

        // check for repetitions
        if (commandResponseParameters.field.FieldRepetitions != null && commandResponseParameters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(commandResponseParameters.Id));
            commandResponseParameters.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(commandResponseParameters, fieldData);
        }

        return commandResponseParameters;
    } 
}
    }
}
