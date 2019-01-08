using FineUIPro;
using System;
using System.Data;
using Web;

namespace Maticsoft.Web.Admin.Menu
{
    public partial class selectMenu : PageBase
    {

        BLL.tMenu BLL = new BLL.tMenu();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTree();
                if (!string.IsNullOrEmpty(Request.QueryString["mCode"]))
                {
                    string mCode = Request.QueryString["mCode"];
                    Model.tMenu  m = BLL.GetModel(Convert.ToInt32(mCode));
                    if (m.mFaherId != null)
                    {
                        TreeDpt.SelectedNodeID = m.mFaherId.ToString();
                    }
                 

                }
            }
        }
        protected void BindTree()
        {
            TreeDpt.Nodes.Clear();
            BLL.tMenu BLL = new BLL.tMenu();
            DataSet ds = BLL.GetAllList();
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["mCode"], ds.Tables[0].Columns["mFaherId"], false);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row.IsNull("mFaherId"))
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.NodeID = row["mCode"].ToString();
                    node.Text = row["mName"].ToString();
                    node.Icon = (Icon)Enum.Parse(typeof(Icon), row["mIcon"].ToString(), true);
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
                    node.NodeID = row["mCode"].ToString();
                    node.Text = row["mName"].ToString();
                    node.Icon = (Icon)Enum.Parse(typeof(Icon), row["mIcon"].ToString(), true);
                    node.EnableClickEvent = true;
                    treeNode.Nodes.Add(node);
                    ResolveSubTree(row, node);
                }
            }
        }

        protected void TreeDpt_NodeCommand(object sender, FineUIPro.TreeCommandEventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["mCode"]))
            {
                string mCode = Request.QueryString["mCode"];
                Model.tMenu m = BLL.GetModel(Convert.ToInt32(mCode));
                if (e.NodeID == m.mCode.ToString())
                {
                   return;
                }

            }
            PageContext.RegisterStartupScript(ActiveWindow.GetWriteBackValueReference(e.Node.NodeID,e.Node.Text ) + ActiveWindow.GetHideReference());
        }

    }
}