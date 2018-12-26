using FineUIPro;
using System;
using System.Web;
using Web;

namespace Maticsoft.Web.Admin.Indexs
{
    public partial class IndexEdit : PageBase
    {
        BLL.t_Index BLL = new BLL.t_Index();
      
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

            Model.t_Index m = BLL.GetModel(Convert.ToInt32(dptId));
            if (m == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtDptName.Text = m.Name;
         
            dptFatherId.Text = m.FatherId.ToString();

            txtFather.Text = BLL.GetModel((int)m.FatherId).Name;
        }

        protected void txtFather_TriggerClick(object sender, EventArgs e)
        {
            string openUrl = "";
            if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
            {
                string dptId = Request.QueryString["dptId"];
                openUrl = string.Format("./selectIndex.aspx?dptId={0}", HttpUtility.UrlEncode(dptId));
            }
            else
            {
                openUrl = string.Format("./selectIndex.aspx");
            }
            PageContext.RegisterStartupScript(Window1.GetSaveStateReference(dptFatherId.ClientID,txtFather.ClientID )
                    + Window1.GetShowReference(openUrl));
        }

        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
            {
                string dptId = Request.QueryString["dptId"];
                Model.t_Index m = BLL.GetModel(Convert.ToInt32(dptId));
                if (m == null) return;

                m.Name = txtDptName.Text.Trim();

                m.FatherId =Convert.ToInt32(dptFatherId.Text);



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
                Model.t_Index m = new Model.t_Index();
                m.Name = txtDptName.Text.Trim();
                m.FatherId = Convert.ToInt32(dptFatherId.Text);
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