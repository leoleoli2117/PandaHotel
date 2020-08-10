<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

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
            text-align:center;
            font-size:2em;
        }
        </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            </p>
        <div>
            <asp:Label ID="lblOrderNo" runat="server" Text="OrderNo"></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="OrderDate"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkStatus" runat="server" Text="Status" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="52px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
