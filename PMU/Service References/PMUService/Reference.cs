﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMU.PMUService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PMUServiceDataResult", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
        "tites")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PMU.PMUService.WSString))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PMU.PMUService.WSBoolean))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PMU.PMUService.WSInteger))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PMU.PMUService.User))]
    public partial class PMUServiceDataResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WSString", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
        "tites")]
    [System.SerializableAttribute()]
    public partial class WSString : PMU.PMUService.PMUServiceDataResult {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WSBoolean", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
        "tites")]
    [System.SerializableAttribute()]
    public partial class WSBoolean : PMU.PMUService.PMUServiceDataResult {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BooleanValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BooleanValue {
            get {
                return this.BooleanValueField;
            }
            set {
                if ((this.BooleanValueField.Equals(value) != true)) {
                    this.BooleanValueField = value;
                    this.RaisePropertyChanged("BooleanValue");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WSInteger", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
        "tites")]
    [System.SerializableAttribute()]
    public partial class WSInteger : PMU.PMUService.PMUServiceDataResult {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IntegerValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IntegerValue {
            get {
                return this.IntegerValueField;
            }
            set {
                if ((this.IntegerValueField.Equals(value) != true)) {
                    this.IntegerValueField = value;
                    this.RaisePropertyChanged("IntegerValue");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
        "tites")]
    [System.SerializableAttribute()]
    public partial class User : PMU.PMUService.PMUServiceDataResult {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_Address1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_Address2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_Address3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int C_CityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int C_CountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_PinCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int C_StateIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FbUniqueIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GmailUniqueIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsDeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsEnabledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsFbUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsGmailUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string M_NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModifiedOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string P_Address1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string P_Address2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string P_Address3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int P_CityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int P_CountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string P_PinCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int P_StateIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string T_NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Address1 {
            get {
                return this.C_Address1Field;
            }
            set {
                if ((object.ReferenceEquals(this.C_Address1Field, value) != true)) {
                    this.C_Address1Field = value;
                    this.RaisePropertyChanged("C_Address1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Address2 {
            get {
                return this.C_Address2Field;
            }
            set {
                if ((object.ReferenceEquals(this.C_Address2Field, value) != true)) {
                    this.C_Address2Field = value;
                    this.RaisePropertyChanged("C_Address2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Address3 {
            get {
                return this.C_Address3Field;
            }
            set {
                if ((object.ReferenceEquals(this.C_Address3Field, value) != true)) {
                    this.C_Address3Field = value;
                    this.RaisePropertyChanged("C_Address3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int C_CityId {
            get {
                return this.C_CityIdField;
            }
            set {
                if ((this.C_CityIdField.Equals(value) != true)) {
                    this.C_CityIdField = value;
                    this.RaisePropertyChanged("C_CityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int C_CountryId {
            get {
                return this.C_CountryIdField;
            }
            set {
                if ((this.C_CountryIdField.Equals(value) != true)) {
                    this.C_CountryIdField = value;
                    this.RaisePropertyChanged("C_CountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_PinCode {
            get {
                return this.C_PinCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.C_PinCodeField, value) != true)) {
                    this.C_PinCodeField = value;
                    this.RaisePropertyChanged("C_PinCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int C_StateId {
            get {
                return this.C_StateIdField;
            }
            set {
                if ((this.C_StateIdField.Equals(value) != true)) {
                    this.C_StateIdField = value;
                    this.RaisePropertyChanged("C_StateId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedOn {
            get {
                return this.CreatedOnField;
            }
            set {
                if ((this.CreatedOnField.Equals(value) != true)) {
                    this.CreatedOnField = value;
                    this.RaisePropertyChanged("CreatedOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FbUniqueId {
            get {
                return this.FbUniqueIdField;
            }
            set {
                if ((object.ReferenceEquals(this.FbUniqueIdField, value) != true)) {
                    this.FbUniqueIdField = value;
                    this.RaisePropertyChanged("FbUniqueId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GmailUniqueId {
            get {
                return this.GmailUniqueIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GmailUniqueIdField, value) != true)) {
                    this.GmailUniqueIdField = value;
                    this.RaisePropertyChanged("GmailUniqueId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDeleted {
            get {
                return this.IsDeletedField;
            }
            set {
                if ((this.IsDeletedField.Equals(value) != true)) {
                    this.IsDeletedField = value;
                    this.RaisePropertyChanged("IsDeleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnabled {
            get {
                return this.IsEnabledField;
            }
            set {
                if ((this.IsEnabledField.Equals(value) != true)) {
                    this.IsEnabledField = value;
                    this.RaisePropertyChanged("IsEnabled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsFbUser {
            get {
                return this.IsFbUserField;
            }
            set {
                if ((this.IsFbUserField.Equals(value) != true)) {
                    this.IsFbUserField = value;
                    this.RaisePropertyChanged("IsFbUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsGmailUser {
            get {
                return this.IsGmailUserField;
            }
            set {
                if ((this.IsGmailUserField.Equals(value) != true)) {
                    this.IsGmailUserField = value;
                    this.RaisePropertyChanged("IsGmailUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string M_Number {
            get {
                return this.M_NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.M_NumberField, value) != true)) {
                    this.M_NumberField = value;
                    this.RaisePropertyChanged("M_Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedOn {
            get {
                return this.ModifiedOnField;
            }
            set {
                if ((this.ModifiedOnField.Equals(value) != true)) {
                    this.ModifiedOnField = value;
                    this.RaisePropertyChanged("ModifiedOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string P_Address1 {
            get {
                return this.P_Address1Field;
            }
            set {
                if ((object.ReferenceEquals(this.P_Address1Field, value) != true)) {
                    this.P_Address1Field = value;
                    this.RaisePropertyChanged("P_Address1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string P_Address2 {
            get {
                return this.P_Address2Field;
            }
            set {
                if ((object.ReferenceEquals(this.P_Address2Field, value) != true)) {
                    this.P_Address2Field = value;
                    this.RaisePropertyChanged("P_Address2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string P_Address3 {
            get {
                return this.P_Address3Field;
            }
            set {
                if ((object.ReferenceEquals(this.P_Address3Field, value) != true)) {
                    this.P_Address3Field = value;
                    this.RaisePropertyChanged("P_Address3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int P_CityId {
            get {
                return this.P_CityIdField;
            }
            set {
                if ((this.P_CityIdField.Equals(value) != true)) {
                    this.P_CityIdField = value;
                    this.RaisePropertyChanged("P_CityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int P_CountryId {
            get {
                return this.P_CountryIdField;
            }
            set {
                if ((this.P_CountryIdField.Equals(value) != true)) {
                    this.P_CountryIdField = value;
                    this.RaisePropertyChanged("P_CountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string P_PinCode {
            get {
                return this.P_PinCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.P_PinCodeField, value) != true)) {
                    this.P_PinCodeField = value;
                    this.RaisePropertyChanged("P_PinCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int P_StateId {
            get {
                return this.P_StateIdField;
            }
            set {
                if ((this.P_StateIdField.Equals(value) != true)) {
                    this.P_StateIdField = value;
                    this.RaisePropertyChanged("P_StateId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string T_Number {
            get {
                return this.T_NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.T_NumberField, value) != true)) {
                    this.T_NumberField = value;
                    this.RaisePropertyChanged("T_Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PMUServiceResult", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
        "tites")]
    [System.SerializableAttribute()]
    public partial class PMUServiceResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PMU.PMUService.PMUServiceDataResult DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public PMU.PMUService.PMUServiceDataResult Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDetails {
            get {
                return this.ErrorDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDetailsField, value) != true)) {
                    this.ErrorDetailsField = value;
                    this.RaisePropertyChanged("ErrorDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PMUService.IPMUService")]
    public interface IPMUService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPMUService/InsertUserSignUpDetails", ReplyAction="http://tempuri.org/IPMUService/InsertUserSignUpDetailsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PMU.PMUService.PMUServiceResult), Action="http://tempuri.org/IPMUService/InsertUserSignUpDetailsPMUServiceResultFault", Name="PMUServiceResult", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
            "tites")]
        PMU.PMUService.PMUServiceResult InsertUserSignUpDetails(PMU.PMUService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPMUService/IsUserNameExist", ReplyAction="http://tempuri.org/IPMUService/IsUserNameExistResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PMU.PMUService.PMUServiceResult), Action="http://tempuri.org/IPMUService/IsUserNameExistPMUServiceResultFault", Name="PMUServiceResult", Namespace="http://schemas.datacontract.org/2004/07/PMU.PMUServices.PMUService.Contracts.Enti" +
            "tites")]
        PMU.PMUService.PMUServiceResult IsUserNameExist(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPMUServiceChannel : PMU.PMUService.IPMUService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PMUServiceClient : System.ServiceModel.ClientBase<PMU.PMUService.IPMUService>, PMU.PMUService.IPMUService {
        
        public PMUServiceClient() {
        }
        
        public PMUServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PMUServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PMUServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PMUServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PMU.PMUService.PMUServiceResult InsertUserSignUpDetails(PMU.PMUService.User user) {
            return base.Channel.InsertUserSignUpDetails(user);
        }
        
        public PMU.PMUService.PMUServiceResult IsUserNameExist(string userName) {
            return base.Channel.IsUserNameExist(userName);
        }
    }
}
