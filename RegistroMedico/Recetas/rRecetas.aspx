<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="rRecetas.aspx.cs" Inherits="RegistroMedico.Recetas.rRecetas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="text-align: center">
        <h3>Registro de Recetas</h3>
    </div>


    <div style="float: right;">
        <span>Fecha</span>
        <asp:TextBox ID="FechaTextBox" type="date" runat="server"></asp:TextBox>
    </div>

    <div>
        <span>IdReceta</span>
        <asp:TextBox ID="IdRecetaTextBox" Enabled="false" runat="server"></asp:TextBox>
    </div>

    <div>
        <span>Paciente</span>
        <asp:DropDownList ID="PacienteDropDownList" Width="60%" runat="server"></asp:DropDownList>
    </div>
    <br />
    <hr />
    <br />
    <div>
        <span>Medicamento</span>
        <asp:DropDownList ID="MedicamentosDropDownList" Width="25%" runat="server"></asp:DropDownList>

        <span>Descripcion</span>
        <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>

        
        <span>Cantidad</span>
        <asp:TextBox ID="CantidadTextBox" runat="server"></asp:TextBox>

        <asp:Button runat="server" Text="Agregar" Width="8%" ID="AgregarButton" OnClick="AgregarButton_Click" />
    </div>


    <div>
        <asp:GridView ID="DatosGridView" runat="server">                                                 
        </asp:GridView>
    </div>
    <br />

    <div style="text-align:center"> 
        <asp:Button runat="server" style="margin:10px;" Text="Nuevo" Width="8%" ID="NuevoButton" OnClick="NuevoButton_Click" />
        <asp:Button runat="server" style="margin:10px;" Text="Guardar" Width="8%" ID="GuardarButton" OnClick="GuardarButton_Click" />
        <asp:Button runat="server" style="margin:10px;" Text="Eliminar" Width="8%" ID="EliminarButton" OnClick="EliminarButton_Click" />
    </div>

    <br />
    <br />

    <div>
        <asp:Label runat="server" ID="MsjLabel"></asp:Label>
    </div>
</asp:Content>
