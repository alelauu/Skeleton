<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockStatistics.aspx.cs" Inherits="StockStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>
                </h3>
            <asp:GridView ID="GridViewStGroupByCapacity" runat="server"></asp:GridView>
        </div>
        <div>
            <h3>Product List - Grouped by Date Added</h3>
            <asp:GridView ID="GridViewStGroupByAddedDate" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="btnBack" runat="server" Text="Back to Previous Page" OnClick="Button1_Click1" />
        </div>
    </form>
</body>
</html>

