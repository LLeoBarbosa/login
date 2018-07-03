<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" type="text/css" href="estilo.css" />

</head>
<body>

    <form id="form1" runat="server">

        <div class="formulario1">

            <h2>Login System</h2>

            <asp:TextBox ID="txtNome" CssClass="entrada" placeholder="User" runat="server"></asp:TextBox>
            <br /><br />

            <asp:TextBox ID="txtSenha" CssClass="entrada" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnBotao" runat="server" Text="Sign-in" Width="231px" BackColor="#779ab7" ForeColor="White" Height="40px" Font-Size="Medium" OnClick="btnBotao_Click"/>
            <br /><br />
            <asp:Label ID="txtTexto" runat="server" Text=""></asp:Label>

        </div>

    </form>
</body>
</html>
