using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoPeru
{
    public partial class Cliente : System.Web.UI.Page
    {

        ProxyCliente.ServiciosClienteClient objServicioCliente = new ProxyCliente.ServiciosClienteClient();
        ProxyCliente.ClienteBE objCliente = new ProxyCliente.ClienteBE();

        private void Enlazar()
        {
            grvDatos.DataSource = objServicioCliente.GetAllClienteLINQ();
            grvDatos.DataBind();
        }

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
                    throw new Exception(ex.Message);
                }

            }
        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objServicioCliente.GetCliente(txtDni.Text);
                grvDatos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objServicioCliente.GetAllClienteLINQ();
                grvDatos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}