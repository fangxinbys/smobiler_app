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

namespace Maticsoft.Web.Admin.PocketGg
{
    public partial class PocketGgEdit : PageBase
    {
        BLL.PocketHelp BLL = new BLL.PocketHelp();
 
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
                

            }
        }
        protected void LoadData(string userId)
        {

            Model.PocketHelp tUsers = BLL.GetModel(Convert.ToInt32(userId));
            if (tUsers == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtTitle.Text = tUsers.helpTitle;
            txtRemark.Text = tUsers.helpInfo;
              


        }
  

        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
            {
                string userId = Request.QueryString["userId"];
                Model.PocketHelp tUsers = BLL.GetModel(Convert.ToInt32(userId));
                if (tUsers == null) return;

                tUsers.helpTitle = txtTitle.Text;

                tUsers.helpInfo = txtRemark.Text; 
               

                if (BLL.Update(tUsers) == true)
                {
                    insertLog("修改了帮助信息：" + userId);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                }
                else
                {
                    Alert.ShowInTop("出错了！");
                }
            }
            else
            {
                Model.PocketHelp tUsers = new Model.PocketHelp();
                tUsers.helpTitle = txtTitle.Text;

                tUsers.helpInfo = txtRemark.Text;

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