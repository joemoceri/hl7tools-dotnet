using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataType
    {
        public string Id { get { return @"PRL"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Parent Result Link"; } }

        public string Description { get { return @"Uniquely identifies the parent result’s OBX segment related to the current order, together with the information in OBR-29 - Parent.

Usage Note: This data type is applied only to OBR-26 - Parent Result where it serves to make information available for other types of linkages (e.g., toxicology). This important information, together with the information in OBR-29 - Parent, uniquely identifies the parent result’s OBX segment related to this order. The value of this OBX segment in the parent result is the organism or chemical species about which this battery reports. For example, if the current battery is an antimicrobial susceptibility, the parent results identified OBX contains a result that identifies the organism on which the susceptibility was run. This indirect linkage is preferred because the name of the organism in the parent result may undergo several preliminary values prior to finalization.

We emphasize that this field does not take the entire result field from the parent. It is meant only for the text name of the organism or chemical subspecies identified. This field is included only to provide a method for linking back to the parent result for those systems that could not generate unambiguous Observation IDs and sub-IDs.
This field is present only when the parent result is identified by OBR-29 - Parent and the parent spawns child orders for each of many results. See Chapter 7, ""Observations"", for more details about this linkage.

Note: Replaces the CM data type used in sections 4.5.3.26 - OBR-26 and 7.4.1.26 - OBR-26 as of v 2.5."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRL.1",
                            Type = @"DataTypeComponent",
                            Position = @"PRL.1",
                            Name = @"Parent Observation Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the unique identifier of the parent observation as defined in the OBX-3 of the parent result. The value is the same as the OBX-3 of the parent.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRL.2",
                            Type = @"DataTypeComponent",
                            Position = @"PRL.2",
                            Name = @"Parent Observation Sub-identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the sub-ID of the parent result as defined in the OBX-4 of the parent result. The value is the same as the OBX-4 of the parent.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRL.3",
                            Type = @"DataTypeComponent",
                            Position = @"PRL.3",
                            Name = @"Parent Observation Value Descriptor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains a descriptor of the parent observation value as specified in the OBX-5 of the parent result.

As an example, the third component may be used to record the name of the microorganism identified by the parent result directly. The organism in this case should be identified exactly as it is in the parent culture.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
