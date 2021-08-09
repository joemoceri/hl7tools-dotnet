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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        };
            }
        }

        public HL7V251SegmentNSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field applicationChangeType;

public HL7V251Field ApplicationChangeType
{
    get
    {
        if (applicationChangeType != null)
        {
            return applicationChangeType;
        }

        applicationChangeType = new HL7V251Field
        {
            field = message[@"NSC"][1],
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
        };

        // check for repetitions
        if (applicationChangeType.field.FieldRepetitions != null && applicationChangeType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(applicationChangeType.Id));
            applicationChangeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(applicationChangeType, fieldData);
        }

        return applicationChangeType;
    } 
}

internal HL7V251Field currentCPU;

public HL7V251Field CurrentCPU
{
    get
    {
        if (currentCPU != null)
        {
            return currentCPU;
        }

        currentCPU = new HL7V251Field
        {
            field = message[@"NSC"][2],
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
        };

        // check for repetitions
        if (currentCPU.field.FieldRepetitions != null && currentCPU.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(currentCPU.Id));
            currentCPU.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(currentCPU, fieldData);
        }

        return currentCPU;
    } 
}

internal HL7V251Field currentFileserver;

public HL7V251Field CurrentFileserver
{
    get
    {
        if (currentFileserver != null)
        {
            return currentFileserver;
        }

        currentFileserver = new HL7V251Field
        {
            field = message[@"NSC"][3],
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
        };

        // check for repetitions
        if (currentFileserver.field.FieldRepetitions != null && currentFileserver.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(currentFileserver.Id));
            currentFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(currentFileserver, fieldData);
        }

        return currentFileserver;
    } 
}

internal HL7V251Field currentApplication;

public HL7V251Field CurrentApplication
{
    get
    {
        if (currentApplication != null)
        {
            return currentApplication;
        }

        currentApplication = new HL7V251Field
        {
            field = message[@"NSC"][4],
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
        };

        // check for repetitions
        if (currentApplication.field.FieldRepetitions != null && currentApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(currentApplication.Id));
            currentApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(currentApplication, fieldData);
        }

        return currentApplication;
    } 
}

internal HL7V251Field currentFacility;

public HL7V251Field CurrentFacility
{
    get
    {
        if (currentFacility != null)
        {
            return currentFacility;
        }

        currentFacility = new HL7V251Field
        {
            field = message[@"NSC"][5],
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
        };

        // check for repetitions
        if (currentFacility.field.FieldRepetitions != null && currentFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(currentFacility.Id));
            currentFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(currentFacility, fieldData);
        }

        return currentFacility;
    } 
}

internal HL7V251Field newCPU;

public HL7V251Field NewCPU
{
    get
    {
        if (newCPU != null)
        {
            return newCPU;
        }

        newCPU = new HL7V251Field
        {
            field = message[@"NSC"][6],
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
        };

        // check for repetitions
        if (newCPU.field.FieldRepetitions != null && newCPU.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(newCPU.Id));
            newCPU.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(newCPU, fieldData);
        }

        return newCPU;
    } 
}

internal HL7V251Field newFileserver;

public HL7V251Field NewFileserver
{
    get
    {
        if (newFileserver != null)
        {
            return newFileserver;
        }

        newFileserver = new HL7V251Field
        {
            field = message[@"NSC"][7],
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
        };

        // check for repetitions
        if (newFileserver.field.FieldRepetitions != null && newFileserver.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(newFileserver.Id));
            newFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(newFileserver, fieldData);
        }

        return newFileserver;
    } 
}

internal HL7V251Field newApplication;

public HL7V251Field NewApplication
{
    get
    {
        if (newApplication != null)
        {
            return newApplication;
        }

        newApplication = new HL7V251Field
        {
            field = message[@"NSC"][8],
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
        };

        // check for repetitions
        if (newApplication.field.FieldRepetitions != null && newApplication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(newApplication.Id));
            newApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(newApplication, fieldData);
        }

        return newApplication;
    } 
}

internal HL7V251Field newFacility;

public HL7V251Field NewFacility
{
    get
    {
        if (newFacility != null)
        {
            return newFacility;
        }

        newFacility = new HL7V251Field
        {
            field = message[@"NSC"][9],
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
        };

        // check for repetitions
        if (newFacility.field.FieldRepetitions != null && newFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(newFacility.Id));
            newFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(newFacility, fieldData);
        }

        return newFacility;
    } 
}
    }
}
