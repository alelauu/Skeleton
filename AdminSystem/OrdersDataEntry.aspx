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
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 136px; top: 56px; position: absolute; width: 129px; height: 22px"></asp:TextBox>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 14px; top: 58px; position: absolute" Text="OrderID" width="79px"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 14px; top: 95px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" height="22px" style="z-index: 1; left: 136px; top: 91px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtOrderDate" runat="server" height="22px" style="z-index: 1; top: 128px; position: absolute; left: 136px" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 14px; top: 131px; position: absolute" Text="Order Date" width="79px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblOrderStatus" runat="server" style="z-index: 1; left: 14px; top: 167px; position: absolute" Text="Order Status" width="79px"></asp:Label>
        <asp:TextBox ID="txtOrderStatus" runat="server" height="22px" style="z-index: 1; left: 136px; top: 166px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkIsReturned" runat="server" style="z-index: 1; left: 136px; top: 207px; position: absolute" Text="Returned" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 259px; position: absolute; height: 19px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 297px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 72px; top: 296px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
