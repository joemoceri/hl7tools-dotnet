using ExpressionEvaluator.Utilities;

namespace ExpressionEvaluator.Models
{
	public class ArithmeticGroup
	{
		public ArithmeticType LeftType { get; set; }
		public ArithmeticType RightType { get; set; }
		public ArithmeticType ExpressionType { get; set; }
	}
}
