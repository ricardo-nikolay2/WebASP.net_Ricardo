﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RicardoWEB01.Register" MasterPageFile="~/WebRicardo.Master"%>

<asp:Content ID="REgister_content" ContentPlaceHolderID="ContentWebRicardo" runat="server">
        <h1>Registrasi Form</h1>

        <div>
             <table class="auto-style1">
        <tr>
            <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> <br />
            <asp:TextBox ID="Username" runat="server"></asp:TextBox> 
            </td>

            <td>
                <asp:RequiredFieldValidator ID="RequiredUserName" runat="server" ErrorMessage="Username Belum di isi" ControlToValidate="Username" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> <br />   
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox> 
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredPassword" runat="server" ErrorMessage="Password harus di isi" ControlToValidate="Password" ForeColor="#FF0066"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Konfirmasi Password"></asp:Label> <br />     
                <asp:TextBox ID="PassConf" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="ComparePassword" runat="server" ErrorMessage="Password tidak sama" ControlToCompare="Password" ControlToValidate="PassConf" ForeColor="#FF0066"></asp:CompareValidator>
                &nbsp <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PassConf" ErrorMessage="Konfirmasi password harus di isi"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label><br /> 
                <asp:TextBox ID="Email" runat="server"></asp:TextBox> 
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ErrorMessage="Email harus di isi" ControlToValidate="Email" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                &nbsp <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="masukkan email yang benar" ControlToValidate="Email" ForeColor="#FF0066" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">

                <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label><br /> 
                <asp:DropDownList ID="Gender" runat="server" Width="165px">
                    <asp:ListItem>=Pilih=</asp:ListItem>
                    <asp:ListItem>Pria</asp:ListItem>
                    <asp:ListItem>Wanita</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Gender" ErrorMessage="Pilih Gender" ForeColor="#FF0066" InitialValue="=Pilih="></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" Text="Daftar" OnClick="Button_Daftar" />&nbsp &nbsp
                <input id="Reset1" class="auto-style3" type="reset" value="reset" /></td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">kembali ke Login</asp:HyperLink>
            </td>
        </tr>
    </table>
           
        </div>
   
    </asp:Content>