<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 392px">
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="21px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 78px; margin-top: 1px" Width="249px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="FullName "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Height="18px" style="margin-left: 93px" Width="246px"></asp:TextBox>
        </p>
&nbsp;<div>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 124px" Width="241px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label4" runat="server" Text="StreetAddress "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 67px" Width="239px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="PostCode"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 98px" Width="237px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="PhoneNumber"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 72px" Width="233px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="DateOfBirth"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 86px" Width="234px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkIsOnline" runat="server" OnCheckedChanged="chkIsOnline_CheckedChanged" Text="Is Online" />
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="brnOK" runat="server" style="margin-left: 21px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Height="27px" OnClick="btnCancel_Click1" style="margin-left: 62px; margin-top: 0px" Text="Cancel" />
    </form>
</body>
</html>
