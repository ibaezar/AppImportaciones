<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AppImportaciones.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<style type="text/css">
    body{
        background-color: #cccccc;
    }
    .texto{
        background-color: green;
        text-align: center;
    }
</style>

<body>
    <h1 class="texto">Aplicación de importaciones</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbName" runat="server" Text="Nombre"></asp:Label><br />
            <asp:TextBox ID="txtName" runat="server" placeholder="Ingrese su nombre"></asp:TextBox>
            <br />
            <asp:Button ID="btnSend" runat="server" Text="Enviar" />
        </div>
    </form>
</body>
</html>