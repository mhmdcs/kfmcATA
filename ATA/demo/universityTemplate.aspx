<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="universityTemplate.aspx.cs" Inherits="ATA.demo.universityTemplate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    <br />

    <asp:DropDownList ID="ddlUniversity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlUniversity_SelectedIndexChanged1"></asp:DropDownList>
    <br />
    <asp:DropDownList ID="ddlTemplate" runat="server">
    </asp:DropDownList>
    <br />
    <br />


</asp:Content>
