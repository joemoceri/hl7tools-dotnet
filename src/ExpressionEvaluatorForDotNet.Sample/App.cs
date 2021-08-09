using Newtonsoft.Json;
using System;
using System.IO;

namespace ExpressionEvaluatorForDotNet.Sample
{
    public class App
    {
        public void Run()
        {
            //SolveStringExample();

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

        public void SolveStringExample()
        {
            var evaluator = new Evaluator();

            var r = "\" ab + " + " cd \"";
            var expression = " \" ab + \" + \" cd \"";

            var result = evaluator.Evaluate(expression);

            Console.WriteLine($"{r} = {result}");
        }

        public void SolveBooleanExample()
        {
            var evaluator = new Evaluator();

            var r = 1 > 2 && (3 + 4) / 2 == 5;

            var result = evaluator.Evaluate("1 > 2 && (3 + 4) / 2 == 5");

            Console.WriteLine($"{r} = {result}");
        }

        public void ParseHL7FileExample()
        {
            // one liner
            //var hl7v2Message = new Evaluator(new HL7V2ExpressionConfiguration()).EvaluateHL7V2File("HL7File.txt");

            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var message = evaluator.EvaluateHL7V2File("HL7File.txt");

            var v23 = message.AsV23();

            //Console.WriteLine(v23.msh.ApplicationAcknowledgementType.Value);

            var adta01 = v23.GetADT_A01();

            var url = "https://test.com/test?id=1&test=2";

            var newUrl = expressionConfiguration.EncodeString(url);

            Console.WriteLine("Before:");

            Console.WriteLine(message.ToString());

            var obrMessageSegment = message.AddMessageSegment("OBR");

            for (var i = 1; i <= 53; i++)
            {
                var result = string.Empty;
                if (i % 2 == 0)
                {
                    result = "1";
                }
                else if (i % 3 == 0)
                {
                    result = "2";
                }

                obrMessageSegment.AddField(result);
            }

            obrMessageSegment = message.AddMessageSegment("OBR");

            for (var i = 1; i <= 53; i++)
            {
                var result = string.Empty;
                if (i % 2 == 0)
                {
                    result = "3";
                }
                else if (i % 3 == 0)
                {
                    result = "4";
                }

                var field = obrMessageSegment.AddField(result);

                if (i % 2 == 0 && i < 15)
                {
                    field.AddFieldRepetition("5");

                    var component = field.AddComponent("test_comp");

                    component.AddSubComponent("sub_1");
                    component.AddSubComponent("sub_2");
                    component.AddSubComponent("sub_3");
                }
                else if (i % 3 == 0)
                {
                    field.AddFieldRepetition("6");
                }
            }

            //Get("OBR(1).2") // gets the 1st OBR repetition's 2nd field
            var obrr12 = message.Get("OBR(1).2");

            var obrr12test = message["OBR", 0][2];

            //Get("OBR(2).3") // gets the 2nd OBR repetition's 3rd field
            var obrr23 = message.Get("OBR(2).3");

            var obrr23test = message["OBR", 1][3];

            //Get("GT1.6(2)") // gets the 1st GT1 repetition's 6th field's 2nd repetition
            var gt162 = message.Get("GT1.6(2)");

            var gt162test = message["GT1"][6].GetFieldRepetition(2);

            Console.WriteLine(gt162test.Value);
            Console.WriteLine(gt162.Value);

            message.Rebuild();

            Console.WriteLine("Final Output:");

            Console.WriteLine(message.ToString());

            Console.Read();
        }
    }
}
