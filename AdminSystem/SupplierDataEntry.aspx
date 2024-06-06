<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCompanyName" runat="server" style="z-index: 1; left: 10px; top: 52px; position: absolute" Text="Company Name"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; top: 14px; position: absolute; left: 132px"></asp:TextBox>
            <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Supplier ID"></asp:Label>
            <asp:TextBox ID="txtCompanyName" runat="server" style="z-index: 1; left: 132px; top: 51px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 92px; position: absolute; width: 47px;" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 132px; top: 93px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblContactPhone" runat="server" style="z-index: 1; left: 10px; top: 136px; position: absolute" Text="Contact Phone"></asp:Label>
        <asp:TextBox ID="txtContactPhone" runat="server" style="z-index: 1; left: 132px; top: 136px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 170px; position: absolute" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"  style="z-index: 1; left: 132px; top: 170px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 10px; top: 215px; position: absolute" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 132px; top: 215px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblQuantityOrdered" runat="server" style="z-index: 1; left: 10px; top: 258px; position: absolute" Text="Quantity Ordered"></asp:Label>
        <asp:TextBox ID="txtQuantiyOrdered" runat="server" style="z-index: 1; left: 132px; top: 259px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 10px; top: 299px; position: absolute" Text="Delivery Date"></asp:Label>
        <asp:TextBox ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 132px; top: 300px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkQualityAssurance" runat="server" style="z-index: 1; left: 139px; top: 385px; position: absolute" Text="Quality Assurance" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 415px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 447px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 82px; top: 448px; position: absolute" Text="Cancel" />
        <asp:Button ID="Find" runat="server" OnClick="Find_Click" style="margin-left: 343px; margin-bottom: 0px" Text="Find" Width="74px" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
