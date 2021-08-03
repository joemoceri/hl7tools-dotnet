using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0259
    {
        public string Id { get { return @"0259"; } }

        public string TableId { get { return @"0259"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Modality"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"AS",
                            Description = @"Angioscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BS",
                            Description = @"Biomagnetic imaging",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CD",
                            Description = @"Color flow Doppler",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Colposcopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Computed radiography",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CS",
                            Description = @"Cystoscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CT",
                            Description = @"Computed tomography",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DD",
                            Description = @"Duplex Doppler",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DG",
                            Description = @"Diapanography",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DM",
                            Description = @"Digital microscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EC",
                            Description = @"Echocardiography",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ES",
                            Description = @"Endoscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FA",
                            Description = @"Fluorescein angiography",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FS",
                            Description = @"Fundoscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LP",
                            Description = @"Laparoscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LS",
                            Description = @"Laser surface scan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Magnetic resonance angiography",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MS",
                            Description = @"Magnetic resonance spectroscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NM",
                            Description = @"Nuclear Medicine (radioisotope study)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OT",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Positron emission tomography (PET)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RF",
                            Description = @"Radio fluoroscopy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ST",
                            Description = @"Single photon emission computed tomography (SPECT)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TG",
                            Description = @"Thermography",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"US",
                            Description = @"Ultrasound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XA",
                            Description = @"X-ray Angiography",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
