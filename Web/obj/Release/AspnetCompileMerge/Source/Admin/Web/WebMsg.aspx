<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMsg.aspx.cs" Inherits="Maticsoft.Web.Admin.Web.WebMsg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="SimpleForm1" runat="server" />
        <f:Form ID="SimpleForm1" ShowBorder="false" ShowHeader="false" AutoScroll="true" BodyPadding="10px" runat="server">

            <Toolbars>
                <f:Toolbar ID="Toolbar2" runat="server" ToolbarAlign="Right" Position="Bottom">
                    <Items>

                        <f:Button ID="btnSave" ValidateForms="SimpleForm1" EnablePostBack="true" Text="保存配置" runat="server" Icon="SystemSave" OnClick="btnSave_Click">
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
            <Rows>

                <f:FormRow>
                    <Items>
                        <f:TextBox ID="WebName" Label="站点名称" runat="server" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="KeyWords" Label=" 关 键 字 " runat="server" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="Description" Label="站点描述" runat="server" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="Copyright" Label="版权信息" runat="server" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="Tel" Label="联系方式" runat="server" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="Email" Label="邮箱信息" runat="server" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="Address" Label="地址信息" runat="server" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="BeiAn" Label="备案编号" runat="server" />
                    </Items>
                </f:FormRow>
            </Rows>

        </f:Form>

    </form>

</body>
</html>
