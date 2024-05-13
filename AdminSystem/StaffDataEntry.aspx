<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" id="lblStaffId" tabindex="0" title="Staff ID">
<head runat="server">
    <title></title>
</head>
<body>
    


    <form id="form1" runat="server">
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 90px; position: absolute; width: 89px" Text="Full Name" height="18px"></asp:Label>
    <asp:TextBox ID="txtStaffId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 99px; top: 48px; position: absolute; width: 203px; height: 22px;"></asp:TextBox>
        <div>
            <asp:Label ID="lblStaffId" runat="server" height="18px" style="z-index: 1; left: 10px; top: 53px; position: absolute; " Text="Staff ID" width="89px"></asp:Label>
        </div>
</body>
</html>
    <p>
        <asp:TextBox ID="txtFullName" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; top: 86px; position: absolute; width: 203px; left: 98px; right: 268px;" height="22px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 121px; position: absolute; width: 89px;" Text="Email" height="18px"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click1" style="z-index: 1; top: 49px; position: absolute; height: 21px; width: 89px; left: 322px" Text="Find" />
    </p>
    <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 99px; top: 117px; position: absolute; width: 203px" height="22px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 10px; top: 152px; position: absolute; height: 18px; width: 89px" Text="Post Code"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 99px; top: 147px; position: absolute" height="22px" width="203px"></asp:TextBox>
    </p>
    <div style="margin-left: 40px">
        <asp:Label ID="lblNumber" runat="server" style="z-index: 1; left: 10px; top: 186px; position: absolute" Text="Number" width="89px" height="18px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumber" runat="server" style="z-index: 1; left: 99px; top: 182px; position: absolute" height="22px" width="203px"></asp:TextBox>
    </div>
    <p>
        <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 10px; top: 223px; position: absolute" Text="Start Date" width="89px" height="18px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 99px; top: 219px; position: absolute; width: 203px;" height="22px"></asp:TextBox>
    </p>
    <p style="margin-left: 120px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 305px; position: absolute; height: 12px;"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 96px; top: 335px; position: absolute; width: 57px; height: 24px" Text="Cancel" />
        <asp:CheckBox ID="chkIsOnline" runat="server" style="z-index: 1; left: 75px; top: 269px; position: absolute; width: 81px;" Text="Is Online" />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 11px; top: 335px; position: absolute; height: 24px; width: 57px" Text="OK" />
    </p>
    <p>
        &nbsp;</p>
    </form>

