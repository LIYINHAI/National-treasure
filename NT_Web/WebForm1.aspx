<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NT_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<asp:listview runat="server"  ID="user" >
    <AlternatingItemTemplate>
        <tr style="">
            <td>
                <asp:Label ID="User_IDLabel" runat="server" Text='<%# Eval("User_ID") %>' />
            </td>
            <td>
                <asp:Label ID="User_NameLabel" runat="server" Text='<%# Eval("User_Name") %>' />
            </td>
            <td>
                <asp:Label ID="User_PasswordLabel" runat="server" Text='<%# Eval("User_Password") %>' />
            </td>
            <td>
                <asp:Label ID="User_ImgLabel" runat="server" Text='<%# Eval("User_Img") %>' />
            </td>
            <td>
                <asp:Label ID="User_EmailLabel" runat="server" Text='<%# Eval("User_Email") %>' />
            </td>
            <td>
                <asp:Label ID="User_PhoneLabel" runat="server" Text='<%# Eval("User_Phone") %>' />
            </td>
        </tr>
    </AlternatingItemTemplate>
    <EditItemTemplate>
        <tr style="">
            <td>
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
            </td>
            <td>
                <asp:Label ID="User_IDLabel1" runat="server" Text='<%# Eval("User_ID") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_NameTextBox" runat="server" Text='<%# Bind("User_Name") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_PasswordTextBox" runat="server" Text='<%# Bind("User_Password") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_ImgTextBox" runat="server" Text='<%# Bind("User_Img") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_EmailTextBox" runat="server" Text='<%# Bind("User_Email") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_PhoneTextBox" runat="server" Text='<%# Bind("User_Phone") %>' />
            </td>
        </tr>
    </EditItemTemplate>
    <EmptyDataTemplate>
        <table runat="server" style="">
            <tr>
                <td>未返回数据。</td>
            </tr>
        </table>
    </EmptyDataTemplate>
    <InsertItemTemplate>
        <tr style="">
            <td>
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="User_NameTextBox" runat="server" Text='<%# Bind("User_Name") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_PasswordTextBox" runat="server" Text='<%# Bind("User_Password") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_ImgTextBox" runat="server" Text='<%# Bind("User_Img") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_EmailTextBox" runat="server" Text='<%# Bind("User_Email") %>' />
            </td>
            <td>
                <asp:TextBox ID="User_PhoneTextBox" runat="server" Text='<%# Bind("User_Phone") %>' />
            </td>
        </tr>
    </InsertItemTemplate>
    <ItemTemplate>
        <tr style="">
            <td>
                <asp:Label ID="User_IDLabel" runat="server" Text='<%# Eval("User_ID") %>' />
            </td>
            <td>
                <asp:Label ID="User_NameLabel" runat="server" Text='<%# Eval("User_Name") %>' />
            </td>
            <td>
                <asp:Label ID="User_PasswordLabel" runat="server" Text='<%# Eval("User_Password") %>' />
            </td>
            <td>
                <asp:Label ID="User_ImgLabel" runat="server" Text='<%# Eval("User_Img") %>' />
            </td>
            <td>
                <asp:Label ID="User_EmailLabel" runat="server" Text='<%# Eval("User_Email") %>' />
            </td>
            <td>
                <asp:Label ID="User_PhoneLabel" runat="server" Text='<%# Eval("User_Phone") %>' />
            </td>
        </tr>
    </ItemTemplate>
    <LayoutTemplate>
        <table runat="server">
            <tr runat="server">
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                        <tr runat="server" style="">
                            <th runat="server">User_ID</th>
                            <th runat="server">User_Name</th>
                            <th runat="server">User_Password</th>
                            <th runat="server">User_Img</th>
                            <th runat="server">User_Email</th>
                            <th runat="server">User_Phone</th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server">
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server">
                <td runat="server" style=""></td>
            </tr>
        </table>
    </LayoutTemplate>
    <SelectedItemTemplate>
        <tr style="">
            <td>
                <asp:Label ID="User_IDLabel" runat="server" Text='<%# Eval("User_ID") %>' />
            </td>
            <td>
                <asp:Label ID="User_NameLabel" runat="server" Text='<%# Eval("User_Name") %>' />
            </td>
            <td>
                <asp:Label ID="User_PasswordLabel" runat="server" Text='<%# Eval("User_Password") %>' />
            </td>
            <td>
                <asp:Label ID="User_ImgLabel" runat="server" Text='<%# Eval("User_Img") %>' />
            </td>
            <td>
                <asp:Label ID="User_EmailLabel" runat="server" Text='<%# Eval("User_Email") %>' />
            </td>
            <td>
                <asp:Label ID="User_PhoneLabel" runat="server" Text='<%# Eval("User_Phone") %>' />
            </td>
        </tr>
    </SelectedItemTemplate>
        </asp:listview>
        
    </div>
    </form>
</body>
</html>
