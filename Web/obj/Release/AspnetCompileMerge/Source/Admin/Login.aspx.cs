using FineUIPro;
using Maticsoft.Common.DEncrypt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Web;



namespace Maticsoft.Web.Admin
{
    public partial class login:PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();  
            }
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {
            InitCaptchaCode();
            Maticsoft.BLL.tSet bll = new Maticsoft.BLL.tSet();
            Maticsoft.Model.tSet model = bll.GetModel(1);
            Window1.Title = model == null ? "" : model.WebName;
        }

        /// <summary>
        /// 初始化验证码
        /// </summary>
        private void InitCaptchaCode()
        {
            imgCaptcha.Text = String.Format("<img src=\"{0}\" />", ResolveUrl("~/captcha/HHVCode.aspx?w=100&h=26&t=" + DateTime.Now.Ticks));
        }

         

        protected void imgCaptcha_Click(object sender, EventArgs e)
        {
            InitCaptchaCode();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbxCaptcha.Text.Trim() != Session["HHCaptchaImageText"].ToString())
                {
                    Alert.ShowInTop("验证码错误！", String.Empty, "top.window.location.reload(false);");
                    return;
                }
                else
                {
                    string userName = tbxUserName.Text.Trim();
                    string password = tbxPassword.Text.Trim();
                    BLL.tUsers bll = new BLL.tUsers();
                    List<Model.tUsers> userList = bll.GetModelList("usersName='" + userName + "'");

                    Model.tUsers user = userList.Count == 0 ? null : userList[0];

                    if (user != null)
                    {
           
                        if (user.usersPwd ==  DESEncrypt.Encrypt(password))
                        {
                            if (user.Flag==0)
                            {
                                Alert.ShowInTop("用户未启用，请联系管理员！", String.Empty, "top.window.location.reload(false);");
                                return;
                            }
                            else
                            {
                               
                                LoginSuccess(user);

                                return;
                            }
                        }
                        else
                        {
                          
                            Alert.ShowInTop("用户名或密码错误！", String.Empty, "top.window.location.reload(false);");
                            return;
                        }
                    }
                    else
                    { 
                        Alert.ShowInTop("用户名或密码错误！", String.Empty, "top.window.location.reload(false);");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
 
                Alert.ShowInTop("系统错误！"+ex.Message, MessageBoxIcon.Error);
                return;
            }
        }
        /// <summary>
        /// 登录成功
        /// </summary>
        /// <param name="user"></param>
        private void LoginSuccess(Model.tUsers user)
        {
            RegisterOnlineUser(user);


            Session["adminUser"] = user;
            Session.Timeout = 120;
            var res = JsonConvert.SerializeObject(user);
            HttpCookie cookie = new HttpCookie("adminUser");
            cookie.Expires = DateTime.Now.AddMinutes(120);
            cookie.Value = HttpUtility.UrlEncode(res, Encoding.GetEncoding("UTF-8"));
            Response.Cookies.Add(cookie);

            insertLog("登入系统");
            Response.Redirect("./Main.aspx", false);
        }



    }
}
