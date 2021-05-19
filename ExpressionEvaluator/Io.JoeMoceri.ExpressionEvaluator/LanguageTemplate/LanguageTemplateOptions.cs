using System;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class LanguageTemplateOptions
    {
        public bool IgnoreWhitespaceOutsideQuotes { get; set; }

        public bool IgnoreParentheses { get; set; }

        public bool IgnoreQuotesValidation { get; set; }
    }
}
