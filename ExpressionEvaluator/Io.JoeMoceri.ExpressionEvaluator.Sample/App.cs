using System;
using System.IO;

namespace Io.JoeMoceri.ExpressionEvaluator.Sample
{
    public class App
    {
        public void Run()
        {
            ParseHL7FileExample();

            //SolveMathExample();

            //SolveBooleanExample();

            Console.ReadLine();
        }

        public void SolveMathExample()
        {
            var evaluator = new Evaluator();

            var r = 1 + 2 * (3 - 4) / 18;

            var result = evaluator.Evaluate("1 + 2 * (3 - 4) / 18");

            Console.WriteLine($"{r} = {result}");
        }

        public void SolveBooleanExample()
        {
            var evaluator = new Evaluator();

            var r = 1 > 2 && (3 + 4) / 2 == 5;

            var result = evaluator.Evaluate("1 > 2 and (3 + 4) / 2 == 5");

            Console.WriteLine($"{r} = {result}");
        }

        public void ParseHL7FileExample()
        {
            // TODO: Implement the rest of the delimiters
            // one liner
            //var hl7v2Message = new Evaluator(new HL7V2ExpressionConfiguration()).EvaluateHL7V2File("HL7File.txt");

            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var hl7v2Message = evaluator.EvaluateHL7V2File("HL7File.txt");

            var msh = hl7v2Message["MSH"];
            var msh1 = hl7v2Message.GetFieldValue("MSH.1");
            var msh2 = hl7v2Message.GetFieldValue("MSH.2");
            var msh3 = hl7v2Message.GetFieldValue("MSH.3");
            var msh4 = hl7v2Message.GetFieldValue("MSH.4");
            var msh7 = hl7v2Message.GetFieldValue("MSH.7");
            var msh8 = hl7v2Message.GetFieldValue("MSH.8");
            var msh9 = hl7v2Message.GetFieldValue("MSH.9");
            //var msh91 = hl7v2Message.GetFieldValue("MSH.9.1");
            //var msh92 = hl7v2Message.GetFieldValue("MSH.9.2");
            //var ob33 = hl7v2Message.GetFieldValue("OBR.33");
            //var ob3312 = hl7v2Message.GetFieldValue("OBR.33.1.2");

            var pid = hl7v2Message["PID"];
            var pid5 = hl7v2Message.GetFieldValue("PID.5");
            var pid7 = hl7v2Message.GetFieldValue("PID.7");

            Console.WriteLine("Final Output:");

            foreach (var messageSegment in hl7v2Message.MessageSegments)
            {
                Console.WriteLine(messageSegment.ToString());
            }
        }
    }
}
