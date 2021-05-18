﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class ErrorTests
	{
		private Evaluator evaluator = new Evaluator();

		[TestMethod]
		public void ErrorTests_BadInput_ShouldReturnExpressionResultWithNullValuesAndException()
		{
			var result = evaluator.Evaluate("asdjhas;dglasd;a;s");

			Assert.IsNull(result.Type);
			Assert.IsNull(result.Value);
			Assert.IsNotNull(result.Error);
		}

		[TestMethod]
		public void ErrorTests_NullInput_ShouldReturnExpressionResultWithNullValuesAndException()
		{
			var result = evaluator.Evaluate(null);

			Assert.IsNull(result.Type);
			Assert.IsNull(result.Value);
			Assert.IsNotNull(result.Error);
		}
	}
}
