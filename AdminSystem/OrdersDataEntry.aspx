<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the Order Data Entry Page
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 158px; top: 56px; position: absolute; width: 128px; height: 22px"></asp:TextBox>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 29px; top: 58px; position: absolute" Text="OrderID" width="79px"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 29px; top: 95px; position: absolute" Text="Customer ID" width="79px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" height="22px" style="z-index: 1; left: 158px; top: 91px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtOrderDate" runat="server" height="22px" style="z-index: 1; top: 128px; position: absolute; left: 158px" width="128px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 321px; top: 57px; position: absolute; height: 26px; width: 59px" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 29px; top: 131px; position: absolute" Text="Order Date" width="79px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 29px; top: 167px; position: absolute" Text="Order Status" width="79px"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" height="22px" style="z-index: 1; left: 158px; top: 166px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkIsReturned" runat="server" style="z-index: 1; left: 131px; top: 305px; position: absolute" Text="Returned" />
            <asp:Label ID="lblProdutIDc" runat="server" style="z-index: 1; left: 29px; top: 206px; position: absolute" Text="Product ID" width="79px"></asp:Label>
        </p>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 29px; top: 242px; position: absolute" Text="Quantity" width="79px"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 29px; top: 304px; position: absolute; height: 19px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtProductID" runat="server" height="22px" style="z-index: 1; left: 158px; top: 210px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" height="22px" style="z-index: 1; left: 158px; top: 242px; position: absolute" width="128px"></asp:TextBox>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 29px; top: 347px; position: absolute; " Text="OK" height="26px" width="33" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 111px; top: 347px; position: absolute" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
