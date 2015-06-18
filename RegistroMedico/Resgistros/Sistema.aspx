<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sistema.aspx.cs" Inherits="RegistroMedico.Sistema" MasterPageFile="~/PaginaMaestra.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 210px">
    
    &nbsp;&nbsp;
        <asp:Label ID="IdSistemaLabel" runat="server" Text="Id del Sitema"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxSistema" runat="server" Width="142px" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelNombre" runat="server" Text="Nombre del Sistema"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxnombresi" runat="server" Width="221px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Buttonnuevo" runat="server" OnClick="Button2_Click" Text="Nuevo" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonGuardar" runat="server" OnClick="ButtonGuardar_Click" Text="Guardar" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonEliminar" runat="server" OnClick="ButtonEliminar_Click" Text="Eliminar" Enabled="False" />
    
    </div>
  
    </asp:Content>