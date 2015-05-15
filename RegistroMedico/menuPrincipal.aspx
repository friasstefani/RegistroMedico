<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuPrincipal.aspx.cs" Inherits="RegistroMedico.menuPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Pacientes.aspx" Text="Registrar Paciente" Value="Registrar Paciente"></asp:MenuItem>
                <asp:MenuItem Text="Consultar Paciente" Value="Consultar Paciente"></asp:MenuItem>
            </Items>
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
