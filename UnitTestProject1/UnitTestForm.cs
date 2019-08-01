using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestForm
    {
        [TestMethod]
        public void TestMethod1()
        {
            Regex r = new Regex("[a-zA-Z]");
            string algo = "Erick ";
            //  if (r.IsMatch(algo)) {

            //   }


            algo = algo.Replace(" ", "");

            Assert.AreEqual("Erick", algo);
        }
        [TestMethod]
        public void TestMethod2()
        {

            // Regex r = new Regex(@"^[a-zA-Z]$");
            Regex rgx = new Regex("[0-9]");
            string algo = "Erick ";
            string algo2 = "Erick1";
            algo = algo.Replace(" ", "");
            algo2 = algo2.Replace(" ", "");
      
           Console.WriteLine(algo + " " + algo2);
            Assert.IsTrue(rgx.IsMatch(algo2), "Algo ha fallado");
        }
    }
}
