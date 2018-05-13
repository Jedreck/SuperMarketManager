<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="store.aspx.cs" Inherits="SuperMarketManager.Views.StoreManage.store" %>



<!DOCTYPE html>
<html lang="en">
<head>
    <title>Tables | Tables</title>
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
                        <li><a href="../../Views/Index/inventory_manager_index.aspx"><i class="fa fa-tachometer fa-fw">
                            <div class="icon-bg bg-orange"></div>
                        </i><span class="menu-title">首页</span></a></li>

                        <li><a href="../../Views/PSInfo/PSInfo.aspx"><i class="fa fa-desktop fa-fw">
                            <div class="icon-bg bg-pink"></div>
                        </i><span class="menu-title">个人信息</span></a>

                        </li>
                        <li><a href="../../Views/GoodsManage2/GoodsManager.aspx"><i class="fa fa-send-o fa-fw">
                            <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">商品信息</span></a>

                        </li>
                        <li class="active"><a href="../../Views/StoreManage/store.aspx"><i class="fa fa-edit fa-fw">
                            <div class="icon-bg bg-violet"></div>
                        </i><span class="menu-title">库存管理</span></a>

                        </li>
                        <li ><a href="../../Views/GoodsInManage2/GoodsInManage2.aspx"><i class="fa fa-th-list fa-fw">
                            <div class="icon-bg bg-blue"></div>
                        </i><span class="menu-title">入库管理</span></a>

                        </li>
                        <li><a href="../../Views/Login/Login.aspx"><i class="fa fa-sitemap fa-fw">
                            <div class="icon-bg bg-dark"></div>
                        </i><span class="menu-title">退出</span></a>
                    </ul>
                </div>
            </nav>
          
          
            <div id="page-wrapper">
                <!--BEGIN TITLE & BREADCRUMB PAGE-->
                <div id="title-breadcrumb-option-demo" class="page-title-breadcrumb">
                    <div class="page-header pull-left">
                        <div class="page-title">
                            库存信息</div>
                    </div>
                    <ol class="breadcrumb page-breadcrumb pull-right">
                        <li><i class="fa fa-home"></i>&nbsp;<a href="dashboard.html">Home</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="hidden"><a href="#">Tables</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="active">库存信息</li>
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
                    <div class="col-lg-6">
                       
                        <div class="panel panel-green">
                            <div class="panel-heading">库存信息表</div>
                            <div class="panel-body">
                                <table class="table table-hover table-bordered">
                                    <thead>
                                                        <tr>
                                                            <th>商品ID</th>
                                                            <th>流水号</th>
                                                            <th>入库数</th>
                                                            <th>生产日期</th>
                                                            <th>总库存</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <%if (storelist1!=null)
                                                            { %>
                                                        <%for (int i = 0; i < storelist1.Count; i++)
                                                            { %>
                                                        <tr>
                                                            <td><%=storelist1[i].G_ID %></td>
                                                            <td><%=storelist1[i].GI_ID %></td>
                                                            <td><%=storelist1[i].Num %></td>
                                                            <td><%=storelist1[i].ProducedDate %></td>
                                                            <td><%=storelist1[i].G_Store %></td>

                                                        </tr>
                                                        <% } %>
                                                        <% } %>
                                                    </tbody>
                                </table>
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

