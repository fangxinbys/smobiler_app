using FineUIPro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.Users
{
    public partial class userDpt : PageBase
    {

        BLL.tDepartMent BLL = new BLL.tDepartMent();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTree();
                if (!string.IsNullOrEmpty(Request.QueryString["dptId"]))
                {
                    string dptId = Request.QueryString["dptId"];

                    TreeDpt.SelectedNodeID = dptId;

                }
            }
        }
        protected void BindTree()
        {
            TreeDpt.Nodes.Clear();
            BLL.tDepartMent BLL = new BLL.tDepartMent();
            DataSet ds = BLL.GetAllList();
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["dptId"], ds.Tables[0].Columns["dptFatherId"], false);

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

        protected void TreeDpt_NodeCommand(object sender, FineUIPro.TreeCommandEventArgs e)
        {
            if (TreeDpt.SelectedNodeID == "10000")
            {
                return;
            }
        
            PageContext.RegisterStartupScript(ActiveWindow.GetWriteBackValueReference(e.Node.NodeID,e.Node.Text ) + ActiveWindow.GetHideReference());
        }

    }
}