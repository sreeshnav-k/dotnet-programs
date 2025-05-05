<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webform24image.aspx.cs" Inherits="WebApplication1.webform24image" %>

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
            <asp:Image ID="Image1" runat="server" Height="277px" ImageUrl="https://bottindia.com/wp-content/uploads/2023/06/philipp-kammerer-6Mxb_mZ_Q8E-unsplash.jpg" Width="400px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://www.traveltalktours.com/wp-content/uploads/2021/01/turkey-dest.jpg" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
