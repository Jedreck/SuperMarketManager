<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SuperMarketManager.Views.Login.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <meta name="keywords" content="Flat Dark Web Login Form Responsive Templates, Iphone Widget Template, Smartphone login forms,Login form, Widget Template, Responsive Templates, a Ipad 404 Templates, Flat Responsive Templates" />
    <link href="../../Content/css/style.css" rel='stylesheet' type='text/css' />
</head>
<body>
    <script>$(document).ready(function (c) {
            $('.close').on('click', function (c) {
                $('.login-form').fadeOut('slow', function (c) {
                    $('.login-form').remove();
                });
            });
        });
    </script>
    <!--SIGN UP-->
    <h1>超市管理系统</h1>
    <div class="login-form">
        <div class="close"></div>
        <div class="head-info">
            <label class="lbl-1"></label>
            <label class="lbl-2"></label>
            <label class="lbl-3"></label>
        </div>
        <div class="clear"></div>
        <div class="avtar">
        </div>
        <form runat="server">
            <input type="text" id="userid" class="text" runat="server" pattern="[0-9]{8}" placeholder="请输入8位数工号">
            <div class="key">
                <input type="password" id="password" placeholder="请输入密码" runat="server">
            </div>
            <div class="signin">
                <asp:Button ID="Button1" runat="server" Text="登录" OnClick="login_button_Click" />
            </div>
        </form>
    </div>
</body>
</html>
