﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsManager.aspx.cs" Inherits="SuperMarketManager.Views.GoodsManager" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>商品信息</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="images/icons/favicon.ico">
    <link rel="apple-touch-icon" href="images/icons/favicon.png">
    <link rel="apple-touch-icon" sizes="72x72" href="images/icons/favicon-72x72.png">
    <link rel="apple-touch-icon" sizes="114x114" href="images/icons/favicon-114x114.png">
    <!--Loading bootstrap css-->
    <link type="text/css" rel="stylesheet" href="http://fonts.googleapis.com/css?family=Open+Sans:400italic,400,300,700">
    <link type="text/css" rel="stylesheet" href="http://fonts.googleapis.com/css?family=Oswald:400,700,300">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/jquery-ui-1.10.4.custom.min.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/font-awesome.min.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/bootstrap.min.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/animate.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/all.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/main.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/style-responsive.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/zabuto_calendar.min.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/pace.css">
    <link type="text/css" rel="stylesheet" href="../../Content/styles/jquery.news-ticker.css">
</head>
<body>
    <div>
        <!--BEGIN THEME SETTING-->
        <div id="theme-setting">
            <a href="#" data-toggle="dropdown" data-step="1" data-intro="&lt;b&gt;Many styles&lt;/b&gt; and &lt;b&gt;colors&lt;/b&gt; be created for you. Let choose one and enjoy it!"
                data-position="left" class="btn-theme-setting"><i class="fa fa-cog"></i></a>
            <div class="content-theme-setting">
                <select id="list-style" class="form-control">
                    <option value="style1">Flat Squared style</option>
                    <option value="style2">Flat Rounded style</option>
                    <option value="style3" selected="selected">Flat Border style</option>
                </select>
            </div>
        </div>
        <!--END THEME SETTING-->
        <!--BEGIN BACK TO TOP-->
        <a id="totop" href="#"><i class="fa fa-angle-up"></i></a>
        <!--END BACK TO TOP-->
        <!--BEGIN TOPBAR-->
        <div id="header-topbar-option-demo" class="page-header-topbar">
            <nav id="topbar" role="navigation" style="margin-bottom: 0;" data-step="3" class="navbar navbar-default navbar-static-top">
                <div class="navbar-header">
                    <button type="button" data-toggle="collapse" data-target=".sidebar-collapse" class="navbar-toggle"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
                    <a id="logo" href="index.html" class="navbar-brand"><span class="fa fa-rocket"></span><span class="logo-text">KAdmin</span><span style="display: none" class="logo-text-icon">µ</span></a>
                </div>
                <div class="topbar-main">
                    <a id="menu-toggle" href="#" class="hidden-xs"><i class="fa fa-bars"></i></a>

                    <form id="topbar-search" action="" method="" class="hidden-sm hidden-xs">
                        <div class="input-icon right text-white">
                            <a href="#"><i class="fa fa-search"></i></a>
                            <input type="text" placeholder="Search here..." class="form-control text-white" />
                        </div>
                    </form>
                    <div class="news-update-box hidden-xs">
                        <span class="text-uppercase mrm pull-left text-white">News:</span>
                        <ul id="news-update" class="ticker list-unstyled">
                            <li>Welcome to KAdmin - Responsive Multi-Style Admin Template</li>
                            <li>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque.</li>
                        </ul>
                    </div>
                    <ul class="nav navbar navbar-top-links navbar-right mbn">
                        <li class="dropdown"><a data-hover="dropdown" href="#" class="dropdown-toggle"><i class="fa fa-bell fa-fw"></i><span class="badge badge-green">3</span></a>

                        </li>
                        <li class="dropdown"><a data-hover="dropdown" href="#" class="dropdown-toggle"><i class="fa fa-envelope fa-fw"></i><span class="badge badge-orange">7</span></a>

                        </li>
                        <li class="dropdown"><a data-hover="dropdown" href="#" class="dropdown-toggle"><i class="fa fa-tasks fa-fw"></i><span class="badge badge-yellow">8</span></a>

                        </li>
                        <li class="dropdown topbar-user"><a data-hover="dropdown" href="#" class="dropdown-toggle">
                            <img src="images/avatar/48.jpg" alt="" class="img-responsive img-circle" />&nbsp;<span class="hidden-xs">Robert John</span>&nbsp;<span class="caret"></span></a>
                            <ul class="dropdown-menu dropdown-user pull-right">
                                <li><a href="#"><i class="fa fa-user"></i>My Profile</a></li>
                                <li><a href="#"><i class="fa fa-calendar"></i>My Calendar</a></li>
                                <li><a href="#"><i class="fa fa-envelope"></i>My Inbox<span class="badge badge-danger">3</span></a></li>
                                <li><a href="#"><i class="fa fa-tasks"></i>My Tasks<span class="badge badge-success">7</span></a></li>
                                <li class="divider"></li>
                                <li><a href="#"><i class="fa fa-lock"></i>Lock Screen</a></li>
                                <li><a href="Login.html"><i class="fa fa-key"></i>Log Out</a></li>
                            </ul>
                        </li>
                        <li id="topbar-chat" class="hidden-xs"><a href="javascript:void(0)" data-step="4" data-intro="&lt;b&gt;Form chat&lt;/b&gt; keep you connecting with other coworker" data-position="left" class="btn-chat"><i class="fa fa-comments"></i><span class="badge badge-info">3</span></a></li>
                    </ul>
                </div>
            </nav>
            <!--BEGIN MODAL CONFIG PORTLET-->
            <div id="modal-config" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" data-dismiss="modal" aria-hidden="true" class="close">
                                &times;</button>
                            <h4 class="modal-title">Modal title</h4>
                        </div>
                        <div class="modal-body">
                            <p>
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eleifend et nisl eget
                                porta. Curabitur elementum sem molestie nisl varius, eget tempus odio molestie.
                                Nunc vehicula sem arcu, eu pulvinar neque cursus ac. Aliquam ultricies lobortis
                                magna et aliquam. Vestibulum egestas eu urna sed ultricies. Nullam pulvinar dolor
                                vitae quam dictum condimentum. Integer a sodales elit, eu pulvinar leo. Nunc nec
                                aliquam nisi, a mollis neque. Ut vel felis quis tellus hendrerit placerat. Vivamus
                                vel nisl non magna feugiat dignissim sed ut nibh. Nulla elementum, est a pretium
                                hendrerit, arcu risus luctus augue, mattis aliquet orci ligula eget massa. Sed ut
                                ultricies felis.
                            </p>
                        </div>
                        <div class="modal-footer">
                            <button type="button" data-dismiss="modal" class="btn btn-default">
                                Close</button>
                            <button type="button" class="btn btn-primary">
                                Save changes</button>
                        </div>
                    </div>
                </div>
            </div>
            <!--END MODAL CONFIG PORTLET-->
        </div>
        <!--END TOPBAR-->
        <div id="wrapper">
            <!--BEGIN SIDEBAR MENU-->
            <nav id="sidebar" role="navigation" data-step="2" data-intro="Template has &lt;b&gt;many navigation styles&lt;/b&gt;"
                data-position="right" class="navbar-default navbar-static-side">
                <div class="sidebar-collapse menu-scroll">
                    <ul id="side-menu" class="nav">

                        <div class="clearfix"></div>
                        <li><a href="dashboard.html"><i class="fa fa-tachometer fa-fw">
                            <div class="icon-bg bg-orange"></div>
                        </i><span class="menu-title">Dashboard</span></a></li>
                        <li><a href="Layout.html"><i class="fa fa-desktop fa-fw">
                            <div class="icon-bg bg-pink"></div>
                        </i><span class="menu-title">Layouts</span></a>

                        </li>
                        <li><a href="UIElements.html"><i class="fa fa-send-o fa-fw">
                            <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">UI Elements</span></a>

                        </li>
                        <li><a href="Forms.html"><i class="fa fa-edit fa-fw">
                            <div class="icon-bg bg-violet"></div>
                        </i><span class="menu-title">Forms</span></a>

                        </li>
                        <li><a href="Tables.html"><i class="fa fa-th-list fa-fw">
                            <div class="icon-bg bg-blue"></div>
                        </i><span class="menu-title">Tables</span></a>

                        </li>
                        <li><a href="DataGrid.html"><i class="fa fa-database fa-fw">
                            <div class="icon-bg bg-red"></div>
                        </i><span class="menu-title">Data Grids</span></a>

                        </li>
                        <li><a href="Pages.html"><i class="fa fa-file-o fa-fw">
                            <div class="icon-bg bg-yellow"></div>
                        </i><span class="menu-title">Pages</span></a>

                        </li>
                        <li><a href="Extras.html"><i class="fa fa-gift fa-fw">
                            <div class="icon-bg bg-grey"></div>
                        </i><span class="menu-title">Extras</span></a>

                        </li>
                        <li><a href="Dropdown.html"><i class="fa fa-sitemap fa-fw">
                            <div class="icon-bg bg-dark"></div>
                        </i><span class="menu-title">Multi-Level Dropdown</span></a>

                        </li>
                        <li class="active"><a href="Email.html"><i class="fa fa-envelope-o">
                            <div class="icon-bg bg-primary"></div>
                        </i><span class="menu-title">Email</span></a>

                        </li>
                        <li><a href="Charts.html"><i class="fa fa-bar-chart-o fa-fw">
                            <div class="icon-bg bg-orange"></div>
                        </i><span class="menu-title">Charts</span></a>

                        </li>
                        <li><a href="Animation.html"><i class="fa fa-slack fa-fw">
                            <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">Animations</span></a></li>
                    </ul>
                </div>
            </nav>


            <div id="page-wrapper">
                <!--BEGIN TITLE & BREADCRUMB PAGE-->
                <div id="title-breadcrumb-option-demo" class="page-title-breadcrumb">
                    <div class="page-header pull-left">
                        <div class="page-title">
                            Extras
                        </div>
                    </div>
                    <ol class="breadcrumb page-breadcrumb pull-right">
                        <li><i class="fa fa-home"></i>&nbsp;<a href="dashboard.html">Home</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="hidden"><a href="#">Extras</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="active">Extras</li>
                    </ol>
                    <div class="clearfix">
                    </div>
                </div>
                <!--END TITLE & BREADCRUMB PAGE-->
                <!--BEGIN CONTENT-->
                <div class="page-content">
                    <div id="tab-general">
                        <div class="row mbl">
                            <div class="col-lg-12">
                                <div class="col-md-12">
                                    <div id="area-chart-spline" style="width: 100%; height: 300px; display: none;">
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <div class="mtl mbl"></div>
                                <div class="row">
                                    <div class="col-sm-9 col-md-10">
                                        <form runat="server">
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        <asp:Button ID="Button1" runat="server" Text="查找商品" OnClick="Button1_Click" />
                                        <div class="tab-content">
                                            <div id="home" class="tab-pane fade in active">
                                                <div class="list-group mail-box">
                                                      <a href="#" class="list-group-item">
                                                        <span style="width: 100px; display: inline-block;" class="name">商品ID</span>
                                                        <span style="width: 100px; display: inline-block;" class="name">商品名称</span>
                                                        <span style="width: 100px; display: inline-block;" class="name">商品类别</span>
                                                        <span style="width: 100px; display: inline-block;" class="name">商品单位</span>
                                                        <span style="width: 100px; display: inline-block;" class="name">保质期</span>
                                                        <span style="width: 100px; display: inline-block;" class="name">单价</span>
                                                         <span style="width: 100px; display: inline-block;" class="name">库存</span>
                                                            </a>
                                                        
                                                        <%for ( i = 0; i < goods.Count ; i++)
                                                            { %>
                                                        <a href="#" class="list-group-item">
                                                        <span style="width: 100px; display: inline-block;" class="name" ><%=goods[i].ID %></span>
                                                        <span style="width: 100px; display: inline-block;" class="name"><%=goods[i].Name %></span>
                                                        <span style="width: 100px; display: inline-block;" class="name"><%=goods[i].GC_Name %></span>
                                                            <span style="width: 100px; display: inline-block;" class="name"><%=goods[i].Unit %></span>
                                                            <span style="width: 100px; display: inline-block;" class="name"><%=goods[i].ExpirationDate %></span>
                                                            <span style="width: 100px; display: inline-block;" class="name"><%=goods[i].Price %></span>
                                                             <span style="width: 100px; display: inline-block;" class="name"><%=goods[i].Store %></span>
                                                            <asp:Button ID="Button2" runat="server" Text="修改单价" OnClick="Button2_Click"/>
                                                            </a>
                                                        <%} %>  
                                                </div>
                                            </div>
                                        </div>
                                        </form>
                                    </div>
                                    <div class="common-modal modal fade" id="common-Modal1" tabindex="-1" role="dialog" aria-hidden="true">
                                        <div class="modal-content">
                                            <ul class="list-inline item-details">
                                                <li><a href="#">Admin templates</a></li>
                                                <li><a href="http://themescloud.org">Bootstrap themes</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>



                            </div>




                        </div>
                    </div>
                </div>
                <!--END CONTENT-->
                <!--BEGIN FOOTER-->
                <div id="footer">
                    <div class="copyright">
                        <a href="#">2014 © KAdmin Responsive Multi-Purpose Template</a>
                    </div>
                </div>
                <!--END FOOTER-->
            </div>
            <!--END PAGE WRAPPER-->
        </div>
    </div>
    <script src="../../Script/jquery-1.10.2.min.js"></script>
    <script src="../../Script/jquery-migrate-1.2.1.min.js"></script>
    <script src="../../Script/jquery-ui.js"></script>
    <script src="../../Script/bootstrap.min.js"></script>
    <script src="../../Script/bootstrap-hover-dropdown.js"></script>
    <script src="../../Script/html5shiv.js"></script>
    <script src="../../Script/respond.min.js"></script>
    <script src="../../Script/jquery.metisMenu.js"></script>
    <script src="../../Script/jquery.slimscroll.js"></script>
    <script src="../../Script/jquery.cookie.js"></script>
    <script src="../../Script/icheck.min.js"></script>
    <script src="../../Script/custom.min.js"></script>
    <script src="../../Script/jquery.news-ticker.js"></script>
    <script src="../../Script/jquery.menu.js"></script>
    <script src="../../Script/pace.min.js"></script>
    <script src="../../Script/holder.js"></script>
    <script src="../../Script/responsive-tabs.js"></script>
    <script src="../../Script/jquery.flot.js"></script>
    <script src="../../Script/jquery.flot.categories.js"></script>
    <script src="../../Script/jquery.flot.pie.js"></script>
    <script src="../../Script/jquery.flot.tooltip.js"></script>
    <script src="../../Script/jquery.flot.resize.js"></script>
    <script src="../../Script/jquery.flot.fillbetween.js"></script>
    <script src="../../Script/jquery.flot.stack.js"></script>
    <script src="../../Script/jquery.flot.spline.js"></script>
    <script src="../../Script/zabuto_calendar.min.js"></script>

    <script src="script/index.js"></script>
    <!--LOADING SCRIPTS FOR CHARTS-->
    <script src="script/highcharts.js"></script>
    <script src="script/data.js"></script>
    <script src="script/drilldown.js"></script>
    <script src="script/exporting.js"></script>
    <script src="script/highcharts-more.js"></script>
    <script src="script/charts-highchart-pie.js"></script>
    <script src="script/charts-highchart-more.js"></script>
    <!--CORE JAVASCRIPT-->
    <script src="script/main.js"></script>

</body>
</html>

