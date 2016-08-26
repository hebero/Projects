<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="TarjetaxCliente.aspx.cs" Inherits="CrediSeguro2.TarjetaxCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="container">
    		<div class="row">
			<div class="col-sm-12 col-md-12 col-xs-12">
			  			<div class="jumbotron">
			  				<h1>Tarjetas x Clientes</h1>
			  			</div>
			</div>
            </div>
                
		<div class="row">
			<div class="col-sm-4 col-md-4 col-xs-4">
                <form method="post" action="TarjetaxCliente.aspx" name ="frmTarjeta" runat ="server" class="form-group">
                    <label>Nombre: <asp:TextBox ID="txtNombre" runat="server" CssClass ="form-control"></asp:TextBox></label> 
                    <label>Apellido: <asp:TextBox ID="txtApellido" runat="server" CssClass ="form-control"></asp:TextBox></label>
                    <br />
                    <asp:Button ID="btnBuscar" runat="server" CssClass ="btn btn-primary" Text="Buscar" OnClick="btnBuscar_Click" />
                    <asp:SqlDataSource ID="SQLDataSource" runat="server"></asp:SqlDataSource>
                    <asp:GridView ID="gvTarjeta" runat="server" CssClass ="table table-bordered"></asp:GridView>
                </form>
                    <asp:Label ID="lblAlert" runat="server" Visible="false" Text=""></asp:Label>
			</div>
		</div>
    </div>
</asp:Content>
