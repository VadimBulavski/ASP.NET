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

            <asp:GridView
                ID="GridView1"
                runat="server"
                DataSourceID="CityDataSource" />

            <asp:ListBox ID="ListBox1" DataSourceID="CityDataSource" DataMember="NameCity" runat="server"/>

            <asp:XmlDataSource ID="XmlCityDataSource" runat="server" DataFile="citys.xml"></asp:XmlDataSource>

            <asp:TreeView ID="CityTreeView"
                DataSourceID="XmlCityDataSource"
                runat="server">

                <DataBindings>
                    <asp:TreeNodeBinding DataMember="NameCity" TextField="#innerText" />
                    <asp:TreeNodeBinding DataMember="Area" TextField="#innerText" />
                    <asp:TreeNodeBinding DataMember="Population" TextField="#innerText" />
                </DataBindings>

            </asp:TreeView>
        </div>

    </form>
</body>
</html>
