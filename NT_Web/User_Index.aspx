<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Index.aspx.cs" Inherits="NT_Web.User_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
         
            <%--用户修改信息 --%>
            <div>
                <table>
                    <tr>
                        <td>姓名：</td>
                        <td>
                            <asp:TextBox ID="User_Name" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>头像：</td>
                        <td>
                            <asp:Image ID="User_Img" runat="server" CssClass="img-circle" Height="62px" Width="64px" />
                            <asp:FileUpload ID="FileUpload_img" runat="server" />
                        <td></td>
                    </tr>
                    <tr>
                        <td>密码：</td>
                        <td>
                            <asp:TextBox ID="User_Password" runat="server"></asp:TextBox>

                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>电话：</td>
                        <td>
                            <asp:TextBox ID="User_Phone" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>邮箱：</td>
                        <td>
                            <asp:TextBox ID="User_Email" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Change" runat="server" Text="修改" OnClick="Change_Click" />
                        </td>
                        <td>
                            <asp:Button ID="noChange" runat="server" Text="重置" OnClick="noChange_Click" />
                        </td>
                    </tr>
                </table>

            </div>

            <%--ACG投稿管理 --%>
            <div>
                <table class="data display datatable" id="example">
                    <thead>
                    </thead>
                    <asp:ListView ID="UserIndex_Acg" runat="server">
                        <ItemTemplate>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:HyperLink ID="Pro_Title" runat="server" ForeColor="Black" CssClass="text" Text='<%# SplitChar(Eval("Pro_Title").ToString(),10) %>' NavigateUrl='<%# "../.aspx?prosid="+ Eval("Pro_ID") %>'></asp:HyperLink>
                                    </td>
                                    <td>
                                        <asp:Label ID="Pro_Time" runat="server" Text='<%# Eval("Pro_Time") %>'></asp:Label>
                                    </td>

                                    <td style="text-align: left">
                                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Pro_ID")%>' />

                                        <asp:HyperLink CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="删除" NavigateUrl='<%#"~/User_Index.aspx?proid="+ Eval("Pro_ID")%>' OnClientClick="return confirm('确认删除？')" Height="25px" Font-Size="12px" />
                                    </td>
                                </tr>
                            </tbody>
                        </ItemTemplate>
                    </asp:ListView>
                </table>
            </div>
            <div class="sxy">
                共有<span id="totalRows" runat="server"></span>条   
 <span id="totalPage" runat="server"></span>
                <asp:DataPager runat="server" PagedControlID="UserIndex_Acg" PageSize="4" ID="DDPager">
                    <Fields>
                        <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                        <asp:NumericPagerField ButtonCount="4" />
                        <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                    </Fields>
                </asp:DataPager>
            </div>
        </div>
    </form>
</body>
</html>
