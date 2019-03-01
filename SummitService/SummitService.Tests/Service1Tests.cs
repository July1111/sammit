using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummitService.Tests.ServiceReference1;

namespace SummitService.Tests
{
    [TestClass]
    public class Service1Tests
    {
        [TestMethod]
        public void AddCountry_Russia_truereturned()
        {
            //arrange
            string country = "Russia";
            bool expected = true;
            
            //act
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            var result = client.AddCountry(country);

            //assert
            Assert.AreEqual(expected, result.error);
        }
    }
}
