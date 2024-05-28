<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 8px; top: 62px; position: absolute; height: 14px; width: 84px; bottom: 600px" Text="Customer ID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" style="z-index: 1; left: 122px; top: 137px; position: absolute; width: 152px" height="19px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 143px; position: absolute; right: 1391px; height: 16px" Text="FullName" width="84px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; top: 61px; position: absolute; height: 19px; width: 152px; left: 123px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomer" runat="server" style="z-index: 1; left: 12px; top: 97px; position: absolute; width: 84px" Text="IsOnline"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 124px; top: 95px; position: absolute; width: 152px" height="19px"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged" style="z-index: 1; left: 124px; top: 195px; position: absolute; height: 19px; width: 152px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 13px; top: 199px; position: absolute; height: 17px; width: 84px" Text="PhoneNumber"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 124px; top: 244px; position: absolute; width: 152px" height="19px"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 15px; top: 245px; position: absolute; height: 18px; width: 84px" Text="PostCode"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged" style="z-index: 1; left: 126px; top: 298px; position: absolute; height: 19px; width: 152px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 129px; top: 406px; position: absolute; width: 152px" height="19px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 12px; position: absolute; height: 21px; top: 298px; width: 84px" Text="StreetAddress"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 15px; top: 343px; position: absolute; height: 28px; width: 84px; margin-top: 0px" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 127px; top: 339px; position: absolute; height: 19px; width: 152px; margin-bottom: 0px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 16px; position: absolute; height: 22px; width: 84px; top: 375px; margin-top: 31px; margin-bottom: 0px" Text="DateOfBirth"></asp:Label>
        </p>
        <p>
            <asp:Button ID="BtnCancel" runat="server" style="z-index: 1; left: 78px; top: 540px; position: absolute; height: 22px; width: 54px" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 128px; top: 432px; position: absolute; height: 23px; width: 78px; margin-bottom: 0px" />
        <p>
            &nbsp;</p>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 17px; top: 498px; position: absolute; height: 21px; width: 73px" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 17px; top: 536px; position: absolute; width: 30px; height: 32px" Text="OK" />
    </form>
</body>
</html>
