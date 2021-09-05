namespace HL7Tools
{
    /// <summary>
    /// This class refers to HL7V2 Sub Components defined in V2 specification. Sub Components are the lowest level of 'fields' in an hl7v2 message segment.
    /// </summary>
    public class HL7V2SubComponent : HL7V2FieldBase
    {
        /// <summary>
        /// The Id of the Sub Component. 1-based.
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// The Delimiter of the Sub Component.
        /// </summary>
        public override string Delimiter { get; set; }

        /// <summary>
        /// The Value of the Sub Component.
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// Required, but method does nothing.
        /// </summary>
        public override void Rebuild()
        {
            // nothing to do
        }
    }
}