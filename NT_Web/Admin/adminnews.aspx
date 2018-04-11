<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminnews.aspx.cs" Inherits="NT_Web.Admin.adminnews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table class="table" style="border-collapse:separate; border-spacing:0px 20px; ">
            <tr class="tr1">
                <td style="width:15%;">用户名</td>
                <td style="width:22%;">用户密码</td>
                <td style="width:27%;">邮箱地址</td>
                <td style="width:13%;">用户电话</td>
                <td style="width:13%;">操作</td>
                <td style="width:10%;"></td>
            </tr>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>                                
            <tr class="tr2">
                    <td><asp:HyperLink ID="hp1"  runat="server" ForeColor="Black" CssClass="text" Text='<%# SplitChar(Eval("News_Title").ToString(),10) %>' ></asp:HyperLink></td> 
                    <td><asp:Label ID="AssID" runat="server" Text='<%#Eval("News_Time") %>'></asp:Label></td>                    
                    <td ><asp:Label ID="acttime" runat="server" Text='<%#Eval("News_Content") %>'></asp:Label></td>     
                    <td ><asp:Label ID="endtime" runat="server" Text='<%#Eval("News_Url") %>'></asp:Label></td> 
                    <td ><asp:Label ID="Label1" runat="server" Text='<%#Eval("News_Img") %>'></asp:Label></td>           
                    <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("News_ID")%>' />
                        <asp:Button ID="btnDelete" runat="server" Text="删除"  OnClick="btnDelete_Click"  OnClientClick="return confirm('确认删除？')"/>
                    </td>
            </tr>
              </ItemTemplate>
            </asp:ListView>
        </table>
    </div>
    </form>
</body>
</html>
