<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TestBodyControl.ascx.cs" Inherits="WebTestUser.TestBodyControl" %>

<table style="width:100%; border:0; background-color:lightblue">
     <tr>
        <td>
            <asp:label id="nameTest" Font-Size="XX-Large" runat="server" Font-Bold="True"></asp:label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="bodyQuestion" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <div id ="textAnawer" runat="server" style="font-size: large; font-weight: bold"></div>
        </td>
    </tr>
</table>
