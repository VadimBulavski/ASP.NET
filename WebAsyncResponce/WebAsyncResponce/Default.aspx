<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAsyncResponce.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager" runat="server" />
            <asp:UpdatePanel ID="UpdataPanel" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="144px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" Height="33px" Width="145px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Ok" Width="76px" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancel" />
                    <br />
                    <asp:UpdateProgress runat="server">
                        <ProgressTemplate>
                            <asp:Image runat="server" ImageUrl="Source/Fading lines.gif" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <br />
                    <br />
                    <asp:GridView
                        ID="GridView1"
                        runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField  HeaderText="Name" DataField="Name"/>
                            <asp:BoundField  HeaderText="Category" DataField="Category"/>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
