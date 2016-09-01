<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CrediSeguro2.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <div class="jumbotron">
                    <h3>Principal</h3>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-4 col-md-4 col-lg-4">
                <form id="frmPrincipal" runat="server">
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                    <div class="alert alert-info">
                        <asp:LoginName ID="LoginName1" runat="server" />
                    </div>
                </form>
            </div>
            <div class="col-xs-8 col-md-8 col-lg-8"></div>
        </div>
    </div>
</asp:Content>
