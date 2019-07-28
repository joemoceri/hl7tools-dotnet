namespace ExpressionEvaluator.Utilities
{
	public static class Utility
	{
		public static bool CheckQuotes(string line, int index, char curQuote)
		{
			bool result = false;
			char ch = line[index];
			char pChar = index - 1 >= 0 ? line[index - 1] : char.MinValue;
			if (pChar == '\\')
			{
				result = false; // skip over escaped quotes
			}
			else if (curQuote == char.MinValue) 
			{
				result = ch == '"'; // default
			}
			else 
			{
				result = ch == curQuote; // otherwise a chosen curQuote
			}
			return result;
		}
	}
}
