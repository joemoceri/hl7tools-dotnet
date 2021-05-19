using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{ 
    public class HL7V2ExpressionConfiguration : ExpressionConfigurationBase
    {
        private readonly IList<ExpressionConfigurationOperator> operators;
        private readonly ExpressionConfigurationOptions options;
        private int delimiterCount;
        private string segment;
        private IList<HL7V2Field> fields;

        public HL7V2ExpressionConfiguration()
        {
            operators = new List<ExpressionConfigurationOperator>
            {
                CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "|")
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

            options = new ExpressionConfigurationOptions
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
                Fields = fields,
                SegmentName = segment
            };

            return result;
        }
    }
}
