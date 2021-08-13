using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentORO
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ORO"; } }

        public string SegmentId { get { return @"ORO"; } }
        
        public string LongName { get { return @"Order Other"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentORO(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _orderItemId;

public HL7V21Field OrderItemId
{
    get
    {
        if (_orderItemId != null)
        {
            return _orderItemId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORO.1",
            Type = @"Field",
            Position = @"ORO.1",
            Name = @"Order Item Id",
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
                            Id = @"ORO.1.1",
                            Type = @"Component",
                            Position = @"ORO.1.1",
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
                            Id = @"ORO.1.2",
                            Type = @"Component",
                            Position = @"ORO.1.2",
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
                            Id = @"ORO.1.3",
                            Type = @"Component",
                            Position = @"ORO.1.3",
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
                            Id = @"ORO.1.4",
                            Type = @"Component",
                            Position = @"ORO.1.4",
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
                            Id = @"ORO.1.5",
                            Type = @"Component",
                            Position = @"ORO.1.5",
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
                            Id = @"ORO.1.6",
                            Type = @"Component",
                            Position = @"ORO.1.6",
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

        _orderItemId = new HL7V21Field
        {
            field = message[@"ORO"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderItemId.field.FieldRepetitions != null && _orderItemId.field.FieldRepetitions.Count > 0)
        {
            _orderItemId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_orderItemId, fieldData);
        }

        return _orderItemId;
    } 
}

internal HL7V21Field _substituteAllowed;

public HL7V21Field SubstituteAllowed
{
    get
    {
        if (_substituteAllowed != null)
        {
            return _substituteAllowed;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORO.2",
            Type = @"Field",
            Position = @"ORO.2",
            Name = @"Substitute Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _substituteAllowed = new HL7V21Field
        {
            field = message[@"ORO"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substituteAllowed.field.FieldRepetitions != null && _substituteAllowed.field.FieldRepetitions.Count > 0)
        {
            _substituteAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_substituteAllowed, fieldData);
        }

        return _substituteAllowed;
    } 
}

internal HL7V21Field _resultsCopiesTo;

public HL7V21Field ResultsCopiesTo
{
    get
    {
        if (_resultsCopiesTo != null)
        {
            return _resultsCopiesTo;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORO.3",
            Type = @"Field",
            Position = @"ORO.3",
            Name = @"Results Copies To",
            Length = 80,
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

        _resultsCopiesTo = new HL7V21Field
        {
            field = message[@"ORO"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultsCopiesTo.field.FieldRepetitions != null && _resultsCopiesTo.field.FieldRepetitions.Count > 0)
        {
            _resultsCopiesTo.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_resultsCopiesTo, fieldData);
        }

        return _resultsCopiesTo;
    } 
}

internal HL7V21Field _stockLocation;

public HL7V21Field StockLocation
{
    get
    {
        if (_stockLocation != null)
        {
            return _stockLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"ORO.4",
            Type = @"Field",
            Position = @"ORO.4",
            Name = @"Stock Location",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0012",
            TableName = @"STOCK LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _stockLocation = new HL7V21Field
        {
            field = message[@"ORO"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_stockLocation.field.FieldRepetitions != null && _stockLocation.field.FieldRepetitions.Count > 0)
        {
            _stockLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_stockLocation, fieldData);
        }

        return _stockLocation;
    } 
}
    }
}
