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
            <asp:TextBox ID="txtAmountInStock" runat="server" style="z-index: 1; left: 168px; top: 196px; position: absolute" height="22px" width="128px"></asp:TextBox>   
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 20px; top: 311px; position: absolute; height: 26px;" Text="OK" />
            

            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 17px; position: absolute; height: 19px; width: 114px;" Text="Product ID"></asp:Label>
            <asp:Label ID="lblProductBrand" runat="server" style="z-index: 1; left: 10px; top: 77px; position: absolute" Text="Product Brand" height="19px" width="114px"></asp:Label>
            <asp:Label ID="lblProductColour" runat="server" style="z-index: 1; left: 10px; top: 108px; position: absolute; width: 123px;" Text="Product Colour" height="19px"></asp:Label>
            <asp:Label ID="lblProductCapacity" runat="server" style="z-index: 1; left: 10px; top: 139px; position: absolute; width: 141px;" Text="Product Capacity" height="19px"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 274px; position: absolute"></asp:Label>
            <asp:Label ID="lblAmountInStock" runat="server" style="z-index: 1; left: 10px; top: 203px; position: absolute; width: 148px;" Text="Amount In Stock"></asp:Label>
            <asp:Label ID="lblProductName0" runat="server" style="z-index: 1; left: 10px; top: 47px; position: absolute; height: 19px; width: 114px;" Text="Product Name"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 333px; top: 14px; position: absolute" Text="Find" />
            <asp:Label ID="lblProductPrice" runat="server" style="z-index: 1; left: 10px; top: 171px; position: absolute; width: 141px;" Text="Product Price" height="19px"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 89px; top: 311px; position: absolute" Text="Cancel" />
            

            <asp:TextBox ID="txtProductPrice" runat="server" height="22px" style="z-index: 1; left: 168px; top: 165px; position: absolute; right: 330px" width="128px"></asp:TextBox>
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 19px; top: 240px; position: absolute" Text="In Stock"/>
        </div>
    </form>
</body>
</html>
