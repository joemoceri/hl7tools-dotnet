using System;

namespace HL7Tools.Validation
{
    public class App
    {
        public void ValidateV23DFTP03TriggerEvent()
        {
            var expressionConfiguration = new HL7V2ExpressionConfiguration();

            var evaluator = new Evaluator(expressionConfiguration);

            var message = evaluator.EvaluateHL7V2File("DFT-P03 Charge.txt");

            var caristixService = new CaristixService(true);

            var validationResult = caristixService.ValidateTriggerEvent(message, HL7V23TriggerEventId.DFT_P03);

            Console.Write($"Valid: {validationResult.Valid}");

            return;
        }

        public void Run()
        {
            ValidateV23DFTP03TriggerEvent();
        }
    }
}
