<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VALIDATIONFORM.aspx.cs" Inherits="ASPSTUDY.VALIDATIONFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 63%;
        }
        .auto-style2 {
            width: 199px;
        }
        .auto-style3 {
            width: 63%;
        }
        .auto-style4 {
            width: 199px;
            height: 34px;
        }
        .auto-style5 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Students Registation From</h2>
            <table class="auto-style3">
                <tr>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Gray" Font-Size="Larger" ForeColor="Red" />
                    </td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Student Name</td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Width="302px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="NameTextBox" ErrorMessage="Please Enter Names" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Email</td>
                    <td>
                        <asp:TextBox ID="EmailTextBox" runat="server" Width="302px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Please Enter Email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email Is Invalid" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Re-Enter Email</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="ReEnterTextBox" runat="server" Width="302px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ReEnterTextBox" Display="Dynamic" ErrorMessage="Please Re-Enter Email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="EmailTextBox" ControlToValidate="ReEnterTextBox" Display="Dynamic" ErrorMessage="Email is Not Same" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Class</td>
                    <td>
                        <asp:TextBox ID="ClassTextBox" runat="server" Width="299px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ClassTextBox" Display="Dynamic" ErrorMessage="Please Enter Class" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="ClassTextBox" Display="Dynamic" ErrorMessage="Class should be from 1 to 12" ForeColor="Red" MaximumValue="12" MinimumValue="1" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Fees</td>
                    <td>
                        <asp:TextBox ID="FeesTextBox" runat="server" Width="299px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="FeesTextBox" Display="Dynamic" ErrorMessage="Please Enter Fess" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="FeesTextBox" Display="Dynamic" ErrorMessage="Fess should be from 2000.00 to 5000.00 " ForeColor="Red" MaximumValue="5000.00" MinimumValue="2000.00" SetFocusOnError="True" Type="Double">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender</td>
                    <td>
                        <asp:RadioButton ID="MaleRadioButton" runat="server" GroupName="GenderGroup" Text="Male" />
                        <asp:RadioButton ID="FemaleRadioButton" runat="server" GroupName="GenderGroup" Text="Female" />
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please Select Gender" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="36px" Text="Submit" Width="158px" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
