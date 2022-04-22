using appWebAdsi.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appWebAdsi.datos
{
    public class clProductoD
    {
        public clProductoE MtdRegistrar(clProductoE objDatos)
        {

            string consulta = "select * from producto where referencia='" + objDatos.referencia + "'and nombreProducto='" + objDatos.nombreProducto + "'";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            clProductoE objDatosUsuario = new clProductoE();

            if (tblDatos.Rows.Count == 1)
            {
                objDatosUsuario.idProducto = int.Parse(tblDatos.Rows[0]["idProducto"].ToString());
                objDatosUsuario.referencia = tblDatos.Rows[0]["referencia"].ToString();
                objDatosUsuario.nombreProducto = tblDatos.Rows[0]["nombreProducto"].ToString();
                objDatosUsuario.cantidad = tblDatos.Rows[0]["cantidad"].ToString();
                objDatosUsuario.precio = tblDatos.Rows[0]["precio"].ToString();
                objDatosUsuario.descripcion = tblDatos.Rows[0]["descripcion"].ToString();
            }
            else
            {
                objDatosUsuario = null;
            }
            return objDatosUsuario;
        }

        public int mtdRegistrar(clProductoE objDatosEmpleado)
        {
            string sql = "insert into producto (referencia,nombreProducto,cantidad,precio,descripcion)" +
                "values ('" + objDatosEmpleado.referencia + "' ,'" + objDatosEmpleado.nombreProducto + "','" + objDatosEmpleado.cantidad + "','" + objDatosEmpleado.precio + "' ,'" + objDatosEmpleado.descripcion + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;
        }

               
        }
    }
