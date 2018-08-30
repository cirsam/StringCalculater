using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    [TestClass()]
    public class StringCalculatorObjectTests
    {
        [TestMethod()]
        public void TestEmptyString()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("0",result);
        }

        [TestMethod()]
        public void TestDelimiterIsNumericEndNewLine()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "1\n";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("Not ok",result);
        }

        [TestMethod()]
        public void TestDelimiterIsNumericNotEndNewLine()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "1\n2,3";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("The total is = 6", result);
        }

        [TestMethod()]
        public void TesttIgnoregreaterthan1000()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "1\n2,3,1000";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("The total is = 6", result);
        }

        [TestMethod()]
        public void TestNegativeNotAllowed()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "1\n-2,-3,1000";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("The total is = 1 and -2 -3  are not allowed", result);
        }

        [TestMethod()]
        public void TestDelimiterIsNotNumericNotEndNewLine()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "//;\n1;2";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("The total is = 6", result);
        }

        [TestMethod()]
        public void TestMultipleDelimiter()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "//[*][%]\n1*2%3";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("The total is = 6", result);
        }


    }
}