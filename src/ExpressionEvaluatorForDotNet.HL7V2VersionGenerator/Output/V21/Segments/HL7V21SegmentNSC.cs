using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNSC
    {
        public readonly HL7V2Message message;

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
                            TableId = null,
                            TableName = null,
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentNSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field networkChangeType;

public HL7V21Field NetworkChangeType
{
    get
    {
        if (networkChangeType != null)
        {
            return networkChangeType;
        }

        networkChangeType = new HL7V21Field
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
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return networkChangeType;
    } 
}
internal HL7V21Field currentCpu;

public HL7V21Field CurrentCpu
{
    get
    {
        if (currentCpu != null)
        {
            return currentCpu;
        }

        currentCpu = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return currentCpu;
    } 
}
internal HL7V21Field currentFileserver;

public HL7V21Field CurrentFileserver
{
    get
    {
        if (currentFileserver != null)
        {
            return currentFileserver;
        }

        currentFileserver = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return currentFileserver;
    } 
}
internal HL7V21Field currentApplication;

public HL7V21Field CurrentApplication
{
    get
    {
        if (currentApplication != null)
        {
            return currentApplication;
        }

        currentApplication = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return currentApplication;
    } 
}
internal HL7V21Field currentFacility;

public HL7V21Field CurrentFacility
{
    get
    {
        if (currentFacility != null)
        {
            return currentFacility;
        }

        currentFacility = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return currentFacility;
    } 
}
internal HL7V21Field newCpu;

public HL7V21Field NewCpu
{
    get
    {
        if (newCpu != null)
        {
            return newCpu;
        }

        newCpu = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return newCpu;
    } 
}
internal HL7V21Field newFileserver;

public HL7V21Field NewFileserver
{
    get
    {
        if (newFileserver != null)
        {
            return newFileserver;
        }

        newFileserver = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return newFileserver;
    } 
}
internal HL7V21Field newApplication;

public HL7V21Field NewApplication
{
    get
    {
        if (newApplication != null)
        {
            return newApplication;
        }

        newApplication = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return newApplication;
    } 
}
internal HL7V21Field newFacility;

public HL7V21Field NewFacility
{
    get
    {
        if (newFacility != null)
        {
            return newFacility;
        }

        newFacility = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return newFacility;
    } 
}

    }
}
