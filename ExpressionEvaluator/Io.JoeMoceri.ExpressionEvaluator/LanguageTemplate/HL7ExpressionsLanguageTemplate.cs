using Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7ExpressionsLanguageTemplate : LanguageTemplateBase
    {
        private readonly IList<LanguageTemplateOperator> operators;
        private readonly LanguageTemplateOptions options;
        private int delimiterCount;
        private string segment;
        private IList<HL7Part> parts;

        public HL7ExpressionsLanguageTemplate()
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
                parts.Add(new HL7Part
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
                IgnoreParentheses = true
            };

        }

        public void Setup()
        {
            parts = new List<HL7Part>();

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

        public override string Name => "HL7 Expressions";

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

        public HL7Result GetHL7Result()
        {
            var result = new HL7Result
            {
                Parts = parts,
                Segment = segment
            };

            return result;
        }
    }
}
