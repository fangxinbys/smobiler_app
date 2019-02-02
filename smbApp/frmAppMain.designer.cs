using System;
using Smobiler.Core;
namespace smbApp
{
    partial class frmAppMain : Smobiler.Core.Controls.MobileForm
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
            this.iconMenuView = new Smobiler.Core.Controls.IconMenuView();
            this.labTitle = new Smobiler.Core.Controls.Label();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Maroon;
            this.panTop.BorderColor = System.Drawing.Color.Transparent;
            this.panTop.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panNav,
            this.labTitle});
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
            this.imgBtnNav.ResourceID = "bars";
            this.imgBtnNav.Size = new System.Drawing.Size(100, 30);
            this.imgBtnNav.Press += new System.EventHandler(this.imgBtnNav_Press);
            // 
            // iconMenuView
            // 
            this.iconMenuView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconMenuView.Location = new System.Drawing.Point(0, 60);
            this.iconMenuView.Name = "iconMenuView";
            this.iconMenuView.Size = new System.Drawing.Size(300, 300);
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labTitle.FontSize = 16F;
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.labTitle.Location = new System.Drawing.Point(48, 10);
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(50F, 0F, 0F, 0F);
            this.labTitle.Size = new System.Drawing.Size(100, 35);
            this.labTitle.Text = "功能列表";
            // 
            // frmMenuMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panTop,
            this.iconMenuView});
            this.DrawerWidth = 200;
            this.Name = "frmMenuMain";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panTop;
        private Smobiler.Core.Controls.Panel panNav;
        private Smobiler.Core.Controls.IconMenuView iconMenuView;
        private Smobiler.Core.Controls.ImageButton imgBtnNav;
        private Smobiler.Core.Controls.Label labTitle;
    }
}