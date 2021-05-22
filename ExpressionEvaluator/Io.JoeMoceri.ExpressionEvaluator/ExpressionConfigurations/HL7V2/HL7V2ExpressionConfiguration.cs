using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{ 
    public class HL7V2ExpressionConfiguration : ExpressionConfigurationBase
    {
        private readonly IList<ExpressionConfigurationOperator> operators;
        private readonly ExpressionConfigurationOptions options;
        public static string fieldDelimiter = "|";
        public static string componentDelimiter = "^";
        public static string escapeDelimiter = "\\";
        public static string subComponentDelimiter = "&";
        public static string fieldRepetitionDelimiter = "~";
        private int delimiterCount;
        private string segment;
        private IList<HL7V2Field> fields;

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
                if (delimiterCount == 0)
                {
                    segment = expGroup.LeftOperand;
                    if (segment.Equals("MSH"))
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

                if (!expGroup.LeftOperand.Equals("MSH"))
                {
                    // get the components
                    if (expGroup.RightOperand.Contains(componentDelimiter))
                    {
                        field.Components = new List<HL7V2FieldComponent>();

                        var componentSplit = expGroup.RightOperand.Split(componentDelimiter);

                        for (var i = 0; i < componentSplit.Length; i++)
                        {
                            var component = new HL7V2FieldComponent
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
                                    var subComponent = new HL7V2FieldSubComponent
                                    {
                                        Delimiter = subComponentDelimiter,
                                        Value = subComponentSplit[j],
                                        Id = j + 1
                                    };

                                    if (subComponent.Value.Contains(fieldRepetitionDelimiter))
                                    {
                                        var fieldRepetitionSplit = subComponent.Value.Split(fieldRepetitionDelimiter);

                                        for (var k = 0; k < fieldRepetitionSplit.Length; k++)
                                        {
                                            var fieldRepetition = new HL7V2FieldRepetition
                                            {
                                                Delimiter = fieldRepetitionDelimiter,
                                                Value = fieldRepetitionSplit[k],
                                                Id = k + 1
                                            };

                                            subComponent.FieldRepetitions.Add(fieldRepetition);
                                        }
                                    }

                                    component.SubComponents.Add(subComponent);
                                }
                            }

                            field.Components.Add(component);
                        }
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
                }

                return DefaultExpressionResult;
            }
        }

        public void Setup()
        {
            fields = new List<HL7V2Field>();

            delimiterCount = 0;
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
            var result = new HL7V2MessageSegment
            {
                Fields = fields.Cast<IHL7V2Field>().ToList(),
                SegmentName = segment
            };

            return result;
        }
    }
}
