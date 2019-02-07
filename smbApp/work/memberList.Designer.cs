using System;
using Smobiler.Core;
namespace smbApp.work
{
    partial class memberList : Smobiler.Core.Controls.MobileForm
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
            this.panelList = new Smobiler.Core.Controls.Panel();
            this.listViewMember = new Smobiler.Core.Controls.ListView();
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
            this.labTitle.Text = "会员列表";
            // 
            // panelList
            // 
            this.panelList.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listViewMember});
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(300, 460);
            // 
            // listViewMember
            // 
            this.listViewMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMember.Name = "listViewMember";
            this.listViewMember.PageSize = 30;
            this.listViewMember.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listViewMember.PageSizeTextSize = 12F;
            this.listViewMember.ShowSplitLine = true;
            this.listViewMember.Size = new System.Drawing.Size(300, 460);
            this.listViewMember.SplitLineColor = System.Drawing.Color.Silver;
            this.listViewMember.TemplateControlName = "memberListView";
            // 
            // memberList
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panTop,
            this.panelList});
            this.Load += new System.EventHandler(this.memberList_Load);
            this.Name = "memberList";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panTop;
        private Smobiler.Core.Controls.Panel panNav;
        private Smobiler.Core.Controls.Panel paneCenter;
        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.ImageButton imgBtnNav;
        private Smobiler.Core.Controls.Panel panelList;
        private Smobiler.Core.Controls.ListView listViewMember;
    }
}