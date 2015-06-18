<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Medicamento.aspx.cs" Inherits="RegistroMedico.Medicamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div style="text-align: center">
        <h3>Registro de Medicamento</h3>
    </div>

    <div>
        <span>IdMedicamento</span>&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="IdMedicamentoTextBox" Enabled="false" runat="server" Height="20px" Width="117px"></asp:TextBox>
        &nbsp;<br />
        <br />
    </div>
 
     <div>
         <span>Nombre del Medicamento</span>&nbsp;<asp:TextBox ID="NombreTextBox" runat="server" Width="246px"></asp:TextBox>
         <br />
         <br />
         <asp:Button ID="ButtonNuevo" runat="server" Text="Nuevo" Width="79px" OnClick="ButtonNuevo_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" Width="70px" OnClick="ButtonGuardar_Click" />
&nbsp;&nbsp;&nbsp;
         <asp:Button ID="ElininarButton" runat="server" Text="Eliminar" Width="83px" OnClick="ElininarButton_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LabelMesaage" runat="server"></asp:Label>
    </div>

    <p>
        &nbsp;</p>
</asp:Content>
