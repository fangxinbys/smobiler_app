<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PowersList.aspx.cs" Inherits="Maticsoft.Web.Admin.Powers.PowersList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server"  OnCustomEvent="PageManager1_CustomEvent"/>

        <f:Panel ID="Panel1" CssClass="blockpanel" runat="server" ShowBorder="false" ShowHeader="false" Layout="Region">

            <Items>

                <f:Panel runat="server" ID="panelLeftRegion" RegionPosition="Left" RegionSplit="true" EnableCollapse="true"
                    Width="230px" Title="选择部门" ShowBorder="true" ShowHeader="true" AutoScroll="true"
                    BodyPadding="10px">
                    <Items>
                        <f:Tree ID="TreeDpt" IsFluid="true" CssClass="blockpanel" ShowHeader="false" Title="组织架构" ShowBorder="false"
                            EnableCollapse="false" runat="server" OnNodeCommand="TreeDpt_NodeCommand">
                        </f:Tree>
                    </Items>
                </f:Panel>
                <f:Panel runat="server" ID="panel2" RegionPosition="Left" RegionSplit="true" EnableCollapse="true"
                    Width="230px" Title="选择用户" ShowBorder="true" ShowHeader="true" AutoScroll="true"
                    BodyPadding="10px">
                    <Items>
                        <f:Tree ID="TreeUser" IsFluid="true" CssClass="blockpanel" ShowHeader="false" Title="用户列表" ShowBorder="false"
                            EnableCollapse="false" runat="server" OnNodeCommand="TreeUser_NodeCommand">
                        </f:Tree>
                    </Items>
                </f:Panel>
                <f:Panel runat="server" ID="panel3" RegionPosition="Left" RegionSplit="true" EnableCollapse="true"
                    Width="230px" Title="权限设置" ShowBorder="true" ShowHeader="true" AutoScroll="true"
                    BodyPadding="10px">

                    <Items>
                        <f:Tree ID="TreePower" IsFluid="true" CssClass="blockpanel" ShowHeader="false" EnableMultiSelect="true" OnNodeCheck="TreePower_NodeCheck"
                            EnableCollapse="false" runat="server" ShowBorder="false" OnNodeCommand="TreePower_NodeCommand">
                        </f:Tree>
                    </Items>
                </f:Panel>
                <f:Panel runat="server" ID="panelCenterRegion" RegionPosition="Center"
                    Title="" ShowBorder="true" ShowHeader="true" BodyPadding="10px">
                    <Items>
                    </Items>
                </f:Panel>
            </Items>
            <Toolbars >
                <f:Toolbar ID="Toolbar1" Position="Top" runat="server" >
                    <Items>
                        <f:ToolbarFill ID="ToolbarFill1" runat="server">
                        </f:ToolbarFill>
                        <f:TextBox ID="txtName" Label="名称" runat="server" />


                        <f:Button ID="btnNew" runat="server" Icon="Add" Text="添加权限" OnClick="btnNew_Click">
                        </f:Button>
                        <f:HiddenField ID="txtPidValue" runat="server" ></f:HiddenField>

                        <f:TextBox ID="txtPidName" Label="已选" runat="server" Readonly="true"    />
                        <f:Button ID="btnDel" runat="server" Icon="Delete" Text="删除权限" EnablePostBack="false" >
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Panel>

    </form>
</body>
</html>
