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
			List<string> custDelimeters = new List<string>();

			if (String.IsNullOrWhiteSpace(v))
			{
				return 0;
			}

			if (v.StartsWith("//"))
			{
				if (v.Contains("["))
				{
					if (v.Count(x => x == '[') > 1)
					{
						string[] delims = v.Substring(v.IndexOf("[") + 1, v.LastIndexOf("]") - v.IndexOf("[") - 1).Split("][", StringSplitOptions.RemoveEmptyEntries);
						foreach (string d in delims)
						{
							custDelimeters.Add(d);
						}
					}
					else
					{
						delimeter = v.Substring(v.IndexOf("[") + 1, v.IndexOf("]") - v.IndexOf("[") - 1);
					}
				}
				else
				{
					delimeter = v.Substring(2, 1);
				}
				v = v.Substring(v.IndexOf("\n") + 1);
			}

			v = v.Replace("\n", delimeter);
			foreach (string d in custDelimeters)
			{
				v = v.Replace(d, delimeter);
			}

			string[] vals = v.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

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
				throw new Exception("negatives not allowed. negative nums: " + String.Join(",", negativeNums));
			}

			return result;
		}
	}
}
