using System;


namespace NInit.Task9
{
    public class ScientificCalculator
    {
        public ValuesAndValidation values = new ValuesAndValidation();
        public ScientificCalculator(double value1, double value2)
        {
            values.Value1 = value1;
            values.Value2 = value2;
        }
       
        public ScientificCalculator(double[] arr)
        {
            values.Array = arr;
        }

        public double Pow()
        {
            return Math.Pow(values.Value1, values.Value2);
        }

        public double Mod()
        {
            return values.Value1 % values.Value2;
        }

        public double Sqrt()
        {
            return Math.Sqrt(values.Value1);
        }

        public double MinInArr()
        {
            double min = values.Array[0];
            for (int i = 0; i < values.Array.Length; i++)
            {
                if (min > values.Array[i])
                {
                    min = values.Array[i];
                }
            }
            return min;
        }

        public double MaxInArr()
        {
            double max = values.Array[0];
            for (int i = 0; i < values.Array.Length; i++)
            {
                if (max < values.Array[i])
                {
                    max = values.Array[i];
                }
            }
            return max;
        }

        public double SumInArr()
        {
            double sum = 0;
            for (int i = 0; i < values.Array.Length; i++)
            {
                sum = values.Array[i] + sum;
            }
            return sum;
        }

    }
     
}
