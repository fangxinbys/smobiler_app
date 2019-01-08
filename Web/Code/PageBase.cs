using FineUIPro;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Web;
using System.Web.UI;


namespace Web
{
    public class PageBase : System.Web.UI.Page
    {
        #region OnInit


        protected override void OnInit(EventArgs e)
        {

            string RawUrl = Page.Request.RawUrl;
            if (!RawUrl.Contains("Admin/Login.aspx"))
            {
                if (HttpContext.Current.Session["adminUser"] == null && HttpContext.Current.Request.Cookies["adminUser"] == null)
                {
                    HttpContext.Current.Response.Redirect("~/Admin/Login.aspx"); return;
                }

            }


            var pm = PageManager.Instance;
            if (pm != null)
            {
                HttpCookie themeCookie = Request.Cookies["Theme_Pro"];
                if (themeCookie != null)
                {
                    string themeValue = themeCookie.Value;

                    // 是否为内置主题
                    if (IsSystemTheme(themeValue))
                    {
                        pm.CustomTheme = String.Empty;
                        pm.Theme = (Theme)Enum.Parse(typeof(Theme), themeValue, true);
                    }
                    else
                    {
                        pm.CustomTheme = themeValue;
                    }
                }
                else
                {
                    string themeValue = "Blitzer";

                    // 是否为内置主题
                    if (IsSystemTheme(themeValue))
                    {
                        pm.CustomTheme = String.Empty;
                        pm.Theme = (Theme)Enum.Parse(typeof(Theme), themeValue, true);
                    }
                    else
                    {
                        pm.CustomTheme = themeValue;
                    }
                 
                }

                if (Constants.IS_BASE)
                {
                    pm.EnableAnimation = false;
                }
            }

            base.OnInit(e);
        }

        private bool IsSystemTheme(string themeName)
        {
            themeName = themeName.ToLower();
            string[] themes = Enum.GetNames(typeof(Theme));
            foreach (string theme in themes)
            {
                if (theme.ToLower() == themeName)
                {
                    return true;
                }
            }
            return false;
        }


        protected void RegisterOnlineUser(Maticsoft.Model.tUsers user)
        {
            Maticsoft.BLL.S_Onlines bll = new Maticsoft.BLL.S_Onlines();
            Maticsoft.Model.S_Onlines online = bll.GetModelByUseId(user.userId);

            DateTime now = DateTime.Now;
            // 如果不存在，就创建一条新的记录
            if (online == null)
            {
                online = new Maticsoft.Model.S_Onlines();
                online.UserId = user.userId;
                online.IpAdddress = Request.UserHostAddress;
                online.LoginTime = now;
                online.UpdateTime = now;

                bll.Add(online);
            }
            else
            {

                online.UserId = user.userId;
                online.IpAdddress = Request.UserHostAddress;
                online.LoginTime = now;
                online.UpdateTime = now;
                bll.Update(online);

            }
        }
        /// <summary>
        /// 获取grid选择行id
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        protected int GetSelectedDataKeyID(Grid grid)
        {

            int id = -1;
            int rowIndex = grid.SelectedRowIndex;
            if (rowIndex >= 0)
            {
                id = Convert.ToInt32(grid.DataKeys[rowIndex][0]);
            }
            return id;
        }
        /// <summary>
        /// 获取当前登录用户信息
        /// </summary>
        /// <returns></returns>
        protected Maticsoft.Model.tUsers GetIdentityUser()
        {
            Maticsoft.Model.tUsers user = new Maticsoft.Model.tUsers();

            if (Request.Cookies["adminUser"] == null)
            {
                Maticsoft.Model.tUsers resStu = Session["adminUser"] as Maticsoft.Model.tUsers;
                user = resStu;
            }
            else
            {
                var res = HttpUtility.UrlDecode(Request.Cookies["adminUser"].Value, Encoding.GetEncoding("UTF-8"));
                var resStu = JsonConvert.DeserializeObject<Maticsoft.Model.tUsers>(res);
                Maticsoft.Model.tUsers resStuCookie = resStu;
                user = resStu;
            }
            return user;
        }
        /// <summary>

        // CreateNotify("您上次登陆时间是：" + online.UpdateTime, "Self", "登录提示", 0,false);
        /// </summary>
        /// <param name="tbxMessage">通知内容</param>

        /// <param name="rblTarget">Self Parent Top </param>
        /// <param name="tbxTitle"></param>
        /// <param name="showTime">5000毫秒/0</param>
        /// <param name="IsModal">true遮盖/false不遮盖</param>
        protected void CreateNotify(string tbxMessage, string rblTarget, string tbxTitle, int showTime, bool IsModal)
        {

            Notify notify = new Notify();
            notify.Message = tbxMessage;

            notify.MessageBoxIcon = (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), "Information", true);
            notify.Target = (Target)Enum.Parse(typeof(Target), rblTarget, true);

            notify.ShowHeader = true;

            notify.Title = tbxTitle;
            notify.EnableDrag = true;
            notify.EnableClose = true;
            notify.DisplayMilliseconds = showTime;

            notify.PositionX = (Position)Enum.Parse(typeof(Position), "Right", true);
            notify.PositionY = (Position)Enum.Parse(typeof(Position), "Bottom", true);

            notify.IsModal = IsModal;
            notify.BodyPadding = "5px";
            notify.MessageAlign = (FineUIPro.TextAlign)Enum.Parse(typeof(FineUIPro.TextAlign), "Left", true);
            notify.ShowLoading = false;

            //notify.Width = 300;
            //notify.MinWidth = 400;
            //notify.MaxWidth = 500;

            //notify.ID = notifyId; 
            //notify.HideScript = PageManager1.GetCustomEventReference("HideNotify"); 
            notify.Show();
        }
        /// <summary>
        /// 系统操作日志
        /// </summary>
        /// <param name="doWhat"></param>
        protected void insertLog(string doWhat)
        {
            Maticsoft.BLL.tSysLog bll = new Maticsoft.BLL.tSysLog();
            Maticsoft.Model.tSysLog m = new Maticsoft.Model.tSysLog();
            m.DoWhat = doWhat;
            m.IP = Request.UserHostAddress;
            m.SysTime = DateTime.Now;

            Maticsoft.Model.tUsers user = GetIdentityUser();
            m.UserId = user.userId;
            m.UserName = user.usersName;

            bll.Add(m);
        }
        #endregion
    }
}