using Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate;
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

            Console.ReadLine();
        }

        public void ParseHL7FileExample()
        {
            var lines = File.ReadLines("HL7File.txt");

            var languageTemplate = new HL7ExpressionsLanguageTemplate();

            var evaluator = new Evaluator(languageTemplate);

            var results = new List<HL7Result>();

            foreach (var line in lines)
            {
                evaluator.Evaluate(line);

                var hl7Result = languageTemplate.GetHL7Result();

                Console.WriteLine(hl7Result.ToString());

                results.Add(hl7Result);
            }

            Console.WriteLine("Final Output:");

            foreach (var result in results)
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
