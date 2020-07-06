using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosEmpleado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosEmpleado
    {
        [OperationContract]
        Boolean InsertEmpleado(EmpleadoBE objCliente);

        [OperationContract]
        List<EmpleadoBE> GetAllEmpleadoLINQ();

        [OperationContract]
        List<EmpleadoBE> ListarNombresEmpleadoLINQ();

        [OperationContract]
        List<EmpleadoBE> GetClienteSucursal(string dni);

        [OperationContract]
        List<EmpleadoBE> GetEmpleado(String dni);


    }

    public class EmpleadoBE
    {
        private Single mvarcod_emp;
        private String mvardni_emp;
        private String mvarnom_emp;
        private String mvarape_emp;
        private String mvartel_emp;
        private String mvaremail_emp;
        private String mvardir_emp;
        private Single mvarsue_emp;
        private String mvarsucursal;
        private String mvardepartamento;
        private DateTime mvarfec_ing;
        private Single mvarcod_depa;

        [DataMember]
        public Single Cod_Emp
        {
            get { return mvarcod_emp; }
            set { mvarcod_emp = value; }
        }
        [DataMember]
        public Single Cod_Depa
        {
            get { return mvarcod_depa; }
            set { mvarcod_depa = value; }
        }
        [DataMember]
        public String Dni_Emp
        {
            get { return mvardni_emp; }
            set { mvardni_emp = value; }
        }
        [DataMember]
        public String Nom_Emp
        {
            get { return mvarnom_emp; }
            set { mvarnom_emp = value; }
        }
        [DataMember]
        public String Ape_Emp
        {
            get { return mvarape_emp; }
            set { mvarape_emp = value; }
        }
        [DataMember]
        public String Tel_Emp
        {
            get { return mvartel_emp; }
            set { mvartel_emp = value; }
        }
        [DataMember]
        public String Email_Emp
        {
            get { return mvaremail_emp; }
            set { mvaremail_emp = value; }
        }
        [DataMember]
        public String Dir_Emp
        {
            get { return mvardir_emp; }
            set { mvardir_emp = value; }
        }
        [DataMember]
        public Single Sue_Emp
        {
            get { return mvarsue_emp; }
            set { mvarsue_emp = value; }
        }
        [DataMember]
        public String Sucursal
        {
            get { return mvarsucursal; }
            set { mvarsucursal = value; }
        }
        [DataMember]
        public String Departamento
        {
            get { return mvardepartamento; }
            set { mvardepartamento = value; }
        }
        [DataMember]
        public DateTime Fec_Ing
        {
           get { return mvarfec_ing; }
            set { mvarfec_ing = value; }
        }


    }
}
