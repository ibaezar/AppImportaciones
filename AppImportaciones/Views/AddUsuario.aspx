<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="AddUsuario.aspx.cs" Inherits="AppImportaciones.Views.AddUsuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style7 {
            width: 244px;
            height: 26px;
        }
        .auto-style11 {
            width: 244px;
            height: 42px;
        }
        .auto-style18 {
            height: 42px;
        }
        .auto-style19 {
            height: 26px;
        }
        .auto-style21 {
            height: 23px;
        }
        .auto-style22 {
            width: 244px;
        }
        .auto-style23 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="2"><strong>Agregar nuevo Usuario</strong></td>
                </tr>
                <tr>
                    <td class="auto-style11">ID</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Nombre</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Apellido Paterno</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtAp1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAp1" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">Apellido Materno</td>
                    <td>
                        <asp:TextBox ID="txtAp2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAp2" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Fecha de Nacimiento (dd-mm-aaaa)</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtFecha" Display="Dynamic" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtFecha" Display="Dynamic" ErrorMessage="Fecha Invalida" ForeColor="Red" ValidationExpression="(^(((0[1-9]|1[0-9]|2[0-8])[-](0[1-9]|1[012]))|((29|30|31)[-](0[13578]|1[02]))|((29|30)[-](0[4,6,9]|11)))[-](19|[2-9][0-9])\d\d$)|(^29[-]02[-](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Rol</td>
                    <td class="auto-style19">
                        <asp:DropDownList ID="dropRol" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email Invalido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">Numero de celular</td>
                    <td>
                        <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtNum" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">País</td>
                    <td>
                        <asp:DropDownList ID="dropPais" runat="server">
                        </asp:DropDownList>
                        <asp:LinkButton ID="lnkSeleccionar" runat="server" OnClick="lnkSeleccionar_Click">Seleccionar</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Ciudad</td>
                    <td class="auto-style19">
                        <asp:DropDownList ID="dropCiudad" runat="server" Enabled="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Contraseña</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPassword" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Repetir contraseña</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="txtRepetirPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" Display="Dynamic" runat="server" ControlToValidate="txtRepetirPassword" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" Display="Dynamic" runat="server" ControlToValidate="txtRepetirPassword" ErrorMessage="Contraseña no coincide" ForeColor="Red" Operator="Equal" ControlToCompare="txtPassword"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23" colspan="2">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style21">
                        <asp:LinkButton ID="lnkListar" runat="server" OnClick="lnkListar_Click">Listar Usuarios</asp:LinkButton>
                    </td>
                </tr>
            </table>

        </div>
</asp:Content>
