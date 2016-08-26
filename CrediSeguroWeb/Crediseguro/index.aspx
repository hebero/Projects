<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Crediseguro.index" %>

<!DOCTYPE html>

<html lang ="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Codigo Tarjeta"></asp:Label>
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <asp:Button ID="btnVerificar" runat="server" OnClick="Button1_Click" Text="Verificar" />
        <br />
        <br />
    </div>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </form>
</body>
</html>
