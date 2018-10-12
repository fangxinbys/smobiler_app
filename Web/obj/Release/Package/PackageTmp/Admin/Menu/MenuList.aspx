<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuList.aspx.cs" Inherits="Maticsoft.Web.Admin.Menu.MenuList" %>

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

                <f:Panel runat="server" ID="panelLeftRegion" RegionPosition="Left" RegionSplit="true" EnableCollapse="true" ShowBorder="false"
                    RegionPercent="20%" ShowHeader="false" IconFont="_PullLeft" AutoScroll="true">
                    <Items>
                        <f:Tree ID="TreeDpt" IsFluid="true" CssClass="blockpanel" ShowHeader="true" Title="菜单架构"
                            EnableCollapse="false" runat="server" OnNodeCommand="TreeDpt_NodeCommand">
                        </f:Tree>
                    </Items>
                </f:Panel>

                <f:Panel runat="server" ID="panelRightRegion" RegionPosition="Right" RegionSplit="true" EnableCollapse="true" AutoScroll="true"
                    RegionPercent="80%" ShowHeader="false" IconFont="_PullRight">
                    <Items>
                        <f:Grid ID="GridDpt" runat="server" ShowBorder="false" ShowHeader="false" OnPageIndexChange="GridDpt_PageIndexChange"
                            DataKeyNames="mCode" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                            OnRowCommand="GridDpt_RowCommand" AllowSorting="true" SortField="mCode" SortDirection="asc" OnSort="GridDpt_Sort">
                            <Toolbars>
                                <f:Toolbar ID="Toolbar1" Position="Top" runat="server">
                                    <Items>
                                        <f:ToolbarFill ID="ToolbarFill1" runat="server">
                                        </f:ToolbarFill>
                                        <f:Button ID="btnNew" runat="server" Icon="Add" Text="添加菜单" OnClick="btnNew_Click">
                                        </f:Button>
                                    </Items>
                                </f:Toolbar>
                            </Toolbars>
                            <Columns>


                                <f:BoundField DataField="mCode" HeaderText="编码" Width="150px" SortField="mCode" />
                                <f:BoundField DataField="mName" HeaderText="菜单名称" Width="150px" />
                                <f:BoundField DataField="mUrl" HeaderText="菜单地址" ExpandUnusedSpace="true"/>
                                <f:BoundField DataField="mIcon" HeaderText="图标" Width="150px" />
                                <f:BoundField DataField="mSort" HeaderText="排序" Width="150px" />
                                <f:BoundField DataField="mRemark" HeaderText="备注" ExpandUnusedSpace="true" />
                                <f:LinkButtonField ColumnID="editField" TextAlign="Center" Icon="Pencil" ToolTip="编辑" ConfirmTarget="Top" CommandName="Edit" Width="50px" />
                                <f:LinkButtonField ColumnID="deleteField" TextAlign="Center" Icon="Delete" ToolTip="删除"
                                    ConfirmText="确定删除该菜单及相关权限？" ConfirmTarget="Top" CommandName="Delete" Width="50px" />
                            </Columns>
                        </f:Grid>
                    </Items>
                </f:Panel>

            </Items>
        </f:Panel>

        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server" OnClose="Window1_Close"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="650px" Title="菜单管理"
            Height="420px">
        </f:Window>
    </form>
</body>
</html>
