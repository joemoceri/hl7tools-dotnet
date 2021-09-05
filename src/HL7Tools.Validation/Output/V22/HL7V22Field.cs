using System;
using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V22Field
    {
        public HL7V2Field field { get; init; }

        public IList<HL7V22FieldRepetition> fieldRepetitions { get; internal set; }

        public HL7V22FieldData fieldData { get; init; }

        public string Value { get { return field?.Value; } }

        public HL7V2ValidationResult Validate()
        {
            var issues = new Dictionary<string, string>();
            Exception error = null;

            try
            {

            }
            catch (Exception e)
            {
                error = e;
            }

            return new HL7V2ValidationResult
            {
                Issues = issues,
                Error = error
            };
        }
    }
}
