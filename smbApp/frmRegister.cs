using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        }

        private void btnSendMsg_Press(object sender, EventArgs e)
        {
            Maticsoft.Web.Code.web web = new Maticsoft.Web.Code.web();
            string strPhone = txtUserName.Text.Trim();
            Random rad = new Random();//实例化随机数产生器rad；
            int value = rad.Next(1000, 10000);//用rad生成大于等于1000，小于等于9999的随机数；
            string Yzm = value.ToString(); //转化为字符串；
            string UseTime = "5";
            string Rst = web.sendMsg(new string[] { strPhone }, 277602, new string[] { Yzm, UseTime });
            if (Rst.Contains("OK"))
            {
                Rst = "发送成功";
                btnSendMsg.Enabled = false;
                timer1.Start();
            }

            MessageBox.Show(Rst); 
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
    }
}