using System;
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
            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var hl7v2Message = evaluator.EvaluateHL7V2File("HL7File.txt");

            var segment = hl7v2Message["PID"];
            var field = hl7v2Message.GetField("PID.3.1");

            Console.WriteLine("Final Output:");

            foreach (var messageSegment in hl7v2Message.MessageSegments)
            {
                Console.WriteLine(messageSegment.ToString());
            }
        }
    }
}
