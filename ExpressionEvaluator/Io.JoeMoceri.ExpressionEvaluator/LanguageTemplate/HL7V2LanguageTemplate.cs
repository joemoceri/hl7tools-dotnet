using Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    // TODO: Look into adding language templates for sub-fields and sub-sub-fields.
    // | : Field delimiter
    // ^ : Sub-Field delimiter
    // & : Sub-Sub-Field delimiter
    // ~ : Separates repeating fields
    public class HL7V2LanguageTemplate : LanguageTemplateBase
    {
        private readonly IList<LanguageTemplateOperator> operators;
        private readonly LanguageTemplateOptions options;
        private int delimiterCount;
        private string segment;
        private IList<HL7V2Field> fields;

        public HL7V2LanguageTemplate()
        {
            operators = new List<LanguageTemplateOperator>
            {
                CreateLanguageTemplateOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "|")
            };

            Setup();

            var additionOperator = MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

            additionOperator.SolveOperatorExpression = (expGroup) =>
            {
                if (delimiterCount == 0)
                {
                    segment = expGroup.LeftOperand;
                }

                delimiterCount++;
                fields.Add(new HL7V2Field
                {
                    Delimiter = additionOperator.OperatorName,
                    DelimiterIndex = delimiterCount,
                    Value = expGroup.RightOperand
                });

                // just return something to make the evaluator happy. The final expression will always be this if it runs successfully.
                return DefaultExpressionResult;
            };

            options = new LanguageTemplateOptions
            {
                IgnoreWhitespaceOutsideQuotes = true,
                IgnoreParentheses = true,
                IgnoreQuotesValidation = true
            };

        }

        public void Setup()
        {
            fields = new List<HL7V2Field>();

            delimiterCount = 0;
        }

        private LanguageTemplateOperator CreateLanguageTemplateOperator(
            Operator expressionOperator, 
            OperatorPrecedence operatorPrecedence, 
            OperatorType expressionOperatorType,
            string operatorName, 
            Func<ExpressionGroup, ExpressionResult> solveOperatorExpression = null,
            Action<ExpressionGroup> onBeforeOperatorExpressionSolved = null,
            Action<ExpressionResult> onAfterOperatorExpressionSolved = null)
        {
            return new LanguageTemplateOperator
            {
                ExpressionOperator = expressionOperator,
                ExpressionOperatorPrecedence = operatorPrecedence,
                ExpressionOperatorType = expressionOperatorType,
                OperatorName = operatorName,
                SolveOperatorExpression = solveOperatorExpression,
                OnBeforeOperatorExpressionSolved = onBeforeOperatorExpressionSolved,
                OnAfterOperatorExpressionSolved = onAfterOperatorExpressionSolved
            };
        }

        public override string Name => "HL7 V2";

        public override IList<LanguageTemplateOperator> MathStringOperators 
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        public override IList<LanguageTemplateOperator> BooleanOperators
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        public override IList<LanguageTemplateOperator> Operators => operators;

        public override LanguageTemplateOptions Options => options;

        public HL7V2MessageSegment GetHL7V2MessageSegment()
        {
            var result = new HL7V2MessageSegment
            {
                Fields = fields,
                SegmentName = segment
            };

            return result;
        }
    }
}
