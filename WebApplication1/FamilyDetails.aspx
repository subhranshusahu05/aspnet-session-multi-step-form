<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamilyDetails.aspx.cs" Inherits="WebApplication1.FamilyDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td>Spous name</td>
                    <td>
                        <asp:TextBox ID="txtspous" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Father Name</td>
                    <td>
                        <asp:TextBox ID="txtfather" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mother Name</td>
                    <td>
                        <asp:TextBox ID="txtmother" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Children if any</td>
                    <td>
                        <asp:TextBox ID="txtchildren" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnfamily" runat="server" OnClick="Button1_Click" Text="Next page" />
                        &nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
