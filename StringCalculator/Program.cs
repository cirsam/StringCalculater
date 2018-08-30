using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculatorObject stringCal = new StringCalculatorObject();
            Console.WriteLine(stringCal.Add(""));
            Console.WriteLine(stringCal.Add("1\n2,3"));
            Console.WriteLine(stringCal.Add("1\n-2,-3,1000"));
            Console.WriteLine(stringCal.Add("1,\n"));
            Console.WriteLine(stringCal.Add("//;\n1;2"));
            Console.WriteLine(stringCal.Add("//[*][%]\n1*2%3"));
            Console.WriteLine(stringCal.Add("//[*][%]\n1*2%-3,1000"));
            Console.WriteLine(stringCal.Add("//[****][*%]\n1****2%%-3,1000"));
            Console.ReadKey();
        }
    }
}
