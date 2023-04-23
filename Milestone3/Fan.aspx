<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fan.aspx.cs" Inherits="Milestone3.Fan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 496px;
            margin-left: 561px;
            margin-top: 0px;
            width: 1233px;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style4 {
            margin-top: 124px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style4">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="fan_name" runat="server" CssClass="auto-style2" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forname" runat="server" MaxLength="20"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="fna_username" runat="server" CssClass="auto-style2" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forusername" runat="server" MaxLength="20"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="fan_pass" runat="server" CssClass="auto-style2" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forpassword" runat="server" MaxLength="20"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="fan_id" runat="server" CssClass="auto-style2" Text="National_id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="for_id" runat="server" MaxLength="20"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="fan_phone" runat="server" CssClass="auto-style2" Text="Phone_number"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forphone" runat="server" MaxLength="20"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="fan_birthdate" runat="server" CssClass="auto-style2" Text="Birthdate"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="for_birthdate" runat="server" MaxLength="20"></asp:TextBox>
            &nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Enter in the form of YY/MM/DD"></asp:Label>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="fan_address" runat="server" CssClass="auto-style2" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="foraddress" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="register_click" runat="server" OnClick="register_Click" Text="Register" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="message" runat="server" ForeColor="Red"></asp:Label>
            </strong>
        </div>
            
    </form>
</body>
</html>
