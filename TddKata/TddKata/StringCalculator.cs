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
			if (String.IsNullOrWhiteSpace(v))
			{
				return 0;
			}

			string[] vals = v.Split(",", StringSplitOptions.RemoveEmptyEntries);

			int result = 0;

			foreach (string s in vals)
			{
				result += Int32.Parse(s);
			}

			return result;
		}
	}
}
