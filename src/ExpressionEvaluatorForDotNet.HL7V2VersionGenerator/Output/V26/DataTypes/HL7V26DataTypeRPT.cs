using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"RPT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Repeat Pattern"; } }

        public string Description { get { return @"The repeat pattern data type should be used where it is necessary to define the frequency at which an event is to take place. This data type provides a way to define repeat pattern codes ""on the fly"". The repeat pattern code is equivalent to the TQ data type, component 2, sub-component 1 (repeat pattern). The additional components define the meaning of the repeat pattern code. Components 2 - 10 are used to define relatively simple repeat patterns. Component 11 is provided to define complex repeat patterns. This data type forms a bridge between the 2.x Repeat Pattern concept from Quantity/Timing, and the Version 3.0 GTS General Timing Specification. Component 1 is the 2.x concept of repeat pattern. Components 2-7 are derived from the version 3.0 data type PIVL. Components 8-10 are derived from the version 3.0 EIVL data type. If a repeat pattern cannot be defined using components 2-10, then component 11, General Timing Specification is provided. This allows the full literal form of the version 3.0 GTS to be specified."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 984; } }

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
                            Id = @"RPT.1",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.1",
                            Name = @"Repeat Pattern Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"A code representing the repeat pattern defined by the other components of this data type. Refer to User-defined Table 0335 - Repeat Pattern for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.2",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.2",
                            Name = @"Calendar Alignment",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0527",
                            TableName = @"Calendar alignment",
                            Description = @"Specifies an alignment of the repetition to a calendar (e.g., to distinguish every 30 days from the 5th of every month). Refer to HL7 Table 0527 - Calendar Alignment for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.3",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.3",
                            Name = @"Phase Range Begin Value",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Used for Calendar aligned repeat patterns to determine the amount of time from the beginning of particular RPT-2 (Calendar Alignment) to the beginning of the phase. If Calendar Alignment is DW (days of week), then this would be the offset from the beginning of the week.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.4",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.4",
                            Name = @"Phase Range End Value",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Used for Calendar aligned repeat patterns to determine the amount of time from the beginning of particular RPT-2 (Calendar Alignment) to the end of the phase.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.5",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.5",
                            Name = @"Period Quantity",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A time duration specifying the frequency at which the periodic interval repeats. RPT-6 (Period Units) defines the units of time for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.6",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.6",
                            Name = @"Period Units",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the units used for RPT-5 (Period Quantity). Constrained to units of time. The codes for unit of measure are specified in the Unified Code for Units of Measure (UCUM) [http://aurora.rg.iupui.edu/UCUM].",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.7",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.7",
                            Name = @"Institution Specified Time",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"A code that indicates whether the exact timing is up to the party executing the schedule (e.g., to distinguish every 8 hours from 3 times a day.) Refer to HL7 Table 0136 - Yes/No Indicator for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.8",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.8",
                            Name = @"Event",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0528",
                            TableName = @"Event related period",
                            Description = @"A code for a common (periodical) activity of daily living. Refer to HL7 Table 0528 - Event-Related Period for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.9",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.9",
                            Name = @"Event Offset Quantity",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"An interval that marks the offsets for the beginning, width and end of the event-related periodic interval measured from the time each such event actually occurred. A positive numeric value indicates the amount of time after the event in RPT-8. A negative numeric value indicates the amount of time prior to the event in RPT-8. RPT-10 (Event Offset Units) defines the units of time for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.10",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.10",
                            Name = @"Event Offset Units",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the units used for RPT-9 (Event Offset Quantity). Constrained to units of time. The codes for unit of measure are specified in the Unified Code for Units of Measure (UCUM) [http://aurora.rg.iupui.edu/UCUM].",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RPT.11",
                            Type = @"DataTypeComponent",
                            Position = @"RPT.11",
                            Name = @"General Timing Specification",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"GTS",
                            DataTypeName = @"General Timing Specification",
                            TableId = null,
                            TableName = null,
                            Description = @"The General Timing Specification as defined by the Version 3 Data Types document.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
