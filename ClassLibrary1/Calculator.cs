using System;

namespace ClassLibrary2Tests
{
    public class Calculator
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public Parser parser = new Parser();
 
        public Calculator(string value1, string value2)
        {
            if ((parser.Validator(value1)) && (parser.Validator(value2)))
            {
            Value1 = Convert.ToDouble(value1);
            Value2 = Convert.ToDouble(value2);
            }
        }

        public double Add()
        {
            return Value1 + Value2;
        }
        public double Subsctarct()
        {
            return Value1 - Value2;
        }

        public double Divide()
        {
            if (Value2 != 0)
            {
                return (Value1 / Value2);
            }
            else
            {
                return 0;
            }                   
        }

        public double Multiply()
        {
            return Value1 * Value2;
        }

    
    }
}
