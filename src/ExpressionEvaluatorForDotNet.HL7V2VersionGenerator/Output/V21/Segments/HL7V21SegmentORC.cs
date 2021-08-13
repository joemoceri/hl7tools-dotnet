using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentORC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ORC"; } }

        public string SegmentId { get { return @"ORC"; } }
        
        public string LongName { get { return @"Common Order"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentORC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _orderControl;

public HL7V21Field OrderControl
{
    get
    {
        if (_orderControl != null)
        {
            return _orderControl;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.1",
            Type = @"Field",
            Position = @"ORC.1",
            Name = @"Order Control",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0119",
            TableName = @"ORDER CONTROL",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _orderControl = new HL7V21Field
        {
            field = message[@"ORC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderControl.field.FieldRepetitions != null && _orderControl.field.FieldRepetitions.Count > 0)
        {
            _orderControl.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_orderControl, fieldData);
        }

        return _orderControl;
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
            Id = @"ORC.2",
            Type = @"Field",
            Position = @"ORC.2",
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
            field = message[@"ORC"][2],
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
            Id = @"ORC.3",
            Type = @"Field",
            Position = @"ORC.3",
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
            field = message[@"ORC"][3],
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

internal HL7V21Field _placerGroup#;

public HL7V21Field PlacerGroup#
{
    get
    {
        if (_placerGroup# != null)
        {
            return _placerGroup#;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.4",
            Type = @"Field",
            Position = @"ORC.4",
            Name = @"Placer Group #",
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

        _placerGroup# = new HL7V21Field
        {
            field = message[@"ORC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerGroup#.field.FieldRepetitions != null && _placerGroup#.field.FieldRepetitions.Count > 0)
        {
            _placerGroup#.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_placerGroup#, fieldData);
        }

        return _placerGroup#;
    } 
}

internal HL7V21Field _orderStatus;

public HL7V21Field OrderStatus
{
    get
    {
        if (_orderStatus != null)
        {
            return _orderStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.5",
            Type = @"Field",
            Position = @"ORC.5",
            Name = @"Order Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0038",
            TableName = @"ORDER STATUS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _orderStatus = new HL7V21Field
        {
            field = message[@"ORC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderStatus.field.FieldRepetitions != null && _orderStatus.field.FieldRepetitions.Count > 0)
        {
            _orderStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_orderStatus, fieldData);
        }

        return _orderStatus;
    } 
}

internal HL7V21Field _responseFlag;

public HL7V21Field ResponseFlag
{
    get
    {
        if (_responseFlag != null)
        {
            return _responseFlag;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.6",
            Type = @"Field",
            Position = @"ORC.6",
            Name = @"Response Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0121",
            TableName = @"RESPONSE FLAG",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _responseFlag = new HL7V21Field
        {
            field = message[@"ORC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_responseFlag.field.FieldRepetitions != null && _responseFlag.field.FieldRepetitions.Count > 0)
        {
            _responseFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_responseFlag, fieldData);
        }

        return _responseFlag;
    } 
}

internal HL7V21Field _timingQuantity;

public HL7V21Field TimingQuantity
{
    get
    {
        if (_timingQuantity != null)
        {
            return _timingQuantity;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.7",
            Type = @"Field",
            Position = @"ORC.7",
            Name = @"Timing/Quantity",
            Length = 200,
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

        _timingQuantity = new HL7V21Field
        {
            field = message[@"ORC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_timingQuantity.field.FieldRepetitions != null && _timingQuantity.field.FieldRepetitions.Count > 0)
        {
            _timingQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_timingQuantity, fieldData);
        }

        return _timingQuantity;
    } 
}

internal HL7V21Field _parent;

public HL7V21Field Parent
{
    get
    {
        if (_parent != null)
        {
            return _parent;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.8",
            Type = @"Field",
            Position = @"ORC.8",
            Name = @"Parent",
            Length = 200,
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

        _parent = new HL7V21Field
        {
            field = message[@"ORC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_parent.field.FieldRepetitions != null && _parent.field.FieldRepetitions.Count > 0)
        {
            _parent.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_parent, fieldData);
        }

        return _parent;
    } 
}

internal HL7V21Field _dateTimeOfTransaction;

public HL7V21Field DateTimeOfTransaction
{
    get
    {
        if (_dateTimeOfTransaction != null)
        {
            return _dateTimeOfTransaction;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.9",
            Type = @"Field",
            Position = @"ORC.9",
            Name = @"Date/Time Of Transaction",
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

        _dateTimeOfTransaction = new HL7V21Field
        {
            field = message[@"ORC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfTransaction.field.FieldRepetitions != null && _dateTimeOfTransaction.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfTransaction.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dateTimeOfTransaction, fieldData);
        }

        return _dateTimeOfTransaction;
    } 
}

internal HL7V21Field _enteredBy;

public HL7V21Field EnteredBy
{
    get
    {
        if (_enteredBy != null)
        {
            return _enteredBy;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.10",
            Type = @"Field",
            Position = @"ORC.10",
            Name = @"Entered By",
            Length = 80,
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

        _enteredBy = new HL7V21Field
        {
            field = message[@"ORC"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_enteredBy.field.FieldRepetitions != null && _enteredBy.field.FieldRepetitions.Count > 0)
        {
            _enteredBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_enteredBy, fieldData);
        }

        return _enteredBy;
    } 
}

internal HL7V21Field _verifiedBy;

public HL7V21Field VerifiedBy
{
    get
    {
        if (_verifiedBy != null)
        {
            return _verifiedBy;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.11",
            Type = @"Field",
            Position = @"ORC.11",
            Name = @"Verified By",
            Length = 80,
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

        _verifiedBy = new HL7V21Field
        {
            field = message[@"ORC"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verifiedBy.field.FieldRepetitions != null && _verifiedBy.field.FieldRepetitions.Count > 0)
        {
            _verifiedBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_verifiedBy, fieldData);
        }

        return _verifiedBy;
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
            Id = @"ORC.12",
            Type = @"Field",
            Position = @"ORC.12",
            Name = @"Ordering Provider",
            Length = 80,
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

        _orderingProvider = new HL7V21Field
        {
            field = message[@"ORC"][12],
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

internal HL7V21Field _enterersLocation;

public HL7V21Field EnterersLocation
{
    get
    {
        if (_enterersLocation != null)
        {
            return _enterersLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.13",
            Type = @"Field",
            Position = @"ORC.13",
            Name = @"Enterer's Location",
            Length = 80,
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

        _enterersLocation = new HL7V21Field
        {
            field = message[@"ORC"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_enterersLocation.field.FieldRepetitions != null && _enterersLocation.field.FieldRepetitions.Count > 0)
        {
            _enterersLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_enterersLocation, fieldData);
        }

        return _enterersLocation;
    } 
}

internal HL7V21Field _callBackPhoneNumber;

public HL7V21Field CallBackPhoneNumber
{
    get
    {
        if (_callBackPhoneNumber != null)
        {
            return _callBackPhoneNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORC.14",
            Type = @"Field",
            Position = @"ORC.14",
            Name = @"Call Back Phone Number",
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

        _callBackPhoneNumber = new HL7V21Field
        {
            field = message[@"ORC"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_callBackPhoneNumber.field.FieldRepetitions != null && _callBackPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _callBackPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_callBackPhoneNumber, fieldData);
        }

        return _callBackPhoneNumber;
    } 
}
    }
}
