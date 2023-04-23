<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Milestone3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 701px;
        }
        .auto-style2 {
            height: 596px;
            width: 702px;
            text-align: center;
            margin-left: 379px;
            margin-top: 0px;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            font-size: larger;
        }
    </style>
</head>
<body style="height: 698px; margin-top: 0px;">
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-image: url('bg.jpg')">
            <div class="auto-style2" style="border-style: none">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Welcome_label" runat="server" CssClass="auto-style4" Font-Size="XX-Large" Text="Welcome"></asp:Label>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Username" runat="server" CssClass="auto-style3" Font-Bold="True" ForeColor="White" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="forusername" runat="server" BackColor="Transparent" BorderStyle="Groove" Font-Size="Medium" OnTextChanged="forusername_TextChanged"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Password" runat="server" CssClass="auto-style3" Font-Bold="True" ForeColor="White" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="forpassword" runat="server" BackColor="Transparent" BorderStyle="Groove" Font-Size="Medium" OnTextChanged="forpassword_TextChanged" TextMode="Password"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="login_click" runat="server" OnClick="login_click_Click" Text="Login" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Don't have an account?"></asp:Label>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Signup" runat="server" OnClick="Signup_click_Click" Text="Sign Up" />
            </div>
        </div>
        
    </form>
</body>
</html>
