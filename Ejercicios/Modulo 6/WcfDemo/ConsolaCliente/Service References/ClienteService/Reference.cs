﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.269
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsolaCliente.ClienteService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clientes", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo")]
    [System.SerializableAttribute()]
    public partial class Clientes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDContactoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PisoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CuidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WebField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsolaCliente.ClienteService.Proyectos[] ProyectosField;
        
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
        public int IDCliente {
            get {
                return this.IDClienteField;
            }
            set {
                if ((this.IDClienteField.Equals(value) != true)) {
                    this.IDClienteField = value;
                    this.RaisePropertyChanged("IDCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int IDContacto {
            get {
                return this.IDContactoField;
            }
            set {
                if ((this.IDContactoField.Equals(value) != true)) {
                    this.IDContactoField = value;
                    this.RaisePropertyChanged("IDContacto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Calle {
            get {
                return this.CalleField;
            }
            set {
                if ((object.ReferenceEquals(this.CalleField, value) != true)) {
                    this.CalleField = value;
                    this.RaisePropertyChanged("Calle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Piso {
            get {
                return this.PisoField;
            }
            set {
                if ((object.ReferenceEquals(this.PisoField, value) != true)) {
                    this.PisoField = value;
                    this.RaisePropertyChanged("Piso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string Departamento {
            get {
                return this.DepartamentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartamentoField, value) != true)) {
                    this.DepartamentoField = value;
                    this.RaisePropertyChanged("Departamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string Cuidad {
            get {
                return this.CuidadField;
            }
            set {
                if ((object.ReferenceEquals(this.CuidadField, value) != true)) {
                    this.CuidadField = value;
                    this.RaisePropertyChanged("Cuidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public string Provincia {
            get {
                return this.ProvinciaField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinciaField, value) != true)) {
                    this.ProvinciaField = value;
                    this.RaisePropertyChanged("Provincia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public string Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisField, value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public string Web {
            get {
                return this.WebField;
            }
            set {
                if ((object.ReferenceEquals(this.WebField, value) != true)) {
                    this.WebField = value;
                    this.RaisePropertyChanged("Web");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public ConsolaCliente.ClienteService.Proyectos[] Proyectos {
            get {
                return this.ProyectosField;
            }
            set {
                if ((object.ReferenceEquals(this.ProyectosField, value) != true)) {
                    this.ProyectosField = value;
                    this.RaisePropertyChanged("Proyectos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Proyectos", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo")]
    [System.SerializableAttribute()]
    public partial class Proyectos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDProyectoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDClienteField;
        
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
        public int IDProyecto {
            get {
                return this.IDProyectoField;
            }
            set {
                if ((this.IDProyectoField.Equals(value) != true)) {
                    this.IDProyectoField = value;
                    this.RaisePropertyChanged("IDProyecto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int IDCliente {
            get {
                return this.IDClienteField;
            }
            set {
                if ((this.IDClienteField.Equals(value) != true)) {
                    this.IDClienteField = value;
                    this.RaisePropertyChanged("IDCliente");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteService.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetCliente", ReplyAction="http://tempuri.org/IClienteService/GetClienteResponse")]
        ConsolaCliente.ClienteService.Clientes GetCliente(int IDCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/GetClientes", ReplyAction="http://tempuri.org/IClienteService/GetClientesResponse")]
        ConsolaCliente.ClienteService.Clientes[] GetClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/InsertarCliente", ReplyAction="http://tempuri.org/IClienteService/InsertarClienteResponse")]
        int InsertarCliente(ConsolaCliente.ClienteService.Clientes Cli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ActualizarCliente", ReplyAction="http://tempuri.org/IClienteService/ActualizarClienteResponse")]
        ConsolaCliente.ClienteService.Clientes ActualizarCliente(ConsolaCliente.ClienteService.Clientes Cli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/EliminarCliente", ReplyAction="http://tempuri.org/IClienteService/EliminarClienteResponse")]
        void EliminarCliente(ConsolaCliente.ClienteService.Clientes Cli);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : ConsolaCliente.ClienteService.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<ConsolaCliente.ClienteService.IClienteService>, ConsolaCliente.ClienteService.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsolaCliente.ClienteService.Clientes GetCliente(int IDCliente) {
            return base.Channel.GetCliente(IDCliente);
        }
        
        public ConsolaCliente.ClienteService.Clientes[] GetClientes() {
            return base.Channel.GetClientes();
        }
        
        public int InsertarCliente(ConsolaCliente.ClienteService.Clientes Cli) {
            return base.Channel.InsertarCliente(Cli);
        }
        
        public ConsolaCliente.ClienteService.Clientes ActualizarCliente(ConsolaCliente.ClienteService.Clientes Cli) {
            return base.Channel.ActualizarCliente(Cli);
        }
        
        public void EliminarCliente(ConsolaCliente.ClienteService.Clientes Cli) {
            base.Channel.EliminarCliente(Cli);
        }
    }
}
