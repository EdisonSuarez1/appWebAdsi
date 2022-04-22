using appWebAdsi.entidades;
using appWebAdsi.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebAdsi.presentacion
{
    public partial class frmRegistrarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnRegistarr_Click(object sender, EventArgs e)
        {
            clUsuarioE objUsuarioE = new clUsuarioE();

            objUsuarioE.documento = txtDocumento.Text;
            objUsuarioE.nombres = txtNombres.Text;
            objUsuarioE.apellidos = txtApellidos.Text;
            objUsuarioE.email = txtEmail.Text;
            objUsuarioE.clave = txtPassword.Text;



            clUsuariosL objUsuariosL = new clUsuariosL();

            int filas = objUsuariosL.mtdRegistarUsuario(objUsuarioE);
            if (filas>0)

            {
                lblMensaje.Text = "usuario Registrado ";

            }
            else
            {
                lblMensaje.Text = "usuario no Registrado ";
            }
            


        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/frmLogin.aspx");
        }
    }
}