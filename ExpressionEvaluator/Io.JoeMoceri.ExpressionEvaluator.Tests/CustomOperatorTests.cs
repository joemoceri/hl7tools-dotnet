using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class CustomOperatorTests
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void CustomOperatorTests_AdditionOnBeforeOperatorExpressionSolved()
		{
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			additionOperator.OnBeforeOperatorExpressionSolved = (expGroup) =>
			{
				count++;
			};

			solver = new Evaluator(languageTemplate);

			var answer = new ExpressionResult 
			{
				Value = "3", Type = VariableType.Int 
			};

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
			Assert.AreEqual(count, 1);

			solver.Evaluate(exp);

			Assert.AreEqual(count, 2);

			additionOperator.OnBeforeOperatorExpressionSolved = null;

			solver.Evaluate(exp);

			// shouldn't be incremented
			Assert.AreEqual(count, 2);
		}

		[TestMethod]
		public void CustomOperatorTests_AdditionOnAfterOperatorExpressionSolved()
		{
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			additionOperator.OnAfterOperatorExpressionSolved = (expressionResult) =>
			{
				// the expression is known, so this is safe, and the point. You're in control.
				var v = int.Parse(expressionResult.Value);

				count += v;
			};

			solver = new Evaluator(languageTemplate);

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(count, 3);

			solver.Evaluate(exp);

			Assert.AreEqual(count, 6);

			additionOperator.OnAfterOperatorExpressionSolved = null;

			solver.Evaluate(exp);

			// shouldn't be called
			Assert.AreEqual(count, 6);
		}

		[TestMethod]
		public void CustomOperatorTests_AdditionSolveOperatorExpression()
		{
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				return new ExpressionResult
				{
					Value = "0",
					Type = VariableType.Int
				};
			};

			solver = new Evaluator(languageTemplate);

			var answer = new ExpressionResult
			{
				Value = "0",
				Type = VariableType.Int
			};

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void CustomOperatorTests_HL7MSHExpression()
        {
			// Arrange
			var answer = new ExpressionResult
			{
				Value = "\"done\"",
				Type = VariableType.String
			};

			var languageTemplate = new HL7MshExpressionsLanguageTemplate();

			var parts = new List<Hl7MshPart>();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var delimiterCount = 0;

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				// this is the real work. Check the right operand for your value, the left will be whatever is being returned after the first time, in this case the string "done"
				delimiterCount++;
				parts.Add(new Hl7MshPart
				{
					DelimiterIndex = delimiterCount,
					LeftOperand = expGroup.LeftOperand,
					RightOperand = expGroup.RightOperand
				});

				// just return something to make the evaluator happy. The final expression will always be this if it runs successfully.
				return answer;
			};


			solver = new Evaluator(languageTemplate);

			var exp = "MSH|^~\\&|EPIC|EPICADT|SMS|SMSADT|199912271408|CHARRIS|ADT^A04|1817457|D|2.5|";

			// Act
			var result = solver.Evaluate(exp);

			foreach (var part in parts)
            {
				// do whatever you need to here
            }

            // Assert
            Assert.AreEqual(answer, result);
        }

	}
}
