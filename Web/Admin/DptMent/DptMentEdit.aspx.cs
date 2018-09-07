using FineUIPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.DptMent
{
    public partial class DptMentEdit : PageBase
    {
        BLL.tDepartMent BLL = new BLL.tDepartMent();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();
             
                if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
                {
                    string dptId = Request.QueryString["dptId"];

                    LoadData(dptId);
                }


            }
        }
        protected void LoadData(string dptId)
        {

            Model.tDepartMent m = BLL.GetModel(Convert.ToInt32(dptId));
            if (m == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtDptName.Text = m.dptName;
            txtRemark.Text = m.dptRemark;
            dptFatherId.Text = m.dptFatherId.ToString();

            txtFather.Text = BLL.GetModel((int)m.dptFatherId).dptName;
        }

        protected void txtFather_TriggerClick(object sender, EventArgs e)
        {
            string openUrl = "";
            if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
            {
                string dptId = Request.QueryString["dptId"];
                openUrl = string.Format("./selectDpt.aspx?dptId={0}", HttpUtility.UrlEncode(dptId));
            }
            else
            {
                openUrl = string.Format("./selectDpt.aspx");
            }
            PageContext.RegisterStartupScript(Window1.GetSaveStateReference(dptFatherId.ClientID,txtFather.ClientID )
                    + Window1.GetShowReference(openUrl));
        }

        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
            {
                string dptId = Request.QueryString["dptId"];
                Model.tDepartMent m = BLL.GetModel(Convert.ToInt32(dptId));
                if (m == null) return;

                m.dptName = txtDptName.Text.Trim();
                m.dptRemark = txtRemark.Text.Trim();
                m.dptFatherId =Convert.ToInt32(dptFatherId.Text);



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
                Model.tDepartMent m = new Model.tDepartMent();
                m.dptName = txtDptName.Text.Trim();
                m.dptRemark = txtRemark.Text.Trim();
                m.dptFatherId = Convert.ToInt32(dptFatherId.Text);
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