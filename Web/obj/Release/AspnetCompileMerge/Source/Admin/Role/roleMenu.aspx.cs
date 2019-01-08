using FineUIPro;
using System;
using System.Collections.Generic;
using System.Data;
using Web;

namespace Maticsoft.Web.Admin.Role
{
    public partial class roleMenu : PageBase
    {

        BLL.tMenu BLL = new BLL.tMenu();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnClose.OnClientClick = ActiveWindow.GetHideReference();
                BindTree();
                if (!string.IsNullOrEmpty(Request.QueryString["rCode"]))
                {

                    string rCode = Request.QueryString["rCode"];
                    Maticsoft.BLL.tRoleMenu BLLtt = new Maticsoft.BLL.tRoleMenu();
                    List<Maticsoft.Model.tRoleMenu> list = BLLtt.GetModelList(string.Format(" rCode={0}", rCode));
                    string[] strR = new string[list.Count];
                    for (int i = 0; i < list.Count; i++)
                    {
                        TreeDpt.FindNode(list[i].mCode.ToString()).Checked = true;
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
                    node.EnableCheckBox = true;
                    node.EnableCheckEvent = true;
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
                    node.EnableCheckBox = true;
                    node.EnableCheckEvent = true;
                    treeNode.Nodes.Add(node);
                    ResolveSubTree(row, node);
                }
            }
        }

        protected void TreeDpt_NodeCheck(object sender, TreeCheckEventArgs e)
        {
            if (e.Checked)
            {

             
                TreeDpt.CheckAllNodes(e.Node.Nodes);
                if (TreeDpt.FindNode(e.NodeID).ParentNode == null) return;
                 
                if (TreeDpt.FindNode(e.NodeID).ParentNode.Checked == false)
                {
                    TreeDpt.FindNode(e.NodeID).ParentNode.Checked = true;
                }
            }
            else
            {
                TreeDpt.UncheckAllNodes(e.Node.Nodes);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["rCode"]))
            {
                string rCode = Request.QueryString["rCode"];
                Maticsoft.BLL.tRoleMenu BLLtt = new Maticsoft.BLL.tRoleMenu();
                BLLtt.Delete(int.Parse(rCode));
                FineUIPro.TreeNode[] nodes = TreeDpt.GetCheckedNodes();


                if (nodes.Length > 0)
                {
                    Maticsoft.Model.tRoleMenu m = new Maticsoft.Model.tRoleMenu();
                    Maticsoft.BLL.tRoleMenu BLL = new Maticsoft.BLL.tRoleMenu();

                    foreach (FineUIPro.TreeNode node in nodes)
                    {
                        m.rCode = int.Parse(rCode);
                        m.mCode = int.Parse(node.NodeID);
                        BLL.Add(m);
                    }
                    PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());
                }

                else
                {
                    Alert.ShowInTop("操作失败！");
                }

            }
        }
    }
}