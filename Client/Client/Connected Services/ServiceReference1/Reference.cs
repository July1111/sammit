﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auth", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Auth : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool errorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string error_messageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_userField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool error {
            get {
                return this.errorField;
            }
            set {
                if ((this.errorField.Equals(value) != true)) {
                    this.errorField = value;
                    this.RaisePropertyChanged("error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error_message {
            get {
                return this.error_messageField;
            }
            set {
                if ((object.ReferenceEquals(this.error_messageField, value) != true)) {
                    this.error_messageField = value;
                    this.RaisePropertyChanged("error_message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_user {
            get {
                return this.id_userField;
            }
            set {
                if ((this.id_userField.Equals(value) != true)) {
                    this.id_userField = value;
                    this.RaisePropertyChanged("id_user");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Summit", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Summit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Summit_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool errorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string error_messageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Summit_ID {
            get {
                return this.Summit_IDField;
            }
            set {
                if ((this.Summit_IDField.Equals(value) != true)) {
                    this.Summit_IDField = value;
                    this.RaisePropertyChanged("Summit_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool error {
            get {
                return this.errorField;
            }
            set {
                if ((this.errorField.Equals(value) != true)) {
                    this.errorField = value;
                    this.RaisePropertyChanged("error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error_message {
            get {
                return this.error_messageField;
            }
            set {
                if ((object.ReferenceEquals(this.error_messageField, value) != true)) {
                    this.error_messageField = value;
                    this.RaisePropertyChanged("error_message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Country : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Country_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool errorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string error_messageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Country_ID {
            get {
                return this.Country_IDField;
            }
            set {
                if ((this.Country_IDField.Equals(value) != true)) {
                    this.Country_IDField = value;
                    this.RaisePropertyChanged("Country_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool error {
            get {
                return this.errorField;
            }
            set {
                if ((this.errorField.Equals(value) != true)) {
                    this.errorField = value;
                    this.RaisePropertyChanged("error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error_message {
            get {
                return this.error_messageField;
            }
            set {
                if ((object.ReferenceEquals(this.error_messageField, value) != true)) {
                    this.error_messageField = value;
                    this.RaisePropertyChanged("error_message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Variant", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Variant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FinishDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string countryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int country_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool errorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string error_messageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int summit_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int user_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int variant_idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FinishDate {
            get {
                return this.FinishDateField;
            }
            set {
                if ((this.FinishDateField.Equals(value) != true)) {
                    this.FinishDateField = value;
                    this.RaisePropertyChanged("FinishDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country {
            get {
                return this.countryField;
            }
            set {
                if ((object.ReferenceEquals(this.countryField, value) != true)) {
                    this.countryField = value;
                    this.RaisePropertyChanged("country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int country_id {
            get {
                return this.country_idField;
            }
            set {
                if ((this.country_idField.Equals(value) != true)) {
                    this.country_idField = value;
                    this.RaisePropertyChanged("country_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool error {
            get {
                return this.errorField;
            }
            set {
                if ((this.errorField.Equals(value) != true)) {
                    this.errorField = value;
                    this.RaisePropertyChanged("error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error_message {
            get {
                return this.error_messageField;
            }
            set {
                if ((object.ReferenceEquals(this.error_messageField, value) != true)) {
                    this.error_messageField = value;
                    this.RaisePropertyChanged("error_message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int summit_id {
            get {
                return this.summit_idField;
            }
            set {
                if ((this.summit_idField.Equals(value) != true)) {
                    this.summit_idField = value;
                    this.RaisePropertyChanged("summit_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string user {
            get {
                return this.userField;
            }
            set {
                if ((object.ReferenceEquals(this.userField, value) != true)) {
                    this.userField = value;
                    this.RaisePropertyChanged("user");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int user_id {
            get {
                return this.user_idField;
            }
            set {
                if ((this.user_idField.Equals(value) != true)) {
                    this.user_idField = value;
                    this.RaisePropertyChanged("user_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int variant_id {
            get {
                return this.variant_idField;
            }
            set {
                if ((this.variant_idField.Equals(value) != true)) {
                    this.variant_idField = value;
                    this.RaisePropertyChanged("variant_id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Voice", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Voice : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string country_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool errorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string error_messageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime finish_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime start_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int sumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int user_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int variant_idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country_name {
            get {
                return this.country_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.country_nameField, value) != true)) {
                    this.country_nameField = value;
                    this.RaisePropertyChanged("country_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool error {
            get {
                return this.errorField;
            }
            set {
                if ((this.errorField.Equals(value) != true)) {
                    this.errorField = value;
                    this.RaisePropertyChanged("error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error_message {
            get {
                return this.error_messageField;
            }
            set {
                if ((object.ReferenceEquals(this.error_messageField, value) != true)) {
                    this.error_messageField = value;
                    this.RaisePropertyChanged("error_message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime finish_date {
            get {
                return this.finish_dateField;
            }
            set {
                if ((this.finish_dateField.Equals(value) != true)) {
                    this.finish_dateField = value;
                    this.RaisePropertyChanged("finish_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime start_date {
            get {
                return this.start_dateField;
            }
            set {
                if ((this.start_dateField.Equals(value) != true)) {
                    this.start_dateField = value;
                    this.RaisePropertyChanged("start_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sum {
            get {
                return this.sumField;
            }
            set {
                if ((this.sumField.Equals(value) != true)) {
                    this.sumField = value;
                    this.RaisePropertyChanged("sum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int user_id {
            get {
                return this.user_idField;
            }
            set {
                if ((this.user_idField.Equals(value) != true)) {
                    this.user_idField = value;
                    this.RaisePropertyChanged("user_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int variant_id {
            get {
                return this.variant_idField;
            }
            set {
                if ((this.variant_idField.Equals(value) != true)) {
                    this.variant_idField = value;
                    this.RaisePropertyChanged("variant_id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorisation", ReplyAction="http://tempuri.org/IService1/AuthorisationResponse")]
        Client.ServiceReference1.Auth Authorisation(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorisation", ReplyAction="http://tempuri.org/IService1/AuthorisationResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Auth> AuthorisationAsync(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSummit", ReplyAction="http://tempuri.org/IService1/AddSummitResponse")]
        Client.ServiceReference1.Summit AddSummit(string summit, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSummit", ReplyAction="http://tempuri.org/IService1/AddSummitResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Summit> AddSummitAsync(string summit, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCountry", ReplyAction="http://tempuri.org/IService1/AddCountryResponse")]
        Client.ServiceReference1.Country AddCountry(string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCountry", ReplyAction="http://tempuri.org/IService1/AddCountryResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Country> AddCountryAsync(string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddVariant", ReplyAction="http://tempuri.org/IService1/AddVariantResponse")]
        Client.ServiceReference1.Variant AddVariant(System.DateTime StartDate, System.DateTime FinishDate, int country_id, int user_id, int summit_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddVariant", ReplyAction="http://tempuri.org/IService1/AddVariantResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Variant> AddVariantAsync(System.DateTime StartDate, System.DateTime FinishDate, int country_id, int user_id, int summit_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddVoice", ReplyAction="http://tempuri.org/IService1/AddVoiceResponse")]
        Client.ServiceReference1.Voice AddVoice(int user_id, int variant_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddVoice", ReplyAction="http://tempuri.org/IService1/AddVoiceResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Voice> AddVoiceAsync(int user_id, int variant_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAllVoices", ReplyAction="http://tempuri.org/IService1/DeleteAllVoicesResponse")]
        void DeleteAllVoices();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAllVoices", ReplyAction="http://tempuri.org/IService1/DeleteAllVoicesResponse")]
        System.Threading.Tasks.Task DeleteAllVoicesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Summarizing", ReplyAction="http://tempuri.org/IService1/SummarizingResponse")]
        Client.ServiceReference1.Voice[] Summarizing();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Summarizing", ReplyAction="http://tempuri.org/IService1/SummarizingResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Voice[]> SummarizingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectCountry", ReplyAction="http://tempuri.org/IService1/SelectCountryResponse")]
        Client.ServiceReference1.Country[] SelectCountry();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectCountry", ReplyAction="http://tempuri.org/IService1/SelectCountryResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Country[]> SelectCountryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectSummit", ReplyAction="http://tempuri.org/IService1/SelectSummitResponse")]
        Client.ServiceReference1.Summit[] SelectSummit();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectSummit", ReplyAction="http://tempuri.org/IService1/SelectSummitResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Summit[]> SelectSummitAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectVariant", ReplyAction="http://tempuri.org/IService1/SelectVariantResponse")]
        Client.ServiceReference1.Variant[] SelectVariant(int summit_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectVariant", ReplyAction="http://tempuri.org/IService1/SelectVariantResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Variant[]> SelectVariantAsync(int summit_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckVoice", ReplyAction="http://tempuri.org/IService1/CheckVoiceResponse")]
        bool CheckVoice(int user_id, int summit_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckVoice", ReplyAction="http://tempuri.org/IService1/CheckVoiceResponse")]
        System.Threading.Tasks.Task<bool> CheckVoiceAsync(int user_id, int summit_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ServiceReference1.Auth Authorisation(string Login, string Password) {
            return base.Channel.Authorisation(Login, Password);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Auth> AuthorisationAsync(string Login, string Password) {
            return base.Channel.AuthorisationAsync(Login, Password);
        }
        
        public Client.ServiceReference1.Summit AddSummit(string summit, System.DateTime date) {
            return base.Channel.AddSummit(summit, date);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Summit> AddSummitAsync(string summit, System.DateTime date) {
            return base.Channel.AddSummitAsync(summit, date);
        }
        
        public Client.ServiceReference1.Country AddCountry(string country) {
            return base.Channel.AddCountry(country);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Country> AddCountryAsync(string country) {
            return base.Channel.AddCountryAsync(country);
        }
        
        public Client.ServiceReference1.Variant AddVariant(System.DateTime StartDate, System.DateTime FinishDate, int country_id, int user_id, int summit_id) {
            return base.Channel.AddVariant(StartDate, FinishDate, country_id, user_id, summit_id);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Variant> AddVariantAsync(System.DateTime StartDate, System.DateTime FinishDate, int country_id, int user_id, int summit_id) {
            return base.Channel.AddVariantAsync(StartDate, FinishDate, country_id, user_id, summit_id);
        }
        
        public Client.ServiceReference1.Voice AddVoice(int user_id, int variant_id) {
            return base.Channel.AddVoice(user_id, variant_id);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Voice> AddVoiceAsync(int user_id, int variant_id) {
            return base.Channel.AddVoiceAsync(user_id, variant_id);
        }
        
        public void DeleteAllVoices() {
            base.Channel.DeleteAllVoices();
        }
        
        public System.Threading.Tasks.Task DeleteAllVoicesAsync() {
            return base.Channel.DeleteAllVoicesAsync();
        }
        
        public Client.ServiceReference1.Voice[] Summarizing() {
            return base.Channel.Summarizing();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Voice[]> SummarizingAsync() {
            return base.Channel.SummarizingAsync();
        }
        
        public Client.ServiceReference1.Country[] SelectCountry() {
            return base.Channel.SelectCountry();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Country[]> SelectCountryAsync() {
            return base.Channel.SelectCountryAsync();
        }
        
        public Client.ServiceReference1.Summit[] SelectSummit() {
            return base.Channel.SelectSummit();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Summit[]> SelectSummitAsync() {
            return base.Channel.SelectSummitAsync();
        }
        
        public Client.ServiceReference1.Variant[] SelectVariant(int summit_id) {
            return base.Channel.SelectVariant(summit_id);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Variant[]> SelectVariantAsync(int summit_id) {
            return base.Channel.SelectVariantAsync(summit_id);
        }
        
        public bool CheckVoice(int user_id, int summit_id) {
            return base.Channel.CheckVoice(user_id, summit_id);
        }
        
        public System.Threading.Tasks.Task<bool> CheckVoiceAsync(int user_id, int summit_id) {
            return base.Channel.CheckVoiceAsync(user_id, summit_id);
        }
    }
}
