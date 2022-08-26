using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKata
{
	public class StringCalculator
	{
		public int Add(string v)
		{
			string delimeter = ",";
			List<int> negativeNums = new List<int>();

			if (String.IsNullOrWhiteSpace(v))
			{
				return 0;
			}

			if (v.StartsWith("//"))
			{
				delimeter = v.Substring(2, 1);
				v = v.Substring(4);
			}

			v = v.Replace("\n", delimeter);

			string[] vals = v.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

			int result = 0;

			foreach (string s in vals)
			{
				int p = Int32.Parse(s);
				if (p < 0)
				{
					negativeNums.Add(p);
				}
				result += p;
			}

			if (negativeNums.Any())
			{
				throw new Exception("negatives not allowed. negative nums: " + String.Join(",", negativeNums));
			}

			return result;
		}
	}
}
