<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body
        {
            background-color:yellow;
        }
        p
        {
            background-color:red;
        }
        </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                </p>
            <asp:Label ID="lblCustomerName" runat="server" Text="CustomerName"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerEmail" runat="server" Text="CustomerEmail"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerMobile" runat="server" Text="CustomerMobile"></asp:Label>
            <asp:TextBox ID="txtCustomerMobile" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="CheckBoxActive" runat="server" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Height="21px" OnClick="btnOK_Click" Text="OK" Width="56px" />
            <asp:Button ID="btnCancel" runat="server" Height="21px" OnClick="btnCancel_Click" Text="Cancel" Width="61px" />
        </div>
    </form>
</body>
</html>
