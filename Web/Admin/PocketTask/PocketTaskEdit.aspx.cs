using FineUIPro;
 
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.PocketTask
{
    public partial class PocketTaskEdit : PageBase
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();

                DateTimeCh.SelectedDate = DateTime.Now;

                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {

                    Maticsoft.BLL.PocketTask bll = new Maticsoft.BLL.PocketTask();
                    Maticsoft.Model.PocketTask model = bll.GetModel(int.Parse(Request.QueryString["Id"]));
                    imgPhoto.ImageUrl = model.pocketFengMian;
                    txtTile.Text = model.pocketTaskInfo;
                    txtNum.Text = model.pocketTaskNum.ToString();
                    txtMoney.Text = model.pocketTaskMoney.ToString();
                    DateTimeCh.SelectedDate = model.pocketTime;
                    hfEditorInitValue.Text = model.pocketTaskRule;
                }
            }
        }



        protected void filePhoto_FileSelected(object sender, EventArgs e)
        {
            if (filePhoto.HasFile)
            {
                string fileName = filePhoto.ShortFileName;
                string type = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower();    //获取文件类型  
                if (type == "jpg" || type == "gif" || type == "bmp" || type == "png")
                {

                    fileName = DateTime.Now.Ticks.ToString() + "." + type;

                    filePhoto.SaveAs(Server.MapPath("~/upload/" + fileName));

                    imgPhoto.ImageUrl = "~/upload/" + fileName;
                    filePhoto.Reset();
                }


                else
                {
                    Alert.ShowInTop("无效的文件类型！");
                    return;
                }
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.PocketTask bll = new Maticsoft.BLL.PocketTask();
            if (imgPhoto.ImageUrl == "")
            {
                filePhoto.MarkInvalid("请先上传封面图片！");

                Alert.ShowInTop("请先上传封面图片！");
                return;
            }
            if (DateTimeCh.SelectedDate == null)
            {
                DateTimeCh.SelectedDate = DateTime.Now;
            }
            string content = Request.Form["editor1"] == null ? "" : Request.Form["editor1"];

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {

                Maticsoft.Model.PocketTask model = bll.GetModel(int.Parse(Request.QueryString["Id"]));
                if (imgPhoto.ImageUrl != model.pocketFengMian)
                {
                    if (!string.IsNullOrEmpty(model.pocketFengMian) && (model.pocketFengMian != "../../upload/blank.png"))
                    {
                        string directoryPath = Server.MapPath(model.pocketFengMian);
                        File.Delete(directoryPath);
                        //删除掉原来的图片
                    }
                }
                model.pocketFengMian = imgPhoto.ImageUrl;
                model.pocketTaskInfo = txtTile.Text;
                model.pocketTaskNum = int.Parse(txtNum.Text);
                model.pocketTaskMoney = decimal.Parse(txtMoney.Text);
                model.pocketTime = DateTimeCh.SelectedDate;
                model.pocketTaskRule = content;
                bll.Update(model);
                PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
            }
            else
            {
                Maticsoft.Model.PocketTask model = new Maticsoft.Model.PocketTask();
                model.pocketFengMian = imgPhoto.ImageUrl;
                model.pocketTaskInfo = txtTile.Text;
                model.pocketTaskNum = int.Parse(txtNum.Text);
                model.pocketTaskMoney = decimal.Parse(txtMoney.Text);
                model.pocketTime = DateTimeCh.SelectedDate;
                model.pocketTaskRule = content;
                int k = bll.Add(model); 

                if (k > 0)
                {
                    PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                }

            }
        }
    }
}