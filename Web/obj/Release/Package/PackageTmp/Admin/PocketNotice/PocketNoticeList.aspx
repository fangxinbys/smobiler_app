<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PocketNoticeList.aspx.cs" Inherits="Maticsoft.Web.Admin.PocketNotice.PocketNoticeList" %>

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
                    DataKeyNames="noticeId" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                    OnRowCommand="GridDpt_RowCommand" AllowSorting="true" SortField="noticeId" SortDirection="asc" OnSort="GridDpt_Sort">
                    <Toolbars>
                        <f:Toolbar ID="Toolbar" runat="server">

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
                                <f:Button ID="btnNew" runat="server" Icon="Add" Text="添加通告" OnClick="btnNew_Click">
                                </f:Button>
                            </Items>
                        </f:Toolbar>

                    </Toolbars>
               
                    <Columns>

                        <f:BoundField DataField="noticeTitle" HeaderText="通告标题" SortField="noticeTitle" ExpandUnusedSpace="true" />

                        <f:BoundField DataField="noticeTime" HeaderText="通告时间" ExpandUnusedSpace="true" />

                        <f:LinkButtonField ColumnID="editField" TextAlign="Center" Icon="Pencil" ToolTip="通告修改" ConfirmTarget="Top" CommandName="Edit" Width="50px" />
                        <f:LinkButtonField ColumnID="deleteField" TextAlign="Center" Icon="Delete" ToolTip="删除"
                            ConfirmText="确定删除该通告？" ConfirmTarget="Top" CommandName="Delete" Width="50px" />
                    </Columns>
                </f:Grid>

            </Items>
        </f:Panel>
        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server" OnClose="Window1_Close"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="700px" Title="通告管理"
            Height="400px">
        </f:Window>


    </form>
</body>
</html>
