<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 8px; top: 62px; position: absolute; height: 14px; width: 84px; " Text="Customer ID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtFullName" runat="server" OnTextChanged="TextBox4_TextChanged" style="z-index: 1; left: 121px; top: 118px; position: absolute; width: 152px" height="19px"></asp:TextBox>
            <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 10px; top: 118px; position: absolute; right: 455px; height: 16px" Text="Full Name" width="84px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; top: 61px; position: absolute; height: 19px; width: 152px; left: 123px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtPhoneNumber" runat="server" OnTextChanged="TextBox5_TextChanged" style="z-index: 1; left: 122px; top: 176px; position: absolute; height: 19px; width: 152px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 13px; top: 180px; position: absolute; height: 17px; width: 84px" Text="PhoneNumber"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 124px; top: 233px; position: absolute; width: 152px" height="19px"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 15px; top: 234px; position: absolute; height: 18px; width: 84px" Text="Post Code"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtStreetAddress" runat="server" OnTextChanged="TextBox7_TextChanged" style="z-index: 1; left: 133px; top: 289px; position: absolute; height: 19px; width: 152px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 138px; top: 397px; position: absolute; width: 152px" height="19px"></asp:TextBox>
            <asp:Label ID="lblStreetAddress" runat="server" style="z-index: 1; left: 12px; position: absolute; height: 21px; top: 290px; width: 96px" Text="Street Address"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 16px; top: 337px; position: absolute; height: 28px; width: 84px; margin-top: 0px" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 127px; top: 339px; position: absolute; height: 19px; width: 152px; margin-bottom: 0px"></asp:TextBox>
            <asp:Label ID="lblDoB" runat="server" style="z-index: 1; left: 15px; position: absolute; height: 22px; width: 95px; top: 368px; margin-top: 31px; margin-bottom: 0px" Text="Date Of Birth"></asp:Label>
        </p>
        <p>
            <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 78px; top: 540px; position: absolute; height: 22px; width: 54px" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkIsOnline" runat="server" style="z-index: 1; left: 128px; top: 432px; position: absolute; height: 23px; width: 78px; margin-bottom: 0px" Text="Online" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 498px; position: absolute; height: 21px; width: 73px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 17px; top: 536px; position: absolute; width: 30px; height: 32px" Text="OK" />
    </form>
</body>
</html>
