using ExpressionEvaluator.Models;
using ExpressionEvaluator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionEvaluator.Services
{
	/// <summary>
	/// Service class used publicly. Should not be created directly. Use ArithmeticController instead.
	/// </summary>
	public class ArithmeticService
	{
		private IEnumerable<string> Delimiters;
		private readonly IEnumerable<string> MathDelimiters = new [] { "+", "-", "*", "/", "%" };
		private readonly IEnumerable<string> BooleanDelimiters = new[] { "<=", ">=", "!=", "==", "&&", "||", "and", "or", ">", "<" };

		public ArithmeticService() { }

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
				string message = string.Format("Could not parse float for {0}.", str);
				Log.Error(message);
				throw new FormatException(message);
			}
			return result;
		}

		public int GetInt(string str)
		{
			int result;
			if (!int.TryParse(str, out result)) 
			{
				string message = string.Format("Could not parse int for {0}.", str);
				Log.Error(message);
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
				string message = string.Format("Operator not found for {0}.", op);
				Log.Error(message);
				throw new ArgumentException(message, "op");
			}
			
			return result;
		}

		public VarType UpdateVarType(VarType curExpType, VarType leftOperandType, VarType rightOperandType) 
		{
			if (curExpType == VarType.String)
			{
				return VarType.String;
			}
			else if (curExpType == VarType.Boolean)
			{
				return VarType.Boolean;
			}
			else if (curExpType == VarType.Float)
			{
				if (leftOperandType == VarType.String || rightOperandType == VarType.String)
				{
					return VarType.String;
				}
				else 
				{
					return VarType.Float;
				}
			}
			else if (curExpType == VarType.Int)
			{
				if (leftOperandType == VarType.Float || rightOperandType == VarType.Float)
				{
					return VarType.Float;
				}
				else if (leftOperandType == VarType.String || rightOperandType == VarType.String)
				{
					return VarType.String;
				}
				else
				{
					return VarType.Int;
				}
			}
			else if (curExpType == VarType.Null) 
			{
				if (leftOperandType == VarType.String || rightOperandType == VarType.String) 
				{
					return VarType.String;
				}
				else if (leftOperandType == VarType.Boolean || rightOperandType == VarType.Boolean) 
				{
					return VarType.Boolean;
				}
				else if (leftOperandType == VarType.Float || rightOperandType == VarType.Float) 
				{
					return VarType.Float;
				}
				else if (leftOperandType == VarType.Int || rightOperandType == VarType.Int) 
				{
					return VarType.Int;
				}
			}
			
			return curExpType;
		}

		public VarType GetVarType(string expression)
		{
			int tempInteger = 0; float tempFloat = 0.0f;

			if (int.TryParse(expression, out tempInteger))
			{
				return VarType.Int;
			}
			else if (float.TryParse(expression, out tempFloat))
			{
				return VarType.Float;
			}
			else if (expression[0] == '"' && expression[expression.Length-1] == '"')
			{
				return VarType.String;
			}
			else if (expression == "True" || expression == "False")
			{
				return VarType.Boolean;
			}
			else 
			{
				string message = string.Format("Variable Type not found for expression {0}.", expression);
				Log.Error(message);
				throw new ArgumentException(message, "expression");
			}
		}

		public string GetLeftBooleanOperand(string expression, int index) 
		{
			string leftHalf = expression.Substring(0, index);
			int start = int.MinValue;
			int dIndex = int.MinValue;
			for (int i = 0; i < Delimiters.Count(); i++) 
			{
				int selection = leftHalf.LastIndexOfOutsideQuotes(Delimiters.ElementAt(i));
				if (selection > start && selection != -1) 
				{
					start = selection;
					dIndex = i;
				}
			}

			if (start == int.MinValue)
			{
				start = 0;
			}
			else 
			{
				start += Delimiters.ElementAt(dIndex).Length;
			}

			if (index > leftHalf.Length) 
			{
				string message = string.Format("Couldn't get left operand for expression {0} using operand {1}.", leftHalf, expression[index]);
				Log.Error(message);
				throw new ArgumentException(message, "expression");
			}

			return leftHalf.Substring(start, index - start);
		}

		public string GetRightBooleanOperand(string expression, int index, int opLength) 
		{
			string rightHalf = expression.Substring(index + opLength);
			int end = int.MaxValue;
			for (int i = 0; i < Delimiters.Count(); i++) 
			{
				int selection = rightHalf.IndexOfOutsideQuotes(Delimiters.ElementAt(i));
				if (selection < end && selection != -1) 
				{
					end = selection;
				}
			}
			if (end == int.MaxValue) 
			{
				end = rightHalf.Length;
			}

			if (end > rightHalf.Length)
			{
				string message = string.Format("Couldn't get right operand for expression {0} using operand {1}.", rightHalf, expression[index]);
				Log.Error(message);
				throw new ArgumentException(message, "expression");
			}

			return rightHalf.Substring(0, end);
		}

		public bool CheckDelimiterForRight(int index, string delimiter, string expression) 
		{
			if (index > 0 && expression.Length > index + delimiter.Length)
			{
				var str = expression.Substring(index, delimiter.Length);
				return str == delimiter;
			}
			else 
			{
				return false;
			}
		}

		public string GetRightMathOperand(string expression, int index)
		{
			string result = "";
			int start = index + 1, opIndex = index + 1;
			if (expression[start] == '-') { start++; result += '-'; }
			for (int i = start; i < expression.Length; i++)
			{
				for (int j = 0; j < Delimiters.Count(); j++)
				{
					char delimStart = Delimiters.ElementAt(j)[0];
					if (expression[i] == delimStart)
					{
						if (CheckDelimiterForRight(i, Delimiters.ElementAt(j), expression)) 
						{
							if (i > expression.Length)
							{
								string message = string.Format("Couldn't get right operand for expression {0} using operand {1}.", expression, expression[index]);
								Log.Error(message);
								throw new ArgumentException(message, "expression");
							}
							return expression.Substring(opIndex, i - opIndex);
						}
					}
				}
			}
			if (result == "" || result == "-") { result = expression.Substring(opIndex); }

			return result;
		}

		public string GetRightStringOperand(string expression, int index)
		{
			string result = null;
			int start = index + 1, quoteCount = 0;
			char curQuote = char.MinValue;

			for (int i = start; i < expression.Length; i++)
			{
				if (Utility.CheckQuotes(expression, i, curQuote))
				{
					if (quoteCount == 0) { curQuote = expression[i]; }
					quoteCount++;
					if (quoteCount == 2)
					{
						if (i + 1 > expression.Length)
						{
							string message = string.Format("Couldn't get right operand for expression {0} using operand {1}.", expression, expression[index]);
							Log.Error(message);
							throw new ArgumentException(message, "expression");
						}
						result = expression.Substring(start, (i + 1) - start);
					}
				}
			}
			if (result == null) { result = expression.Substring(start); }
			return result.Trim();
		}

		public string GetLeftStringOperand(string expression, int index)
		{
			string result = null;
			int start = index - 1, quoteCount = 0;
			char curQuote = char.MinValue;
			for (int i = start; i >= 0; i--)
			{
				if (Utility.CheckQuotes(expression, i, curQuote))
				{
					curQuote = expression[i];
					quoteCount++;
					if (quoteCount == 2)
					{
						if (index > expression.Length)
						{
							string message = string.Format("Couldn't get right operand for expression {0} using operand {1}.", expression, expression[index]);
							Log.Error(message);
							throw new ArgumentException(message, "expression");
						}
						result = expression.Substring(i, index - i);
					}
				}
			}
			if (result == null) { result = expression.Substring(0, index); }

			return result.Trim();
		}

		public string GetLeftMathOperand(string expression, int index)
		{
			string result = "";
			int start = index - 1;
			for (int i = start; i >= 0; i--)
			{
				for (int j = 0; j < Delimiters.Count(); j++)
				{
					char delimEnd = Delimiters.ElementAt(j).Last();
					if (expression[i] == delimEnd)
					{
						if (CheckDelimiterForLeft(i, Delimiters.ElementAt(j), expression)) 
						{
							int startSubstringIndex = i + 1, substringLength = start - i;
							if (i != 0)
							{
								if (CheckDelimiter(expression[i - 1], Delimiters, expression, i - 1)) // the one after the negative is an operator
								{
									startSubstringIndex = i; // then include the negative, otherwise default to normal i + 1
									substringLength++;
								}
							}
							else if (i == 0 || expression[i] == '-')
							{
								startSubstringIndex = i;
								substringLength++;
							}

							if (substringLength > expression.Length - startSubstringIndex)
							{
								string message = string.Format("Couldn't get right operand for expression {0} using operand {1}.", expression, expression[index]);
								Log.Error(message);
								throw new ArgumentException(message, "expression");
							}

							return expression.Substring(startSubstringIndex, substringLength);
						}
					}
				}
			}
			if (result == "") { result = expression.Substring(0, index); }

			return result;
		}

		public string HandleImplicitNegative(string expression) { return expression.Replace("-(", ("-1*(")); }

		public string GetOuterMostParentheticalExpression(string expression, Func<string, ExpressionResult> action)
		{
			int start = expression.IndexOfOutsideQuotes('(') + 1; int length = GetParentheticalLength(expression); // always default to non same level
			if (length > expression.Length || start == 0) 
			{
				string message = string.Format("Couldn't get parenthetical expression for {0}.", expression);
				Log.Error(message);
				throw new ArgumentException(message, "expression");
			}
			string outer = expression.Substring(start, length - start);
			return expression.ReplaceFirst("(" + outer + ")", action(outer).Value);
		}

		public int GetCharCount(string original, char ch)
		{
			int result = 0;
			bool inQuote = false;
			char curQuote = char.MinValue;

			for (int i = 0; i < original.Length; i++)
			{
				if (Utility.CheckQuotes(original, i, curQuote))
				{
					curQuote = original[i];
					inQuote = !inQuote;
					if (!inQuote) { curQuote = char.MinValue; }
					if (curQuote == ch) { result++; }
				}
				if (!inQuote)
				{
					if (original[i] == ch)
					{
						result++;
					}
				}
			}

			return result;
		}

		public int GetParentheticalLength(string str)
		{
			int result = 0, leftCount = 0;
			char curQuote = char.MinValue;
			bool inQuote = false;
			for (int i = 0; i < str.Length; i++)
			{
				if (Utility.CheckQuotes(str, i, curQuote))
				{
					curQuote = str[i];
					inQuote = !inQuote;
				}
				if (!inQuote)
				{
					if (str[i] == '(') { leftCount++; }
					else if (str[i] == ')')
					{
						leftCount--;
						if (leftCount == 0)
						{
							result = i;
							break;
						}

					}
				}
			}
			return result;
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
					string message = string.Format("Couldn't find operand for expression {0}.", expression);
					Log.Error(message);
					throw new ArgumentException(message, "expression");
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

		public ArithmeticGroup GetOperandTypes(string expression, int opIndex)
		{
			var leftType = ArithmeticType.None;
			var rightType = ArithmeticType.None;
			var expType = ArithmeticType.None;

			if (expression[opIndex - 1] == '"')
			{
				leftType = ArithmeticType.String;
			}
			else
			{
				leftType = ArithmeticType.Math;
			}

			if (expression[opIndex + 1] == '"')
			{
				rightType = ArithmeticType.String;
			}
			else
			{
				rightType = ArithmeticType.Math;
			}

			if (leftType == ArithmeticType.String || rightType == ArithmeticType.String)
			{
				expType = ArithmeticType.String;
			}
			else if(leftType == ArithmeticType.Math && rightType == ArithmeticType.Math)
			{
				expType = ArithmeticType.Math;
			}

			if (leftType == ArithmeticType.None) 
			{
				string message = string.Format("Couldn't find Arithmetic Type for left operand for expression {0}.", expression);
				Log.Error(message);
				throw new ArgumentException(message, "expression");
			}
			else if (rightType == ArithmeticType.None) 
			{
				string message = string.Format("Couldn't find Arithmetic Type for right operand for expression {0}.", expression);
				Log.Error(message);
				throw new ArgumentException(message, "expression");
			}
			else if (expType == ArithmeticType.None) 
			{
				string message = string.Format("Couldn't find Arithmetic Type for expression {0}.", expression);
				Log.Error(message);
				throw new ArgumentException(message, "expression");
			}

			var arGroup = new ArithmeticGroup
			{
				LeftType = leftType,
				RightType = rightType,
				ExpressionType = expType,
			};

			return arGroup;
		}

		public static string GetOperator(Operator op)
		{
			switch (op)
			{
				case Operator.Addition:
					return "+";
				case Operator.Division:
					return "/";
				case Operator.Modulus:
					return "%";
				case Operator.Multiplication:
					return "*";
				case Operator.Subtraction:
					return "-";
				case Operator.LessThan:
					return "<";
				case Operator.LessThanOrEqualTo:
					return "<=";
				case Operator.GreaterThan:
					return ">";
				case Operator.GreaterThanOrEqualTo:
					return ">=";
				case Operator.NotEqualTo:
					return "!=";
				case Operator.EqualTo:
					return "==";
				case Operator.And:
					return "&&";
				case Operator.Or:
					return "||";
				default:
					return null;
			}
		}

		private bool CheckDelimiter(char ch, IEnumerable<string> delimiters, string expression, int opIndex)
		{
			bool result = false;
			for (int i = 0; i < Delimiters.Count(); i++)
			{
				char delimEnd = delimiters.ElementAt(i).Last();
				if (ch == delimEnd)
				{
					if (CheckDelimiterForLeft(opIndex, delimiters.ElementAt(i), expression))
					{
						result = true;
						break;
					}
				}
			}

			return result;
		}

		private bool CheckDelimiterForLeft(int index, string delimiter, string expression)
		{
			int start = index - (delimiter.Length - 1);
			if (start >= 0 && expression.Length > start + delimiter.Length)
			{
				string result = expression.Substring(start, delimiter.Length);
				return result == delimiter;
			}
			else
			{
				return false;
			}
		}

	}
}