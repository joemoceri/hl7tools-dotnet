using System;
using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V2ValidationResult
    {
        public bool Valid 
        {
            get
            {
                return Issues == null ? false : Issues.Count == 0 && Error == null;
            }
        }

        public IDictionary<string, string> Issues { get; set; }

        public Exception Error { get; set; }
    }
}
