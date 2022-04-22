<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegistrarUsuarios.aspx.cs" Inherits="appWebAdsi.presentacion.frmRegistrarUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel =" stylesheet" href ="../Content/bootstrap.min.css" type =" text/css" />
</head>
<body>
    
    <form id="form1" runat="server">
       



         <div class="container">


            <div class="col offset-6 col-md-6 mt-5">
                
            <div class ="card car-body login-card-body"> 

                <h1>        </h1>


                <div class="mb-6 mt-6">
                    <label for="documento" class="form-label">documento:</label>

                    <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" placeholder="documento" TextMode="Number"></asp:TextBox>


                     <label for="nombres" class="form-label">nombres:</label>

                    <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" placeholder="nombres " TextMode="MultiLine"></asp:TextBox>


                     <label for="apellidos " class="form-label">apellidos :</label>

                    <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" placeholder="Apellidos " TextMode="MultiLine"></asp:TextBox>

                     <label for="email " class="form-label">email :</label>

                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="email " TextMode="Email"></asp:TextBox>


                    
                </div>
                <div class="mb-3">
                    <label for="pwd" class="form-label">Password:</label>


                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>

                </div>

                <div class=" col mt-3 mb-3">
                   <%-- <asp:HyperLink ID="hplRegistro" runat="server" NavigateUrl="~/presentacion/frmRegistrarUsuarios.aspx">Registrar</asp:HyperLink>--%>
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                   


                </div>

                <asp:Button ID="btnRegistro"  CssClass="btn btn-secundary"  runat="server"  Text="Registar Usuario" OnClick="btnRegistarr_Click" />
                   

                    <asp:Button ID="btnContinuar"  CssClass="btn btn-secundary"  runat="server"  Text="continuar" OnClick="btnContinuar_Click" />

              

                </div>
            </div>
            
        </div>
    </form>
</body>
</html>
