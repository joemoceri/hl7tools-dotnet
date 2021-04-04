using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionEvaluator
{
    public interface IArithmetic
    {
        OperatorGroup GetFirstSelection(string expression, IEnumerable<string> delimiters);
        float GetFloat(string str);
        int GetInt(string str);
        Operator GetOperator(string op);
        VarType GetVarType(string expression);
        void SetDelimiterRange(DelimiterOperandType type);
        IEnumerable<string> GetMathDelimiters();
        IEnumerable<string> GetBooleanDelimiters();
    }

    /// <summary>
    /// Service class used publicly. Should not be created directly. Use ArithmeticController instead.
    /// </summary>
    public class Arithmetic : IArithmetic
    {
        private IEnumerable<string> Delimiters;
        public readonly IEnumerable<string> MathDelimiters = new[] { "+", "-", "*", "/", "%" };
        public readonly IEnumerable<string> BooleanDelimiters = new[] { "<=", ">=", "!=", "==", "&&", "||", "and", "or", ">", "<" };

        public void SetDelimiterRange(DelimiterOperandType type)
        {
            if (type == DelimiterOperandType.Boolean)
            {
                Delimiters = BooleanDelimiters;
            }
            else if (type == DelimiterOperandType.Math)
            {
                Delimiters = MathDelimiters;
            }
            else if (type == DelimiterOperandType.All)
            {
                MathDelimiters.Concat(BooleanDelimiters).ToArray();
            }
        }

        public float GetFloat(string str)
        {
            float result;
            if (!float.TryParse(str, out result))
            {
                var message = $"Could not parse float for {str}.";
                throw new FormatException(message);
            }
            return result;
        }

        public int GetInt(string str)
        {
            int result;
            if (!int.TryParse(str, out result))
            {
                var message = $"Could not parse int for {str}.";
                throw new FormatException(message);
            }
            return result;
        }

        public Operator GetOperator(string op)
        {
            Operator result = Operator.Null;
            switch (op)
            {
                case "+":
                    result = Operator.Addition;
                    break;
                case "-":
                    result = Operator.Subtraction;
                    break;
                case "*":
                    result = Operator.Multiplication;
                    break;
                case "/":
                    result = Operator.Division;
                    break;
                case "%":
                    result = Operator.Modulus;
                    break;
                case "<":
                    result = Operator.LessThan;
                    break;
                case "<=":
                    result = Operator.LessThanOrEqualTo;
                    break;
                case ">":
                    result = Operator.GreaterThan;
                    break;
                case ">=":
                    result = Operator.GreaterThanOrEqualTo;
                    break;
                case "!=":
                    result = Operator.NotEqualTo;
                    break;
                case "==":
                    result = Operator.EqualTo;
                    break;
                case "&&":
                    result = Operator.And;
                    break;
                case "||":
                    result = Operator.Or;
                    break;
                case "and":
                    result = Operator.And;
                    break;
                case "or":
                    result = Operator.Or;
                    break;
            }
            if (result == Operator.Null)
            {
                var message = $"Operator not found for {op}.";
                throw new ArgumentException(message, nameof(op));
            }

            return result;
        }

        public VarType GetVarType(string expression)
        {
            if (int.TryParse(expression, out int tempInteger))
            {
                return VarType.Int;
            }
            else if (float.TryParse(expression, out float tempFloat))
            {
                return VarType.Float;
            }
            else if (expression[0] == '"' && expression[expression.Length - 1] == '"')
            {
                return VarType.String;
            }
            else if (expression == "True" || expression == "False")
            {
                return VarType.Boolean;
            }
            else
            {
                var message = $"Variable Type not found for expression {expression}.";
                throw new ArgumentException(message, nameof(expression));
            }
        }

        public OperatorGroup GetFirstSelection(string expression, IEnumerable<string> delimiters)
        {
            string result = null;
            int min = int.MaxValue, index = int.MinValue;
            bool isNegative = false;

            if (expression[0] == '-')
            {
                if (expression.Length < 2)
                {
                    var message = $"Couldn't find operand for expression {expression}.";
                    throw new ArgumentException(message, nameof(expression));
                }
                expression = expression.Substring(1); isNegative = true;
            }

            for (int i = 0; i < delimiters.Count(); i++)
            {
                int selection = expression.IndexOfOutsideQuotes(delimiters.ElementAt(i));
                if (selection == -1) { continue; }
                if (min > selection)
                {
                    min = selection;
                    result = delimiters.ElementAt(i).ToString();
                    index = isNegative ? selection + 1 : selection;
                }
            }

            var opGroup = new OperatorGroup { Value = result, Location = index };

            return opGroup;
        }

        public IEnumerable<string> GetMathDelimiters()
        {
            return MathDelimiters;
        }

        public IEnumerable<string> GetBooleanDelimiters()
        {
            return BooleanDelimiters;
        }
    }
}