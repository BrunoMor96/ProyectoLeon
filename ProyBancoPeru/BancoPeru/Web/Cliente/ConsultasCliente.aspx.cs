using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoPeru.Web.Cliente
{
    public partial class ConsultasCliente : System.Web.UI.Page
    {
        ProxyCliente.ServiciosClienteClient objServicioCliente = new ProxyCliente.ServiciosClienteClient();
        ProxyCliente.ClienteBE objCliente = new ProxyCliente.ClienteBE();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objServicioCliente.GetAllCuentaCliente(txtDni.Text);
                grvDatos.DataBind();

                Single sngDeuda = objServicioCliente.CalcularDeudaCliente(txtDni.Text);
                txtDeuda.Text = sngDeuda.ToString("###0.00 soles");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}