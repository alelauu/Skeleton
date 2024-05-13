<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Staff Form
    </title>
    <style type="text/css">
       
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 17px;
            position: absolute;
            height: 19px;
            width: 114px;
        }
        .auto-style2 {
            position: absolute;
            top: 13px;
            left: 105px;
            z-index: 1;
            width: 130px;
            height: 20px;
        }
        .auto-style4 {
            z-index: 1;
            left: 15px;
            top: 250px;
            position: absolute;
        }
       
        .auto-style5 {
            bottom: 598px;
        }
        .auto-style6 {
            z-index: 1;
            left: 105px;
            top: 43px;
            position: absolute;
        }
        .auto-style7 {
            left: 105px;
            top: 166px;
        }
        .auto-style8 {
            position: absolute;
            top: 14px;
            left: 265px;
            z-index: 1;
        }
        .auto-style9 {
            left: 105px;
            top: 73px;
        }
        .auto-style10 {
            right: 744px;
        }
        .auto-style11 {
            left: 105px;
            top: 104px;
        }
        .auto-style12 {
            left: 105px;
            top: 135px;
        }
        .auto-style13 {
            right: 719px;
        }
       
        .auto-style15 {
            height: 325px;
        }
       
        .auto-style16 {
            position: absolute;
            top: 286px;
            left: 110px;
            z-index: 1;
        }
       
        .auto-style17 {
            right: 1097px;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style15">

  <asp:TextBox ID="txtFullName" runat="server" height="22px" width="128px" CssClass="auto-style6"></asp:TextBox>
  <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; position: absolute" height="22px" width="128px" CssClass="auto-style9"></asp:TextBox>
  <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; position: absolute" height="22px" width="128px" CssClass="auto-style11"></asp:TextBox>
  <asp:TextBox ID="txtNumber" runat="server" style="z-index: 1; position: absolute" height="22px" width="128px" CssClass="auto-style12"></asp:TextBox>
  <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; position: absolute" height="22px" width="128px" CssClass="auto-style7"></asp:TextBox>   
  <asp:CheckBox ID="chkIsOnline" runat="server" style="z-index: 1; left: 23px; top: 208px; position: absolute" Text="Is Online" />
  <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 286px; position: absolute" Text="OK" height="26px" width="60px" CssClass="auto-style17" />
  <asp:Button ID="btnCancel" runat="server" CssClass="auto-style16" Text="Cancel" height="26px" width="60px" />

  

  <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" CssClass="auto-style1"></asp:Label>
  <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 77px; position: absolute" Text="Email" height="19px" width="114px"></asp:Label>
  <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 108px; position: absolute; width: 123px;" Text="Address" height="19px" CssClass="auto-style10"></asp:Label>
  <asp:Label ID="lblNumber" runat="server" style="z-index: 1; left: 10px; top: 139px; position: absolute; width: 141px;" Text="Number" height="19px"></asp:Label>
  <asp:Label ID="lblError" runat="server" CssClass="auto-style4"></asp:Label>
  <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 10px; top: 170px; position: absolute; width: 148px;" Text="Start Date" CssClass="auto-style13"></asp:Label>
  <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 10px; top: 47px; position: absolute; height: 19px; width: 114px;" Text="Full Name" CssClass="auto-style5"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" CssClass="auto-style2" height="22px" width="128px"></asp:TextBox>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" CssClass="auto-style8" Text="Find" OnClick="btnFind_Click" />
            
            
             
            
            
             </div>
    </form>
</body>
</html>
