using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosEmpleado" en el código y en el archivo de configuración a la vez.
    public class ServiciosEmpleado : IServiciosEmpleado
    {
        Boolean blnexito;
        

        public List<EmpleadoBE> GetAllEmpleadoLINQ()
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<EmpleadoBE> objListaEmpleadosBE = new List<EmpleadoBE>();

            try
            {

                var query = from MisEmpleados in MisDatos.EMPLEADO
                            
                            select new
                            {
                                Codigo = MisEmpleados.IdEmpleado,
                                DNI = MisEmpleados.DNIEmpleado,
                                Nombre = MisEmpleados.NombreEmpleado,
                                Telefono = MisEmpleados.TelefonoEmpleado,
                                Email = MisEmpleados.EmailEmpleado,
                                Direccion = MisEmpleados.DireccionEmpleado,
                                //Sueldo = MisEmpleados.SueldoEmpleado,
                                //FechaIngreso = MisEmpleados.FechaIngreso,
                                //FechaSalida = MisEmpleados.FechaSalida
                            };

                foreach (var resultado in query)
                {
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.Cod_Emp = resultado.Codigo;
                    objEmpleadoBE.Dni_Emp = resultado.DNI;
                    objEmpleadoBE.Nom_Emp = resultado.Nombre;
                    objEmpleadoBE.Tel_Emp = resultado.Telefono;
                    objEmpleadoBE.Email_Emp = resultado.Email;
                    objEmpleadoBE.Dir_Emp = resultado.Direccion;
                    //objEmpleadoBE.Sue_Emp = resultado.Sueldo;
                    //objEmpleadoBE.Fec_Ing = resultado.FechaIngreso;

                    objListaEmpleadosBE.Add(objEmpleadoBE);
                }

                return objListaEmpleadosBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<EmpleadoBE> GetClienteSucursal(string dni)
        {
            
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<EmpleadoBE> objListaEmpeladoBE = new List<EmpleadoBE>();

            try
            {
                //HACEMOS LA CONSULTA CON LINQ
                var query = (from Empleado in MisDatos.vw_EmpleadoDepartamentoSucursal
                             where Empleado.DNIEmpleado == dni 
                             select new
                             {
                                 Numero = Empleado.DNIEmpleado,
                                 Nombre = Empleado.NombreEmpleado,
                                 Apellido = Empleado.ApellidoEmplado,
                                 Sucursal = Empleado.NombreSucursal,
                                 Departamento = Empleado.NombreDepartamento,
                             }
                           );

                //DEVOLVEMOS LA LISTA DE FACTURAS
                foreach (var resultado in query)
                {
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.Dni_Emp = resultado.Numero;
                    objEmpleadoBE.Nom_Emp = resultado.Nombre;
                    objEmpleadoBE.Ape_Emp = resultado.Apellido;
                    objEmpleadoBE.Sucursal = resultado.Sucursal;
                    objEmpleadoBE.Departamento = resultado.Departamento;


                    //AGREGO LA INSTANCIA A LA LISTA DE FACTURAS
                    objListaEmpeladoBE.Add(objEmpleadoBE);

                }
                return objListaEmpeladoBE;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmpleadoBE> GetEmpleado(string dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            EmpleadoBE objEmpleadoBE = new EmpleadoBE();
            List<EmpleadoBE> objLista = new List<EmpleadoBE>();

            try
            {
                var query = MisDatos.usp_EmpleadoConsultar(dni);
                foreach (var resultado in query)
                {
                    objEmpleadoBE.Cod_Emp = resultado.IdEmpleado;
                    objEmpleadoBE.Dni_Emp = resultado.DNIEmpleado;
                    objEmpleadoBE.Nom_Emp = resultado.Nombre;
                    objEmpleadoBE.Dir_Emp = resultado.DireccionEmpleado;
                    objEmpleadoBE.Tel_Emp = resultado.TelefonoEmpleado;
                    objLista.Add(objEmpleadoBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objLista;
        }

        public bool InsertEmpleado(EmpleadoBE objCliente)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            try
            {
                EMPLEADO objEmpleado = new EMPLEADO();

                objEmpleado.IdEmpleado = 0;
                objEmpleado.NombreEmpleado = objCliente.Nom_Emp;
                objEmpleado.ApellidoEmplado = objCliente.Ape_Emp;
                objEmpleado.TelefonoEmpleado = objCliente.Tel_Emp;
                objEmpleado.DireccionEmpleado = objCliente.Dir_Emp;
                objEmpleado.SueldoEmpleado =Convert.ToInt32(objCliente.Sue_Emp);
                objEmpleado.FechaIngreso = objCliente.Fec_Ing;
                objEmpleado.IdDepartamento = 0;
                //objAlumno.EstadoAlu = "R";

                MisDatos.EMPLEADO.Add(objEmpleado);
                MisDatos.SaveChanges();
                blnexito = true;
            }
            catch (Exception ex)
            {
                blnexito = false;
            }
            return blnexito;
        }

        public List<EmpleadoBE> ListarNombresEmpleadoLINQ()
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<EmpleadoBE> objListaEmpleado = new List<EmpleadoBE>();

            try
            {

                var query = from miEmpleado in MisDatos.EMPLEADO
                            orderby miEmpleado.NombreEmpleado
                            select new
                            {
                                Codigo = miEmpleado.IdEmpleado,
                                Nombre = miEmpleado.NombreEmpleado + " " + miEmpleado.ApellidoEmplado
                            };

                foreach (var resultado in query)
                {
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.Cod_Emp = resultado.Codigo;
                    objEmpleadoBE.Nom_Emp = resultado.Nombre;

                    objListaEmpleado.Add(objEmpleadoBE);

                }

                return objListaEmpleado;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}

