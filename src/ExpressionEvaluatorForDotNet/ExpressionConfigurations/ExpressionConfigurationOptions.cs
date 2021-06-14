namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// This class represents the options for configuring an <see cref="ExpressionConfigurationBase"/>.
    /// </summary>
    public class ExpressionConfigurationOptions
    {
        /// <summary>
        /// Whether the evaluator should ignore whitespace outside quotes, or remove them.
        /// </summary>
        public bool IgnoreWhitespaceOutsideQuotes { get; set; }

        /// <summary>
        /// Whether the evaluator should ignore parentheses, or break them down.
        /// </summary>
        public bool IgnoreParentheses { get; set; }

        /// <summary>
        /// Whether the evaluator should ignore validating quotes, or validate them.
        /// </summary>
        public bool IgnoreQuotesValidation { get; set; }
    }
}
