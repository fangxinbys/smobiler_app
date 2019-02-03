using System;
using Smobiler.Core;
namespace smbApp.userControl
{
    partial class mainBanner : Smobiler.Core.Controls.MobileUserControl
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
            this.imageBanner = new Smobiler.Core.Controls.Image();
            // 
            // imageBanner
            // 
            this.imageBanner.DisplayMember = "image";
            this.imageBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageBanner.Name = "imageBanner";
            this.imageBanner.Size = new System.Drawing.Size(300, 115);
            // 
            // mainBanner
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageBanner});
            this.Size = new System.Drawing.Size(300, 115);
            this.Name = "mainBanner";

        }
        #endregion

        private Smobiler.Core.Controls.Image imageBanner;
    }
}