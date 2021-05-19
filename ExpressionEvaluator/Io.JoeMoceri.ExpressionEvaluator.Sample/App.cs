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

            var languageTemplate = new HL7V2LanguageTemplate();

            var evaluator = new Evaluator(languageTemplate);

            var messageSegments = new List<HL7V2MessageSegment>();

            foreach (var line in lines)
            {
                evaluator.Evaluate(line);

                var messageSegment = languageTemplate.GetHL7V2MessageSegment();

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
