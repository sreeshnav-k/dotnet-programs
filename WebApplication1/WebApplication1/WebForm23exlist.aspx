<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm23exlist.aspx.cs" Inherits="WebApplication1.WebForm23exlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem Value="1">item1</asp:ListItem>
                <asp:ListItem Value="2">item2</asp:ListItem>
                <asp:ListItem Value="3">item3</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click">
                <asp:ListItem Value="1">product 1</asp:ListItem>
                <asp:ListItem Value="2">product 2</asp:ListItem>
                <asp:ListItem Value="3">product 3</asp:ListItem>
            </asp:BulletedList>
        </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
