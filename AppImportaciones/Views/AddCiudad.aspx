<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCiudad.aspx.cs" Inherits="AppImportaciones.Views.AddCiudad" %>

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
            width: 232px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 232px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</head>
<body style="width: 559px">
    <form id="form1" runat="server">
        <div>

            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2">Agregar Ciudad</td>
                </tr>
                <tr>
                    <td class="auto-style4">Id Ciudad</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre Ciudad</td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Pais</td>
                    <td>
                        <asp:DropDownList ID="dropPais" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkListar" runat="server" OnClick="lnkListar_Click">Listar Ciudades</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
