<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="YingDingWebApp.Login.Admins.Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <!-- VENDOR CSS -->
    <link rel="stylesheet" href="assets/css/bootstrap.min.css" />
    <link rel="stylesheet" href="assets/vendor/font-awesome/css/font-awesome.min.css" />
    <link rel="stylesheet" href="assets/vendor/linearicons/style.css" />
    <!-- MAIN CSS -->
    <link rel="stylesheet" href="assets/css/main.css">
    <!-- FOR DEMO PURPOSES ONLY. You should remove this in your project -->
    <link rel="stylesheet" href="assets/css/demo.css" />
    <!-- GOOGLE FONTS -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700" rel="stylesheet" />
    <!-- ICONS -->
    <link rel="apple-touch-icon" sizes="76x76" href="assets/img/apple-icon.png" />
    <link rel="icon" type="image/png" sizes="96x96" href="assets/img/favicon.png" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <div class="vertical-align-wrap">
                <div class="vertical-align-middle">
                    <div class="auth-box ">
                        <div class="left">
                            <div class="content">
                                <div class="header">
                                    <div class="logo text-center">
                                        <img src="assets/img/logo-dark.png" alt="Klorofil Logo"></div>
                                    <p class="lead">Login to your account</p>
                                </div>

                                <div class="form-group">
                                    <label for="signin-email" class="control-label sr-only">Email</label>
                                    <asp:TextBox ID="txtEmail" TextMode="Email" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="signin-password" class="control-label sr-only">Password</label>
                                    <asp:TextBox ID="txtPwd" TextMode="Password" runat="server" class="form-control" placeholder="Password"></asp:TextBox>
                                </div>
                                <%--<div class="form-group clearfix">
                                        <label class="fancy-checkbox element-left">
                                            <input type="checkbox">
                                            <span>Remember me</span>
                                        </label>
                                    </div>--%>

                                <asp:Button ID="btnSubmit" runat="server" Text="LOGIN" class="btn btn-primary btn-lg btn-block" OnClick="btnSubmit_OnClick" />
                                <div class="bottom">
                                    <span class="helper-text"><i class="fa fa-lock"></i><a href="#">Forgot password?</a></span>
                                </div>

                            </div>
                        </div>
                        <div class="right">
                            <div class="overlay"></div>
                            <div class="content text">
                                <h1 class="heading">Free Bootstrap dashboard template</h1>
                                <p>by The Develovers</p>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
