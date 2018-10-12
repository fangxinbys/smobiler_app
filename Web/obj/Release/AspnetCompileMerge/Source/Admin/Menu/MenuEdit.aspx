<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuEdit.aspx.cs" Inherits="Maticsoft.Web.Admin.Menu.MenuEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server" />
        <f:Panel ID="Panel1" ShowBorder="false" ShowHeader="false" AutoScroll="true" runat="server">
            <Toolbars>
                <f:Toolbar ID="toolbar" runat="server" ToolbarAlign="Right" Position="Bottom">
                    <Items>
                        <f:Button ID="btnClose" Icon="SystemClose" EnablePostBack="false" runat="server"
                            Text="关闭">
                        </f:Button>
                        <f:ToolbarSeparator ID="toolbarSe" runat="server">
                        </f:ToolbarSeparator>
                        <f:Button ID="btnSaveClose" ValidateForms="SimpleForm1" Icon="SystemSaveClose" OnClick="btnSaveClose_Click"
                            runat="server" Text="保存后关闭">
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
            <Items>
                <f:Form ID="SimpleForm1" ShowBorder="false" ShowHeader="false" runat="server" BodyPadding="10px"
                    Title="SimpleForm">
                    <Rows>
                        <f:FormRow runat="server">
                            <Items>
                                <f:TextBox ID="txtName" runat="server" Label="菜单名称" Required="true" ShowRedStar="true">
                                </f:TextBox>

                            </Items>
                        </f:FormRow>
                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtUrl" Label="菜单地址" Required="true" ShowRedStar="true" runat="server" />
                            </Items>
                        </f:FormRow>
                        <f:FormRow>
                            <Items>
                                <f:NumberBox ID="txtSort" Label="菜单排序" Required="true" ShowRedStar="true" runat="server" EmptyText="请输入数字" NoDecimal="True" NoNegative="True" Text="0" />
                            </Items>
                        </f:FormRow>

                        <f:FormRow runat="server">
                             <Items>
                                <f:CheckBox runat="server"   Label="上级菜单" Text="是（一级菜单）" ID="chk"></f:CheckBox>
                            </Items>
                            <Items>
                                <f:TriggerBox ID="txtFather" TriggerIcon="Search" EnableEdit="false"  
                                    OnTriggerClick="txtFather_TriggerClick" runat="server" Label="上级菜单">
                                </f:TriggerBox>
                            </Items>
                        </f:FormRow>
                        <f:FormRow>
                            <Items>
                                <f:DropDownList runat="server" ID="drp_tb" Label="菜单图标" EnableEdit="true">
                                </f:DropDownList>
                            </Items>
                        </f:FormRow>

                        <f:FormRow runat="server">
                            <Items>
                                <f:TextArea ID="txtRemark" runat="server" Label="备注">
                                </f:TextArea>
                            </Items>
                        </f:FormRow>
                    </Rows>
                </f:Form>
            </Items>
        </f:Panel>


        <f:Window ID="Window1" Title="菜单架构" Hidden="true" EnableIFrame="true" runat="server"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="550px"
            Height="350px">
        </f:Window>

        <f:HiddenField ID="dptFatherId" runat="server" >
        </f:HiddenField>
    </form>

</body>
</html>
