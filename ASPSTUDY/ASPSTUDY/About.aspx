<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ASPSTUDY.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
<asp:Button ID="Button1" runat="server" Height="65px" OnClick="Button1_Click" style="margin-left: 172" Text="LOGOUT" Width="288px" />
</asp:Content>
