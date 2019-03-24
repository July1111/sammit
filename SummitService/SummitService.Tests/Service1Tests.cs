using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummitService.Tests.ServiceReference1;

namespace SummitService.Tests
{
    [TestClass]
    public class Service1Tests
    {
        
        [TestMethod]
        public void AddCountry_USA_falsereturned()
        {
            var client = new Service1();
            int CountryBefore = client.SelectCountry().Count;
            Country co = new Country
            {
                Name = "USAa"
            };
            Country co1 = new Country();
            co1 = client.AddCountry(co);
            int CountryAfter = client.SelectCountry().Count;
            Assert.AreEqual(CountryBefore + 1, CountryAfter);
        }

        [TestMethod]
        public void AddSummit_Big7_falsereturned()
        {
            var client = new Service1();
            int SumBefore = client.SelectSummit().Count;
            Summit su = new Summit
            {
                Name = "Big7a"
            };
            Summit su1 = new Summit();
            su1 = client.AddSummit(su);
            int SumAfter = client.SelectSummit().Count;
            Assert.AreEqual(SumBefore + 1, SumAfter);
        }
        /*
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
        }*/
        /*
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
        }*/
    }
}
