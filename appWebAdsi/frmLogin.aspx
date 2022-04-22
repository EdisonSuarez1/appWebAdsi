<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="appWebAdsi.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>


        <link rel =" stylesheet" href ="Content/bootstrap.min.css" typr =" text/css"/>
</head>
<body>

    <form id="form1" runat="server">

        <div class="container">


            <div class="col offset-4 col-md-4 mt-5">
                
            <div class ="card car-body login-card-body"> 


                

                <div class="mb-3 mt-3">
                    <label for="email" class="form-label">Email:</label>

                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email usuario" TextMode="Email"></asp:TextBox>


                </div>
                <div class="mb-3">
                    <label for="pwd" class="form-label">Password:</label>


                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>

                </div>

                <div class=" col mt-3 mb-3">
                   <%-- <asp:HyperLink ID="hplRegistro" runat="server" NavigateUrl="~/presentacion/frmRegistrarUsuarios.aspx">Registrar</asp:HyperLink>--%>
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                   


                </div>

                <asp:Button ID="btnIngresar" CssClass="btn btn-primary" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />


                <asp:Button ID="btnRegistarr"  CssClass="btn btn-secundary"  runat="server"  Text="Registar" OnClick="btnRegistarr_Click" />


                </div>
            </div>
            
        </div>
    </form>
</body>
</html>
