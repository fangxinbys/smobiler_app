<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PocketTaskEdit.aspx.cs" Inherits="Maticsoft.Web.Admin.PocketTask.PocketTaskEdit" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <style>
        .photo img {
            height: 160px;
            width: 250px;
            border: 1px solid #eee;
        }
    </style>
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
                        <f:Button ID="btnSave" ValidateForms="SimpleForm1" EnablePostBack="true" Text="保存" runat="server" Icon="SystemSave" OnClick="btnSave_Click">
                        </f:Button>
                    </Items>
                </f:Toolbar>
            </Toolbars>
            <Rows>

                <f:FormRow>
                    <Items>

                        <f:Image ID="imgPhoto" CssClass="photo" ImageUrl="../../upload/blank.png" ShowEmptyLabel="true" runat="server" Label="封面图片">
                        </f:Image>

                    </Items>
                    <Items>
                        <f:FileUpload runat="server" ID="filePhoto" ButtonText="上传封面图片" ButtonOnly="true"
                            AutoPostBack="true" CssStyle="margin-top:130px;text-aligin:left" OnFileSelected="filePhoto_FileSelected">
                        </f:FileUpload>
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:TextBox ID="txtTile" Label="任务标题" Required="true" ShowRedStar="true" runat="server" MaxLength="300" />

                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:DatePicker runat="server" DateFormatString="yyyy-MM-dd" Label="发布时间" EmptyText="请选择日期"
                            ID="DateTimeCh" Required="true" ShowRedStar="true">
                        </f:DatePicker>
                    </Items>

                </f:FormRow>


                <f:FormRow>

                    <Items>
                        <f:NumberBox runat="server" ID="txtNum" Label="任务数量" Text="0" Required="true" ShowRedStar="true"></f:NumberBox>
                    </Items>
                </f:FormRow>
                <f:FormRow>

                    <Items>
                        <f:NumberBox runat="server" ID="txtMoney" Label="任务单价" Text="0" Required="true" ShowRedStar="true"></f:NumberBox>
                    </Items>
                </f:FormRow>
                <f:FormRow>
                    <Items>
                        <f:ContentPanel runat="server" ID="contentpan" ShowBorder="false">
                            <textarea name="editor1" id="editor1">  </textarea>
                        </f:ContentPanel>
                    </Items>
                </f:FormRow>

            </Rows>

        </f:Form>

        <f:HiddenField runat="server" ID="hfEditorInitValue"></f:HiddenField>
    </form>
    <script type="text/javascript" src="../../ueditor/ueditor.config.js"></script>
    <script type="text/javascript" src="../../ueditor/ueditor.all.js"></script>
    <script type="text/javascript">


        var hfEditorInitValueClientID = '<%= hfEditorInitValue.ClientID %>';
        var editor;
        F.ready(function () {
            editor = UE.getEditor('editor1', {
                initialFrameWidth: '100%',
                initialFrameHeight: '200',
                autoHeightEnabled: false,
                autoFloatEnabled: false,
                focus: false,
                onready: function () {
                    var editorInitValue = F('hfEditorInitValue').getValue();
                    if (editorInitValue) {
                        this.setContent(editorInitValue);
                    }

                }
            });

        });


        function updateEditor(content) {
            if (editor && editor.isReady) {
                editor.setContent(content);
            }
        }

    </script>
</body>
</html>
