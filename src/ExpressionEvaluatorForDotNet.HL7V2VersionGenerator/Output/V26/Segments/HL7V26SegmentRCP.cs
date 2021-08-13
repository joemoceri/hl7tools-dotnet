using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentRCP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RCP"; } }

        public string SegmentId { get { return @"RCP"; } }
        
        public string LongName { get { return @"Response Control Parameter"; } }
        
        public string Description { get { return @"The RCP segment is used to restrict the amount of data that should be returned in response to query."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V26SegmentRCP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _queryPriority;

public HL7V26Field QueryPriority
{
    get
    {
        if (_queryPriority != null)
        {
            return _queryPriority;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RCP.1",
            Type = @"Field",
            Position = @"RCP.1",
            Name = @"Query Priority",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0091",
            TableName = @"Query priority",
            Description = @"This field contains the time frame in which the response is expected. Refer to HL7 Table 0091 - Query priority for valid values. Table values and subsequent fields specify time frames for response.",
            Sample = @"",
            Fields = null
        }

        _queryPriority = new HL7V26Field
        {
            field = message[@"RCP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryPriority.field.FieldRepetitions != null && _queryPriority.field.FieldRepetitions.Count > 0)
        {
            _queryPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_queryPriority, fieldData);
        }

        return _queryPriority;
    } 
}

internal HL7V26Field _quantityLimitedRequest;

public HL7V26Field QuantityLimitedRequest
{
    get
    {
        if (_quantityLimitedRequest != null)
        {
            return _quantityLimitedRequest;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RCP.2",
            Type = @"Field",
            Position = @"RCP.2",
            Name = @"Quantity Limited Request",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the maximum length of the response that can be accepted by the requesting system. Valid entries are numerical values (in the first component) given in the units specified in the second component. Default is LI (lines).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RCP.2.1",
                            Type = @"Component",
                            Position = @"RCP.2.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2",
                            Type = @"Component",
                            Position = @"RCP.2.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.1",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.2",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.3",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.4",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.5",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.6",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.7",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.8",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.9",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _quantityLimitedRequest = new HL7V26Field
        {
            field = message[@"RCP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityLimitedRequest.field.FieldRepetitions != null && _quantityLimitedRequest.field.FieldRepetitions.Count > 0)
        {
            _quantityLimitedRequest.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_quantityLimitedRequest, fieldData);
        }

        return _quantityLimitedRequest;
    } 
}

internal HL7V26Field _responseModality;

public HL7V26Field ResponseModality
{
    get
    {
        if (_responseModality != null)
        {
            return _responseModality;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RCP.3",
            Type = @"Field",
            Position = @"RCP.3",
            Name = @"Response Modality",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0394",
            TableName = @"Response modality",
            Description = @"This field specifies the timing and grouping of the response message(s). Refer to HL7 Table 0394 - Response modality for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RCP.3.1",
                            Type = @"Component",
                            Position = @"RCP.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.2",
                            Type = @"Component",
                            Position = @"RCP.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.3",
                            Type = @"Component",
                            Position = @"RCP.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.4",
                            Type = @"Component",
                            Position = @"RCP.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.5",
                            Type = @"Component",
                            Position = @"RCP.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.6",
                            Type = @"Component",
                            Position = @"RCP.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.7",
                            Type = @"Component",
                            Position = @"RCP.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.8",
                            Type = @"Component",
                            Position = @"RCP.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.9",
                            Type = @"Component",
                            Position = @"RCP.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _responseModality = new HL7V26Field
        {
            field = message[@"RCP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_responseModality.field.FieldRepetitions != null && _responseModality.field.FieldRepetitions.Count > 0)
        {
            _responseModality.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_responseModality, fieldData);
        }

        return _responseModality;
    } 
}

internal HL7V26Field _executionandDeliveryTime;

public HL7V26Field ExecutionandDeliveryTime
{
    get
    {
        if (_executionandDeliveryTime != null)
        {
            return _executionandDeliveryTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RCP.4",
            Type = @"Field",
            Position = @"RCP.4",
            Name = @"Execution and Delivery Time",
            Length = 24,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"Specifies the time the response is to be returned. This field is only valued when RCP-1-Query priority contains the value D (Deferred).",
            Sample = @"",
            Fields = null
        }

        _executionandDeliveryTime = new HL7V26Field
        {
            field = message[@"RCP"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_executionandDeliveryTime.field.FieldRepetitions != null && _executionandDeliveryTime.field.FieldRepetitions.Count > 0)
        {
            _executionandDeliveryTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_executionandDeliveryTime, fieldData);
        }

        return _executionandDeliveryTime;
    } 
}

internal HL7V26Field _modifyIndicator;

public HL7V26Field ModifyIndicator
{
    get
    {
        if (_modifyIndicator != null)
        {
            return _modifyIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RCP.5",
            Type = @"Field",
            Position = @"RCP.5",
            Name = @"Modify Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0395",
            TableName = @"Modify indicator",
            Description = @"This field specifies whether the subscription is new or is being modified. Refer to HL7 Table 0395 - Modify indicatorfor valid values.",
            Sample = @"",
            Fields = null
        }

        _modifyIndicator = new HL7V26Field
        {
            field = message[@"RCP"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_modifyIndicator.field.FieldRepetitions != null && _modifyIndicator.field.FieldRepetitions.Count > 0)
        {
            _modifyIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_modifyIndicator, fieldData);
        }

        return _modifyIndicator;
    } 
}

internal HL7V26Field _sortbyField;

public HL7V26Field SortbyField
{
    get
    {
        if (_sortbyField != null)
        {
            return _sortbyField;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RCP.6",
            Type = @"Field",
            Position = @"RCP.6",
            Name = @"Sort-by Field",
            Length = 512,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SRT",
            DataTypeName = @"Sort Order",
            TableId = null,
            TableName = null,
            Description = @"For queries requesting a tabular response, this field specifies by which fields the response is to be sorted, and the order(s) in which sorting is to be performed. When the QSC variant is not in use, the values specified for the first component in this field are derived from the ColName field of the Output Specification and Commentary; see section 5.3.3.1, "" Query Profile template for query with tabular response ."" When the QSC variant is used, the values are derived from the ColName field of the Input/Output Specification and Commentary; see section 5.9.4.1, "" Pharmacy example "" for an example.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RCP.6.1",
                            Type = @"Component",
                            Position = @"RCP.6.1",
                            Name = @"Sort-by Field",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the field by which the response will be sorted. In a tabular response, this will be the column name to sort by. In the Segment Pattern and the Display Response, this will be the segment field name to sort by. See QIP in Section 2.A.59.1, ""Segment Field Name (ST)"" for segment field name definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.6.2",
                            Type = @"Component",
                            Position = @"RCP.6.2",
                            Name = @"Sequencing",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0397",
                            TableName = @"Sequencing",
                            Description = @"Identifies how the field or parameter will be sorted; and, if sorted, whether the sort will be case sensitive (the default) or not. Refer to HL7 Table 0397 - Sequencing for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sortbyField = new HL7V26Field
        {
            field = message[@"RCP"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sortbyField.field.FieldRepetitions != null && _sortbyField.field.FieldRepetitions.Count > 0)
        {
            _sortbyField.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_sortbyField, fieldData);
        }

        return _sortbyField;
    } 
}

internal HL7V26Field _segmentgroupinclusion;

public HL7V26Field Segmentgroupinclusion
{
    get
    {
        if (_segmentgroupinclusion != null)
        {
            return _segmentgroupinclusion;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RCP.7",
            Type = @"Field",
            Position = @"RCP.7",
            Name = @"Segment group inclusion",
            Length = 256,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0391",
            TableName = @"Segment group",
            Description = @"Specifies those optional segment groups which are to be included in the response. Refer to HL7 Table 0391Segment group for values for Segment Group. This is a repeating field, to accommodate inclusion of multiple segment groups. The default for this field, not present, means that all relevant groups are included.",
            Sample = @"",
            Fields = null
        }

        _segmentgroupinclusion = new HL7V26Field
        {
            field = message[@"RCP"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentgroupinclusion.field.FieldRepetitions != null && _segmentgroupinclusion.field.FieldRepetitions.Count > 0)
        {
            _segmentgroupinclusion.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_segmentgroupinclusion, fieldData);
        }

        return _segmentgroupinclusion;
    } 
}
    }
}
