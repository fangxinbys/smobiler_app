<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BalanceRecardList.aspx.cs" Inherits="Maticsoft.Web.Admin.BalanceRecard.BalanceRecardList" %>

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
                    DataKeyNames="recardId" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                    OnRowCommand="GridDpt_RowCommand" AllowSorting="true" SortField="recardId" SortDirection="asc" OnSort="GridDpt_Sort">
                    <Toolbars>
                        <f:Toolbar ID="Toolbar" runat="server">
                            <Items>
                                <f:DropDownList runat="server" ID="drpSearch" AutoPostBack="true" OnSelectedIndexChanged="drpSearch_SelectedIndexChanged">

                                    <f:ListItem Text="全部" Value="" />
                                    <f:ListItem Text="通过" Value="通过" />
                                    <f:ListItem Text="驳回" Value="驳回" />
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

                        <f:BoundField DataField="recardState" HeaderText="状态" SortField="recardState" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="recardStateTime" HeaderText="审核时间" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="recardUser" HeaderText="提现用户" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="recardTime" HeaderText="提现时间" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="recardMoney" HeaderText="提现金额" ExpandUnusedSpace="true" />

                        <f:LinkButtonField ColumnID="editField" TextAlign="Center" Icon="Pencil" ToolTip="提现审核" ConfirmTarget="Top" CommandName="Edit" Width="50px" />
                        <f:LinkButtonField ColumnID="deleteField" TextAlign="Center" Icon="Delete" ToolTip="删除" Enabled="false"
                            ConfirmText="确定删除该提交？" ConfirmTarget="Top" CommandName="Delete" Width="50px" />
                    </Columns>
                </f:Grid>

            </Items>
        </f:Panel>
        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server" OnClose="Window1_Close"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="700px" Title="提现管理"
            Height="400px">
        </f:Window>


    </form>
</body>
</html>
