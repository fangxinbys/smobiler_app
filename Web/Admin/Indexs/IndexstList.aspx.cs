using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using FineUIPro;
 
namespace Maticsoft.Web.Admin.Indexs
{
    public partial class IndexstList : PageBase
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
            BLL.t_Index BLL = new BLL.t_Index(); 
            DataSet ds = BLL.GetAllList(); 
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["Id"], ds.Tables[0].Columns["FatherId"],false);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row.IsNull("FatherId"))
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.NodeID = row["Id"].ToString();
                    node.Text = row["Name"].ToString();
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
                    node.NodeID = row["Id"].ToString();
                    node.Text = row["Name"].ToString();
                    node.EnableClickEvent = true;
                    treeNode.Nodes.Add(node); 
                    ResolveSubTree(row, node);
                }
            }
        }

        protected void LoadData()
        {
            Maticsoft.BLL.t_Index BLL = new Maticsoft.BLL.t_Index();
            string sortField = GridDpt.SortField;
            string sortDirection = GridDpt.SortDirection;
            if (TreeDpt.SelectedNode == null)
            {
                GridDpt.RecordCount = BLL.GetRecordCount(" FatherId is null ");
    
                DataView view = BLL.GetListByPage(" FatherId is null ", " Id asc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                GridDpt.DataSource = view.ToTable();
            }
            else
            {
                string NodeId = TreeDpt.SelectedNodeID;
                GridDpt.RecordCount = BLL.GetRecordCount(" FatherId=" + NodeId);
                DataView view = BLL.GetListByPage(" FatherId=" + NodeId, " Id asc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
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


                if (TreeDpt.FindNode(deptID.ToString()).Nodes.Count > 0)
                {
                    Alert.ShowInTop("请先删除该指标下子部门！");
                    return;
                }
            
                BLL.t_Index BLL = new Maticsoft.BLL.t_Index();


                if (BLL.GetModel(deptID).FatherId==null)
                {
                    Alert.ShowInTop("根目录无法删除！");
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
                Window1.Title = "指标管理";
                string openUrl = String.Format("./IndexEdit.aspx?dptId={0}", HttpUtility.UrlEncode(deptID.ToString()));
                PageContext.RegisterStartupScript(Window1.GetSaveStateReference(deptID.ToString())+ Window1.GetShowReference(openUrl));
            }


        }

        protected void GridDpt_Sort(object sender, GridSortEventArgs e)
        {
            LoadData();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Window1.Title = "指标管理";
            PageContext.RegisterStartupScript(Window1.GetShowReference("./IndexEdit.aspx"));
        }

        protected void Window1_Close(object sender, WindowCloseEventArgs e)
        {
            Alert.ShowInTop("保存成功");
            BindTree();
            LoadData();
        }
    }
}