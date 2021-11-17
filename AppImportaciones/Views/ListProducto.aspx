<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProducto.aspx.cs" Inherits="AppImportaciones.Views.ListProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Listado de productos"></asp:Label>

            <br /><br />
            <asp:GridView ID="grdProducto" runat="server"></asp:GridView>
            <br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar productos</asp:LinkButton>
        </div>
    </form>
</body>
</html>
