<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Maticsoft.Web.Admin.Main" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title><%=(model==null?"":model.WebName) %></title>
    <link href="~/res/css/index.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server"></f:PageManager>
        <f:Panel ID="Panel1" Layout="Region" CssClass="mainpanel" ShowBorder="false" ShowHeader="false" runat="server">
            <Items>
                <f:ContentPanel ID="topPanel" CssClass="topregion bgpanel" RegionPosition="Top" ShowBorder="false" ShowHeader="false" EnableCollapse="true" runat="server">
                    <div id="header" class="f-widget-header f-mainheader">
                        <table>
                            <tr>
                                <td>
                                    <%--
                                         <f:Button runat="server" CssClass="icononlyaction" ID="btnHomePage" IconAlign="Top" IconFont="_Home"
                                          EnablePostBack="false" EnableDefaultState="false" EnableDefaultCorner="false">
                                         </f:Button>
                                    --%>
                                    <img src="../res/images/my_logo.png" class="img" />
                                    <a class="logo" href="./Main.aspx"><%=(model==null?"":model.WebName) %>
                                    </a>
                                </td>
                                <td style="text-align: right;">
                                    <f:Button runat="server" CssClass="icontopaction themes" ID="btnThemeSelect" Text="界面风格" IconAlign="Top" IconFont="_Skin"
                                        EnablePostBack="false" EnableDefaultState="false" EnableDefaultCorner="false">
                                        <Listeners>
                                            <f:Listener Event="click" Handler="onThemeSelectClick" />
                                        </Listeners>
                                    </f:Button>
                                    <f:Button runat="server" CssClass="userpicaction" IconUrl="~/res/images/my_face_80.jpg" IconAlign="Left" ID="btnUserName"
                                        EnablePostBack="false" EnableDefaultState="false" EnableDefaultCorner="false">
                                        <Menu runat="server">
                                            <f:MenuHyperLink Text="浏览首页" NavigateUrl="/index.aspx" Target="_blank" runat="server" Icon="Webcam"></f:MenuHyperLink>
                                            <f:MenuButton Text="个人信息" IconFont="_User" runat="server" ID="txtUserInfo" OnClick="txtUserInfo_Click">
                                            </f:MenuButton>
                                            <f:MenuSeparator runat="server"></f:MenuSeparator>
                                            <f:MenuButton Text="安全退出" IconFont="_SignOut" runat="server" OnClick="btnExit_Click" ConfirmText="您确定退出系统吗?" ID="btnExit">
                                            </f:MenuButton>
                                        </Menu>
                                    </f:Button>
                                </td>
                            </tr>
                        </table>
                    </div>
                </f:ContentPanel>
                <f:Panel ID="leftPanel" CssClass="leftregion bgpanel" Width="220px" ShowHeader="false"
                    EnableCollapse="true" Layout="Fit" RegionPosition="Left"
                    RegionSplit="true" RegionSplitWidth="3" RegionSplitIcon="false" runat="server">
                    <Items>
                        <f:Tree runat="server" ShowBorder="false" ShowHeader="false" ID="treeMenu" EnableSingleClickExpand="true">
                        </f:Tree>
                    </Items>
                </f:Panel>
                <f:Panel ID="mainPanel" CssClass="centerregion" ShowHeader="false" Layout="Fit" RegionPosition="Center" runat="server">
                    <Items>
                        <f:TabStrip ID="mainTabStrip" EnableTabCloseMenu="true" ShowBorder="false" runat="server" ShowInkBar="true">
                            <Tabs>
                                <f:Tab ID="Tab1" Title="首页" BodyPadding="10px" AutoScroll="true" Icon="House" runat="server">
                                    <Content>
                                    </Content>
                                </f:Tab>
                            </Tabs>
                        </f:TabStrip>
                    </Items>
                </f:Panel>
            </Items>
        </f:Panel>

        <f:Window ID="windowThemeRoller" Title="主题仓库" Hidden="true" EnableIFrame="true" IFrameUrl="../common/themes.aspx" ClearIFrameAfterClose="false"
            runat="server" IsModal="true" Width="1020px" Height="600px" EnableClose="true"
            EnableMaximize="true" EnableResize="true">
        </f:Window>


        <f:Window ID="Window1" Hidden="true" EnableIFrame="true" runat="server" OnClose="Window1_Close"
            EnableMaximize="true" EnableResize="true" Target="Top" IsModal="True" Width="600px" Title="个人信息"
            Height="280px">
        </f:Window>
    </form>

    <script>
        var treeMenuClientID = '<%= treeMenu.ClientID %>';
        var mainTabStripClientID = '<%= mainTabStrip.ClientID %>';
        var windowThemeRollerClientID = '<%= windowThemeRoller.ClientID %>';

        // 点击主题仓库
        function onThemeSelectClick(event) {
            F(windowThemeRollerClientID).show();
        }




        // 页面控件初始化完毕后执行
        F.ready(function () {


            var treeMenu = F(treeMenuClientID);
            var mainTabStrip = F(mainTabStripClientID);
            if (!treeMenu) return;

            // 初始化主框架中的树(或者Accordion+Tree)和选项卡互动，以及地址栏的更新
            // treeMenu： 主框架中的树控件实例，或者内嵌树控件的手风琴控件实例
            // mainTabStrip： 选项卡实例
            // updateHash: 切换Tab时，是否更新地址栏Hash值（默认值：true）
            // refreshWhenExist： 添加选项卡时，如果选项卡已经存在，是否刷新内部IFrame（默认值：false）
            // refreshWhenTabChange: 切换选项卡时，是否刷新内部IFrame（默认值：false）
            // maxTabCount: 最大允许打开的选项卡数量
            // maxTabMessage: 超过最大允许打开选项卡数量时的提示信息
            F.initTreeTabStrip(treeMenu, mainTabStrip, {
                maxTabCount: 10,
                updateHash: false,
                refreshWhenTabChange: true,
                maxTabMessage: '请先关闭一些选项卡（最多允许打开 10 个）！'
            });
            time();
        });
    </script>
    <script>

        function alertAndRedirect(message, redirectUrl) {
            F.alert({
                message: message,
                ok: function () {
                    window.location.href = redirectUrl;
                }
            });
        }

    </script>

    <script>

        function time() {

            $.ajax({
                type: "post",
                async: "false",
                url: "Main.aspx/CheckLogin",
                contentType: "application/json; charset=utf-8",
                success: function (msg) {
                    if (msg == "loginErr") {
                        window.location.href = "Login.aspx";
                    }
                },
                error: function (err) {
                    window.location.href = "Login.aspx";
                }
            });
            setTimeout(time, 60000);
        }
    </script>

</body>
</html>

