using System;
using Smobiler.Core;
namespace smbApp.userInfo
{
    partial class frmUserInfo : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            this.panTop = new Smobiler.Core.Controls.Panel();
            this.panNav = new Smobiler.Core.Controls.Panel();
            this.imgBtnNav = new Smobiler.Core.Controls.ImageButton();
            this.paneCenter = new Smobiler.Core.Controls.Panel();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.panBot = new Smobiler.Core.Controls.Panel();
            this.btnExit = new Smobiler.Core.Controls.Button();
            this.panelContent = new Smobiler.Core.Controls.Panel();
            this.panelUser = new Smobiler.Core.Controls.Panel();
            this.panelUserC1 = new Smobiler.Core.Controls.Panel();
            this.fUser = new Smobiler.Core.Controls.FontIcon();
            this.panelUserC2 = new Smobiler.Core.Controls.Panel();
            this.imgBtnUser = new Smobiler.Core.Controls.ImageButton();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labelUser = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.buttonSave = new Smobiler.Core.Controls.Button();
            this.popListTest = new Smobiler.Core.Controls.PopList();
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
            this.panTop.Size = new System.Drawing.Size(300, 35);
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
            this.labTitle.Text = "个人信息";
            // 
            // panBot
            // 
            this.panBot.BorderColor = System.Drawing.Color.Transparent;
            this.panBot.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnExit});
            this.panBot.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panBot.Location = new System.Drawing.Point(44, 100);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(300, 35);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.BorderRadius = 0;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FontSize = 18F;
            this.btnExit.Location = new System.Drawing.Point(65, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 30);
            this.btnExit.Text = "注销登录";
            this.btnExit.Press += new System.EventHandler(this.btnExit_Press);
            // 
            // panelContent
            // 
            this.panelContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelUser,
            this.panel1,
            this.panel6});
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(7, 57);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(300, 280);
            // 
            // panelUser
            // 
            this.panelUser.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panelUser.BorderColor = System.Drawing.Color.Silver;
            this.panelUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelUserC1,
            this.panelUserC2,
            this.panel2});
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(23, 26);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(300, 35);
            // 
            // panelUserC1
            // 
            this.panelUserC1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fUser});
            this.panelUserC1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserC1.Location = new System.Drawing.Point(8, 6);
            this.panelUserC1.Name = "panelUserC1";
            this.panelUserC1.Size = new System.Drawing.Size(60, 100);
            // 
            // fUser
            // 
            this.fUser.ForeColor = System.Drawing.Color.Gray;
            this.fUser.Location = new System.Drawing.Point(20, 2);
            this.fUser.Name = "fUser";
            this.fUser.ResourceID = "user";
            this.fUser.Size = new System.Drawing.Size(30, 30);
            // 
            // panelUserC2
            // 
            this.panelUserC2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgBtnUser});
            this.panelUserC2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUserC2.Location = new System.Drawing.Point(8, 6);
            this.panelUserC2.Name = "panelUserC2";
            this.panelUserC2.Size = new System.Drawing.Size(50, 100);
            // 
            // imgBtnUser
            // 
            this.imgBtnUser.BorderColor = System.Drawing.Color.Transparent;
            this.imgBtnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBtnUser.ForeColor = System.Drawing.Color.White;
            this.imgBtnUser.IconColor = System.Drawing.Color.Silver;
            this.imgBtnUser.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgBtnUser.Location = new System.Drawing.Point(17, 11);
            this.imgBtnUser.Name = "imgBtnUser";
            this.imgBtnUser.ResourceID = "angle-right";
            this.imgBtnUser.Size = new System.Drawing.Size(100, 30);
            this.imgBtnUser.Press += new System.EventHandler(this.imgBtnUser_Press);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labelUser});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(73, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 100);
            // 
            // labelUser
            // 
            this.labelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUser.FontSize = 15F;
            this.labelUser.Location = new System.Drawing.Point(18, 5);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(100, 35);
            this.labelUser.Text = "大灰狼与红太狼";
            // 
            // panel1
            // 
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel3,
            this.panel4,
            this.panel5});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(23, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            // 
            // panel3
            // 
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
            this.fontIcon1.ResourceID = "user";
            this.fontIcon1.Size = new System.Drawing.Size(30, 30);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 100);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(73, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 100);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "大灰狼与红太狼";
            // 
            // panel6
            // 
            this.panel6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panel6.BorderColor = System.Drawing.Color.Silver;
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.buttonSave});
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(23, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 35);
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
            this.buttonSave.Text = "保存设置";
            // 
            // popListTest
            // 
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "上海";
            popListItem1.Value = "上海";
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "北京";
            popListItem2.Value = "北京";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2});
            popListGroup1.Title = "一线城市";
            popListGroup1.Value = "一线城市";
            this.popListTest.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popListTest.Name = "popListTest";
            // 
            // frmUserInfo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListTest});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panTop,
            this.panBot,
            this.panelContent});
            this.Name = "frmUserInfo";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panTop;
        private Smobiler.Core.Controls.Panel panNav;
        private Smobiler.Core.Controls.Panel panBot;
        private Smobiler.Core.Controls.Panel paneCenter;
        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.ImageButton imgBtnNav;
        private Smobiler.Core.Controls.Button btnExit;
        private Smobiler.Core.Controls.Panel panelContent;
        private Smobiler.Core.Controls.Panel panelUser;
        private Smobiler.Core.Controls.Panel panelUserC1;
        private Smobiler.Core.Controls.FontIcon fUser;
        private Smobiler.Core.Controls.Panel panelUserC2;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label labelUser;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel panel6;
        private Smobiler.Core.Controls.Button buttonSave;
        private Smobiler.Core.Controls.PopList popListTest;
        private Smobiler.Core.Controls.ImageButton imgBtnUser;
    }
}