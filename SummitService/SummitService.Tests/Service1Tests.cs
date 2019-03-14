using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummitService.Tests.ServiceReference1;

namespace SummitService.Tests
{
    [TestClass]
    public class Service1Tests
    {
        
        [TestMethod]
        public void AddCountry_USA_truereturned()
        {
            //arrange
            string country = "USA";
           
            bool expected = true;

            //act
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            var result = client.AddCountry(country);

            //assert
            Assert.AreEqual(expected, result.error);
        }

        [TestMethod]
        public void AddSummit_Big7_truereturned()
        {
            //arrange
            string summit = "Big10";
            DateTime date = DateTime.Today;
            bool expected = true;

            //act
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            var result = client.AddSummit(summit, date);

            //assert
            Assert.AreEqual(expected, result.error);
        }

        [TestMethod]
        public void AddVariant_1_1_1_truereturned()
        {
            //arrange
            int country_id = 1;
            int user_id = 1;
            int summit_id = 1;
            DateTime date1 = DateTime.Today;
            DateTime date2 = DateTime.Today;
            bool expected = true;

            //act
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            var result = client.AddVariant(date1, date2, country_id, user_id, summit_id);

            //assert
            Assert.AreEqual(expected, result.error);
        }

        [TestMethod]
        public void AddVoice_1_1_true_returned()
        {
            //arrange
            int user_id = 1;
            int variant_id = 1;
            bool expected = true;

            //act
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            var result = client.AddVoice(user_id, variant_id);

            //assert
            Assert.AreEqual(expected, result.error);
        }
    }
}
