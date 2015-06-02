<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RegistroMedico.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Usuario&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUsuario" runat="server" Width="140px"></asp:TextBox>
    </p>
    <p>
        Clave&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxClave" runat="server" Width="138px" TextMode="Password"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buttonlogon" runat="server" Text="Long in" Width="85px" OnClick="Buttonlogon_Click" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
