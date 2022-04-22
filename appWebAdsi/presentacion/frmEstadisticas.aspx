<%@ Page Title="" Language="C#" MasterPageFile="~/presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmEstadisticas.aspx.cs" Inherits="appWebAdsi.presentacion.frmEstadisticas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel=" stylesheet" href="../Content/bootstrap.min.css" type=" text/css" />

    <center>
        <h1>Lista de productos</h1>
    </center>
   
    <table tableWidth="">

        <tr>
                        

                        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">

                            <ItemTemplate>
                                <div class="row">
                               <td class=" itemWidth">
                                    <div class="container mt-3">
                                
                                   <h3>Nombre Producto:
                         
                     <%# DataBinder.Eval (Container.DataItem,"nombreProducto") %></h3>
                                    <br />

                                    <%--<%# DataBinder.Eval (Container.DataItem,".../imagenes/prueba.jpg") %>--%>


                                    <img class="img-responsive" src="data:image/jpg;base64,<%# Convert.ToBase64String((byte[]) DataBinder.Eval (Container.DataItem,"foto"))%>" />
                                    <br />
                                        <h2>Precio
                                    <%# DataBinder.Eval (Container.DataItem,"precio") %></h2>

                                  <%--  <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                                        Mostrar Modal--%>
                                   
                                    <%--</button>--%>
                                    <%--<asp:Button ID="Button1" runat="server" Text="Detalles" />--%>
                            
                             

                               </div>
                                   </td>
                                </div>
                            </ItemTemplate>

                        </asp:Repeater>

                    </tr>

    </table>
</asp:Content>

