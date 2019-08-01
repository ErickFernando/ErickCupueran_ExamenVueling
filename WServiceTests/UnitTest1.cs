using System;
using EricCupueran_ExamenVueling.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rebelde r = new Rebelde();
            r.NameRebelde = "Erick";

            Console.WriteLine("holsaa");
            Assert.AreEqual("Erick", r.GetName());
        }
    }
}
