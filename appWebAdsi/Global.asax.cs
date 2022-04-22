using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace appWebAdsi
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //es para todos los usuarios 
            Application["porcentaje"] = 0.25;
        }


        protected void Session_Start(object sender, EventArgs e)
        {
            //variables de sesion
            Session["usuario"] = "normal";
            Session["idUsuario"] = 0;


            //Session["usuario"] = "normal"; cuando quiero q el usuario entre sin lguin

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
         

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}