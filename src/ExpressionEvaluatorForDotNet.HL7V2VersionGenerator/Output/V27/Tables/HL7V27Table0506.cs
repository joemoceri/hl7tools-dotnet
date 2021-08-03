using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0506
    {
        public string Id { get { return @"0506"; } }

        public string TableId { get { return @"0506"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Service Request Relationship"; } }

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
                            Value = @"C",
                            Description = @"Compound",
                            Comment = @"A compound is an extempo order which may be made up of multiple drugs. For example, many hospitals have a standard item called ""Magic Mouthwash"". The item is ordered that way by the physician. The extempo items will contain multiple products, such as Maalox, Benadryl, Xylocaine, etc. They will all be mixed together and will be dispensed in a single container."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Exclusive",
                            Comment = @"An exclusive order is an order where only one of the multiple items should be administered at any one dosage time. The nurse may chose between the alternatives, but should only give ONE of them. An example would be: Phenergan 25 mg PO, IM or R q6h prn (orally, intramuscularly, or rectally every 6 hours as needed)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Nurse prerogative",
                            Comment = @"Where a set of two or more orders exist and the Nurse, or other caregiver, has the prerogative to choose which order will be administered at a particular point in time."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Simultaneous",
                            Comment = @"simultaneous order is 2 or more drugs which are ordered to be given at the same time. A common example of this would be Demerol and Phenergan (Phenergan is given with the Demerol to control the nausea that Demerol can cause). The order could be: Demerol 50 mg IM with Phenergan 25 mg IM q4h prn (every 4 hours as needed)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Tapering",
                            Comment = @"A tapering order is one in which the same drug is used, but it has a declining dosage over a number of days."
                        },
                    };
            } 
        }
    }
}
