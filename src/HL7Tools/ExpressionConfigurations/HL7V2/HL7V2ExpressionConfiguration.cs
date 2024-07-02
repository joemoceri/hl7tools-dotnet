using System.Collections.Generic;
using System.Linq;

namespace HL7Tools
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

        private readonly HL7V2MessageDelimiters messageDelimiters;

        public HL7V2MessageDelimiters GetMessageDelimiters()
        {
            return messageDelimiters;
        }

        /// <summary>
        /// The present but null character used by the expression configuration. By default is """" (two double quotes).
        /// </summary>
        public string presentButNull { get; set; }

        /// <summary>
        /// Special segment headers are special headers defined by the hl7 spec that should be treated uniquely. MSH, BSH, and FSH.
        /// </summary>
        public static readonly IList<string> specialSegmentHeaders;

        /// <summary>
        /// The encoding conversions define how <see cref="EncodeString(string)"/> behaves. It uses the escape character and delimiters to hl7 encode data.
        /// </summary>
        public IDictionary<string, string> encodingConversions { get; set; }

        /// <summary>
        /// The end character is used internally to handle when there is a delimiter at the end of a message segment (expression) when evaluating expressions.
        /// </summary>
        internal string endCharacter;

        /// <summary>
        /// The message segment for each line of the hl7v2 message.
        /// </summary>
        private HL7V2MessageSegment messageSegment;

        /// <summary>
        /// Rebuilds the <see cref="encodingConversions"/>, using the <see cref="escapeCharacter"/>, <see cref="fieldDelimiter"/>, <see cref="fieldRepetitionDelimiter"/>, <see cref="componentDelimiter"/>, <see cref="subComponentDelimiter"/>. Call this if you update any of those fields before calling <see cref="EncodeString(string)"/>.
        /// </summary>
        public void RebuildEncodingConversions()
        {
            encodingConversions = new Dictionary<string, string>();
            encodingConversions.Add(messageDelimiters.escapeCharacter, $"{messageDelimiters.escapeCharacter}E{messageDelimiters.escapeCharacter}");
            encodingConversions.Add(messageDelimiters.fieldDelimiter, $"{messageDelimiters.escapeCharacter}F{messageDelimiters.escapeCharacter}");
            encodingConversions.Add(messageDelimiters.fieldRepetitionDelimiter, $"{messageDelimiters.escapeCharacter}R{messageDelimiters.escapeCharacter}");
            encodingConversions.Add(messageDelimiters.componentDelimiter, $"{messageDelimiters.escapeCharacter}S{messageDelimiters.escapeCharacter}");
            encodingConversions.Add(messageDelimiters.subComponentDelimiter, $"{messageDelimiters.escapeCharacter}T{messageDelimiters.escapeCharacter}");
        }

        /// <summary>
        /// Encodes input data if any of the <see cref="encodingConversions"/> key's are found in the data.
        /// </summary>
        /// <param name="input">The data to encode.</param>
        /// <returns>The newly encoded <see cref="string"/> data.</returns>
        public string EncodeString(string input)
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
        public string DecodeString(string input)
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

        static HL7V2ExpressionConfiguration()
        {
            // TODO: I think this should update the delimiters. I need more concrete examples to test against. But this will work for single FHS / BHS segments, I'm not sure for more. I need a test message to see.
            specialSegmentHeaders = new List<string>
            {
                "MSH",
                "FHS",
                "BHS"
            };
        }

        /// <summary>
        /// Initializes the operators with one Addition operator and it's <see cref="ExpressionConfigurationOperator.SolveOperatorExpression"/> callback to grab the fields from the Evaluator, initializes the options, and initializes the <see cref="messageSegment"/>.
        /// </summary>
        public HL7V2ExpressionConfiguration()
        {
            messageDelimiters = new HL7V2MessageDelimiters
            {
                fieldDelimiter = "|",
                componentDelimiter = "^",
                escapeCharacter = "\\",
                subComponentDelimiter = "&",
                fieldRepetitionDelimiter = "~",
            };

            presentButNull = "\"\"";

            RebuildEncodingConversions();

            operators = new List<ExpressionConfigurationOperator>
            {
                CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, messageDelimiters.fieldDelimiter, FieldSolveOperatorExpression, null, null)
            };

            options = new ExpressionConfigurationOptions
            {
                IgnoreWhitespaceOutsideQuotes = true,
                IgnoreParentheses = true,
                IgnoreQuotesValidation = true
            };


            // this gets called on every operator expression group
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
                        messageSegment.AddField(messageDelimiters.fieldDelimiter, false);
                    }
                }

                //^~\&
                var input = $"{messageDelimiters.componentDelimiter}{messageDelimiters.fieldRepetitionDelimiter}{messageDelimiters.escapeCharacter}{messageDelimiters.subComponentDelimiter}";
                var includeFieldRepetition = !expGroup.RightOperand.Equals(input);

                messageSegment.AddField(endCharacterFound.Value ? expGroup.RightOperand.Split(endCharacter)[0] : expGroup.RightOperand, includeFieldRepetition);

                return DefaultExpressionResult;
            }
        }

        /// <summary>
        /// Internal method to initialize the <see cref="messageSegment"/>.
        /// </summary>
        internal void Setup()
        {
            messageSegment = new HL7V2MessageSegment(messageDelimiters);
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
