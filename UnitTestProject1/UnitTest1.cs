using System;
using EricCupueran_ExamenVueling.Clases;
using EricCupueran_ExamenVueling.Factory;
using EricCupueran_ExamenVueling.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
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

        [TestMethod]
        public void TestMethod2()
        {
            Factory factory = new Factory();

            IUniverse rebelde = factory.getUniverse( "Rebelde");
            rebelde.SetName("Erick");
            Assert.AreEqual("Erick", rebelde.GetName());

        }

        [TestMethod]
        public void TestMethod3()
        {
            Factory factory = new Factory();

            IUniverse planeta = factory.getUniverse("Planeta");
            planeta.SetName("Mercurio");
            Assert.AreEqual("Mercurio", planeta.GetName());

        }

        [TestMethod]
        public void TestMethod4()
        {
            Factory factory = new Factory();

            IUniverse soldado = factory.getUniverse("Soldado");
            soldado.SetName("Capitán");
            Assert.AreEqual("Capitán", soldado.GetName());

        }
    }
}
