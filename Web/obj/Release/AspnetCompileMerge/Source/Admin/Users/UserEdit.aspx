<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserEdit.aspx.cs" Inherits="Maticsoft.Web.Admin.Users.UserEdit" %>

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
                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtUsername" Label="用户名" Required="true" ShowRedStar="true" runat="server" />
                            </Items>
                            <Items>
                                <f:TextBox ID="txtNickName" Label="真实姓名" Required="true" ShowRedStar="true" runat="server" />
                            </Items>
                        </f:FormRow>
                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtPassword" Label="密码" ShowRedStar="true" runat="server" />
                            </Items>
                            <Items>
                                <f:TextBox ID="txtPassword2" Label="确认密码" ShowRedStar="true" runat="server" CompareControl="txtPassword" />
                            </Items>
                        </f:FormRow>

                        <f:FormRow>
                            <Items>
                                <f:CheckBox runat="server" Text="是(重置密码)" Label="修改密码" ID="chk"></f:CheckBox>
                            </Items>
                            <Items>
                                <f:CheckBox runat="server" Text="启用" Label="是否启用" ID="chkFlag" Checked="true"></f:CheckBox>
                            </Items>
                        </f:FormRow>

                        <f:FormRow>
                            <Items>
                                <f:DropDownList Label="用户角色" AutoPostBack="false" Required="false" ShowRedStar="true" runat="server" ID="ddlfatherId">
                                </f:DropDownList>
                            </Items>
                            <Items>
                                <f:TriggerBox ID="txtDpt" TriggerIcon="Search" EnableEdit="false" Required="true"
                                    OnTriggerClick="txtFather_TriggerClick" runat="server" Label="所属部门">
                                </f:TriggerBox>
                            </Items>
                        </f:FormRow>

                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtTel" Label="电话" runat="server" />
                            </Items>
                            <Items>
                                <f:TextBox ID="txtAdr" Label="地址" runat="server" />
                            </Items>
                        </f:FormRow>

                        <f:FormRow runat="server">
                            <Items>
                                <f:TextArea ID="txtRemark" runat="server" Label="备注" Height="70">
                                </f:TextArea>
                            </Items>
                        </f:FormRow>
                    </Rows>
                </f:Form>
            </Items>
        </f:Panel>


        <f:Window ID="Window1" Title="组织架构" Hidden="true" EnableIFrame="true" runat="server"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="550px"
            Height="350px">
        </f:Window>

        <f:HiddenField ID="dptIdHid" runat="server">
        </f:HiddenField>
    </form>

</body>
</html>
