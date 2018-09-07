using FineUIPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.Menu
{
    public partial class MenuEdit : PageBase
    {
        BLL.tMenu BLL = new BLL.tMenu();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();
                bindtb();
                if (!string.IsNullOrEmpty(Request.QueryString["mCode"]))
                {
                    string mCode = Request.QueryString["mCode"];

                     LoadData(mCode);
                }


            }
        }
        protected void LoadData(string mCode)
        {

            Model.tMenu m = BLL.GetModel(Convert.ToInt32(mCode));
            if (m == null)
            {
                Alert.ShowInTop("出错了！"); return;

            }

            txtName.Text = m.mName;
            txtRemark.Text = m.mRemark;
            if (m.mFaherId == null)
            {
                chk.Checked = true;
            }
            else
            {
                dptFatherId.Text = m.mFaherId.ToString();
                txtFather.Text = BLL.GetModel((int)m.mFaherId).mName;
            }
            txtSort.Text = m.mSort.ToString();
            txtUrl.Text = m.mUrl; 
            drp_tb.SelectedValue = m.mIcon;
           
        }
        protected void bindtb()
        {

            foreach (Icon c in (Icon[])Enum.GetValues(typeof(Icon)))
            {

                FineUIPro.ListItem list = new FineUIPro.ListItem();
                list.Text = c.ToString();
                list.Value = c.ToString();
                drp_tb.Items.Add(list);
            }
        }
        protected void txtFather_TriggerClick(object sender, EventArgs e)
        {
            string openUrl = "";
            if (!string.IsNullOrEmpty(Request.QueryString["mCode"]))
            {
                string mCode = Request.QueryString["mCode"];
                openUrl = string.Format("./selectMenu.aspx?mCode={0}", HttpUtility.UrlEncode(mCode));
            }
            else
            {
                openUrl = string.Format("./selectMenu.aspx");
            }
            PageContext.RegisterStartupScript(Window1.GetSaveStateReference(dptFatherId.ClientID,txtFather.ClientID )
                    + Window1.GetShowReference(openUrl));
        }

        protected void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["mCode"]))
            {
                string mCode = Request.QueryString["mCode"];
                Model.tMenu m = BLL.GetModel(Convert.ToInt32(mCode));
                if (m == null) return;

                m.mName = txtName.Text.Trim();
                m.mRemark = txtRemark.Text.Trim();

                if (chk.Checked)
                {
                    m.mFaherId =null;
                } 
                else 
                {
                    if (string.IsNullOrEmpty(dptFatherId.Text))
                    {
                        Alert.ShowInTop("请设置上级菜单！"); return;
                    }
                    m.mFaherId = Convert.ToInt32(dptFatherId.Text);
                }
           
                m.mIcon = drp_tb.SelectedValue;
                m.mSort =Convert.ToInt32(txtSort.Text);
                m.mUrl = txtUrl.Text;


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
                Model.tMenu m = new Model.tMenu();
                m.mName = txtName.Text.Trim();
                m.mRemark = txtRemark.Text.Trim();
                if (chk.Checked)
                {
                    m.mFaherId = null;
                }
                else
                {
                    if (string.IsNullOrEmpty(dptFatherId.Text))
                    {
                        Alert.ShowInTop("请设置上级菜单！"); return;
                    }
                    m.mFaherId = Convert.ToInt32(dptFatherId.Text);
                }
                m.mIcon = drp_tb.SelectedValue;
                m.mSort = Convert.ToInt32(txtSort.Text);
                m.mUrl = txtUrl.Text;
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