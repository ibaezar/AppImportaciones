<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AppImportaciones.Views.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 66%;
            height: 75px;
        }
        .auto-style7 {
            width: 131px;
        }
        .auto-style8 {
            width: 131px;
            height: 26px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style10 {
            width: 47px;
        }
        .auto-style11 {
            width: 47px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login">
        <table class="auto-style1" >
            <tr>
                <td colspan="2"><strong>Ingresar a mi cuenta</strong></td>
            </tr>
            <tr>
                <td class="auto-style10">Email</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" Display="Dynamic" ControlToValidate="txtEmail" runat="server" ErrorMessage="Email Invalido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Contraseña</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style9" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Contraseña requerida" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Button ID="btnIngresar" runat="server" OnClick="Button1_Click" Text="Ingresar" />
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lbMensaje" runat="server" Text="" ForeColor="red"></asp:Label>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
