<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PocketUserEdit.aspx.cs" Inherits="Maticsoft.Web.Admin.PocketUser.PocketUserEdit" %>

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
                                <f:TextBox ID="txtpocketUserName" Label="用户名" Required="true" ShowRedStar="true" runat="server" />
                            </Items>

                        </f:FormRow>
                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtpocketUserPhone" Label="注册手机" Required="true" ShowRedStar="true" runat="server" />
                            </Items>

                        </f:FormRow>
                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtpocketUserInv" Label="邀请码" Required="true" ShowRedStar="true" runat="server" />
                            </Items>

                        </f:FormRow>
                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtpocketUserAlipay" Label="支付宝" Required="true" ShowRedStar="true" runat="server" />
                            </Items>

                        </f:FormRow>

                        <f:FormRow>
                            <Items>
                                <f:TextBox ID="txtpocketUserReName" Label="真实姓名" Required="true" ShowRedStar="true" runat="server" />
                            </Items>

                        </f:FormRow>


                    </Rows>
                </f:Form>
            </Items>
        </f:Panel>


    </form>

</body>
</html>
