using Io.JoeMoceri.ExpressionEvaluator.ExpressionConfiguration;
using System;
using System.Collections.Generic;
using System.IO;

namespace Io.JoeMoceri.ExpressionEvaluator.Sample
{
    public class App
    {
        public void Run()
        {
            ParseHL7FileExample();

            // SolveMathExample();

            // SolveBooleanExample();

            Console.ReadLine();
        }

        public void SolveMathExample()
        {
            var evaluator = new Evaluator();

            var result = evaluator.Evaluate("1 + 2 * (3 - 4) / 18");

            Console.WriteLine(result.ToString());
        }

        public void SolveBooleanExample()
        {
            var evaluator = new Evaluator();

            var result = evaluator.Evaluate("1 > 2 and (3 + 4) / 2 == 5");

            Console.WriteLine(result.ToString());
        }

        public void ParseHL7FileExample()
        {
            var lines = File.ReadLines("HL7File.txt");

            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var messageSegments = new List<HL7V2MessageSegment>();

            foreach (var line in lines)
            {
                evaluator.Evaluate(line);

                var messageSegment = expressionConfiguration.GetHL7V2MessageSegment();

                Console.WriteLine(messageSegment.ToString());

                messageSegments.Add(messageSegment);
            }

            Console.WriteLine("Final Output:");

            foreach (var messageSegment in messageSegments)
            {
                Console.WriteLine(messageSegment.ToString());
            }
        }
    }
}
