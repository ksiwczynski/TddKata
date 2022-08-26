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
				result += Int32.Parse(s);
			}

			return result;
		}
	}
}
