<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierManager.aspx.cs" Inherits="SuperMarketManager.Views.SupplierManager.SupplierManager" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>超市管理系统 | 供应商管理</title>
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
    <link type="text/css" rel="stylesheet" href="../../Content/styles/jplist-custom.css">
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
                            <img src="../../Content/images/avatar/48.jpg" alt="" class="img-responsive img-circle" />&nbsp;<span class="hidden-xs">Robert John</span>&nbsp;<span class="caret"></span></a>
                            <ul class="dropdown-menu dropdown-user pull-right">
                                <
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
                        <li><a href="../../Views/Index/Manager_Index.aspx"><i class="fa fa-tachometer fa-fw">
                            <div class="icon-bg bg-orange"></div>
                        </i><span class="menu-title">首页</span></a></li>

                        <li><a href="../../Views/EmployeeManager/EmployeeManager.aspx"><i class="fa fa-desktop fa-fw">
                            <div class="icon-bg bg-pink"></div>
                        </i><span class="menu-title">员工管理</span></a>

                        </li>
                        <li class="active"><a href="../../Views/SupplierManager/SupplierManager.aspx"><i class="fa fa-send-o fa-fw">
                            <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">供应商管理</span></a>

                        </li>
                        <li><a href="../../Views/GoodsSell/GoodsSell.aspx"><i class="fa fa-edit fa-fw">
                            <div class="icon-bg bg-violet"></div>
                        </i><span class="menu-title">商品销售</span></a>

                        </li>
                        <li><a href="Tables.html"><i class="fa fa-th-list fa-fw">
                            <div class="icon-bg bg-blue"></div>
                        </i><span class="menu-title">商品信息与库存</span></a>

                        </li>
                        <li><a href="DataGrid.html"><i class="fa fa-database fa-fw">
                            <div class="icon-bg bg-red"></div>
                        </i><span class="menu-title">折扣管理</span></a>

                        </li>
                        <li><a href="../../Views/Businessstatistics/Businessstatistics.aspx"><i class="fa fa-file-o fa-fw">
                            <div class="icon-bg bg-yellow"></div>
                        </i><span class="menu-title">营业统计</span></a>

                        </li>
                        <li><a href="Extras.html"><i class="fa fa-gift fa-fw">
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
                            供应商管理
                        </div>
                    </div>
                    <ol class="breadcrumb page-breadcrumb pull-right">
                        <li><i class="fa fa-home"></i>&nbsp;<a href="../../Views/Index/Manager_Index.aspx">Home</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="hidden"><a href="#">供应商管理</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="active">供应商管理</li>
                    </ol>
                    <div class="clearfix">
                    </div>
                </div>
                <!--END TITLE & BREADCRUMB PAGE-->
                <!--BEGIN CONTENT-->
                <form runat="server">
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

                                <div class="page-content">
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <div class="panel">
                                                <div class="panel-body">
                                                    <div id="grid-layout-table-1" class="box jplist">
                                                        <div class="jplist-ios-button"><i class="fa fa-sort"></i>jPList Actions</div>
                                                        <div class="jplist-panel box panel-top">
                                                            <button type="button" style="height:35px;" data-control-type="reset" data-control-name="reset" data-control-action="reset" class="jplist-reset-btn btn btn-default">重置<i class="fa fa-share mls"></i></button>
                                                            <div data-control-type="drop-down" data-control-name="paging" data-control-action="paging" class="jplist-drop-down form-control">
                                                                <ul class="dropdown-menu">
                                                                    <li><span data-number="3">3 per page</span></li>
                                                                    <li><span data-number="5">5 per page</span></li>
                                                                    <li><span data-number="10" data-default="true">10 per page</span></li>
                                                                    <li><span data-number="all">view all</span></li>
                                                                </ul>
                                                            </div>
                                                            <div data-control-type="drop-down" data-control-name="sort" data-control-action="sort" data-datetime-format="{month}/{day}/{year}" class="jplist-drop-down form-control">
                                                                <ul class="dropdown-menu">
                                                                    <li><span data-path=".title" data-order="asc" data-type="text">供应商 A-Z</span></li>
                                                                    <li><span data-path=".title" data-order="desc" data-type="text">供应商 Z-A</span></li>                                                               
                                                                    <li><span data-path=".like" data-order="asc" data-type="number" data-default="true">报价升序</span></li>
                                                                    <li><span data-path=".like" data-order="desc" data-type="number">报价降序</span></li>
                                                                </ul>
                                                            </div>
                                                            <div class="text-filter-box">
                                                                <div class="input-group">
                                                                    <span class="input-group-addon"><i class="fa fa-search"></i></span>
                                                                    <input data-path=".title" type="text" runat="server" id="search_content" value="" placeholder="供应商名称" data-control-type="textbox" data-control-name="title-filter" data-control-action="filter" class="form-control" />
                                                                </div>
                                                            </div>                                                          
                                                            <div data-type="Page {current} of {pages}" data-control-type="pagination-info" data-control-name="paging" data-control-action="paging" class="jplist-label btn btn-default"></div>
                                                            <div data-control-type="pagination" data-control-name="paging" data-control-action="paging" class="jplist-pagination"></div>
                                                        </div>
                                                        <div class="box text-shadow">
                                                            <table class="demo-tbl">
                                                             <%if (supplierlist!= null)
                                                             { %>
                                                                <%for (int i = 0; i <supplierlist.Count; i++)
                                                                    {
                                                                     %>                                                                   
                                                                    <!--<item>1</item>-->
                                                                    <tr class="tbl-item">
                                                                    <!--<img/>-->
                                                                    
                                                                    <!--<data></data>-->
                                                                    <td class="td-block">
                                                                        <p class="title"><a href="/Views/SupplierManager/Supplier_detail.aspx"><%=supplierlist[i].S_Name%></a></p>

                                                                        <p class="desc">供应商信息：供应商id:<%=supplierlist[i].S_ID %>&nbsp&nbsp&nbsp 供应商名称：<%=supplierlist[i].S_Name %><br />                                                                                   
                                                                                        商品信息：商品id：<%=supplierlist[i].G_ID %>&nbsp&nbsp&nbsp 商品名称：<%=supplierlist[i].G_Name %>
                                                                        </p>
                                                                        <p class="like">供应商报价：<%=supplierlist[i].SL_Price %></p>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <%} %>
                                                            <%} %>
                                                            </table>
                                                        </div>
                                                        <div class="box jplist-no-results text-shadow align-center">
                                                            <p>No results found</p>
                                                        </div>
                                                        <div class="jplist-ios-button"><i class="fa fa-sort"></i>jPList Actions</div>
                                                        <div class="jplist-panel box panel-bottom">
                                                            <div data-control-type="drop-down" data-control-name="paging" data-control-action="paging" data-control-animate-to-top="true" class="jplist-drop-down form-control">
                                                                <ul class="dropdown-menu">
                                                                    <li><span data-number="3">3 per page</span></li>
                                                                    <li><span data-number="5">5 per page</span></li>
                                                                    <li><span data-number="10" data-default="true">10 per page</span></li>
                                                                    <li><span data-number="all">view all</span></li>
                                                                </ul>
                                                            </div>
                                                            <div data-control-type="drop-down" data-control-name="sort" data-control-action="sort" data-control-animate-to-top="true" data-datetime-format="{month}/{day}/{year}" class="jplist-drop-down form-control">
                                                                <ul class="dropdown-menu">
                                                                    <li><span data-path="default">默认排序</span></li>
                                                                    <li><span data-path=".title" data-order="asc" data-type="text">供应商 A-Z</span></li>
                                                                    <li><span data-path=".title" data-order="desc" data-type="text">供应商 Z-A</span></li>                                                               
                                                                    <li><span data-path=".like" data-order="asc" data-type="number" data-default="true">报价升序</span></li>
                                                                    <li><span data-path=".like" data-order="desc" data-type="number">报价降序</span></li>
                                                                </ul>
                                                            </div>
                                                            <div data-type="{start} - {end} of {all}" data-control-type="pagination-info" data-control-name="paging" data-control-action="paging" class="jplist-label btn btn-default"></div>
                                                            <div data-control-type="pagination" data-control-name="paging" data-control-action="paging" data-control-animate-to-top="true" class="jplist-pagination"></div>
                                                            <div>
                                                                 &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                <asp:Button ID="s_manage" runat="server" Width="100px" Height="55px" BorderStyle="Dashed" ForeColor="#ffffff" BackColor=" #488c6c" BorderColor="#458567" Font-Size="12px" Text="管理供应商信息" OnClick="Manage_Click" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>
                </form>
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
    <script src="../../Scripts/highcharts.js"></script>
    <script src="../../Scripts/data.js"></script>
    <script src="../../Scripts/drilldown.js"></script>
    <script src="../../Scripts/exporting.js"></script>
    <script src="../../Scripts/highcharts-more.js"></script>
    <script src="../../Scripts/charts-highchart-pie.js"></script>
    <script src="../../Scripts/charts-highchart-more.js"></script>
    <script src="../../Scripts/modernizr.min.js"></script>
    <script src="../../Scripts/jplist.min.js"></script>
    <script src="../../Scripts/jplist.js"></script>-->
    <script>
</script>
    <!--CORE JAVASCRIPT-->
    <script src="../../Scripts/main.js"></script>

</body>
</html>

