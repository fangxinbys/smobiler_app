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
                        <f:NumberBox ID="txtSf" Label="拜师师傅赏金" Required="true"   runat="server" EmptyText="请输入数字" Text="0" LabelWidth="200" />
                                                                                      
                    </Items>                                                          
                </f:FormRow>                                                          
                <f:FormRow>                                                           
                    <Items>                                                           
                        <f:NumberBox ID="txtTd" Label="拜师徒弟赏金" Required="true"   runat="server" EmptyText="请输入数字" Text="0" LabelWidth="200"/>
                                                                                      
                    </Items>                                                          
                </f:FormRow>                                                          
                <f:FormRow>                                                           
                    <Items>                                                           
                        <f:NumberBox ID="txtTx" Label="会员提现限额" Required="true"   runat="server" EmptyText="请输入数字" Text="10" LabelWidth="200"/>
                                                                                      
                    </Items>                                                          
                </f:FormRow>                                                          
                <f:FormRow>                                                           
                    <Items>                                                           
                        <f:NumberBox ID="txtBl" Label="上级抽成比例" Required="true"   runat="server" EmptyText="请输入数字" Text="10" LabelWidth="200"/>
                                                                                      
                    </Items>
                </f:FormRow>
            </Rows>

        </f:Form>

    </form>

</body>
</html>
