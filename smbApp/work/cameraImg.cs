using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace smbApp.work
{
    partial class cameraImg : Smobiler.Core.Controls.MobileForm
    {
        private userInfo.frmUserInfo fWindow;
        public cameraImg(userInfo.frmUserInfo fatherWindow) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            fWindow = fatherWindow;
        }

        private void imgBtnNav_Press(object sender, EventArgs e)
        {
            this.Close();
        }



        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error))
            {
                if (Client.Session["UserModel"] == null) return;
                try
                {
                    string Rs = DateTime.Now.ToString("yyyyMMddHHmmss");
                    e.SaveFile(Rs + ".png");
                    //image1.ResourcePath = "Upload";



                    imageUser.ResourceID = Rs;
                    imageUser.Refresh();

                    Maticsoft.Model.tUsers user = (Maticsoft.Model.tUsers)Client.Session["UserModel"];
                    user.userImage = Rs + ".png";
                    Maticsoft.BLL.tUsers bll = new Maticsoft.BLL.tUsers();
                    bll.Update(user);

                    if (fWindow == null) return;
                    fWindow.loadUserImg();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUser_Press(object sender, EventArgs e)
        {

            camera1.GetPhoto();

        }

        private void cameraImg_KeyDown(object sender, KeyDownEventArgs e)
        {
            this.Close();
        }

        private void cameraImg_Load(object sender, EventArgs e)
        {
            if (Client.Session["UserModel"] == null) return;
            Maticsoft.Model.tUsers user = (Maticsoft.Model.tUsers)Client.Session["UserModel"];
            if (user.userImage == null) return;
            imageUser.ResourceID = user.userImage.Replace(".png","");
            imageUser.Refresh();

        }
    }
}