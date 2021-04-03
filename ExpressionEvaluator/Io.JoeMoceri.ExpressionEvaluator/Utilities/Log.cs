using System;
using System.IO;

namespace ExpressionEvaluator.Utilities
{
	/// <summary>
	/// Used for logging errors. Can be turned on. Default is off.
	/// </summary>
	public static class Log
	{
		/// <summary>
		/// Set this to true if you want logging. Default is false.
		/// </summary>
		public static bool Logging = false;

		public static void Error(string message) 
		{
			if (Logging) 
			{
				using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "ArithmeticErrorLog.txt", true))
				{
					string log = "(" + DateTime.Now + ")" + "Error Message:" + message;
					writer.WriteLine(log);
				}
			}
		}
	}
}
