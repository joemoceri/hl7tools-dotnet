using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public static class HL7V2FieldGenerator
    {
        public static IList<HL7V21FieldRepetition> GenerateV21FieldRepetitions(HL7V21Field field, HL7V21FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V21FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V21FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V21Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V21Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V21SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V21SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],                                    
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V22FieldRepetition> GenerateV22FieldRepetitions(HL7V22Field field, HL7V22FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V22FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V22FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V22Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V22Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V22SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V22SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V23FieldRepetition> GenerateV23FieldRepetitions(HL7V23Field field, HL7V23FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V23Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V231FieldRepetition> GenerateV231FieldRepetitions(HL7V231Field field, HL7V231FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V231Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V24FieldRepetition> GenerateV24FieldRepetitions(HL7V24Field field, HL7V24FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V24Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V25FieldRepetition> GenerateV25FieldRepetitions(HL7V25Field field, HL7V25FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V25FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V25FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V25Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V25Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V25SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V25SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V251FieldRepetition> GenerateV251FieldRepetitions(HL7V251Field field, HL7V251FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V251Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V26FieldRepetition> GenerateV26FieldRepetitions(HL7V26Field field, HL7V26FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V26FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V26FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V26Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V26Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V26SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V26SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V27FieldRepetition> GenerateV27FieldRepetitions(HL7V27Field field, HL7V27FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V27Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V27Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V27SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V271FieldRepetition> GenerateV271FieldRepetitions(HL7V271Field field, HL7V271FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V271FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V271FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V271Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V271Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = componentFieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V271SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V271SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }

        public static IList<HL7V28FieldRepetition> GenerateV28FieldRepetitions(HL7V28Field field, HL7V28FieldData fieldData)
        {
            var fieldRepetitions = new List<HL7V28FieldRepetition>();

            for (var i = 0; i < field.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V28FieldRepetition
                {
                    fieldRepetition = field.field.FieldRepetitions[i],
                    fieldData = fieldData
                };

                // check for components if the definition specifies it does
                if (fieldData.Fields != null && fieldData.Fields.Count > 0)
                {
                    var components = new List<HL7V28Component>();

                    // there should be components per repetition
                    for (var j = 0; j < field.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.Fields[j];
                        var component = new HL7V28Component
                        {
                            component = field.field.FieldRepetitions[i].Components[j],
                            fieldData = fieldData
                        };

                        // check for sub components
                        if (componentFieldData.Fields != null && componentFieldData.Fields.Count > 0)
                        {
                            var subComponents = new List<HL7V28SubComponent>();

                            for (var k = 0; k < field.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.Fields[k];
                                var subComponent = new HL7V28SubComponent
                                {
                                    subComponent = field.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    fieldData = subComponentFieldData
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

            return fieldRepetitions;
        }
    }
}
