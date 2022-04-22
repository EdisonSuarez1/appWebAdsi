using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebAdsi.presentacion
{
    public partial class frmHome : System.Web.UI.Page
    {
        string CadenaConexion = "Data Source=.;Initial Catalog=dbProducto;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnabrirClick(object sender, EventArgs e)
        {
            //Obtemer Datos de la imagen
            int Tamanio = fImagen.PostedFile.ContentLength;
            byte[] ImagenOriginal = new byte[Tamanio];

            fImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, Tamanio);

            Bitmap ImagenOriginalBinaria = new Bitmap(fImagen.PostedFile.InputStream);

            //Crear Imageb Thumbail
            System.Drawing.Image imtThumbnail;
            int TamanioThumbnail = 200;
            imtThumbnail = RedimencionarImagen(ImagenOriginalBinaria, TamanioThumbnail);
            byte[] bImagenThumbnail = new byte[TamanioThumbnail];
            ImageConverter convertidor = new ImageConverter();
            bImagenThumbnail = (byte[])convertidor.ConvertTo(imtThumbnail, typeof(byte[]));

            //Insertar en la base de datos
            SqlConnection conexionSQL = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO producto(referencia,nombreProducto,cantidad,precio,descripcion,foto) VALUES(@referencia,@nombreProducto,@cantidad,@precio,@descripcion,@foto)";
            cmd.Parameters.Add("@referencia", SqlDbType.Text).Value = txtRef.Text;
            cmd.Parameters.Add("@nombreProducto", SqlDbType.Text).Value = txtNombre.Text;
            cmd.Parameters.Add("@cantidad", SqlDbType.Text).Value = txtCantidad.Text;
            cmd.Parameters.Add("@precio", SqlDbType.Text).Value = txtPrecio.Text;
            cmd.Parameters.Add("@descripcion", SqlDbType.Text).Value = txtDescripcion.Text;
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = bImagenThumbnail;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();
            cmd.ExecuteNonQuery();


            string ImagenDataUrl64 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenThumbnail);

            imgPreview.ImageUrl = ImagenDataUrl64;
            
        }
        public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOrinal, int Alto)
        {
            var Radio = (double)Alto / ImagenOrinal.Height;
            var NuevoAncho = (int)(ImagenOrinal.Width * Radio);
            var NuevoAlto = (int)(ImagenOrinal.Height * Radio);
            var NuevaImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencionada);
            g.DrawImage(ImagenOrinal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencionada;
        }
    }
    }
