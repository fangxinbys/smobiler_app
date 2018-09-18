using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using FineUIPro;

namespace Maticsoft.Web.Admin.Menu
{
    public partial class MenuList : PageBase
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
            BLL.tMenu BLL = new BLL.tMenu(); 
            DataSet ds = BLL.GetList(" mCode<>0 order by mSort desc");
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["mCode"], ds.Tables[0].Columns["mFaherId"], false);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row.IsNull("mFaherId"))
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.NodeID = row["mCode"].ToString();
                    node.Text = row["mName"].ToString();
                    node.EnableClickEvent = true;
                    node.Icon = (Icon)Enum.Parse(typeof(Icon), row["mIcon"].ToString(), true);
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
                    node.NodeID = row["mCode"].ToString();
                    node.Text = row["mName"].ToString();
                    node.Icon = (Icon)Enum.Parse(typeof(Icon), row["mIcon"].ToString(), true);
                    node.EnableClickEvent = true;
                    treeNode.Nodes.Add(node); 
                    ResolveSubTree(row, node);
                }
            }
        }

        protected void LoadData()
        {
            Maticsoft.BLL.tMenu BLL = new Maticsoft.BLL.tMenu();
            string sortField = GridDpt.SortField;
            string sortDirection = GridDpt.SortDirection;
            if (TreeDpt.SelectedNode == null)
            {
                GridDpt.RecordCount = BLL.GetRecordCount("");

                DataView view = BLL.GetListByPage("", " mSort desc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                GridDpt.DataSource = view.ToTable();
            }
            else
            {
                string NodeId = TreeDpt.SelectedNodeID;
                GridDpt.RecordCount = BLL.GetRecordCount(" mFaherId=" + NodeId + " or mCode=" + NodeId);
                DataView view = BLL.GetListByPage(" mFaherId=" + NodeId + " or mCode=" + NodeId, " mSort desc ", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
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
                    Alert.ShowInTop("请先删除该菜单下子菜单！");
                    return;
                }


                BLL.tMenu BLL = new Maticsoft.BLL.tMenu();

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
                Window1.Title = "菜单管理";
                string openUrl = String.Format("./MenuEdit.aspx?mCode={0}", HttpUtility.UrlEncode(deptID.ToString()));
                PageContext.RegisterStartupScript(Window1.GetSaveStateReference(deptID.ToString())+ Window1.GetShowReference(openUrl));
            }


        }

        protected void GridDpt_Sort(object sender, GridSortEventArgs e)
        {
            LoadData();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Window1.Title = "菜单管理";
            PageContext.RegisterStartupScript(Window1.GetShowReference("./MenuEdit.aspx"));
        }

        protected void Window1_Close(object sender, WindowCloseEventArgs e)
        {
            Alert.ShowInTop("保存成功");
            BindTree();
            LoadData();
        }
    }
}