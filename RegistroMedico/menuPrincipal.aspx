<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuPrincipal.aspx.cs" Inherits="RegistroMedico.menuPrincipal" MasterPageFile="~/PaginaMaestra.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="margin-left: 40px">
    
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu1_MenuItemClick">
            <Items>
                <asp:MenuItem NavigateUrl="~/Pacientes.aspx" Text="Registrar Paciente" Value="Registrar Paciente"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/consultaPaciente.aspx" Text="Consultar Paciente" Value="Consultar Paciente"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Sistema.aspx" Text="Registro de sistema" Value="Registro de sistema"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/EstadoPacientes.aspx" Text="Registro de estado del paciente" Value="Registro de estado del paciente"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/consultaSistemas.aspx" Text="Consultar sistema" Value="Consultar sistema"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/consultaEstado.aspx" Text="Consulta de estado" Value="Consulta de estado"></asp:MenuItem>
            </Items>
        </asp:Menu>
    
    </div>
    
</asp:Content>