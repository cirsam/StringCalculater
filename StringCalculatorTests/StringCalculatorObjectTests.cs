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
            string radom_string = "";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("Not ok",result);
        }


        [TestMethod()]
        public void TestDelimiterIsNumericNotEndNewLine()
        {
            StringCalculatorObject string_cal = new StringCalculatorObject();
            string radom_string = "";
            string result = string_cal.Add(radom_string);
            Assert.AreEqual("The total is 6", result);
        }
    }
}