using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentMsh
    {
        public readonly HL7V2Message message;

        public HL7V23SegmentMsh(HL7V2Message message)
        {
            this.message = message;
        }

        public HL7V23Field FieldSeparator
        { 
            get 
            {
                var fieldData = new HL7V2FieldData
                {
                    Id = "MSH.1",
                    Type = "Field",
                    Position = "MSH.1",
                    Name = "Field Separator",
                    Length = 1,
                    Usage = "R",
                    Rpt = "1",
                    DataType = "ST",
                    DataTypeName = "String Data",
                    TableId = null,
                    TableName = null,
                    Description = "This field contains the separator between the segment ID and the first real field, MSH-2encoding characters.  As such it serves as the separator and defines the character to be used as a separator for the rest of the message.  Recommended value is |, (ASCII 124). ",
                    Sample = "",
                    FieldDatas = Enumerable.Empty<HL7V2FieldData>().ToList()
                };

                var result = new HL7V23Field(message["MSH"][1], fieldData);

                return result;
            } 
        }

        public HL7V23Field EncodingCharacters { get { return new HL7V23Field(message["MSH"][2], null); } }
        public HL7V23Field SendingApplication { get { return new HL7V23Field(message["MSH"][3], null); } }
        public HL7V23Field SendingFacility { get { return new HL7V23Field(message["MSH"][4], null); } }
        public HL7V23Field ReceivingApplication { get { return new HL7V23Field(message["MSH"][5], null); } }
        public HL7V23Field ReceivingFacility { get { return new HL7V23Field(message["MSH"][6], null); } }
        public HL7V23Field DateTimeOfMessage { get { return new HL7V23Field(message["MSH"][7], null); } }
        public HL7V23Field Security { get { return new HL7V23Field(message["MSH"][8], null); } }
        public HL7V23Field MessageType { get { return new HL7V23Field(message["MSH"][9], null); } }
        public HL7V23Field MessageControlId { get { return new HL7V23Field(message["MSH"][10], null); } }
        public HL7V23Field ProcessingId { get { return new HL7V23Field(message["MSH"][11], null); } }
        public HL7V23Field VersionId { get { return new HL7V23Field(message["MSH"][12], null); } }
        public HL7V23Field SequenceNumber { get { return new HL7V23Field(message["MSH"][13], null); } }
        public HL7V23Field ContinuationPointer { get { return new HL7V23Field(message["MSH"][14], null); } }
        public HL7V23Field AcceptAcknowledgementType { get { return new HL7V23Field(message["MSH"][15], null); } }
        public HL7V23Field ApplicationAcknowledgementType { get { return new HL7V23Field(message["MSH"][16], null); } }
        public HL7V23Field CountryCode { get { return new HL7V23Field(message["MSH"][17], null); } }
        public HL7V23Field CharacterSet { get { return new HL7V23Field(message["MSH"][18], null); } }
        public HL7V23Field PrincipleLanguageOfMessage { get { return new HL7V23Field(message["MSH"][19], null); } }
    }
}
