<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebValidationExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="240px" Height="20"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="Red" ControlToValidate="TextBox1" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div>
             <asp:TextBox ID="TextBox2" runat="server" Width="240" Height="20"></asp:TextBox>
        </div>
        <br />
        <br />
        <div>
             <asp:Button ID="Button1" runat="server" Text="Разделить" Width="180px" />
        </div>
    </form>
</body>
</html>
