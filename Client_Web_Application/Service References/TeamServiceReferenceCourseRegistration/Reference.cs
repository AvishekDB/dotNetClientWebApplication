﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_Web_Application.TeamServiceReferenceCourseRegistration {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SvcParticipant", Namespace="http://schemas.datacontract.org/2004/07/CourseRegistration.Service")]
    [System.SerializableAttribute()]
    public partial class SvcParticipant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DietaryRequirementField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmploymentStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Web_Application.TeamServiceReferenceCourseRegistration.Gender GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Web_Application.TeamServiceReferenceCourseRegistration.OrganizationSize OrganizationSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Web_Application.TeamServiceReferenceCourseRegistration.SalaryRange SalaryRangeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalutationField;
        
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
        public string ContactNumber {
            get {
                return this.ContactNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNumberField, value) != true)) {
                    this.ContactNumberField = value;
                    this.RaisePropertyChanged("ContactNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DietaryRequirement {
            get {
                return this.DietaryRequirementField;
            }
            set {
                if ((object.ReferenceEquals(this.DietaryRequirementField, value) != true)) {
                    this.DietaryRequirementField = value;
                    this.RaisePropertyChanged("DietaryRequirement");
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
        public string EmploymentStatus {
            get {
                return this.EmploymentStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.EmploymentStatusField, value) != true)) {
                    this.EmploymentStatusField = value;
                    this.RaisePropertyChanged("EmploymentStatus");
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
        public Client_Web_Application.TeamServiceReferenceCourseRegistration.Gender Gender {
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
        public string IdNumber {
            get {
                return this.IdNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.IdNumberField, value) != true)) {
                    this.IdNumberField = value;
                    this.RaisePropertyChanged("IdNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobTitle {
            get {
                return this.JobTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.JobTitleField, value) != true)) {
                    this.JobTitleField = value;
                    this.RaisePropertyChanged("JobTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nationality {
            get {
                return this.NationalityField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalityField, value) != true)) {
                    this.NationalityField = value;
                    this.RaisePropertyChanged("Nationality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_Web_Application.TeamServiceReferenceCourseRegistration.OrganizationSize OrganizationSize {
            get {
                return this.OrganizationSizeField;
            }
            set {
                if ((this.OrganizationSizeField.Equals(value) != true)) {
                    this.OrganizationSizeField = value;
                    this.RaisePropertyChanged("OrganizationSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_Web_Application.TeamServiceReferenceCourseRegistration.SalaryRange SalaryRange {
            get {
                return this.SalaryRangeField;
            }
            set {
                if ((this.SalaryRangeField.Equals(value) != true)) {
                    this.SalaryRangeField = value;
                    this.RaisePropertyChanged("SalaryRange");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salutation {
            get {
                return this.SalutationField;
            }
            set {
                if ((object.ReferenceEquals(this.SalutationField, value) != true)) {
                    this.SalutationField = value;
                    this.RaisePropertyChanged("Salutation");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender", Namespace="http://schemas.datacontract.org/2004/07/CourseRegistration.Service")]
    public enum Gender : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Female = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Male = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrganizationSize", Namespace="http://schemas.datacontract.org/2004/07/CourseRegistration.Service")]
    public enum OrganizationSize : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Less_Than_20 = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        From_20_To_200 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        From_200_To_500 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        More_Than_500 = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SalaryRange", Namespace="http://schemas.datacontract.org/2004/07/CourseRegistration.Service")]
    public enum SalaryRange : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Less_Than_60k = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        From_60_To_90k = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        From_90k_To_120k = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        More_Than_120k = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SvcCourseClass", Namespace="http://schemas.datacontract.org/2004/07/CourseRegistration.Service")]
    [System.SerializableAttribute()]
    public partial class SvcCourseClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassIdField;
        
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
        public string ClassId {
            get {
                return this.ClassIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassIdField, value) != true)) {
                    this.ClassIdField = value;
                    this.RaisePropertyChanged("ClassId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/CourseRegistration.Service")]
    [System.SerializableAttribute()]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bResultField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bResult {
            get {
                return this.bResultField;
            }
            set {
                if ((this.bResultField.Equals(value) != true)) {
                    this.bResultField = value;
                    this.RaisePropertyChanged("bResult");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TeamServiceReferenceCourseRegistration.ICourseRegistrationService")]
    public interface ICourseRegistrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseRegistrationService/RegisterCourseForEmployee", ReplyAction="http://tempuri.org/ICourseRegistrationService/RegisterCourseForEmployeeResponse")]
        Client_Web_Application.TeamServiceReferenceCourseRegistration.Result RegisterCourseForEmployee(Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcParticipant svcParticipant, Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcCourseClass svcCourseClass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseRegistrationService/RegisterCourseForEmployee", ReplyAction="http://tempuri.org/ICourseRegistrationService/RegisterCourseForEmployeeResponse")]
        System.Threading.Tasks.Task<Client_Web_Application.TeamServiceReferenceCourseRegistration.Result> RegisterCourseForEmployeeAsync(Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcParticipant svcParticipant, Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcCourseClass svcCourseClass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourseRegistrationServiceChannel : Client_Web_Application.TeamServiceReferenceCourseRegistration.ICourseRegistrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourseRegistrationServiceClient : System.ServiceModel.ClientBase<Client_Web_Application.TeamServiceReferenceCourseRegistration.ICourseRegistrationService>, Client_Web_Application.TeamServiceReferenceCourseRegistration.ICourseRegistrationService {
        
        public CourseRegistrationServiceClient() {
        }
        
        public CourseRegistrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourseRegistrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseRegistrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseRegistrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_Web_Application.TeamServiceReferenceCourseRegistration.Result RegisterCourseForEmployee(Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcParticipant svcParticipant, Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcCourseClass svcCourseClass) {
            return base.Channel.RegisterCourseForEmployee(svcParticipant, svcCourseClass);
        }
        
        public System.Threading.Tasks.Task<Client_Web_Application.TeamServiceReferenceCourseRegistration.Result> RegisterCourseForEmployeeAsync(Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcParticipant svcParticipant, Client_Web_Application.TeamServiceReferenceCourseRegistration.SvcCourseClass svcCourseClass) {
            return base.Channel.RegisterCourseForEmployeeAsync(svcParticipant, svcCourseClass);
        }
    }
}
