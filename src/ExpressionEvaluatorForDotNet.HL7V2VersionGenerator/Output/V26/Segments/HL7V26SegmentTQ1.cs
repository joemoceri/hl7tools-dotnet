using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentTQ1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"TQ1"; } }

        public string SegmentId { get { return @"TQ1"; } }
        
        public string LongName { get { return @"Timing/Quantity"; } }
        
        public string Description { get { return @"The TQ1 segment is used to specify the complex timing of events and actions such as those that occur in order management and scheduling systems. This segment determines the quantity, frequency, priority and timing of a service. By allowing the segment to repeat, it is possible to have service requests that vary the quantity, frequency and priority of a service request over time."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TQ1.1",
                            Type = @"Field",
                            Position = @"TQ1.1",
                            Name = @"Set ID - TQ1",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"For the first timing specification transmitted, the sequence number shall be 1; for the second timing specification, it shall be 2; and so on.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2",
                            Type = @"Field",
                            Position = @"TQ1.2",
                            Name = @"Quantity",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the numeric quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be '2', or if three units of blood are to be typed and cross-matched, the quantity would be '3'. The default value for this field is '1'.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.2.1",
                            Type = @"Component",
                            Position = @"TQ1.2.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2",
                            Type = @"Component",
                            Position = @"TQ1.2.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.1",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.2",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.3",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.4",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.5",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.6",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.7",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.8",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.2.2.9",
                            Type = @"SubComponent",
                            Position = @"TQ1.2.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3",
                            Type = @"Field",
                            Position = @"TQ1.3",
                            Name = @"Repeat Pattern",
                            Length = 540,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"RPT",
                            DataTypeName = @"Repeat Pattern",
                            TableId = null,
                            TableName = null,
                            Description = @"The repeating frequency with which the treatment is to be administered. It is similar to the frequency and SIG code tables used in order entry systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1",
                            Type = @"Component",
                            Position = @"TQ1.3.1",
                            Name = @"Repeat Pattern Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"A code representing the repeat pattern defined by the other components of this data type. Refer to User-defined Table 0335 - Repeat Pattern for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.1",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.2",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.3",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.4",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.5",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.6",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.7",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.8",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.1.9",
                            Type = @"SubComponent",
                            Position = @"TQ1.3.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.2",
                            Type = @"Component",
                            Position = @"TQ1.3.2",
                            Name = @"Calendar Alignment",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0527",
                            TableName = @"Calendar alignment",
                            Description = @"Specifies an alignment of the repetition to a calendar (e.g., to distinguish every 30 days from the 5th of every month). Refer to HL7 Table 0527 - Calendar Alignment for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.3",
                            Type = @"Component",
                            Position = @"TQ1.3.3",
                            Name = @"Phase Range Begin Value",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Used for Calendar aligned repeat patterns to determine the amount of time from the beginning of particular RPT-2 (Calendar Alignment) to the beginning of the phase. If Calendar Alignment is DW (days of week), then this would be the offset from the beginning of the week.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.4",
                            Type = @"Component",
                            Position = @"TQ1.3.4",
                            Name = @"Phase Range End Value",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Used for Calendar aligned repeat patterns to determine the amount of time from the beginning of particular RPT-2 (Calendar Alignment) to the end of the phase.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.5",
                            Type = @"Component",
                            Position = @"TQ1.3.5",
                            Name = @"Period Quantity",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A time duration specifying the frequency at which the periodic interval repeats. RPT-6 (Period Units) defines the units of time for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.6",
                            Type = @"Component",
                            Position = @"TQ1.3.6",
                            Name = @"Period Units",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the units used for RPT-5 (Period Quantity). Constrained to units of time. The codes for unit of measure are specified in the Unified Code for Units of Measure (UCUM) [http://aurora.rg.iupui.edu/UCUM].",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.7",
                            Type = @"Component",
                            Position = @"TQ1.3.7",
                            Name = @"Institution Specified Time",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"A code that indicates whether the exact timing is up to the party executing the schedule (e.g., to distinguish every 8 hours from 3 times a day.) Refer to HL7 Table 0136 - Yes/No Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.8",
                            Type = @"Component",
                            Position = @"TQ1.3.8",
                            Name = @"Event",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0528",
                            TableName = @"Event related period",
                            Description = @"A code for a common (periodical) activity of daily living. Refer to HL7 Table 0528 - Event-Related Period for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.9",
                            Type = @"Component",
                            Position = @"TQ1.3.9",
                            Name = @"Event Offset Quantity",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"An interval that marks the offsets for the beginning, width and end of the event-related periodic interval measured from the time each such event actually occurred. A positive numeric value indicates the amount of time after the event in RPT-8. A negative numeric value indicates the amount of time prior to the event in RPT-8. RPT-10 (Event Offset Units) defines the units of time for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.10",
                            Type = @"Component",
                            Position = @"TQ1.3.10",
                            Name = @"Event Offset Units",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the units used for RPT-9 (Event Offset Quantity). Constrained to units of time. The codes for unit of measure are specified in the Unified Code for Units of Measure (UCUM) [http://aurora.rg.iupui.edu/UCUM].",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.3.11",
                            Type = @"Component",
                            Position = @"TQ1.3.11",
                            Name = @"General Timing Specification",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"GTS",
                            DataTypeName = @"General Timing Specification",
                            TableId = null,
                            TableName = null,
                            Description = @"The General Timing Specification as defined by the Version 3 Data Types document.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.4",
                            Type = @"Field",
                            Position = @"TQ1.4",
                            Name = @"Explicit Time",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"TM",
                            DataTypeName = @"Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field explicitly lists the actual times referenced by the code in TQ1-3. This field will be used to clarify the TQ1-3 in cases where the actual administration times vary within an institution. If the time of the service request spans more than a single day, this field is only practical if the same times of administration occur for each day of the service request. If the actual start time of the service request (as given by TQ1-7) is after the first explicit time, the first administration is taken to be the first explicit time after the start time. In the case where the patient moves to a location having a different set of explicit times, the existing service request may be updated with a new quantity/timing segment showing the changed explicit times.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5",
                            Type = @"Field",
                            Position = @"TQ1.5",
                            Name = @"Relative Time and Units",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to define the interval between schedules for service request or bottle records. If this field contains a value, it overrides any value in the explicit time interval field. The units component of the CQ data type is constrained to units of time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.5.1",
                            Type = @"Component",
                            Position = @"TQ1.5.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2",
                            Type = @"Component",
                            Position = @"TQ1.5.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.1",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.2",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.3",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.4",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.5",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.6",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.7",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.8",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.5.2.9",
                            Type = @"SubComponent",
                            Position = @"TQ1.5.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6",
                            Type = @"Field",
                            Position = @"TQ1.6",
                            Name = @"Service Duration",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for which the service is requested.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.6.1",
                            Type = @"Component",
                            Position = @"TQ1.6.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2",
                            Type = @"Component",
                            Position = @"TQ1.6.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.1",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.2",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.3",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.4",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.5",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.6",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.7",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.8",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.6.2.9",
                            Type = @"SubComponent",
                            Position = @"TQ1.6.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.7",
                            Type = @"Field",
                            Position = @"TQ1.7",
                            Name = @"Start date/time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the requester, in which case it indicates the earliest date/time at which the services should be started. In many cases, however, the start date/time will be implied or will be defined by other fields in the service request record (e.g., urgency - STAT). In such a case, this field will be empty.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.8",
                            Type = @"Field",
                            Position = @"TQ1.8",
                            Name = @"End date/time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should contain the latest date/time that the service should be performed. If it has not been performed by the specified time, it should not be performed at all. The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9",
                            Type = @"Field",
                            Position = @"TQ1.9",
                            Name = @"Priority",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0485",
                            TableName = @"Extended Priority Codes",
                            Description = @"This field describes the urgency of the request. If this field is blank, the default is R. Refer to User-Defined Table 0485 - Extended Priority Codes for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.9.1",
                            Type = @"Component",
                            Position = @"TQ1.9.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.2",
                            Type = @"Component",
                            Position = @"TQ1.9.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.3",
                            Type = @"Component",
                            Position = @"TQ1.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.4",
                            Type = @"Component",
                            Position = @"TQ1.9.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.5",
                            Type = @"Component",
                            Position = @"TQ1.9.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.6",
                            Type = @"Component",
                            Position = @"TQ1.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.7",
                            Type = @"Component",
                            Position = @"TQ1.9.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.8",
                            Type = @"Component",
                            Position = @"TQ1.9.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.9.9",
                            Type = @"Component",
                            Position = @"TQ1.9.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.10",
                            Type = @"Field",
                            Position = @"TQ1.10",
                            Name = @"Condition text",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given. For example, ""PRN pain,"" or ""to keep blood pressure below 110.""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.11",
                            Type = @"Field",
                            Position = @"TQ1.11",
                            Name = @"Text instruction",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a full text version of the instruction (optional).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.12",
                            Type = @"Field",
                            Position = @"TQ1.12",
                            Name = @"Conjunction",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0472",
                            TableName = @"TQ conjunction ID",
                            Description = @"This field indicates that a second TQ1 segment is to follow. Refer To HL7 Table 0472 - TQ Conjunction ID for allowed values.

If the TQ1 segment is repeated in the message, this field must be populated with the appropriate Conjunction code indicating the sequencing of the following TQ1 segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13",
                            Type = @"Field",
                            Position = @"TQ1.13",
                            Name = @"Occurrence duration",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for which a single performance of a service is requested. The quantity component of this field must be a positive, non-zero number when populated. The units component is constrained to be units of time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.13.1",
                            Type = @"Component",
                            Position = @"TQ1.13.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2",
                            Type = @"Component",
                            Position = @"TQ1.13.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.1",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.2",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.3",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.4",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.5",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.6",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.7",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.8",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.13.2.9",
                            Type = @"SubComponent",
                            Position = @"TQ1.13.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TQ1.14",
                            Type = @"Field",
                            Position = @"TQ1.14",
                            Name = @"Total occurrences",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total number of occurrences of a service that should result from this service request. If both the end date/time (TQ1-8) and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence. Otherwise the number of occurrences takes precedence.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentTQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIDTQ1;

public HL7V26Field SetIDTQ1
{
    get
    {
        if (setIDTQ1 != null)
        {
            return setIDTQ1;
        }

        setIDTQ1 = new HL7V26Field
        {
            field = message[@"TQ1"][1],
            Id = @"TQ1.1",
            Type = @"Field",
            Position = @"TQ1.1",
            Name = @"Set ID - TQ1",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"For the first timing specification transmitted, the sequence number shall be 1; for the second timing specification, it shall be 2; and so on.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDTQ1.field.FieldRepetitions != null && setIDTQ1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDTQ1.Id));
            setIDTQ1.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(setIDTQ1, fieldData);
        }

        return setIDTQ1;
    } 
}

internal HL7V26Field quantity;

public HL7V26Field Quantity
{
    get
    {
        if (quantity != null)
        {
            return quantity;
        }

        quantity = new HL7V26Field
        {
            field = message[@"TQ1"][2],
            Id = @"TQ1.2",
            Type = @"Field",
            Position = @"TQ1.2",
            Name = @"Quantity",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the numeric quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be '2', or if three units of blood are to be typed and cross-matched, the quantity would be '3'. The default value for this field is '1'.",
            Sample = @"",
        };

        // check for repetitions
        if (quantity.field.FieldRepetitions != null && quantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantity.Id));
            quantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(quantity, fieldData);
        }

        return quantity;
    } 
}

internal HL7V26Field repeatPattern;

public HL7V26Field RepeatPattern
{
    get
    {
        if (repeatPattern != null)
        {
            return repeatPattern;
        }

        repeatPattern = new HL7V26Field
        {
            field = message[@"TQ1"][3],
            Id = @"TQ1.3",
            Type = @"Field",
            Position = @"TQ1.3",
            Name = @"Repeat Pattern",
            Length = 540,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"RPT",
            DataTypeName = @"Repeat Pattern",
            TableId = null,
            TableName = null,
            Description = @"The repeating frequency with which the treatment is to be administered. It is similar to the frequency and SIG code tables used in order entry systems.",
            Sample = @"",
        };

        // check for repetitions
        if (repeatPattern.field.FieldRepetitions != null && repeatPattern.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(repeatPattern.Id));
            repeatPattern.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(repeatPattern, fieldData);
        }

        return repeatPattern;
    } 
}

internal HL7V26Field explicitTime;

public HL7V26Field ExplicitTime
{
    get
    {
        if (explicitTime != null)
        {
            return explicitTime;
        }

        explicitTime = new HL7V26Field
        {
            field = message[@"TQ1"][4],
            Id = @"TQ1.4",
            Type = @"Field",
            Position = @"TQ1.4",
            Name = @"Explicit Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TM",
            DataTypeName = @"Time",
            TableId = null,
            TableName = null,
            Description = @"This field explicitly lists the actual times referenced by the code in TQ1-3. This field will be used to clarify the TQ1-3 in cases where the actual administration times vary within an institution. If the time of the service request spans more than a single day, this field is only practical if the same times of administration occur for each day of the service request. If the actual start time of the service request (as given by TQ1-7) is after the first explicit time, the first administration is taken to be the first explicit time after the start time. In the case where the patient moves to a location having a different set of explicit times, the existing service request may be updated with a new quantity/timing segment showing the changed explicit times.",
            Sample = @"",
        };

        // check for repetitions
        if (explicitTime.field.FieldRepetitions != null && explicitTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(explicitTime.Id));
            explicitTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(explicitTime, fieldData);
        }

        return explicitTime;
    } 
}

internal HL7V26Field relativeTimeandUnits;

public HL7V26Field RelativeTimeandUnits
{
    get
    {
        if (relativeTimeandUnits != null)
        {
            return relativeTimeandUnits;
        }

        relativeTimeandUnits = new HL7V26Field
        {
            field = message[@"TQ1"][5],
            Id = @"TQ1.5",
            Type = @"Field",
            Position = @"TQ1.5",
            Name = @"Relative Time and Units",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field is used to define the interval between schedules for service request or bottle records. If this field contains a value, it overrides any value in the explicit time interval field. The units component of the CQ data type is constrained to units of time.",
            Sample = @"",
        };

        // check for repetitions
        if (relativeTimeandUnits.field.FieldRepetitions != null && relativeTimeandUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relativeTimeandUnits.Id));
            relativeTimeandUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(relativeTimeandUnits, fieldData);
        }

        return relativeTimeandUnits;
    } 
}

internal HL7V26Field serviceDuration;

public HL7V26Field ServiceDuration
{
    get
    {
        if (serviceDuration != null)
        {
            return serviceDuration;
        }

        serviceDuration = new HL7V26Field
        {
            field = message[@"TQ1"][6],
            Id = @"TQ1.6",
            Type = @"Field",
            Position = @"TQ1.6",
            Name = @"Service Duration",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the duration for which the service is requested.",
            Sample = @"",
        };

        // check for repetitions
        if (serviceDuration.field.FieldRepetitions != null && serviceDuration.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(serviceDuration.Id));
            serviceDuration.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(serviceDuration, fieldData);
        }

        return serviceDuration;
    } 
}

internal HL7V26Field startdatetime;

public HL7V26Field Startdatetime
{
    get
    {
        if (startdatetime != null)
        {
            return startdatetime;
        }

        startdatetime = new HL7V26Field
        {
            field = message[@"TQ1"][7],
            Id = @"TQ1.7",
            Type = @"Field",
            Position = @"TQ1.7",
            Name = @"Start date/time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field may be specified by the requester, in which case it indicates the earliest date/time at which the services should be started. In many cases, however, the start date/time will be implied or will be defined by other fields in the service request record (e.g., urgency - STAT). In such a case, this field will be empty.",
            Sample = @"",
        };

        // check for repetitions
        if (startdatetime.field.FieldRepetitions != null && startdatetime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(startdatetime.Id));
            startdatetime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(startdatetime, fieldData);
        }

        return startdatetime;
    } 
}

internal HL7V26Field enddatetime;

public HL7V26Field Enddatetime
{
    get
    {
        if (enddatetime != null)
        {
            return enddatetime;
        }

        enddatetime = new HL7V26Field
        {
            field = message[@"TQ1"][8],
            Id = @"TQ1.8",
            Type = @"Field",
            Position = @"TQ1.8",
            Name = @"End date/time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"When filled in by the requester of the service, this field should contain the latest date/time that the service should be performed. If it has not been performed by the specified time, it should not be performed at all. The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
            Sample = @"",
        };

        // check for repetitions
        if (enddatetime.field.FieldRepetitions != null && enddatetime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(enddatetime.Id));
            enddatetime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(enddatetime, fieldData);
        }

        return enddatetime;
    } 
}

internal HL7V26Field priority;

public HL7V26Field Priority
{
    get
    {
        if (priority != null)
        {
            return priority;
        }

        priority = new HL7V26Field
        {
            field = message[@"TQ1"][9],
            Id = @"TQ1.9",
            Type = @"Field",
            Position = @"TQ1.9",
            Name = @"Priority",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0485",
            TableName = @"Extended Priority Codes",
            Description = @"This field describes the urgency of the request. If this field is blank, the default is R. Refer to User-Defined Table 0485 - Extended Priority Codes for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (priority.field.FieldRepetitions != null && priority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priority.Id));
            priority.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(priority, fieldData);
        }

        return priority;
    } 
}

internal HL7V26Field conditiontext;

public HL7V26Field Conditiontext
{
    get
    {
        if (conditiontext != null)
        {
            return conditiontext;
        }

        conditiontext = new HL7V26Field
        {
            field = message[@"TQ1"][10],
            Id = @"TQ1.10",
            Type = @"Field",
            Position = @"TQ1.10",
            Name = @"Condition text",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This is a free text field that describes the conditions under which the drug is to be given. For example, ""PRN pain,"" or ""to keep blood pressure below 110.""",
            Sample = @"",
        };

        // check for repetitions
        if (conditiontext.field.FieldRepetitions != null && conditiontext.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(conditiontext.Id));
            conditiontext.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(conditiontext, fieldData);
        }

        return conditiontext;
    } 
}

internal HL7V26Field textinstruction;

public HL7V26Field Textinstruction
{
    get
    {
        if (textinstruction != null)
        {
            return textinstruction;
        }

        textinstruction = new HL7V26Field
        {
            field = message[@"TQ1"][11],
            Id = @"TQ1.11",
            Type = @"Field",
            Position = @"TQ1.11",
            Name = @"Text instruction",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field is a full text version of the instruction (optional).",
            Sample = @"",
        };

        // check for repetitions
        if (textinstruction.field.FieldRepetitions != null && textinstruction.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(textinstruction.Id));
            textinstruction.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(textinstruction, fieldData);
        }

        return textinstruction;
    } 
}

internal HL7V26Field conjunction;

public HL7V26Field Conjunction
{
    get
    {
        if (conjunction != null)
        {
            return conjunction;
        }

        conjunction = new HL7V26Field
        {
            field = message[@"TQ1"][12],
            Id = @"TQ1.12",
            Type = @"Field",
            Position = @"TQ1.12",
            Name = @"Conjunction",
            Length = 10,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0472",
            TableName = @"TQ conjunction ID",
            Description = @"This field indicates that a second TQ1 segment is to follow. Refer To HL7 Table 0472 - TQ Conjunction ID for allowed values.

If the TQ1 segment is repeated in the message, this field must be populated with the appropriate Conjunction code indicating the sequencing of the following TQ1 segment.",
            Sample = @"",
        };

        // check for repetitions
        if (conjunction.field.FieldRepetitions != null && conjunction.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(conjunction.Id));
            conjunction.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(conjunction, fieldData);
        }

        return conjunction;
    } 
}

internal HL7V26Field occurrenceduration;

public HL7V26Field Occurrenceduration
{
    get
    {
        if (occurrenceduration != null)
        {
            return occurrenceduration;
        }

        occurrenceduration = new HL7V26Field
        {
            field = message[@"TQ1"][13],
            Id = @"TQ1.13",
            Type = @"Field",
            Position = @"TQ1.13",
            Name = @"Occurrence duration",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the duration for which a single performance of a service is requested. The quantity component of this field must be a positive, non-zero number when populated. The units component is constrained to be units of time.",
            Sample = @"",
        };

        // check for repetitions
        if (occurrenceduration.field.FieldRepetitions != null && occurrenceduration.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(occurrenceduration.Id));
            occurrenceduration.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(occurrenceduration, fieldData);
        }

        return occurrenceduration;
    } 
}

internal HL7V26Field totaloccurrences;

public HL7V26Field Totaloccurrences
{
    get
    {
        if (totaloccurrences != null)
        {
            return totaloccurrences;
        }

        totaloccurrences = new HL7V26Field
        {
            field = message[@"TQ1"][14],
            Id = @"TQ1.14",
            Type = @"Field",
            Position = @"TQ1.14",
            Name = @"Total occurrences",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total number of occurrences of a service that should result from this service request. If both the end date/time (TQ1-8) and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence. Otherwise the number of occurrences takes precedence.",
            Sample = @"",
        };

        // check for repetitions
        if (totaloccurrences.field.FieldRepetitions != null && totaloccurrences.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(totaloccurrences.Id));
            totaloccurrences.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(totaloccurrences, fieldData);
        }

        return totaloccurrences;
    } 
}
    }
}
