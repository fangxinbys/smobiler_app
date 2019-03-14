<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskCheckList.aspx.cs" Inherits="Maticsoft.Web.Admin.TaskCheck.TaskCheckList" %>

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
                <f:Grid ID="GridDpt" runat="server" ShowBorder="false" ShowHeader="false" OnPageIndexChange="GridDpt_PageIndexChange"
                    DataKeyNames="subId" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                    OnRowCommand="GridDpt_RowCommand" AllowSorting="true" SortField="subId" SortDirection="asc" OnSort="GridDpt_Sort">
                    <Toolbars>
                        <f:Toolbar ID="Toolbar" runat="server">
                            <Items>
                                <f:DropDownList runat="server" ID="drpSearch" AutoPostBack="true" OnSelectedIndexChanged="drpSearch_SelectedIndexChanged">

                                    <f:ListItem Text="全部" Value="" />
                                    <f:ListItem Text="已审核" Value="已审核" />
                                    <f:ListItem Text="已驳回" Value="已驳回" />
                                    <f:ListItem Text="待审核" Value="待审核" />
                                </f:DropDownList>
                            </Items>
                            <Items>


                                <f:TextBox runat="server" ID="txtValue" Label="快速查询"></f:TextBox>
                            </Items>
                            <Items>
                                <f:Button runat="server" ID="btnSelect" Text="查询" Icon="Zoom" OnClick="btnSelect_Click"></f:Button>
                                <f:Button runat="server" ID="btnExcel" Text="导出数据" Icon="Cursor" OnClick="btnExcel_Click"
                                    EnableAjax="false" DisableControlBeforePostBack="false">
                                </f:Button>
                            </Items>
                            <Items>
                                <f:ToolbarFill ID="ToolbarFill1" runat="server">
                                </f:ToolbarFill>
                                <f:Button ID="btnRe" runat="server" Icon="Reload" Text="刷新" OnClick="btnRe_Click"></f:Button>

                            </Items>
                        </f:Toolbar>

                    </Toolbars>

                    <Columns>

                        <f:BoundField DataField="examine" HeaderText="审核" SortField="examine" ExpandUnusedSpace="true" />

                        <f:BoundField DataField="subUser" HeaderText="提交用户" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="subTime" HeaderText="提交时间" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketUserName" HeaderText="昵称" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketUserAlipay" HeaderText="支付宝" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketUserReName" HeaderText="姓名" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketTaskInfo" HeaderText="任务" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketTaskNum" HeaderText="任务发布数" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketTaskMoney" HeaderText="任务单价" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketTime" HeaderText="发布时间" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="pocketTaskRuleUrl" HeaderText="任务规则" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="IsTaskRecCount" HeaderText="任务领取数量" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="IsTaskSubCount" HeaderText="任务提交数量" ExpandUnusedSpace="true" />
                        <f:LinkButtonField ColumnID="editField" TextAlign="Center" Icon="Pencil" ToolTip="任务审核" ConfirmTarget="Top" CommandName="Edit" Width="50px" />
                        <f:LinkButtonField ColumnID="deleteField" TextAlign="Center" Icon="Delete" ToolTip="删除"
                            ConfirmText="确定删除该任务提交？" ConfirmTarget="Top" CommandName="Delete" Width="50px" />
                    </Columns>
                </f:Grid>

            </Items>
        </f:Panel>
        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server" OnClose="Window1_Close"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="700px" Title="任务提交管理"
            Height="400px">
        </f:Window>


    </form>
</body>
</html>
