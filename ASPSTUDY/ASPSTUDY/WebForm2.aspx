﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASPSTUDY.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 65%;
            margin-left: 276px;
        }
    </style>
</head>
<body style="margin-left: 252px">
    <form id="form1" runat="server">
        <div>
            <table cellpadding="2" class="auto-style1">
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" AutoGenerateColumns="true" runat="server" GridLines="None" ShowHeader="False">
                           <%-- <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                         <table border="1" width="250" height="250">
                                <tr>
                                    <td><h3>ID</h3></td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><h3>NAME</h3></td>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><h3>GENDER</h3></td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("gender") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><h3>CITY</h3></td>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("city") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>--%>
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <table border="1" width="250" height="250">
                                <tr>
                                    <td><h3>ID</h3></td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><h3>NAME</h3></td>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><h3>GENDER</h3></td>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("gender") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><h3>CITY</h3></td>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("city") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                            <SeparatorTemplate>
                                <br />
                            </SeparatorTemplate>
                        </asp:Repeater>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
