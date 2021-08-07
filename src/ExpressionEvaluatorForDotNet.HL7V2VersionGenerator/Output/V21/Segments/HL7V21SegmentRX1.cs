using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentRX1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RX1"; } }

        public string SegmentId { get { return @"RX1"; } }
        
        public string LongName { get { return @"Pharmacy Order"; } }
        
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
                            Id = @"RX1.1",
                            Type = @"Field",
                            Position = @"RX1.1",
                            Name = @"Unused",
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
                            Id = @"RX1.2",
                            Type = @"Field",
                            Position = @"RX1.2",
                            Name = @"Unused",
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
                            Id = @"RX1.3",
                            Type = @"Field",
                            Position = @"RX1.3",
                            Name = @"Route",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0033",
                            TableName = @"ROUTE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.4",
                            Type = @"Field",
                            Position = @"RX1.4",
                            Name = @"Site Administered",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0034",
                            TableName = @"SITE ADMINISTERED",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.5",
                            Type = @"Field",
                            Position = @"RX1.5",
                            Name = @"Iv Solution Rate",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.6",
                            Type = @"Field",
                            Position = @"RX1.6",
                            Name = @"Drug Strength",
                            Length = 14,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.7",
                            Type = @"Field",
                            Position = @"RX1.7",
                            Name = @"Final Concentration",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.8",
                            Type = @"Field",
                            Position = @"RX1.8",
                            Name = @"Final Volume In Ml.",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.9",
                            Type = @"Field",
                            Position = @"RX1.9",
                            Name = @"Drug Dose",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.10",
                            Type = @"Field",
                            Position = @"RX1.10",
                            Name = @"Drug Role",
                            Length = 1,
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
                            Id = @"RX1.11",
                            Type = @"Field",
                            Position = @"RX1.11",
                            Name = @"Prescription Sequence #",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.12",
                            Type = @"Field",
                            Position = @"RX1.12",
                            Name = @"Quantity Dispensed",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.13",
                            Type = @"Field",
                            Position = @"RX1.13",
                            Name = @"Unused",
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
                            Id = @"RX1.14",
                            Type = @"Field",
                            Position = @"RX1.14",
                            Name = @"Drug Id",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE_0057",
                            DataTypeName = @"",
                            TableId = @"0057",
                            TableName = @"DRUG CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.15",
                            Type = @"Field",
                            Position = @"RX1.15",
                            Name = @"Component Drug Ids",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"5",
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
                            Id = @"RX1.16",
                            Type = @"Field",
                            Position = @"RX1.16",
                            Name = @"Prescription Type",
                            Length = 2,
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
                            Id = @"RX1.17",
                            Type = @"Field",
                            Position = @"RX1.17",
                            Name = @"Substitution Status",
                            Length = 1,
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
                            Id = @"RX1.18",
                            Type = @"Field",
                            Position = @"RX1.18",
                            Name = @"Rx Order Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0038",
                            TableName = @"ORDER STATUS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.19",
                            Type = @"Field",
                            Position = @"RX1.19",
                            Name = @"Number Of Refills",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.20",
                            Type = @"Field",
                            Position = @"RX1.20",
                            Name = @"Unused",
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
                            Id = @"RX1.21",
                            Type = @"Field",
                            Position = @"RX1.21",
                            Name = @"Refills Remaining",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.22",
                            Type = @"Field",
                            Position = @"RX1.22",
                            Name = @"Dea Class",
                            Length = 5,
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
                            Id = @"RX1.23",
                            Type = @"Field",
                            Position = @"RX1.23",
                            Name = @"Ordering Md's Dea Number",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.24",
                            Type = @"Field",
                            Position = @"RX1.24",
                            Name = @"Unused",
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
                            Id = @"RX1.25",
                            Type = @"Field",
                            Position = @"RX1.25",
                            Name = @"Last Refill Date/Time",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.26",
                            Type = @"Field",
                            Position = @"RX1.26",
                            Name = @"Rx Number",
                            Length = 20,
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
                            Id = @"RX1.27",
                            Type = @"Field",
                            Position = @"RX1.27",
                            Name = @"Prn Status",
                            Length = 5,
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
                            Id = @"RX1.28",
                            Type = @"Field",
                            Position = @"RX1.28",
                            Name = @"Pharmacy Instructions",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.29",
                            Type = @"Field",
                            Position = @"RX1.29",
                            Name = @"Patient Instructions",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"5",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RX1.30",
                            Type = @"Field",
                            Position = @"RX1.30",
                            Name = @"Instructions (sig)",
                            Length = 500,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentRX1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field unused;

public HL7V21Field Unused
{
    get
    {
        if (unused != null)
        {
            return unused;
        }

        unused = new HL7V21Field
        {
            field = message[@"RX1"][1],
            Id = @"RX1.1",
            Type = @"Field",
            Position = @"RX1.1",
            Name = @"Unused",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return unused;
    } 
}
internal HL7V21Field unused;

public HL7V21Field Unused
{
    get
    {
        if (unused != null)
        {
            return unused;
        }

        unused = new HL7V21Field
        {
            field = message[@"RX1"][2],
            Id = @"RX1.2",
            Type = @"Field",
            Position = @"RX1.2",
            Name = @"Unused",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return unused;
    } 
}
internal HL7V21Field route;

public HL7V21Field Route
{
    get
    {
        if (route != null)
        {
            return route;
        }

        route = new HL7V21Field
        {
            field = message[@"RX1"][3],
            Id = @"RX1.3",
            Type = @"Field",
            Position = @"RX1.3",
            Name = @"Route",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0033",
            TableName = @"ROUTE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return route;
    } 
}
internal HL7V21Field siteAdministered;

public HL7V21Field SiteAdministered
{
    get
    {
        if (siteAdministered != null)
        {
            return siteAdministered;
        }

        siteAdministered = new HL7V21Field
        {
            field = message[@"RX1"][4],
            Id = @"RX1.4",
            Type = @"Field",
            Position = @"RX1.4",
            Name = @"Site Administered",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0034",
            TableName = @"SITE ADMINISTERED",
            Description = null,
            Sample = @"",
        };

        

        

        

        return siteAdministered;
    } 
}
internal HL7V21Field ivSolutionRate;

public HL7V21Field IvSolutionRate
{
    get
    {
        if (ivSolutionRate != null)
        {
            return ivSolutionRate;
        }

        ivSolutionRate = new HL7V21Field
        {
            field = message[@"RX1"][5],
            Id = @"RX1.5",
            Type = @"Field",
            Position = @"RX1.5",
            Name = @"Iv Solution Rate",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return ivSolutionRate;
    } 
}
internal HL7V21Field drugStrength;

public HL7V21Field DrugStrength
{
    get
    {
        if (drugStrength != null)
        {
            return drugStrength;
        }

        drugStrength = new HL7V21Field
        {
            field = message[@"RX1"][6],
            Id = @"RX1.6",
            Type = @"Field",
            Position = @"RX1.6",
            Name = @"Drug Strength",
            Length = 14,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return drugStrength;
    } 
}
internal HL7V21Field finalConcentration;

public HL7V21Field FinalConcentration
{
    get
    {
        if (finalConcentration != null)
        {
            return finalConcentration;
        }

        finalConcentration = new HL7V21Field
        {
            field = message[@"RX1"][7],
            Id = @"RX1.7",
            Type = @"Field",
            Position = @"RX1.7",
            Name = @"Final Concentration",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return finalConcentration;
    } 
}
internal HL7V21Field finalVolumeInMl.;

public HL7V21Field FinalVolumeInMl.
{
    get
    {
        if (finalVolumeInMl. != null)
        {
            return finalVolumeInMl.;
        }

        finalVolumeInMl. = new HL7V21Field
        {
            field = message[@"RX1"][8],
            Id = @"RX1.8",
            Type = @"Field",
            Position = @"RX1.8",
            Name = @"Final Volume In Ml.",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return finalVolumeInMl.;
    } 
}
internal HL7V21Field drugDose;

public HL7V21Field DrugDose
{
    get
    {
        if (drugDose != null)
        {
            return drugDose;
        }

        drugDose = new HL7V21Field
        {
            field = message[@"RX1"][9],
            Id = @"RX1.9",
            Type = @"Field",
            Position = @"RX1.9",
            Name = @"Drug Dose",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return drugDose;
    } 
}
internal HL7V21Field drugRole;

public HL7V21Field DrugRole
{
    get
    {
        if (drugRole != null)
        {
            return drugRole;
        }

        drugRole = new HL7V21Field
        {
            field = message[@"RX1"][10],
            Id = @"RX1.10",
            Type = @"Field",
            Position = @"RX1.10",
            Name = @"Drug Role",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return drugRole;
    } 
}
internal HL7V21Field prescriptionSequence#;

public HL7V21Field PrescriptionSequence#
{
    get
    {
        if (prescriptionSequence# != null)
        {
            return prescriptionSequence#;
        }

        prescriptionSequence# = new HL7V21Field
        {
            field = message[@"RX1"][11],
            Id = @"RX1.11",
            Type = @"Field",
            Position = @"RX1.11",
            Name = @"Prescription Sequence #",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return prescriptionSequence#;
    } 
}
internal HL7V21Field quantityDispensed;

public HL7V21Field QuantityDispensed
{
    get
    {
        if (quantityDispensed != null)
        {
            return quantityDispensed;
        }

        quantityDispensed = new HL7V21Field
        {
            field = message[@"RX1"][12],
            Id = @"RX1.12",
            Type = @"Field",
            Position = @"RX1.12",
            Name = @"Quantity Dispensed",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return quantityDispensed;
    } 
}
internal HL7V21Field unused;

public HL7V21Field Unused
{
    get
    {
        if (unused != null)
        {
            return unused;
        }

        unused = new HL7V21Field
        {
            field = message[@"RX1"][13],
            Id = @"RX1.13",
            Type = @"Field",
            Position = @"RX1.13",
            Name = @"Unused",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return unused;
    } 
}
internal HL7V21Field drugId;

public HL7V21Field DrugId
{
    get
    {
        if (drugId != null)
        {
            return drugId;
        }

        drugId = new HL7V21Field
        {
            field = message[@"RX1"][14],
            Id = @"RX1.14",
            Type = @"Field",
            Position = @"RX1.14",
            Name = @"Drug Id",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE_0057",
            DataTypeName = @"",
            TableId = @"0057",
            TableName = @"DRUG CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return drugId;
    } 
}
internal HL7V21Field componentDrugIds;

public HL7V21Field ComponentDrugIds
{
    get
    {
        if (componentDrugIds != null)
        {
            return componentDrugIds;
        }

        componentDrugIds = new HL7V21Field
        {
            field = message[@"RX1"][15],
            Id = @"RX1.15",
            Type = @"Field",
            Position = @"RX1.15",
            Name = @"Component Drug Ids",
            Length = 5,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return componentDrugIds;
    } 
}
internal HL7V21Field prescriptionType;

public HL7V21Field PrescriptionType
{
    get
    {
        if (prescriptionType != null)
        {
            return prescriptionType;
        }

        prescriptionType = new HL7V21Field
        {
            field = message[@"RX1"][16],
            Id = @"RX1.16",
            Type = @"Field",
            Position = @"RX1.16",
            Name = @"Prescription Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return prescriptionType;
    } 
}
internal HL7V21Field substitutionStatus;

public HL7V21Field SubstitutionStatus
{
    get
    {
        if (substitutionStatus != null)
        {
            return substitutionStatus;
        }

        substitutionStatus = new HL7V21Field
        {
            field = message[@"RX1"][17],
            Id = @"RX1.17",
            Type = @"Field",
            Position = @"RX1.17",
            Name = @"Substitution Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return substitutionStatus;
    } 
}
internal HL7V21Field rxOrderStatus;

public HL7V21Field RxOrderStatus
{
    get
    {
        if (rxOrderStatus != null)
        {
            return rxOrderStatus;
        }

        rxOrderStatus = new HL7V21Field
        {
            field = message[@"RX1"][18],
            Id = @"RX1.18",
            Type = @"Field",
            Position = @"RX1.18",
            Name = @"Rx Order Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0038",
            TableName = @"ORDER STATUS",
            Description = null,
            Sample = @"",
        };

        

        

        

        return rxOrderStatus;
    } 
}
internal HL7V21Field numberOfRefills;

public HL7V21Field NumberOfRefills
{
    get
    {
        if (numberOfRefills != null)
        {
            return numberOfRefills;
        }

        numberOfRefills = new HL7V21Field
        {
            field = message[@"RX1"][19],
            Id = @"RX1.19",
            Type = @"Field",
            Position = @"RX1.19",
            Name = @"Number Of Refills",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return numberOfRefills;
    } 
}
internal HL7V21Field unused;

public HL7V21Field Unused
{
    get
    {
        if (unused != null)
        {
            return unused;
        }

        unused = new HL7V21Field
        {
            field = message[@"RX1"][20],
            Id = @"RX1.20",
            Type = @"Field",
            Position = @"RX1.20",
            Name = @"Unused",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return unused;
    } 
}
internal HL7V21Field refillsRemaining;

public HL7V21Field RefillsRemaining
{
    get
    {
        if (refillsRemaining != null)
        {
            return refillsRemaining;
        }

        refillsRemaining = new HL7V21Field
        {
            field = message[@"RX1"][21],
            Id = @"RX1.21",
            Type = @"Field",
            Position = @"RX1.21",
            Name = @"Refills Remaining",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return refillsRemaining;
    } 
}
internal HL7V21Field deaClass;

public HL7V21Field DeaClass
{
    get
    {
        if (deaClass != null)
        {
            return deaClass;
        }

        deaClass = new HL7V21Field
        {
            field = message[@"RX1"][22],
            Id = @"RX1.22",
            Type = @"Field",
            Position = @"RX1.22",
            Name = @"Dea Class",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return deaClass;
    } 
}
internal HL7V21Field orderingMd'sDeaNumber;

public HL7V21Field OrderingMd'sDeaNumber
{
    get
    {
        if (orderingMd'sDeaNumber != null)
        {
            return orderingMd'sDeaNumber;
        }

        orderingMd'sDeaNumber = new HL7V21Field
        {
            field = message[@"RX1"][23],
            Id = @"RX1.23",
            Type = @"Field",
            Position = @"RX1.23",
            Name = @"Ordering Md's Dea Number",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return orderingMd'sDeaNumber;
    } 
}
internal HL7V21Field unused;

public HL7V21Field Unused
{
    get
    {
        if (unused != null)
        {
            return unused;
        }

        unused = new HL7V21Field
        {
            field = message[@"RX1"][24],
            Id = @"RX1.24",
            Type = @"Field",
            Position = @"RX1.24",
            Name = @"Unused",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return unused;
    } 
}
internal HL7V21Field lastRefillDateTime;

public HL7V21Field LastRefillDateTime
{
    get
    {
        if (lastRefillDateTime != null)
        {
            return lastRefillDateTime;
        }

        lastRefillDateTime = new HL7V21Field
        {
            field = message[@"RX1"][25],
            Id = @"RX1.25",
            Type = @"Field",
            Position = @"RX1.25",
            Name = @"Last Refill Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return lastRefillDateTime;
    } 
}
internal HL7V21Field rxNumber;

public HL7V21Field RxNumber
{
    get
    {
        if (rxNumber != null)
        {
            return rxNumber;
        }

        rxNumber = new HL7V21Field
        {
            field = message[@"RX1"][26],
            Id = @"RX1.26",
            Type = @"Field",
            Position = @"RX1.26",
            Name = @"Rx Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return rxNumber;
    } 
}
internal HL7V21Field prnStatus;

public HL7V21Field PrnStatus
{
    get
    {
        if (prnStatus != null)
        {
            return prnStatus;
        }

        prnStatus = new HL7V21Field
        {
            field = message[@"RX1"][27],
            Id = @"RX1.27",
            Type = @"Field",
            Position = @"RX1.27",
            Name = @"Prn Status",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return prnStatus;
    } 
}
internal HL7V21Field pharmacyInstructions;

public HL7V21Field PharmacyInstructions
{
    get
    {
        if (pharmacyInstructions != null)
        {
            return pharmacyInstructions;
        }

        pharmacyInstructions = new HL7V21Field
        {
            field = message[@"RX1"][28],
            Id = @"RX1.28",
            Type = @"Field",
            Position = @"RX1.28",
            Name = @"Pharmacy Instructions",
            Length = 80,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return pharmacyInstructions;
    } 
}
internal HL7V21Field patientInstructions;

public HL7V21Field PatientInstructions
{
    get
    {
        if (patientInstructions != null)
        {
            return patientInstructions;
        }

        patientInstructions = new HL7V21Field
        {
            field = message[@"RX1"][29],
            Id = @"RX1.29",
            Type = @"Field",
            Position = @"RX1.29",
            Name = @"Patient Instructions",
            Length = 80,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return patientInstructions;
    } 
}
internal HL7V21Field instructions(sig);

public HL7V21Field Instructions(sig)
{
    get
    {
        if (instructions(sig) != null)
        {
            return instructions(sig);
        }

        instructions(sig) = new HL7V21Field
        {
            field = message[@"RX1"][30],
            Id = @"RX1.30",
            Type = @"Field",
            Position = @"RX1.30",
            Name = @"Instructions (sig)",
            Length = 500,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return instructions(sig);
    } 
}

    }
}
