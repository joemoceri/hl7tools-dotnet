using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentNSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NSC"; } }

        public string SegmentId { get { return @"NSC"; } }
        
        public string LongName { get { return @"Application Status Change"; } }
        
        public string Description { get { return @"The NSC segment is used to inform (NMR query response) or announce (NMD unsolicited update) the start up, shut down, and/or migration (to a different CPU or file server/file system) of a particular application. 

Usage Notes: Fields 2-9.  These are not applicable (""n/a"") when the type of change being requested or reported is start-up or shut-down.  If the change is of type ""M"", at least one of fields 2-5 must be different from its corresponding field in range 6-9.

Fields 4-5, 8-9.  See definitions for the MSH, message header segment, in Chapter 2, ""Control Section,"" for fields 3-4, for system and facility.  ""Application"" is available for interfacing with lower level protocols.  ""Facility"" is entirely site-defined.

Fields 2-3, 6-7: entirely site-defined."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

                    };
            }
        }

        public HL7V28SegmentNSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _applicationChangeType;

public HL7V28Field ApplicationChangeType
{
    get
    {
        if (_applicationChangeType != null)
        {
            return _applicationChangeType;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.1",
            Type = @"Field",
            Position = @"NSC.1",
            Name = @"Application Change Type",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded With Exceptions",
            TableId = @"0409",
            TableName = @"Application Change Type",
            Description = @"This field contains the type of change being requested (if NMR query) or announced (if NMD unsolicited update).  Refer to User-Defined Table 0409 - Application Change Type in Chapter 2C, Code Tables, for suggested values. It is assumed that ""new"" version starts up with no loss or duplication of data as old one is shutting down (if possible).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.1.1",
                            Type = @"Component",
                            Position = @"NSC.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.

In the context of “Data Missing”, described above in the Usage Note, refer to HL7 Table 0353 – CWE Statuses for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.2",
                            Type = @"Component",
                            Position = @"NSC.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., ""myocardial infarction"" or ""X-ray impression"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.3",
                            Type = @"Component",
                            Position = @"NSC.1.3",
                            Name = @"Name Of Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the ""Coding System"" component or the ""Coding System OID"" for the tuple.

Refer to HL7 Table 0396 – Coding System in Chapter 2C, section ""Coding System Table"" for valid values. 

Refer to section 2.A.8.3, ""Name of Coding System (ID)"" for a discussion of coding system conventions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.4",
                            Type = @"Component",
                            Position = @"NSC.1.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. 

Usage Notes: The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.5",
                            Type = @"Component",
                            Position = @"NSC.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.6",
                            Type = @"Component",
                            Position = @"NSC.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.7",
                            Type = @"Component",
                            Position = @"NSC.1.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.8",
                            Type = @"Component",
                            Position = @"NSC.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.9",
                            Type = @"Component",
                            Position = @"NSC.1.9",
                            Name = @"Original Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.10",
                            Type = @"Component",
                            Position = @"NSC.1.10",
                            Name = @"Second Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.11",
                            Type = @"Component",
                            Position = @"NSC.1.11",
                            Name = @"Second Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.12",
                            Type = @"Component",
                            Position = @"NSC.1.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.13",
                            Type = @"Component",
                            Position = @"NSC.1.13",
                            Name = @"Second Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.14",
                            Type = @"Component",
                            Position = @"NSC.1.14",
                            Name = @"Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.15",
                            Type = @"Component",
                            Position = @"NSC.1.15",
                            Name = @"Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.16",
                            Type = @"Component",
                            Position = @"NSC.1.16",
                            Name = @"Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.15 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.17",
                            Type = @"Component",
                            Position = @"NSC.1.17",
                            Name = @"Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.18",
                            Type = @"Component",
                            Position = @"NSC.1.18",
                            Name = @"Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.19",
                            Type = @"Component",
                            Position = @"NSC.1.19",
                            Name = @"Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.18 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.20",
                            Type = @"Component",
                            Position = @"NSC.1.20",
                            Name = @"Second Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.21",
                            Type = @"Component",
                            Position = @"NSC.1.21",
                            Name = @"Second Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.1.22",
                            Type = @"Component",
                            Position = @"NSC.1.22",
                            Name = @"Second Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.21 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _applicationChangeType = new HL7V28Field
        {
            field = message[@"NSC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationChangeType.field.FieldRepetitions != null && _applicationChangeType.field.FieldRepetitions.Count > 0)
        {
            _applicationChangeType.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_applicationChangeType, fieldData);
        }

        return _applicationChangeType;
    } 
}

internal HL7V28Field _currentCpu;

public HL7V28Field CurrentCpu
{
    get
    {
        if (_currentCpu != null)
        {
            return _currentCpu;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.2",
            Type = @"Field",
            Position = @"NSC.2",
            Name = @"Current Cpu",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name for the current CPU. ",
            Sample = @"",
            Fields = null
        }

        _currentCpu = new HL7V28Field
        {
            field = message[@"NSC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentCpu.field.FieldRepetitions != null && _currentCpu.field.FieldRepetitions.Count > 0)
        {
            _currentCpu.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_currentCpu, fieldData);
        }

        return _currentCpu;
    } 
}

internal HL7V28Field _currentFileserver;

public HL7V28Field CurrentFileserver
{
    get
    {
        if (_currentFileserver != null)
        {
            return _currentFileserver;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.3",
            Type = @"Field",
            Position = @"NSC.3",
            Name = @"Current Fileserver",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site specific name for the current fileserver or file system used by this application. ",
            Sample = @"",
            Fields = null
        }

        _currentFileserver = new HL7V28Field
        {
            field = message[@"NSC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFileserver.field.FieldRepetitions != null && _currentFileserver.field.FieldRepetitions.Count > 0)
        {
            _currentFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_currentFileserver, fieldData);
        }

        return _currentFileserver;
    } 
}

internal HL7V28Field _currentApplication;

public HL7V28Field CurrentApplication
{
    get
    {
        if (_currentApplication != null)
        {
            return _currentApplication;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.4",
            Type = @"Field",
            Position = @"NSC.4",
            Name = @"Current Application",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Application",
            Description = @"This field contains a site-specific name used to identify the ""current"" application process for interfacing with lower level protocols.  To be used in conjunction with the sending/receiving system and facility values in the MSH.  Entirely site-defined. User-defined Table 0361-Sending/Receiving Application is used as the user-defined table of values for the first component.

By site agreement, implementors may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.4.1",
                            Type = @"Component",
                            Position = @"NSC.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.4.2",
                            Type = @"Component",
                            Position = @"NSC.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.4.3",
                            Type = @"Component",
                            Position = @"NSC.4.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _currentApplication = new HL7V28Field
        {
            field = message[@"NSC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentApplication.field.FieldRepetitions != null && _currentApplication.field.FieldRepetitions.Count > 0)
        {
            _currentApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_currentApplication, fieldData);
        }

        return _currentApplication;
    } 
}

internal HL7V28Field _currentFacility;

public HL7V28Field CurrentFacility
{
    get
    {
        if (_currentFacility != null)
        {
            return _currentFacility;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.5",
            Type = @"Field",
            Position = @"NSC.5",
            Name = @"Current Facility",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Facility",
            Description = @"This field contains a site-specific name for the current facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH. This field further describes the current application, NSC-5 Current Application.  With the promotion of this field to an HD data type, the usage has been broadened to include not just the current facility but other organizational entities, such as: a) the organizational entity responsible for current application; b) the responsible unit; c) a product or vendor's identifier, etc. Entirely site defined. User-defined Table 0362 – Sending/Receiving Facility is used as the HL7 identifier for the user-defined table of values for the first component.  

Note: By site agreement, implementors may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.5.1",
                            Type = @"Component",
                            Position = @"NSC.5.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.5.2",
                            Type = @"Component",
                            Position = @"NSC.5.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.5.3",
                            Type = @"Component",
                            Position = @"NSC.5.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _currentFacility = new HL7V28Field
        {
            field = message[@"NSC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentFacility.field.FieldRepetitions != null && _currentFacility.field.FieldRepetitions.Count > 0)
        {
            _currentFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_currentFacility, fieldData);
        }

        return _currentFacility;
    } 
}

internal HL7V28Field _newCpu;

public HL7V28Field NewCpu
{
    get
    {
        if (_newCpu != null)
        {
            return _newCpu;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.6",
            Type = @"Field",
            Position = @"NSC.6",
            Name = @"New Cpu",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name for the new CPU. ",
            Sample = @"",
            Fields = null
        }

        _newCpu = new HL7V28Field
        {
            field = message[@"NSC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newCpu.field.FieldRepetitions != null && _newCpu.field.FieldRepetitions.Count > 0)
        {
            _newCpu.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_newCpu, fieldData);
        }

        return _newCpu;
    } 
}

internal HL7V28Field _newFileserver;

public HL7V28Field NewFileserver
{
    get
    {
        if (_newFileserver != null)
        {
            return _newFileserver;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.7",
            Type = @"Field",
            Position = @"NSC.7",
            Name = @"New Fileserver",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a site-specific name for the new fileserver or file system used by this application. ",
            Sample = @"",
            Fields = null
        }

        _newFileserver = new HL7V28Field
        {
            field = message[@"NSC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFileserver.field.FieldRepetitions != null && _newFileserver.field.FieldRepetitions.Count > 0)
        {
            _newFileserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_newFileserver, fieldData);
        }

        return _newFileserver;
    } 
}

internal HL7V28Field _newApplication;

public HL7V28Field NewApplication
{
    get
    {
        if (_newApplication != null)
        {
            return _newApplication;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.8",
            Type = @"Field",
            Position = @"NSC.8",
            Name = @"New Application",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Application",
            Description = @"This field contains a site-specific name used to identify ""new"" application processes for interfacing with lower level protocols.  To be used in conjunction with the sending/receiving system and facility values in the MSH.  Entirely site-defined. User-defined Table 0361-Sending/Receiving Application is used as the user-defined table of values for the first component.

Note:By site agreement, implementors may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.8.1",
                            Type = @"Component",
                            Position = @"NSC.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.8.2",
                            Type = @"Component",
                            Position = @"NSC.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.8.3",
                            Type = @"Component",
                            Position = @"NSC.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _newApplication = new HL7V28Field
        {
            field = message[@"NSC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newApplication.field.FieldRepetitions != null && _newApplication.field.FieldRepetitions.Count > 0)
        {
            _newApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_newApplication, fieldData);
        }

        return _newApplication;
    } 
}

internal HL7V28Field _newFacility;

public HL7V28Field NewFacility
{
    get
    {
        if (_newFacility != null)
        {
            return _newFacility;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"NSC.9",
            Type = @"Field",
            Position = @"NSC.9",
            Name = @"New Facility",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Facility",
            Description = @"This field contains a site-specific name for the new facility used by this application. To be used in conjunction with the values for the sending/receiving system and facility values in the MSH. 

This field further describes the new application, NSC-8 New Application.  With the promotion of this field to an HD data type, the usage has been broadened to include not just the new facility but other organizational entities, such as: a) the organizational entity responsible for new application; b) the responsible unit; c) a product or vendor's identifier, etc. Entirely site defined. User-defined Table 0362 – Sending/Receiving Facility is used as the HL7 identifier for the user-defined table of values for the first component. 

Note: By site agreement, implementors may continue to use User-defined Table 0300 – Namespace ID for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NSC.9.1",
                            Type = @"Component",
                            Position = @"NSC.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.9.2",
                            Type = @"Component",
                            Position = @"NSC.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NSC.9.3",
                            Type = @"Component",
                            Position = @"NSC.9.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _newFacility = new HL7V28Field
        {
            field = message[@"NSC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_newFacility.field.FieldRepetitions != null && _newFacility.field.FieldRepetitions.Count > 0)
        {
            _newFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_newFacility, fieldData);
        }

        return _newFacility;
    } 
}
    }
}
