using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
 
using Maticsoft.Common;

namespace smbApp
{
    partial class Login : Smobiler.Core.Controls.MobileForm 
    {
        public Login() : base()
        {
 
            InitializeComponent();
        }
        /// <summary>
        /// 读取客户端数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_Load(object sender, EventArgs e)
        {

            //Maticsoft.Web.Code.web web = new Maticsoft.Web.Code.web();
            //web.sendMsg(new string[] { "13839870291", "15290319652" }, 277602);
            //读取用户名
            ReadClientData(MobileServer.ServerID + "user", (object sender1, ClientDataResultHandlerArgs e1) =>
            {
                if (string.IsNullOrEmpty(e1.error))
                {
                    txtUserName.Text = e1.Value;
                }
            });
            //读取密码
            ReadClientData(MobileServer.ServerID + "pwd", (object sender1, ClientDataResultHandlerArgs e1) =>
            {
                if (string.IsNullOrEmpty(e1.error))
                {
                    txtPassWord.Text = e1.Value;
                    if (txtPassWord.Text.Length > 0)
                    {
                        checkRemb.Checked = true;
                    }
                }
            });
        }
        private void btnLogin_Press(object sender, EventArgs e)
        {
            try
            {
                string userID = txtUserName.Text.Trim();
                string PassWord = txtPassWord.Text.Trim();
                if (userID.Length <= 0)
                {
                    MessageBox.Show("请输入手机号码");
                    return;
                }
                if (PassWord.Length < 0)
                {
                    MessageBox.Show("请输入密码");
                    return;
                }
                LoadClientData(MobileServer.ServerID + "user", userID);
                if (checkRemb.Checked == true)
                {
                    //记住密码
                    LoadClientData(MobileServer.ServerID + "pwd", PassWord);
                }
                else
                {
                    //删除客户端数据
                    RemoveClientData(MobileServer.ServerID + "pwd", (object s, ClientDataResultHandlerArgs args) => txtPassWord.Text = "");
                }


                Maticsoft.BLL.tUsers bll = new Maticsoft.BLL.tUsers();
                List<Maticsoft.Model.tUsers> userList = bll.GetModelList("usersName='" + userID + "'"); 
                Maticsoft.Model.tUsers user = userList.Count == 1 ? userList[0] : null;

                if (user != null)
                {
                    string strPwd =Maticsoft.Common.DEncrypt.DESEncrypt.Encrypt(PassWord);
                    if (user.usersPwd == strPwd)
                    {
                        if (user.Flag == 0)
                        {
                            MessageBox.Show("用户未启用，请联系管理员！");
                            return;
                        }
                        else
                        {
                            insertLog(userList[0], "APP登入系统");
                            Client.Session["UserModel"] = userList[0];
                            frmMenuMain frm = new frmMenuMain();
                            this.Show(frm);
                            //this.Show(frm, (obj, args) => { this.Close(); });
                            return;
                        }
                    }
                    else
                    {

                        MessageBox.Show("用户名或密码错误！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                    return;
                }




            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        protected void insertLog(Maticsoft.Model.tUsers user,string doWhat)
        {
            Maticsoft.BLL.tSysLog bll = new Maticsoft.BLL.tSysLog();
            Maticsoft.Model.tSysLog m = new Maticsoft.Model.tSysLog();
            m.DoWhat = doWhat;
            m.IP = this.Client.Device + ":" + this.Client.DeviceID;
            m.SysTime = DateTime.Now;
 
            m.UserId = user.userId;
            m.UserName = user.usersName;

            bll.Add(m);
        }

        private void Login_KeyDown(object sender, KeyDownEventArgs e)
        {
            Client.Exit();
            
        }
    }
}