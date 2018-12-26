using FineUIPro;
using System;
using System.Data;
using Web;

namespace Maticsoft.Web.Admin.Indexs
{
    public partial class selectIndex : PageBase
    {

        BLL.t_Index BLL = new BLL.t_Index();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTree();
                if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
                {
                    string dptId = Request.QueryString["dptId"];
                    Model.t_Index  m = BLL.GetModel(Convert.ToInt32(dptId));

                    TreeDpt.SelectedNodeID = m.FatherId.ToString();

                }
            }
        }
        protected void BindTree()
        {
            TreeDpt.Nodes.Clear();
            BLL.t_Index BLL = new BLL.t_Index();
            DataSet ds = BLL.GetAllList();
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["Id"], ds.Tables[0].Columns["FatherId"], false);

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

        protected void TreeDpt_NodeCommand(object sender, FineUIPro.TreeCommandEventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
            {
                string dptId = Request.QueryString["dptId"];
                Model.t_Index m = BLL.GetModel(Convert.ToInt32(dptId));
                if (e.NodeID == m.Id.ToString())
                {
                   return;
                }

            }
            PageContext.RegisterStartupScript(ActiveWindow.GetWriteBackValueReference(e.Node.NodeID,e.Node.Text ) + ActiveWindow.GetHideReference());
        }

    }
}