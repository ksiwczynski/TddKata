using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKata.Tests
{
	public class StringCalculatorTest
	{
		[Test]
		public void AddEmptyStringTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add(""), Is.EqualTo(0));
		}

		[Test]
		public void AddSingleNumberTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add("1"), Is.EqualTo(1));
		}

		[Test]
		public void AddTwoNumbersTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add("1,2"), Is.EqualTo(3));
		}
	}
}
