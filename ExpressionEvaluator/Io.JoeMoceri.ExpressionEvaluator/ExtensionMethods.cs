using System.Text;

namespace ExpressionEvaluator
{
	public static class ExtensionMethods
	{

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

		public static string RemoveWhitespaceOutsideQuotes(this string str) 
		{
			StringBuilder result = new StringBuilder();
			bool inQuote = false;
			int start = 0, length = 0;
			char curQuote = char.MinValue;

			for (int i = 0; i < str.Length; i++) 
			{
				if (Utility.CheckQuotes(str, i, curQuote)) 
				{
					curQuote = str[i];
					if (!inQuote)
					{
						start = i; length = 0;
					}
					else 
					{
						length = (i + 1) - start; // + 1 to get the extra quote
						string temp = str.Substring(start, length);
						result.Append(temp);
						curQuote = char.MinValue;
					}
					inQuote = !inQuote;
				}
				else if (str[i] != ' ' && !inQuote) 
				{
					result.Append(str[i]);
				}			

			}

			return result.ToString();
		}

		public static int IndexOfOutsideQuotes(this string str, char ch, int startIndex = 0) 
		{
			int result = -1;
			bool inQuote = false;
			char curQuote = char.MinValue;

			for (int i = startIndex; i < str.Length; i++) 
			{
				if (Utility.CheckQuotes(str, i, curQuote)) 
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
				if (Utility.CheckQuotes(str, i, curQuote))
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
				if (Utility.CheckQuotes(str, i, curQuote))
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