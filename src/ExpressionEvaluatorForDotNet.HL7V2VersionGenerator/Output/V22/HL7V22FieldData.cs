using System;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22FieldData
    {
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

        public IList<HL7V22FieldData> Fields { get; init; }
    }
}
