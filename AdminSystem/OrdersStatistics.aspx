<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersStatistics.aspx.cs" Inherits="OrdersStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 266px">
    <form id="form1" runat="server">
        <div><h1> Statistics Page</h1></div>
       <div>
           <h3>Order List - Grouped by Order Status</h3>
               <asp:GridView ID="GridViewStGroupByOrderStatus" runat="server"></asp:GridView>
       </div>

        <div>
            <h3> Order List - Grouped by Order Date </h3>
                <asp:GridView ID="GridViewStGroupByOrderDate" runat="server">
                </asp:GridView>
            
        </div>
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 20px; top: 505px; position: absolute" Text="Back to Previous Page" />
    </form>
</body>
</html>
