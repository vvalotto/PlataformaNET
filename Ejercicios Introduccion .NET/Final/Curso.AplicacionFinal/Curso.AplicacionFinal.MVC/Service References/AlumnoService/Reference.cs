﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.239
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Curso.AplicacionFinal.MVC.AlumnoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumnos", Namespace="http://schemas.datacontract.org/2004/07/Curso.AplicacionFinal.WCF.Modelo", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Alumnos : Curso.AplicacionFinal.MVC.AlumnoService.EntityObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaNacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NroLegajoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaNac {
            get {
                return this.FechaNacField;
            }
            set {
                if ((this.FechaNacField.Equals(value) != true)) {
                    this.FechaNacField = value;
                    this.RaisePropertyChanged("FechaNac");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NroLegajo {
            get {
                return this.NroLegajoField;
            }
            set {
                if ((this.NroLegajoField.Equals(value) != true)) {
                    this.NroLegajoField = value;
                    this.RaisePropertyChanged("NroLegajo");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Curso.AplicacionFinal.MVC.AlumnoService.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Curso.AplicacionFinal.MVC.AlumnoService.Alumnos))]
    public partial class StructuralObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Curso.AplicacionFinal.MVC.AlumnoService.Alumnos))]
    public partial class EntityObject : Curso.AplicacionFinal.MVC.AlumnoService.StructuralObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Curso.AplicacionFinal.MVC.AlumnoService.EntityKey EntityKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Curso.AplicacionFinal.MVC.AlumnoService.EntityKey EntityKey {
            get {
                return this.EntityKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyField, value) != true)) {
                    this.EntityKeyField = value;
                    this.RaisePropertyChanged("EntityKey");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKey", Namespace="http://schemas.datacontract.org/2004/07/System.Data", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class EntityKey : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntityContainerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Curso.AplicacionFinal.MVC.AlumnoService.EntityKeyMember> EntityKeyValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntitySetNameField;
        
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
        public string EntityContainerName {
            get {
                return this.EntityContainerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityContainerNameField, value) != true)) {
                    this.EntityContainerNameField = value;
                    this.RaisePropertyChanged("EntityContainerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Curso.AplicacionFinal.MVC.AlumnoService.EntityKeyMember> EntityKeyValues {
            get {
                return this.EntityKeyValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyValuesField, value) != true)) {
                    this.EntityKeyValuesField = value;
                    this.RaisePropertyChanged("EntityKeyValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntitySetName {
            get {
                return this.EntitySetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntitySetNameField, value) != true)) {
                    this.EntitySetNameField = value;
                    this.RaisePropertyChanged("EntitySetName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKeyMember", Namespace="http://schemas.datacontract.org/2004/07/System.Data")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Curso.AplicacionFinal.MVC.AlumnoService.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Curso.AplicacionFinal.MVC.AlumnoService.StructuralObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<Curso.AplicacionFinal.MVC.AlumnoService.Alumnos>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Curso.AplicacionFinal.MVC.AlumnoService.Alumnos))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Curso.AplicacionFinal.MVC.AlumnoService.EntityKey))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<Curso.AplicacionFinal.MVC.AlumnoService.EntityKeyMember>))]
    public partial class EntityKeyMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ValueField;
        
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
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AlumnoService.IAlumnoService")]
    public interface IAlumnoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoService/GetAlumnos", ReplyAction="http://tempuri.org/IAlumnoService/GetAlumnosResponse")]
        System.Collections.Generic.List<Curso.AplicacionFinal.MVC.AlumnoService.Alumnos> GetAlumnos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoService/GetAlumnoById", ReplyAction="http://tempuri.org/IAlumnoService/GetAlumnoByIdResponse")]
        Curso.AplicacionFinal.MVC.AlumnoService.Alumnos GetAlumnoById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoService/SaveAlumno", ReplyAction="http://tempuri.org/IAlumnoService/SaveAlumnoResponse")]
        Curso.AplicacionFinal.MVC.AlumnoService.Alumnos SaveAlumno(Curso.AplicacionFinal.MVC.AlumnoService.Alumnos alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnoService/DeleteAlumno", ReplyAction="http://tempuri.org/IAlumnoService/DeleteAlumnoResponse")]
        void DeleteAlumno(Curso.AplicacionFinal.MVC.AlumnoService.Alumnos alumno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlumnoServiceChannel : Curso.AplicacionFinal.MVC.AlumnoService.IAlumnoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlumnoServiceClient : System.ServiceModel.ClientBase<Curso.AplicacionFinal.MVC.AlumnoService.IAlumnoService>, Curso.AplicacionFinal.MVC.AlumnoService.IAlumnoService {
        
        public AlumnoServiceClient() {
        }
        
        public AlumnoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlumnoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Curso.AplicacionFinal.MVC.AlumnoService.Alumnos> GetAlumnos() {
            return base.Channel.GetAlumnos();
        }
        
        public Curso.AplicacionFinal.MVC.AlumnoService.Alumnos GetAlumnoById(int id) {
            return base.Channel.GetAlumnoById(id);
        }
        
        public Curso.AplicacionFinal.MVC.AlumnoService.Alumnos SaveAlumno(Curso.AplicacionFinal.MVC.AlumnoService.Alumnos alumno) {
            return base.Channel.SaveAlumno(alumno);
        }
        
        public void DeleteAlumno(Curso.AplicacionFinal.MVC.AlumnoService.Alumnos alumno) {
            base.Channel.DeleteAlumno(alumno);
        }
    }
}
