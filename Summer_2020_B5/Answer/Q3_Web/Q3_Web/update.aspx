<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="Q3_Web.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 142px; width: 928px">
    <form id="form1" runat="server">
        <div>
            Update</div>
        <p>
            ID<asp:TextBox ID="txt_ID" runat="server" Enabled="False" style="margin-left: 45px"></asp:TextBox>
        </p>
        <p>
            Tittle<asp:TextBox ID="txt_Title" runat="server" style="margin-left: 30px"></asp:TextBox>
        </p>
        <p>
            Year<asp:TextBox ID="txt_Year" runat="server" style="margin-left: 31px"></asp:TextBox>
        </p>
        <p>
            Description<asp:TextBox ID="txt_Des" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>
        <asp:Button ID="bt_Save" runat="server" OnClick="bt_Save_Click" Text="Save" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
