using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public abstract class LanguageTemplateBase
    {
        public abstract string Name { get; }
        public abstract IList<LanguageTemplateOperator> MathStringOperators { get; }
        public abstract IList<LanguageTemplateOperator> BooleanOperators { get; }

        public abstract IList<LanguageTemplateOperator> Operators { get; }

        public abstract LanguageTemplateOptions Options { get; }

        public ExpressionResult DefaultExpressionResult => new ExpressionResult
        {
            Value = "\"done\"",
            Type = VariableType.String
        };
    }
}