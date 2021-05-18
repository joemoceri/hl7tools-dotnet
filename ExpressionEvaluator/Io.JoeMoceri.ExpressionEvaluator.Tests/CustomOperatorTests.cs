using Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class CustomOperatorTests
	{
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

			var evaluator = new Evaluator(languageTemplate);

			var answer = new ExpressionResult 
			{
				Value = "3", Type = VariableType.Int 
			};

			var exp = "1+2";

			// Act
			var result = evaluator.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
			Assert.AreEqual(count, 1);

			evaluator.Evaluate(exp);

			Assert.AreEqual(count, 2);

			additionOperator.OnBeforeOperatorExpressionSolved = null;

			evaluator.Evaluate(exp);

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
				// the expression is known
				var v = int.Parse(expressionResult.Value);

				count += v;
			};

			var evaluator = new Evaluator(languageTemplate);

			var exp = "1+2";

			// Act
			var result = evaluator.Evaluate(exp);

			// Assert
			Assert.AreEqual(count, 3);

			evaluator.Evaluate(exp);

			Assert.AreEqual(count, 6);

			additionOperator.OnAfterOperatorExpressionSolved = null;

			evaluator.Evaluate(exp);

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

			var evaluator = new Evaluator(languageTemplate);

			var answer = new ExpressionResult
			{
				Value = "0",
				Type = VariableType.Int
			};

			var exp = "1+2";

			// Act
			var result = evaluator.Evaluate(exp);

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

			var languageTemplate = new HL7ExpressionsLanguageTemplate();

			var segment = "MSH";
			var parts = new List<HL7Part>();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var delimiter = additionOperator.OperatorName;

			var delimiterCount = 0;

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				// this is the real work. Check the right operand for your value, the left will be whatever is being returned after the first time, in this case the string "done"
				delimiterCount++;
				parts.Add(new HL7Part
				{
					Segment = segment,
					Delimiter = delimiter,
					DelimiterIndex = delimiterCount,
					Value = expGroup.RightOperand
				});

				// just return something to make the evaluator happy. The final expression will always be this if it runs successfully.
				return answer;
			};

			var evaluator = new Evaluator(languageTemplate);

			var msh = "MSH|^~\\&|EPIC|EPICADT|SMS|SMSADT|199912271408|CHARRIS|ADT^A04|1817457|D|2.5|";

			// Act
			var result = evaluator.Evaluate(msh);

            // Assert
            Assert.AreEqual(answer, result);

			var hl7Result = new HL7Result
			{
				Parts = parts
			};

			var combinedParts = hl7Result.ToString();

			Assert.AreEqual(combinedParts, msh);
        }

		[TestMethod]
		public void CustomOperatorTests_HL7PIDExpression()
		{
			// Arrange
			var answer = new ExpressionResult
			{
				Value = "\"done\"",
				Type = VariableType.String
			};

			var languageTemplate = new HL7ExpressionsLanguageTemplate();

			var segment = "PID";
			var parts = new List<HL7Part>();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var delimiter = additionOperator.OperatorName;

			var delimiterCount = 0;

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				// this is the real work. Check the right operand for your value, the left will be whatever is being returned after the first time, in this case the string "done"
				delimiterCount++;
				parts.Add(new HL7Part
				{
					Segment = segment,
					Delimiter = delimiter,
					DelimiterIndex = delimiterCount,
					Value = expGroup.RightOperand
				});

				// just return something to make the evaluator happy. The final expression will always be this if it runs successfully.
				return answer;
			};

			var evaluator = new Evaluator(languageTemplate);

			var pid = "PID||0493575^^^2^ID 1|454721||DOE^JOHN^^^^|DOE^JOHN^^^^|19480203|M||B|254 MYSTREET AVE^^MYTOWN^OH^44123^USA||(216)123-4567|||M|NON|400003403~1129086|";
			
			// Act
			var result = evaluator.Evaluate(pid);

			// Assert
			Assert.AreEqual(answer, result);

			var hl7Result = new HL7Result
			{
				Parts = parts
			};

			var combinedParts = hl7Result.ToString();

			Assert.AreEqual(combinedParts, pid);
		}

		[TestMethod]
		public void CustomOperatorTests_HL7NK1Expression()
		{
			// Arrange
			var answer = new ExpressionResult
			{
				Value = "\"done\"",
				Type = VariableType.String
			};

			var languageTemplate = new HL7ExpressionsLanguageTemplate();

			var segment = "NK1";
			var parts = new List<HL7Part>();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var delimiter = additionOperator.OperatorName;

			var delimiterCount = 0;

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				// this is the real work. Check the right operand for your value, the left will be whatever is being returned after the first time, in this case the string "done"
				delimiterCount++;
				parts.Add(new HL7Part
				{
					Segment = segment,
					Delimiter = delimiter,
					DelimiterIndex = delimiterCount,
					Value = expGroup.RightOperand
				});

				// just return something to make the evaluator happy. The final expression will always be this if it runs successfully.
				return answer;
			};

			var evaluator = new Evaluator(languageTemplate);

			var nk1 = "NK1||ROE^MARIE^^^^|SPO||(216)123-4567||EC|||||||||||||||||||||||||||";
			
			// Act
			var result = evaluator.Evaluate(nk1);

			// Assert
			Assert.AreEqual(answer, result);

			var hl7Result = new HL7Result
			{
				Parts = parts
			};

			var combinedParts = hl7Result.ToString();

			Assert.AreEqual(combinedParts, nk1);
		}

		[TestMethod]
		public void CustomOperatorTests_HL7PV1Expression()
		{
			// Arrange
			var answer = new ExpressionResult
			{
				Value = "\"done\"",
				Type = VariableType.String
			};

			var languageTemplate = new HL7ExpressionsLanguageTemplate();

			var segment = "PV1";
			var parts = new List<HL7Part>();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var delimiter = additionOperator.OperatorName;

			var delimiterCount = 0;

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				// this is the real work. Check the right operand for your value, the left will be whatever is being returned after the first time, in this case the string "done"
				delimiterCount++;
				parts.Add(new HL7Part
				{
					Segment = segment,
					Delimiter = delimiter,
					DelimiterIndex = delimiterCount,
					Value = expGroup.RightOperand
				});

				// just return something to make the evaluator happy. The final expression will always be this if it runs successfully.
				return answer;
			};

			var evaluator = new Evaluator(languageTemplate);

			var pv1 = "PV1||O|168 ~219~C~PMA^^^^^^^^^||||277^ALLEN MYLASTNAME^BONNIE^^^^|||||||||| ||2688684|||||||||||||||||||||||||199912271408||||||002376853";

			// Act
			var result = evaluator.Evaluate(pv1);

			// Assert
			Assert.AreEqual(answer, result);

			var hl7Result = new HL7Result
			{
				Parts = parts
			};

			var combinedParts = hl7Result.ToString();

			Assert.AreEqual(combinedParts, pv1);
		}
	}
}
