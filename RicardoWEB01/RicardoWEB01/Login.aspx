<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RicardoWEB01.Login" MasterPageFile="~/WebRicardo.Master" %>

<asp:Content ID="login_content" ContentPlaceHolderID="ContentWebRicardo" runat="server">


       <div>
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
                    <asp:Button CssClass="btn btn-primary" ID="Btn_login" runat="server" Text="Login" OnClick="Btn_login_Click" />
                </td>
            
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Belum punya akun ?Daftar disini</asp:HyperLink>
                </td>
            </tr>
        </table>

       </div>

    </asp:Content>


   