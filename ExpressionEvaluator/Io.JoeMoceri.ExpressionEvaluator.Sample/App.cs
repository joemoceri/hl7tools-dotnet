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
            // one liner
            //var hl7v2Message = new Evaluator(new HL7V2ExpressionConfiguration()).EvaluateHL7V2File("HL7File.txt");

            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var hl7v2Message = evaluator.EvaluateHL7V2File("HL7File.txt");

            var msh = hl7v2Message["MSH"];
            var msh214 = hl7v2Message["MSH"][21][4];
            var msh214fr1 = hl7v2Message["MSH"][21][4].GetFieldRepetition(1);
            var msh214fr2 = hl7v2Message["MSH"][21][4].GetFieldRepetition(2);
            var msh1 = hl7v2Message.Get("MSH.1");
            var msh2 = hl7v2Message.Get("MSH.2");
            var msh3 = hl7v2Message.Get("MSH.3");
            var msh4 = hl7v2Message.Get("MSH.4");
            var msh7 = hl7v2Message.Get("MSH.7");
            var msh8 = hl7v2Message.Get("MSH.8");
            var msh9 = hl7v2Message.Get("MSH.9");
            var msh91 = hl7v2Message.Get("MSH.9.1");
            var msh92 = hl7v2Message.Get("MSH.9.2");
            var obr = hl7v2Message["OBR"];
            var obr33test = hl7v2Message["OBR"][33];
            var obr331test = hl7v2Message["OBR"][33][1];
            var obr3311test = hl7v2Message["OBR"][33][1][1];
            var obr3312test = hl7v2Message["OBR"][33][1][2];
            var obr3313test = hl7v2Message["OBR"][33][1][3];
            var obr33 = hl7v2Message.Get("OBR.33");
            var obr331 = hl7v2Message.Get("OBR.33.1");
            var obr3311 = hl7v2Message.Get("OBR.33.1.1");
            var obr3312 = hl7v2Message.Get("OBR.33.1.2");
            var obr3313 = hl7v2Message.Get("OBR.33.1.3");

            var pid = hl7v2Message["PID"];
            var pid5 = hl7v2Message.Get("PID.5");
            var pid7 = hl7v2Message.Get("PID.7");

            var pv1 = hl7v2Message["PV1"];
            var pv131 = hl7v2Message.Get("PV1.3.1");

            var fieldComponent = (HL7V2FieldComponent)pv131;

            fieldComponent.AddFieldRepetition(expressionConfiguration.fieldRepetitionDelimiter, "TEST JOE");

            Console.WriteLine("Before:");

            foreach (var messageSegment in hl7v2Message.MessageSegments)
            {
                Console.WriteLine(messageSegment.ToString());
            }

            hl7v2Message.Rebuild();

            Console.WriteLine("Final Output:");

            foreach (var messageSegment in hl7v2Message.MessageSegments)
            {
                Console.WriteLine(messageSegment.ToString());
            }

            Console.Read();
        }
    }
}
