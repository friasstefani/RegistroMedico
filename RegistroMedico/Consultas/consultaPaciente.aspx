<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultaPaciente.aspx.cs" Inherits="RegistroMedico.consultaPaciente" MasterPageFile="~/PaginaMaestra.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="Filtrar"></asp:Label>
        &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListTipoFiltro" runat="server" Height="23px" Width="159px">
            <asp:ListItem>Nombre</asp:ListItem>
            <asp:ListItem>Apellido</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFiltro" runat="server" Width="186px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
        <br />
        <br />
        <asp:GridView ID="GridViewConsulta" runat="server" AutoGenerateColumns="False" Height="145px" Width="877px" OnSelectedIndexChanged="GridViewConsulta_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="IdPaciente" HeaderText="Id" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="celular" HeaderText="Celular" />
                <asp:BoundField DataField="cedula" HeaderText="Cedula" />
                <asp:BoundField DataField="fechanacimiento" HeaderText="Fecha Nacimiento" />
                <asp:BoundField DataField="fechaingreso" HeaderText="Fecha de Ingreso" />
                <asp:BoundField DataField="sexo" HeaderText="Sexo" />
                <asp:BoundField DataField="ocupacion" HeaderText="Ocupacion" />
                <asp:BoundField />
                <asp:HyperLinkField DataNavigateUrlFields="IdPaciente" DataNavigateUrlFormatString="~/Resgistros/rPacientes.aspx?IdPaciente={0}" Text="Editar" />
            </Columns>
        </asp:GridView>
        <br />

    </div>
</asp:Content>
