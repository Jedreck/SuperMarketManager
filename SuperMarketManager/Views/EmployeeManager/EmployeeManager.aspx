<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeManager.aspx.cs" Inherits="SuperMarketManager.Views.EmployeeManager.EmployeeManager" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>超市管理系统 | 员工管理</title>
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
                        <li><a href="../../Views/Index/Manager_Index.aspx"><i class="fa fa-tachometer fa-fw">
                            <div class="icon-bg bg-orange"></div>
                        </i><span class="menu-title">首页</span></a></li>

                        <li>
                        <li class="active"><a href="../../Views/EmployeeManager/EmployeeManager.aspx"><i class="fa fa-desktop fa-fw">
                            <div class="icon-bg bg-pink"></div>
                        </i><span class="menu-title">员工管理</span></a>

                        </li>
                        <li><a href="../../Views/SupplierManager/SupplierManager.aspx"><i class="fa fa-send-o fa-fw">
                            <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">供应商管理</span></a>

                        </li>
                        <li><a href="Forms.html"><i class="fa fa-edit fa-fw">
                            <div class="icon-bg bg-violet"></div>
                        </i><span class="menu-title">商品销售与库存</span></a>

                        </li>
                        <li><a href="Tables.html"><i class="fa fa-th-list fa-fw">
                            <div class="icon-bg bg-blue"></div>
                        </i><span class="menu-title">营业统计</span></a>

                        </li>
                        <li><a href="DataGrid.html"><i class="fa fa-database fa-fw">
                            <div class="icon-bg bg-red"></div>
                        </i><span class="menu-title">个人信息</span></a>

                        <li><a href="../../Views/Login/Login.aspx"><i class="fa fa-slack fa-fw">
                        <div class="icon-bg bg-green"></div>
                        </i><span class="menu-title">退出</span></a></li>
                    </ul>
                </div>
            </nav>


            <div id="page-wrapper">
                <!--BEGIN TITLE & BREADCRUMB PAGE-->
                <div id="title-breadcrumb-option-demo" class="page-title-breadcrumb">
                    <div class="page-header pull-left">
                        <div class="page-title">
                            员工管理
                        </div>
                    </div>
                    <ol class="breadcrumb page-breadcrumb pull-right">
                        <li><i class="fa fa-home"></i>&nbsp;<a href="../../Views/Index/Manager_Index.aspx">Home</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="hidden"><a href="#">员工管理</a>&nbsp;&nbsp;<i class="fa fa-angle-right"></i>&nbsp;&nbsp;</li>
                        <li class="active">员工管理</li>
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
                            <div>
                                <form runat="server">
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="employeeid">
                                        <HeaderStyle BackColor="Yellow" BorderStyle="Double" Font-Size="Large" />
                                        <RowStyle BorderWidth="10px" BorderStyle="Double" Height="60px" Width="160px" />
                                        <Columns>
                                            <asp:BoundField DataField="id" Visible="true" HeaderText="工号" />
                                            <asp:BoundField DataField="name" HeaderText="姓名" />
                                            <asp:BoundField DataField="id" HeaderText="性别" />
                                            <asp:BoundField DataField="id" HeaderText="出生年月" />
                                            <asp:BoundField DataField="id" HeaderText="身份证号" />
                                            <asp:BoundField DataField="id" HeaderText="联系方式" />
                                            <asp:BoundField DataField="id" HeaderText="职位" />
                                        </Columns>
                                    </asp:GridView>
                                </form>
                            </div>
                            <div class="col-lg-12">
                                <div class="row">
                                    <div class="col-lg-6">
                                        <div class="panel panel-yellow">
                                            <div class="panel-heading">员工信息表</div>
                                            <div class="panel-body">
                                                <table class="table table-hover">
                                                    <thead>
                                                        <tr>
                                                            <th>#</th>
                                                            <th>Username</th>
                                                            <th>Age</th>
                                                            <th>Status</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>1</td>
                                                            <td>Henry</td>
                                                            <td>23</td>
                                                            <td><span class="label label-sm label-success">Approved</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>2</td>
                                                            <td>John</td>
                                                            <td>45</td>
                                                            <td><span class="label label-sm label-info">Pending</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>3</td>
                                                            <td>Larry</td>
                                                            <td>30</td>
                                                            <td><span class="label label-sm label-warning">Suspended</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>4</td>
                                                            <td>Lahm</td>
                                                            <td>15</td>
                                                            <td><span class="label label-sm label-danger">Blocked</span></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
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

