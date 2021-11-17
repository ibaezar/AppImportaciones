<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPais.aspx.cs" Inherits="AppImportaciones.Views.AddPais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Agregar Pais"></asp:Label><br /><br />
            <asp:TextBox ID="txtId" runat="server" placeholder="Id"></asp:TextBox><br />
            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox><br /><br />
            <asp:LinkButton ID="lnkAgregar" runat="server" OnClick="lnkAgregar_Click">Agregar</asp:LinkButton><br />
            <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
            <br />
            <asp:LinkButton ID="lnkListado" runat="server" OnClick="lnkListado_Click">Ver listado paises</asp:LinkButton>
        </div>
    </form>
</body>
</html>
