using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosPago" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosPago
    {
        [OperationContract]
        List<PagoBE> ListarPagosPendientesClienteSP(String dni);

        [OperationContract]
        List<PagoBE> ListarPagosVencidosClienteLINQ(String dni);

        [OperationContract]
        List<PagoBE> ListarPagosClienteLINQ(String dni);
    }

    public class PagoBE
    {
        private Single mvarcod_pago;
        private Single mvarnrcuo_pago;
        private Single mvarimporte_pago;
        private DateTime mvarfec_pago;
        private DateTime mvarfec_ven;
        private String mvarest_pago;
        private Single mvarcod_prest;
        private String mvardni_cli;
        private String mvarnom_cli;

        [DataMember]
        public Single Cod_Pago
        {
            get { return mvarcod_pago; }
            set { mvarcod_pago = value; }
        }
        [DataMember]
        public Single Cuo_Pago
        {
            get { return mvarnrcuo_pago; }
            set { mvarnrcuo_pago = value; }
        }
        [DataMember]
        public Single Importe_Pago
        {
            get { return mvarimporte_pago; }
            set { mvarimporte_pago = value; }
        }
        [DataMember]
        public DateTime Fecha_Pago
        {
            get { return mvarfec_pago; }
            set { mvarfec_pago = value; }
        }

        [DataMember]
        public DateTime Fecha_Ven
        {
            get { return mvarfec_ven; }
            set { mvarfec_ven = value; }
        }

        [DataMember]
        public String Est_Pago
        {
            get { return mvarest_pago; }
            set { mvarest_pago = value; }

        }

        [DataMember]
        public Single Cod_Prest
        {
            get { return mvarcod_prest; }
            set { mvarcod_prest = value; }
        }

        [DataMember]
        public String Dni_Cliente
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
    }
}
