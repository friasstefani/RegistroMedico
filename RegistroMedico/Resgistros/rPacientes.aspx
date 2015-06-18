<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="rPacientes.aspx.cs" Inherits="RegistroMedico.rPacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
     <div>
    
        <asp:Label ID="LabelId" runat="server" Text="IDPaciente"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxId" runat="server" Width="184px" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelMesaage" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
        <asp:Label ID="Labelnombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxnombre" runat="server" Width="184px"></asp:TextBox>
&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxnombre" ErrorMessage="No puede dejar Este campo vacio.." ForeColor="Maroon">*</asp:RequiredFieldValidator>
&nbsp;
        <asp:Label ID="Labelapellido" runat="server" Text="Apellido"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBoxapellido" runat="server" Width="178px"></asp:TextBox>
        <br />
        <br /> <div>
        <span>IdReceta</span>
        <asp:TextBox ID="IdRecetaTextBox" Enabled="false" runat="server"></asp:TextBox>
    </div>
        <asp:Label ID="Labeldireccion" runat="server" Text="Direccion"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxdireccion" runat="server" Width="447px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labeltelefono" runat="server" Text="Telefono"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxtelefono" runat="server" Width="185px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Labelcelular" runat="server" Text="Celular"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxcelular" runat="server" Width="174px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labelocupacion" runat="server" Text="Ocupacion"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxocupacion" runat="server" Width="449px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labelcedula" runat="server" Text="Cedula"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxcedula" runat="server" Width="184px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Labelsexo" runat="server" Text="Sexo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListsexo" runat="server" Height="16px" Width="178px">
            <asp:ListItem>selecione un sexo.</asp:ListItem>
            <asp:ListItem Value="0">masculino</asp:ListItem>
            <asp:ListItem Value="1">femenino</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Labelnacimiento" runat="server" Text="Fecha de nacimiento"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxnacimiento" runat="server" TextMode="Date" Width="133px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxnacimiento" ErrorMessage="no puede deja la fecha" ForeColor="Maroon">*</asp:RequiredFieldValidator>
&nbsp;<asp:Label ID="Labelingreso" runat="server" Text="Fecha de Ingreso"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxingreso" runat="server" TextMode="Date" Width="121px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Buttonnuevo" runat="server" Text="Nuevo" OnClick="Buttonnuevo_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buttoneliminar" runat="server" Text="Eliminar" OnClick="Buttoneliminar_Click" Enabled="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buttonguardar" runat="server" Text="Guardar" OnClick="Buttonguardar_Click" />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
     
</asp:Content>
