using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosBancoPeru
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosPrestamo" en el código y en el archivo de configuración a la vez.
    public class ServiciosPrestamo : IServiciosPrestamo
    {
        public List<PrestamoBE> GetAllPrestamosClienteFechasLINQ(int cod, DateTime fecini, DateTime fecfin)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<PrestamoBE> objListaPrestamosBE = new List<PrestamoBE>();

            try
            {
                var query = (from Prest in MisDatos.vw_VistaPrestamos
                             where Prest.IdCLiente == cod &&
                             Prest.FechaPrestamo >= fecini &&
                             Prest.FechaPrestamo <= fecfin
                             select new
                             {
                                 CodigoPrestamo = Prest.IdPrestamo,
                                 FechaPresta = Prest.FechaPrestamo,
                                 IMporte = Prest.Importe,
                                 InteresImporte = Prest.Interestotal,
                                 ImporteTotal = Prest.Importetotal,
                                 Nombres = Prest.NombresCliente

                             }

                    );

                foreach (var resultado in query)
                {

                    PrestamoBE objPrestamoBE = new PrestamoBE();
                    objPrestamoBE.Cod_Prest = resultado.CodigoPrestamo;
                    objPrestamoBE.Fec_Prest = Convert.ToDateTime(resultado.FechaPresta);
                    objPrestamoBE.Importe = Convert.ToSingle(resultado.IMporte);
                    objPrestamoBE.Interes_Importe = Convert.ToSingle(resultado.InteresImporte);
                    objPrestamoBE.Importe_Total = Convert.ToSingle(resultado.ImporteTotal);
                    objPrestamoBE.Nombre_Cliente = resultado.Nombres;

                    objListaPrestamosBE.Add(objPrestamoBE);

                }

                return objListaPrestamosBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }



        }

        public List<PrestamoBE> GetAllPrestamosClienteSP(String dni)
        {
            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<PrestamoBE> objListaPrestamosBE = new List<PrestamoBE>();

            try
            {
                var query = MisDatos.usp_ListarPrestamos(dni);
                foreach (var resultado in query)
                {
                    PrestamoBE objPrestamoBE = new PrestamoBE();
                    objPrestamoBE.Cod_Prest = Convert.ToSingle(resultado.idPrestamo);
                    objPrestamoBE.Nombre_Cliente = resultado.NombresCliente;
                    objPrestamoBE.Fec_Prest = Convert.ToDateTime(resultado.FechaPrestamo);
                    objPrestamoBE.Importe = Convert.ToSingle(resultado.Importe);
                    objPrestamoBE.Interes_Importe = Convert.ToSingle(resultado.Interestotal);
                    objPrestamoBE.Importe_Total = Convert.ToSingle(resultado.Importetotal);
                    objPrestamoBE.Est_Prest = resultado.Estado;

                    objListaPrestamosBE.Add(objPrestamoBE);

                }
                return objListaPrestamosBE;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<PrestamoBE> GetAllPrestamoLINQ()
        {

            BancoPeruEntitie MisDatos = new BancoPeruEntitie();
            List<PrestamoBE> objListaPrestamosBE = new List<PrestamoBE>();


            try
            {
                var query = from MiPrestamo in MisDatos.vw_VistaPrestamos
                            orderby MiPrestamo.NombresCliente
                            select new
                            {
                                Codigo = MiPrestamo.IdPrestamo,
                                Nombres = MiPrestamo.NombresCliente,
                                Fecha = MiPrestamo.FechaPrestamo,
                                Importe = MiPrestamo.Importe,
                                Interes = MiPrestamo.Interestotal,
                                ImporteTotal = MiPrestamo.Importetotal,
                                Estado = MiPrestamo.Estado

                            };
                foreach (var resultado in query)
                {
                    PrestamoBE objPrestamoBE = new PrestamoBE();
                    objPrestamoBE.Cod_Cli = resultado.Codigo;
                    objPrestamoBE.Nombre_Cliente = resultado.Nombres;
                    objPrestamoBE.Fec_Prest = resultado.Fecha;
                    objPrestamoBE.Importe = resultado.Importe;
                    objPrestamoBE.Interes_Importe = Convert.ToSingle(resultado.Interes);
                    objPrestamoBE.Importe_Total = Convert.ToSingle(resultado.ImporteTotal);
                    objPrestamoBE.Est_Prest = resultado.Estado;


                    objListaPrestamosBE.Add(objPrestamoBE);

                }
                return objListaPrestamosBE;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);


            }

        }

        
    }
}
