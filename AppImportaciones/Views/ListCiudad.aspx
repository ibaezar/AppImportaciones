<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCiudad.aspx.cs" Inherits="AppImportaciones.Views.ListCiudad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Listado de ciudades"></asp:Label><br /><br />
            <asp:DropDownList ID="dropPais" runat="server"></asp:DropDownList><br />
            <asp:LinkButton ID="lnkVer" runat="server" OnClick="lnkVer_Click">Ver</asp:LinkButton>
            <br /><asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
            <br /><br />
            
            <asp:GridView ID="grdCiudad" runat="server"></asp:GridView>

            <br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar Ciudad</asp:LinkButton>
        </div>
    </form>
</body>
</html>
