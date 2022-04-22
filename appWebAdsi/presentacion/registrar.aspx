<%@ Page Title="" Language="C#" MasterPageFile="~/presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="appWebAdsi.presentacion.registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>pagina de registro</h1>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="idUsuario" DataSourceID="SqlDataSource2" EmptyDataText="No hay registros de datos para mostrar." BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
        <Columns>
            <asp:BoundField DataField="documento" HeaderText="documento" SortExpression="documento" />
            <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="clave" HeaderText="clave" SortExpression="clave" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
<p>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbProductoConnectionString1 %>" DeleteCommand="DELETE FROM [usuario] WHERE [idUsuario] = @idUsuario" InsertCommand="INSERT INTO [usuario] ([documento], [nombres], [apellidos], [email], [clave]) VALUES (@documento, @nombres, @apellidos, @email, @clave)" ProviderName="<%$ ConnectionStrings:dbProductoConnectionString1.ProviderName %>" SelectCommand="SELECT [idUsuario], [documento], [nombres], [apellidos], [email], [clave] FROM [usuario]" UpdateCommand="UPDATE [usuario] SET [documento] = @documento, [nombres] = @nombres, [apellidos] = @apellidos, [email] = @email, [clave] = @clave WHERE [idUsuario] = @idUsuario">
        <DeleteParameters>
            <asp:Parameter Name="idUsuario" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="documento" Type="String" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="apellidos" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="clave" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="documento" Type="String" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="apellidos" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="clave" Type="String" />
            <asp:Parameter Name="idUsuario" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>


</asp:Content>
