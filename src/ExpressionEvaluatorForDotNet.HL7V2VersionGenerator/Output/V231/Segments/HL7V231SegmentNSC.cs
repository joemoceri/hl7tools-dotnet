using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentNSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NSC"; } }

        public string SegmentId { get { return @"NSC"; } }
        
        public string LongName { get { return @"Status change"; } }
        
        public string Description { get { return @"The NSC segment can be used to request the start-up, shut-down, and/or migration (to a different cpu or file-server/file-system) of a particular application. It can also be used in an unsolicited update from one system to another to announce the start-up, shut-down, or migration of an application."; } }
        
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

        public HL7V231SegmentNSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _networkChangeType;

public HL7V231Field NetworkChangeType
{
    get
    {
        if (_networkChangeType != null)
        {
            return _networkChangeType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"NSC.1",
            Type = @"Field",
            Position = @"NSC.1",
            Name = @"Network Change Type",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0333",
            TableName = @"Network change type",
            Description = @"This field contains the type of change being requested (if NMR query) or announced (if NMD unsolicited update).  Refer to user-defined table 0333 - Network change type for suggested values.  Implies that ""new"" version starts up with no loss or duplication of data as old one is shutting down (if possible).",
            Sample = @"",
            Fields = null
        }

        _networkChangeType = new HL7V231Field
        {
            field = message[@"NSC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_networkChangeType.field.FieldRepetitions != null && _networkChangeType.field.FieldRepetitions.Count > 0)
        {
            _networkChangeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_networkChangeType, fieldData);
        }

        return _networkChangeType;
    } 
}

internal HL7V231Field _currentCPU;

public HL7V231Field CurrentCPU
{
    get
    {
        if (_currentCPU != null)
        {
            return _currentCPU;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"NSC.2",
            Type = @"Field",
            Position = @"NSC.2",
            Name = @"Current CPU",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name for the current CPU",
            Sample = @"",
            Fields = null
        }

        _currentCPU = new HL7V231Field
        {
            field = message[@"NSC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentCPU.field.FieldRepetitions != null && _currentCPU.field.FieldRepetitions.Count > 0)
        {
            _currentCPU.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_currentCPU, fieldData);
        }

        return _currentCPU;
    } 
}

internal HL7V231Field _currentFileserver;

public HL7V231Field CurrentFileserver
{
    get
    {
        if (_currentFileserver != null)
        {
            return _currentFileserver;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains a site-specific name for the current fileserver or file system used by this application",
            Sample = @"",
            Fields = null
        }

        _currentFileserver = new HL7V231Field
        {
            field = message[@"NSC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFileserver.field.FieldRepetitions != null && _currentFileserver.field.FieldRepetitions.Count > 0)
        {
            _currentFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_currentFileserver, fieldData);
        }

        return _currentFileserver;
    } 
}

internal HL7V231Field _currentApplication;

public HL7V231Field CurrentApplication
{
    get
    {
        if (_currentApplication != null)
        {
            return _currentApplication;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains a site-specific name available to identify the ""current"" application process used for interfacing with lower level protocols.  To be used in conjunction with the sending/receiving system and facility values in the MSH.",
            Sample = @"",
            Fields = null
        }

        _currentApplication = new HL7V231Field
        {
            field = message[@"NSC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentApplication.field.FieldRepetitions != null && _currentApplication.field.FieldRepetitions.Count > 0)
        {
            _currentApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_currentApplication, fieldData);
        }

        return _currentApplication;
    } 
}

internal HL7V231Field _currentFacility;

public HL7V231Field CurrentFacility
{
    get
    {
        if (_currentFacility != null)
        {
            return _currentFacility;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains a site-specific name for the current facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH",
            Sample = @"",
            Fields = null
        }

        _currentFacility = new HL7V231Field
        {
            field = message[@"NSC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFacility.field.FieldRepetitions != null && _currentFacility.field.FieldRepetitions.Count > 0)
        {
            _currentFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_currentFacility, fieldData);
        }

        return _currentFacility;
    } 
}

internal HL7V231Field _newCPU;

public HL7V231Field NewCPU
{
    get
    {
        if (_newCPU != null)
        {
            return _newCPU;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"NSC.6",
            Type = @"Field",
            Position = @"NSC.6",
            Name = @"New CPU",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name for the new CPU",
            Sample = @"",
            Fields = null
        }

        _newCPU = new HL7V231Field
        {
            field = message[@"NSC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newCPU.field.FieldRepetitions != null && _newCPU.field.FieldRepetitions.Count > 0)
        {
            _newCPU.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_newCPU, fieldData);
        }

        return _newCPU;
    } 
}

internal HL7V231Field _newFileserver;

public HL7V231Field NewFileserver
{
    get
    {
        if (_newFileserver != null)
        {
            return _newFileserver;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains a site-specific name for the new fileserver or file system used by this application",
            Sample = @"",
            Fields = null
        }

        _newFileserver = new HL7V231Field
        {
            field = message[@"NSC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFileserver.field.FieldRepetitions != null && _newFileserver.field.FieldRepetitions.Count > 0)
        {
            _newFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_newFileserver, fieldData);
        }

        return _newFileserver;
    } 
}

internal HL7V231Field _newApplication;

public HL7V231Field NewApplication
{
    get
    {
        if (_newApplication != null)
        {
            return _newApplication;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains a site-specific name available to identify ""new"" application processes used for interfacing with lower level protocols.  To be used in conjunction with the sending/receiving system and facility values in the MSH",
            Sample = @"",
            Fields = null
        }

        _newApplication = new HL7V231Field
        {
            field = message[@"NSC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newApplication.field.FieldRepetitions != null && _newApplication.field.FieldRepetitions.Count > 0)
        {
            _newApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_newApplication, fieldData);
        }

        return _newApplication;
    } 
}

internal HL7V231Field _newFacility;

public HL7V231Field NewFacility
{
    get
    {
        if (_newFacility != null)
        {
            return _newFacility;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains a site-specific name for the new facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH.",
            Sample = @"",
            Fields = null
        }

        _newFacility = new HL7V231Field
        {
            field = message[@"NSC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFacility.field.FieldRepetitions != null && _newFacility.field.FieldRepetitions.Count > 0)
        {
            _newFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_newFacility, fieldData);
        }

        return _newFacility;
    } 
}
    }
}
