using System.Collections.Generic;

namespace ExpressionEvaluator
{
    public class EEExpressionsLanguageTemplate : LanguageTemplateBase
    {
        private readonly IList<LanguageTemplateOperator> mathOperators;
        private readonly IList<LanguageTemplateOperator> booleanOperators;

        public EEExpressionsLanguageTemplate()
        {
            mathOperators = new List<LanguageTemplateOperator>
            {
                CreateLanguageTemplateOperator(Operator.Addition, OperatorPrecedence.Lower, "+"),
                CreateLanguageTemplateOperator(Operator.Subtraction, OperatorPrecedence.Lower, "-"),
                CreateLanguageTemplateOperator(Operator.Multiplication, OperatorPrecedence.Higher, "*"),
                CreateLanguageTemplateOperator(Operator.Division, OperatorPrecedence.Higher, "/"),
                CreateLanguageTemplateOperator(Operator.Modulus, OperatorPrecedence.Higher, "%"),
            };

            booleanOperators = new List<LanguageTemplateOperator>
            {
                CreateLanguageTemplateOperator(Operator.And, OperatorPrecedence.Lower, "and"),
                CreateLanguageTemplateOperator(Operator.And, OperatorPrecedence.Lower, "&&"),
                CreateLanguageTemplateOperator(Operator.Or, OperatorPrecedence.Lower, "||"),
                CreateLanguageTemplateOperator(Operator.Or, OperatorPrecedence.Lower, "or"),
                CreateLanguageTemplateOperator(Operator.LessThanOrEqualTo, OperatorPrecedence.Higher, "<="),
                CreateLanguageTemplateOperator(Operator.GreaterThanOrEqualTo, OperatorPrecedence.Higher, ">="),
                CreateLanguageTemplateOperator(Operator.EqualTo, OperatorPrecedence.Higher, "=="),
                CreateLanguageTemplateOperator(Operator.NotEqualTo, OperatorPrecedence.Higher, "!="),
                CreateLanguageTemplateOperator(Operator.LessThan, OperatorPrecedence.Higher, "<"),
                CreateLanguageTemplateOperator(Operator.GreaterThan, OperatorPrecedence.Higher, ">"),
            };
        }

        private LanguageTemplateOperator CreateLanguageTemplateOperator(Operator expressionOperator, OperatorPrecedence operatorPrecedence, string operatorName)
        {
            return new LanguageTemplateOperator
            {
                ExpressionOperator = expressionOperator,
                ExpressionOperatorPrecedence = operatorPrecedence,
                OperatorName = operatorName
            };
        }

        public override string Name => "EE Expressions";

        public override IList<LanguageTemplateOperator> BooleanOperators 
        {
            get
            {
                return booleanOperators;
            }
        }

        public override IList<LanguageTemplateOperator> MathOperators
        {
            get
            {
                return mathOperators;
            }
        }
    }
}
