using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoPeru.Web.Empleado
{
    public partial class Empleado : System.Web.UI.Page
    {
        ProxyEmpleado.ServiciosEmpleadoClient objServicioEmpleado = new ProxyEmpleado.ServiciosEmpleadoClient();
        ProxyEmpleado.EmpleadoBE objEmpleado = new ProxyEmpleado.EmpleadoBE();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objServicioEmpleado.GetEmpleado(txtDni.Text);
                grvDatos.DataBind();
                grvEmpleado.DataSource = objServicioEmpleado.GetClienteSucursal(txtDni.Text);
                grvEmpleado.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}