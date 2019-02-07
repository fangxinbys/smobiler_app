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
            this.panTop = new Smobiler.Core.Controls.Panel();
            this.panNav = new Smobiler.Core.Controls.Panel();
            this.imgBtnNav = new Smobiler.Core.Controls.ImageButton();
            this.paneCenter = new Smobiler.Core.Controls.Panel();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.panBot = new Smobiler.Core.Controls.Panel();
            this.btnExit = new Smobiler.Core.Controls.Button();
            this.panelSave = new Smobiler.Core.Controls.Panel();
            this.buttonSave = new Smobiler.Core.Controls.Button();
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
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 50F, 0F);
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
            // panelSave
            // 
            this.panelSave.BorderColor = System.Drawing.Color.Transparent;
            this.panelSave.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.buttonSave});
            this.panelSave.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSave.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panelSave.Location = new System.Drawing.Point(44, 100);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(300, 35);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.BorderRadius = 2;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FontSize = 18F;
            this.buttonSave.Location = new System.Drawing.Point(65, 2);
            this.buttonSave.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 0F, 5F);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(170, 30);
            this.buttonSave.Text = "保存设置";
            // 
            // frmUserInfo
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panTop,
            this.panBot,
            this.panelSave});
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
        private Smobiler.Core.Controls.Panel panelSave;
        private Smobiler.Core.Controls.Button buttonSave;
    }
}