<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ClienteDelete.aspx.cs" Inherits="CrediSeguro2.ClienteDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="container">
       <div class="row">
            <div class ="col-lg-10 col-md-10 col-xs-10">
                <div class="jumbotron">
                    <h2>Eliminar cliente.</h2>
                </div>
            </div>
       </div>
        <div class="row">
            <div class="col-lg-8 col-md-8 col-xs-8">
                <form method="post" action ="ClienteDelete.aspx" name ="frmDelteCliente" runat="server" class ="form-group">
                    <label>Codigo de Cliente: <asp:TextBox ID="txtCodCliente" runat="server" CssClass ="form-control"></asp:TextBox></label>
                    <asp:Button ID="btnBorrar" runat="server" Text="Eliminar" CssClass ="btn btn-danger" OnClick="btnBorrar_Click"/>
                    <asp:Label ID="lblMensaje" runat="server" Text="" CssClass="alert" Visible ="false"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
