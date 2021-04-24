using NUnit.Framework;


namespace ClassLibrary2Tests
{
    class CalculatorTest
    {
       [Test]
        public void TestAddFunction()
        {
            string value1 = "11";
            string value2 = "22";
            var page = new Calculator(value1, value2);

            Assert.AreEqual(page.Value1 + page.Value2, page.Add());
        }
        [Test]
        public void TestAddFunctionWithString()
        {
            string value1 = "11";
            string value2 = "a";
            var page = new Calculator(value1, value2);

            Assert.AreEqual(page.Value1 + page.Value2 + 1, page.Add());
        }

        [Test]
        public void TestSubsctarctFunction()
        {
            string value1 = "11";
            string value2 = "22";
            var page = new Calculator(value1, value2);

            Assert.AreEqual(page.Value1 - page.Value2, page.Subsctarct());
        }
        [Test]
        public void TestSubsctarctFunctionWithString()
        {
            string value1 = "a";
            string value2 = "22";
            var page = new Calculator(value1, value2);

            Assert.AreEqual(page.Value1 - page.Value2, page.Subsctarct());
        }
        [Test]
        public void TestDivideFunction()
        {
            string value1 = "10";
            string value2 = "-5";
            var page = new Calculator(value1, value2);

            Assert.AreEqual(page.Value1 / page.Value2, page.Divide());
        }

        [Test]
        public void TestDivideFunctionWithNull()
        {
            string value1 = "-7";
            string value2 = null;
            var page = new Calculator(value1, value2);
            Assert.IsNotNull(page.Divide());
        }
        [Test]
        public void TestDivideFunctionWitZero()
        {
            string value1 = "-7";
            string value2 = "0";
            var page = new Calculator(value1, value2);
            Assert.AreEqual(0, page.Divide());
        }

        [Test]
          public void TestMultiplyFunction()
          {
              string value1 = "11";
              string value2 = "22";
              var page = new Calculator(value1, value2);

              Assert.AreEqual(page.Value1 * page.Value2 * 0, page.Multiply());
          }
        [Test]
        public void TestMultiplyFunctionWithString()
        {
            string value1 = "a";
            string value2 = " ";
            var page = new Calculator(value1, value2);

            Assert.AreEqual(page.Value1 * page.Value2, page.Multiply());
        }
    }
}


