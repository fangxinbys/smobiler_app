using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Maticsoft.Common.DEncrypt;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace smbApp
{
    partial class frmRegister : Smobiler.Core.Controls.MobileForm
    {
        public frmRegister() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void imgBtnNav_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendMsg_Press(object sender, EventArgs e)
        {
  
            string strPhone = txtUserName.Text.Trim();
            Maticsoft.BLL.tUsers bllUser = new Maticsoft.BLL.tUsers();
            List<Maticsoft.Model.tUsers> userList = bllUser.GetModelList("usersName='" + strPhone + "'");
            Maticsoft.Model.tUsers user = userList.Count >= 1 ? userList[0] : null;

            if (user == null)
            {
                Maticsoft.Web.Code.web web = new Maticsoft.Web.Code.web();

                Random rad = new Random();//实例化随机数产生器rad；
                int value = rad.Next(1000, 10000);//用rad生成大于等于1000，小于等于9999的随机数；
                string Yzm = value.ToString(); //转化为字符串；
                string UseTime = "5";
                string Rst = web.sendMsg(new string[] { strPhone }, 277602, new string[] { Yzm, UseTime });
                if (Rst.Contains("OK"))
                {
                    Maticsoft.BLL.tRegisterSend bll = new Maticsoft.BLL.tRegisterSend();
                    Maticsoft.Model.tRegisterSend model = new Maticsoft.Model.tRegisterSend();
                    model.AppCilentId = this.Client.DeviceID;
                    model.lPhone = strPhone;
                    model.Time = DateTime.Now;
                    model.Yzm = Yzm;
                    if (bll.Add(model) > 0)
                    {
                        Rst = "发送成功,请在5分钟内填写";
                        btnSendMsg.Enabled = false;
                        timer1.Start();
                    }
                }

                MessageBox.Show(Rst);
            }
            else
            {
                MessageBox.Show("该手机号码已经注册");
            }
        }
        int ntimer = 300;//验证码发送所剩时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            ntimer -= 1;
            btnSendMsg.Text = "" + ntimer.ToString() + "秒";
            if (ntimer == 0)
            {
                timer1.Stop();//关闭计时器
                btnSendMsg.Text = "获取验证码";
                btnSendMsg.Enabled = true;
            }
        }

        private void frmRegister_KeyDown(object sender, KeyDownEventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Press(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtYzm.Text.Trim() == "")
            {
                MessageBox.Show("请填写手机号与验证码");return;

            }
            if (!ValidateMobile(txtUserName.Text.Trim()))
            {
                MessageBox.Show("请填写合法手机号"); return;
            }
            if(textPwd.Text.Trim()=="" || textPwdDou.Text.Trim()=="")
            {
                MessageBox.Show("请设置登录密码"); return;

            }
            if (textPwd.Text.Trim()!= textPwdDou.Text.Trim())
            {
                MessageBox.Show("两次密码不一致"); return; 
            }


            Maticsoft.BLL.tRegisterSend bllRegisterSend = new Maticsoft.BLL.tRegisterSend();
            List<Maticsoft.Model.tRegisterSend> tRegisterSendList = bllRegisterSend.GetModelList("AppCilentId='" + this.Client.DeviceID + "'");
            Maticsoft.Model.tRegisterSend tRegisterSend = tRegisterSendList.Count>= 1 ? tRegisterSendList[0] : null;

            if (tRegisterSend == null)
            {
                MessageBox.Show("请先获取验证码"); return;
            }
            if (tRegisterSend.Yzm != txtYzm.Text.Trim())
            {
                MessageBox.Show("验证码无效"); return;
            }

            if ((DateTime.Now - tRegisterSend.Time).Value.Seconds >= 300)
            {
                MessageBox.Show("验证码过期"); return;
            }
            
            Maticsoft.BLL.tUsers bll = new Maticsoft.BLL.tUsers(); 
            Maticsoft.Model.tUsers tUsers = new Maticsoft.Model.tUsers();

            tUsers.usersName = txtUserName.Text.Trim();
            tUsers.trueName = txtUserName.Text.Trim();
            tUsers.usersRemark = this.Client.DeviceID;
            tUsers.Tel = txtUserName.Text.Trim();
            tUsers.Flag = 1;
            tUsers.usersPwd = DESEncrypt.Encrypt(this.textPwd.Text.Trim());

            if (bll.Add(tUsers) >= 1)
            {
                MessageBox.Show("注册成功,请登录", "系统提醒", MessageBoxButtons.OK, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == ShowResult.OK)
                    {
                        this.Close(); 
                    }
                });
              
            }
            else
            {
                MessageBox.Show("注册失败");  
            }
        }
        /// <summary>
        /// 校验手机号码是否符合标准。
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool ValidateMobile(string mobile)
        {
            if (string.IsNullOrEmpty(mobile))
                return false;
            return Regex.IsMatch(mobile, @"^(13|14|15|16|18|19|17)\d{9}$");
        }
    }
}