﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoPeru.ProxyCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteBE", Namespace="http://schemas.datacontract.org/2004/07/ServiciosBancoPeru")]
    [System.SerializableAttribute()]
    public partial class ClienteBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ape_CliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Cod_CliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CuentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Dir_CliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Dni_CliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_CliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tel_CliField;
        
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
        public string Ape_Cli {
            get {
                return this.Ape_CliField;
            }
            set {
                if ((object.ReferenceEquals(this.Ape_CliField, value) != true)) {
                    this.Ape_CliField = value;
                    this.RaisePropertyChanged("Ape_Cli");
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
        public string Cuenta {
            get {
                return this.CuentaField;
            }
            set {
                if ((object.ReferenceEquals(this.CuentaField, value) != true)) {
                    this.CuentaField = value;
                    this.RaisePropertyChanged("Cuenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dir_Cli {
            get {
                return this.Dir_CliField;
            }
            set {
                if ((object.ReferenceEquals(this.Dir_CliField, value) != true)) {
                    this.Dir_CliField = value;
                    this.RaisePropertyChanged("Dir_Cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dni_Cli {
            get {
                return this.Dni_CliField;
            }
            set {
                if ((object.ReferenceEquals(this.Dni_CliField, value) != true)) {
                    this.Dni_CliField = value;
                    this.RaisePropertyChanged("Dni_Cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_Cli {
            get {
                return this.Nom_CliField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_CliField, value) != true)) {
                    this.Nom_CliField = value;
                    this.RaisePropertyChanged("Nom_Cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel_Cli {
            get {
                return this.Tel_CliField;
            }
            set {
                if ((object.ReferenceEquals(this.Tel_CliField, value) != true)) {
                    this.Tel_CliField = value;
                    this.RaisePropertyChanged("Tel_Cli");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyCliente.IServiciosCliente")]
    public interface IServiciosCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/GetAllClienteLINQ", ReplyAction="http://tempuri.org/IServiciosCliente/GetAllClienteLINQResponse")]
        BancoPeru.ProxyCliente.ClienteBE[] GetAllClienteLINQ();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/GetAllClienteLINQ", ReplyAction="http://tempuri.org/IServiciosCliente/GetAllClienteLINQResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> GetAllClienteLINQAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/ListarNombresClienteLINQ", ReplyAction="http://tempuri.org/IServiciosCliente/ListarNombresClienteLINQResponse")]
        BancoPeru.ProxyCliente.ClienteBE[] ListarNombresClienteLINQ();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/ListarNombresClienteLINQ", ReplyAction="http://tempuri.org/IServiciosCliente/ListarNombresClienteLINQResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> ListarNombresClienteLINQAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/InsertCliente", ReplyAction="http://tempuri.org/IServiciosCliente/InsertClienteResponse")]
        bool InsertCliente(BancoPeru.ProxyCliente.ClienteBE objCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/InsertCliente", ReplyAction="http://tempuri.org/IServiciosCliente/InsertClienteResponse")]
        System.Threading.Tasks.Task<bool> InsertClienteAsync(BancoPeru.ProxyCliente.ClienteBE objCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/UpdateCliente", ReplyAction="http://tempuri.org/IServiciosCliente/UpdateClienteResponse")]
        bool UpdateCliente(BancoPeru.ProxyCliente.ClienteBE objCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/UpdateCliente", ReplyAction="http://tempuri.org/IServiciosCliente/UpdateClienteResponse")]
        System.Threading.Tasks.Task<bool> UpdateClienteAsync(BancoPeru.ProxyCliente.ClienteBE objCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/DeleteCliente", ReplyAction="http://tempuri.org/IServiciosCliente/DeleteClienteResponse")]
        bool DeleteCliente(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/DeleteCliente", ReplyAction="http://tempuri.org/IServiciosCliente/DeleteClienteResponse")]
        System.Threading.Tasks.Task<bool> DeleteClienteAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/BuscarCliente", ReplyAction="http://tempuri.org/IServiciosCliente/BuscarClienteResponse")]
        BancoPeru.ProxyCliente.ClienteBE BuscarCliente(int cod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/BuscarCliente", ReplyAction="http://tempuri.org/IServiciosCliente/BuscarClienteResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE> BuscarClienteAsync(int cod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/GetCliente", ReplyAction="http://tempuri.org/IServiciosCliente/GetClienteResponse")]
        BancoPeru.ProxyCliente.ClienteBE[] GetCliente(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/GetCliente", ReplyAction="http://tempuri.org/IServiciosCliente/GetClienteResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> GetClienteAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/GetAllCuentaCliente", ReplyAction="http://tempuri.org/IServiciosCliente/GetAllCuentaClienteResponse")]
        BancoPeru.ProxyCliente.ClienteBE[] GetAllCuentaCliente(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/GetAllCuentaCliente", ReplyAction="http://tempuri.org/IServiciosCliente/GetAllCuentaClienteResponse")]
        System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> GetAllCuentaClienteAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/CalcularDeudaCliente", ReplyAction="http://tempuri.org/IServiciosCliente/CalcularDeudaClienteResponse")]
        float CalcularDeudaCliente(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosCliente/CalcularDeudaCliente", ReplyAction="http://tempuri.org/IServiciosCliente/CalcularDeudaClienteResponse")]
        System.Threading.Tasks.Task<float> CalcularDeudaClienteAsync(string dni);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiciosClienteChannel : BancoPeru.ProxyCliente.IServiciosCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiciosClienteClient : System.ServiceModel.ClientBase<BancoPeru.ProxyCliente.IServiciosCliente>, BancoPeru.ProxyCliente.IServiciosCliente {
        
        public ServiciosClienteClient() {
        }
        
        public ServiciosClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiciosClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BancoPeru.ProxyCliente.ClienteBE[] GetAllClienteLINQ() {
            return base.Channel.GetAllClienteLINQ();
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> GetAllClienteLINQAsync() {
            return base.Channel.GetAllClienteLINQAsync();
        }
        
        public BancoPeru.ProxyCliente.ClienteBE[] ListarNombresClienteLINQ() {
            return base.Channel.ListarNombresClienteLINQ();
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> ListarNombresClienteLINQAsync() {
            return base.Channel.ListarNombresClienteLINQAsync();
        }
        
        public bool InsertCliente(BancoPeru.ProxyCliente.ClienteBE objCliente) {
            return base.Channel.InsertCliente(objCliente);
        }
        
        public System.Threading.Tasks.Task<bool> InsertClienteAsync(BancoPeru.ProxyCliente.ClienteBE objCliente) {
            return base.Channel.InsertClienteAsync(objCliente);
        }
        
        public bool UpdateCliente(BancoPeru.ProxyCliente.ClienteBE objCliente) {
            return base.Channel.UpdateCliente(objCliente);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateClienteAsync(BancoPeru.ProxyCliente.ClienteBE objCliente) {
            return base.Channel.UpdateClienteAsync(objCliente);
        }
        
        public bool DeleteCliente(string dni) {
            return base.Channel.DeleteCliente(dni);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClienteAsync(string dni) {
            return base.Channel.DeleteClienteAsync(dni);
        }
        
        public BancoPeru.ProxyCliente.ClienteBE BuscarCliente(int cod) {
            return base.Channel.BuscarCliente(cod);
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE> BuscarClienteAsync(int cod) {
            return base.Channel.BuscarClienteAsync(cod);
        }
        
        public BancoPeru.ProxyCliente.ClienteBE[] GetCliente(string dni) {
            return base.Channel.GetCliente(dni);
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> GetClienteAsync(string dni) {
            return base.Channel.GetClienteAsync(dni);
        }
        
        public BancoPeru.ProxyCliente.ClienteBE[] GetAllCuentaCliente(string dni) {
            return base.Channel.GetAllCuentaCliente(dni);
        }
        
        public System.Threading.Tasks.Task<BancoPeru.ProxyCliente.ClienteBE[]> GetAllCuentaClienteAsync(string dni) {
            return base.Channel.GetAllCuentaClienteAsync(dni);
        }
        
        public float CalcularDeudaCliente(string dni) {
            return base.Channel.CalcularDeudaCliente(dni);
        }
        
        public System.Threading.Tasks.Task<float> CalcularDeudaClienteAsync(string dni) {
            return base.Channel.CalcularDeudaClienteAsync(dni);
        }
    }
}
