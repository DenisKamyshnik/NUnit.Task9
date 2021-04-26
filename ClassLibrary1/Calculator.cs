
namespace NInit.Task9
{
    public class Calculator
    {

        public ValuesAndValidation values = new ValuesAndValidation();

         public Calculator(double value1, double value2)
        {
            values.Value1 = value1;
            values.Value2 = value2;
        }
   
        public double Add()
        {
            return values.Value1 + values.Value2;
        }
        public double Subsctarct()
        {
            return values.Value1 - values.Value2;
        }

        public double Divide()
        {
            if (values.Value2 != 0)
            {
                return (values.Value1 / values.Value2);
            }
            else
            {
                return double.NaN;
            }                   
        }

        public double Multiply()
        {
            return values.Value1 * values.Value2;
        }

    
    }
}
