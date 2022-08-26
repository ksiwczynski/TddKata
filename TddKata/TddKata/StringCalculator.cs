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

			if (vals.Length == 1)
			{
				return Int32.Parse(vals[0]);
			}

			return Int32.Parse(vals[0]) + Int32.Parse(vals[1]);
		}
	}
}
