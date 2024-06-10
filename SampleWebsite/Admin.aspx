<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="SampleWebsite.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
            color: #000066;
        }
        .auto-style2 {
            font-weight: normal;
            text-decoration: none;
            font-size: medium;
        }
        .auto-style3 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="sec-login">
    <div class="sec-login-heading-area">
        <h1>Admin Area</h1>
        <div class="heading-line"></div>
        <div class="heading-line"></div>
    </div>
    <div class="sec-login-box-main">
            <h3>Welcome
                <asp:Label ID="Label1" runat="server" CssClass="auto-style1"></asp:Label>
&nbsp;|
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="auto-style2" ForeColor="Black" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
            </h3>
        <div class="admin-area-gridview">
                &nbsp;<!-- We will add Gridview here -->
            <div class="table-container">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="auto-style3">
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="ContactRegistration" DataSourceID="SqlDataSource1" Font-Size="18px" ForeColor="Black" ShowFooter="True" Width="100%" CellSpacing="3">
                                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                                <Columns>
                                    <asp:BoundField DataField="Name" HeaderText="NAME" SortExpression="Name">
                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Email" HeaderText="EMAIL" SortExpression="Email" />
                                    <asp:BoundField DataField="Phone" HeaderText="PHONE" SortExpression="Phone" />
                                    <asp:BoundField DataField="Message" HeaderText="MESSAGE" SortExpression="Message" />
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>
                                <FooterStyle BackColor="Tan" />
                                <HeaderStyle BackColor="Tan" Font-Bold="True" HorizontalAlign="Left" VerticalAlign="Middle" BorderStyle="Double" BorderWidth="10px" />
                                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                            </asp:GridView>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ContactRegistration], [Name], [Email], [Phone], [Message] FROM [Contact]" DeleteCommand="DELETE FROM [Contact] WHERE [ContactRegistration] = @ContactRegistration" InsertCommand="INSERT INTO [Contact] ([Name], [Email], [Phone], [Message]) VALUES (@Name, @Email, @Phone, @Message)" UpdateCommand="UPDATE [Contact] SET [Name] = @Name, [Email] = @Email, [Phone] = @Phone, [Message] = @Message WHERE [ContactRegistration] = @ContactRegistration">
                        <DeleteParameters>
                            <asp:Parameter Name="ContactRegistration" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Name" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Phone" Type="Decimal" />
                            <asp:Parameter Name="Message" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Name" Type="String" />
                            <asp:Parameter Name="Email" Type="String" />
                            <asp:Parameter Name="Phone" Type="Decimal" />
                            <asp:Parameter Name="Message" Type="String" />
                            <asp:Parameter Name="ContactRegistration" Type="Int32" />
                        </UpdateParameters>
                </asp:SqlDataSource>
                </div>
                <!-- We will add Gridview here -->
            </div>
        </div>
</section>
</asp:Content>
