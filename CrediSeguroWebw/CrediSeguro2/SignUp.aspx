<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CrediSeguro2.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div class="container">
            <div class="row">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class ="jumbotron">
                <h3>Creación usuario</h3>
            </div>
        </div>
    </div>
    <div class ="row">
       <div class="col-xs-1 col-md-1 col-lg-1"></div>
	   <div class="col-xs-11 col-md-11 col-lg-11">
           <form id ="frmSignUp" runat="server">
               <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" OnCreatedUser="CreateUserWizard1_CreatedUser" CompleteSuccessText="Tu cuenta ha sido creada." ConfirmPasswordLabelText="Confirmar contraseña:" CreateUserButtonText="Crear usuario" CssClass="form-group" PasswordLabelText="Contraseña:">
                   <CreateUserButtonStyle CssClass="btn btn-primary" />
                   <ErrorMessageStyle CssClass="alert alert-danger" />
                   <WizardSteps>
                       <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                       </asp:CreateUserWizardStep>
                       <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                       </asp:CompleteWizardStep>
                   </WizardSteps>
                   <CancelButtonStyle CssClass="btn btn-danger" />
               </asp:CreateUserWizard>
           </form>
	   </div>
    </div>
    </div>
</asp:Content>
