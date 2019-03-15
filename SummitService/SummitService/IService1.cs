using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace SummitService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Auth Authorisation(string Login, string Password);

        [OperationContract]
        Summit AddSummit(string summit, DateTime date);

        [OperationContract]
        Country AddCountry(string country);

        [OperationContract]
        Variant AddVariant(DateTime StartDate, DateTime FinishDate, int country_id, int user_id, int summit_id);

        [OperationContract]
        Voice AddVoice(int user_id, int variant_id);

        [OperationContract]
        void DeleteAllVoices();

        [OperationContract]
        List<Voice> Summarizing(int id);

        [OperationContract]
        List<Country> SelectCountry();

        [OperationContract]
        List<Summit> SelectSummit();

        [OperationContract]
        ObservableCollection<Variant> SelectVariant(int summit_id);
    }
}
