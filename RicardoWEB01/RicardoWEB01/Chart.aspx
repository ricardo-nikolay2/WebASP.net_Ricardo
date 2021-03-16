<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chart.aspx.cs" Inherits="RicardoWEB01.Chart" MasterPageFile="~/WebRicardo.Master"%>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="REgister_content" ContentPlaceHolderID="ContentWebRicardo" runat="server">
        <div>
            <h1>Chart</h1>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RicardoDB01Conn %>" SelectCommand="SELECT * FROM [Barang]"></asp:SqlDataSource>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="977px" Height="340px">
            <series>
                <asp:Series Name="Series1" XValueMember="NamaBarang" YValueMembers="JumlahBarang">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
   </asp:Content>