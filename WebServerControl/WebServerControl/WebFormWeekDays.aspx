<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormWeekDays.aspx.cs" Inherits="WebServerControl.WebFormWeekDays" %>
<%@ Register Assembly="MyWeekDayServerControl"  Namespace="MyWeekDayServerControl"  TagPrefix="ccs" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="user">
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <ccs:ServerControl1 ID="ServerControl" Text="" runat="server" />
        </div>
    </form>
</body>
</html>
