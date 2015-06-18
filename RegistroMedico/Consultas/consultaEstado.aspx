<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultaEstado.aspx.cs" Inherits="RegistroMedico.consultaEstado" MasterPageFile="~/PaginaMaestra.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:Label ID="LabelFiltrar" runat="server" Text="Filtrar"></asp:Label>
        &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListfiltro" runat="server" Height="31px" Width="143px">
            <asp:ListItem Value="1">Nombre Paciente</asp:ListItem>
            <asp:ListItem Value="2">Cedula</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxfiltro" runat="server" Width="179px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="MsJ" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridViewConsulta" runat="server" Width="541px">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="IdEstado" Text="Editar" DataNavigateUrlFormatString="~/Resgistros/EstadoPacientes.aspx?IdDetalle={0}" />
            </Columns>
        </asp:GridView>

        <br />

    </div>
</asp:Content>
