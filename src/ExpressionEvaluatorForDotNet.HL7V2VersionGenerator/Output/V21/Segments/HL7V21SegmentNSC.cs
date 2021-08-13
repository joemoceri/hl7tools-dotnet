using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NSC"; } }

        public string SegmentId { get { return @"NSC"; } }
        
        public string LongName { get { return @"Status Change"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentNSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _networkChangeType;

public HL7V21Field NetworkChangeType
{
    get
    {
        if (_networkChangeType != null)
        {
            return _networkChangeType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.1",
            Type = @"Field",
            Position = @"NSC.1",
            Name = @"Network Change Type",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _networkChangeType = new HL7V21Field
        {
            field = message[@"NSC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_networkChangeType.field.FieldRepetitions != null && _networkChangeType.field.FieldRepetitions.Count > 0)
        {
            _networkChangeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_networkChangeType, fieldData);
        }

        return _networkChangeType;
    } 
}

internal HL7V21Field _currentCpu;

public HL7V21Field CurrentCpu
{
    get
    {
        if (_currentCpu != null)
        {
            return _currentCpu;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.2",
            Type = @"Field",
            Position = @"NSC.2",
            Name = @"Current Cpu",
            Length = 30,
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

        _currentCpu = new HL7V21Field
        {
            field = message[@"NSC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentCpu.field.FieldRepetitions != null && _currentCpu.field.FieldRepetitions.Count > 0)
        {
            _currentCpu.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_currentCpu, fieldData);
        }

        return _currentCpu;
    } 
}

internal HL7V21Field _currentFileserver;

public HL7V21Field CurrentFileserver
{
    get
    {
        if (_currentFileserver != null)
        {
            return _currentFileserver;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.3",
            Type = @"Field",
            Position = @"NSC.3",
            Name = @"Current Fileserver",
            Length = 30,
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

        _currentFileserver = new HL7V21Field
        {
            field = message[@"NSC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFileserver.field.FieldRepetitions != null && _currentFileserver.field.FieldRepetitions.Count > 0)
        {
            _currentFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_currentFileserver, fieldData);
        }

        return _currentFileserver;
    } 
}

internal HL7V21Field _currentApplication;

public HL7V21Field CurrentApplication
{
    get
    {
        if (_currentApplication != null)
        {
            return _currentApplication;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.4",
            Type = @"Field",
            Position = @"NSC.4",
            Name = @"Current Application",
            Length = 30,
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

        _currentApplication = new HL7V21Field
        {
            field = message[@"NSC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentApplication.field.FieldRepetitions != null && _currentApplication.field.FieldRepetitions.Count > 0)
        {
            _currentApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_currentApplication, fieldData);
        }

        return _currentApplication;
    } 
}

internal HL7V21Field _currentFacility;

public HL7V21Field CurrentFacility
{
    get
    {
        if (_currentFacility != null)
        {
            return _currentFacility;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.5",
            Type = @"Field",
            Position = @"NSC.5",
            Name = @"Current Facility",
            Length = 30,
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

        _currentFacility = new HL7V21Field
        {
            field = message[@"NSC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFacility.field.FieldRepetitions != null && _currentFacility.field.FieldRepetitions.Count > 0)
        {
            _currentFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_currentFacility, fieldData);
        }

        return _currentFacility;
    } 
}

internal HL7V21Field _newCpu;

public HL7V21Field NewCpu
{
    get
    {
        if (_newCpu != null)
        {
            return _newCpu;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.6",
            Type = @"Field",
            Position = @"NSC.6",
            Name = @"New Cpu",
            Length = 30,
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

        _newCpu = new HL7V21Field
        {
            field = message[@"NSC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newCpu.field.FieldRepetitions != null && _newCpu.field.FieldRepetitions.Count > 0)
        {
            _newCpu.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_newCpu, fieldData);
        }

        return _newCpu;
    } 
}

internal HL7V21Field _newFileserver;

public HL7V21Field NewFileserver
{
    get
    {
        if (_newFileserver != null)
        {
            return _newFileserver;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.7",
            Type = @"Field",
            Position = @"NSC.7",
            Name = @"New Fileserver",
            Length = 30,
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

        _newFileserver = new HL7V21Field
        {
            field = message[@"NSC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFileserver.field.FieldRepetitions != null && _newFileserver.field.FieldRepetitions.Count > 0)
        {
            _newFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_newFileserver, fieldData);
        }

        return _newFileserver;
    } 
}

internal HL7V21Field _newApplication;

public HL7V21Field NewApplication
{
    get
    {
        if (_newApplication != null)
        {
            return _newApplication;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.8",
            Type = @"Field",
            Position = @"NSC.8",
            Name = @"New Application",
            Length = 30,
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

        _newApplication = new HL7V21Field
        {
            field = message[@"NSC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newApplication.field.FieldRepetitions != null && _newApplication.field.FieldRepetitions.Count > 0)
        {
            _newApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_newApplication, fieldData);
        }

        return _newApplication;
    } 
}

internal HL7V21Field _newFacility;

public HL7V21Field NewFacility
{
    get
    {
        if (_newFacility != null)
        {
            return _newFacility;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NSC.9",
            Type = @"Field",
            Position = @"NSC.9",
            Name = @"New Facility",
            Length = 30,
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

        _newFacility = new HL7V21Field
        {
            field = message[@"NSC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFacility.field.FieldRepetitions != null && _newFacility.field.FieldRepetitions.Count > 0)
        {
            _newFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_newFacility, fieldData);
        }

        return _newFacility;
    } 
}
    }
}
