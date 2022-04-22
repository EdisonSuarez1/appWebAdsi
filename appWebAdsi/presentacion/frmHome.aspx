<%@ Page Title="" Language="C#" MasterPageFile="~/presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmHome.aspx.cs" Inherits="appWebAdsi.presentacion.frmHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--    todo el contenido de la pagina --%>

    <h1>Pagina principal </h1>
    <h1>Lista de productos</h1>
   <div>
            <div class="container">
                <div class="row">

                    <div class="col-md-border-4 col-md-offset-4">
                        Imagen agregada
                    <br />
                        <asp:Image ID="imgPreview" Width="100" ImageUrl="https://w7.pngwing.com/pngs/527/625/png-transparent-scalable-graphics-computer-icons-upload-uploading-cdr-angle-text-thumbnail.png" runat="server" />
                        <br />
                        <br />

                        Archivo
                    <asp:FileUpload ID="fImagen" accept=".jpg" runat="server" CssClass="form-control" />
                        <br />
                        <br />

                        Referencia
                    <asp:TextBox ID="txtRef" CssClass="form-control" runat="server"></asp:TextBox>
                        <br />
                        <br />
                           Nombre Producto
                    <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                        <br />
                           Cantidad
                    <asp:TextBox ID="txtCantidad" CssClass="form-control" runat="server"></asp:TextBox>
                        <br />
                           Precio Producto
                    <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox>
                        <br />
                           Descripcion
                    <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server"></asp:TextBox>
                        <br />
                        Subida de imagen
 <asp:Button ID="btnabrir" runat="server" Text="Registrar Producto" CssClass="btn btn-success" OnClick="btnabrirClick" />

                    </div>

                </div>
            
            <div class="row"></div>


 <%--   
    <p><i><center>Venta al por menor de una amplia variedad de electrodomésticos, de distinto tamaño y función, además de la posibilidad 
        de incluir un servicio de transporte
        e instalación a domicilio (que puede realizarse por medios propios o mediante una empresa subcontratada).
        Para los inicios de la actividad se propone la venta
        por catálogo de los productos más costosos, de forma que la inversión inicial sea menor.</center> </i></p>

    <div class ="container">
        <div class ="row">
            <center>
            <div class ="col-md-4 col-md-offset-4">
               <%--imagen agregada:--%>
               <%--<center> <asp:Image ID="Image1" Width="500" ImageUrl="https://st2.depositphotos.com/1001877/6374/i/600/depositphotos_63745311-stock-photo-home-appliances-gas-cooker-tv.jpg" runat ="server" /></center>
                <br />
                <br />
                </center>--%>
                --%>
               

               
            </div>
        </div>
   
    
    
    </div>


</asp:Content>
