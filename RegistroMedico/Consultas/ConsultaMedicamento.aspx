<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ConsultaMedicamento.aspx.cs" Inherits="RegistroMedico.Consultas.ConsultaMedicamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp; Filtral por
    <asp:DropDownList ID="filtroDropDownList" runat="server" Height="16px" Width="193px">
        <asp:ListItem>Nombre</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="filtroTextBox" runat="server" Width="226px"></asp:TextBox>
    &nbsp;&nbsp;<asp:Button ID="BuscarButton" runat="server" Text="Buscar" Width="97px" OnClick="BuscarButton_Click" />
    <br />
    <br />
    <asp:GridView ID="ConsultaGridView" runat="server" Width="631px">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="IdMedicamento" Text="Editar" DataNavigateUrlFormatString="~/Resgistros/Medicamento.aspx?IdMedicamento={0}" HeaderText="Editar" />
        </Columns>
    </asp:GridView>
&nbsp; 
</asp:Content>
