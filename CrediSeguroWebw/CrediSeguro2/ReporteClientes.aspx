<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ReporteClientes.aspx.cs" Inherits="CrediSeguro2.ReporteClientes" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
        <div class="container">
       <div class="row">
            <div class ="col-lg-10 col-md-10 col-xs-10">
                <div class="jumbotron">
                    <h2>Reporte cliente.</h2>
                </div>
            </div>
       </div>
        <div class="row">
            <div class="col-lg-8 col-md-8 col-xs-8">
                <form method="post" action ="ReporteClientes.aspx" name ="frmReporte" runat="server" class ="form-group">
                    <asp:Button ID="btnReporte" runat="server" Text="Ver reportes" OnClick="btnReporte_Click" CssClass ="btn btn-primary"/>
                    <br />
                    <br />
                    <asp:ScriptManager ID="smRptCliente" runat="server"></asp:ScriptManager>
                    <rsweb:ReportViewer ID="rvClientes" runat="server" Width =" 950px"></rsweb:ReportViewer>
                    <br />
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
