<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 653px;
            width: 983px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<asp:ListBox runat="server" ID="lstStaffList" Height="655px" Width="820px"></asp:ListBox>



        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" height="26px" OnClick="btnAdd_Click" style="z-index: 1; left: 18px; top: 673px; position: absolute" Text="Add" width="55px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" height="26px" OnClick="btnEdit_Click" style="z-index: 1; left: 108px; top: 673px; position: absolute" Text="Edit" width="55px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" height="26px" style="z-index: 1; top: 673px; position: absolute" Text="Delete" width="55px" OnClick="btnDelete_Click" />
&nbsp;<div style="margin-bottom: 0px">
            <asp:Label ID="lblEnterFullName" runat="server" style="z-index: 1; left: 10px; top: 712px; position: absolute; width: 139px" Text="Enter a Full Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEnterFullName" runat="server" style="z-index: 1; left: 158px; top: 711px; position: absolute"></asp:TextBox>



        </div>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 9px; top: 754px; position: absolute" Text="Apply Filter" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 143px; top: 754px; position: absolute" Text="Clear Filter" />
        </p>
        <asp:Button ID="btnStatistics" runat="server" OnClick="btnStatistics_Click" style="z-index: 1; left: 276px; top: 754px; position: absolute" Text="Statistics Page" />
        <asp:Button ID="btnMainPage" runat="server" style="z-index: 1; left: 455px; top: 754px; position: absolute; width: 181px" Text="Return to Main page" OnClick="btnMainPage_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 810px; position: absolute" Text="[lblError]"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

