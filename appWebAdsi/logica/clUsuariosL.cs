using appWebAdsi.datos;
using appWebAdsi.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebAdsi.logica
{
    public class clUsuariosL
    {
        public clUsuarioE mtdLogin(clUsuarioE objDatos)
        {
            clUsuariosD objUsuariosD = new clUsuariosD();
            clUsuarioE objDatosUsuario = new clUsuarioE();
            objDatosUsuario = objUsuariosD.mtdLogin(objDatos);
            return objDatosUsuario;



        }

        public int mtdRegistarUsuario(clUsuarioE objdatosUser)
        {
            clUsuariosD objUsuariosD = new clUsuariosD();
            int resultado = objUsuariosD.mtdRegistrar(objdatosUser);
            return resultado;
        }
            
    }
}