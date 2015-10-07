<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/External.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Cedesistemas.Web.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 50%;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/Principal.aspx">
</asp:Login>
    
    jkjkj

<asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
    <WizardSteps>
        <asp:CreateUserWizardStep runat="server" />
        <asp:CompleteWizardStep runat="server" />
    </WizardSteps>
</asp:CreateUserWizard>

</asp:Content>
