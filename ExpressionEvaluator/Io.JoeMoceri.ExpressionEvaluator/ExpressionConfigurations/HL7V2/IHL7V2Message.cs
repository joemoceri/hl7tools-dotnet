using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public interface IHL7V2Message
    {
        IHL7V2Field GetField(string id);
        IHL7V2MessageSegment this[string segmentName]
        {
            get;
        }

        IList<IHL7V2MessageSegment> MessageSegments { get; }
    }
}
