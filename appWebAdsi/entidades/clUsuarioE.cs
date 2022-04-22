using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebAdsi.entidades
{
    public class clUsuarioE
    {

        public int idUsuario { get; set; }
        public  string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos  { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
       
    }
}