using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class showTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {

                    Maticsoft.BLL.PocketTask bll = new Maticsoft.BLL.PocketTask();
                    Maticsoft.Model.PocketTask model = bll.GetModel(int.Parse(Request.QueryString["Id"]));
                    lit_task.Text = model == null ? "": model.pocketTaskRule;
                }
            }

        }
    }
}