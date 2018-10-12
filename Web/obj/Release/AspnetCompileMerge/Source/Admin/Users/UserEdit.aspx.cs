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

namespace Maticsoft.Web.Admin.Users
{
    public partial class UserEdit : PageBase
    {
        BLL.tUsers BLL = new BLL.tUsers();
        BLL.tDepartMent BLLDPT = new BLL.tDepartMent();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();
                LoadRole();
                if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
                {
                    string userId = Request.QueryString["userId"];

                    LoadData(userId);
                    txtUsername.Readonly = true;
                }
                else
                {
                    txtUsername.Readonly = false;
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
            ddlfatherId.SelectedValue = tUsers.roleCode.ToString();
            txtRemark.Text = tUsers.usersRemark;
            dptIdHid.Text = tUsers.dptId.ToString();
            txtAdr.Text = tUsers.Address;
            txtTel.Text = tUsers.Tel;
            txtDpt.Text = BLLDPT.GetModel((int)tUsers.dptId).dptName;
            chkFlag.Checked = tUsers.Flag == 1 ? true : false;
        }

        private void LoadRole()
        {
            Maticsoft.BLL.tRole bll = new Maticsoft.BLL.tRole();
            DataTable table = bll.GetAllList().Tables[0];
            ddlfatherId.DataTextField = "rName";
            ddlfatherId.DataValueField = "rCode";
            ddlfatherId.DataSource = table;
            ddlfatherId.DataBind();
        }
        protected void txtFather_TriggerClick(object sender, EventArgs e)
        {
            string openUrl = "";
            if (!string.IsNullOrEmpty(Request.QueryString["userId"]))
            {

                string dptId = dptIdHid.Text;
                openUrl = string.Format("./userDpt.aspx?dptId={0}", HttpUtility.UrlEncode(dptId));
            }
            else
            {
                openUrl = string.Format("./userDpt.aspx");
            }
            PageContext.RegisterStartupScript(Window1.GetSaveStateReference(dptIdHid.ClientID, txtDpt.ClientID)
                    + Window1.GetShowReference(openUrl));
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
                tUsers.roleCode = Convert.ToInt32(ddlfatherId.SelectedValue);
                tUsers.usersRemark = txtRemark.Text;
                tUsers.dptId = Convert.ToInt32(dptIdHid.Text);
                tUsers.Address = txtAdr.Text;
                tUsers.Tel = txtTel.Text;
                tUsers.Flag = chkFlag.Checked == true ? 1 : 0;
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
            else
            {
                Model.tUsers tUsers = new Model.tUsers();

                tUsers.usersName = txtUsername.Text;
                tUsers.trueName = txtNickName.Text;
                tUsers.roleCode = Convert.ToInt32(ddlfatherId.SelectedValue);
                tUsers.usersRemark = txtRemark.Text;
                tUsers.dptId = Convert.ToInt32(dptIdHid.Text);
                tUsers.Address = txtAdr.Text;
                tUsers.Tel = txtTel.Text;
                tUsers.Flag = chkFlag.Checked == true ? 1 : 0;
                tUsers.usersPwd = DESEncrypt.Encrypt(this.txtPassword.Text);
                if (BLL.GetList(string.Format(" usersName='{0}'", txtUsername.Text.ToString().Trim())).Tables[0].Rows.Count > 0)
                {
                    Alert.ShowInTop("该用户名已经存在！"); return;
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