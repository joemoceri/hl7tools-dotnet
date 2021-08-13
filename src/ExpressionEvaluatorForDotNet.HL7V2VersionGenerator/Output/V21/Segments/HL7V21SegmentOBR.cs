using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentOBR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OBR"; } }

        public string SegmentId { get { return @"OBR"; } }
        
        public string LongName { get { return @"Observation Request"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentOBR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdObservationRequest;

public HL7V21Field SetIdObservationRequest
{
    get
    {
        if (_setIdObservationRequest != null)
        {
            return _setIdObservationRequest;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.1",
            Type = @"Field",
            Position = @"OBR.1",
            Name = @"Set Id - Observation Request",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdObservationRequest = new HL7V21Field
        {
            field = message[@"OBR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdObservationRequest.field.FieldRepetitions != null && _setIdObservationRequest.field.FieldRepetitions.Count > 0)
        {
            _setIdObservationRequest.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdObservationRequest, fieldData);
        }

        return _setIdObservationRequest;
    } 
}

internal HL7V21Field _placerOrder#;

public HL7V21Field PlacerOrder#
{
    get
    {
        if (_placerOrder# != null)
        {
            return _placerOrder#;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.2",
            Type = @"Field",
            Position = @"OBR.2",
            Name = @"Placer Order #",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _placerOrder# = new HL7V21Field
        {
            field = message[@"OBR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerOrder#.field.FieldRepetitions != null && _placerOrder#.field.FieldRepetitions.Count > 0)
        {
            _placerOrder#.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_placerOrder#, fieldData);
        }

        return _placerOrder#;
    } 
}

internal HL7V21Field _fillerOrder#;

public HL7V21Field FillerOrder#
{
    get
    {
        if (_fillerOrder# != null)
        {
            return _fillerOrder#;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.3",
            Type = @"Field",
            Position = @"OBR.3",
            Name = @"Filler Order #",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _fillerOrder# = new HL7V21Field
        {
            field = message[@"OBR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerOrder#.field.FieldRepetitions != null && _fillerOrder#.field.FieldRepetitions.Count > 0)
        {
            _fillerOrder#.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_fillerOrder#, fieldData);
        }

        return _fillerOrder#;
    } 
}

internal HL7V21Field _universalServiceIdent;

public HL7V21Field UniversalServiceIdent
{
    get
    {
        if (_universalServiceIdent != null)
        {
            return _universalServiceIdent;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.4",
            Type = @"Field",
            Position = @"OBR.4",
            Name = @"Universal Service Ident.",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.4.1",
                            Type = @"Component",
                            Position = @"OBR.4.1",
                            Name = @"Identifier",
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
                            Id = @"OBR.4.2",
                            Type = @"Component",
                            Position = @"OBR.4.2",
                            Name = @"Text",
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
                            Id = @"OBR.4.3",
                            Type = @"Component",
                            Position = @"OBR.4.3",
                            Name = @"Name Of Coding System",
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
                            Id = @"OBR.4.4",
                            Type = @"Component",
                            Position = @"OBR.4.4",
                            Name = @"Alternate Identifier",
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
                            Id = @"OBR.4.5",
                            Type = @"Component",
                            Position = @"OBR.4.5",
                            Name = @"Alternate Text",
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
                            Id = @"OBR.4.6",
                            Type = @"Component",
                            Position = @"OBR.4.6",
                            Name = @"Name Of Alternate Coding System",
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
                        }
        }

        _universalServiceIdent = new HL7V21Field
        {
            field = message[@"OBR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_universalServiceIdent.field.FieldRepetitions != null && _universalServiceIdent.field.FieldRepetitions.Count > 0)
        {
            _universalServiceIdent.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_universalServiceIdent, fieldData);
        }

        return _universalServiceIdent;
    } 
}

internal HL7V21Field _priority;

public HL7V21Field Priority
{
    get
    {
        if (_priority != null)
        {
            return _priority;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.5",
            Type = @"Field",
            Position = @"OBR.5",
            Name = @"Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _priority = new HL7V21Field
        {
            field = message[@"OBR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priority.field.FieldRepetitions != null && _priority.field.FieldRepetitions.Count > 0)
        {
            _priority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_priority, fieldData);
        }

        return _priority;
    } 
}

internal HL7V21Field _requestedDatetime;

public HL7V21Field RequestedDatetime
{
    get
    {
        if (_requestedDatetime != null)
        {
            return _requestedDatetime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.6",
            Type = @"Field",
            Position = @"OBR.6",
            Name = @"Requested Date-time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _requestedDatetime = new HL7V21Field
        {
            field = message[@"OBR"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDatetime.field.FieldRepetitions != null && _requestedDatetime.field.FieldRepetitions.Count > 0)
        {
            _requestedDatetime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_requestedDatetime, fieldData);
        }

        return _requestedDatetime;
    } 
}

internal HL7V21Field _observationDateTime;

public HL7V21Field ObservationDateTime
{
    get
    {
        if (_observationDateTime != null)
        {
            return _observationDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.7",
            Type = @"Field",
            Position = @"OBR.7",
            Name = @"Observation Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _observationDateTime = new HL7V21Field
        {
            field = message[@"OBR"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationDateTime.field.FieldRepetitions != null && _observationDateTime.field.FieldRepetitions.Count > 0)
        {
            _observationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_observationDateTime, fieldData);
        }

        return _observationDateTime;
    } 
}

internal HL7V21Field _observationEndDateTime;

public HL7V21Field ObservationEndDateTime
{
    get
    {
        if (_observationEndDateTime != null)
        {
            return _observationEndDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.8",
            Type = @"Field",
            Position = @"OBR.8",
            Name = @"Observation End Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _observationEndDateTime = new HL7V21Field
        {
            field = message[@"OBR"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationEndDateTime.field.FieldRepetitions != null && _observationEndDateTime.field.FieldRepetitions.Count > 0)
        {
            _observationEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_observationEndDateTime, fieldData);
        }

        return _observationEndDateTime;
    } 
}

internal HL7V21Field _collectionVolume;

public HL7V21Field CollectionVolume
{
    get
    {
        if (_collectionVolume != null)
        {
            return _collectionVolume;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.9",
            Type = @"Field",
            Position = @"OBR.9",
            Name = @"Collection Volume",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = @"0036",
            TableName = @"UNITS OF MEASURE - ISO528,1977",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _collectionVolume = new HL7V21Field
        {
            field = message[@"OBR"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_collectionVolume.field.FieldRepetitions != null && _collectionVolume.field.FieldRepetitions.Count > 0)
        {
            _collectionVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_collectionVolume, fieldData);
        }

        return _collectionVolume;
    } 
}

internal HL7V21Field _collectorIdentifier;

public HL7V21Field CollectorIdentifier
{
    get
    {
        if (_collectorIdentifier != null)
        {
            return _collectorIdentifier;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.10",
            Type = @"Field",
            Position = @"OBR.10",
            Name = @"Collector Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _collectorIdentifier = new HL7V21Field
        {
            field = message[@"OBR"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_collectorIdentifier.field.FieldRepetitions != null && _collectorIdentifier.field.FieldRepetitions.Count > 0)
        {
            _collectorIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_collectorIdentifier, fieldData);
        }

        return _collectorIdentifier;
    } 
}

internal HL7V21Field _specimenActionCode;

public HL7V21Field SpecimenActionCode
{
    get
    {
        if (_specimenActionCode != null)
        {
            return _specimenActionCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.11",
            Type = @"Field",
            Position = @"OBR.11",
            Name = @"Specimen Action Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0065",
            TableName = @"ACTION CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _specimenActionCode = new HL7V21Field
        {
            field = message[@"OBR"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenActionCode.field.FieldRepetitions != null && _specimenActionCode.field.FieldRepetitions.Count > 0)
        {
            _specimenActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_specimenActionCode, fieldData);
        }

        return _specimenActionCode;
    } 
}

internal HL7V21Field _dangerCode;

public HL7V21Field DangerCode
{
    get
    {
        if (_dangerCode != null)
        {
            return _dangerCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.12",
            Type = @"Field",
            Position = @"OBR.12",
            Name = @"Danger Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = @"0047",
            TableName = @"DANGER CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dangerCode = new HL7V21Field
        {
            field = message[@"OBR"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dangerCode.field.FieldRepetitions != null && _dangerCode.field.FieldRepetitions.Count > 0)
        {
            _dangerCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dangerCode, fieldData);
        }

        return _dangerCode;
    } 
}

internal HL7V21Field _relevantClinicalInfo;

public HL7V21Field RelevantClinicalInfo
{
    get
    {
        if (_relevantClinicalInfo != null)
        {
            return _relevantClinicalInfo;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.13",
            Type = @"Field",
            Position = @"OBR.13",
            Name = @"Relevant Clinical Info.",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _relevantClinicalInfo = new HL7V21Field
        {
            field = message[@"OBR"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relevantClinicalInfo.field.FieldRepetitions != null && _relevantClinicalInfo.field.FieldRepetitions.Count > 0)
        {
            _relevantClinicalInfo.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_relevantClinicalInfo, fieldData);
        }

        return _relevantClinicalInfo;
    } 
}

internal HL7V21Field _specimenReceivedDateTime;

public HL7V21Field SpecimenReceivedDateTime
{
    get
    {
        if (_specimenReceivedDateTime != null)
        {
            return _specimenReceivedDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.14",
            Type = @"Field",
            Position = @"OBR.14",
            Name = @"Specimen Received Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _specimenReceivedDateTime = new HL7V21Field
        {
            field = message[@"OBR"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenReceivedDateTime.field.FieldRepetitions != null && _specimenReceivedDateTime.field.FieldRepetitions.Count > 0)
        {
            _specimenReceivedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_specimenReceivedDateTime, fieldData);
        }

        return _specimenReceivedDateTime;
    } 
}

internal HL7V21Field _specimenSource;

public HL7V21Field SpecimenSource
{
    get
    {
        if (_specimenSource != null)
        {
            return _specimenSource;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.15",
            Type = @"Field",
            Position = @"OBR.15",
            Name = @"Specimen Source",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = @"0070",
            TableName = @"SOURCE OF SPECIMEN",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _specimenSource = new HL7V21Field
        {
            field = message[@"OBR"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenSource.field.FieldRepetitions != null && _specimenSource.field.FieldRepetitions.Count > 0)
        {
            _specimenSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_specimenSource, fieldData);
        }

        return _specimenSource;
    } 
}

internal HL7V21Field _orderingProvider;

public HL7V21Field OrderingProvider
{
    get
    {
        if (_orderingProvider != null)
        {
            return _orderingProvider;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.16",
            Type = @"Field",
            Position = @"OBR.16",
            Name = @"Ordering Provider",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _orderingProvider = new HL7V21Field
        {
            field = message[@"OBR"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderingProvider.field.FieldRepetitions != null && _orderingProvider.field.FieldRepetitions.Count > 0)
        {
            _orderingProvider.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_orderingProvider, fieldData);
        }

        return _orderingProvider;
    } 
}

internal HL7V21Field _orderCallbackPhoneNum;

public HL7V21Field OrderCallbackPhoneNum
{
    get
    {
        if (_orderCallbackPhoneNum != null)
        {
            return _orderCallbackPhoneNum;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.17",
            Type = @"Field",
            Position = @"OBR.17",
            Name = @"Order Call-back Phone Num",
            Length = 40,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _orderCallbackPhoneNum = new HL7V21Field
        {
            field = message[@"OBR"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderCallbackPhoneNum.field.FieldRepetitions != null && _orderCallbackPhoneNum.field.FieldRepetitions.Count > 0)
        {
            _orderCallbackPhoneNum.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_orderCallbackPhoneNum, fieldData);
        }

        return _orderCallbackPhoneNum;
    } 
}

internal HL7V21Field _placersField#1;

public HL7V21Field PlacersField#1
{
    get
    {
        if (_placersField#1 != null)
        {
            return _placersField#1;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.18",
            Type = @"Field",
            Position = @"OBR.18",
            Name = @"Placers Field #1",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _placersField#1 = new HL7V21Field
        {
            field = message[@"OBR"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placersField#1.field.FieldRepetitions != null && _placersField#1.field.FieldRepetitions.Count > 0)
        {
            _placersField#1.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_placersField#1, fieldData);
        }

        return _placersField#1;
    } 
}

internal HL7V21Field _placersField#2;

public HL7V21Field PlacersField#2
{
    get
    {
        if (_placersField#2 != null)
        {
            return _placersField#2;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.19",
            Type = @"Field",
            Position = @"OBR.19",
            Name = @"Placers Field #2",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _placersField#2 = new HL7V21Field
        {
            field = message[@"OBR"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placersField#2.field.FieldRepetitions != null && _placersField#2.field.FieldRepetitions.Count > 0)
        {
            _placersField#2.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_placersField#2, fieldData);
        }

        return _placersField#2;
    } 
}

internal HL7V21Field _fillersField#1;

public HL7V21Field FillersField#1
{
    get
    {
        if (_fillersField#1 != null)
        {
            return _fillersField#1;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.20",
            Type = @"Field",
            Position = @"OBR.20",
            Name = @"Fillers Field #1",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _fillersField#1 = new HL7V21Field
        {
            field = message[@"OBR"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillersField#1.field.FieldRepetitions != null && _fillersField#1.field.FieldRepetitions.Count > 0)
        {
            _fillersField#1.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_fillersField#1, fieldData);
        }

        return _fillersField#1;
    } 
}

internal HL7V21Field _fillersField#2;

public HL7V21Field FillersField#2
{
    get
    {
        if (_fillersField#2 != null)
        {
            return _fillersField#2;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.21",
            Type = @"Field",
            Position = @"OBR.21",
            Name = @"Fillers Field #2",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _fillersField#2 = new HL7V21Field
        {
            field = message[@"OBR"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillersField#2.field.FieldRepetitions != null && _fillersField#2.field.FieldRepetitions.Count > 0)
        {
            _fillersField#2.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_fillersField#2, fieldData);
        }

        return _fillersField#2;
    } 
}

internal HL7V21Field _resultsRptStatusChngDateT;

public HL7V21Field ResultsRptStatusChngDateT
{
    get
    {
        if (_resultsRptStatusChngDateT != null)
        {
            return _resultsRptStatusChngDateT;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.22",
            Type = @"Field",
            Position = @"OBR.22",
            Name = @"Results Rpt/Status Chng - Date/T",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _resultsRptStatusChngDateT = new HL7V21Field
        {
            field = message[@"OBR"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultsRptStatusChngDateT.field.FieldRepetitions != null && _resultsRptStatusChngDateT.field.FieldRepetitions.Count > 0)
        {
            _resultsRptStatusChngDateT.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_resultsRptStatusChngDateT, fieldData);
        }

        return _resultsRptStatusChngDateT;
    } 
}

internal HL7V21Field _chargeToPractice;

public HL7V21Field ChargeToPractice
{
    get
    {
        if (_chargeToPractice != null)
        {
            return _chargeToPractice;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.23",
            Type = @"Field",
            Position = @"OBR.23",
            Name = @"Charge To Practice",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _chargeToPractice = new HL7V21Field
        {
            field = message[@"OBR"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargeToPractice.field.FieldRepetitions != null && _chargeToPractice.field.FieldRepetitions.Count > 0)
        {
            _chargeToPractice.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_chargeToPractice, fieldData);
        }

        return _chargeToPractice;
    } 
}

internal HL7V21Field _diagnosticServSectId;

public HL7V21Field DiagnosticServSectId
{
    get
    {
        if (_diagnosticServSectId != null)
        {
            return _diagnosticServSectId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.24",
            Type = @"Field",
            Position = @"OBR.24",
            Name = @"Diagnostic Serv Sect Id",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0074",
            TableName = @"DIAGNOSTIC SERVICE SECTION ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _diagnosticServSectId = new HL7V21Field
        {
            field = message[@"OBR"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticServSectId.field.FieldRepetitions != null && _diagnosticServSectId.field.FieldRepetitions.Count > 0)
        {
            _diagnosticServSectId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_diagnosticServSectId, fieldData);
        }

        return _diagnosticServSectId;
    } 
}

internal HL7V21Field _resultStatus;

public HL7V21Field ResultStatus
{
    get
    {
        if (_resultStatus != null)
        {
            return _resultStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.25",
            Type = @"Field",
            Position = @"OBR.25",
            Name = @"Result Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0123",
            TableName = @"RESULT STATUS - OBR",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _resultStatus = new HL7V21Field
        {
            field = message[@"OBR"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultStatus.field.FieldRepetitions != null && _resultStatus.field.FieldRepetitions.Count > 0)
        {
            _resultStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_resultStatus, fieldData);
        }

        return _resultStatus;
    } 
}

internal HL7V21Field _linkedResults;

public HL7V21Field LinkedResults
{
    get
    {
        if (_linkedResults != null)
        {
            return _linkedResults;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.26",
            Type = @"Field",
            Position = @"OBR.26",
            Name = @"Linked Results",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.26.1",
                            Type = @"Component",
                            Position = @"OBR.26.1",
                            Name = @"Identifier",
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
                            Id = @"OBR.26.2",
                            Type = @"Component",
                            Position = @"OBR.26.2",
                            Name = @"Text",
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
                            Id = @"OBR.26.3",
                            Type = @"Component",
                            Position = @"OBR.26.3",
                            Name = @"Name Of Coding System",
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
                            Id = @"OBR.26.4",
                            Type = @"Component",
                            Position = @"OBR.26.4",
                            Name = @"Alternate Identifier",
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
                            Id = @"OBR.26.5",
                            Type = @"Component",
                            Position = @"OBR.26.5",
                            Name = @"Alternate Text",
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
                            Id = @"OBR.26.6",
                            Type = @"Component",
                            Position = @"OBR.26.6",
                            Name = @"Name Of Alternate Coding System",
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
                        }
        }

        _linkedResults = new HL7V21Field
        {
            field = message[@"OBR"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_linkedResults.field.FieldRepetitions != null && _linkedResults.field.FieldRepetitions.Count > 0)
        {
            _linkedResults.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_linkedResults, fieldData);
        }

        return _linkedResults;
    } 
}

internal HL7V21Field _quantityTiming;

public HL7V21Field QuantityTiming
{
    get
    {
        if (_quantityTiming != null)
        {
            return _quantityTiming;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.27",
            Type = @"Field",
            Position = @"OBR.27",
            Name = @"Quantity/Timing",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _quantityTiming = new HL7V21Field
        {
            field = message[@"OBR"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityTiming.field.FieldRepetitions != null && _quantityTiming.field.FieldRepetitions.Count > 0)
        {
            _quantityTiming.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_quantityTiming, fieldData);
        }

        return _quantityTiming;
    } 
}

internal HL7V21Field _resultCopiesTo;

public HL7V21Field ResultCopiesTo
{
    get
    {
        if (_resultCopiesTo != null)
        {
            return _resultCopiesTo;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.28",
            Type = @"Field",
            Position = @"OBR.28",
            Name = @"Result Copies To",
            Length = 80,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _resultCopiesTo = new HL7V21Field
        {
            field = message[@"OBR"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultCopiesTo.field.FieldRepetitions != null && _resultCopiesTo.field.FieldRepetitions.Count > 0)
        {
            _resultCopiesTo.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_resultCopiesTo, fieldData);
        }

        return _resultCopiesTo;
    } 
}

internal HL7V21Field _parentAccession#;

public HL7V21Field ParentAccession#
{
    get
    {
        if (_parentAccession# != null)
        {
            return _parentAccession#;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.29",
            Type = @"Field",
            Position = @"OBR.29",
            Name = @"Parent Accession #",
            Length = 150,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _parentAccession# = new HL7V21Field
        {
            field = message[@"OBR"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_parentAccession#.field.FieldRepetitions != null && _parentAccession#.field.FieldRepetitions.Count > 0)
        {
            _parentAccession#.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_parentAccession#, fieldData);
        }

        return _parentAccession#;
    } 
}

internal HL7V21Field _transportationMode;

public HL7V21Field TransportationMode
{
    get
    {
        if (_transportationMode != null)
        {
            return _transportationMode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.30",
            Type = @"Field",
            Position = @"OBR.30",
            Name = @"Transportation Mode",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0124",
            TableName = @"TRANSPORTATION MODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _transportationMode = new HL7V21Field
        {
            field = message[@"OBR"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transportationMode.field.FieldRepetitions != null && _transportationMode.field.FieldRepetitions.Count > 0)
        {
            _transportationMode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transportationMode, fieldData);
        }

        return _transportationMode;
    } 
}

internal HL7V21Field _reasonForStudy;

public HL7V21Field ReasonForStudy
{
    get
    {
        if (_reasonForStudy != null)
        {
            return _reasonForStudy;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.31",
            Type = @"Field",
            Position = @"OBR.31",
            Name = @"Reason For Study",
            Length = 300,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.31.1",
                            Type = @"Component",
                            Position = @"OBR.31.1",
                            Name = @"Identifier",
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
                            Id = @"OBR.31.2",
                            Type = @"Component",
                            Position = @"OBR.31.2",
                            Name = @"Text",
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
                            Id = @"OBR.31.3",
                            Type = @"Component",
                            Position = @"OBR.31.3",
                            Name = @"Name Of Coding System",
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
                            Id = @"OBR.31.4",
                            Type = @"Component",
                            Position = @"OBR.31.4",
                            Name = @"Alternate Identifier",
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
                            Id = @"OBR.31.5",
                            Type = @"Component",
                            Position = @"OBR.31.5",
                            Name = @"Alternate Text",
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
                            Id = @"OBR.31.6",
                            Type = @"Component",
                            Position = @"OBR.31.6",
                            Name = @"Name Of Alternate Coding System",
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
                        }
        }

        _reasonForStudy = new HL7V21Field
        {
            field = message[@"OBR"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reasonForStudy.field.FieldRepetitions != null && _reasonForStudy.field.FieldRepetitions.Count > 0)
        {
            _reasonForStudy.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_reasonForStudy, fieldData);
        }

        return _reasonForStudy;
    } 
}

internal HL7V21Field _principalResultInterpreter;

public HL7V21Field PrincipalResultInterpreter
{
    get
    {
        if (_principalResultInterpreter != null)
        {
            return _principalResultInterpreter;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.32",
            Type = @"Field",
            Position = @"OBR.32",
            Name = @"Principal Result Interpreter",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _principalResultInterpreter = new HL7V21Field
        {
            field = message[@"OBR"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_principalResultInterpreter.field.FieldRepetitions != null && _principalResultInterpreter.field.FieldRepetitions.Count > 0)
        {
            _principalResultInterpreter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_principalResultInterpreter, fieldData);
        }

        return _principalResultInterpreter;
    } 
}

internal HL7V21Field _assistantResultInterpreter;

public HL7V21Field AssistantResultInterpreter
{
    get
    {
        if (_assistantResultInterpreter != null)
        {
            return _assistantResultInterpreter;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.33",
            Type = @"Field",
            Position = @"OBR.33",
            Name = @"Assistant Result Interpreter",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _assistantResultInterpreter = new HL7V21Field
        {
            field = message[@"OBR"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assistantResultInterpreter.field.FieldRepetitions != null && _assistantResultInterpreter.field.FieldRepetitions.Count > 0)
        {
            _assistantResultInterpreter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_assistantResultInterpreter, fieldData);
        }

        return _assistantResultInterpreter;
    } 
}

internal HL7V21Field _technician;

public HL7V21Field Technician
{
    get
    {
        if (_technician != null)
        {
            return _technician;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.34",
            Type = @"Field",
            Position = @"OBR.34",
            Name = @"Technician",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _technician = new HL7V21Field
        {
            field = message[@"OBR"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_technician.field.FieldRepetitions != null && _technician.field.FieldRepetitions.Count > 0)
        {
            _technician.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_technician, fieldData);
        }

        return _technician;
    } 
}

internal HL7V21Field _transcriptionist;

public HL7V21Field Transcriptionist
{
    get
    {
        if (_transcriptionist != null)
        {
            return _transcriptionist;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.35",
            Type = @"Field",
            Position = @"OBR.35",
            Name = @"Transcriptionist",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _transcriptionist = new HL7V21Field
        {
            field = message[@"OBR"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transcriptionist.field.FieldRepetitions != null && _transcriptionist.field.FieldRepetitions.Count > 0)
        {
            _transcriptionist.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transcriptionist, fieldData);
        }

        return _transcriptionist;
    } 
}

internal HL7V21Field _scheduledDateTime;

public HL7V21Field ScheduledDateTime
{
    get
    {
        if (_scheduledDateTime != null)
        {
            return _scheduledDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBR.36",
            Type = @"Field",
            Position = @"OBR.36",
            Name = @"Scheduled - Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _scheduledDateTime = new HL7V21Field
        {
            field = message[@"OBR"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduledDateTime.field.FieldRepetitions != null && _scheduledDateTime.field.FieldRepetitions.Count > 0)
        {
            _scheduledDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_scheduledDateTime, fieldData);
        }

        return _scheduledDateTime;
    } 
}
    }
}
