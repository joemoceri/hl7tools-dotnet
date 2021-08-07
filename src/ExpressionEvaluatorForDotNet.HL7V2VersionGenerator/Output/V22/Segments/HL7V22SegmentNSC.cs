using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentNSC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"NSC"; } }

        public string SegmentId { get { return @"NSC"; } }
        
        public string LongName { get { return @"Status Change"; } }
        
        public string Description { get { return @"The NSC segment can be used to request the start-up, shut-down, and/or migration (to a different cpu or file-server/file-system) of a particular application. It can also be used in an unsolicited update from one system to another to announce the start-up, shut-down, or migration of an application"; } }
        
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
                            Name = @"Network Change Type",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"NSC1",
                            TableName = @"Network Change Type",
                            Description = @"Type of change being requested (if NMR query) or announced (if NMD unsolicited update). Suggested values are: ""SU"" - Start up; ""SD"" - Shut down; ""M"" - migrates to different CPU. Implies that ""new"" version starts up with no loss or duplication of data as old one is shutting down (if possible).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"A site specific name for the current CPU.",
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
                            Description = @"A site-specific name for the current fileserver or file system used by this application",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A site specific name available to identify the ""current"" application process used for interfacing with lower level protocols. To be used in conjunction with the sending/receiving system and facility values in the MSH.",
                            Sample = @"",
                            FieldDatas = null
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A site specific name for the current facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"A site specific name for the new CPU.",
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
                            Description = @"A site specific name for the new fileserver or file system used by this application",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A site specific name available to identify ""new"" application processes used for interfacing with lower level protocols. To be used in conjunction with the sending/receiving system and facility values in the MSH.",
                            Sample = @"",
                            FieldDatas = null
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A site specific name for the new facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentNSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field networkChangeType;

public HL7V22Field NetworkChangeType
{
    get
    {
        if (networkChangeType != null)
        {
            return networkChangeType;
        }

        networkChangeType = new HL7V22Field
        {
            field = message[@"NSC"][1],
            Id = @"NSC.1",
            Type = @"Field",
            Position = @"NSC.1",
            Name = @"Network Change Type",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"NSC1",
            TableName = @"Network Change Type",
            Description = @"Type of change being requested (if NMR query) or announced (if NMD unsolicited update). Suggested values are: ""SU"" - Start up; ""SD"" - Shut down; ""M"" - migrates to different CPU. Implies that ""new"" version starts up with no loss or duplication of data as old one is shutting down (if possible).",
            Sample = @"",
        };

        

        

        

        return networkChangeType;
    } 
}
internal HL7V22Field currentCpu;

public HL7V22Field CurrentCpu
{
    get
    {
        if (currentCpu != null)
        {
            return currentCpu;
        }

        currentCpu = new HL7V22Field
        {
            field = message[@"NSC"][2],
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
            Description = @"A site specific name for the current CPU.",
            Sample = @"",
        };

        

        

        

        return currentCpu;
    } 
}
internal HL7V22Field currentFileserver;

public HL7V22Field CurrentFileserver
{
    get
    {
        if (currentFileserver != null)
        {
            return currentFileserver;
        }

        currentFileserver = new HL7V22Field
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
            Description = @"A site-specific name for the current fileserver or file system used by this application",
            Sample = @"",
        };

        

        

        

        return currentFileserver;
    } 
}
internal HL7V22Field currentApplication;

public HL7V22Field CurrentApplication
{
    get
    {
        if (currentApplication != null)
        {
            return currentApplication;
        }

        currentApplication = new HL7V22Field
        {
            field = message[@"NSC"][4],
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
            Description = @"A site specific name available to identify the ""current"" application process used for interfacing with lower level protocols. To be used in conjunction with the sending/receiving system and facility values in the MSH.",
            Sample = @"",
        };

        

        

        

        return currentApplication;
    } 
}
internal HL7V22Field currentFacility;

public HL7V22Field CurrentFacility
{
    get
    {
        if (currentFacility != null)
        {
            return currentFacility;
        }

        currentFacility = new HL7V22Field
        {
            field = message[@"NSC"][5],
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
            Description = @"A site specific name for the current facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH.",
            Sample = @"",
        };

        

        

        

        return currentFacility;
    } 
}
internal HL7V22Field newCpu;

public HL7V22Field NewCpu
{
    get
    {
        if (newCpu != null)
        {
            return newCpu;
        }

        newCpu = new HL7V22Field
        {
            field = message[@"NSC"][6],
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
            Description = @"A site specific name for the new CPU.",
            Sample = @"",
        };

        

        

        

        return newCpu;
    } 
}
internal HL7V22Field newFileserver;

public HL7V22Field NewFileserver
{
    get
    {
        if (newFileserver != null)
        {
            return newFileserver;
        }

        newFileserver = new HL7V22Field
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
            Description = @"A site specific name for the new fileserver or file system used by this application",
            Sample = @"",
        };

        

        

        

        return newFileserver;
    } 
}
internal HL7V22Field newApplication;

public HL7V22Field NewApplication
{
    get
    {
        if (newApplication != null)
        {
            return newApplication;
        }

        newApplication = new HL7V22Field
        {
            field = message[@"NSC"][8],
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
            Description = @"A site specific name available to identify ""new"" application processes used for interfacing with lower level protocols. To be used in conjunction with the sending/receiving system and facility values in the MSH.",
            Sample = @"",
        };

        

        

        

        return newApplication;
    } 
}
internal HL7V22Field newFacility;

public HL7V22Field NewFacility
{
    get
    {
        if (newFacility != null)
        {
            return newFacility;
        }

        newFacility = new HL7V22Field
        {
            field = message[@"NSC"][9],
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
            Description = @"A site specific name for the new facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH.",
            Sample = @"",
        };

        

        

        

        return newFacility;
    } 
}

    }
}
