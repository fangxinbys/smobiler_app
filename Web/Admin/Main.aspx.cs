using FineUIPro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web;

namespace Maticsoft.Web.Admin
{
    public partial class Main : PageBase
    {
        protected Maticsoft.Model.tSet model;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                Maticsoft.Model.tUsers user= GetIdentityUser();
                btnUserName.Text = user.usersName;

                Maticsoft.BLL.tSet bll = new Maticsoft.BLL.tSet();
                model = bll.GetModel(1);
                Maticsoft.BLL.S_Onlines bllOn = new Maticsoft.BLL.S_Onlines();
                Maticsoft.Model.S_Onlines online = bllOn.GetModelByUseId(user.userId);

                CreateNotify("您上次登陆时间是：" + online.UpdateTime, "Self", "登录提示", 5000,false);
                
            }
        }
        [WebMethod]
        public static void CheckLogin()
        {
            

            HttpContext.Current.Response.Clear();
            if (HttpContext.Current.Session["adminUser"] == null && HttpContext.Current.Request.Cookies["adminUser"] == null)
            {
                HttpContext.Current.Response.Write("loginErr");
            }
            else
            {
                
                if (HttpContext.Current.Session["adminUser"] == null)
                {
                    var res = HttpUtility.UrlDecode(HttpContext.Current.Request.Cookies["adminUser"].Value, Encoding.GetEncoding("UTF-8"));
                    var resStu = JsonConvert.DeserializeObject<Maticsoft.Model.tUsers>(res);
                    HttpContext.Current.Session["adminUser"] = resStu;
                    HttpContext.Current.Session.Timeout = 120;

                }
                if (HttpContext.Current.Request.Cookies["adminUser"] == null)
                {
                    Maticsoft.Model.tUsers resStu = HttpContext.Current.Session["adminUser"] as Maticsoft.Model.tUsers;
                    var res = JsonConvert.SerializeObject(resStu);
                    HttpCookie cookie = new HttpCookie("adminUser");
                    cookie.Expires = DateTime.Now.AddMinutes(120);
                    cookie.Value = HttpUtility.UrlEncode(res, Encoding.GetEncoding("UTF-8"));
                    HttpContext.Current.Response.Cookies.Add(cookie);

                }

                HttpContext.Current.Response.Write("loginOk");
            }
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();
        }

        protected void Window1_Close(object sender, WindowCloseEventArgs e)
        {
            exit();
            PageContext.RegisterStartupScript("alertAndRedirect('修改成功，请重新登录', 'Login.aspx');");
         
        }
        private void LoadData()
        {
            Maticsoft.BLL.tMenu BLL = new Maticsoft.BLL.tMenu();
            DataSet ds = BLL.GetList(string.Format(" mCode in (select mCode from tRoleMenu where rCode={0}) order by mSort desc ", GetIdentityUser().roleCode));
            ds.Relations.Add("TreeRelation", ds.Tables[0].Columns["mCode"], ds.Tables[0].Columns["mFaherId"], false);

            foreach (DataRow row in ds.Tables[0].Rows)
            {

                if (row.IsNull("mFaherId"))
                {
                    FineUIPro.TreeNode node = new FineUIPro.TreeNode();
                    node.Text = row["mName"].ToString();
                    node.NodeID = row["mCode"].ToString();


                    if (!string.IsNullOrEmpty(row["mIcon"].ToString()))
                    {
                        node.Icon = (Icon)Enum.Parse(typeof(Icon), row["mIcon"].ToString(), true);
                    }
                     
                    treeMenu.Nodes.Add(node); 
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
                    node.Text = row["mName"].ToString();
                    node.NodeID = row["mCode"].ToString();

                    node.Icon = (Icon)Enum.Parse(typeof(Icon), row["mIcon"].ToString(), true);


                    if (row["mUrl"].ToString().Contains("#") == false)
                    {
                        node.NavigateUrl = row["mUrl"].ToString();
                    }
                    treeNode.Nodes.Add(node);
                    ResolveSubTree(row, node);
                }
            }
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            exit();
          
        }
        protected void exit()
        {
            Session.Abandon();

            HttpCookie cok = Request.Cookies["adminUser"];
            if (cok != null)
            {
                cok.Expires = DateTime.Now.AddDays(-1);
                Response.AppendCookie(cok);
            }
            Response.Redirect("./Login.aspx");
        }
        protected void txtUserInfo_Click(object sender, EventArgs e)
        {

            string openUrl = String.Format("./UserInfo.aspx?userId={0}", HttpUtility.UrlEncode(GetIdentityUser().userId.ToString()));
            PageContext.RegisterStartupScript(Window1.GetSaveStateReference(GetIdentityUser().userId.ToString()) + Window1.GetShowReference(openUrl));
        }
 

        
    }
}