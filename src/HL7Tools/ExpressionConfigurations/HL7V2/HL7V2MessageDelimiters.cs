namespace HL7Tools
{
    public class HL7V2MessageDelimiters
    {
        /// <summary>
        /// The field delimiter used by the expression configuration. By default is "|".
        /// </summary>
        public string fieldDelimiter { get; set; }

        /// <summary>
        /// The component delimiter used by the expression configuration. By default is "^".
        /// </summary>
        public string componentDelimiter { get; set; }

        /// <summary>
        /// The escape character used by the expression configuration. By default is "\".
        /// </summary>
        public string escapeCharacter { get; set; }

        /// <summary>
        /// The sub component delimiter used by the expression configuration. By default is "&".
        /// </summary>
        public string subComponentDelimiter { get; set; }

        /// <summary>
        /// The field repetition delimiter used by the expression configuration. By default is "~".
        /// </summary>
        public string fieldRepetitionDelimiter { get; set; }

        public static readonly HL7V2MessageDelimiters DefaultMessageDelimiters = new HL7V2MessageDelimiters
        {
            fieldDelimiter = "|",
            componentDelimiter = "^",
            escapeCharacter = "\\",
            subComponentDelimiter = "&",
            fieldRepetitionDelimiter = "~"
        };
    }
}
