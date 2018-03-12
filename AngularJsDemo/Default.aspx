<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AngularJsDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/angular.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div ng-app>
            2 + 3 = {{ 2 + 3 }} 

        </div>
    </form>
</body>
</html>
