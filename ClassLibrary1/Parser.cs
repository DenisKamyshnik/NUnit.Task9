using System;

namespace ClassLibrary2Tests
{
    public class Parser
    {
        public bool Validator(string value)
        {
            double dValue;
            return Double.TryParse(value, out dValue);
        }
    }
}
