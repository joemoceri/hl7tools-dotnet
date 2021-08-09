using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentECR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ECR"; } }

        public string SegmentId { get { return @"ECR"; } }
        
        public string LongName { get { return @"Equipment Command Response"; } }
        
        public string Description { get { return @"The equipment command response segment contains the receiving components response to the previously received command."; } }
        
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
                            Description = @"This field identifies the response of the previously issued command.  Refer to User-defined Table 0387 – Command response for valid values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ECR.1.1",
                            Type = @"Component",
                            Position = @"ECR.1.1",
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
                            Id = @"ECR.1.2",
                            Type = @"Component",
                            Position = @"ECR.1.2",
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
                            Id = @"ECR.1.3",
                            Type = @"Component",
                            Position = @"ECR.1.3",
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
                            Id = @"ECR.1.4",
                            Type = @"Component",
                            Position = @"ECR.1.4",
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
                            Id = @"ECR.1.5",
                            Type = @"Component",
                            Position = @"ECR.1.5",
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
                            Id = @"ECR.1.6",
                            Type = @"Component",
                            Position = @"ECR.1.6",
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
                            Description = @"his field contains the date and time that the receiving component completed the requested command",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ECR.2.1",
                            Type = @"Component",
                            Position = @"ECR.2.1",
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
                            Id = @"ECR.2.2",
                            Type = @"Component",
                            Position = @"ECR.2.2",
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
                            Id = @"ECR.3",
                            Type = @"Field",
                            Position = @"ECR.3",
                            Name = @"Command Response Parameters",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies any associated parameters that relate to the returned response command message",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentECR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field commandResponse;

public HL7V24Field CommandResponse
{
    get
    {
        if (commandResponse != null)
        {
            return commandResponse;
        }

        commandResponse = new HL7V24Field
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
            Description = @"This field identifies the response of the previously issued command.  Refer to User-defined Table 0387 – Command response for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (commandResponse.field.FieldRepetitions != null && commandResponse.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(commandResponse.Id));
            commandResponse.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(commandResponse, fieldData);
        }

        return commandResponse;
    } 
}

internal HL7V24Field dateTimeCompleted;

public HL7V24Field DateTimeCompleted
{
    get
    {
        if (dateTimeCompleted != null)
        {
            return dateTimeCompleted;
        }

        dateTimeCompleted = new HL7V24Field
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
            Description = @"his field contains the date and time that the receiving component completed the requested command",
            Sample = @"",
        };

        // check for repetitions
        if (dateTimeCompleted.field.FieldRepetitions != null && dateTimeCompleted.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeCompleted.Id));
            dateTimeCompleted.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(dateTimeCompleted, fieldData);
        }

        return dateTimeCompleted;
    } 
}

internal HL7V24Field commandResponseParameters;

public HL7V24Field CommandResponseParameters
{
    get
    {
        if (commandResponseParameters != null)
        {
            return commandResponseParameters;
        }

        commandResponseParameters = new HL7V24Field
        {
            field = message[@"ECR"][3],
            Id = @"ECR.3",
            Type = @"Field",
            Position = @"ECR.3",
            Name = @"Command Response Parameters",
            Length = 65536,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies any associated parameters that relate to the returned response command message",
            Sample = @"",
        };

        // check for repetitions
        if (commandResponseParameters.field.FieldRepetitions != null && commandResponseParameters.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(commandResponseParameters.Id));
            commandResponseParameters.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(commandResponseParameters, fieldData);
        }

        return commandResponseParameters;
    } 
}
    }
}
