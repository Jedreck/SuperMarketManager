<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsInManage.aspx.cs" Inherits="SuperMarketManager.Views.GoodsInManage.GoodsInManage" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>超市管理系统|入库管理</title>
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
       <div id="header-topbar-option-demo" class="page-header-topbar">
            <nav id="topbar" role="navigation" style="margin-bottom: 0;" data-step="3" class="navbar navbar-default navbar-static-top">
                <div class="navbar-header">
                    <button type="button" data-toggle="collapse" data-target=".sidebar-collapse" class="navbar-toggle"><span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span></button>
                    <a id="logo" href="index.html" class="navbar-brand"><span class="fa fa-rocket"></span><span class="logo-text">Supermarket</span><span style="display: none" class="logo-text-icon">µ</span></a>
                </div>
                <div class="topbar-main">
                    <a id="menu-toggle" href="#" class="hidden-xs"><i class="fa fa-bars"></i></a>

                    <form id="topbar-search" class="hidden-sm hidden-xs">
                        <div class="input-icon right text-white">
                            <a href="#"><i class="fa fa-search"></i></a>
                            <input type="text" placeholder="Search here..." class="form-control text-white" />
                        </div>
                    </form>
                    <div class="news-update-box hidden-xs">
                        <span class="text-uppercase mrm pull-left text-white">News:</span>
                        <ul id="news-update" class="ticker list-unstyled">
                            <li>欢迎来到“超库”超市管理系统！</li>
                            <li>平庸的员工总是在质疑目标,卓越的员工总是在寻找方法</li>
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
                            <img src="../../Content/images/avatar/48.jpg" alt="" class="img-responsive img-circle" />&nbsp;<span class="hidden-xs">Robert John</span>&nbsp;<span class="caret"></span></a>
                            <ul class="dropdown-menu dropdown-user pull-right">
                                <li><a href="#"><i class="fa fa-user"></i>个人信息</a></li>
                                <li><a href="#"><i class="fa fa-tasks"></i>我的任务<span class="badge badge-success">7</span></a></li>
                                <li class="divider"></li>
                                <li><a href="../../Views/Login/Login.aspx"><i class="fa fa-key"></i>退出</a></li>
                            </ul>
                        </li>
                        <li id="topbar-chat" class="hidden-xs"><a href="javascript:void(0)" data-step="4" data-intro="&lt;b&gt;Form chat&lt;/b&gt; keep you connecting with other coworker" data-position="left" class="btn-chat"><i class="fa fa-comments"></i><span class="badge badge-info">3</span></a></li>
                    </ul>
                </div>
            </nav>
        </div>
        <!--END TOPBAR-->
        <div id="wrapper">
            <!--BEGIN SIDEBAR MENU-->
            <nav id="sidebar" role="navigation" data-step="2" data-intro="Template has &lt;b&gt;many navigation styles&lt;/b&gt;"
                data-position="right" class="navbar-default navbar-static-side">
                <div class="sidebar-collapse menu-scroll">
                    <ul id="side-menu" class="nav">

                        <div class="clearfix"></div>
                        <li class="active"><a href="../../Views/Index/Manager_Index.aspx"><i class="fa fa-tachometer fa-fw">
                            <div class="icon-bg bg-orange"></div>
                        </i><span class="menu-title">首页</span></a></li>

                        <li><i class="fa fa-desktop fa-fw">
                            <div class="icon-bg bg-pink"></div>
                        </i><span class="menu-title">个人信息</span></a>

                        </li>
                        <li><a href="../../Views/GoodsManage2/GoodsManager.aspx"><i class="fa fa-send-o fa-fw">
                            <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">商品信息</span></a>

                        </li>
                        <li><a href="../../Views/StoreManage/store.aspx"><i class="fa fa-edit fa-fw">
                            <div class="icon-bg bg-violet"></div>
                        </i><span class="menu-title">库存管理</span></a>

                        </li>
                        <li><i class="fa fa-th-list fa-fw">
                            <div class="icon-bg bg-blue"></div>
                        </i><span class="menu-title">入库管理</span></a>

                        </li>
                        <li><a href="../../Views/Index/inventory_manager_index.aspx"><i class="fa fa-sitemap fa-fw">
                            <div class="icon-bg bg-dark"></div>
                        </i><span class="menu-title">退出</span></a>
                    </ul>
                </div>
            </nav>
            <!--END SIDEBAR MENU-->
            <div id="page-wrapper">
                <!--BEGIN TITLE & BREADCRUMB PAGE-->
                <div id="title-breadcrumb-option-demo" class="page-title-breadcrumb">
                    <div class="page-header pull-left">
                        <div class="page-title">
                            Forms</div>
                    </div>
                    <ol class="breadcrumb page-breadcrumb pull-right">
                        <li><i class="fa fa-home"></i>&nbsp;<a href="dashboard.html">Home</a>&nbsp;&nbsp;<i
                            class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="hidden"><a href="#">Forms</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="active">Forms</li>
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
                                <div class="row">
                                    <div class="col-lg-4">
                                        <div class="panel panel-orange">
                                            <div class="panel-heading">
                                                Registration form</div>
                                            <div class="panel-body pan">
                                                <form action="#">
                                                <div class="form-body pal">
                                                    <div class="form-group">
                                                        <div class="input-icon right">
                                                            <i class="fa fa-user"></i>
                                                            <input id="inputName" type="text" placeholder="Username" class="form-control" /></div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-icon right">
                                                            <i class="fa fa-envelope"></i>
                                                            <input id="inputEmail" type="text" placeholder="Email address" class="form-control" /></div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-icon right">
                                                            <i class="fa fa-lock"></i>
                                                            <input id="inputPassword" type="password" placeholder="Password" class="form-control" /></div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-icon right">
                                                            <i class="fa fa-lock"></i>
                                                            <input id="inputConfirmPassword" type="password" placeholder="Confirm Password" class="form-control" /></div>
                                                    </div>
                                                    <hr />
                                                    <div class="row">
                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <input id="inputFirstName" type="text" placeholder="First Name" class="form-control" /></div>
                                                        </div>
                                                        <div class="col-md-6">
                                                            <div class="form-group">
                                                                <input id="inputLastName" type="text" placeholder="Last Name" class="form-control" /></div>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <select class="form-control">
                                                            <option>Gender</option>
                                                            <option value="0">Male</option>
                                                            <option value="1">Female</option>
                                                            <option value="2">Other</option>
                                                        </select></div>
                                                    <div class="form-group">
                                                        <div class="checkbox">
                                                            <label>
                                                                <input tabindex="5" type="checkbox" />&nbsp; I want to receive news and special
                                                                offers</label></div>
                                                    </div>
                                                    <div class="form-group mbn">
                                                        <div class="checkbox">
                                                            <label>
                                                                <input tabindex="5" type="checkbox" />&nbsp; I agree with the Terms and Conditions</label></div>
                                                    </div>
                                                </div>
                                                <div class="form-actions text-right pal">
                                                    <button type="submit" class="btn btn-primary">
                                                        Submit</button>
                                                </div>
                                                </form>
                                            </div>
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
                        <a href="#">2014 © KAdmin Responsive Multi-Purpose Template</a></div>
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
    <script src="../../Script/index.js"></script>
    <!--LOADING SCRIPTS FOR CHARTS-->
    <script src="../../Script/highcharts.js"></script>
    <script src="../../Script/data.js"></script>
    <script src="../../Script/drilldown.js"></script>
    <script src="../../Script/exporting.js"></script>
    <script src="../../Script/highcharts-more.js"></script>
    <script src="../../Script/charts-highchart-pie.js"></script>
    <script src="../../Script/charts-highchart-more.js"></script>
    <!--CORE JAVASCRIPT-->
    <script src="../../Script/main.js"></script>
    
</body>
</html>