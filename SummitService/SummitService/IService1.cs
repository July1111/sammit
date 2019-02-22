﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SummitService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Auth Authorisation(string Login, string Password);

        [OperationContract]
        void AddSummit(Summit summit);

        [OperationContract]
        void AddCountry(Country country);

        [OperationContract]
        void AddVariant(Variant variant);
    }
}
