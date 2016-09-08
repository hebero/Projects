<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AfiliadoAlta.aspx.cs" Inherits="CrediSeguro2.AfiliadoAlta2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-md-12 col-lg-12">
                <div class="jumbotron">
                    <h3>Alta de afiliado</h3>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-1 col-md-1 col-lg-1">
            </div>
            <div class="col-sm-11 col-md-11 col-lg-11">
                <form method="post" action="AfiliadoAlta.aspx" name="frmCliente" runat="server" class="form-vertical">
                    <div class="form-group">
                        <label>Codigo Afiliado: <asp:TextBox ID="txtAfiliado" runat="server" MaxLength ="150" Text ="0" CssClass="form-control"></asp:TextBox></label>
                        <label>Empresa: <asp:TextBox ID="txtEmpresa" runat="server" MaxLength ="150" CssClass="form-control"></asp:TextBox></label>
                        <label>Contacto: <asp:TextBox ID="txtContacto" runat="server" MaxLength ="150" CssClass="form-control"></asp:TextBox></label>
                        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn btn-primary" OnClick="btnGrabar_Click"/>
                        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="False"></asp:Label>
                        <div></div>
                        <label>Nombre local <asp:TextBox ID="txtNombreLocal" runat="server" MaxLength ="150" CssClass="form-control"></asp:TextBox></label>
                        <label>Monto máximo de crédito <asp:TextBox ID="txtCredito" runat="server"  MaxLength ="20" CssClass="form-control"></asp:TextBox></label>
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary" Visible ="False" OnClick="btnAgregar_Click"/>

                        <asp:SqlDataSource ID="sdsLocales" runat="server"></asp:SqlDataSource>
                        <asp:GridView ID="gvLocal" runat="server" CssClass="table table-striped"></asp:GridView>
                    </div>
                </form>
            </div>
        </div>
    </div>
    
</asp:Content>
