<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AppImportaciones.Views.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="4" class="auto-style2">Sistemas para Importaciones y Exportaciones</td>
                </tr>
                <tr>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
     &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkUsuario" runat="server" OnClick="lnkUsuario_Click">Usuarios</asp:LinkButton>
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkPais" runat="server" OnClick="lnkPais_Click">Paises</asp:LinkButton>
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkCiudad" runat="server" OnClick="lnkCiudad_Click">Ciudades</asp:LinkButton>
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkProducto" runat="server" OnClick="lnkProducto_Click">Productos</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <hr />
        </div>
    </form>
</body>
</html>
