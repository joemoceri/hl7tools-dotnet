using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public abstract class LanguageTemplateBase
    {
        public abstract string Name { get; }
        public abstract IList<LanguageTemplateOperator> MathStringOperators { get; }
        public abstract IList<LanguageTemplateOperator> BooleanOperators { get; }

        public abstract IList<LanguageTemplateOperator> Operators { get; }
    }
}