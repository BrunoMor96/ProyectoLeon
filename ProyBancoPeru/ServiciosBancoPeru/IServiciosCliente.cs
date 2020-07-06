using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosCliente
    {
        [OperationContract]
        List<ClienteBE> GetAllClienteLINQ();

        [OperationContract]
        List<ClienteBE> ListarNombresClienteLINQ();

        [OperationContract]
        Boolean InsertCliente(ClienteBE objCliente);

        [OperationContract]
        Boolean UpdateCliente(ClienteBE objCliente);

        [OperationContract]
        Boolean DeleteCliente(String dni);

        [OperationContract]
        ClienteBE BuscarCliente(int cod);

        [OperationContract]
        List<ClienteBE> GetCliente(String dni);

        [OperationContract]
        List<ClienteBE> GetAllCuentaCliente(String dni);

        [OperationContract]
        Single CalcularDeudaCliente(String dni);
        

    }

    [DataContract]
    [Serializable]
    public class ClienteBE
    {
        private Single mvarcod_cli;
        private String mvardni_cli;
        private String mvarnom_cli;
        private String mvarape_cli;
        private String mvardir_cli;
        private String mvartel_cli;
        private String mvarcuenta;


        [DataMember]
        public Single Cod_Cli
        {
            get { return mvarcod_cli; }
            set { mvarcod_cli = value; }
        }
        [DataMember]
        public String Dni_Cli
        {
            get { return mvardni_cli; }
            set { mvardni_cli = value; }
        }
        [DataMember]
        public String Nom_Cli
        {
            get { return mvarnom_cli; }
            set { mvarnom_cli = value; }
        }

        [DataMember]
        public String Ape_Cli
        {
            get { return mvarape_cli; }
            set { mvarape_cli = value; }
        }

        [DataMember]
        public String Dir_Cli
        {
            get { return mvardir_cli; }
            set { mvardir_cli = value; }
        }

        [DataMember]
        public String Tel_Cli
        {
            get { return mvartel_cli; }
            set { mvartel_cli = value; }
        }

        [DataMember]
        public String Cuenta
        {
            get { return mvarcuenta; }
            set { mvarcuenta = value; }
        }


    }
}
