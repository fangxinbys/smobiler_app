using FineUIPro;
using Maticsoft.Common.DEncrypt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.PocketNotice
{
    public partial class PocketNoticeEdit : PageBase
    {
        BLL.PocketNotice BLL = new BLL.PocketNotice();
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();

                if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
                {
                    string userId = Request.QueryString["userId"];

                    LoadData(userId);
                }
                else
                {
                    DateTimeCh.SelectedDate = DateTime.Now;
                }

            }
        }
        protected void LoadData(string userId)
        {

            Model.PocketNotice tUsers = BLL.GetModel(Convert.ToInt32(userId));
            if (tUsers == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtTitle.Text = tUsers.noticeTitle;
            txtRemark.Text = tUsers.noticeInfo;
             
            DateTimeCh.SelectedDate = tUsers.noticeTime  ;


        }
  

        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
            {
                string userId = Request.QueryString["userId"];
                Model.PocketNotice tUsers = BLL.GetModel(Convert.ToInt32(userId));
                if (tUsers == null) return;

                tUsers.noticeTitle = txtTitle.Text;

                tUsers.noticeInfo = txtRemark.Text;
                tUsers.noticeTime = DateTimeCh.SelectedDate ;
               

                if (BLL.Update(tUsers) == true)
                {
                    insertLog("修改了通告：" + userId);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                }
                else
                {
                    Alert.ShowInTop("出错了！");
                }
            }
            else
            {
                Model.PocketNotice tUsers = new Model.PocketNotice();
                tUsers.noticeTitle = txtTitle.Text;

                tUsers.noticeInfo = txtRemark.Text;
                tUsers.noticeTime = DateTimeCh.SelectedDate ;

               
                if (BLL.Add(tUsers) >= 1)
                {

                    PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                }
                else
                {
                    Alert.ShowInTop("出错了！");
                }
            }
        }
    }
}