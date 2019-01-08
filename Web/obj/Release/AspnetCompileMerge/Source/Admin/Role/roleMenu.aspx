<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="roleMenu.aspx.cs" Inherits="Maticsoft.Web.Admin.Role.roleMenu" %>

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

                <f:Panel runat="server" ID="panelLeftRegion" RegionPosition="Center" RegionSplit="true" EnableCollapse="true" ShowBorder="false" RegionPercent="60%"
                    ShowHeader="false" IconFont="_PullLeft" AutoScroll="true">
                    <Toolbars>
                        <f:Toolbar ID="Toolbar2" runat="server" ToolbarAlign="Left" Position="Top">
                            <Items>
                                <f:Button ID="btnClose" EnablePostBack="false" Text=" 取消 " runat="server" Icon="SystemClose">
                                </f:Button>
                                <f:Button ID="btnSave" ValidateForms="SimpleForm1" Text=" 保存 " runat="server" Icon="SystemSave" OnClick="btnSave_Click">
                                </f:Button>

                            </Items>
                        </f:Toolbar>
                    </Toolbars>
                    <Items>
                        <f:Tree ID="TreeDpt" IsFluid="true" CssClass="blockpanel" ShowHeader="false" EnableMultiSelect="true" OnNodeCheck="TreeDpt_NodeCheck"
                            EnableCollapse="false" runat="server" EnableCheckBox="true">
                        </f:Tree>
                    </Items>
                </f:Panel>
            </Items>
        </f:Panel>
    </form>
</body>
</html>
