﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiscountManager.aspx.cs" Inherits="SuperMarketManager.Views.DiscountManager" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>超市管理系统 |折扣管理</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="../../Content/images/icons/favicon.ico">
    <link rel="apple-touch-icon" href="../../Content/images/icons/favicon.png">
    <link rel="apple-touch-icon" sizes="72x72" href="../../Content/images/icons/favicon-72x72.png">
    <link rel="apple-touch-icon" sizes="114x114" href="../../Content/images/icons/favicon-114x114.png">
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

                    <form id="topbar-search" action="" method="" class="hidden-sm hidden-xs">
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
                            <img src="../../Content/images/avatar/48.jpg" alt="" class="img-responsive img-circle" />&nbsp;<span class="hidden-xs">Manager</span>&nbsp;<span class="caret"></span></a>
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
                        <li ><a href="../../Views/Index/Manager_Index.aspx"><i class="fa fa-tachometer fa-fw">
                            <div class="icon-bg bg-orange"></div>
                        </i><span class="menu-title">首页</span></a></li>

                        <li><a href="../../Views/EmployeeManager/EmployeeManager.aspx"><i class="fa fa-desktop fa-fw">
                            <div class="icon-bg bg-pink"></div>
                        </i><span class="menu-title">员工管理</span></a>

                        </li>
                        <li><a href="../../Views/SupplierManager/SupplierManager.aspx"><i class="fa fa-send-o fa-fw">
                            <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">供应商管理</span></a>

                        </li>
                        <li><a href="../../Views/GoodsSell/GoodsSell.aspx"><i class="fa fa-edit fa-fw">
                            <div class="icon-bg bg-violet"></div>
                        </i><span class="menu-title">商品销售</span></a>

                        </li>
                        <li><a href="../../Views/GoodsManager/GoodsManager.aspx"><i class="fa fa-th-list fa-fw">
                            <div class="icon-bg bg-blue"></div>
                        </i><span class="menu-title">商品信息与库存</span></a>

                        </li>
                        <li class="active"><a href="../../Views/DiscountManage/DiscountManager.aspx"><i class="fa fa-database fa-fw">
                            <div class="icon-bg bg-red"></div>
                        </i><span class="menu-title">折扣管理</span></a>

                        </li>
                        <li><a href="../../Views/Businessstatistics/Businessstatistics.aspx"><i class="fa fa-file-o fa-fw">
                            <div class="icon-bg bg-yellow"></div>
                        </i><span class="menu-title">营业统计</span></a>

                        </li>
                        <li><a href="../../Views/PSInfo1/PSInfo1.aspx"><i class="fa fa-gift fa-fw">
                            <div class="icon-bg bg-grey"></div>
                        </i><span class="menu-title">个人信息</span></a>

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
                            折扣管理
                        </div>
                    </div>
                    <ol class="breadcrumb page-breadcrumb pull-right">
                        <li><i class="fa fa-home"></i>&nbsp;<a href="dashboard.html">Home</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="hidden"><a href="#">折扣管理</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="active">折扣管理</li>
                    </ol>
                    <div class="clearfix">
                    </div>
                </div>
                <!--END TITLE & BREADCRUMB PAGE-->
                <!--BEGIN CONTENT-->
                <div class="page-content">
                    <form runat="server">
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
                                        <div class="col-sm-3 col-md-2">
                                            <a href="#" role="button" class="btn btn-danger btn-sm btn-block">折扣管理</a>
                                            <div class="mtm mbm"></div>
                                            <div class="panel">
                                                <div class="panel-body pan">
                                                    <ul style="background: #fff" class="nav nav-pills nav-stacked">
                                                        <li class="active"><a href="#">折扣查询</a></li>
                                                        <li><label style="height:1px;"/></li>
                                                        <li><i class="fa fa-fw mrs"></i>商品编号：</li><li>&nbsp&nbsp<asp:TextBox ID="dgoodsid" runat="server" Width="120px" Height="20px"></asp:TextBox></li>
                                                        <li><i class="fa fa-fw mrs"></i>打折日期：</li><li>&nbsp&nbsp<asp:TextBox ID="disdate" runat="server" Width="120px" Height="20px" TextMode="Date"></asp:TextBox></li>
                                                        <li><i class="fa fa-fw mrs"></i>起始时间：</li><li>&nbsp&nbsp<asp:TextBox ID="disstart" runat="server"  Width="120px" Height="20px" TextMode="Date"></asp:TextBox></li>
                                                        <li><i class="fa fa-fw mrs"></i>结束时间：</li><li>&nbsp&nbsp<asp:TextBox ID="disend" runat="server"  Width="120px" Height="20px" TextMode="Date"></asp:TextBox></li>
                                                        <li><label style="height:1px;"/></li>
                                                        <li><i class="fa fa-fw mrs"></i>&nbsp&nbsp<asp:Button ID="searchbutton" runat="server" OnClick="searchbutton_Click" ForeColor="White"  BackColor="#dc6767" BorderStyle="None" Width="60px" Height="20px" Text="查询"></asp:Button>&nbsp&nbsp</li>
                                                        <li><label style="height:1px;"/></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <hr />
                                            <div class="panel">
                                                <div class="panel-body pan">
                                                    <ul style="background: #fff" class="nav nav-pills nav-stacked">
                                                        <li class="active"><a href="#">增加折扣</a></li>
                                                        <li><label style="height:1px;"/></li>
                                                        <li><i class="fa fa-fw mrs"></i>商品编号：</li><li>&nbsp&nbsp<asp:TextBox ID="sdgoodsid" runat="server" Width="120px" Height="20px"></asp:TextBox></li>
                                                        <li><i class="fa fa-fw mrs"></i>起始时间：</li><li>&nbsp&nbsp<asp:TextBox ID="sdisstart" runat="server" Width="120px" Height="20px" TextMode="Date"></asp:TextBox></li>
                                                        <li><i class="fa fa-fw mrs"></i>结束时间：</li><li>&nbsp&nbsp<asp:TextBox ID="sdisend" runat="server"  Width="120px" Height="20px" TextMode="Date"></asp:TextBox></li>
                                                        <li><i class="fa fa-fw mrs"></i>折扣力度：</li><li>&nbsp&nbsp<asp:TextBox ID="disprice" runat="server"  Width="120px" Height="20px"></asp:TextBox></li>

                                                        <li><label style="height:1px;"/></li>
                                                        <li><i class="fa fa-fw mrs"></i>&nbsp&nbsp<asp:Button ID="addbutton" runat="server" ForeColor="White" BackColor="#dc6767" BorderStyle="None" Width="60px" Height="20px" Text="增加" OnClick="addbutton_Click"></asp:Button>&nbsp&nbsp</li>
                                                        <li><label style="height:1px;"/></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-9 col-md-10">
                                            <ul class="nav nav-tabs">
                                                <li class="active"><a href="#home" data-toggle="tab"><span class="fa fa-inbox"></span>&nbsp;折扣查询结果</a></li>
                                            </ul>
                                            <div class="tab-content">
                                                <div id="home" class="tab-pane fade in active">
                                                    <div class="list-group mail-box">
                                                        <div class="list-group-item">
                                                                  <input type="checkbox" /><span class="fa mrm mlm"></span>
                                                                  <span style="min-width: 120px; display: inline-block;" class="name"><strong>折扣编号 &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 折扣物品 &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 
                                                                      折扣开始 &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 折扣结束 &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp 折扣力度</strong></span>
                                                                  <span class="pull-right mrl"></span></div>
                                                        <%if (discountslist != null)
                                                                { %>
                                                            <%for (int i = 0; i < discountslist.Count; i++)
                                                                { %>
                                                                  <div class="list-group-item">
                                                                  <span class="fa fa-star-o mrm mlm"></span>
                                                                  <span style="min-width: 120px; display: inline-block;" class="name"><a href="../../Views/DiscountManage/Discount_delete.aspx?id=<%=discountslist[i].ID  %>"><%=discountslist[i].ID %></a>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                                                      <%=discountslist[i].G_ID %>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<%=discountslist[i].Start %>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                                                                      <%=discountslist[i].End %>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<%=discountslist[i].DDiscount %></span>
                                                                  <span class="pull-right mrl"></span>
                                                                  </div>
                                                            <%} %>
                                                        <%} %>
                                                        
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
            <!--END CONTENT-->
        </div>
        <!--END PAGE WRAPPER-->
    </div>
    </div>
        <script src="../../Scripts/jquery-1.10.2.min.js"></script>
    <script src="../../Scripts/jquery-migrate-1.2.1.min.js"></script>
    <script src="../../Scripts/jquery-ui.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/bootstrap-hover-dropdown.js"></script>
    <script src="../../Scripts/html5shiv.js"></script>
    <script src="../../Scripts/respond.min.js"></script>
    <script src="../../Scripts/jquery.metisMenu.js"></script>
    <script src="../../Scripts/jquery.slimscroll.js"></script>
    <script src="../../Scripts/jquery.cookie.js"></script>
    <script src="../../Scripts/icheck.min.js"></script>
    <script src="../../Scripts/custom.min.js"></script>
    <script src="../../Scripts/jquery.news-ticker.js"></script>
    <script src="../../Scripts/jquery.menu.js"></script>
    <script src="../../Scripts/pace.min.js"></script>
    <script src="../../Scripts/holder.js"></script>
    <script src="../../Scripts/responsive-tabs.js"></script>
    <script src="../../Scripts/jquery.flot.js"></script>
    <script src="../../Scripts/jquery.flot.categories.js"></script>
    <script src="../../Scripts/jquery.flot.pie.js"></script>
    <script src="../../Scripts/jquery.flot.tooltip.js"></script>
    <script src="../../Scripts/jquery.flot.resize.js"></script>
    <script src="../../Scripts/jquery.flot.fillbetween.js"></script>
    <script src="../../Scripts/jquery.flot.stack.js"></script>
    <script src="../../Scripts/jquery.flot.spline.js"></script>
    <script src="../../Scripts/zabuto_calendar.min.js"></script>

    <script src="../../Scripts/index.js"></script>
    <!--LOADING SCRIPTS FOR CHARTS-->
    <script src="../../Scripts/highcharts.js"></script>
    <script src="../../Scripts/data.js"></script>
    <script src="../../Scripts/drilldown.js"></script>
    <script src="../../Scripts/exporting.js"></script>
    <script src="../../Scripts/highcharts-more.js"></script>
    <script src="../../Scripts/charts-highchart-pie.js"></script>
    <script src="../../Scripts/charts-highchart-more.js"></script>
    <!--CORE JAVASCRIPT-->
    <script src="../../Scripts/main.js"></script>
</body>
</html>


