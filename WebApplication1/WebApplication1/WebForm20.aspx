<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm20.aspx.cs" Inherits="WebApplication1.WebForm20" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 263px;
            height: 105px;
        }
        .auto-style4 {
            height: 105px;
        }
        .auto-style5 {
            width: 263px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="798px">
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="DATA FORM"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <table style="width: 51%; height: 319px; margin-right: 0px; border:solid 2PX">
                    <tr>
                        <td class="auto-style3">
                            &nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label8" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                        <td class="auto-style4"></td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;
                            <asp:Label ID="Label3" runat="server" Text="QUALIFICATION"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Value="-1">----SELECT ANY---</asp:ListItem>
                                <asp:ListItem Value="1">B-TECH</asp:ListItem>
                                <asp:ListItem Value="2">BSC</asp:ListItem>
                                <asp:ListItem Value="3">MSC</asp:ListItem>
                                <asp:ListItem Value="4">PHD</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:Label ID="Label9" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;
                            <asp:Label ID="Label4" runat="server" Text="GENDER"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" Text="MALE" />
                            &nbsp;&nbsp;
                            <asp:RadioButton ID="RadioButton2" runat="server" Text="FEMALE" />
                            &nbsp;&nbsp;
                            <asp:RadioButton ID="RadioButton3" runat="server" Text="OTHERS" />
                            <br />
                            <asp:Label ID="Label10" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;
                            <asp:Label ID="Label5" runat="server" Text="ADDRESS"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label11" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;
                            <asp:Label ID="Label6" runat="server" Text="DISTRICT"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem Value="-1">--SELECT DISTRICT--</asp:ListItem>
                                <asp:ListItem Value="1">THRISSUR</asp:ListItem>
                                <asp:ListItem Value="2">CALICUT</asp:ListItem>
                                <asp:ListItem Value="3">VADAKARA</asp:ListItem>
                                <asp:ListItem Value="4">KANNUR</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:Label ID="Label12" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox1" runat="server" Text="CONFIRM DATA" />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#00CC00" Height="40px" Text="SUBMIT" Width="131px" OnClick="Button1_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#CC0000" Height="43px" Text="RESET" Width="117px" OnClick="Button2_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
