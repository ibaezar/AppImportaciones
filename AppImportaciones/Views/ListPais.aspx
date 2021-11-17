<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListPais.aspx.cs" Inherits="AppImportaciones.Views.ListPais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Listado de paises"></asp:Label><br /><br />
            <asp:GridView ID="grdPais" runat="server"></asp:GridView>
            <br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar país</asp:LinkButton>
        </div>
    </form>
</body>
</html>
