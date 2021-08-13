using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentNSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NSC"; } }

        public string SegmentId { get { return @"NSC"; } }
        
        public string LongName { get { return @"Application Status Change"; } }
        
        public string Description { get { return @"The NSC segment is used to inform (NMR query response) or announce (NMD unsolicited update) the start-up, shut-down, and/or migration (to a different cpu or file-server/file-system) of a particular application.

Usage Notes: Fields 2-9.  These are not applicable (“n/a”) when the type of change being requested or reported is start-up or shut-down.  If the change is of type ""M"", at least one of fields 2-5 must be different from its corresponding field in range 6-9. 

Fields 4-5, 8-9.  See definitions for the MSH, message header segment, for fields 3-4, for system and facility.  ""Application"" is available for interfacing with lower level protocols.  ""Facility"" is entirely site-defined. 

Fields 2-3, 6-7. Entirely site-defined. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

                    };
            }
        }

        public HL7V251SegmentNSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _applicationChangeType;

public HL7V251Field ApplicationChangeType
{
    get
    {
        if (_applicationChangeType != null)
        {
            return _applicationChangeType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"NSC.1",
            Type = @"Field",
            Position = @"NSC.1",
            Name = @"Application Change Type",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0409",
            TableName = @"Application change type",
            Description = @"This field contains the type of change being requested (if NMR query) or announced (if NMD unsolicited update). Refer to User-Defined Table 0409 - Application Change Type for suggested values. It is assumed that ""new"" version starts up with no loss or duplication of data as old one is shutting down (if possible).",
            Sample = @"",
            Fields = null
        }

        _applicationChangeType = new HL7V251Field
        {
            field = message[@"NSC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationChangeType.field.FieldRepetitions != null && _applicationChangeType.field.FieldRepetitions.Count > 0)
        {
            _applicationChangeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_applicationChangeType, fieldData);
        }

        return _applicationChangeType;
    } 
}

internal HL7V251Field _currentCPU;

public HL7V251Field CurrentCPU
{
    get
    {
        if (_currentCPU != null)
        {
            return _currentCPU;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field contains a site-specific name for the current CPU.",
            Sample = @"",
            Fields = null
        }

        _currentCPU = new HL7V251Field
        {
            field = message[@"NSC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentCPU.field.FieldRepetitions != null && _currentCPU.field.FieldRepetitions.Count > 0)
        {
            _currentCPU.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_currentCPU, fieldData);
        }

        return _currentCPU;
    } 
}

internal HL7V251Field _currentFileserver;

public HL7V251Field CurrentFileserver
{
    get
    {
        if (_currentFileserver != null)
        {
            return _currentFileserver;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field contains a site-specific name for the current fileserver or file system used by this application.",
            Sample = @"",
            Fields = null
        }

        _currentFileserver = new HL7V251Field
        {
            field = message[@"NSC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFileserver.field.FieldRepetitions != null && _currentFileserver.field.FieldRepetitions.Count > 0)
        {
            _currentFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_currentFileserver, fieldData);
        }

        return _currentFileserver;
    } 
}

internal HL7V251Field _currentApplication;

public HL7V251Field CurrentApplication
{
    get
    {
        if (_currentApplication != null)
        {
            return _currentApplication;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"NSC.4",
            Type = @"Field",
            Position = @"NSC.4",
            Name = @"Current Application",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name used to identify the ""current"" application process for interfacing with lower level protocols. To be used in conjunction with the sending/receiving system and facility values in the MSH. Entirely site-defined. User-defined Table 0361-Sending/receiving application is used as the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.4.1",
                            Type = @"Component",
                            Position = @"NSC.4.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.4.2",
                            Type = @"Component",
                            Position = @"NSC.4.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.4.3",
                            Type = @"Component",
                            Position = @"NSC.4.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _currentApplication = new HL7V251Field
        {
            field = message[@"NSC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentApplication.field.FieldRepetitions != null && _currentApplication.field.FieldRepetitions.Count > 0)
        {
            _currentApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_currentApplication, fieldData);
        }

        return _currentApplication;
    } 
}

internal HL7V251Field _currentFacility;

public HL7V251Field CurrentFacility
{
    get
    {
        if (_currentFacility != null)
        {
            return _currentFacility;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"NSC.5",
            Type = @"Field",
            Position = @"NSC.5",
            Name = @"Current Facility",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name for the current facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH. This field further describes the current application, NSC-5-current application. With the promotion of this field to an HD data type, the usage has been broadened to include not just the current facility but other organizational entities such as a) the organizational entity responsible for current application; b) the responsible unit; c) a product or vendors identifier, etc. Entirely site-defined. User-defined Table 0362 - Sending/receiving facility is used as the HL7 identifier for the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.5.1",
                            Type = @"Component",
                            Position = @"NSC.5.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.5.2",
                            Type = @"Component",
                            Position = @"NSC.5.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.5.3",
                            Type = @"Component",
                            Position = @"NSC.5.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _currentFacility = new HL7V251Field
        {
            field = message[@"NSC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFacility.field.FieldRepetitions != null && _currentFacility.field.FieldRepetitions.Count > 0)
        {
            _currentFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_currentFacility, fieldData);
        }

        return _currentFacility;
    } 
}

internal HL7V251Field _newCPU;

public HL7V251Field NewCPU
{
    get
    {
        if (_newCPU != null)
        {
            return _newCPU;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field contains a site-specific name for the new CPU.",
            Sample = @"",
            Fields = null
        }

        _newCPU = new HL7V251Field
        {
            field = message[@"NSC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newCPU.field.FieldRepetitions != null && _newCPU.field.FieldRepetitions.Count > 0)
        {
            _newCPU.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_newCPU, fieldData);
        }

        return _newCPU;
    } 
}

internal HL7V251Field _newFileserver;

public HL7V251Field NewFileserver
{
    get
    {
        if (_newFileserver != null)
        {
            return _newFileserver;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field contains a site-specific name for the new fileserver or file system used by this application.",
            Sample = @"",
            Fields = null
        }

        _newFileserver = new HL7V251Field
        {
            field = message[@"NSC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFileserver.field.FieldRepetitions != null && _newFileserver.field.FieldRepetitions.Count > 0)
        {
            _newFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_newFileserver, fieldData);
        }

        return _newFileserver;
    } 
}

internal HL7V251Field _newApplication;

public HL7V251Field NewApplication
{
    get
    {
        if (_newApplication != null)
        {
            return _newApplication;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"NSC.8",
            Type = @"Field",
            Position = @"NSC.8",
            Name = @"New Application",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name used to identify ""new"" application processes for interfacing with lower level protocols. To be used in conjunction with the sending/receiving system and facility values in the MSH. Entirely site-defined. User-defined Table 0361-Sending/receiving application is used as the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.8.1",
                            Type = @"Component",
                            Position = @"NSC.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.8.2",
                            Type = @"Component",
                            Position = @"NSC.8.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.8.3",
                            Type = @"Component",
                            Position = @"NSC.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _newApplication = new HL7V251Field
        {
            field = message[@"NSC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newApplication.field.FieldRepetitions != null && _newApplication.field.FieldRepetitions.Count > 0)
        {
            _newApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_newApplication, fieldData);
        }

        return _newApplication;
    } 
}

internal HL7V251Field _newFacility;

public HL7V251Field NewFacility
{
    get
    {
        if (_newFacility != null)
        {
            return _newFacility;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"NSC.9",
            Type = @"Field",
            Position = @"NSC.9",
            Name = @"New Facility",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name for the new facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.9.1",
                            Type = @"Component",
                            Position = @"NSC.9.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.9.2",
                            Type = @"Component",
                            Position = @"NSC.9.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.9.3",
                            Type = @"Component",
                            Position = @"NSC.9.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _newFacility = new HL7V251Field
        {
            field = message[@"NSC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFacility.field.FieldRepetitions != null && _newFacility.field.FieldRepetitions.Count > 0)
        {
            _newFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_newFacility, fieldData);
        }

        return _newFacility;
    } 
}
    }
}
