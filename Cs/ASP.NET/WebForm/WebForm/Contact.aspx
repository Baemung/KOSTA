<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100<asp:Xml ID="Xml1" runat="server"></asp:Xml>
    </address>
    <address>
        &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="144px" OnClick="ImageButton1_Click" Width="276px" />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="140px" Width="294px" />
    </address>
</asp:Content>
