using appWebAdsi.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appWebAdsi.datos
{
    public class clUsuariosD
    {

        public clUsuarioE mtdLogin(clUsuarioE objDatos)
        {

            string consulta = "select* from usuario where email='" + objDatos.email + "'and clave='" + objDatos.clave + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clUsuarioE objDatosUsuario = new clUsuarioE();

            if (tblDatos.Rows.Count==1)
            {
               objDatosUsuario.idUsuario= int.Parse(tblDatos.Rows[0]["idUsuario"].ToString());
                objDatosUsuario.documento = tblDatos.Rows[0]["documento"].ToString();
                objDatosUsuario.nombres = tblDatos.Rows[0]["nombres"].ToString();
                objDatosUsuario.apellidos = tblDatos.Rows[0]["apellidos"].ToString();
                objDatosUsuario.email = tblDatos.Rows[0]["email"].ToString();
                objDatosUsuario.clave = tblDatos.Rows[0]["clave"].ToString();
            }
            else
            {
                objDatosUsuario = null;
            }
            return objDatosUsuario;
        }

        public int mtdRegistrar(clUsuarioE objDatosEmpleado)
        {
            string sql = "insert into usuario(documento,nombres,apellidos,email,clave)" +
                "values ('" + objDatosEmpleado.documento + "' ,'" + objDatosEmpleado.nombres + "','" + objDatosEmpleado.apellidos + "','" + objDatosEmpleado.email + "' ,'" + objDatosEmpleado.clave + "')";
            clConexion objConexion = new clConexion();
            int resulatdo = objConexion.mtdConectado(sql);
            return resulatdo;
        }

    }
}