<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormProduct.aspx.cs" Inherits="ASPTask1.WebFormProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelProduct" runat="server" Text="Список продуктов"></asp:Label>
        </div>
        <div>
            <asp:ListBox ID="ListBoxProduct" runat="server" Width="150" Height="200" SelectionMode="Multiple"></asp:ListBox>
        </div>
        <div>
            <asp:Label ID="LabelBasket" runat="server" Text="Корзина"></asp:Label>
        </div>
        <div>
            <asp:ListBox ID="ListBoxBasket" runat="server" Width="150" Height="200" SelectionMode="Multiple"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="ButtAddBasket" runat="server" Width="250" Text="Поместить в корзину" OnClick="ButtAddBasket_Click" />
        </div>
        <div>
            <asp:Button ID="ButtRemoveFromBasket" runat="server" Width="250" Text="Убрать из корзины" OnClick="ButtRemoveFromBasket_Click" />
        </div>
        <div>
            <asp:Button ID="ButtAddBasketAll" runat="server" Width="250" Text="Перенести все в корзину" OnClick="ButtAddBasketAll_Click" />
        </div>
        <div>
            <asp:Button ID="ButtRemoveFromBasketAll" runat="server" Width="250" Text="Убрать все из корзины" OnClick="ButtRemoveFromBasketAll_Click" />
        </div>
    </form>
</body>
</html>
