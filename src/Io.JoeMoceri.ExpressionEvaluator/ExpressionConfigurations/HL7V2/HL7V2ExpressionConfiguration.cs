using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{ 
    /// <summary>
    /// 
    /// </summary>
    public class HL7V2ExpressionConfiguration : ExpressionConfigurationBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IList<ExpressionConfigurationOperator> operators;

        /// <summary>
        /// 
        /// </summary>
        private readonly ExpressionConfigurationOptions options;

        /// <summary>
        /// 
        /// </summary>
        public static string fieldDelimiter = "|";

        /// <summary>
        /// 
        /// </summary>
        public static string componentDelimiter = "^";

        /// <summary>
        /// 
        /// </summary>
        public static string escapeDelimiter = "\\";

        /// <summary>
        /// 
        /// </summary>
        public static string subComponentDelimiter = "&";
        
        /// <summary>
        /// 
        /// </summary>
        public static string fieldRepetitionDelimiter = "~";

        /// <summary>
        /// 
        /// </summary>
        public static string presentButNull = "\"\"";

        /// <summary>
        /// 
        /// </summary>
        public static IList<string> specialSegmentHeaders;

        /// <summary>
        /// 
        /// </summary>
        public static IDictionary<string, string> encodingConversions;

        /// <summary>
        /// 
        /// </summary>
        internal string endCharacter;

        /// <summary>
        /// 
        /// </summary>
        private HL7V2MessageSegment messageSegment;

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public static void RebuildEncodingConversions()
        {
            encodingConversions = new Dictionary<string, string>();
            encodingConversions.Add(escapeDelimiter, $"{escapeDelimiter}E{escapeDelimiter}");
            encodingConversions.Add(fieldDelimiter, $"{escapeDelimiter}F{escapeDelimiter}");
            encodingConversions.Add(fieldRepetitionDelimiter, $"{escapeDelimiter}R{escapeDelimiter}");
            encodingConversions.Add(componentDelimiter, $"{escapeDelimiter}S{escapeDelimiter}");
            encodingConversions.Add(subComponentDelimiter, $"{escapeDelimiter}T{escapeDelimiter}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string EncodeString(string input)
        {
            foreach (var encodingConversion in encodingConversions)
            {
                input = input.Replace(encodingConversion.Key, encodingConversion.Value);
            }

            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        /// 
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
                var input = $"{componentDelimiter}{fieldRepetitionDelimiter}{escapeDelimiter}{subComponentDelimiter}";
                var includeFieldRepetition = !expGroup.RightOperand.Equals(input);

                var field = messageSegment.AddField(endCharacterFound.Value ? expGroup.RightOperand.Split(endCharacter)[0] : expGroup.RightOperand, includeFieldRepetition);

                return DefaultExpressionResult;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        internal void Setup()
        {
            messageSegment = new HL7V2MessageSegment();
        }

        /// <summary>
        /// 
        /// </summary>
        public override IList<ExpressionConfigurationOperator> MathStringOperators 
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override IList<ExpressionConfigurationOperator> BooleanOperators
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override IList<ExpressionConfigurationOperator> Operators => operators;

        /// <summary>
        /// 
        /// </summary>
        public override ExpressionConfigurationOptions Options => options;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HL7V2MessageSegment GetHL7V2MessageSegment()
        {
            return messageSegment;
        }
    }
}
