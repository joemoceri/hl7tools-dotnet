using System.Collections.Generic;
using System.Linq;

namespace ExpressionEvaluatorForDotNet
{ 
    /// <summary>
    /// Use this configuration when using the Evaluator to evaluate HL7V2 flat file messages.
    /// </summary>
    public class HL7V2ExpressionConfiguration : ExpressionConfigurationBase
    {
        /// <summary>
        /// A list of <see cref="ExpressionConfigurationOperator"/> used by the expression configuration.
        /// </summary>
        private readonly IList<ExpressionConfigurationOperator> operators;

        /// <summary>
        /// The options used by the expression configuration.
        /// </summary>
        private readonly ExpressionConfigurationOptions options;

        /// <summary>
        /// The field delimiter used by the expression configuration. By default is "|".
        /// </summary>
        public static string fieldDelimiter = "|";

        /// <summary>
        /// The component delimiter used by the expression configuration. By default is "^".
        /// </summary>
        public static string componentDelimiter = "^";

        /// <summary>
        /// The escape character used by the expression configuration. By default is "\".
        /// </summary>
        public static string escapeCharacter = "\\";

        /// <summary>
        /// The sub component delimiter used by the expression configuration. By default is "&".
        /// </summary>
        public static string subComponentDelimiter = "&";
        
        /// <summary>
        /// The field repetition delimiter used by the expression configuration. By default is "~".
        /// </summary>
        public static string fieldRepetitionDelimiter = "~";

        /// <summary>
        /// The present but null character used by the expression configuration. By default is """" (two double quotes).
        /// </summary>
        public static string presentButNull = "\"\"";

        /// <summary>
        /// Special segment headers are special headers defined by the hl7 spec that should be treated uniquely. MSH, BSH, and FSH.
        /// </summary>
        public static IList<string> specialSegmentHeaders;

        /// <summary>
        /// The encoding conversions define how <see cref="EncodeString(string)"/> behaves. It uses the escape character and delimiters to hl7 encode data.
        /// </summary>
        public static IDictionary<string, string> encodingConversions;

        /// <summary>
        /// The end character is used internally to handle when there is a delimiter at the end of a message segment (expression) when evaluating expressions.
        /// </summary>
        internal string endCharacter;

        /// <summary>
        /// The message segment for each line of the hl7v2 message.
        /// </summary>
        private HL7V2MessageSegment messageSegment;

        /// <summary>
        /// On static constructor load, the encoding conversions are rebuilt, and the special segment headers are initialized.
        /// </summary>
        static HL7V2ExpressionConfiguration()
        {
            RebuildEncodingConversions();

            // TODO: I think this should update the delimiters. I need more concrete examples to test against. But this will work for single FHS / BHS segments, I'm not sure for more. I need a test message to see.
            specialSegmentHeaders = new List<string>()
            {
                "MSH",
                "FHS",
                "BHS"
            };
        }

        /// <summary>
        /// Rebuilds the <see cref="encodingConversions"/>, using the <see cref="escapeCharacter"/>, <see cref="fieldDelimiter"/>, <see cref="fieldRepetitionDelimiter"/>, <see cref="componentDelimiter"/>, <see cref="subComponentDelimiter"/>. Call this if you update any of those fields before calling <see cref="EncodeString(string)"/>.
        /// </summary>
        public static void RebuildEncodingConversions()
        {
            encodingConversions = new Dictionary<string, string>();
            encodingConversions.Add(escapeCharacter, $"{escapeCharacter}E{escapeCharacter}");
            encodingConversions.Add(fieldDelimiter, $"{escapeCharacter}F{escapeCharacter}");
            encodingConversions.Add(fieldRepetitionDelimiter, $"{escapeCharacter}R{escapeCharacter}");
            encodingConversions.Add(componentDelimiter, $"{escapeCharacter}S{escapeCharacter}");
            encodingConversions.Add(subComponentDelimiter, $"{escapeCharacter}T{escapeCharacter}");
        }

        /// <summary>
        /// Encodes input data if any of the <see cref="encodingConversions"/> key's are found in the data.
        /// </summary>
        /// <param name="input">The data to encode.</param>
        /// <returns>The newly encoded <see cref="string"/> data.</returns>
        public static string EncodeString(string input)
        {
            foreach (var encodingConversion in encodingConversions)
            {
                input = input.Replace(encodingConversion.Key, encodingConversion.Value);
            }

            return input;
        }

        /// <summary>
        /// Decodes input data if any of the <see cref="encodingConversions"/> value's are found in the data.
        /// </summary>
        /// <param name="input">The data to decode.</param>
        /// <returns>The newly decoded <see cref="string"/> data.</returns>
        public static string DecodeString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            foreach (var escapeConversion in encodingConversions)
            {
                input = input.Replace(escapeConversion.Value, escapeConversion.Key);
            }

            return input;
        }

        /// <summary>
        /// Initializes the operators with one Addition operator and it's <see cref="ExpressionConfigurationOperator.SolveOperatorExpression"/> callback to grab the fields from the Evaluator, initializes the options, and initializes the <see cref="messageSegment"/>.
        /// </summary>
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
                bool? endCharacterFound = false;

                // found the end character
                if (endCharacter != null && expGroup.RightOperand.EndsWith(endCharacter))
                {
                    endCharacterFound = true;
                }

                if (messageSegment.Fields.Count == 0)
                {
                    messageSegment.SegmentName = expGroup.LeftOperand;
                    if (specialSegmentHeaders.Any(a => a.Equals(messageSegment.SegmentName)))
                    {
                        messageSegment.AddField(fieldDelimiter, false);
                    }
                }

                //^~\&
                var input = $"{componentDelimiter}{fieldRepetitionDelimiter}{escapeCharacter}{subComponentDelimiter}";
                var includeFieldRepetition = !expGroup.RightOperand.Equals(input);

                var field = messageSegment.AddField(endCharacterFound.Value ? expGroup.RightOperand.Split(endCharacter)[0] : expGroup.RightOperand, includeFieldRepetition);

                return DefaultExpressionResult;
            }
        }

        /// <summary>
        /// Internal method to initialize the <see cref="messageSegment"/>.
        /// </summary>
        internal void Setup()
        {
            messageSegment = new HL7V2MessageSegment();
        }

        /// <summary>
        /// A list of operators used by the expression configuration.
        /// </summary>
        public override IList<ExpressionConfigurationOperator> Operators => operators;

        /// <summary>
        /// The options used by the expression configuration.
        /// </summary>
        public override ExpressionConfigurationOptions Options => options;

        /// <summary>
        /// Get's the message segment. 
        /// </summary>
        /// <returns><see cref="HL7V2MessageSegment"/></returns>
        public HL7V2MessageSegment GetHL7V2MessageSegment()
        {
            return messageSegment;
        }
    }
}
