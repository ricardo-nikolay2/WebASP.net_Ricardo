<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RicardoWEB01.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Registrasi Form</h1>

        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />

            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> <br />   
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /> 
            
            <asp:Label ID="Label3" runat="server" Text="Konfirmasi Password"></asp:Label> <br />     
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /> 
            
            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label><br /> 
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /> 
            
            <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label><br /> 
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br /> 


           
        </div>
    </form>
</body>
</html>
