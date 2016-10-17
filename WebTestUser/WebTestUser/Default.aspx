<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTestUser.Default" %>
<%@ Register TagPrefix="mycontrol" TagName="TestBodyControl" Src="~/TestBodyControl.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:UpdatePanel ID="UpdatePanel" runat="server">
            <ContentTemplate>
                <mycontrol:TestBodyControl ID="TestBodyControl"  runat="server"/>
                <asp:Button ID="ButtNext" runat="server" Text="Next-->" />
                <asp:Button ID="ButtCancel" runat="server" Text="Cancel" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
