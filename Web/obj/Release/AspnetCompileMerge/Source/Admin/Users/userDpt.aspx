<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userDpt.aspx.cs" Inherits="Maticsoft.Web.Admin.Users.userDpt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server" />
        <f:Panel ID="Panel1" CssClass="blockpanel" Margin="10px" runat="server" ShowBorder="false" ShowHeader="false" Layout="Region">
            <Items>

                <f:Panel runat="server" ID="panelLeftRegion" RegionPosition="Center" RegionSplit="true" EnableCollapse="true" ShowBorder="false" RegionPercent="60%"
                    ShowHeader="false" IconFont="_PullLeft" AutoScroll="true">
                    <Items>
                        <f:Tree ID="TreeDpt" IsFluid="true" CssClass="blockpanel" ShowHeader="false" Title="组织架构"
                            EnableCollapse="false" runat="server" OnNodeCommand="TreeDpt_NodeCommand">
                        </f:Tree>
                    </Items>
                </f:Panel>
            </Items>
        </f:Panel>
    </form>
</body>
</html>
