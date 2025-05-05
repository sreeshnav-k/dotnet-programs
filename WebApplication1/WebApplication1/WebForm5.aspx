<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:gray;
        }
        .sam{
            border:dashed 2px solid black;
            margin-left:auto;
        }
        #button1:hover{
            background-color:brown;
        }

    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div class="sam" style="margin-left: 200px">
            <p style="margin-left: 120px">
                &nbsp;</p>
            <p style="margin-left: 120px">
                &nbsp;</p>
            <p style="margin-left: 0px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; STUDENT DETAILS</p>
            <p style="margin-left: 160px">
                <asp:Label ID="Label1" runat="server" Text="NAME"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 160px">
                <asp:Label ID="Label2" runat="server" Text="CHEMISTRY"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 160px">
                <asp:Label ID="Label3" runat="server" Text="BIOLOGY"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 160px">
                <asp:Label ID="Label4" runat="server" Text="PHYSICS"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 160px">
                <asp:Label ID="Label5" runat="server" Text="MATHS"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </p>
            <p style="margin-left: 160px">
                &nbsp;</p>
            <p style="margin-left: 280px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
            </p>
            <p style="margin-left: 160px">
                <asp:Label ID="Label6" runat="server" Text="TOTAL MARKS"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p style="margin-left: 160px">
                <asp:Label ID="Label7" runat="server" Text="AVERAGE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server"></asp:Label>
&nbsp;
            </p>
            <p style="margin-left: 200px">
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
