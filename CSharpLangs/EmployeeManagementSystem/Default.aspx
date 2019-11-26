<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmployeeManagementSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        Enter Name
    </div>
    <div>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="ButtonNext"   runat="server" Text="Next" OnClick="ButtonNext_Click" />
    </div>
    <asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click"/>
</asp:Content>
