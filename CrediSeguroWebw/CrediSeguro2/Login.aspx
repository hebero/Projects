<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CrediSeguro2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
<div class="container">
    <div class ="row">
        <div class =" col-xl-4 col-lg-4 col-xl-4">
        </div>  
        <div class =" col-xs-4 col-lg-4 col-md-4 col-xl-4" >
            <br />
            <br />
            <br />
            <br />
            <br />

            <form id ="frmLogin" runat="server" class="form-group">
                <asp:Login ID="Login1" runat="server"></asp:Login>
            </form>
        </div>
        <div class =" col-xs-4 col-lg-4 col-md-4 col-xl-4" >
        </div>
    </div>
</div>
</asp:Content>
