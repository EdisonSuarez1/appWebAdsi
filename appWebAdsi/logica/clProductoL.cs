using appWebAdsi.datos;
using appWebAdsi.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebAdsi.logica
{
    public class clProductoL
    {
        public clProductoE mtdRegistrar(clProductoE objDatos)
        {
            clProductoD objUsuariosD = new clProductoD();
            clProductoE objDatosUsuario = new clProductoE();
            objDatosUsuario = objUsuariosD.MtdRegistrar(objDatos);
            return objDatosUsuario;



        }

        //internal object mtdListar()
        //{
        //    throw new NotImplementedException();
        //}

        public int mtdRegistarProducto(clProductoE objdatosUser)
        {
            clProductoD objUsuariosD = new clProductoD();
            int resultado = objUsuariosD.mtdRegistrar(objdatosUser);
            return resultado;
        }

        //public List<clProductoE> mtdListarProducto()
        //{
        //    clProductoD objProductoD = new clProductoD();
        //    List<clProductoE> listaProducto = new List<clProductoE>();
        //    listaProducto = objProductoD.MtdListar();
        //    return listaProducto;

        //}

        internal int mtdListar(clProductoE objDatos)
        {
            throw new NotImplementedException();
        }
    }
}