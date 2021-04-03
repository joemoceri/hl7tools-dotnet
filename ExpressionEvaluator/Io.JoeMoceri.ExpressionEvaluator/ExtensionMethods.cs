using System.Text;

namespace ExpressionEvaluator
{
	public static class ExtensionMethods
	{
		public static bool CheckQuotes(this string line, int index, char curQuote)
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


		public static string ReplaceFirst(this string text, string search, string replace)
		{
			if (search == null || replace == null || text == null) 
			{
				return text;
			}
			int pos = text.IndexOf(search);
			if (pos < 0)
			{
				return text;
			}
			return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
		}

		public static int IndexOfOutsideQuotes(this string str, char ch, int startIndex = 0) 
		{
			int result = -1;
			bool inQuote = false;
			char curQuote = char.MinValue;

			for (int i = startIndex; i < str.Length; i++) 
			{
				if (str.CheckQuotes(i, curQuote))
				{
					curQuote = str[i];
					inQuote = !inQuote;
					if (!inQuote) { curQuote = char.MinValue; }
				}
				if(!inQuote)
				{
					if (str[i] == ch) 
					{
						result = i;
						break;
					}
				}
			}

			return result;
		}

		public static int IndexOfOutsideQuotes(this string str, string search, int startIndex = 0) 
		{
			int result = -1, searchIndex = 0;
			bool inQuote = false;
			char curQuote = char.MinValue;

			for (int i = startIndex; i < str.Length; i++)
			{
				if (str.CheckQuotes(i, curQuote))
				{
					curQuote = str[i];
					inQuote = !inQuote;
					searchIndex = 0;
					if (!inQuote) { curQuote = char.MinValue; }
				}
				if (!inQuote)
				{
					if (str[i] == search[searchIndex])
					{
						if (searchIndex == search.Length - 1) 
						{
							result = i - (search.Length - 1);
							break;
						}
						searchIndex++;
					}
					else 
					{
						searchIndex = 0;
					}
				}
			}

			return result;
		}

		public static int LastIndexOfOutsideQuotes(this string str, string search, int startIndex = 0) 
		{
			int result = -1, searchIndex = search.Length - 1;
			bool inQuote = false;
			char curQuote = char.MinValue;

			for (int i = str.Length - 1; i >= startIndex; i--)
			{
				if (str.CheckQuotes(i, curQuote))
				{
					curQuote = str[i];
					inQuote = !inQuote;
					searchIndex = 0;
					if (!inQuote) { curQuote = char.MinValue; }
				}
				if (!inQuote)
				{
					if (str[i] == search[searchIndex])
					{
						if (searchIndex == 0)
						{
							result = i;
							break;
						}
						searchIndex--;
					}
					else
					{
						searchIndex = search.Length - 1;
					}
				}
			}

			return result;
		}
	}
}