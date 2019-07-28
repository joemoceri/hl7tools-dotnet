using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpressionEvaluator.Controllers;
using ExpressionEvaluator.Services;

namespace ExpressionEvaluator_UnitTesting
{
	[TestClass]
	public class ErrorTests
	{
		private ArithmeticController solver = new ArithmeticController(new ArithmeticService());

		[TestMethod]
		public void BadInput_ShouldReturnExpressionResultWithNullValuesAndException()
		{
			var result = solver.Evaluate("asdjhas;dglasd;a;s");
			Assert.IsNotNull(result.Error);
		}
	}
}
