<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BomList.aspx.cs" Inherits="Maticsoft.Web.Admin.Bom.BomList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server"   />

        <f:Panel ID="Panel1" CssClass="blockpanel" runat="server" ShowBorder="false" ShowHeader="false" Layout="Region">

            <Items>


                <f:Panel runat="server" ID="panelLeftRegion" RegionPosition="Left" RegionSplit="true" EnableCollapse="true"
                    Width="230px" Title="Bom" ShowBorder="true" ShowHeader="true" AutoScroll="true" BodyPadding="10px">
                    <Items>
                        <f:Tree ID="TreeBom" IsFluid="true" CssClass="blockpanel" ShowHeader="false" Title="Bom" ShowBorder="false"
                            EnableCollapse="false" runat="server">
                        </f:Tree>
                    </Items>
                </f:Panel>

                <f:Panel runat="server" ID="panelCenterRegion" RegionPosition="Center"
                    Title="" ShowBorder="true" ShowHeader="true" BodyPadding="10px">
                    <Items>
                    </Items>

                </f:Panel>
            </Items>
            <Toolbars>
                <f:Toolbar ID="Toolbar1" Position="Top" runat="server">
                    <Items>
                    </Items>
                </f:Toolbar>

            </Toolbars>
        </f:Panel>

    </form>
</body>
</html>
