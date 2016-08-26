<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ClienteAlta.aspx.cs" Inherits="CrediSeguro2.ClienteAlta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="row">
        <div class="col-sm-12 col-lg-12 col-md-12">
            <div class ="jumbotron">
                <h1>Clientes</h1>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="col-xs-1 col-md-1 col-lg-1">

        </div>
        <div class="col-lg-11 col-md-11 col-xs-11">
            <form method="post" action="ClienteAlta.aspx" name="frmCliente" runat ="server" class="form-vertical">
                <div class ="form-group">
                    <label>Nombre Primero: <asp:TextBox ID="txtNomP" CssClass="form-control" runat="server"></asp:TextBox></label>
                    <label>Nombre Segundo: <asp:TextBox ID="txtNomS" CssClass="form-control" runat="server"></asp:TextBox></label>
                    <label>Apellido Primero: <asp:TextBox ID="txtApeP" CssClass="form-control" runat="server"></asp:TextBox></label>
                    <label>Segundo Apellido: <asp:TextBox ID="txtApeS" CssClass="form-control" runat="server"></asp:TextBox></label>
                    <label>DPI: <asp:TextBox ID="txtDPI" CssClass="form-control" runat="server"></asp:TextBox></label>
                    <label>NIT: <asp:TextBox ID="txtNIT" CssClass="form-control" runat="server"></asp:TextBox></label>
                    <label>Fecha Nacimiento: <asp:TextBox ID="txtFNac" CssClass="form-control" runat="server"></asp:TextBox></label>
                    <asp:Button ID="bGrabar" runat="server" Text="Grabar" OnClick="bGrabar_Click" />
                    <asp:Label ID="lblMensaje" runat="server" Text="" Visible ="False"></asp:Label>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
