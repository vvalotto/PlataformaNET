﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExceptionHandlingExample.SalaryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SalaryCalculationFault", Namespace="http://schemas.datacontract.org/2004/07/ExampleService")]
    [System.SerializableAttribute()]
    public partial class SalaryCalculationFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid FaultIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
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
        public System.Guid FaultID {
            get {
                return this.FaultIDField;
            }
            set {
                if ((this.FaultIDField.Equals(value) != true)) {
                    this.FaultIDField = value;
                    this.RaisePropertyChanged("FaultID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalaryService.ISalaryService")]
    public interface ISalaryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalaryService/GetWeeklySalary", ReplyAction="http://tempuri.org/ISalaryService/GetWeeklySalaryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ExceptionHandlingExample.SalaryService.SalaryCalculationFault), Action="http://tempuri.org/ISalaryService/GetWeeklySalarySalaryCalculationFaultFault", Name="SalaryCalculationFault", Namespace="http://schemas.datacontract.org/2004/07/ExampleService")]
        decimal GetWeeklySalary(string employeeId, int weeks);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ISalaryServiceChannel : ExceptionHandlingExample.SalaryService.ISalaryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class SalaryServiceClient : System.ServiceModel.ClientBase<ExceptionHandlingExample.SalaryService.ISalaryService>, ExceptionHandlingExample.SalaryService.ISalaryService {
        
        public SalaryServiceClient() {
        }
        
        public SalaryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalaryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalaryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalaryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal GetWeeklySalary(string employeeId, int weeks) {
            return base.Channel.GetWeeklySalary(employeeId, weeks);
        }
    }
}
