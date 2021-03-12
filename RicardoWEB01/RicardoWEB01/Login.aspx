<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RicardoWEB01.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 380px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>


        </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> <br />
                 <asp:TextBox ID="UserLogin" runat="server" Width="244px"></asp:TextBox>
            
            </td>
            
            <td>
                <asp:RequiredFieldValidator ID="UsernameVld" runat="server" ControlToValidate="UserLogin" ErrorMessage="username harus di isi" ForeColor="#FF3399"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> <br />
                <asp:TextBox ID="PassLogin" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="PasswordVld" runat="server" ErrorMessage="password harus diisi" ControlToValidate="PassLogin" ForeColor="#FF3399"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Btn_login" runat="server" Text="Login" OnClick="Btn_login_Click" />
            </td>
            
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Belum punya akun ?Daftar disini</asp:HyperLink>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
