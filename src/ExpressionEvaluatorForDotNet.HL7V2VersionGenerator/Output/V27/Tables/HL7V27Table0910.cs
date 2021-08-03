using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0910
    {
        public string Id { get { return @"0910"; } }

        public string TableId { get { return @"0910"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Acquisition Modality"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"...",
                            Description = null,
                            Comment = @"Acquisition Modality codes, Context Group 29, Digital Imaging and Communications in Medicine (DICOM) - Part 16: Content Mapping Resource (PS3.16), available free at http://dicom.nema.org"
                        },
                    };
            } 
        }
    }
}
