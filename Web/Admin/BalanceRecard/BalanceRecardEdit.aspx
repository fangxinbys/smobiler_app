<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BalanceRecardEdit.aspx.cs" Inherits="Maticsoft.Web.Admin.BalanceRecard.BalanceRecardEdit" ValidateRequest="false" %>

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
                <f:Toolbar ID="Toolbar2" runat="server" ToolbarAlign="right" Position="Bottom">
                    <Items>

                        <f:Button ID="btnClose" EnablePostBack="false" Text="取消" runat="server" Icon="SystemClose">
                        </f:Button>
                        <f:Button ID="btnSave" ValidateForms="SimpleForm1" EnablePostBack="true" Text="确定操作" runat="server" Icon="SystemSave" OnClick="btnSave_Click">
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
            <Rows>


                <f:FormRow>
                    <Items>
                        <f:TextBox ID="txtUser" Label="提现用户" Required="true" ShowRedStar="true" runat="server" Readonly="true" />
                    </Items>
                </f:FormRow>

                <f:FormRow>
                    <Items>
                        <f:TextBox ID="txtZfb" Label="支付宝号" Required="true" ShowRedStar="true" runat="server" Readonly="true" />
                    </Items>
                </f:FormRow>

                <f:FormRow>
                    <Items>
                        <f:TextBox ID="txtRname" Label="提现姓名" Required="true" ShowRedStar="true" runat="server" Readonly="true" />
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="txtJe" Label="提现金额" Required="true" ShowRedStar="true" runat="server" Readonly="true" />
                    </Items>

                </f:FormRow>


                <f:FormRow>

                    <Items>
                        <f:RadioButtonList ID="CheckTask" Label="审核操作" runat="server" Required="true" ShowRedStar="true">
                            <f:RadioItem Text="通过" Value="通过" />
                            <f:RadioItem Text="驳回" Value="驳回" />
                        </f:RadioButtonList>

                    </Items>
                </f:FormRow>
                <f:FormRow runat="server">
                    <Items>
                        <f:TextArea ID="txtRemark" runat="server" Label="审核说明" Required="true" ShowRedStar="true">
                        </f:TextArea>
                    </Items>
                </f:FormRow>


            </Rows>

        </f:Form>

    </form>
</body>
</html>
