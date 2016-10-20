<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TestBodyControl.ascx.cs" Inherits="WebTestUser.TestBodyControl" %>

<table style="width: 100%; border: 0; background-color: lightblue">
    <tr>
        <td>
            <asp:Label ID="nameTest" Font-Size="XX-Large" runat="server" Font-Bold="True"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="bodyQuestion" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Panel ID="textAnswer" runat="server" Font-Size="Large" Font-Bold="true"></asp:Panel>

            <%--<div id="textAnswer" runat="server" style="font-size: large; font-weight: bold"></div>--%>
        </td>
    </tr>
</table>
