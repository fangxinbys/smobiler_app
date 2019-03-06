<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PocketMentorList.aspx.cs" Inherits="Maticsoft.Web.Admin.PocketMentor.PocketMentorList" %>

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
                    DataKeyNames="mentorId" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                    AllowSorting="true" SortField="mentorId" SortDirection="asc" OnSort="GridDpt_Sort">
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

                            </Items>
                        </f:Toolbar>

                    </Toolbars>

                    <Columns>

                        <f:BoundField DataField="pocketMaster" HeaderText="师傅" SortField="pocketMaster" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="disciple" HeaderText="徒弟" SortField="disciple" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="masterMoney" HeaderText="师傅赏金" SortField="disciple" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="discipleMoney" HeaderText="徒弟赏金" SortField="disciple" ExpandUnusedSpace="true" />
                    </Columns>
                </f:Grid>

            </Items>
        </f:Panel>
       

    </form>
</body>
</html>
