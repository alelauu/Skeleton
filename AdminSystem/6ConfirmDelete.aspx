<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" EnableTheming="False" style="z-index: 1; left: 10px; top: 26px; position: absolute" Text="Order ID"></asp:Label>
        <p>
            <asp:TextBox ID="OrderID" runat="server" style="z-index: 1; left: 124px; top: 25px; position: absolute; bottom: 674px"></asp:TextBox>
            <asp:Label ID="CustomerID" runat="server" style="z-index: 1; left: 10px; top: 69px; position: absolute" Text="Customer ID"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 125px; top: 65px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Label"></asp:Label>
    </form>
</body>
</html>
