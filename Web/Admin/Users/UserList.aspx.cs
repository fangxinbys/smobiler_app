using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using FineUIPro;
 
namespace Maticsoft.Web.Admin.Users
{
    public partial class UserList : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTree();
                LoadData();
                
            }
        }

        protected void GridDpt_PageIndexChange(object sender, FineUIPro.GridPageEventArgs e)
        {
            LoadData();
        }
        protected void BindTree()
        {
            TreeDpt.Nodes.Clear();
            BLL.tDepartMent BLL = new BLL.tDepartMent(); 
            DataSet ds = BLL.GetAllList(); 
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["dptId"], ds.Tables[0].Columns["dptFatherId"],false);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row.IsNull("dptFatherId"))
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.NodeID = row["dptId"].ToString();
                    node.Text = row["dptName"].ToString();
                    node.EnableClickEvent = true;
                    TreeDpt.Nodes.Add(node);
                    ResolveSubTree(row, node);
                }
            }
        }
        private void ResolveSubTree(DataRow dataRow, FineUIPro.TreeNode treeNode)
        {
            DataRow[] rows = dataRow.GetChildRows("TreeRelation");
            if (rows.Length > 0)
            {
                // 如果是目录，则默认展开
                treeNode.Expanded = true;
                foreach (DataRow row in rows)
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.NodeID = row["dptId"].ToString();
                    node.Text = row["dptName"].ToString();
                    node.EnableClickEvent = true;
                    treeNode.Nodes.Add(node); 
                    ResolveSubTree(row, node);
                }
            }
        }

        protected void LoadData()
        {
            Maticsoft.BLL.tUsers BLL = new Maticsoft.BLL.tUsers();
            string sortField = GridDpt.SortField;
            string sortDirection = GridDpt.SortDirection;
            if (TreeDpt.SelectedNode == null)
            {
                GridDpt.RecordCount = BLL.GetRecordCount("");
    
                DataView view = BLL.GetListByPage("", " userId asc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                GridDpt.DataSource = view.ToTable();
            }
            else
            {
                string NodeId = TreeDpt.SelectedNodeID;
                GridDpt.RecordCount = BLL.GetRecordCount(" dptId=" + NodeId);
                DataView view = BLL.GetListByPage(" dptId=" + NodeId, " userId asc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                GridDpt.DataSource = view.ToTable();
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


              

                BLL.tUsers BLL = new Maticsoft.BLL.tUsers();
                if(BLL.GetModel(deptID).dptId==10000)
                {
                    Alert.ShowInTop("超级用户无法删除！");
                    return;
                }
                bool isTrue = BLL.Delete(deptID);


                if (!isTrue)
                {
                    Alert.ShowInTop("删除失败！");
                    return;
                }
                else
                {
                    BindTree();
                    LoadData();
                }
            }
            if (e.CommandName == "Edit")
            {
                this.Window1.Title = "用户管理";
                string openUrl = String.Format("./UserEdit.aspx?userId={0}", HttpUtility.UrlEncode(deptID.ToString()));
                PageContext.RegisterStartupScript(Window1.GetSaveStateReference(deptID.ToString())+ Window1.GetShowReference(openUrl));
            }


        }

        protected void GridDpt_Sort(object sender, GridSortEventArgs e)
        {
            LoadData();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Window1.Title = "用户管理";
            PageContext.RegisterStartupScript(Window1.GetShowReference("./UserEdit.aspx"));
        }

        protected void Window1_Close(object sender, WindowCloseEventArgs e)
        {
            Alert.ShowInTop("保存成功");
            BindTree();
            LoadData();
        }


        protected string GetRoleName(string Rid)
        {
            Maticsoft.BLL.tRole bll = new Maticsoft.BLL.tRole();
            Maticsoft.Model.tRole model = bll.GetModel(int.Parse(Rid)); 
            return model.rName;
        }
        protected string GetDptName(string Rid)
        {
            Maticsoft.BLL.tDepartMent bll = new Maticsoft.BLL.tDepartMent();
            Maticsoft.Model.tDepartMent model = bll.GetModel(int.Parse(Rid));
            return model.dptName;
        }
        protected string GetZt(string state)
        {
            if (state == "0")
            {
                return "<span style='color:red'>禁用</span>";
            }
            else
            {
                return "<span style='color:green'>启用</span>";
            }
        }
    }
}