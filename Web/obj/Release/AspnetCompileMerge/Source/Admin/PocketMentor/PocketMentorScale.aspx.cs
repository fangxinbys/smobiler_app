using FineUIPro;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.PocketMentor
{
    public partial class PocketMentorScale : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
            if (!IsPostBack)
            {
                Maticsoft.BLL.pocketSet bll = new Maticsoft.BLL.pocketSet();
                Maticsoft.Model.pocketSet model_1 = bll.GetModel(1);
                Maticsoft.Model.pocketSet model_2 = bll.GetModel(2);
                if (model_1 != null)
                {
                    txtSf.Text = model_1.setMoney.ToString();
                }
                if (model_2 != null)
                {
                    txtTd.Text = model_2.setMoney.ToString();
                }
            }

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.pocketSet bll = new Maticsoft.BLL.pocketSet();
            Maticsoft.Model.pocketSet model_1 = bll.GetModel(1);
            Maticsoft.Model.pocketSet model_2 = bll.GetModel(2);
            if (model_1 == null || model_2 == null)
            {
                return;
            }

            else
            {
                model_1.setMoney = decimal.Parse(txtSf.Text);
                model_2.setMoney = decimal.Parse(txtTd.Text);

                if (bll.Update(model_1) && bll.Update(model_2))
                {
                    Alert.ShowInTop("保存成功！");
                }
                else
                {
                    Alert.ShowInTop("保存失败！");
                }

            }
        }
    }
}