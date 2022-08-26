using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKata
{
	public class StringCalculator
	{
		public int Add(string inputValue)
		{
			string delimeter = ",";
			List<int> negativeNums = new List<int>();
			List<string> custDelimeters = new List<string> { "\n" };

			if (String.IsNullOrWhiteSpace(inputValue))
			{
				return 0;
			}

			if (inputValue.StartsWith("//"))
			{
				if (inputValue.Contains('['))
				{
					string[] delims = inputValue.Substring(inputValue.IndexOf("[") + 1, inputValue.LastIndexOf("]") - inputValue.IndexOf("[") - 1).Split("][", StringSplitOptions.RemoveEmptyEntries);
					foreach (string d in delims)
					{
						custDelimeters.Add(d);
					}
				}
				else
				{
					delimeter = inputValue.Substring(2, 1);
				}
				inputValue = inputValue.Substring(inputValue.IndexOf("\n") + 1);
			}

			foreach (string d in custDelimeters)
			{
				inputValue = inputValue.Replace(d, delimeter);
			}

			string[] vals = inputValue.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

			int result = 0;

			foreach (string s in vals)
			{
				int p = Int32.Parse(s);
				if (p < 0)
				{
					negativeNums.Add(p);
				}
				if (p <= 1000)
				{
					result += p;
				}
			}

			if (negativeNums.Any())
			{
				throw new ArgumentOutOfRangeException("negatives not allowed. negative nums: " + String.Join(",", negativeNums));
			}

			return result;
		}
	}
}
