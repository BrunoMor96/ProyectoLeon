using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core.Objects;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosCliente" en el código y en el archivo de configuración a la vez.
    public class ServiciosCliente : IServiciosCliente
    {
        Boolean blnexito;

        public List<ClienteBE> GetAllClienteLINQ()
        {

            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<ClienteBE> objListaClientesBE = new List<ClienteBE>();


            try
            {
                var query = from MisClientes in MisDatos.CLIENTE
                            orderby MisClientes.DNICliente
                            select new
                            {
                                Codigo = MisClientes.IdCliente,
                                DNI = MisClientes.DNICliente,
                                Nombres = MisClientes.NombreCliente + " " + MisClientes.ApellidoCliente,
                                Direccion = MisClientes.DireccionCliente,
                                Telefono = MisClientes.TelefonoCliente,
                                Email = MisClientes.EmailCLiente,


                            };
                foreach (var resultado in query)
                {
                    ClienteBE objClienteBE = new ClienteBE();
                    objClienteBE.Cod_Cli = resultado.Codigo;
                    objClienteBE.Dni_Cli = resultado.DNI;
                    objClienteBE.Nom_Cli = resultado.Nombres;
                    objClienteBE.Dir_Cli = resultado.Direccion;
                    objClienteBE.Tel_Cli = resultado.Telefono;
                    //objClienteBE.Email_Cli = resultado.Email;



                    objListaClientesBE.Add(objClienteBE);

                }
                return objListaClientesBE;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);


            }

        }


        public List<ClienteBE> ListarNombresClienteLINQ()
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<ClienteBE> objListaCliente = new List<ClienteBE>();

            try
            {
                var query = from miCliente in MisDatos.CLIENTE
                            orderby miCliente.NombreCliente
                            select new
                            {
                                Codigo = miCliente.IdCliente,
                                Nombres = miCliente.NombreCliente + " " + miCliente.ApellidoCliente

                            };
                foreach (var resultado in query)
                {
                    ClienteBE objCLienteBE = new ClienteBE();
                    objCLienteBE.Cod_Cli = resultado.Codigo;
                    objCLienteBE.Nom_Cli = resultado.Nombres;


                    objListaCliente.Add(objCLienteBE);

                }
                return objListaCliente;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);


            }
        }

       

        public List<ClienteBE> GetCliente (String dni)
        {
          

            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            ClienteBE objClienteBE = new ClienteBE();
            List<ClienteBE> objLista = new List<ClienteBE>();

            try
            {
                var query = MisDatos.usp_ClienteConsultar(dni);
                foreach (var resultado in query)
                {
                    objClienteBE.Cod_Cli = resultado.IdCliente;
                    objClienteBE.Nom_Cli = resultado.Nombre;
                    objClienteBE.Dni_Cli = resultado.DNICliente;
                    objClienteBE.Dir_Cli = resultado.DireccionCliente;
                    objClienteBE.Tel_Cli = resultado.TelefonoCliente;
                    objLista.Add(objClienteBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objLista;
        }

        public List<ClienteBE> GetAllCuentaCliente(String dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<ClienteBE> objListaClienteBE = new List<ClienteBE>();

            try
            {
                var query = MisDatos.usp_CuentaCliente(dni);
                foreach (var resultado in query)
                {
                    ClienteBE objClienteBE = new ClienteBE();
                    objClienteBE.Nom_Cli = resultado.NombreCliente;
                    objClienteBE.Ape_Cli = resultado.ApellidoCliente;
                    objClienteBE.Cuenta = resultado.CUENTA;
                    objListaClienteBE.Add(objClienteBE);

                }
                return objListaClienteBE;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ClienteBE BuscarCliente(int cod)
        {


            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            ClienteBE objClienteBE = new ClienteBE();

            try
            {
                vw_Cliente objAlumno = (from obj in MisDatos.vw_Cliente
                                        where obj.IdCliente == cod
                                        select obj).FirstOrDefault();
                objClienteBE.Cod_Cli = objAlumno.IdCliente;
                objClienteBE.Dni_Cli = objAlumno.DNICliente;
                objClienteBE.Nom_Cli = objAlumno.NombreCliente;
                objClienteBE.Ape_Cli = objAlumno.ApellidoCliente;
                objClienteBE.Dir_Cli = objAlumno.DireccionCliente;
                objClienteBE.Tel_Cli = objAlumno.TelefonoCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objClienteBE;
        }

        public bool InsertCliente(ClienteBE objCliente)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            try
            {
                CLIENTE objClientes = new CLIENTE();

                objClientes.IdCliente = 0;
                objClientes.DNICliente = objCliente.Dni_Cli;
                objClientes.NombreCliente = objCliente.Nom_Cli;
                objClientes.ApellidoCliente = objCliente.Ape_Cli;
                objClientes.DireccionCliente = objCliente.Dir_Cli;
                objClientes.TelefonoCliente = objCliente.Tel_Cli;

                MisDatos.CLIENTE.Add(objClientes);
                MisDatos.SaveChanges();
                blnexito = true;
            }
            catch (Exception ex)
            {
                blnexito = false;
            }
            return blnexito;
        }

        public bool UpdateCliente(ClienteBE objCliente)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            try
            {
                MisDatos.usp_ClienteActualizar( Convert.ToInt32(objCliente.Cod_Cli), Convert.ToString(objCliente.Dni_Cli), objCliente.Nom_Cli,
                    objCliente.Ape_Cli, objCliente.Dir_Cli, objCliente.Tel_Cli);

                MisDatos.SaveChanges();
                blnexito = true;

            }
            catch (Exception ex)
            {
                blnexito = false;
                throw ex;
            }
            return blnexito;
        }

        public bool DeleteCliente(String dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            try
            {
                CLIENTE objCliente = (from objCli in MisDatos.CLIENTE
                                    where objCli.DNICliente == dni
                                      select objCli).FirstOrDefault();
                MisDatos.CLIENTE.Remove(objCliente);
                MisDatos.SaveChanges();
                blnexito = true;
            }
            catch (Exception ex)
            {
                blnexito = false;
                throw ex;
            }
            return blnexito;
        }

        public Single CalcularDeudaCliente(String dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            Single sngDeuda = 0;

            try
            {

                ObjectParameter parDeuda = new ObjectParameter("deuda", typeof(Single));
                MisDatos.usp_DeudaCliente(dni, parDeuda);
                sngDeuda = Convert.ToSingle(parDeuda.Value);

                return sngDeuda;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }




        }

    }
    }

