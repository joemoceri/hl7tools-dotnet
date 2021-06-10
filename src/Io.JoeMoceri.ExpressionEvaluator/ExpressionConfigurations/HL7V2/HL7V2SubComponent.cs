namespace Io.JoeMoceri.ExpressionEvaluator
{
    /// <summary>
    /// 
    /// </summary>
    public class HL7V2SubComponent : HL7V2FieldBase
    {
        /// <summary>
        /// 
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override string Delimiter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override void Rebuild()
        {
            // nothing to do
        }
    }
}