<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 342px">
            <asp:ListBox ID="lstOrderList" runat="server" Height="256px" Width="264px"></asp:ListBox>
            <br />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 82px; top: 289px; position: absolute" Text="Edit" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 289px; position: absolute; right: 1096px;" Text="Add" height="26px" width="37px" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 327px; position: absolute"></asp:Label>
        </div>
    </form>
</body>
</html>
