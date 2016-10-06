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
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" Display="Dynamic" 
                ErrorMessage="Поле не заполнено!" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer"
                ErrorMessage="Недопустимое значение" ForeColor="Red"></asp:RangeValidator>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server" Width="240" Height="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" Display="Dynamic" 
                ErrorMessage="Поле не заполнено!" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox2" MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer"
                ErrorMessage="Недопустимое значение" ForeColor="Red" Display="Dynamic"></asp:RangeValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="TextBox2" ValidationExpression="[^0]*" runat="server" 
                ErrorMessage="Недопустимое значение" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Разделить" Width="180px" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
