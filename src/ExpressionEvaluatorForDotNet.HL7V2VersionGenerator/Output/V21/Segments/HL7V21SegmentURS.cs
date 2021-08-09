using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentURS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"URS"; } }

        public string SegmentId { get { return @"URS"; } }
        
        public string LongName { get { return @"Unsolicited Selection"; } }
        
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
                            Id = @"URS.1",
                            Type = @"Field",
                            Position = @"URS.1",
                            Name = @"R/U Where Subject Definition",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
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
                            Id = @"URS.2",
                            Type = @"Field",
                            Position = @"URS.2",
                            Name = @"R/U When Data Start Date/Time",
                            Length = 19,
                            Usage = @"O",
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
                            Id = @"URS.3",
                            Type = @"Field",
                            Position = @"URS.3",
                            Name = @"R/U When Data End Date/Time",
                            Length = 19,
                            Usage = @"O",
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
                            Id = @"URS.4",
                            Type = @"Field",
                            Position = @"URS.4",
                            Name = @"R/U What User Qualifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
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
                            Id = @"URS.5",
                            Type = @"Field",
                            Position = @"URS.5",
                            Name = @"R/U Other Results Subject Defini",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentURS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field rUWhereSubjectDefinition;

public HL7V21Field RUWhereSubjectDefinition
{
    get
    {
        if (rUWhereSubjectDefinition != null)
        {
            return rUWhereSubjectDefinition;
        }

        rUWhereSubjectDefinition = new HL7V21Field
        {
            field = message[@"URS"][1],
            Id = @"URS.1",
            Type = @"Field",
            Position = @"URS.1",
            Name = @"R/U Where Subject Definition",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (rUWhereSubjectDefinition.field.FieldRepetitions != null && rUWhereSubjectDefinition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhereSubjectDefinition.Id));
            rUWhereSubjectDefinition.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(rUWhereSubjectDefinition, fieldData);
        }

        return rUWhereSubjectDefinition;
    } 
}

internal HL7V21Field rUWhenDataStartDateTime;

public HL7V21Field RUWhenDataStartDateTime
{
    get
    {
        if (rUWhenDataStartDateTime != null)
        {
            return rUWhenDataStartDateTime;
        }

        rUWhenDataStartDateTime = new HL7V21Field
        {
            field = message[@"URS"][2],
            Id = @"URS.2",
            Type = @"Field",
            Position = @"URS.2",
            Name = @"R/U When Data Start Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (rUWhenDataStartDateTime.field.FieldRepetitions != null && rUWhenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhenDataStartDateTime.Id));
            rUWhenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(rUWhenDataStartDateTime, fieldData);
        }

        return rUWhenDataStartDateTime;
    } 
}

internal HL7V21Field rUWhenDataEndDateTime;

public HL7V21Field RUWhenDataEndDateTime
{
    get
    {
        if (rUWhenDataEndDateTime != null)
        {
            return rUWhenDataEndDateTime;
        }

        rUWhenDataEndDateTime = new HL7V21Field
        {
            field = message[@"URS"][3],
            Id = @"URS.3",
            Type = @"Field",
            Position = @"URS.3",
            Name = @"R/U When Data End Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (rUWhenDataEndDateTime.field.FieldRepetitions != null && rUWhenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhenDataEndDateTime.Id));
            rUWhenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(rUWhenDataEndDateTime, fieldData);
        }

        return rUWhenDataEndDateTime;
    } 
}

internal HL7V21Field rUWhatUserQualifier;

public HL7V21Field RUWhatUserQualifier
{
    get
    {
        if (rUWhatUserQualifier != null)
        {
            return rUWhatUserQualifier;
        }

        rUWhatUserQualifier = new HL7V21Field
        {
            field = message[@"URS"][4],
            Id = @"URS.4",
            Type = @"Field",
            Position = @"URS.4",
            Name = @"R/U What User Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (rUWhatUserQualifier.field.FieldRepetitions != null && rUWhatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUWhatUserQualifier.Id));
            rUWhatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(rUWhatUserQualifier, fieldData);
        }

        return rUWhatUserQualifier;
    } 
}

internal HL7V21Field rUOtherResultsSubjectDefini;

public HL7V21Field RUOtherResultsSubjectDefini
{
    get
    {
        if (rUOtherResultsSubjectDefini != null)
        {
            return rUOtherResultsSubjectDefini;
        }

        rUOtherResultsSubjectDefini = new HL7V21Field
        {
            field = message[@"URS"][5],
            Id = @"URS.5",
            Type = @"Field",
            Position = @"URS.5",
            Name = @"R/U Other Results Subject Defini",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (rUOtherResultsSubjectDefini.field.FieldRepetitions != null && rUOtherResultsSubjectDefini.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(rUOtherResultsSubjectDefini.Id));
            rUOtherResultsSubjectDefini.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(rUOtherResultsSubjectDefini, fieldData);
        }

        return rUOtherResultsSubjectDefini;
    } 
}
    }
}
