﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IronMan.IronManEventoServicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Evento", Namespace="http://schemas.datacontract.org/2004/07/IronManServicios")]
    [System.SerializableAttribute()]
    public partial class Evento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComentarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LugarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Comentario {
            get {
                return this.ComentarioField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentarioField, value) != true)) {
                    this.ComentarioField = value;
                    this.RaisePropertyChanged("Comentario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lugar {
            get {
                return this.LugarField;
            }
            set {
                if ((object.ReferenceEquals(this.LugarField, value) != true)) {
                    this.LugarField = value;
                    this.RaisePropertyChanged("Lugar");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IronManEventoServicio.IEventoServicio")]
    public interface IEventoServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/ObtenerNombreEvento", ReplyAction="http://tempuri.org/IEventoServicio/ObtenerNombreEventoResponse")]
        string ObtenerNombreEvento(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/ObtenerNombreEvento", ReplyAction="http://tempuri.org/IEventoServicio/ObtenerNombreEventoResponse")]
        System.Threading.Tasks.Task<string> ObtenerNombreEventoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/Guardar", ReplyAction="http://tempuri.org/IEventoServicio/GuardarResponse")]
        void Guardar(IronMan.IronManEventoServicio.Evento e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/Guardar", ReplyAction="http://tempuri.org/IEventoServicio/GuardarResponse")]
        System.Threading.Tasks.Task GuardarAsync(IronMan.IronManEventoServicio.Evento e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/Obtener", ReplyAction="http://tempuri.org/IEventoServicio/ObtenerResponse")]
        IronMan.IronManEventoServicio.Evento Obtener(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/Obtener", ReplyAction="http://tempuri.org/IEventoServicio/ObtenerResponse")]
        System.Threading.Tasks.Task<IronMan.IronManEventoServicio.Evento> ObtenerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/Listar", ReplyAction="http://tempuri.org/IEventoServicio/ListarResponse")]
        IronMan.IronManEventoServicio.Evento[] Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoServicio/Listar", ReplyAction="http://tempuri.org/IEventoServicio/ListarResponse")]
        System.Threading.Tasks.Task<IronMan.IronManEventoServicio.Evento[]> ListarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventoServicioChannel : IronMan.IronManEventoServicio.IEventoServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventoServicioClient : System.ServiceModel.ClientBase<IronMan.IronManEventoServicio.IEventoServicio>, IronMan.IronManEventoServicio.IEventoServicio {
        
        public EventoServicioClient() {
        }
        
        public EventoServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventoServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObtenerNombreEvento(int id) {
            return base.Channel.ObtenerNombreEvento(id);
        }
        
        public System.Threading.Tasks.Task<string> ObtenerNombreEventoAsync(int id) {
            return base.Channel.ObtenerNombreEventoAsync(id);
        }
        
        public void Guardar(IronMan.IronManEventoServicio.Evento e) {
            base.Channel.Guardar(e);
        }
        
        public System.Threading.Tasks.Task GuardarAsync(IronMan.IronManEventoServicio.Evento e) {
            return base.Channel.GuardarAsync(e);
        }
        
        public IronMan.IronManEventoServicio.Evento Obtener(int id) {
            return base.Channel.Obtener(id);
        }
        
        public System.Threading.Tasks.Task<IronMan.IronManEventoServicio.Evento> ObtenerAsync(int id) {
            return base.Channel.ObtenerAsync(id);
        }
        
        public IronMan.IronManEventoServicio.Evento[] Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<IronMan.IronManEventoServicio.Evento[]> ListarAsync() {
            return base.Channel.ListarAsync();
        }
    }
}
