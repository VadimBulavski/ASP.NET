<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFoto.aspx.cs" Inherits="WebTask2ImgManager.AddFoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUploadControl" runat="server" />
            <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_Click" Width="58px" />
            <br />
            <br />
            <asp:Label runat="server" ID="StatusLabel" Text="Upload status: " />
            <br />
            <br />
            <asp:Button ID="ButtonViewImages" runat="server" Text="View Images" OnClick="ButtonViewImages_Click" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
