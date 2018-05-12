<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SuperMarketManager.Views.Index.Index" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>B page</title>
    <script>
        $(document).ready(function() {
            //使用正则表达式获取url中的参数
            function getUrlParam(name) {
                //构造一个含有目标参数的正则表达式对象
                var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
                //匹配目标参数 
                var r = window.location.search.substr(1).match(reg);  
                //返回参数值
                if (r != null) return unescape(r[2]); return null;
            }
            var urlData = getUrlParam('data');
            // 将数据填充到input框里面
            $('#getUrlData').val(urlData);
        });
</script>
</head>
<body>
    <input type="text" id="getUrlData">
</body>
</html>

