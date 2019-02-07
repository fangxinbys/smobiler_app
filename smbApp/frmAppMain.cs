using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace smbApp
{
    partial class frmMenuMain : Smobiler.Core.Controls.MobileForm
    {
        private Dictionary<string, IconMenuViewGroup> menuDictionary = new Dictionary<string, IconMenuViewGroup>();
        public frmMenuMain() : base()
        {
        
            InitializeComponent();
        }
        DataTable pageTable;
        private void DataBindBanner()
        {
            pageTable = new DataTable();
            pageTable.Columns.Add("image");
            pageTable.Rows.Add("logon");
            pageTable.Rows.Add("logon");
            pageTable.Rows.Add("logon");
            if (pageTable.Rows.Count > 0)
            {
                pageMainView.DataSource = pageTable;
                pageMainView.DataBind();
            }
        }
        private void imgBtnNav_Press(object sender, EventArgs e)
        {
            userInfo.frmUserInfo frm = new userInfo.frmUserInfo();
            //this.Show(frm, (obj, args) => { this.Close(); });
             Show(frm);



        }
    
        private void frmMenuMain_Load(object sender, EventArgs e)
        {

            getMainMenu();
            DataBindBanner();

        }

        protected void getMainMenu()
        {
            if (Client.Session["UserModel"] == null) return;
            this.iconMenuView.Groups.Clear();
            IconMenuViewGroup grop = new IconMenuViewGroup();
            Maticsoft.Model.tUsers user = (Maticsoft.Model.tUsers)Client.Session["UserModel"];
            DataSet ds = getMenu(user.roleCode);
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["mCode"], ds.Tables[0].Columns["mFaherId"], false);
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                if (row.IsNull("mFaherId"))
                {

                    grop.Items.Add(new IconMenuViewItem(row["mCode"].ToString(), row["mAppIcon"].ToString(), row["mName"].ToString(), row["mCode"].ToString(), "1"));
                    ResolveSubTree(row);

                }

            }
            this.iconMenuView.Groups.Add(grop);

        }
        private void ResolveSubTree(DataRow dataRow)
        {
            DataRow[] rows = dataRow.GetChildRows("TreeRelation");
            if (rows.Length > 0)
            {
                IconMenuViewGroup gropSon = new IconMenuViewGroup();
                foreach (DataRow row in rows)
                {
                    gropSon.Items.Add(new IconMenuViewItem(row["mCode"].ToString(), row["mAppIcon"].ToString(), row["mName"].ToString(), row["mCode"].ToString()));
                    //ResolveSubTree(row); 解析到二级菜单
                }
                if (menuDictionary.ContainsKey(dataRow["mCode"].ToString()) == false)
                {
                    menuDictionary.Add(dataRow["mCode"].ToString(), gropSon);
                }
            }
        }

        private void iconMenuView_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            if (menuDictionary.ContainsKey(e.Item.ID) == true)
            {

                this.iconMenuView.ShowDialogMenu(menuDictionary[e.Item.ID]);
            }
            else
            {
              
                switch (e.Item.ID)
                {
                    case "40":
                        work.memberList frm = new work.memberList();
                        this.Show(frm);

                        break;
                     
                    default:  
                        
                        break;
                }
              
            }
        }
        private DataSet getMenu(int roleCode)
        {
            Maticsoft.BLL.tMenu BLL = new Maticsoft.BLL.tMenu();
            DataSet dt = BLL.GetList(string.Format(" mCode in (select mCode from tRoleMenu where rCode={0}) order by mSort desc ", roleCode));
            return dt;
        }

        private void frmMenuMain_KeyDown(object sender, KeyDownEventArgs e)
        {
           this.Client.Exit();
            
        }

        private void toolBarMain_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "主页": 
                    getMainMenu();
                    this.toolBarMain.SelectedIndex = -1;
                    break;
                case "通知":
                    this.toolBarMain.SelectedIndex = -1;
                    break;
                case "我的":
                    this.toolBarMain.SelectedIndex = -1;
                    break;
                case "设置":
                    userInfo.frmUserInfo frm = new userInfo.frmUserInfo();
                    this.Show(frm, (obj, args) => { this.toolBarMain.SelectedIndex=-1 ; });
                    break;
            }
        }

        
    }
}