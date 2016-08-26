<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="MovsxTarjeta.aspx.cs" Inherits="CrediSeguro2.MovsxTarjeta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
 <div class ="container">
       	<div class="row">
			<div class="col-sm-12 col-md-12 col-xs-12">
                <div class="jumbotron">
                    <h1>Movimientos x Tarjeta</h1>
                </div>
			</div>
		</div>
    	<div class="row">
			<div class="col-sm-1 col-md-1 col-xs-1">

			</div>
		</div>
    	<div class="row">
			<div class="col-sm-8 col-md-8 col-xs-8">
                <form method ="post" action ="MovsxTarjeta.aspx" name="frmMovs" runat ="server" class="form-group">
                    <asp:TextBox ID="txtCod" runat="server" CssClass ="form-control"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass=" btn btn-default" OnClick="btnBuscar_Click" />
                    <asp:SqlDataSource ID="SQLDataSourceMovs" runat="server"></asp:SqlDataSource>
                    <asp:GridView ID="gvMovs" runat="server" class="table table-bordered"></asp:GridView>
                </form>
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
			</div>
		</div>
     </div>
</asp:Content>
