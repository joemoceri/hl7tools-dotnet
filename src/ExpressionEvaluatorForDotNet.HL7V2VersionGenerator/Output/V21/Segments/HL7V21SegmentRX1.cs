using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentRX1
    {
        public HL7V2Message message { get; init; }

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

        public HL7V21SegmentRX1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _unused;

public HL7V21Field Unused
{
    get
    {
        if (_unused != null)
        {
            return _unused;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _unused = new HL7V21Field
        {
            field = message[@"RX1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unused.field.FieldRepetitions != null && _unused.field.FieldRepetitions.Count > 0)
        {
            _unused.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_unused, fieldData);
        }

        return _unused;
    } 
}

internal HL7V21Field _unused;

public HL7V21Field Unused
{
    get
    {
        if (_unused != null)
        {
            return _unused;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _unused = new HL7V21Field
        {
            field = message[@"RX1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unused.field.FieldRepetitions != null && _unused.field.FieldRepetitions.Count > 0)
        {
            _unused.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_unused, fieldData);
        }

        return _unused;
    } 
}

internal HL7V21Field _route;

public HL7V21Field Route
{
    get
    {
        if (_route != null)
        {
            return _route;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _route = new HL7V21Field
        {
            field = message[@"RX1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_route.field.FieldRepetitions != null && _route.field.FieldRepetitions.Count > 0)
        {
            _route.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_route, fieldData);
        }

        return _route;
    } 
}

internal HL7V21Field _siteAdministered;

public HL7V21Field SiteAdministered
{
    get
    {
        if (_siteAdministered != null)
        {
            return _siteAdministered;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _siteAdministered = new HL7V21Field
        {
            field = message[@"RX1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_siteAdministered.field.FieldRepetitions != null && _siteAdministered.field.FieldRepetitions.Count > 0)
        {
            _siteAdministered.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_siteAdministered, fieldData);
        }

        return _siteAdministered;
    } 
}

internal HL7V21Field _ivSolutionRate;

public HL7V21Field IvSolutionRate
{
    get
    {
        if (_ivSolutionRate != null)
        {
            return _ivSolutionRate;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _ivSolutionRate = new HL7V21Field
        {
            field = message[@"RX1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ivSolutionRate.field.FieldRepetitions != null && _ivSolutionRate.field.FieldRepetitions.Count > 0)
        {
            _ivSolutionRate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ivSolutionRate, fieldData);
        }

        return _ivSolutionRate;
    } 
}

internal HL7V21Field _drugStrength;

public HL7V21Field DrugStrength
{
    get
    {
        if (_drugStrength != null)
        {
            return _drugStrength;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _drugStrength = new HL7V21Field
        {
            field = message[@"RX1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drugStrength.field.FieldRepetitions != null && _drugStrength.field.FieldRepetitions.Count > 0)
        {
            _drugStrength.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_drugStrength, fieldData);
        }

        return _drugStrength;
    } 
}

internal HL7V21Field _finalConcentration;

public HL7V21Field FinalConcentration
{
    get
    {
        if (_finalConcentration != null)
        {
            return _finalConcentration;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _finalConcentration = new HL7V21Field
        {
            field = message[@"RX1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_finalConcentration.field.FieldRepetitions != null && _finalConcentration.field.FieldRepetitions.Count > 0)
        {
            _finalConcentration.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_finalConcentration, fieldData);
        }

        return _finalConcentration;
    } 
}

internal HL7V21Field _finalVolumeInMl;

public HL7V21Field FinalVolumeInMl
{
    get
    {
        if (_finalVolumeInMl != null)
        {
            return _finalVolumeInMl;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _finalVolumeInMl = new HL7V21Field
        {
            field = message[@"RX1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_finalVolumeInMl.field.FieldRepetitions != null && _finalVolumeInMl.field.FieldRepetitions.Count > 0)
        {
            _finalVolumeInMl.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_finalVolumeInMl, fieldData);
        }

        return _finalVolumeInMl;
    } 
}

internal HL7V21Field _drugDose;

public HL7V21Field DrugDose
{
    get
    {
        if (_drugDose != null)
        {
            return _drugDose;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _drugDose = new HL7V21Field
        {
            field = message[@"RX1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drugDose.field.FieldRepetitions != null && _drugDose.field.FieldRepetitions.Count > 0)
        {
            _drugDose.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_drugDose, fieldData);
        }

        return _drugDose;
    } 
}

internal HL7V21Field _drugRole;

public HL7V21Field DrugRole
{
    get
    {
        if (_drugRole != null)
        {
            return _drugRole;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _drugRole = new HL7V21Field
        {
            field = message[@"RX1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drugRole.field.FieldRepetitions != null && _drugRole.field.FieldRepetitions.Count > 0)
        {
            _drugRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_drugRole, fieldData);
        }

        return _drugRole;
    } 
}

internal HL7V21Field _prescriptionSequence#;

public HL7V21Field PrescriptionSequence#
{
    get
    {
        if (_prescriptionSequence# != null)
        {
            return _prescriptionSequence#;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _prescriptionSequence# = new HL7V21Field
        {
            field = message[@"RX1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_prescriptionSequence#.field.FieldRepetitions != null && _prescriptionSequence#.field.FieldRepetitions.Count > 0)
        {
            _prescriptionSequence#.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_prescriptionSequence#, fieldData);
        }

        return _prescriptionSequence#;
    } 
}

internal HL7V21Field _quantityDispensed;

public HL7V21Field QuantityDispensed
{
    get
    {
        if (_quantityDispensed != null)
        {
            return _quantityDispensed;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _quantityDispensed = new HL7V21Field
        {
            field = message[@"RX1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityDispensed.field.FieldRepetitions != null && _quantityDispensed.field.FieldRepetitions.Count > 0)
        {
            _quantityDispensed.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_quantityDispensed, fieldData);
        }

        return _quantityDispensed;
    } 
}

internal HL7V21Field _unused;

public HL7V21Field Unused
{
    get
    {
        if (_unused != null)
        {
            return _unused;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _unused = new HL7V21Field
        {
            field = message[@"RX1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unused.field.FieldRepetitions != null && _unused.field.FieldRepetitions.Count > 0)
        {
            _unused.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_unused, fieldData);
        }

        return _unused;
    } 
}

internal HL7V21Field _drugId;

public HL7V21Field DrugId
{
    get
    {
        if (_drugId != null)
        {
            return _drugId;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _drugId = new HL7V21Field
        {
            field = message[@"RX1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drugId.field.FieldRepetitions != null && _drugId.field.FieldRepetitions.Count > 0)
        {
            _drugId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_drugId, fieldData);
        }

        return _drugId;
    } 
}

internal HL7V21Field _componentDrugIds;

public HL7V21Field ComponentDrugIds
{
    get
    {
        if (_componentDrugIds != null)
        {
            return _componentDrugIds;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _componentDrugIds = new HL7V21Field
        {
            field = message[@"RX1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentDrugIds.field.FieldRepetitions != null && _componentDrugIds.field.FieldRepetitions.Count > 0)
        {
            _componentDrugIds.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_componentDrugIds, fieldData);
        }

        return _componentDrugIds;
    } 
}

internal HL7V21Field _prescriptionType;

public HL7V21Field PrescriptionType
{
    get
    {
        if (_prescriptionType != null)
        {
            return _prescriptionType;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _prescriptionType = new HL7V21Field
        {
            field = message[@"RX1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_prescriptionType.field.FieldRepetitions != null && _prescriptionType.field.FieldRepetitions.Count > 0)
        {
            _prescriptionType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_prescriptionType, fieldData);
        }

        return _prescriptionType;
    } 
}

internal HL7V21Field _substitutionStatus;

public HL7V21Field SubstitutionStatus
{
    get
    {
        if (_substitutionStatus != null)
        {
            return _substitutionStatus;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _substitutionStatus = new HL7V21Field
        {
            field = message[@"RX1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substitutionStatus.field.FieldRepetitions != null && _substitutionStatus.field.FieldRepetitions.Count > 0)
        {
            _substitutionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_substitutionStatus, fieldData);
        }

        return _substitutionStatus;
    } 
}

internal HL7V21Field _rxOrderStatus;

public HL7V21Field RxOrderStatus
{
    get
    {
        if (_rxOrderStatus != null)
        {
            return _rxOrderStatus;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _rxOrderStatus = new HL7V21Field
        {
            field = message[@"RX1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rxOrderStatus.field.FieldRepetitions != null && _rxOrderStatus.field.FieldRepetitions.Count > 0)
        {
            _rxOrderStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rxOrderStatus, fieldData);
        }

        return _rxOrderStatus;
    } 
}

internal HL7V21Field _numberOfRefills;

public HL7V21Field NumberOfRefills
{
    get
    {
        if (_numberOfRefills != null)
        {
            return _numberOfRefills;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _numberOfRefills = new HL7V21Field
        {
            field = message[@"RX1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfRefills.field.FieldRepetitions != null && _numberOfRefills.field.FieldRepetitions.Count > 0)
        {
            _numberOfRefills.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_numberOfRefills, fieldData);
        }

        return _numberOfRefills;
    } 
}

internal HL7V21Field _unused;

public HL7V21Field Unused
{
    get
    {
        if (_unused != null)
        {
            return _unused;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _unused = new HL7V21Field
        {
            field = message[@"RX1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unused.field.FieldRepetitions != null && _unused.field.FieldRepetitions.Count > 0)
        {
            _unused.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_unused, fieldData);
        }

        return _unused;
    } 
}

internal HL7V21Field _refillsRemaining;

public HL7V21Field RefillsRemaining
{
    get
    {
        if (_refillsRemaining != null)
        {
            return _refillsRemaining;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _refillsRemaining = new HL7V21Field
        {
            field = message[@"RX1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_refillsRemaining.field.FieldRepetitions != null && _refillsRemaining.field.FieldRepetitions.Count > 0)
        {
            _refillsRemaining.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_refillsRemaining, fieldData);
        }

        return _refillsRemaining;
    } 
}

internal HL7V21Field _deaClass;

public HL7V21Field DeaClass
{
    get
    {
        if (_deaClass != null)
        {
            return _deaClass;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _deaClass = new HL7V21Field
        {
            field = message[@"RX1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deaClass.field.FieldRepetitions != null && _deaClass.field.FieldRepetitions.Count > 0)
        {
            _deaClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_deaClass, fieldData);
        }

        return _deaClass;
    } 
}

internal HL7V21Field _orderingMdsDeaNumber;

public HL7V21Field OrderingMdsDeaNumber
{
    get
    {
        if (_orderingMdsDeaNumber != null)
        {
            return _orderingMdsDeaNumber;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _orderingMdsDeaNumber = new HL7V21Field
        {
            field = message[@"RX1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderingMdsDeaNumber.field.FieldRepetitions != null && _orderingMdsDeaNumber.field.FieldRepetitions.Count > 0)
        {
            _orderingMdsDeaNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_orderingMdsDeaNumber, fieldData);
        }

        return _orderingMdsDeaNumber;
    } 
}

internal HL7V21Field _unused;

public HL7V21Field Unused
{
    get
    {
        if (_unused != null)
        {
            return _unused;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _unused = new HL7V21Field
        {
            field = message[@"RX1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unused.field.FieldRepetitions != null && _unused.field.FieldRepetitions.Count > 0)
        {
            _unused.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_unused, fieldData);
        }

        return _unused;
    } 
}

internal HL7V21Field _lastRefillDateTime;

public HL7V21Field LastRefillDateTime
{
    get
    {
        if (_lastRefillDateTime != null)
        {
            return _lastRefillDateTime;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _lastRefillDateTime = new HL7V21Field
        {
            field = message[@"RX1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lastRefillDateTime.field.FieldRepetitions != null && _lastRefillDateTime.field.FieldRepetitions.Count > 0)
        {
            _lastRefillDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_lastRefillDateTime, fieldData);
        }

        return _lastRefillDateTime;
    } 
}

internal HL7V21Field _rxNumber;

public HL7V21Field RxNumber
{
    get
    {
        if (_rxNumber != null)
        {
            return _rxNumber;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _rxNumber = new HL7V21Field
        {
            field = message[@"RX1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rxNumber.field.FieldRepetitions != null && _rxNumber.field.FieldRepetitions.Count > 0)
        {
            _rxNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rxNumber, fieldData);
        }

        return _rxNumber;
    } 
}

internal HL7V21Field _prnStatus;

public HL7V21Field PrnStatus
{
    get
    {
        if (_prnStatus != null)
        {
            return _prnStatus;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _prnStatus = new HL7V21Field
        {
            field = message[@"RX1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_prnStatus.field.FieldRepetitions != null && _prnStatus.field.FieldRepetitions.Count > 0)
        {
            _prnStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_prnStatus, fieldData);
        }

        return _prnStatus;
    } 
}

internal HL7V21Field _pharmacyInstructions;

public HL7V21Field PharmacyInstructions
{
    get
    {
        if (_pharmacyInstructions != null)
        {
            return _pharmacyInstructions;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _pharmacyInstructions = new HL7V21Field
        {
            field = message[@"RX1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacyInstructions.field.FieldRepetitions != null && _pharmacyInstructions.field.FieldRepetitions.Count > 0)
        {
            _pharmacyInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_pharmacyInstructions, fieldData);
        }

        return _pharmacyInstructions;
    } 
}

internal HL7V21Field _patientInstructions;

public HL7V21Field PatientInstructions
{
    get
    {
        if (_patientInstructions != null)
        {
            return _patientInstructions;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _patientInstructions = new HL7V21Field
        {
            field = message[@"RX1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientInstructions.field.FieldRepetitions != null && _patientInstructions.field.FieldRepetitions.Count > 0)
        {
            _patientInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientInstructions, fieldData);
        }

        return _patientInstructions;
    } 
}

internal HL7V21Field _instructionssig;

public HL7V21Field Instructionssig
{
    get
    {
        if (_instructionssig != null)
        {
            return _instructionssig;
        }

        var fieldData = new HL7V21FieldData
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
            Fields = null
        }

        _instructionssig = new HL7V21Field
        {
            field = message[@"RX1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_instructionssig.field.FieldRepetitions != null && _instructionssig.field.FieldRepetitions.Count > 0)
        {
            _instructionssig.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_instructionssig, fieldData);
        }

        return _instructionssig;
    } 
}
    }
}
