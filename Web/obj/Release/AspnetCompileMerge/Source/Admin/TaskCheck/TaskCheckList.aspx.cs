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
using Maticsoft.DBUtility;

namespace Maticsoft.Web.Admin.TaskCheck
{
    public partial class TaskCheckList : PageBase
    {
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

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.subId desc");
            }
            strSql.Append(")AS Row, T.*  from TaskCheckInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM TaskCheckInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        protected void LoadData()
        {
           
            string sortField = GridDpt.SortField;
            string sortDirection = GridDpt.SortDirection;
            if (drpSearch.SelectedValue == "")
            {
                if (txtValue.Text.Trim() == "")
                {
                    GridDpt.RecordCount = GetRecordCount(" ");

                    DataView view = GetListByPage("", " subId desc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                    view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                    GridDpt.DataSource = view.ToTable();
                }
                else
                {
                    GridDpt.RecordCount = GetRecordCount(" subUser like '%" + txtValue.Text + "%' ");

                    DataView view = GetListByPage(" subUser like '%" + txtValue.Text + "%' ", " subId desc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                    view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                    GridDpt.DataSource = view.ToTable();
                }
            }
            else
            {
                if (txtValue.Text.Trim() == "")
                {
                    GridDpt.RecordCount = GetRecordCount(string.Format(" examine='{0}' ", drpSearch.SelectedValue));

                    DataView view = GetListByPage(string.Format(" examine='{0}' ", drpSearch.SelectedValue), " subId desc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                    view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                    GridDpt.DataSource = view.ToTable();
                }
                else
                {
                    GridDpt.RecordCount = GetRecordCount(string.Format(" subUser like '%" + txtValue.Text + "%' and examine='{0}' ", drpSearch.SelectedValue));

                    DataView view = GetListByPage(string.Format(" subUser like '%" + txtValue.Text + "%' and  examine='{0}' ", drpSearch.SelectedValue), " subId desc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                    view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                    GridDpt.DataSource = view.ToTable();
                }

            }
            GridDpt.DataBind();

        }

        protected void TreeDpt_NodeCommand(object sender, TreeCommandEventArgs e)
        {
            LoadData();
        }

        protected void GridDpt_RowCommand(object sender, GridCommandEventArgs e)
        {
           
            int deptID  = GetSelectedDataKeyID(GridDpt);

        
            if (e.CommandName == "Delete")
            { 

                BLL.PocketTaskSub BLL = new Maticsoft.BLL.PocketTaskSub();
               
                bool isTrue = BLL.Delete(deptID);


                if (!isTrue)
                {
                    Alert.ShowInTop("删除失败！");
                    return;
                }
                else
                {
                    insertLog("删除了任务提交：" + deptID);
                    LoadData();
                }
            }
            if (e.CommandName == "Edit")
            {
                this.Window1.Title = "任务提交管理";
                string openUrl = String.Format("./TaskCheckEdit.aspx?Id={0}", HttpUtility.UrlEncode(deptID.ToString()));
                PageContext.RegisterStartupScript(Window1.GetSaveStateReference(deptID.ToString())+ Window1.GetShowReference(openUrl));
            }
           
        }

        protected void GridDpt_Sort(object sender, GridSortEventArgs e)
        {
            LoadData();
        }

      

        protected void Window1_Close(object sender, WindowCloseEventArgs e)
        {
            Alert.ShowInTop("保存成功");
           
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
            LoadData();
        }

        protected void btnRe_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void drpSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}