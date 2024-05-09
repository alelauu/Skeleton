<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 900px">
    <form id="form1" runat="server">
        <div style="height: 451px">
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 168px; top: 13px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 168px; top: 43px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtProductBrand" runat="server" style="z-index: 1; left: 168px; top: 73px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtProductColour" runat="server" style="z-index: 1; left: 168px; top: 104px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtProductCapacity" runat="server" style="z-index: 1; left: 168px; top: 134px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtAmountInStock" runat="server" style="z-index: 1; left: 168px; top: 164px; position: absolute" height="22px" width="128px"></asp:TextBox>   
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 23px; top: 208px; position: absolute" Text="In Stock" />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 286px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 86px; top: 286px; position: absolute" Text="Cancel" />
            

            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 17px; position: absolute; height: 19px; width: 114px;" Text="Product ID"></asp:Label>
            <asp:Label ID="lblProductBrand" runat="server" style="z-index: 1; left: 10px; top: 77px; position: absolute" Text="Product Brand" height="19px" width="114px"></asp:Label>
            <asp:Label ID="lblProductColour" runat="server" style="z-index: 1; left: 10px; top: 108px; position: absolute; width: 123px;" Text="Product Colour" height="19px"></asp:Label>
            <asp:Label ID="lblProductCapacity" runat="server" style="z-index: 1; left: 10px; top: 139px; position: absolute; width: 141px;" Text="Product Capacity" height="19px"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 246px; position: absolute"></asp:Label>
            <asp:Label ID="lblAmountInStock" runat="server" style="z-index: 1; left: 10px; top: 170px; position: absolute; width: 148px;" Text="Amount In Stock"></asp:Label>
            <asp:Label ID="lblProductName0" runat="server" style="z-index: 1; left: 10px; top: 47px; position: absolute; height: 19px; width: 114px;" Text="Product Name"></asp:Label>
        </div>
    </form>
</body>
</html>
