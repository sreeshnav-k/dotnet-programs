<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalistex1.aspx.cs" Inherits="WebApplication4.datalistex1" %>

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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DataList ID="DataList1" runat="server" >
            

            <headertemplate>
                <table style="width=900">
                    <tr>
                        <td style="width:300px">id</td>
                        <td style="width:300px">name</td>
                        <td style="width:300px">age</td>
                        <td style="width:300px">address</td>
                    </tr>
                </table>
            </headertemplate>
            <itemtemplate>
                <table style="width:1200px">
                    <tr>
                        <td style="width:300px">  
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Id") %>'></asp:Label>      
                         </td>
                        <td style="width:300px">
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("NAME") %>'></asp:Label>
                        </td>
                        <td style="width:300px">
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("AGE") %>'></asp:Label>
                        </td>
                        <td style="width:300px">
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("Address") %>'></asp:Label>

                        </td>
                        <td>
                            <a href="updatedatalist1.aspx?id=<%#DataBinder.Eval(Container.DataItem,"Id") %>">Update</a>
                        </td>

                         <td>
     <asp:Button ID="Button1" runat="server" Text="Button" CommandName="remove" CommandArgument='<%#Eval("Id") %>' OnCommand="button1_command" />
 </td>
                       
                    </tr>
                </table>
            </itemtemplate>
                </asp:DataList>
            <br />
        </div>
    </form>
</body>
</html>
