<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> ElectraTech</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             
                <asp:Label ID="lblMainPage" runat="server" style="z-index: 1; left: 376px; top: 21px; position: absolute; width: 333px; font-weight: 700; font-size: xx-large;" Text="ElectraTech Main Page"></asp:Label>
               


        </div>
        <p>
            <asp:Button ID="btnStock" runat="server" height="26px" style="z-index: 1; left: 40px; top: 89px; position: absolute" Text="Stock" width="71px" OnClick="btnStock_Click" />
            <asp:Button ID="btnStaff" runat="server" height="26px" style="z-index: 1; left: 443px; top: 89px; position: absolute" Text="Staff" width="71px" OnClick="btnStaff_Click" />
            <asp:Button ID="btnSuppliers" runat="server" height="26px" style="z-index: 1; left: 916px; top: 89px; position: absolute; width: 71px" Text="Suppliers" OnClick="btnSuppliers_Click" />
            <asp:Button ID="btnOrders" runat="server" height="26px" style="z-index: 1; left: 225px; top: 89px; position: absolute" Text="Orders" width="71px" OnClick="btnOrders_Click" />
            <asp:Button ID="btnCustomers" runat="server" height="26px" style="z-index: 1; left: 667px; top: 89px; position: absolute; width: 81px" Text="Customers" OnClick="btnCustomers_Click" />
        </p>
    </form>
</body>
</html>
