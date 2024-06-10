<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChangeAdminPassword.aspx.cs" Inherits="SampleWebsite.ChangeAdminPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="sec-login">
    <div class="sec-login-heading-area">
        <h1>Change Password</h1>
        <div class="heading-line"></div>
        <div class="heading-line"></div>
    </div>
    <div class="sec-login-box-main">
        <div class="sec-login-form">
            <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox1" placeholder="New Password" runat="server" class="login-txt-box"></asp:TextBox>
            <asp:TextBox ID="TextBox2" placeholder="Confirm Password" runat="server" class="login-txt-box"></asp:TextBox>
            <div class="sec-login-area">
                <asp:Button ID="Button1" runat="server" Text="Change Password" class="btn-login" OnClick="Button1_Click"/>
            </div>
            <div class="sec-login-area">
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </div>
    </div>
</section>
</asp:Content>
