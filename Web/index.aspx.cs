using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Maticsoft.Web.Code;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace Maticsoft.Web
{
    public partial class index : System.Web.UI.Page
    {
        private ReportDocument RegRdt = new ReportDocument();
        protected void Page_Load(object sender, EventArgs e)
        {
           // DealPrint();
        }
        protected void Page_UnLoad(object sender, EventArgs e)

        {

            //释放

            RegRdt.Dispose();

            this.Dispose();

            this.ClearChildState();

        }
        private void DealPrint()

        {


            BLL.tMenu bll = new BLL.tMenu();
            DataTable dt = bll.GetList(" mCode=11 ").Tables[0];

            RegRdt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            string path = Server.MapPath("~/report/test.rpt");
            RegRdt.Load(path);

            RegRdt.SetDataSource(dt);

            // crv.ParameterFieldInfo = paramFields;

            crv.ReportSource = RegRdt;

            crv.DataBind();

            RegRdt.Refresh();

        }
    }
}