<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q3.aspx.cs" Inherits="Ship_Web.Q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 962px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Select ship :"></asp:Label>
        <asp:CheckBox ID="cb_Ship" runat="server" />
        <asp:DropDownList ID="dropdow" runat="server" Height="33px" style="margin-left: 23px" Width="84px">
        </asp:DropDownList>
        <asp:Button ID="btnSearch" runat="server" style="margin-left: 25px" Text="Search" Width="79px" OnClick="btnSearch_Click" />
        <p>
            <asp:Label ID="lb_Count" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:GridView ID="gv_Ship" runat="server" style="margin-left: 54px" Width="383px">
        </asp:GridView>
    </form>
</body>
</html>
