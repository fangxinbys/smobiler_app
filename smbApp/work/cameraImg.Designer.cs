using System;
using Smobiler.Core;
namespace smbApp.work
{
    partial class cameraImg : Smobiler.Core.Controls.MobileForm
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
            this.panelCamera = new Smobiler.Core.Controls.Panel();
            this.buttonUser = new Smobiler.Core.Controls.Button();
            this.imageUser = new Smobiler.Core.Controls.Image();
            this.camera1 = new Smobiler.Core.Controls.Camera();
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
            this.labTitle.Text = "上传图片";
            // 
            // panelContent
            // 
            this.panelContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelCamera});
            this.panelContent.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panelContent.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(300, 460);
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.buttonUser,
            this.imageUser});
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Name = "panelCamera";
            this.panelCamera.Size = new System.Drawing.Size(300, 460);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.Maroon;
            this.buttonUser.Location = new System.Drawing.Point(50, 310);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(200, 40);
            this.buttonUser.Text = "开始自拍";
            this.buttonUser.Press += new System.EventHandler(this.buttonUser_Press);
            // 
            // imageUser
            // 
            this.imageUser.Border = new Smobiler.Core.Controls.Border(1F);
            this.imageUser.BorderColor = System.Drawing.Color.Silver;
            this.imageUser.Location = new System.Drawing.Point(50, 40);
            this.imageUser.Name = "imageUser";
            this.imageUser.ResourcePath = "upload";
            this.imageUser.Size = new System.Drawing.Size(200, 240);
            this.imageUser.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // camera1
            // 
            this.camera1.Name = "camera1";
            this.camera1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.camera1_ImageCaptured);
            // 
            // cameraImg
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.camera1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panTop,
            this.panelContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.cameraImg_KeyDown);
            this.Load += new System.EventHandler(this.cameraImg_Load);
            this.Name = "cameraImg";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panTop;
        private Smobiler.Core.Controls.Panel panNav;
        private Smobiler.Core.Controls.ImageButton imgBtnNav;
        private Smobiler.Core.Controls.Panel paneCenter;
        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.Panel panelContent;
        private Smobiler.Core.Controls.Panel panelCamera;
        private Smobiler.Core.Controls.Button buttonUser;
        private Smobiler.Core.Controls.Image imageUser;
        private Smobiler.Core.Controls.Camera camera1;
    }
}