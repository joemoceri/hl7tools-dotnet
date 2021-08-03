using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0291
    {
        public string Id { get { return @"0291"; } }

        public string TableId { get { return @"0291"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Subtype of referenced data"; } }

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
                            Value = @"BASIC",
                            Description = @"ISDN PCM audio data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DICOM",
                            Description = @"Digital Imaging and Communications in Medicine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FAX",
                            Description = @"Facsimile data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GIF",
                            Description = @"Graphics Interchange Format",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HTML",
                            Description = @"Hypertext Markup Language",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JOT",
                            Description = @"Electronic ink data (Jot 1.0 standard)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JPEG",
                            Description = @"Joint Photographic Experts Group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Octet-stream",
                            Description = @"Uninterpreted binary data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PICT",
                            Description = @"PICT format image data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PostScript",
                            Description = @"PostScript program",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RTF",
                            Description = @"Rich Text Format",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SGML",
                            Description = @"Standard Generalized Markup Language (HL7 V2.3.1 and later)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TIFF",
                            Description = @"TIFF image data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"x-hl7-cda-level-one",
                            Description = @"HL7 Clinical Document Architecture Level One document",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XML",
                            Description = @"Extensible Markup Language (HL7 V2.3.1 and later)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
