using System;
using Smobiler.Core;
namespace smbApp.userControl
{
    partial class memberListView : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panelList = new Smobiler.Core.Controls.Panel();
            this.imageList = new Smobiler.Core.Controls.Image();
            this.labelListTitle = new Smobiler.Core.Controls.Label();
            // 
            // panelList
            // 
            this.panelList.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageList,
            this.labelListTitle});
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(76, 13);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(300, 100);
            this.panelList.Touchable = true;
            this.panelList.Press += new System.EventHandler(this.panelList_Press);
            // 
            // imageList
            // 
            this.imageList.DisplayMember = "Img";
            this.imageList.Location = new System.Drawing.Point(5, 5);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(40, 40);
            // 
            // labelListTitle
            // 
            this.labelListTitle.DisplayMember = "Title";
            this.labelListTitle.Location = new System.Drawing.Point(50, 0);
            this.labelListTitle.Name = "labelListTitle";
            this.labelListTitle.Size = new System.Drawing.Size(250, 50);
            // 
            // memberListView
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelList});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "memberListView";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panelList;
        private Smobiler.Core.Controls.Image imageList;
        private Smobiler.Core.Controls.Label labelListTitle;
    }
}