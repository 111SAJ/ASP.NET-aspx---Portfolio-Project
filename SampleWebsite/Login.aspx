<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SampleWebsite.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-decoration: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="sec-login">
    <div class="sec-login-heading-area">
        <h1>Admin Login</h1>
        <div class="heading-line"></div>
        <div class="heading-line"></div>
    </div>
    <div class="sec-login-box-main">
        <div class="sec-login-form">
            <%--<input type="text" id="username" class="login-txt-box" placeholder="Username">--%>
            <asp:TextBox ID="TextBox1" placeholder="Username" runat="server" Class="login-txt-box"></asp:TextBox>
            <%--<input type="text" id="password" class="login-txt-box" placeholder="Password">--%>
            <asp:TextBox ID="TextBox2" placeholder="Password" runat="server" class="login-txt-box" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            <div class="sec-login-area">
                <%--<button id="btn-login" class="btn-login">LOGIN</button>--%>
                <asp:Button ID="Button1" runat="server" Text="Login" class="btn-login" OnClick="Button1_Click"/>
                <a href="SendActivationCode.aspx" class="auto-style1">Forgot Password?</a>
            </div>
        </div>
    </div>
</section>
</asp:Content>
