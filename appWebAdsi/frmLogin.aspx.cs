using appWebAdsi.entidades;
using appWebAdsi.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebAdsi
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {


            clUsuarioE objDatos = new clUsuarioE();
            objDatos.email = txtEmail.Text;
            objDatos.clave = txtPassword.Text;

            clUsuariosL objUsuariosL = new clUsuariosL();
            clUsuarioE objDatosReci = new clUsuarioE();
            objDatosReci=objUsuariosL.mtdLogin(objDatos);
            if (objDatosReci!=null)
            {

                Session["usuario"] = objDatosReci.nombres + " " + objDatosReci.apellidos;
                Response.Redirect("presentacion/frmHome.aspx");



                ////Session["usuario"] = "" + "" + "";
                //Session["usuario"] = txtEmail.Text;
                ////Response es para llamar la pagina 
                //Response.Redirect("presentacion/frmHome.aspx");

                //establesco la paguina de inicio q quiero q me aparesca


            }
            else
            {
                lblMensaje.Text = "usuario no Registrado ";
            }


        }


        protected void btnRegistarr_Click(object sender, EventArgs e)
        {

            Response.Redirect("presentacion/frmRegistrarUsuarios.aspx");

        }
    }
}