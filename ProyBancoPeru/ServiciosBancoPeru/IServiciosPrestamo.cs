using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosPrestamo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosPrestamo
    {
        [OperationContract]
        List<PrestamoBE> GetAllPrestamosClienteFechasLINQ(
             int cod, DateTime ficini, DateTime fecfin);

        [OperationContract]
        List<PrestamoBE> GetAllPrestamosClienteSP(String dni);

        [OperationContract]
        List<PrestamoBE> GetAllPrestamoLINQ();
    }

    [DataContract]
    [Serializable]
    public class PrestamoBE
    {
        private Single mvarcod_prest;
        private DateTime mvarfec_prest;
        private Single mvarcod_cli;
        private Single mvarImporte;
        private Single mvarInteresImporte;
        private Single mvarImporteTotal;
        private String mvarest_prest;
        private String mvarnom_cli;
        private String mvarape_cli;

        [DataMember]
        public Single Cod_Prest
        {
            get { return mvarcod_prest; }
            set { mvarcod_prest = value; }
        }

        [DataMember]
        public DateTime Fec_Prest
        {
            get { return mvarfec_prest; }
            set { mvarfec_prest = value; }
        }

        [DataMember]
        public Single Cod_Cli
        {
            get { return mvarcod_cli; }
            set { mvarcod_cli = value; }
        }

        [DataMember]
        public Single Importe
        {
            get { return mvarImporte; }
            set { mvarImporte = value; }
        }

        [DataMember]
        public Single Interes_Importe
        {
            get { return mvarInteresImporte; }
            set { mvarInteresImporte = value; }
        }

        [DataMember]
        public Single Importe_Total
        {
            get { return mvarImporteTotal; }
            set { mvarImporteTotal = value; }
        }

        [DataMember]
        public String Est_Prest
        {
            get { return mvarest_prest; }
            set { mvarest_prest = value; }
        }

        [DataMember]
        public String Nombre_Cliente
        {
            get { return mvarnom_cli; }
            set { mvarnom_cli = value; }
        }

        [DataMember]
        public String Apellido_Cliente
        {
            get { return mvarape_cli; }
            set { mvarape_cli = value; }
        }




    }
}
