using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// 
    /// </summary>
    public class HL7V23Field
    {
        public readonly HL7V2FieldBase field;

        public HL7V23Field(HL7V2FieldBase field)
        {
            this.field = field;
        }

        public int Length { get; set; }

        public HL7V23DataType DataType { get; set; }

        public bool Optional { get; set; }

        public bool Repeatable { get; set; }

        public HL7V23Table Table { get; set; }

        public string Value { get { return field.Value; } }
    }
}
