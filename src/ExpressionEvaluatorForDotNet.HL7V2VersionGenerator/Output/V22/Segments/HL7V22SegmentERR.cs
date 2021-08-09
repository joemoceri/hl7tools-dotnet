using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentERR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERR"; } }

        public string SegmentId { get { return @"ERR"; } }
        
        public string LongName { get { return @"Error"; } }
        
        public string Description { get { return @"The ERR segment is used to add error comments to acknowledgement messages"; } }
        
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
                            Id = @"ERR.1",
                            Type = @"Field",
                            Position = @"ERR.1",
                            Name = @"Error Code And Location",
                            Length = 80,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CM_ELD",
                            DataTypeName = @"Error",
                            TableId = null,
                            TableName = null,
                            Description = @"identifies an erroneous segment in another message.  The second component is an index if there are more than one segment of type <segment ID>.  For systems that do not use the HL7 Encoding Rules, the data item number may be used for the third component.  The fourth component references a user-defined error table and is restricted from having any subcomponents as the subcomponent separator is now the CE's component separator",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ERR.1.1",
                            Type = @"Component",
                            Position = @"ERR.1.1",
                            Name = @"Segment-id",
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
                            Id = @"ERR.1.2",
                            Type = @"Component",
                            Position = @"ERR.1.2",
                            Name = @"Sequence",
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
                            Id = @"ERR.1.3",
                            Type = @"Component",
                            Position = @"ERR.1.3",
                            Name = @"Field-position",
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
                            Id = @"ERR.1.4",
                            Type = @"Component",
                            Position = @"ERR.1.4",
                            Name = @"Code Identifying Error",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0060",
                            TableName = @"ERROR CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.1",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.2",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.3",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.4",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.5",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.6",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        };
            }
        }

        public HL7V22SegmentERR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field errorCodeAndLocation;

public HL7V22Field ErrorCodeAndLocation
{
    get
    {
        if (errorCodeAndLocation != null)
        {
            return errorCodeAndLocation;
        }

        errorCodeAndLocation = new HL7V22Field
        {
            field = message[@"ERR"][1],
            Id = @"ERR.1",
            Type = @"Field",
            Position = @"ERR.1",
            Name = @"Error Code And Location",
            Length = 80,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CM_ELD",
            DataTypeName = @"Error",
            TableId = null,
            TableName = null,
            Description = @"identifies an erroneous segment in another message.  The second component is an index if there are more than one segment of type <segment ID>.  For systems that do not use the HL7 Encoding Rules, the data item number may be used for the third component.  The fourth component references a user-defined error table and is restricted from having any subcomponents as the subcomponent separator is now the CE's component separator",
            Sample = @"",
        };

        // check for repetitions
        if (errorCodeAndLocation.field.FieldRepetitions != null && errorCodeAndLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(errorCodeAndLocation.Id));
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < errorCodeAndLocation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = errorCodeAndLocation.field.FieldRepetitions[i],
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
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < errorCodeAndLocation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V22Component
                        {
                            component = errorCodeAndLocation.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < errorCodeAndLocation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = errorCodeAndLocation.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            errorCodeAndLocation.fieldRepetitions = fieldRepetitions;
        }

        return errorCodeAndLocation;
    } 
}
    }
}
