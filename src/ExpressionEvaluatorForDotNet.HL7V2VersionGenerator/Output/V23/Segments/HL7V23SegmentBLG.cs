using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentBLG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"BLG"; } }

        public string SegmentId { get { return @"BLG"; } }
        
        public string LongName { get { return @"Billing"; } }
        
        public string Description { get { return @"The BLG segment is used to provide billing information, on the ordered service, to the filling application."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Id = @"BLG.1",
                            Type = @"Field",
                            Position = @"BLG.1",
                            Name = @"When to Charge",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_CCD",
                            DataTypeName = @"Charge Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines when to charge for the ordered service.  The first component contains a value defined in HL7 table 0100 - When to charge.  The second component is used to express the exact time to charge for the ordered service; it is used only when the when to charge value is T.  When used, it is expressed as a TS data type.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BLG.1.1",
                            Type = @"Component",
                            Position = @"BLG.1.1",
                            Name = @"When To Charge Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0100",
                            TableName = @"When to charge",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.1.2",
                            Type = @"Component",
                            Position = @"BLG.1.2",
                            Name = @"Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BLG.1.2.1",
                            Type = @"SubComponent",
                            Position = @"BLG.1.2.1",
                            Name = @"Time Of An Event",
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
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.2",
                            Type = @"Field",
                            Position = @"BLG.2",
                            Name = @"Charge Type",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0122",
                            TableName = @"Charge type",
                            Description = @"This field identifies someone or something other than the patient to be billed for this service.  It is used in conjunction with BLG-3-account ID.  Refer to HL7 table 0122 - Charge type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.3",
                            Type = @"Field",
                            Position = @"BLG.3",
                            Name = @"Account ID",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the account to be billed.  It is used in conjunction with BLG-2-charge type.  Refer to HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BLG.3.1",
                            Type = @"Component",
                            Position = @"BLG.3.1",
                            Name = @"ID Number",
                            Length = 0,
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
                            Id = @"BLG.3.2",
                            Type = @"Component",
                            Position = @"BLG.3.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.3.3",
                            Type = @"Component",
                            Position = @"BLG.3.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.3.4",
                            Type = @"Component",
                            Position = @"BLG.3.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"BLG.3.4.1",
                            Type = @"SubComponent",
                            Position = @"BLG.3.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.3.4.2",
                            Type = @"SubComponent",
                            Position = @"BLG.3.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BLG.3.4.3",
                            Type = @"SubComponent",
                            Position = @"BLG.3.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        };
            }
        }

        public HL7V23SegmentBLG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field whentoCharge;

public HL7V23Field WhentoCharge
{
    get
    {
        if (whentoCharge != null)
        {
            return whentoCharge;
        }

        whentoCharge = new HL7V23Field
        {
            field = message[@"BLG"][1],
            Id = @"BLG.1",
            Type = @"Field",
            Position = @"BLG.1",
            Name = @"When to Charge",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_CCD",
            DataTypeName = @"Charge Time",
            TableId = null,
            TableName = null,
            Description = @"This field determines when to charge for the ordered service.  The first component contains a value defined in HL7 table 0100 - When to charge.  The second component is used to express the exact time to charge for the ordered service; it is used only when the when to charge value is T.  When used, it is expressed as a TS data type.",
            Sample = @"",
        };

        // check for repetitions
        if (whentoCharge.field.FieldRepetitions != null && whentoCharge.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whentoCharge.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < whentoCharge.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = whentoCharge.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < whentoCharge.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = whentoCharge.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < whentoCharge.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = whentoCharge.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            whentoCharge.fieldRepetitions = fieldRepetitions;
        }

        return whentoCharge;
    } 
}

internal HL7V23Field chargeType;

public HL7V23Field ChargeType
{
    get
    {
        if (chargeType != null)
        {
            return chargeType;
        }

        chargeType = new HL7V23Field
        {
            field = message[@"BLG"][2],
            Id = @"BLG.2",
            Type = @"Field",
            Position = @"BLG.2",
            Name = @"Charge Type",
            Length = 50,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0122",
            TableName = @"Charge type",
            Description = @"This field identifies someone or something other than the patient to be billed for this service.  It is used in conjunction with BLG-3-account ID.  Refer to HL7 table 0122 - Charge type for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (chargeType.field.FieldRepetitions != null && chargeType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(chargeType.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < chargeType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = chargeType.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < chargeType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = chargeType.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < chargeType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = chargeType.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            chargeType.fieldRepetitions = fieldRepetitions;
        }

        return chargeType;
    } 
}

internal HL7V23Field accountID;

public HL7V23Field AccountID
{
    get
    {
        if (accountID != null)
        {
            return accountID;
        }

        accountID = new HL7V23Field
        {
            field = message[@"BLG"][3],
            Id = @"BLG.3",
            Type = @"Field",
            Position = @"BLG.3",
            Name = @"Account ID",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the account to be billed.  It is used in conjunction with BLG-2-charge type.  Refer to HL7 table 0061 - Check digit scheme",
            Sample = @"",
        };

        // check for repetitions
        if (accountID.field.FieldRepetitions != null && accountID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(accountID.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < accountID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = accountID.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < accountID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = accountID.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < accountID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = accountID.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            accountID.fieldRepetitions = fieldRepetitions;
        }

        return accountID;
    } 
}
    }
}
