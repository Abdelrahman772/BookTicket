<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StadManager.aspx.cs" Inherits="Milestone3.StadManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 407px;
            margin-left: 612px;
            margin-top: 167px;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forname" runat="server"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="Label2" runat="server" CssClass="auto-style2" Text="Username"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="forusername" runat="server"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="Label3" runat="server" CssClass="auto-style2" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forpassword" runat="server"></asp:TextBox>
            <br class="auto-style2" />
            <br class="auto-style2" />
            <asp:Label ID="Label4" runat="server" CssClass="auto-style2" Text="Stadium Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="forstad" runat="server" DataSourceID="SqlDataSource_stadiumnames" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource_stadiumnames" runat="server" ConnectionString="<%$ ConnectionStrings:project_dbConnectionString %>" SelectCommand="SELECT [name] FROM [allStadiums]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="registerclicked" runat="server" OnClick="registerclicked_Click" Text="Register" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="message" runat="server" ForeColor="Red"></asp:Label>
            </strong>
        </div>
    </form>
</body>
</html>
