using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            string delimiters = somestring.Split('\n')[0];

            return CalculateMethod(numbers, delimiters);
        }


        private static string CalculateMethod(string numbs, string delimiters)
        {
            StringBuilder stringBuild = new StringBuilder();
            string results = "";
            int response;
            int total = 0;

            foreach (var items in Regex.Matches(numbs, @"(\d+|-\d+)"))
            {
                if (Convert.ToInt32(items.ToString()) > 0)
                {
                    if (Convert.ToDouble(items.ToString()) < 1000)
                    {
                        total += Convert.ToInt32(items.ToString());

                    }
                }
                else
                {
                    stringBuild.Append($"{items.ToString()} ");
                }
            }

            if (int.TryParse(delimiters, out response))
            {
                if (!string.IsNullOrEmpty(stringBuild.ToString()))
                {

                    results = string.Format("The total is = {0} and {1} are not allowed", (total + int.Parse(delimiters)).ToString(), stringBuild);

                }
                else
                {

                    results = string.Format("The total is = {0}", (total + int.Parse(delimiters)).ToString());

                }
            }
            else
            {
                if (!string.IsNullOrEmpty(stringBuild.ToString()))
                {

                    results = string.Format("The total is = {0} and {1} are not allowed", (total).ToString(), stringBuild);

                }
                else
                {

                    results = string.Format("The total is = {0}", (total).ToString());

                }
            }

            return results;
        }
    }
}
