<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:ListBox ID="lstProductList" runat="server" Height="149px" Width="165px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 69px; top: 171px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 128px; top: 170px; position: absolute" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 204px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>