<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" type="text/css" href="estilo.css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="txtUsuario" Forecolor="White" runat="server" Text="Label"></asp:Label>
        <br /><br />

        <asp:Button ID="btSair" runat="server" Text="Sign Out" OnClick="btSair_Click" Width="92px" BackColor="#779ab7" ForeColor="White" />

    </div>
    </form>
</body>
</html>
