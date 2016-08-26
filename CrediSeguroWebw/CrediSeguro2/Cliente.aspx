<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="CrediSeguro2.Cliente" %>
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
        <div class ="col-lg-4 col-md-4 col-xl-4">

        </div>
        <div class ="col-xs-6 col-md-6 col-md-6">
            <form method="post" action="Cliente.aspx" name="frmCliente" runat="server" class="form-group">
                <label>Nombre:
                <asp:TextBox ID="txNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </label>
                <label>Apellido:<asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox> </label>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click"/>
                <asp:SqlDataSource ID="SQLdsCrediSeguro" runat="server"></asp:SqlDataSource>
                <asp:GridView ID="gvClientes" CssClass="table table-bordered" runat="server"></asp:GridView>
            </form>
        </div>
    </div>

</asp:Content>
