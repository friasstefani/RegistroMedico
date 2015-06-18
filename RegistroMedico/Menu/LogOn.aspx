<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="RegistroMedico.LogOn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <p>
        Usuario&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUsuario" runat="server" Width="140px"></asp:TextBox>
    </p>
    <p>
        Clave&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxClave" runat="server" Width="138px" TextMode="Password"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buttonlogon" runat="server" Text="Long in" Width="85px" OnClick="Buttonlogon_Click" />
    </p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
