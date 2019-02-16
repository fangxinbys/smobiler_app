using System;
using Smobiler.Core;
namespace smbApp
{
    partial class frmRegister : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panTop = new Smobiler.Core.Controls.Panel();
            this.panNav = new Smobiler.Core.Controls.Panel();
            this.imgBtnNav = new Smobiler.Core.Controls.ImageButton();
            this.paneCenter = new Smobiler.Core.Controls.Panel();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.panelContent = new Smobiler.Core.Controls.Panel();
            this.panelUser = new Smobiler.Core.Controls.Panel();
            this.panel14 = new Smobiler.Core.Controls.Panel();
            this.fUser = new Smobiler.Core.Controls.FontIcon();
            this.panel15 = new Smobiler.Core.Controls.Panel();
            this.btnSendMsg = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.panelYzm = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.txtYzm = new Smobiler.Core.Controls.TextBox();
            this.panelPwd = new Smobiler.Core.Controls.Panel();
            this.panel7 = new Smobiler.Core.Controls.Panel();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.panel9 = new Smobiler.Core.Controls.Panel();
            this.textPwd = new Smobiler.Core.Controls.TextBox();
            this.panelPwdDou = new Smobiler.Core.Controls.Panel();
            this.panel11 = new Smobiler.Core.Controls.Panel();
            this.fontIcon3 = new Smobiler.Core.Controls.FontIcon();
            this.panel13 = new Smobiler.Core.Controls.Panel();
            this.textPwdDou = new Smobiler.Core.Controls.TextBox();
            this.panelSave = new Smobiler.Core.Controls.Panel();
            this.panel12 = new Smobiler.Core.Controls.Panel();
            this.buttonSave = new Smobiler.Core.Controls.Button();
            this.timer1 = new Smobiler.Core.Controls.Timer();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Maroon;
            this.panTop.BorderColor = System.Drawing.Color.Transparent;
            this.panTop.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panNav,
            this.paneCenter});
            this.panTop.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(44, 100);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(300, 40);
            // 
            // panNav
            // 
            this.panNav.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgBtnNav});
            this.panNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panNav.Location = new System.Drawing.Point(12, 0);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(60, 100);
            // 
            // imgBtnNav
            // 
            this.imgBtnNav.BackColor = System.Drawing.Color.Maroon;
            this.imgBtnNav.BorderColor = System.Drawing.Color.Transparent;
            this.imgBtnNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBtnNav.ForeColor = System.Drawing.Color.White;
            this.imgBtnNav.IconColor = System.Drawing.Color.White;
            this.imgBtnNav.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgBtnNav.Location = new System.Drawing.Point(17, 11);
            this.imgBtnNav.Name = "imgBtnNav";
            this.imgBtnNav.ResourceID = "angle-left";
            this.imgBtnNav.Size = new System.Drawing.Size(100, 30);
            this.imgBtnNav.Press += new System.EventHandler(this.imgBtnNav_Press);
            // 
            // paneCenter
            // 
            this.paneCenter.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labTitle});
            this.paneCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneCenter.Location = new System.Drawing.Point(81, 15);
            this.paneCenter.Name = "paneCenter";
            this.paneCenter.Size = new System.Drawing.Size(300, 100);
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitle.FontSize = 16F;
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labTitle.Location = new System.Drawing.Point(48, 10);
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 60F, 0F);
            this.labTitle.Size = new System.Drawing.Size(100, 35);
            this.labTitle.Text = "填写信息";
            // 
            // panelContent
            // 
            this.panelContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelUser,
            this.panelYzm,
            this.panelPwd,
            this.panelPwdDou,
            this.panelSave});
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(7, 57);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(300, 280);
            // 
            // panelUser
            // 
            this.panelUser.BorderColor = System.Drawing.Color.Transparent;
            this.panelUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel14,
            this.panel15,
            this.panel2});
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(23, 26);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(300, 35);
            // 
            // panel14
            // 
            this.panel14.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel14.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fUser});
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(8, 6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(60, 100);
            // 
            // fUser
            // 
            this.fUser.ForeColor = System.Drawing.Color.Gray;
            this.fUser.Location = new System.Drawing.Point(20, 2);
            this.fUser.Name = "fUser";
            this.fUser.ResourceID = "user";
            this.fUser.Size = new System.Drawing.Size(30, 30);
            // 
            // panel15
            // 
            this.panel15.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSendMsg});
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(8, 6);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(80, 100);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.BackColor = System.Drawing.Color.Silver;
            this.btnSendMsg.BorderColor = System.Drawing.Color.Silver;
            this.btnSendMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendMsg.Location = new System.Drawing.Point(11, 11);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(100, 25);
            this.btnSendMsg.Text = "获取验证码";
            this.btnSendMsg.Press += new System.EventHandler(this.btnSendMsg_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtUserName});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(73, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 100);
            // 
            // txtUserName
            // 
            this.txtUserName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.KeyboardType = Smobiler.Core.Controls.KeyboardType.PhonePad;
            this.txtUserName.Location = new System.Drawing.Point(75, 26);
            this.txtUserName.MaxLength = 11;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(195, 30);
            this.txtUserName.WaterMarkText = "请输入手机号码";
            // 
            // panelYzm
            // 
            this.panelYzm.BorderColor = System.Drawing.Color.Silver;
            this.panelYzm.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel3,
            this.panel5});
            this.panelYzm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYzm.Location = new System.Drawing.Point(23, 26);
            this.panelYzm.Name = "panelYzm";
            this.panelYzm.Size = new System.Drawing.Size(300, 35);
            // 
            // panel3
            // 
            this.panel3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1});
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 100);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Gray;
            this.fontIcon1.Location = new System.Drawing.Point(20, 2);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "comment-o";
            this.fontIcon1.Size = new System.Drawing.Size(30, 30);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtYzm});
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(73, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 100);
            // 
            // txtYzm
            // 
            this.txtYzm.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtYzm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtYzm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYzm.KeyboardType = Smobiler.Core.Controls.KeyboardType.PhonePad;
            this.txtYzm.Location = new System.Drawing.Point(75, 26);
            this.txtYzm.Name = "txtYzm";
            this.txtYzm.Size = new System.Drawing.Size(195, 30);
            this.txtYzm.WaterMarkText = "输入验证码";
            // 
            // panelPwd
            // 
            this.panelPwd.BorderColor = System.Drawing.Color.Silver;
            this.panelPwd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel7,
            this.panel9});
            this.panelPwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPwd.Location = new System.Drawing.Point(23, 26);
            this.panelPwd.Name = "panelPwd";
            this.panelPwd.Size = new System.Drawing.Size(300, 35);
            // 
            // panel7
            // 
            this.panel7.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel7.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon2});
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(8, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 100);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.Gray;
            this.fontIcon2.Location = new System.Drawing.Point(20, 2);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "key";
            this.fontIcon2.Size = new System.Drawing.Size(30, 30);
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textPwd});
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(73, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 100);
            // 
            // textPwd
            // 
            this.textPwd.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.textPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPwd.Location = new System.Drawing.Point(75, 26);
            this.textPwd.Name = "textPwd";
            this.textPwd.SecurityMode = true;
            this.textPwd.Size = new System.Drawing.Size(195, 30);
            this.textPwd.WaterMarkText = "设置登录密码";
            // 
            // panelPwdDou
            // 
            this.panelPwdDou.BorderColor = System.Drawing.Color.Silver;
            this.panelPwdDou.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel11,
            this.panel13});
            this.panelPwdDou.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPwdDou.Location = new System.Drawing.Point(23, 26);
            this.panelPwdDou.Name = "panelPwdDou";
            this.panelPwdDou.Size = new System.Drawing.Size(300, 35);
            // 
            // panel11
            // 
            this.panel11.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel11.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon3});
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(8, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(60, 100);
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.Gray;
            this.fontIcon3.Location = new System.Drawing.Point(20, 2);
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "check-square-o";
            this.fontIcon3.Size = new System.Drawing.Size(30, 30);
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textPwdDou});
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(73, 7);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(300, 100);
            // 
            // textPwdDou
            // 
            this.textPwdDou.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.textPwdDou.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textPwdDou.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPwdDou.Location = new System.Drawing.Point(75, 26);
            this.textPwdDou.Name = "textPwdDou";
            this.textPwdDou.SecurityMode = true;
            this.textPwdDou.Size = new System.Drawing.Size(195, 30);
            this.textPwdDou.WaterMarkText = "再次输入密码";
            // 
            // panelSave
            // 
            this.panelSave.BorderColor = System.Drawing.Color.Silver;
            this.panelSave.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel12});
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSave.Location = new System.Drawing.Point(23, 26);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(300, 35);
            // 
            // panel12
            // 
            this.panel12.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.buttonSave});
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(73, 7);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(300, 100);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.BorderRadius = 2;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FontSize = 18F;
            this.buttonSave.Location = new System.Drawing.Point(65, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(170, 30);
            this.buttonSave.Text = "提交注册";
            this.buttonSave.Press += new System.EventHandler(this.buttonSave_Press);
            // 
            // timer1
            // 
            this.timer1.Name = "timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmRegister
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.timer1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panTop,
            this.panelContent});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRegister_KeyDown);
            this.Name = "frmRegister";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panTop;
        private Smobiler.Core.Controls.Panel panNav;
        private Smobiler.Core.Controls.ImageButton imgBtnNav;
        private Smobiler.Core.Controls.Panel paneCenter;
        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.Panel panelContent;
        private Smobiler.Core.Controls.Panel panelUser;
        private Smobiler.Core.Controls.Panel panel14;
        private Smobiler.Core.Controls.FontIcon fUser;
        private Smobiler.Core.Controls.Panel panel15;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel panelYzm;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.Button btnSendMsg;
        private Smobiler.Core.Controls.TextBox txtYzm;
        private Smobiler.Core.Controls.Panel panelPwd;
        private Smobiler.Core.Controls.Panel panel7;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Panel panel9;
        private Smobiler.Core.Controls.TextBox textPwd;
        private Smobiler.Core.Controls.Panel panelPwdDou;
        private Smobiler.Core.Controls.Panel panel11;
        private Smobiler.Core.Controls.FontIcon fontIcon3;
        private Smobiler.Core.Controls.Panel panel13;
        private Smobiler.Core.Controls.TextBox textPwdDou;
        private Smobiler.Core.Controls.Panel panelSave;
        private Smobiler.Core.Controls.Panel panel12;
        private Smobiler.Core.Controls.Button buttonSave;
        private Smobiler.Core.Controls.Timer timer1;
    }
}