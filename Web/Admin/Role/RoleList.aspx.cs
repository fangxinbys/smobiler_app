using FineUIPro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin.Role
{
    public partial class RoleList : PageBase
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
       

        protected void LoadData()
        {
            Maticsoft.BLL.tRole BLL = new Maticsoft.BLL.tRole();
            string sortField = GridDpt.SortField;
            string sortDirection = GridDpt.SortDirection;
     
           
                GridDpt.RecordCount = BLL.GetRecordCount("");
                DataView view = BLL.GetListByPage("", "", GridDpt.PageIndex * GridDpt.PageSize, (GridDpt.PageIndex + 1) * GridDpt.PageSize).Tables[0].DefaultView;
                view.Sort = String.Format("{0} {1}", sortField, sortDirection);
                GridDpt.DataSource = view.ToTable();
          
            GridDpt.DataBind();

        }

        protected void TreeDpt_NodeCommand(object sender, TreeCommandEventArgs e)
        {
            LoadData();
        }

        protected void GridDpt_RowCommand(object sender, GridCommandEventArgs e)
        {

            int roleID = GetSelectedDataKeyID(GridDpt);


            if (e.CommandName == "Delete")
            {
                if (roleID == 10)
                {
                    Alert.ShowInTop("超级管理员不可删除！");
                    return;
                }


                BLL.tRole BLL = new Maticsoft.BLL.tRole();

                bool isTrue = BLL.Delete(roleID);
                 
                if (!isTrue)
                {
                    Alert.ShowInTop("删除失败！");
                    return;
                }
                else
                {
              
                    LoadData();
                }
            }
            else if (e.CommandName == "Edit")
            {
                Window1.Title = "编辑角色";
                string openUrl = String.Format("./RoleEdit.aspx?roleId={0}", HttpUtility.UrlEncode(roleID.ToString()));
                PageContext.RegisterStartupScript(Window1.GetSaveStateReference(roleID.ToString()) + Window1.GetShowReference(openUrl));
            }
            else
            {

                Window1.Title = "编辑角色";
                string openUrl = String.Format("./roleMenu.aspx?rCode={0}", HttpUtility.UrlEncode(roleID.ToString()));
                PageContext.RegisterStartupScript(Window1.GetSaveStateReference(roleID.ToString()) + Window1.GetShowReference(openUrl));
            }

        }

        protected void GridDpt_Sort(object sender, GridSortEventArgs e)
        {
            LoadData();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Window1.Title = "编辑角色";
            PageContext.RegisterStartupScript(Window1.GetShowReference("./RoleEdit.aspx"));
        }

        protected void Window1_Close(object sender, WindowCloseEventArgs e)
        {
            Alert.ShowInTop("保存成功");
      
            LoadData();
        }
    }
}