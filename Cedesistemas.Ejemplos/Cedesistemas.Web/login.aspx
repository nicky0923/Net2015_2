<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/External.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Cedesistemas.Web.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 50%;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="form-horizontal auto-style2">
        <fieldset>

            <!-- Form Name -->
            <legend>Login de usuario</legend>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="Username">User name</label>
                <div class="col-md-4">
                    <input id="Username" name="Username" type="text" placeholder="User name" class="form-control input-md" required="">
                    <span class="help-block">Username</span>
                </div>
            </div>

            <!-- Password input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="passwor">Password</label>
                <div class="col-md-4">
                    <input id="passwor" name="passwor" type="password" placeholder="Password" class="form-control input-md" required="">
                    <span class="help-block">Password</span>
                </div>
            </div>

            <!-- Button (Double) -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="button1id"></label>
                <div class="col-md-8">
                    <asp:Button runat="server" id="button1id" name="button1id" class="btn btn-success" Text="Aceptar" PostBackUrl="~/Principal.aspx"/>
                    <button id="button2id" name="button2id" class="btn btn-danger">Cancelar</button>
                </div>
            </div>

        </fieldset>
    </div>

</asp:Content>
