<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPSTUDY.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style2 {
            width: 207px;
        }
    </style>
</head>
<body style="width: 610px">
    <form id="form1" runat="server">
        <table cellpadding="3" cellspacing="3" class="auto-style1">
            <tr>
                <td colspan="2">LOGIN FORM</td>
            </tr>
            <tr>
                <td class="auto-style2">Username</td>
                <td>
                    <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserNameTextBox" Display="Dynamic" ErrorMessage="please enter username" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="password is required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="36px" OnClick="Button1_Click" Text="LOGIN" Width="136px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
