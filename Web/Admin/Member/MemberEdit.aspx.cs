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

namespace Maticsoft.Web.Admin.Member
{
    public partial class MemberEdit : PageBase
    {
        BLL.Uvip BLL = new BLL.Uvip();
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();
      
                if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
                {
                    string userId = Request.QueryString["userId"];

                    LoadData(userId);
                    txtCode.Readonly = true;
                }
                else
                {
                    txtCode.Readonly = false;
                }

            }
        }
        protected void LoadData(string userId)
        {

            Model.Uvip tUsers = BLL.GetModel(Convert.ToInt32(userId));
            if (tUsers == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtUsername.Text = tUsers.Uname;
            txtCode.Text = tUsers.Ucode;
            txtAdr.Text = tUsers.Uads;
            txtTel.Text = tUsers.Utel;
            ddlfatherId.SelectedValue = tUsers.Usex;
            txtWx.Text = tUsers.Uwx;
            txtCname.Text = tUsers.UchName;
            DateTimeCh.SelectedDate = tUsers.UbirTime;


        }
  

        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
            {
                string userId = Request.QueryString["userId"];
                Model.Uvip tUsers = BLL.GetModel(Convert.ToInt32(userId));
                if (tUsers == null) return;

                tUsers.Uname = txtUsername.Text;

                tUsers.Uads = txtAdr.Text;
                tUsers.Utel = txtTel.Text;
                tUsers.Usex = ddlfatherId.SelectedValue;
                tUsers.Uwx = txtWx.Text;
                tUsers.UchName = txtCname.Text;
                tUsers.UbirTime = DateTimeCh.SelectedDate;

                if (BLL.Update(tUsers) == true)
                {
                    insertLog("修改了会员：" + userId);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                }
                else
                {
                    Alert.ShowInTop("出错了！");
                }
            }
            else
            {
                Model.Uvip tUsers = new Model.Uvip();
                tUsers.Uwx = txtWx.Text;
                tUsers.UchName = txtCname.Text;
                tUsers.UbirTime = DateTimeCh.SelectedDate;
                tUsers.Uname = txtUsername.Text;
                tUsers.Ucode = txtCode.Text;
                tUsers.Uads = txtAdr.Text;
                tUsers.Utel = txtTel.Text;
                tUsers.Usex = ddlfatherId.SelectedValue;

                if (BLL.GetList(string.Format(" Ucode='{0}'", txtCode.Text.ToString().Trim())).Tables[0].Rows.Count > 0)
                {
                    Alert.ShowInTop("该卡号已经存在！"); return;
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