<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm25multiview.aspx.cs" Inherits="WebApplication1.WebForm25multiview" %>

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
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="1st view"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GO TO VIEW2" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Label ID="Label2" runat="server" Text="2ND view"></asp:Label>
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="GO TO VIEW3" />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Label ID="Label3" runat="server" Text="3RD view"></asp:Label>
                    <br />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="GO TO VIEW1" />
                </asp:View>

            </asp:MultiView>
        </div>
    </form>
</body>
</html>
