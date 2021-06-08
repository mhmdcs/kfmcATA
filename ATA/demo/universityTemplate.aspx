<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="universityTemplate.aspx.cs" Inherits="ATA.demo.universityTemplate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    <br />

    <asp:DropDownList ID="ddlUniversity" runat="server" OnSelectedIndexChanged="ddlUniversity_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <asp:DropDownList ID="ddlTemplate" runat="server" DataSourceID="SqlDataSource1_Template" DataTextField="UniversityTemplate" DataValueField="UniversityTemplateId">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1_Template" runat="server" ConnectionString="<%$ ConnectionStrings:ATA_v2ConnStr %>" SelectCommand="SELECT [UniversityTemplate], [UniversityTemplateId] FROM [UniversityTemplate]"></asp:SqlDataSource>
    <br />
    <br />


</asp:Content>
