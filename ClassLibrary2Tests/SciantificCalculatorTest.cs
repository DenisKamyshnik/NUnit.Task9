using NUnit.Framework;
using NInit.Task9;
using System;

namespace NUnit.Task9.Tests
{
    public class SciantificCalculatorTest
    {
        [Test]
        public void TestPowFunction()
        {
            string value1 = "11";
            string value2 = "22";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new ScientificCalculator(values.Value1, values.Value2);

            Assert.AreEqual(Math.Pow(values.Value1, values.Value2), calculator.Pow());
        }

        [Test]
        public void TestPowWithZeroFunction()
        {
            string value1 = "0";
            string value2 = "a";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new ScientificCalculator(values.Value1, values.Value2);

            Assert.AreEqual(1, calculator.Pow());
        }

        [Test]
        public void TestPowWithStringFunction()
        {
            string value1 = "/_";
            string value2 = "a";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new ScientificCalculator(values.Value1, values.Value2);

            Assert.AreEqual(1, calculator.Pow());
        }

        [Test]
        public void TestModFunction()
        {
            string value1 = "5";
            string value2 = "24,74";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new ScientificCalculator(values.Value1, values.Value2);

            Assert.AreEqual(values.Value1 % values.Value2, calculator.Mod());
        }
        [Test]
        public void TestModWithStringFunction()
        {
            string value1 = "5";
            string value2 = "a";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new ScientificCalculator(values.Value1, values.Value2);

            Assert.IsNaN(calculator.Mod());
        }
        [Test]
        public void TestSqrtFunction()
        {
            string value1 = "5";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            var calculator = new ScientificCalculator(values.Value1, values.Value2);

            Assert.AreEqual(Math.Sqrt(values.Value1), calculator.Sqrt());
        }
        [Test]
        public void TestSqrtWithStringFunction()
        {
            string value1 = "a";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            var calculator = new ScientificCalculator(values.Value1, values.Value2);

            Assert.AreEqual(0, calculator.Sqrt());
        }

        [Test]
        public void TestMinInArr()
        {
            double[] valuesArr = new double[4] { 4, 1, 3, -5 };
            var calculator = new ScientificCalculator(valuesArr);

            Assert.Negative(calculator.MinInArr());
        }
        [Test]
        public void TestMaxInArr()
        {
            double[] valuesArr = new double[4] { 4, 1, 3, 5 };
            var calculator = new ScientificCalculator(valuesArr);

            Assert.AreEqual(5, calculator.MaxInArr());
        }
        [Test]
        public void TestSumInArr()
        {
            double[] valuesArr = new double[4] { 4, 1, 3, 5 };
            var calculator = new ScientificCalculator(valuesArr);

            Assert.AreEqual(13, calculator.SumInArr());
        }
    }
}
