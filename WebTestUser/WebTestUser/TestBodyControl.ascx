<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TestBodyControl.ascx.cs" Inherits="WebTestUser.TestBodyControl" %>

<table style="width:100%; border:0; background-color:lightblue">
     <tr>
        <td>
            <asp:label id="nameTest" runat="server"></asp:label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="bodyQuestion" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <div id ="textAnawer" runat="server"></div>
        </td>
    </tr>
</table>
