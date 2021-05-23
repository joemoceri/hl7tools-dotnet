using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{ 
    public class HL7V2ExpressionConfiguration : ExpressionConfigurationBase
    {
        private readonly IList<ExpressionConfigurationOperator> operators;
        private readonly ExpressionConfigurationOptions options;
        public static string headerSegmentName = "MSH";
        public static string fieldDelimiter = "|";
        public static string componentDelimiter = "^";
        public static string escapeDelimiter = "\\";
        public static string subComponentDelimiter = "&";
        public static string fieldRepetitionDelimiter = "~";
        public static string presentButNull = "\"\"";
        public static IList<string> specialSegmentHeaders;
        public static IDictionary<string, string> encodingConversions;
        public string endCharacter;
        private int delimiterCount;
        private string segment;
        private IList<HL7V2Field> fields;

        static HL7V2ExpressionConfiguration()
        {
            RebuildEncodingConversions();

            // TODO: I think this should update the delimiters. I need more concrete examples to test against. But this will work for single FHS / BHS segments, I'm not sure for more. I need a test message to see.
            specialSegmentHeaders = new List<string>()
            {
                "MSH",
                "FHS",
                "BHS"
            };
        }

        public static void RebuildEncodingConversions()
        {
            encodingConversions = new Dictionary<string, string>();
            encodingConversions.Add(escapeDelimiter, $"{escapeDelimiter}E{escapeDelimiter}");
            encodingConversions.Add(fieldDelimiter, $"{escapeDelimiter}F{escapeDelimiter}");
            encodingConversions.Add(fieldRepetitionDelimiter, $"{escapeDelimiter}R{escapeDelimiter}");
            encodingConversions.Add(componentDelimiter, $"{escapeDelimiter}S{escapeDelimiter}");
            encodingConversions.Add(subComponentDelimiter, $"{escapeDelimiter}T{escapeDelimiter}");
        }

        public static string EncodeString(string input, bool rebuildEncodingConversions = false)
        {
            if (input == null)
            {
                return presentButNull;
            }

            if (rebuildEncodingConversions)
            {
                RebuildEncodingConversions();
            }

            foreach (var encodingConversion in encodingConversions)
            {
                input = input.Replace(encodingConversion.Key, encodingConversion.Value);
            }

            return input;
        }

        public static string DecodeString(string input, bool rebuildEncodingConversions = false)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            if (rebuildEncodingConversions)
            {
                RebuildEncodingConversions();
            }

            foreach (var escapeConversion in encodingConversions)
            {
                input = input.Replace(escapeConversion.Value, escapeConversion.Key);
            }

            return input;
        }

        public HL7V2ExpressionConfiguration()
        {
            operators = new List<ExpressionConfigurationOperator>
            {
                CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, fieldDelimiter)
            };

            options = new ExpressionConfigurationOptions
            {
                IgnoreWhitespaceOutsideQuotes = true,
                IgnoreParentheses = true,
                IgnoreQuotesValidation = true
            };

            Setup();

            var additionOperator = MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

            additionOperator.SolveOperatorExpression = FieldSolveOperatorExpression;

            ExpressionResult FieldSolveOperatorExpression(ExpressionGroup expGroup)
            {
                // found the end character
                if (endCharacter != null && expGroup.RightOperand.EndsWith(endCharacter))
                {
                    var split = expGroup.RightOperand.Split(endCharacter);

                    // on the absolutely out there case somebody else uses this same end character in the data
                    if (split.Length > 2)
                    {
                        var result = "";

                        // get the value, ignoring the end one I put there
                        for (var i = 0; i < split.Length - 1; i++)
                        {
                            result += split[i];
                        }

                        // update it
                        expGroup.RightOperand = result;
                    }
                    // only 2 elements if it's just my end character, ignore the empty
                    else
                    {
                        expGroup.RightOperand = split[0];
                    }
                }

                if (delimiterCount == 0)
                {
                    segment = expGroup.LeftOperand;
                    if (specialSegmentHeaders.Any(a => a.Equals(segment)))
                    {
                        delimiterCount++;

                        fields.Add(new HL7V2Field
                        {
                            Delimiter = additionOperator.OperatorName,
                            Id = delimiterCount,
                            Value = additionOperator.OperatorName
                        });
                    }

                }

                delimiterCount++;

                var field = new HL7V2Field
                {
                    Delimiter = additionOperator.OperatorName,
                    Id = delimiterCount,
                    Value = expGroup.RightOperand
                }; 

                fields.Add(field);

                if (specialSegmentHeaders.Any(a => a.Equals(expGroup.LeftOperand)))
                {
                    return DefaultExpressionResult;
                }

                // fields contain field repetition
                if (expGroup.RightOperand.Contains(fieldRepetitionDelimiter))
                {
                    var fieldRepetitionSplit = expGroup.RightOperand.Split(fieldRepetitionDelimiter);

                    for (var j = 0; j < fieldRepetitionSplit.Length; j++)
                    {
                        var fieldRepetition = new HL7V2FieldRepetition
                        {
                            Delimiter = fieldRepetitionDelimiter,
                            Value = fieldRepetitionSplit[j],
                            Id = j + 1
                        };

                        field.FieldRepetitions.Add(fieldRepetition);
                    }
                }
                else
                {
                    field.FieldRepetitions.Add(new HL7V2FieldRepetition
                    {
                        Delimiter = fieldRepetitionDelimiter,
                        Value = expGroup.RightOperand,
                        Id = 1
                    });
                }

                for (var k = 0; k < field.FieldRepetitions.Count; k++)
                {
                    var fieldRepetition = field.FieldRepetitions[k];

                    // get the components
                    if (fieldRepetition.Value.Contains(componentDelimiter))
                    {
                        fieldRepetition.Components = new List<HL7V2Component>();

                        var componentSplit = fieldRepetition.Value.Split(componentDelimiter);

                        for (var i = 0; i < componentSplit.Length; i++)
                        {
                            var component = new HL7V2Component
                            {
                                Delimiter = componentDelimiter,
                                Value = componentSplit[i],
                                Id = i + 1
                            };

                            if (component.Value.Contains(subComponentDelimiter))
                            {
                                var subComponentSplit = component.Value.Split(subComponentDelimiter);

                                for (var j = 0; j < subComponentSplit.Length; j++)
                                {
                                    var subComponent = new HL7V2SubComponent
                                    {
                                        Delimiter = subComponentDelimiter,
                                        Value = subComponentSplit[j],
                                        Id = j + 1
                                    };

                                    component.SubComponents.Add(subComponent);
                                }
                            }

                            fieldRepetition.Components.Add(component);
                        }
                    }
                }

                return DefaultExpressionResult;
            }
        }

        public void Setup()
        {
            fields = new List<HL7V2Field>();

            delimiterCount = 0;

            segment = null;
        }

        public override string Name => "HL7 V2";

        public override IList<ExpressionConfigurationOperator> MathStringOperators 
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        public override IList<ExpressionConfigurationOperator> BooleanOperators
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        public override IList<ExpressionConfigurationOperator> Operators => operators;

        public override ExpressionConfigurationOptions Options => options;

        public HL7V2MessageSegment GetHL7V2MessageSegment()
        {
            if (segment == null)
            {
                return null;
            }

            var result = new HL7V2MessageSegment
            {
                Fields = fields,
                SegmentName = segment
            };

            return result;
        }
    }
}
