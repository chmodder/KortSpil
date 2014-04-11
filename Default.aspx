<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
    
        <h1>Velkommen til spillet</h1>
        <h2>Stillingen er:</h2>
        <p>Du har <asp:Literal ID="LiteralSpillerPoint" runat="server"></asp:Literal> point.</p>
        <p>Computeren har <asp:Literal ID="LiteralComputerPoint" runat="server"></asp:Literal> point.</p>
        <asp:Button ID="ButtonTagKort" runat="server" Text="Spil" OnClick="ButtonTagKort_Click" />
    
</asp:Content>

