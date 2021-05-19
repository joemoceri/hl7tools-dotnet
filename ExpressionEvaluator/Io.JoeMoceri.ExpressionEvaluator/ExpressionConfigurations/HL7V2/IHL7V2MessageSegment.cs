using System.Collections.Generic;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public interface IHL7V2MessageSegment
    {
        string SegmentName { get; set; }

        IList<IHL7V2Field> Fields { get; set; }

        string ToString();

		IHL7V2Field this[int id]
        {
            get;
        }
    }
}
