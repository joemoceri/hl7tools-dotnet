using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionEvaluatorForDotNet.Tests
{
	[TestClass]
	public class CustomOperatorTests
	{
		[TestMethod]
		public void CustomOperatorTests_AdditionOnBeforeOperatorExpressionSolved()
		{
			// Arrange
			var expressionConfiguration = new CSharpExpressionConfiguration();

			var additionOperator = expressionConfiguration.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			additionOperator.OnBeforeOperatorExpressionSolved = (expGroup) =>
			{
				count++;
			};

			var evaluator = new Evaluator(expressionConfiguration);

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

			var greaterThan = expressionConfiguration.BooleanOperators.First(o => o.ExpressionOperator == Operator.GreaterThan);

			greaterThan.OnBeforeOperatorExpressionSolved = (expResult) =>
			{
				count++;
			};

			evaluator.Evaluate("1>2");

			Assert.AreEqual(count, 3);

			greaterThan.OnBeforeOperatorExpressionSolved = null;

			evaluator.Evaluate("1>2");

			Assert.AreEqual(count, 3);
		}

		[TestMethod]
		public void CustomOperatorTests_AdditionOnAfterOperatorExpressionSolved()
		{
			// Arrange
			var expressionConfiguration = new CSharpExpressionConfiguration();

			var additionOperator = expressionConfiguration.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			additionOperator.OnAfterOperatorExpressionSolved = (expressionResult) =>
			{
				// the expression is known
				var v = int.Parse(expressionResult.Value);

				count += v;
			};

			var evaluator = new Evaluator(expressionConfiguration);

			var exp = "1+2";

			// Act
			evaluator.Evaluate(exp);

			// Assert
			Assert.AreEqual(count, 3);

			evaluator.Evaluate(exp);

			Assert.AreEqual(count, 6);

			additionOperator.OnAfterOperatorExpressionSolved = null;

			evaluator.Evaluate(exp);

			// shouldn't be called
			Assert.AreEqual(count, 6);

			var greaterThan = expressionConfiguration.BooleanOperators.First(o => o.ExpressionOperator == Operator.GreaterThan);

			greaterThan.OnAfterOperatorExpressionSolved = (expResult) =>
			{
				count++;
			};

			evaluator.Evaluate("1>2");

			Assert.AreEqual(count, 7);

			greaterThan.OnAfterOperatorExpressionSolved = null;

			evaluator.Evaluate("1>2");

			Assert.AreEqual(count, 7);
		}

		[TestMethod]
		public void CustomOperatorTests_AdditionSolveOperatorExpression()
		{
			// Arrange
			var expressionConfiguration = new CSharpExpressionConfiguration();

			var additionOperator = expressionConfiguration.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				return new ExpressionResult
				{
					Value = "0",
					Type = VariableType.Int
				};
			};

			var evaluator = new Evaluator(expressionConfiguration);

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

			additionOperator.SolveOperatorExpression = null;

			var greaterThan = expressionConfiguration.BooleanOperators.First(o => o.ExpressionOperator == Operator.GreaterThan);

			var guid = $"{Guid.NewGuid()}";

			greaterThan.SolveOperatorExpression = (expGroup) =>
			{
				return new ExpressionResult
				{
					Value = guid,
					Type = VariableType.Boolean
				};
			};

			result = evaluator.Evaluate("1>2");

			Assert.AreEqual(result.Value, guid);
			Assert.AreEqual(result.Type, VariableType.Boolean);
		}

        [TestMethod]
        public void CustomOperatorTests_HL7MSHExpression()
        {
            // Arrange
            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var msh = @"MSH|^~\&|AccMgr|1|||20050110045504||ADT^A08|599102|P|2.3|||";

            // Act
            var result = evaluator.Evaluate(msh);

            // Assert
            Assert.AreEqual(expressionConfiguration.DefaultExpressionResult, result);

			var combinedParts = expressionConfiguration.GetHL7V2MessageSegment().ToString();

			Assert.AreEqual(combinedParts, msh);
        }

        [TestMethod]
        public void CustomOperatorTests_HL7PIDExpression()
        {
            // Arrange
            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var pid = "PID|1||10006579^^^1^MRN^1||DUCK^DONALD^D||19241010|M||1|111 DUCK ST^^FOWL^CA^999990000^^M|1|8885551212|8885551212|1|2||40007716^^^AccMgr^VN^1|123121234|||||||||||NO";

            // Act
            var result = evaluator.Evaluate(pid);

            // Assert
            Assert.AreEqual(expressionConfiguration.DefaultExpressionResult, result);

			var combinedParts = expressionConfiguration.GetHL7V2MessageSegment().ToString();

			Assert.AreEqual(combinedParts, pid);
        }

        [TestMethod]
        public void CustomOperatorTests_HL7NK1Expression()
        {
            // Arrange
            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var nk1 = "NK1|1|DUCK^HUEY|SO|3583 DUCK RD^^FOWL^CA^999990000|8885552222||Y||||||||||||||";

            // Act
            var result = evaluator.Evaluate(nk1);

            // Assert
            Assert.AreEqual(expressionConfiguration.DefaultExpressionResult, result);

            var combinedParts = expressionConfiguration.GetHL7V2MessageSegment().ToString();

            Assert.AreEqual(combinedParts, nk1);
        }

        [TestMethod]
		public void CustomOperatorTests_HL7PV1Expression()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();
			
			var evaluator = new Evaluator(expressionConfiguration);

			var pv1 = "PV1|1|I|PREOP^101^1^1^^^S|3|||37^DISNEY^WALT^^^^^^AccMgr^^^^CI|||01||||1|||37^DISNEY^WALT^^^^^^AccMgr^^^^CI|2|40007716^^^AccMgr^VN|4|||||||||||||||||||1||G|||20050110045253||||||";

			// Act
			var result = evaluator.Evaluate(pv1);

			// Assert
			Assert.AreEqual(expressionConfiguration.DefaultExpressionResult, result);

			var combinedParts = expressionConfiguration.GetHL7V2MessageSegment().ToString();

			Assert.AreEqual(combinedParts, pv1);
		}

		[TestMethod]
		public void CustomOperatorTests_ParseMultipleHL7Expressions()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			var hl7Lines = new[] {
				@"MSH|^~\&|AccMgr|1|||20050110045504||ADT^A08|599102|P|2.3|||",
				"EVN|A01|20050110045502|||||",
				"PID|1||10006579^^^1^MRN^1||DUCK^DONALD^D||19241010|M||1|111 DUCK ST^^FOWL^CA^999990000^^M|1|8885551212|8885551212|1|2||40007716^^^AccMgr^VN^1|123121234|||||||||||NO",
				"NK1|1|DUCK^HUEY|SO|3583 DUCK RD^^FOWL^CA^999990000|8885552222||Y||||||||||||||",
				"PV1|1|I|PREOP^101^1^1^^^S|3|||37^DISNEY^WALT^^^^^^AccMgr^^^^CI|||01||||1|||37^DISNEY^WALT^^^^^^AccMgr^^^^CI|2|40007716^^^AccMgr^VN|4|||||||||||||||||||1||G|||20050110045253||||||",
				"GT1|1|8291|DUCK^DONALD^D||111^DUCK ST^^FOWL^CA^999990000|8885551212||19241010|M||1|123121234||||#Cartoon Ducks Inc|111^DUCK ST^^FOWL^CA^999990000|8885551212||PT|",
				"DG1|1|I9|71596^OSTEOARTHROS NOS-L/LEG ^I9|OSTEOARTHROS NOS-L/LEG ||A|",
				@"IN1|1|MEDICARE|3|MEDICARE|||||||Cartoon Ducks Inc|19891001|||4|DUCK^DONALD^D|1|19241010|111^DUCK ST^^FOWL^CA^999990000|||||||||||||||||123121234A||||||PT|M|111 DUCK ""ST^^FOWL^CA^999990000|||||8291",
				"IN2|1||123121234|Cartoon Ducks Inc|||123121234A|||||||||||||||||||||||||||||||||||||||||||||||||||||||||8885551212",
				@"IN1|2|NON-PRIMARY|9|MEDICAL MUTUAL CALIF.|PO BOX 94776^^HOLLYWOOD^CA^441414776||8003621279|PUBSUMB|||Cartoon Ducks Inc||||7|DUCK^DONALD^D|1|19241010|111 DUCK ""ST^^FOWL^CA^999990000|||||||||||||||||056269770||||||PT|M|111^DUCK ST^^FOWL^CA^999990000|||||8291",
				"IN2|2||123121234|Cartoon Ducks Inc||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||8885551212",
				"IN1|3|SELF PAY|1|SELF PAY|||||||||||5||1",
			};

			var results = new List<HL7V2MessageSegment>();

			// Act
			for (var i = 0; i < hl7Lines.Length; i++)
            {
				var result = evaluator.Evaluate(hl7Lines[i]);

				results.Add(expressionConfiguration.GetHL7V2MessageSegment());

				// Assert
				Assert.AreEqual(expressionConfiguration.DefaultExpressionResult, result);
            }

			// Act
			for (var i = 0; i < results.Count; i++)
            {
				var combinedParts = results[i].ToString();

				// Assert
				Assert.AreEqual(combinedParts, hl7Lines[i]);
            }

		}
	}
}
