<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebXmlService.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" Text="Rate DataGrid" Font-Bold="true" Font-Size="X-Large" runat="server"></asp:Label>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label2" Text="Currency DataGrid" Font-Bold="true" Font-Size="X-Large" runat="server"></asp:Label>
                    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="10000"></asp:Timer>
                    <script>
                        var label = document.getElementById("<%=Label3.ClientID%>");
                        var interval = setInterval(fff, 1000);
                        function fff() {
                            label.textContent += 1;
                        }
                    </script>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

    </form>
</body>
</html>
