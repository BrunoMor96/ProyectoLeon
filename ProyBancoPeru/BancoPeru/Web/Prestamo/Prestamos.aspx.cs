using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoPeru.Web.Prestamo
{
    public partial class Prestamos : System.Web.UI.Page
    {
        ProxyPrestamo.ServiciosPrestamoClient objServicioPrestamo = new ProxyPrestamo.ServiciosPrestamoClient();
        ProxyPrestamo.PrestamoBE objPrestamo = new ProxyPrestamo.PrestamoBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {
                    Enlazar();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error" + ex.Message;
                }

            }
        }

        private void Enlazar()
        {
            grvDatos.DataSource = objServicioPrestamo.GetAllPrestamoLINQ();
            grvDatos.DataBind();
        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objServicioPrestamo.GetAllPrestamosClienteSP(txtCodigo.Text);
                grvDatos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }




        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Hide();
        }


       

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objPrestamo.Cod_Cli = Convert.ToInt64(txtCod.Text);
                objPrestamo.Fec_Prest = Convert.ToDateTime(txtIni.Text);
                objPrestamo.Fec_Prest = Convert.ToDateTime(txtFin.Text);

                grvDatos.DataSource = objServicioPrestamo.GetAllPrestamosClienteFechasLINQ
                    (Convert.ToInt16(txtCod.Text),
                    Convert.ToDateTime(txtIni.Text).Date,Convert.ToDateTime(txtFin.Text).Date
                    );

                grvDatos.DataBind();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }

            finally
            {
                txtCod.Text = "";
                txtIni.Text = "";
                txtFin.Text = "";
            }
        }
    }
}