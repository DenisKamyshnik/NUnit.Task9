using NUnit.Framework;
using NInit.Task9;


namespace NUnit.Task9.Tests
{
    class CalculatorTest
    {
       [Test]
        public void TestAddFunction()
        {
            string value1 = "11";
            string value2 = "22";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);
                             
            Assert.AreEqual(values.Value1 + values.Value2, calculator.Add());
        }
      [Test]
        public void TestAddFunctionWithString()
        {
            string value1 = "11";
            string value2 = "a";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.AreEqual(values.Value1 + values.Value2 + 1, calculator.Add());
        }

        [Test]
        public void TestSubsctarctFunction()
        {
            string value1 = "11";
            string value2 = "22";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.AreEqual(values.Value1 - values.Value2, calculator.Subsctarct());
        }
        [Test]
        public void TestSubsctarctFunctionWithString()
        {
            string value1 = "a";
            string value2 = "22";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.AreEqual(values.Value1 - values.Value2, calculator.Subsctarct());
        }
        [Test]
        public void TestDivideFunction()
        {
            string value1 = "10";
            string value2 = "-5";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.AreEqual(values.Value1 / values.Value2, calculator.Divide());
        }

        [Test]
        public void TestDivideFunctionWithNull()
        {
            string value1 = "-7";
            string value2 = null;
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.IsNotNull(calculator.Divide());
        }

        [Test]
        public void TestDivideFunctionWithZero()
        {
            string value1 = "7";
            string value2 = "0";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.IsNaN(calculator.Divide());
        }

        [Test]
          public void TestMultiplyFunction()
          {
             string value1 = "11";
             string value2 = "22";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.AreEqual(values.Value1 * values.Value2 * 0, calculator.Multiply());
          }
        [Test]
        public void TestMultiplyFunctionWithString()
        {
            string value1 = "a";
            string value2 = " ";
            var values = new ValuesAndValidation();
            values.SetValue1(value1);
            values.SetValue2(value2);
            var calculator = new Calculator(values.Value1, values.Value2);

            Assert.AreEqual(values.Value1 * values.Value2, calculator.Multiply());
        }
    }
}


