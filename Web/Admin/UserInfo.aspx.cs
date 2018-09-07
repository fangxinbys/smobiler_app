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

namespace Maticsoft.Web.Admin
{
    public partial class UserInfo : PageBase
    {
        BLL.tUsers BLL = new BLL.tUsers();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();

                if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
                {
                    string userId = Request.QueryString["userId"];

                    LoadData(userId);
                    txtUsername.Readonly = true;
                }


            }
        }
        protected void LoadData(string userId)
        {

            Model.tUsers tUsers = BLL.GetModel(Convert.ToInt32(userId));
            if (tUsers == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtUsername.Text = tUsers.usersName;
            txtNickName.Text = tUsers.trueName;

            txtAdr.Text = tUsers.Address;
            txtTel.Text = tUsers.Tel;

        }


        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
            {
                string userId = Request.QueryString["userId"];
                Model.tUsers tUsers = BLL.GetModel(Convert.ToInt32(userId));
                if (tUsers == null) return;

                tUsers.usersName = txtUsername.Text;
                tUsers.trueName = txtNickName.Text;

                tUsers.Address = txtAdr.Text;
                tUsers.Tel = txtTel.Text;

                if (chk.Checked)
                {
                    if (this.txtPassword.Text.Trim() == "")
                    {
                        Alert.ShowInTop("请输入重置密码！");
                        return;
                    }
                    if (this.txtPassword.Text.Trim() != this.txtPassword2.Text.Trim())
                    {
                        Alert.ShowInTop("两次输入密码不一致！");
                        return;
                    }
                    tUsers.usersPwd = DESEncrypt.Encrypt(this.txtPassword.Text);
                }
                if (BLL.Update(tUsers) == true)
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