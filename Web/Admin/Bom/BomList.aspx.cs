using FineUIPro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;
using Maticsoft.DBUtility;

namespace Maticsoft.Web.Admin.Bom
{
    public partial class BomList : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTree();//绑定部门
              

                
            }
        }
       
    
        protected void BindTree()
        {
            TreeBom.Nodes.Clear();
            BLL.tBom BLL = new BLL.tBom();
            DataSet ds = DbHelperSQL.Query(@"");//
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["component"], ds.Tables[0].Columns["parent"], false);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row.IsNull("parent"))
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.NodeID = row["component"].ToString();
                    node.Text = row["component"].ToString();
                    node.Icon = Icon.Database;
                    node.Expanded = true;
                    TreeBom.Nodes.Add(node);
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
               
                foreach (DataRow row in rows)
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.NodeID = row["component"].ToString();
                    node.Text = row["component"].ToString();
                    node.Icon = Icon.Door;
                    node.Expanded = false;
                    treeNode.Nodes.Add(node);
                    ResolveSubTree(row, node);
                }
            }
        }
  
 

   



         
      
    }
}