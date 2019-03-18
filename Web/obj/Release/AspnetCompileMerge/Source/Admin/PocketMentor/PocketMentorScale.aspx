<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PocketMentorScale.aspx.cs" Inherits="Maticsoft.Web.Admin.PocketMentor.PocketMentorScale" %>

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
                        <f:NumberBox ID="txtSf" Label="师傅赏金" Required="true" ShowRedStar="true" runat="server" EmptyText="请输入数字" Text="4" />

                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:NumberBox ID="txtTd" Label="徒弟赏金" Required="true" ShowRedStar="true" runat="server" EmptyText="请输入数字" Text="3" />

                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:NumberBox ID="txtTx" Label="提现限额" Required="true" ShowRedStar="true" runat="server" EmptyText="请输入数字" Text="10" />

                    </Items>
                </f:FormRow>
            </Rows>

        </f:Form>

    </form>

</body>
</html>
