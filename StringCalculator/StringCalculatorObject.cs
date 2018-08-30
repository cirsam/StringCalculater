using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorObject
    {
        public string Add(string somestring)
        {
            if (string.IsNullOrEmpty(somestring))
            {
                return "0";
            }


            string numbers = somestring.Split('\n')[1];

            if (string.IsNullOrEmpty(numbers))
            {
                return "Not ok";
            }

            return "";
        }
    }
}
