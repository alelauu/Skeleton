<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 513px">
    <form id="form1" runat="server">
        <div style="height: 342px">
            <asp:ListBox ID="lstOrderList" runat="server" Height="256px" Width="264px"></asp:ListBox>
            <br />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 82px; top: 289px; position: absolute; right: 1018px;" Text="Edit" height="26px" width="55px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 289px; position: absolute; right: 1096px;" Text="Add" height="26px" width="55px" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 450px; position: absolute"></asp:Label>
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 153px; top: 289px; position: absolute" Text="Delete" height="26px" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 22px; top: 403px; position: absolute; right: 1015px;" Text="Apply Filter" height="26px" width="100px" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 135px; top: 403px; position: absolute" Text="Clear Filter" height="26px" width="100px" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 13px; top: 354px; position: absolute" Text="Enter an Order Status"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 165px; top: 355px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnStats" runat="server" OnClick="btnStats_Click" style="z-index: 1; left: 247px; top: 403px; position: absolute" Text="Statistics Page" height="26px" width="100px" />
        <asp:Button ID="btnReturnMain" runat="server" OnClick="btnReturnMain_Click" style="z-index: 1; left: 363px; top: 403px; position: absolute" Text="Return to Main Menu" height="26px" />
    </form>
</body>
</html>
