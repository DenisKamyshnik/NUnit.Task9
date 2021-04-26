using System;

namespace NInit.Task9
{
    public class ValuesAndValidation
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double[] Array { get; set; }
        public bool Parser(string value)
        {
            double dValue;
            return Double.TryParse(value, out dValue);
        }
        public double SetValue1(string value1)
        {
            if (Parser(value1))
            {
               return Value1 = Convert.ToDouble(value1);
            }
            else
            {
                return 0;
            }       
        }
        public double SetValue2(string value2)
        {          
            if (Parser(value2))
            {
                return Value2 = Convert.ToDouble(value2);
            }
            else
            {
                return 0;
            }
        }
       
    }
}
