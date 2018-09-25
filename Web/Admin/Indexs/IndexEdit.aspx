<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexEdit.aspx.cs" Inherits="Maticsoft.Web.Admin.Indexs.IndexEdit" %>

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
                <f:Toolbar ID="toolbar" runat="server" ToolbarAlign="Right" Position="Bottom" >
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
                                <f:TextBox ID="txtDptName" runat="server" Label="名称" Required="true" ShowRedStar="true">
                                </f:TextBox>

                            </Items>
                        </f:FormRow>

                        <f:FormRow runat="server">
                            <Items>
                                <f:TriggerBox ID="txtFather" TriggerIcon="Search" EnableEdit="false" Required="true"
                                    OnTriggerClick="txtFather_TriggerClick" runat="server" Label="上级指标">
                                </f:TriggerBox>
                            </Items>
                        </f:FormRow>


                        
                    </Rows>
                </f:Form>
            </Items>
        </f:Panel>


        <f:Window ID="Window1" Title="指标列表" Hidden="true" EnableIFrame="true" runat="server"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="550px"
            Height="350px">
        </f:Window>

        <f:HiddenField ID="dptFatherId" runat="server">
        </f:HiddenField>
    </form>

</body>
</html>
