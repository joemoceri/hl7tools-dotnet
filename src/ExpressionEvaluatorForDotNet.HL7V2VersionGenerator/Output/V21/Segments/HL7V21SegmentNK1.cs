using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNK1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NK1"; } }

        public string SegmentId { get { return @"NK1"; } }
        
        public string LongName { get { return @"Next Of Kin"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentNK1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdNextOfKin;

public HL7V21Field SetIdNextOfKin
{
    get
    {
        if (_setIdNextOfKin != null)
        {
            return _setIdNextOfKin;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NK1.1",
            Type = @"Field",
            Position = @"NK1.1",
            Name = @"Set Id - Next Of Kin",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdNextOfKin = new HL7V21Field
        {
            field = message[@"NK1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdNextOfKin.field.FieldRepetitions != null && _setIdNextOfKin.field.FieldRepetitions.Count > 0)
        {
            _setIdNextOfKin.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdNextOfKin, fieldData);
        }

        return _setIdNextOfKin;
    } 
}

internal HL7V21Field _nextOfKinName;

public HL7V21Field NextOfKinName
{
    get
    {
        if (_nextOfKinName != null)
        {
            return _nextOfKinName;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NK1.2",
            Type = @"Field",
            Position = @"NK1.2",
            Name = @"Next Of Kin Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _nextOfKinName = new HL7V21Field
        {
            field = message[@"NK1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextOfKinName.field.FieldRepetitions != null && _nextOfKinName.field.FieldRepetitions.Count > 0)
        {
            _nextOfKinName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_nextOfKinName, fieldData);
        }

        return _nextOfKinName;
    } 
}

internal HL7V21Field _nextOfKinRelationship;

public HL7V21Field NextOfKinRelationship
{
    get
    {
        if (_nextOfKinRelationship != null)
        {
            return _nextOfKinRelationship;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NK1.3",
            Type = @"Field",
            Position = @"NK1.3",
            Name = @"Next Of Kin Relationship",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _nextOfKinRelationship = new HL7V21Field
        {
            field = message[@"NK1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextOfKinRelationship.field.FieldRepetitions != null && _nextOfKinRelationship.field.FieldRepetitions.Count > 0)
        {
            _nextOfKinRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_nextOfKinRelationship, fieldData);
        }

        return _nextOfKinRelationship;
    } 
}

internal HL7V21Field _nextOfKinAddress;

public HL7V21Field NextOfKinAddress
{
    get
    {
        if (_nextOfKinAddress != null)
        {
            return _nextOfKinAddress;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NK1.4",
            Type = @"Field",
            Position = @"NK1.4",
            Name = @"Next Of Kin - Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _nextOfKinAddress = new HL7V21Field
        {
            field = message[@"NK1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextOfKinAddress.field.FieldRepetitions != null && _nextOfKinAddress.field.FieldRepetitions.Count > 0)
        {
            _nextOfKinAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_nextOfKinAddress, fieldData);
        }

        return _nextOfKinAddress;
    } 
}

internal HL7V21Field _nextOfKinPhoneNumber;

public HL7V21Field NextOfKinPhoneNumber
{
    get
    {
        if (_nextOfKinPhoneNumber != null)
        {
            return _nextOfKinPhoneNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NK1.5",
            Type = @"Field",
            Position = @"NK1.5",
            Name = @"Next Of Kin - Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _nextOfKinPhoneNumber = new HL7V21Field
        {
            field = message[@"NK1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextOfKinPhoneNumber.field.FieldRepetitions != null && _nextOfKinPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _nextOfKinPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_nextOfKinPhoneNumber, fieldData);
        }

        return _nextOfKinPhoneNumber;
    } 
}
    }
}
