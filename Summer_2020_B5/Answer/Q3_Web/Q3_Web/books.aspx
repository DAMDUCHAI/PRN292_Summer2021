<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="books.aspx.cs" Inherits="Q3_Web.books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 887px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="List of book"></asp:Label>
        <asp:GridView ID="gv_Book" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Year" HeaderText="Year" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="delete.aspx?id={0}" HeaderText="Active" Text="Delete" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="update.aspx?id={0}" HeaderText="Update" Text="Update" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
