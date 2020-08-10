<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

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
        <p>
            </p>
        <div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this Order?"></asp:Label>
                <br />
            </div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="height: 21px" Text="Yes" Width="53px" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="57px" />
        </div>
    </form>
</body>
</html>
