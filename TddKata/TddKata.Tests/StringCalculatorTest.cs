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

		[Test]
		public void AddFiveNumbersTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add("3,4,6,5,7"), Is.EqualTo(25));
		}

		[Test]
		public void AddNineNumbersTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add("1,2,3,4,5,6,7,8,9"), Is.EqualTo(45));
		}

		[Test]
		public void AddNumbersWithNewLineTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add("1\n2,3"), Is.EqualTo(6));
		}

		[Test]
		public void AddNumbersWithCustomDelimeterTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add("//;\n1;2"), Is.EqualTo(3));
		}

		[Test]
		public void AddNegativeNumbersTest()
		{
			var calc = new StringCalculator();
			Assert.That(() => calc.Add("-1,2"), Throws.TypeOf<Exception>().With.Message.Contains("negatives not allowed"));
		}

		[Test]
		public void AddTwoBigNumbersTest()
		{
			var calc = new StringCalculator();
			Assert.That(calc.Add("1002,2"), Is.EqualTo(2));
		}
	}
}
