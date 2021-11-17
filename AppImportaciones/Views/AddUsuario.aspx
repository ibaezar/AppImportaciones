<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUsuario.aspx.cs" Inherits="AppImportaciones.Views.AddUsuario" %>

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
            width: 218px;
        }
        .auto-style3 {
            width: 106px;
        }
    </style>
</head>
<body style="width: 703px">
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="2">Agregar nuevo Usuario</td>
                </tr>
                <tr>
                    <td class="auto-style2">ID</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Apellido Paterno</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtAp1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Apellido Materno</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtAp2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Fecha de Nacimiento (dd-mm-aaaa)</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Rol</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="dropRol" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Numero de celular</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">País</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="dropPais" runat="server">
                        </asp:DropDownList>
                        <asp:LinkButton ID="lnkSeleccionar" runat="server" OnClick="lnkSeleccionar_Click">Seleccionar</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ciudad</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="dropCiudad" runat="server" Enabled="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lnkListar" runat="server" OnClick="lnkListar_Click">Listar Usuarios</asp:LinkButton>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
