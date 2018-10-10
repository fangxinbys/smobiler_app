using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using FineUIPro;
using System.IO;
using System.Text;
 
namespace Maticsoft.Web.Admin.Member
{
    public partial class MemberPointEdit : PageBase
    {
        Maticsoft.BLL.UvipInfo bll = new BLL.UvipInfo();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                LoadData();
            }
        }

        protected void GridDpt_PageIndexChange(object sender, FineUIPro.GridPageEventArgs e)
        {
            LoadData();
        }



        protected void LoadData()
        {

            if (string.IsNullOrEmpty(Request.QueryString["userId"]))
            {
                return;
            }
            string userId = Request.QueryString["userId"];
            int  uid = int.Parse(userId);
            string sortField = GridDpt.SortField;
            string sortDirection = GridDpt.SortDirection;


            GridDpt.RecordCount = bll.GetRecordCount(string.Format(" UvipId={0} ",uid));

            DataView view = bll.GetListByPage(string.Format(" UvipId={0} ", uid), " Id desc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
            view.Sort = String.Format("{0} {1}", sortField, sortDirection);
            GridDpt.DataSource = view.ToTable();

            GridDpt.DataBind();

        }

        protected void TreeDpt_NodeCommand(object sender, TreeCommandEventArgs e)
        {
            LoadData();
        }

        protected void GridDpt_RowCommand(object sender, GridCommandEventArgs e)
        {
           
           

        }

        protected void GridDpt_Sort(object sender, GridSortEventArgs e)
        {
            LoadData();
        }

       
 
        protected void btnExcel_Click(object sender, EventArgs e)
        {
            if (GridDpt.Rows.Count <= 0)
            {
                Alert.ShowInTop("no data！"); return;
            }
            string ExcelName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=" + ExcelName);
            Response.ContentType = "application/excel";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Write(GetGridTableHtml(GridDpt));
            Response.End();
        }
         




        private string GetGridTableHtml(Grid grid)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<meta http-equiv=\"content-type\" content=\"application/excel; charset=UTF-8\"/>");

            sb.Append("<table cellspacing=\"0\" rules=\"all\" border=\"1\" style=\"border-collapse:collapse;\">");

            sb.Append("<tr>");
            foreach (GridColumn column in grid.Columns)
            {
                sb.AppendFormat("<td style='height:35;background-color:#ddd'>{0}</td>", column.HeaderText);
            }
            sb.Append("</tr>");


            foreach (GridRow row in grid.Rows)
            {
                sb.Append("<tr>");
                foreach (object value in row.Values)
                {
                    string html = value.ToString();
                    if (html.StartsWith(Grid.TEMPLATE_PLACEHOLDER_PREFIX))
                    {
                        string templateID = html.Substring(Grid.TEMPLATE_PLACEHOLDER_PREFIX.Length);
                        Control templateCtrl = row.FindControl(templateID);
                        html = GetRenderedHtmlSource(templateCtrl);
                    }
                    else
                    {
                        if (html.Contains("box-grid-static-checkbox"))
                        {
                            if (html.Contains("uncheck"))
                            {
                                html = "×";
                            }
                            else
                            {
                                html = "√";
                            }
                        }

                        if (html.Contains("<img"))
                        {
                            string prefix = Request.Url.AbsoluteUri.Replace(Request.Url.AbsolutePath, "");
                            html = html.Replace("src=\"", "src=\"" + prefix);
                        }
                    }

                    sb.AppendFormat("<td>{0}</td>", html);
                }
                sb.Append("</tr>");
            }


            sb.Append("</table>");

            return sb.ToString();
        }


        /// <summary>
        /// 获取控件渲染后的HTML源代码
        /// 可能遇到的两个错误：
        /// 1. 控件必须放在具有 runat=server 的窗体标记内" - 添加重载方法 VerifyRenderingInServerForm
        /// 2. 只能在执行Render()的过程中调用RegisterForEventValidation” - 为页面添加声明 EnableEventValidation="false"
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        private string GetRenderedHtmlSource(Control ctrl)
        {
            if (ctrl != null)
            {
                using (StringWriter sw = new StringWriter())
                {
                    using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                    {
                        ctrl.RenderControl(htw);

                        return sw.ToString();
                    }
                }
            }
            return String.Empty;
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Request.QueryString["userId"]))
            {
                Alert.ShowInTop("请选择会员！"); return;
            }
            if (rbtnFirst.Checked == false && rbtnSecond.Checked == false)
            {
                Alert.ShowInTop("请选择操作！");return;
            }
            decimal money = 0;
            if (rbtnFirst.Checked)
            {
                money = 0 - decimal.Parse(txtNum.Text);
            }
            else
            {
                money =   decimal.Parse(txtNum.Text);
            }
            Maticsoft.Model.UvipInfo model = new Maticsoft.Model.UvipInfo();
            model.Uqyt = money;
            model.Urmk = txtValue.Text+"-"+ (rbtnFirst.Checked==true?rbtnFirst.Text:rbtnSecond.Text)              ;
            model.Utime = DateTime.Now;
            model.UvipId = int.Parse(Request.QueryString["userId"]);
            if (bll.Add(model) > 0)
            {
                LoadData();
            }
            else
            {
                Alert.ShowInTop("出错了！"); return;
            }
          
        }
    }
}