﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_Web_Application.TeamServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SvcStudent", Namespace="http://schemas.datacontract.org/2004/07/CourseRegistration.Service")]
    [System.SerializableAttribute()]
    public partial class SvcStudent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_Web_Application.TeamServiceReference.Gender GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ParticipantIdField;
        
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
        public Client_Web_Application.TeamServiceReference.Gender Gender {
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
        public int ParticipantId {
            get {
                return this.ParticipantIdField;
            }
            set {
                if ((this.ParticipantIdField.Equals(value) != true)) {
                    this.ParticipantIdField = value;
                    this.RaisePropertyChanged("ParticipantId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TeamServiceReference.IAttendanceService")]
    public interface IAttendanceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/GetStudentList", ReplyAction="http://tempuri.org/IAttendanceService/GetStudentListResponse")]
        Client_Web_Application.TeamServiceReference.SvcStudent[] GetStudentList(System.DateTime date, string classId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/GetStudentList", ReplyAction="http://tempuri.org/IAttendanceService/GetStudentListResponse")]
        System.Threading.Tasks.Task<Client_Web_Application.TeamServiceReference.SvcStudent[]> GetStudentListAsync(System.DateTime date, string classId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/SubmitAttendance", ReplyAction="http://tempuri.org/IAttendanceService/SubmitAttendanceResponse")]
        Client_Web_Application.TeamServiceReference.Result SubmitAttendance(int participantId, string classId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/SubmitAttendance", ReplyAction="http://tempuri.org/IAttendanceService/SubmitAttendanceResponse")]
        System.Threading.Tasks.Task<Client_Web_Application.TeamServiceReference.Result> SubmitAttendanceAsync(int participantId, string classId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAttendanceServiceChannel : Client_Web_Application.TeamServiceReference.IAttendanceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AttendanceServiceClient : System.ServiceModel.ClientBase<Client_Web_Application.TeamServiceReference.IAttendanceService>, Client_Web_Application.TeamServiceReference.IAttendanceService {
        
        public AttendanceServiceClient() {
        }
        
        public AttendanceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AttendanceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AttendanceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AttendanceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_Web_Application.TeamServiceReference.SvcStudent[] GetStudentList(System.DateTime date, string classId) {
            return base.Channel.GetStudentList(date, classId);
        }
        
        public System.Threading.Tasks.Task<Client_Web_Application.TeamServiceReference.SvcStudent[]> GetStudentListAsync(System.DateTime date, string classId) {
            return base.Channel.GetStudentListAsync(date, classId);
        }
        
        public Client_Web_Application.TeamServiceReference.Result SubmitAttendance(int participantId, string classId) {
            return base.Channel.SubmitAttendance(participantId, classId);
        }
        
        public System.Threading.Tasks.Task<Client_Web_Application.TeamServiceReference.Result> SubmitAttendanceAsync(int participantId, string classId) {
            return base.Channel.SubmitAttendanceAsync(participantId, classId);
        }
    }
}
