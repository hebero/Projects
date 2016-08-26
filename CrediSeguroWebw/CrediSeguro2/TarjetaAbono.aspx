<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="TarjetaAbono.aspx.cs" Inherits="CrediSeguro2.TarjetaAbono" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="container">
       <div class="row">
            <div class ="col-lg-10 col-md-10 col-xs-10">
                <div class="jumbotron">
                    <h2>Abono a tarjeta.</h2>
                </div>
            </div>
       </div>
        <div class="row">
            <div class="col-lg-8 col-md-8 col-xs-8">
                <form method="post" action ="TarjetaAbono.aspx" name ="frmTarjetaAbono" runat="server" class ="form-group">
                    <label>Código de tarjeta: <asp:TextBox ID="txtCodTar" runat="server" CssClass=" form-control"></asp:TextBox></label>
                    <label>Fecha: <asp:TextBox ID="txtFecha" runat="server" CssClass=" form-control"></asp:TextBox></label>
                    <label>Monto: <asp:TextBox ID="txtMonto" runat="server" CssClass=" form-control"></asp:TextBox></label>
                    <asp:Button ID="btnBuscar" runat="server" Text="Actualizar" CssClass="btn btn-default" />
                    <asp:Label ID="lblMensaje" runat="server" Text="" CssClass =" alert alert-danger"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
