using FineUIPro;
 
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.BalanceRecard
{
    public partial class BalanceRecardEdit : PageBase
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();



                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {

                    Maticsoft.BLL.PocketBalanceRecard bll = new Maticsoft.BLL.PocketBalanceRecard();
                    Maticsoft.Model.PocketBalanceRecard model = bll.GetModel(int.Parse(Request.QueryString["Id"]));

                    txtUser.Text = model.recardUser;
                    txtJe.Text = model.recardMoney.ToString();


                    Maticsoft.BLL.PocketUser bllTask = new Maticsoft.BLL.PocketUser();
                    Maticsoft.Model.PocketUser modelTask = bllTask.GetModelList(string.Format(" pocketUserPhone ='{0}' ", model.recardUser))[0];
                    if (modelTask == null) return;
                    txtZfb.Text = modelTask.pocketUserAlipay;
                    txtRname.Text = modelTask.pocketUserReName;
                    if (model.recardState != "待审核")
                    {
                        CheckTask.SelectedValue = model.recardState;
                    }
                    txtRemark.Text = model.recardRemake;
                }
            }
        }

        
 

        protected void btnSave_Click(object sender, EventArgs e)
        {
   
         

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {

                Maticsoft.BLL.PocketBalanceRecard bll = new Maticsoft.BLL.PocketBalanceRecard();
                Maticsoft.Model.PocketBalanceRecard model = bll.GetModel(int.Parse(Request.QueryString["Id"]));

                model.recardState = CheckTask.SelectedValue;
                model.recardRemake = txtRemark.Text;

                bll.Update(model);
                PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
            }
          
        }
    }
}