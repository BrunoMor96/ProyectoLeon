﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoPeru.ProxyPrestamo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PrestamoBE", Namespace="http://schemas.datacontract.org/2004/07/ServiciosBancoPeru")]
    [System.SerializableAttribute()]
    public partial class PrestamoBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Apellido_ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Cod_CliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Cod_PrestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Est_PrestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_PrestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ImporteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Importe_TotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Interes_ImporteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_ClienteField;
        
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
        public string Apellido_Cliente {
            get {
                return this.Apellido_ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.Apellido_ClienteField, value) != true)) {
                    this.Apellido_ClienteField = value;
                    this.RaisePropertyChanged("Apellido_Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Cod_Cli {
            get {
                return this.Cod_CliField;
            }
            set {
                if ((this.Cod_CliField.Equals(value) != true)) {
                    this.Cod_CliField = value;
                    this.RaisePropertyChanged("Cod_Cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Cod_Prest {
            get {
                return this.Cod_PrestField;
            }
            set {
                if ((this.Cod_PrestField.Equals(value) != true)) {
                    this.Cod_PrestField = value;
                    this.RaisePropertyChanged("Cod_Prest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Est_Prest {
            get {
                return this.Est_PrestField;
            }
            set {
                if ((object.ReferenceEquals(this.Est_PrestField, value) != true)) {
                    this.Est_PrestField = value;
                    this.RaisePropertyChanged("Est_Prest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Prest {
            get {
                return this.Fec_PrestField;
            }
            set {
                if ((this.Fec_PrestField.Equals(value) != true)) {
                    this.Fec_PrestField = value;
                    this.RaisePropertyChanged("Fec_Prest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Importe {
            get {
                return this.ImporteField;
            }
            set {
                if ((this.ImporteField.Equals(value) != true)) {
                    this.ImporteField = value;
                    this.RaisePropertyChanged("Importe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Importe_Total {
            get {
                return this.Importe_TotalField;
            }
            set {
                if ((this.Importe_TotalField.Equals(value) != true)) {
                    this.Importe_TotalField = value;
                    this.RaisePropertyChanged("Importe_Total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Interes_Importe {
            get {
                return this.Interes_ImporteField;
            }
            set {
                if ((this.Interes_ImporteField.Equals(value) != true)) {
                    this.Interes_ImporteField = value;
                    this.RaisePropertyChanged("Interes_Importe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Cliente {
            get {
                return this.Nombre_ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_ClienteField, value) != true)) {
                    this.Nombre_ClienteField = value;
                    this.RaisePropertyChanged("Nombre_Cliente");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyPrestamo.IServiciosPrestamo")]
    public interface IServiciosPrestamo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteFechasLINQ", ReplyAction="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteFechasLINQResponse")]
        BancoPeru.ProxyPrestamo.PrestamoBE[] GetAllPrestamosClienteFechasLINQ(int cod, System.DateTime ficini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteFechasLINQ", ReplyAction="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteFechasLINQResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyPrestamo.PrestamoBE[]> GetAllPrestamosClienteFechasLINQAsync(int cod, System.DateTime ficini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteSP", ReplyAction="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteSPResponse")]
        BancoPeru.ProxyPrestamo.PrestamoBE[] GetAllPrestamosClienteSP(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteSP", ReplyAction="http://tempuri.org/IServiciosPrestamo/GetAllPrestamosClienteSPResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyPrestamo.PrestamoBE[]> GetAllPrestamosClienteSPAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosPrestamo/GetAllPrestamoLINQ", ReplyAction="http://tempuri.org/IServiciosPrestamo/GetAllPrestamoLINQResponse")]
        BancoPeru.ProxyPrestamo.PrestamoBE[] GetAllPrestamoLINQ();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosPrestamo/GetAllPrestamoLINQ", ReplyAction="http://tempuri.org/IServiciosPrestamo/GetAllPrestamoLINQResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyPrestamo.PrestamoBE[]> GetAllPrestamoLINQAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiciosPrestamoChannel : BancoPeru.ProxyPrestamo.IServiciosPrestamo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiciosPrestamoClient : System.ServiceModel.ClientBase<BancoPeru.ProxyPrestamo.IServiciosPrestamo>, BancoPeru.ProxyPrestamo.IServiciosPrestamo {
        
        public ServiciosPrestamoClient() {
        }
        
        public ServiciosPrestamoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiciosPrestamoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosPrestamoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosPrestamoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BancoPeru.ProxyPrestamo.PrestamoBE[] GetAllPrestamosClienteFechasLINQ(int cod, System.DateTime ficini, System.DateTime fecfin) {
            return base.Channel.GetAllPrestamosClienteFechasLINQ(cod, ficini, fecfin);
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyPrestamo.PrestamoBE[]> GetAllPrestamosClienteFechasLINQAsync(int cod, System.DateTime ficini, System.DateTime fecfin) {
            return base.Channel.GetAllPrestamosClienteFechasLINQAsync(cod, ficini, fecfin);
        }
        
        public BancoPeru.ProxyPrestamo.PrestamoBE[] GetAllPrestamosClienteSP(string dni) {
            return base.Channel.GetAllPrestamosClienteSP(dni);
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyPrestamo.PrestamoBE[]> GetAllPrestamosClienteSPAsync(string dni) {
            return base.Channel.GetAllPrestamosClienteSPAsync(dni);
        }
        
        public BancoPeru.ProxyPrestamo.PrestamoBE[] GetAllPrestamoLINQ() {
            return base.Channel.GetAllPrestamoLINQ();
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyPrestamo.PrestamoBE[]> GetAllPrestamoLINQAsync() {
            return base.Channel.GetAllPrestamoLINQAsync();
        }
    }
}
