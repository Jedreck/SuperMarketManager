<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalInformation.aspx.cs" Inherits="SuperMarketManager.Views.PersonalInformation.PersonalInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>超市管理系统|个人信息管理</title>
</head>
<body>

    <div>

        <!--BEGIN BACK TO TOP-->

        <a id="totop" href="#"><i class="fa fa-angle-up"></i></a>

        <!--END BACK TO TOP-->

       


                <!--BEGIN CONTENT-->

                <div>

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

                                    <div class="col-lg-10">

                                       <form id="Form1" action="#" class="form-horizontal" runat="server">



                                            <asp:Label ID="basic" runat="server" Text="个人基本信息" class="label label-success" Font-Size="18px"></asp:Label>



                                            <div class="form-group"><label class="col-sm-3 control-label">工号</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-9"><input type="text" id="id" runat="server" placeholder="工号" class="form-control"/></div>

                                                    </div>

                                                </div>

                                            </div>

                                            <div class="form-group"><label class="col-sm-3 control-label">姓名</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-9">

                                                            <input id="up_name" runat="server" type="text" placeholder="姓名" class="form-control"/></div>

                                                    </div>

                                                </div>

                                            </div>

                                            <div class="form-group"><label class="col-sm-3 control-label">性别</label>

                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-9">

                                                            <asp:RadioButton ID="sex_male" runat="server" Text="男"  />

                                                            <asp:RadioButton ID="sex_female" runat="server" Text="女"  />                                                      

                                                        </div>

                                                    </div>

                                                </div>

                                            </div>

                                            <div class="form-group"><label class="col-sm-3 control-label">出生日期</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-4"><input type="password"  runat="server" id="birth" placeholder="年月日分秒" class="form-control"/></div>

                                                    </div>

                                                </div>

                                            </div>

                                           <div class="form-group"><label class="col-sm-3 control-label">密码</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-4"><input type="password" runat="server" id="password" readonly="readonly"  placeholder="初始密码:000000" class="form-control"/></div>

                                                    </div>

                                                </div>

                                            </div>

                                            <hr/>

                                            <h3><asp:Label ID="connect" runat="server" Text="联系方式" class="label label-warning" Font-Size="18px"/></h3>

                                            <div class="form-group"><label class="col-sm-3 control-label">邮箱</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-9"><input type="text" runat="server" id="email" placeholder="email" class="form-control"/></div>

                                                    </div>

                                                </div>

                                            </div>

                                            <div class="form-group"><label class="col-sm-3 control-label">手机号码</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-9"><input type="text" placeholder="手机号" runat="server" id="phone" class="form-control"/></div>

                                                    </div>

                                                </div>

                                            </div>                                                                                                                                         

                                            <hr/>



                                            <h3><asp:Label ID="working" runat="server" Text="员工工作情况" class="label label-info" Font-Size="18px"/></h3>

                                            <div class="form-group"><label class="col-sm-3 control-label">职位</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">



                                                        <div class="col-xs-4"><select class="form-control" runat="server" id="position">

                                                            <option>CEO</option>

                                                            <option>Director</option>

                                                            <option>Manager</option>

                                                            <option>Staff</option>

                                                            <option>Office Boy</option>

                                                        </select></div>

                                                    </div>

                                                </div>

                                            </div>

                                            <div class="form-group"><label class="col-sm-3 control-label">银行卡号</label>



                                                <div class="col-sm-9 controls">

                                                    <div class="row">

                                                        <div class="col-xs-9"><input type="text" runat="server" id="bankaccount" placeholder="银行卡号" class="form-control"/></div>

                                                    </div>

                                                </div>

                                            </div>

                                            <hr/>

                                           <asp:Label runat="server" ID="zero1" Width="200px" />

                                           <asp:Button ID="update" runat="server" Text="修改" class="btn-green" BorderStyle="Dashed"  Height="30px" Width="150px" OnClick="Update_Click" />

                                           <asp:Label runat="server" ID="zero2" Width="50px" />

                                           <asp:Button ID="back" runat="server" Text="返回" class="btn-green" BorderStyle="Dashed" Height="30px" Width="150px" OnClick="Back_Click" />

                                           <asp:Label runat="server" ID="zero3" Width="200px" />

                                        </form>



                                    </div>

                                </div>

                            </div>

                        </div>

                    </div>

                </div>

            </div>

        

        

</body>
</html>