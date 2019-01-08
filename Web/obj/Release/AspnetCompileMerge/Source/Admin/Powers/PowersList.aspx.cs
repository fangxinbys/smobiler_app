using FineUIPro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.Powers
{
    public partial class PowersList : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTree();//绑定部门
                LoadData();
                LoadPowerData();

                   btnDel.OnClientClick = Confirm.GetShowReference("确认执行删除操作？",
                   String.Empty,
                   MessageBoxIcon.Question,
                   PageManager1.GetCustomEventReference("Confirm_OK"),
                   PageManager1.GetCustomEventReference("Confirm_Cancel"));
            }
        }
        protected void PageManager1_CustomEvent(object sender, CustomEventArgs e)
        {
            if (e.EventArgument == "Confirm_OK")
            {
                if (TreePower.SelectedNodeID == "")
                { Alert.ShowInTop("该项操作未执行，因未选权限！"); return; }
                BLL.tPower bll = new BLL.tPower();

                if (bll.Delete(int.Parse(TreePower.SelectedNodeID)))
                {

                    Alert.ShowInTop("删除成功！");
                    LoadPowerData();
                }
            }
            else if (e.EventArgument == "Confirm_Cancel")
            {
                return;
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

        protected void LoadData()
        {
            //Alert.ShowInTop(TreeDpt.SelectedNodeID);
            Maticsoft.BLL.tUsers BLL = new Maticsoft.BLL.tUsers();
            DataTable dt = null;
            TreeUser.Nodes.Clear();
            if (TreeDpt.SelectedNodeID == "" || TreeDpt.SelectedNodeID=="10000")
            {


                dt = BLL.GetAllList().Tables[0];
               
            }
            else
            {
                string NodeId = TreeDpt.SelectedNodeID;
                dt = BLL.GetList(" dptId=" + NodeId).Tables[0];
 
            }
            foreach (DataRow row in dt.Rows)
            {

                FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                node.NodeID = row["userId"].ToString();
                node.Text = row["usersName"].ToString();
                node.EnableClickEvent = true;
                TreeUser.Nodes.Add(node);
            }

        }
        protected void LoadPowerData()
        {

            TreePower.Nodes.Clear();
            BLL.tPower BLL = new BLL.tPower();
            DataSet ds = BLL.GetAllList();

            foreach (DataRow row in ds.Tables[0].Rows)
            {

                FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                node.NodeID = row["powerId"].ToString();
                node.Text = row["powerName"].ToString();
                node.EnableClickEvent = true;
                node.EnableCheckBox = true;
                node.EnableCheckEvent = true;
                TreePower.Nodes.Add(node);
            }


            if (TreeUser.SelectedNode == null) return;
            string userID =TreeUser.SelectedNodeID;
            Maticsoft.BLL.tUserPower BLLtt = new Maticsoft.BLL.tUserPower();
            List<Maticsoft.Model.tUserPower> list = BLLtt.GetModelList(string.Format(" userId={0}", userID));
            string[] strR = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                TreePower.FindNode(list[i].powerId.ToString()).Checked = true;
            }
        }
        protected void TreeDpt_NodeCommand(object sender, TreeCommandEventArgs e)
        {
            LoadData();
        }

   
       
        protected void TreeUser_NodeCommand(object sender, TreeCommandEventArgs e)
        {
            LoadPowerData();

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
                return;
            BLL.tPower bll = new BLL.tPower();
            Model.tPower m = new Model.tPower();
            m.powerName = txtName.Text;
            if (bll.Add(m)>0)
            {

                Alert.ShowInTop("添加成功！");
                LoadPowerData();
            }
        }

   





        protected void TreePower_NodeCheck(object sender, TreeCheckEventArgs e)
        {

            if (TreeUser.SelectedNode == null)
            {
                Alert.ShowInTop("该项操作未执行，因未选择用户！"); return;
            }
           
            Maticsoft.BLL.tUserPower BLLtt = new Maticsoft.BLL.tUserPower();
            BLLtt.Delete(int.Parse(TreeUser.SelectedNodeID));
            FineUIPro.TreeNode[] nodes = TreePower.GetCheckedNodes();


            if (nodes.Length > 0)
            {
                Maticsoft.Model.tUserPower m = new Maticsoft.Model.tUserPower();
                Maticsoft.BLL.tUserPower BLL = new Maticsoft.BLL.tUserPower();

                foreach (FineUIPro.TreeNode node in nodes)
                {
                    m.userId = int.Parse(TreeUser.SelectedNodeID);
                    m.powerId = int.Parse(node.NodeID);
                    BLL.Add(m);
                }
                LoadPowerData();
            }
        }
 
      
    }
}