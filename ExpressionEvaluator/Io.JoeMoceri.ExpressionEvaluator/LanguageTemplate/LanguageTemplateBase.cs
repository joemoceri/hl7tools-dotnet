using System.Collections.Generic;

namespace ExpressionEvaluator
{
    public abstract class LanguageTemplateBase
    {
        public abstract string Name { get; }
        public abstract IList<LanguageTemplateOperator> BooleanOperators { get; }
        public abstract IList<LanguageTemplateOperator> MathOperators { get; }
    }
}
