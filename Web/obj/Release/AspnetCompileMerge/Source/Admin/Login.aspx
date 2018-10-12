<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="Maticsoft.Web.Admin.login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录</title>
    <link href="res/css/common.css" rel="stylesheet" />
    <style>
        .imgcaptcha .f-field-label {
            margin: 0;
        }
    </style>
</head>
 
<body style="background-image:url('../res/images/lg.jpg')">
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" runat="server" />
     
        <f:Window ID="Window1" runat="server"  IsModal="false" EnableClose="false" 
            WindowPosition="GoldenSection" Width="450px">
            <Items>
                <f:SimpleForm ID="SimpleForm1" runat="server" ShowBorder="false" BodyPadding="10px" LabelWidth="80px" ShowHeader="false">
                    <Items>
                        <f:TextBox ID="tbxUserName" Label="用户名" Required="true" runat="server">
                        </f:TextBox>
                        <f:TextBox ID="tbxPassword" Label="密码" TextMode="Password" Required="true" runat="server">
                        </f:TextBox>
                        <f:Panel ID="Panel1" ShowBorder="false" ShowHeader="false" Layout="HBox" BoxConfigAlign="Stretch" runat="server">
                            <Items>
                                <f:TextBox ID="tbxCaptcha" BoxFlex="1" Margin="0 5px 0 0" Label="验证码" Required="true" runat="server">
                                </f:TextBox>
                                <f:LinkButton ID="imgCaptcha" CssClass="imgcaptcha" Width="100px" EncodeText="false" runat="server" OnClick="imgCaptcha_Click">
                                </f:LinkButton>
                            </Items>
                        </f:Panel>
                    </Items>
                </f:SimpleForm>
            </Items>
            <Toolbars>
                <f:Toolbar ID="Toolbar1" runat="server" Position="Bottom" ToolbarAlign="Right">
                    <Items>
                        <f:Button ID="btnLogin" Text="登录" Type="Submit" ValidateForms="SimpleForm1" ValidateTarget="Top"
                            runat="server" OnClick="btnLogin_Click">
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
        </f:Window>
    </form>
</body>
</html>
