<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Maticsoft.Web.Admin.Users.UserList" %>

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
                        <f:Tree ID="TreeDpt" IsFluid="true" CssClass="blockpanel" ShowHeader="true" Title="部门列表"
                            EnableCollapse="false" runat="server" OnNodeCommand="TreeDpt_NodeCommand">
                        </f:Tree>
                    </Items>
                </f:Panel>

                <f:Panel runat="server" ID="panelRightRegion" RegionPosition="Right" RegionSplit="true" EnableCollapse="true" AutoScroll="true"
                    RegionPercent="80%" ShowHeader="false" IconFont="_PullRight">
                    <Items>
                        <f:Grid ID="GridDpt" runat="server" ShowBorder="false" ShowHeader="false" OnPageIndexChange="GridDpt_PageIndexChange"
                            DataKeyNames="userId" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                            OnRowCommand="GridDpt_RowCommand" AllowSorting="true" SortField="userId" SortDirection="asc" OnSort="GridDpt_Sort">
                            <Toolbars>
                                <f:Toolbar ID="Toolbar1" Position="Top" runat="server">
                                    <Items>
                                        <f:ToolbarFill ID="ToolbarFill1" runat="server">
                                        </f:ToolbarFill>
                                        <f:Button ID="btnNew" runat="server" Icon="Add" Text="添加用户" OnClick="btnNew_Click">
                                        </f:Button>
                                    </Items>
                                </f:Toolbar>
                            </Toolbars>
                            <Columns>

                                <f:BoundField Width="100px" DataField="userId" HeaderText="编码" SortField="userId" />
                                <f:TemplateField Width="120px" HeaderText="部门">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="dpt" Text='<%# GetDptName(Eval("dptId").ToString()) %>'></asp:Label>
                                    </ItemTemplate>
                                </f:TemplateField>
                                <f:BoundField Width="120px" DataField="usersName" HeaderText="用户名" />
                                <f:BoundField Width="120px" DataField="trueName" HeaderText="昵称" />
                                <f:TemplateField Width="120px" HeaderText="角色">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="rname" Text='<%# GetRoleName(Eval("roleCode").ToString()) %>'></asp:Label>
                                    </ItemTemplate>
                                </f:TemplateField>
                                <f:TemplateField Width="100px" HeaderText="状态">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="zt" Text='<%# GetZt(Eval("Flag").ToString()) %>'></asp:Label>
                                    </ItemTemplate>
                                </f:TemplateField>
                                <f:BoundField DataField="usersRemark" HeaderText="用户描述" ExpandUnusedSpace="true" />
                                <f:LinkButtonField ColumnID="editField" TextAlign="Center" Icon="Pencil" ToolTip="编辑" ConfirmTarget="Top" CommandName="Edit" Width="50px" />
                                <f:LinkButtonField ColumnID="deleteField" TextAlign="Center" Icon="Delete" ToolTip="删除"
                                    ConfirmText="确定删除该用户及权限？" ConfirmTarget="Top" CommandName="Delete" Width="50px" />
                            </Columns>
                        </f:Grid>
                    </Items>
                </f:Panel>

            </Items>
        </f:Panel>

        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server" OnClose="Window1_Close"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="620px" Title="用户管理"
            Height="380px">
        </f:Window>
    </form>
</body>
</html>
