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

namespace Maticsoft.Web.Admin.PocketUser
{
    public partial class PocketUserEdit : PageBase
    {
       BLL.PocketUser BLL = new BLL.PocketUser();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();

                if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
                {
                    string userId = Request.QueryString["userId"];

                    LoadData(userId);
                    txtpocketUserPhone.Readonly = true;
                    txtpocketUserInv.Readonly = true;
                }
                else
                {
                    txtpocketUserPhone.Readonly = false;
                    txtpocketUserInv.Readonly = false;
                }

            }
        }
        protected void LoadData(string userId)
        {

            Model.PocketUser tUsers = BLL.GetModel(Convert.ToInt32(userId));
            if (tUsers == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtpocketUserName.Text = tUsers.pocketUserName;
            txtpocketUserPhone.Text = tUsers.pocketUserPhone;
            txtpocketUserInv.Text = tUsers.pocketUserInv;
            txtpocketUserAlipay.Text = tUsers.pocketUserAlipay;
            txtpocketUserReName.Text = tUsers.pocketUserReName;
            txtImg.ImageUrl =   "../../smobiler/Resources/Upload/"+ tUsers.wximg + ".jpg";
        
        }


        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
            {
                string userId = Request.QueryString["userId"];
                Model.PocketUser tUsers = BLL.GetModel(Convert.ToInt32(userId));
                if (tUsers == null) return;

                tUsers.pocketUserName= txtpocketUserName.Text;
                tUsers.pocketUserPhone = txtpocketUserPhone.Text;
                tUsers.pocketUserInv = txtpocketUserInv.Text;
                tUsers.pocketUserAlipay = txtpocketUserAlipay.Text;
                tUsers.pocketUserReName = txtpocketUserReName.Text;

                if (!ValidateMobile(txtpocketUserPhone.Text))
                {
                    Alert.ShowInTop("注册手机号错误！");return;
                }

                if (BLL.Update(tUsers) == true)
                {
                    insertLog("修改了用户：" + userId);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                }
                else
                {
                    Alert.ShowInTop("出错了！");
                }
            }
            else
            {
                Model.PocketUser tUsers = new Model.PocketUser();
                tUsers.pocketUserName = txtpocketUserName.Text;
                tUsers.pocketUserPhone = txtpocketUserPhone.Text;
                tUsers.pocketUserInv = txtpocketUserInv.Text;
                tUsers.pocketUserAlipay = txtpocketUserAlipay.Text;
                tUsers.pocketUserReName = txtpocketUserReName.Text;
                if (BLL.GetList(string.Format(" pocketUserPhone='{0}' or pocketUserInv='{1}'", txtpocketUserPhone.Text.ToString().Trim(),txtpocketUserInv.Text.ToString().Trim())).Tables[0].Rows.Count > 0)
                {
                    Alert.ShowInTop("该手机号或邀请码已经存在！"); return;
                }
                if (!ValidateMobile(txtpocketUserPhone.Text))
                {
                    Alert.ShowInTop("注册手机号错误！"); return;
                }

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