using FineUIPro;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.Web
{
    public partial class WebMsg :PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
            if (!IsPostBack)
            {
                Maticsoft.BLL.tSet bll = new Maticsoft.BLL.tSet();
                Maticsoft.Model.tSet model = bll.GetModel(1);
                if (model != null)
                {

                    Address.Text = model.Address;
                    BeiAn.Text = model.BeiAn;
                    Copyright.Text = model.Copyright;
                    Description.Text = model.Description;
                    Email.Text = model.Email;
                    KeyWords.Text = model.KeyWords;
                    Tel.Text = model.Tel;
                    WebName.Text = model.WebName;
                }
            }

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.tSet bll = new Maticsoft.BLL.tSet();
            Maticsoft.Model.tSet model = bll.GetModel(1);
            if (model == null)
            {
                Maticsoft.Model.tSet newm = new Maticsoft.Model.tSet();
                newm.Address = Address.Text;
                newm.BeiAn = BeiAn.Text;
                newm.Copyright = Copyright.Text;
                newm.Description = Description.Text;
                newm.Email = Email.Text;
                newm.KeyWords = KeyWords.Text;
                newm.Tel = Tel.Text;
                newm.WebName = WebName.Text;
                if (bll.Add(newm) > 0)
                {
                    Alert.ShowInTop("保存成功！");
                }
                else
                {
                    Alert.ShowInTop("保存失败！");
                }
            }

            else
            {
                model.Address = Address.Text;
                model.BeiAn = BeiAn.Text;
                model.Copyright = Copyright.Text;
                model.Description = Description.Text;
                model.Email = Email.Text;
                model.KeyWords = KeyWords.Text;
                model.Tel = Tel.Text;
                model.WebName = WebName.Text;
                if (bll.Update(model))
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