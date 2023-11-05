<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingUp.aspx.cs" Inherits="ASPSTUDY.SingUp" %>

<!DOCTYPE html>
<script runat="server">

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
            margin:auto;
            border:3px solid black;
        }
        .auto-style2 {
            text-align: center;
            align-items: center;
            s font-size: 20px;
            width: 22px;
        }
        .auto-style3 {
            width: 333px;
        }
        .auto-style4 {
            text-align: center;
            align-items: center;
            s font-size: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SINGUPFORM</td>
                </tr>
                <tr>
                    <td class="auto-style2">FirstName</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Width="124px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FirstNameTextBox" Display="Dynamic" ErrorMessage="First name is required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">LastName</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="LastNameTextBox" runat="server" Width="124px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="LastNameTextBox" Display="Dynamic" ErrorMessage="Last name is required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="158px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="Select" ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Please select a gender" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Invalid email" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="EmailTextBox" runat="server" Width="127px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Please enter email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Address</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="AddressTextBox" runat="server" Width="135px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="AddressTextBox" Display="Dynamic" ErrorMessage="Please enter address" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">UserName</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="UserNameTextBox" runat="server" Width="133px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="UserNameTextBox" Display="Dynamic" ErrorMessage="please enter Username" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="PasswordTextBox" runat="server" Width="137px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="please enter password" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="Please Enter strong password" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ConfirmPaswword</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" AutoCompleteType="Search" Width="136px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ConfirmPasswordTextBox" Display="Dynamic" ErrorMessage="please enter confirm password" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PasswordTextBox" ControlToValidate="ConfirmPasswordTextBox" Display="Dynamic" ErrorMessage="password is not same" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Height="33px" Text="SIGNUP" Width="120px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="#CCCCCC" Font-Size="Larger" ForeColor="Red" />
    </form>
</body>
</html>
