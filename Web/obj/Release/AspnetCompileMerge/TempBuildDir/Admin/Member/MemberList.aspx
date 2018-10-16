<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="Maticsoft.Web.Admin.Member.MemberList" %>

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



                <f:Panel runat="server" ID="panelRightRegion" RegionPosition="Right" RegionSplit="true" EnableCollapse="true" AutoScroll="true"
                    RegionPercent="100%" ShowHeader="false" IconFont="_PullRight">
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

                        </f:Toolbar>

                    </Toolbars>
                    <Items>
                        <f:Grid ID="GridDpt" runat="server" ShowBorder="false" ShowHeader="false" OnPageIndexChange="GridDpt_PageIndexChange"
                            DataKeyNames="Id" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                            OnRowCommand="GridDpt_RowCommand" AllowSorting="true" SortField="Id" SortDirection="asc" OnSort="GridDpt_Sort">
                            <Toolbars>
                                <f:Toolbar ID="Toolbar1" Position="Top" runat="server">
                                    <Items>
                                        <f:ToolbarFill ID="ToolbarFill1" runat="server">
                                        </f:ToolbarFill>
                                        <f:Button ID="btnNew" runat="server" Icon="Add" Text="添加会员" OnClick="btnNew_Click">
                                        </f:Button>
                                    </Items>
                                </f:Toolbar>
                            </Toolbars>
                            <Columns>

                                <f:BoundField DataField="Ucode" HeaderText="卡号" SortField="Ucode" ExpandUnusedSpace="true" />

                                <f:BoundField DataField="Uname" HeaderText="会员名" ExpandUnusedSpace="true" />
                                <f:BoundField DataField="Utel" HeaderText="电话" ExpandUnusedSpace="true" />
                                <f:BoundField DataField="Uwx" HeaderText="微信" ExpandUnusedSpace="true" />
                                <f:BoundField DataField="UchName" HeaderText="孩子姓名" ExpandUnusedSpace="true" />
                                <f:BoundField DataField="UbirTime" HeaderText="孩子生日" ExpandUnusedSpace="true" />
                                <f:BoundField DataField="Uads" HeaderText="地址" ExpandUnusedSpace="true" />
                                <f:BoundField DataField="Usex" HeaderText="性别" />
                                <f:TemplateField HeaderText="积分" ExpandUnusedSpace="true">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="rname" Text='<%# GetFen(Eval("Id").ToString()) %>'></asp:Label>
                                    </ItemTemplate>
                                </f:TemplateField>

                                <f:LinkButtonField ColumnID="editFieldPower" TextAlign="Center" Icon="User" ToolTip="积分操作" ConfirmTarget="Top" CommandName="EditPoint" Width="50px" />
                                <f:LinkButtonField ColumnID="editField" TextAlign="Center" Icon="Pencil" ToolTip="信息修改" ConfirmTarget="Top" CommandName="Edit" Width="50px" />
                                <f:LinkButtonField ColumnID="deleteField" TextAlign="Center" Icon="Delete" ToolTip="删除"
                                    ConfirmText="确定删除该会员？" ConfirmTarget="Top" CommandName="Delete" Width="50px" />
                            </Columns>
                        </f:Grid>
                    </Items>
                </f:Panel>

            </Items>
        </f:Panel>

        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server" OnClose="Window1_Close" CloseAction="HidePostBack"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="700px" Title="会员管理"
            Height="400px">
        </f:Window>


    </form>
</body>
</html>
