<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FanPage.aspx.cs" Inherits="Milestone3.FanPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 992px;
            margin-left: 317px;
            margin-top: 53px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style4 {
            text-decoration: underline;
            font-size: large;
        }
        .auto-style7 {
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="fanlabel" runat="server" BorderColor="Black" BorderStyle="Groove" CssClass="auto-style2" ForeColor="Red" Text="Fan"></asp:Label>
            <br />
            <br />
            <asp:Label ID="tickets" runat="server" CssClass="auto-style4" Text="AllAvailableTickets:"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource_availableTickets">
                <Columns>
                    <asp:BoundField DataField="hostclubname" HeaderText="hostclubname" SortExpression="hostclubname" />
                    <asp:BoundField DataField="guestclubname" HeaderText="guestclubname" SortExpression="guestclubname" />
                    <asp:BoundField DataField="stadiumname" HeaderText="stadiumname" SortExpression="stadiumname" />
                    <asp:BoundField DataField="stadiumlocation" HeaderText="stadiumlocation" SortExpression="stadiumlocation" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource_availableTickets" runat="server" ConnectionString="<%$ ConnectionStrings:project_dbConnectionString %>" SelectCommand="SELECT * FROM [allTickets]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" CssClass="auto-style4" Text="AvailableMatches:"></asp:Label>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource_allmatches">
                <Columns>
                    <asp:BoundField DataField="hostclub" HeaderText="hostclub" SortExpression="hostclub" />
                    <asp:BoundField DataField="guestclub" HeaderText="guestclub" SortExpression="guestclub" />
                    <asp:BoundField DataField="matchtime" HeaderText="matchtime" SortExpression="matchtime" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource_allmatches" runat="server" ConnectionString="<%$ ConnectionStrings:project_dbConnectionString %>" SelectCommand="SELECT * FROM [allMatches]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:Label ID="ticketspurchae" runat="server" CssClass="auto-style4" Text="BuyingTickets:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="NationalID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="for_id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="HostClubName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forhost" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="GuestClubName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="forguest" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="DatetimeOfMatch"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="fortime" runat="server"></asp:TextBox>
            &nbsp;<asp:Label ID="Label6" runat="server" CssClass="auto-style7" ForeColor="Red" Text="Enter in the form of YY/MM/DD   HH:MM:SS"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="purchase_Click" Text="PurchaseTicket" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </strong>
        </div>
    </form>
</body>
</html>
