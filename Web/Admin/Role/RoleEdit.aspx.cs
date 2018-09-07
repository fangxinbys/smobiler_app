using FineUIPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.Role
{
    public partial class RoleEdit : PageBase
    {
        BLL.tRole BLL = new BLL.tRole();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();

                if (!string.IsNullOrEmpty(Request.QueryString["roleId"]))
                {
                    string roleId = Request.QueryString["roleId"];

                    LoadData(roleId);
                }


            }
        }
        protected void LoadData(string roleId)
        {

            Model.tRole m = BLL.GetModel(Convert.ToInt32(roleId));
            if (m == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtRoleName.Text = m.rName;
            txtRemark.Text = m.rRemark;
 
        }

      

        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["roleId"]))
            {
                string roleId = Request.QueryString["roleId"];
                Model.tRole m = BLL.GetModel(Convert.ToInt32(roleId));
                if (m == null) return;

                m.rName = txtRoleName.Text.Trim();
                m.rRemark = txtRemark.Text.Trim();
           



                if (BLL.Update(m) == true)
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
                Model.tRole m = new Model.tRole();
                m.rName = txtRoleName.Text.Trim();
                m.rRemark = txtRemark.Text.Trim();
           
                if (BLL.Add(m) >= 1)
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