<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 331px">
    <form id="form1" runat="server">
        <div style="height: 28px">
            <asp:Label ID="lblSure" runat="server" style="z-index: 1; left: 67px; top: 62px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 107px; top: 103px; position: absolute; width: 69px; right: 1011px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; top: 103px; position: absolute; left: 226px" Text="No" width="69px" />
    </form>
</body>
</html>
