<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="ATA.demo.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
        </p>
    <table class="nav-justified">
        <tr>
            <td class="modal-sm" style="width: 243px;">This is the registration form</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" colspan="2" style="text-align: center">
                <asp:Label ID="lblOutput" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="text-align: center">Student</td>
            <td>
                <asp:TextBox ID="txtStudent" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="text-align: center">Active</td>
            <td style="margin-left: 40px">
                <asp:RadioButton ID="rbtnActive" runat="server" Text="Yes" GroupName="activeGroup" />
                <asp:RadioButton ID="rbtnActive2" runat="server" Text="No" GroupName="activeGroup" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="text-align: center">Gender</td>
            <td style="height: 22px">
                <asp:DropDownList ID="ddlGender" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="text-align: center">Allowance</td>
            <td style="height: 22px">
                <asp:TextBox ID="txtAllowance" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 243px">&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            </td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>
