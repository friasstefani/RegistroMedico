<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoPacientes.aspx.cs" Inherits="RegistroMedico.EstadoPacientes" MasterPageFile="~/PaginaMaestra.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 324px; margin-top: 0px">
    
        <asp:Label ID="Label1" runat="server" Text="Paciente:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="PacientesDropDownList" runat="server" Height="16px" Width="155px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Fecha:" ToolTip=" "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date" Width="167px"></asp:TextBox>
        <br />
        <br />
        
        <hr />
        <div>
            <br />
&nbsp;&nbsp; Sistema&nbsp;&nbsp;
            <asp:DropDownList ID="SistemasDropDownList" runat="server" Height="16px" Width="155px">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp; Situacion del Paciente:&nbsp;
            <asp:TextBox ID="SituacionPacienteTextBox" runat="server" Width="366px"></asp:TextBox>
&nbsp;
            <asp:Button ID="AgregarButton" runat="server" OnClick="AgregarButton_Click" Text="Agregar" />
            <br />
            <br />
            <asp:GridView ID="DetalleGridView" runat="server" Width="100%">
            </asp:GridView>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Buttonnuevo" runat="server" OnClick="Buttonnuevo_Click" Text="Nuevo" Width="120px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="GuardarEstadoButton" runat="server" OnClick="GuardarEstadoButton_Click" Text="Guardar" Width="163px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Buttonelimina" runat="server" OnClick="Buttonelimina_Click" Text="Eliminar" Width="136px" />
            <br />
            <asp:Label ID="MsjLabel" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </div>
   </asp:Content>
