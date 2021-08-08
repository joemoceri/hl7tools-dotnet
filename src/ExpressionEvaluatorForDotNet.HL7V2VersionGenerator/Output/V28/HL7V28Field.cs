using System;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Field
    {
        public HL7V2Field field { get; init; }

        public IList<HL7V28FieldRepetition> fieldRepetitions { get; internal set; }

        public string Id { get; init; }

        public string Type { get; init; }

        public string Position { get; init; }

        public string Name { get; init; }

        public int Length { get; init; }

        public string Usage { get; init; }

        public string Rpt { get; init; }

        public string DataType { get; init; }

        public string DataTypeName { get; init; }

        public string TableId { get; init; }

        public string TableName { get; init; }

        public string Description { get; init; }

        public string Sample { get; init; }

        public string Value { get { return field?.Value; } }

        public HL7V2ValidationResult Validate()
        {
            var issues = new Dictionary<string, string>();
            var result = true;
            Exception error = null;

            try
            {

            }
            catch(Exception e)
            {
                error = e;
            }

            return new HL7V2ValidationResult
            {
                Issues = issues,
                Error = error,
                Result = result
            };
        }
    }
}
