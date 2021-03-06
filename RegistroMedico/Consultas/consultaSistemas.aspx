﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultaSistemas.aspx.cs" Inherits="RegistroMedico.consultaSistemas" MasterPageFile="~/PaginaMaestra.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="Filtrar"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListTipoFiltro" runat="server" Height="23px" Width="159px">
            <asp:ListItem Value="0">Id</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxFiltro" runat="server" Width="186px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
        <br />
        <br />

    </div>
    &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridViewConsulta" runat="server" AutoGenerateColumns="False" Width="492px">
            <Columns>
                <asp:BoundField DataField="IdSistema" HeaderText="Numero del sistema" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:HyperLinkField DataNavigateUrlFields="IdSistema" DataNavigateUrlFormatString="~/Resgistros/Sistema.aspx?IdSistema={0}" HeaderText="Editar" Text="Editar" />
            </Columns>
        </asp:GridView>
</asp:Content>
