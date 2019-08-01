using System;
using EricCupueran_ExamenVueling.Factory;
using EricCupueran_ExamenVueling.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestWS
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceReferenceTest.WebServiceSoapClient serviceSoapClient = new ServiceReferenceTest.WebServiceSoapClient();

            Factory factory = new Factory();

            IUniverse Planeta = factory.getUniverse("Planeta");
            IUniverse Rebelde = factory.getUniverse("Rebelde");

            Rebelde.SetName("Erick");
            Planeta.SetName("Venus");

            Assert.IsTrue(serviceSoapClient.AddListServiceRebelde(Rebelde.GetName(),Planeta.GetName()), "algo ha fallado");

           
        }

        [TestMethod]
        public void TestMethod2()
        {
            ServiceReferenceTest.WebServiceSoapClient serviceSoapClient = new ServiceReferenceTest.WebServiceSoapClient();

            Factory factory = new Factory();

            IUniverse Planeta = factory.getUniverse("Planeta");
            IUniverse Rebelde = factory.getUniverse("Rebelde");

            Rebelde.SetName("Erick");
            Planeta.SetName("Venus");

            serviceSoapClient.AddListServiceRebelde(Rebelde.GetName(), Planeta.GetName());

          var  listaRebeldes = serviceSoapClient.GetRebeldesService();

            foreach (var values in listaRebeldes) {
              
                Assert.AreEqual("Erick" + "," + "Venus", values);
            }
        }
    }
}
