<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Createacc.aspx.cs" Inherits="Milestone3.Createacc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1521px;
            height: 780px;
            font-size: xx-large;
            text-align: center;
            direction: ltr;
        }
        .auto-style2 {
            font-size: large;
            margin-right: 0px;
            margin-top: 1px;
        }
        .auto-style4 {
            font-size: large;
            margin-left: 0px;
        }
        .auto-style3 {
            font-size: large;
            margin-top: 0px;
        }
    </style>
</head>
<body style="height: 64px; width: 1519px; margin-bottom: 0px">
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-image: url('createacc_bg.jpg'); color: #FFFFFF;">
            <strong><em>Please specify the user type you want to create<br />
            <br />
            <asp:Button ID="Assoc_button" runat="server" OnClick="Button2_Click" Text="Sport Association Manager" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Clubrep_button" runat="server" OnClick="Clubrep_button_Click" Text="Club Representative" />
&nbsp;&nbsp;
            <asp:Button ID="stadManager_button" runat="server" OnClick="stadManager_button_Click" Text="Stadium Manager" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Fan_button" runat="server" OnClick="Fan_button_Click" Text="Fan" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </em></strong><em><strong>
            <asp:Label ID="AssocManager_Label" runat="server" BorderStyle="None" CssClass="auto-style2" Height="373px" Text="SPORT ASSOCIATION MANAGER                          he can manage (create, edit or delete) the matches that will be played by the different clubs." Width="128px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Clubrep_label" runat="server" BorderStyle="None" CssClass="auto-style3" Height="373px" Text="CLUB REPRESENTATIVE             The club will also have a representative who will be responsible for asking for the permission to host the matches played by the club he is representing" Width="227px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="stadManager_label" runat="server" BorderStyle="None" CssClass="auto-style4" Height="416px" Text="STADIUM MANAGER     each stadium has a manager who is in charge  for approving or disapproving the different club requests for hosting their matches on the stadium he is managing ." Width="229px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Fans_label" runat="server" BorderStyle="None" CssClass="auto-style3" Height="370px" Text="FANS     they can buy tickets to attend the matches.      " Width="102px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></em>
        </div>
    </form>
</body>
</html>
