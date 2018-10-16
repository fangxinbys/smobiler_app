<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPointEdit.aspx.cs" Inherits="Maticsoft.Web.Admin.Member.MemberPointEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server" />
        <f:Panel ID="Panel1" CssClass="blockpanel"   runat="server" ShowBorder="false" ShowHeader="false" Layout="Region">



            <Toolbars>
                <f:Toolbar ID="Toolbar" runat="server">

                    <Items>

                        <f:RadioButton ID="rbtnFirst" Checked="true" GroupName="MyRadioGroup1" Text="消费" runat="server" LabelWidth="65">
                        </f:RadioButton>
                        <f:RadioButton ID="rbtnSecond" GroupName="MyRadioGroup1" ShowEmptyLabel="true" Text="充值" runat="server" LabelWidth="65">
                        </f:RadioButton>
                    </Items>


                </f:Toolbar>

                <f:Toolbar ID="Toolbar1" runat="server">


                    <Items>
                        <f:NumberBox runat="server" ID="txtNum" Label="金额" ShowRedStar="true" MinValue="0" Required="true" LabelWidth="65" Width="150"></f:NumberBox>
                        <f:TextBox runat="server" ID="txtValue" Label="备注" Width="250" LabelWidth="65"></f:TextBox>
                        <f:Button runat="server" ID="btnSelect" Text="提交" Icon="DatabaseSave" OnClick="btnSelect_Click"></f:Button>
                        <f:Button runat="server" ID="btnExcel" Text="导出" Icon="Cursor" OnClick="btnExcel_Click"
                            EnableAjax="false" DisableControlBeforePostBack="false">
                        </f:Button>
                    </Items>
                </f:Toolbar>

            </Toolbars>
            <Items>
                <f:Grid ID="GridDpt" runat="server" ShowBorder="false" ShowHeader="false" OnPageIndexChange="GridDpt_PageIndexChange"
                    DataKeyNames="Id" EnableMultiSelect="false" ShowPagingMessage="true" AllowPaging="true" IsDatabasePaging="true"
                    OnRowCommand="GridDpt_RowCommand" AllowSorting="true" SortField="Id" SortDirection="desc" OnSort="GridDpt_Sort">

                    <Columns>

                        <f:BoundField DataField="UvipId" HeaderText="编号" SortField="UvipId" ExpandUnusedSpace="true" />

                        <f:BoundField DataField="Uqyt" HeaderText="金额" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="Urmk" HeaderText="备注" ExpandUnusedSpace="true" />
                        <f:BoundField DataField="Utime" HeaderText="时间" ExpandUnusedSpace="true" />


                    </Columns>
                </f:Grid>
            </Items>



        </f:Panel>



    </form>
</body>
</html>
