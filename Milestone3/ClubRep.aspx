<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClubRep.aspx.cs" Inherits="Milestone3.ClubRep" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 586px;
        }
        .auto-style2 {
            height: 622px;
            margin-left: 603px;
            margin-top: 7px;
            margin-bottom: 13px;
        }
        .auto-style3 {
            font-size: large;
        }
    </style>
</head>
<body style="height: 662px">
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-image: none">
            <div class="auto-style2">
                
                <strong>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="name_rep" runat="server" CssClass="auto-style3" Text="Name"></asp:Label>
                <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                <asp:TextBox ID="forname" runat="server"></asp:TextBox>
                <br class="auto-style3" />
                <br class="auto-style3" />
                <asp:Label ID="username_rep" runat="server" CssClass="auto-style3" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="forusername" runat="server"></asp:TextBox>
                <br class="auto-style3" />
                <br class="auto-style3" />
                <asp:Label ID="password_rep" runat="server" CssClass="auto-style3" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="forpassword" runat="server"></asp:TextBox>
                <br class="auto-style3" />
                <br class="auto-style3" />
                <asp:Label ID="clubname_rep" runat="server" CssClass="auto-style3" Text="ClubName"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="listofclubs" runat="server" DataSourceID="SqlDataSource_nameofclubs" DataTextField="name" DataValueField="name">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource_nameofclubs" runat="server" ConnectionString="<%$ ConnectionStrings:project_dbConnectionString %>" SelectCommand="SELECT [name] FROM [allClubs]"></asp:SqlDataSource>
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Register_rep" runat="server" OnClick="Register_rep_Click" Text="Register" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="message" runat="server" ForeColor="Red"></asp:Label>
                </strong>
                
            </div>
        </div>
    </form>
</body>
</html>
