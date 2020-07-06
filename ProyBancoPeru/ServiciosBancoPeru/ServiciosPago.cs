using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosPago" en el código y en el archivo de configuración a la vez.
    public class ServiciosPago : IServiciosPago
    {
        public List<PagoBE> ListarPagosPendientesClienteSP(String dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<PagoBE> objListaPagoBE = new List<PagoBE>();

            try
            {
                var query = MisDatos.usp_PagosPendientes(dni);

                foreach (var resultado in query)
                {
                    PagoBE objPagoBE = new PagoBE();
                    objPagoBE.Cod_Pago = Convert.ToSingle(resultado.IdPago);
                    objPagoBE.Cod_Prest = Convert.ToSingle(resultado.IdPrestamo);
                    objPagoBE.Dni_Cliente = resultado.DNICliente;
                    objPagoBE.Fecha_Pago = Convert.ToDateTime(resultado.FechaPago);
                    objPagoBE.Importe_Pago = Convert.ToSingle(resultado.ImportePago);
                    objPagoBE.Est_Pago = resultado.Estado;

                    objListaPagoBE.Add(objPagoBE);

                }
                return objListaPagoBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public List<PagoBE> ListarPagosVencidosClienteLINQ(String dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<PagoBE> objListaPagosBE = new List<PagoBE>();

            try
            {
                var query = (from Pago in MisDatos.vw_VistaPagos
                             where Pago.DNICliente == dni &&
                             Pago.Estado == "Vencido"
                             select new
                             {
                                 Codigo = Pago.IdPago,
                                 Fecha = Pago.FechaPago,
                                 Dni = Pago.DNICliente,
                                 Nombres = Pago.Nombres,
                                 Importe = Pago.ImportePago,
                                 Estado = Pago.Estado
                             }


                             );

                foreach (var resultado in query)
                {
                    PagoBE objPagoBE = new PagoBE();
                    objPagoBE.Cod_Pago = resultado.Codigo;
                    objPagoBE.Fecha_Pago = resultado.Fecha;
                    objPagoBE.Dni_Cliente = resultado.Dni;
                    objPagoBE.Nom_Cli = resultado.Nombres;
                    objPagoBE.Importe_Pago = resultado.Importe;
                    objPagoBE.Est_Pago = resultado.Estado;

                    objListaPagosBE.Add(objPagoBE);
                }

                return objListaPagosBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }


        }

        public List<PagoBE> ListarPagosClienteLINQ(String dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<PagoBE> objListaPagosBE = new List<PagoBE>();

            try
            {
                var query = (from Pago in MisDatos.vw_VistaPagos
                             where Pago.DNICliente == dni
                             select new
                             {
                                 Codigo = Pago.IdPago,
                                 Fecha = Pago.FechaPago,
                                 Dni = Pago.DNICliente,
                                 Nombres = Pago.Nombres,
                                 Importe = Pago.ImportePago,
                                 Estado = Pago.Estado
                             }


                             );

                foreach (var resultado in query)
                {
                    PagoBE objPagoBE = new PagoBE();
                    objPagoBE.Cod_Pago = resultado.Codigo;
                    objPagoBE.Fecha_Pago = resultado.Fecha;
                    objPagoBE.Dni_Cliente = resultado.Dni;
                    objPagoBE.Nom_Cli = resultado.Nombres;
                    objPagoBE.Importe_Pago = resultado.Importe;
                    objPagoBE.Est_Pago = resultado.Estado;

                    objListaPagosBE.Add(objPagoBE);
                }

                return objListaPagosBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }


        }
    }
}
