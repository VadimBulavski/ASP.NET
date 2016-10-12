<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebObjectDataSource.Default" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ObjectDataSource
                ID="CityDataSource"
                runat="server"
                SelectMethod="GetCityCollection"
                TypeName="WebObjectDataSource.App_Code.ObjectCityRepository" />

            DataGrid
            <asp:GridView
                ID="GridView1"
                runat="server"
                DataSourceID="CityDataSource" />
            <br />
            ListBox<br />
&nbsp;<asp:ListBox ID="ListBox1" DataSourceID="CityDataSource" DataTextField="NameCity" Height="100" Width="100" runat="server"/>

            <asp:XmlDataSource ID="XmlCityDataSource" runat="server" DataFile="citys.xml"></asp:XmlDataSource>

            <br />
            <br />

            TreeView
            <asp:TreeView ID="CityTreeView"
                DataSourceID="XmlCityDataSource"
                runat="server">

                <DataBindings>
                    <asp:TreeNodeBinding DataMember="city" TextField="name" />
                    <asp:TreeNodeBinding DataMember="area" TextField="#innerText" />
                    <asp:TreeNodeBinding DataMember="population" TextField="#innerText" />
                </DataBindings>

            </asp:TreeView>
        </div>

    </form>
</body>
</html>
