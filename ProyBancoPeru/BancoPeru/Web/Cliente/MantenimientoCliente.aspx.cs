using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BancoPeru.Web.Cliente
{
    public partial class MantenimientoCliente : System.Web.UI.Page
    {
        ProxyCliente.ServiciosClienteClient objServicioCliente = new ProxyCliente.ServiciosClienteClient();
        ProxyCliente.ClienteBE objCliente = new ProxyCliente.ClienteBE();

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
            grvDatos.DataSource = objServicioCliente.GetAllClienteLINQ();
            grvDatos.DataBind();
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

  
       

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Hide();
        }
        

        protected void grvDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            try
            {
                int fila = Convert.ToInt16(e.CommandArgument);
                if (e.CommandName == "Editar")
                {
                    Int16 vcod = Convert.ToInt16(grvDatos.Rows[fila].Cells[1].Text);
                    objCliente = objServicioCliente.BuscarCliente(vcod);


                    //Mostramos los datos del vendedor consultado
                    lblCodigo.Text = objCliente.Cod_Cli.ToString();
                    txtCod2.Text = objCliente.Dni_Cli;
                    txtNom2.Text = objCliente.Nom_Cli;
                    txtApe2.Text = objCliente.Ape_Cli;
                    txtDir2.Text = objCliente.Dir_Cli;
                    txtTel2.Text = objCliente.Tel_Cli;

                    ModalPopupExtender2.Show();
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objCliente.Cod_Cli = Convert.ToInt16(lblCodigo.Text);
                objCliente.Dni_Cli = txtCod2.Text.Trim();
                objCliente.Nom_Cli = txtNom2.Text.Trim();
                objCliente.Ape_Cli = txtApe2.Text.Trim();
                objCliente.Dir_Cli = txtDir2.Text.Trim();
                objCliente.Tel_Cli = txtTel2.Text.Trim();

                if (objServicioCliente.UpdateCliente(objCliente) == true)
                {
                    Enlazar();
                    ModalPopupExtender2.Hide();
                }
                else
                {
                    lblMensaje.Text = "Datos no Actualizados, Verifique";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error" + ex.Message;
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Show();
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objCliente.Dni_Cli = txtCod.Text;
                objCliente.Nom_Cli = txtNombre.Text;
                objCliente.Ape_Cli = txtApellido.Text;
                objCliente.Dir_Cli = txtDireccion.Text;
                objCliente.Tel_Cli = txtTel.Text;

                if (objServicioCliente.InsertCliente(objCliente) == true)
                {
                    Enlazar();
                    ModalPopupExtender1.Hide();
                }
                else
                {
                    lblMensaje.Text = "Datos no Insertados, Verifique";
                }
            }

            catch (Exception ex)
            {
                lblMensaje.Text = "Error" + ex.Message;
            }
            finally
            {
                txtCod.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                txtTel.Text = "";
            }
        }
    }
}