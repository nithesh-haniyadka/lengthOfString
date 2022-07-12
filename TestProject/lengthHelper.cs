// C# program to illustrate
// the use of Console.ReadLine()
using System;
using System.IO;



namespace findLengthOftheString
{
	public class LengthHelper
	{
		public static int findLength(string str)
		{
			int l = 0;

			foreach (char chr in str)
			{
				l += 1;
			}
			return l;

		}

		// Main Method
		public static void Main()
		{
			string str;
			int l = 0;
			Console.WriteLine("Enter the string :");
			str = Console.ReadLine();
			l = findLength(str);

			Console.Write("Length of the string is : {0}\n\n", l);


		}
	}

}