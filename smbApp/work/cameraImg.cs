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
        public cameraImg() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void imgBtnNav_Press(object sender, EventArgs e)
        {
            this.Close();
        }



        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error))
            {
                try
                {
                    string Rs = DateTime.Now.ToString("yyyyMMddHHmmss");
                    e.SaveFile(Rs + ".png");
                    //image1.ResourcePath = "Upload";
                    imageUser.ResourceID = Rs;
                    imageUser.Refresh();
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
    }
}