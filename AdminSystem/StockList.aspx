<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:ListBox ID="lstProductList" runat="server" Height="149px" Width="165px" style="z-index: 1; left: 10px; top: 15px; position: absolute"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 150px; top: 171px; position: absolute; right: 641px;" Text="Edit" width="55px" />
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 80px; top: 171px; position: absolute" Text="Delete" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" style="z-index: 1; left: 10px; top: 171px; position: absolute" width="55px" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 209px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <asp:Label ID="lblEnterProductName" runat="server" style="z-index: 1; left: 10px; top: 238px; position: absolute; width: 193px; right: 934px;" Text="Enter a Product Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 179px; top: 237px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 10px; top: 270px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 134px; top: 270px; position: absolute" Text="Clear Filter" width="100px" />
        <div>
            <asp:Button ID="btnStatsPage" runat="server" OnClick="btnStatsPage_Click" style="z-index: 1; left: 258px; top: 270px; position: absolute" Text="Statistics Page" />
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 382px; top: 270px; position: absolute" Text="Return to Main Menu" />
        </div>
    </form>
    <p>
        s</p>
</body>
</html>
