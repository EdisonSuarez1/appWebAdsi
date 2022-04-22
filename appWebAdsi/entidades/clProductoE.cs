using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebAdsi.entidades
{
    public class clProductoE
    {
        public int idProducto { get; set; }
        public string referencia { get; set; }
        public string nombreProducto { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }
        public string descripcion { get; set; }
        public string foto { get; set; }
        public int idUsuario { get; set; }
    }
}