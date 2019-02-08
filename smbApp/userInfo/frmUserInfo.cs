using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace smbApp.userInfo
{
    partial class frmUserInfo : Smobiler.Core.Controls.MobileForm
    {
        public frmUserInfo() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }



      
        private void btnExit_Press(object sender, EventArgs e)
        {

            MessageBox.Show("是否注销当前用户？", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
            {
                if (args.Result == ShowResult.OK)
                {
                    Client.ReStart();
                  
                }
            });
        }

        private void imgBtnNav_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgBtnUser_Press(object sender, EventArgs e)
        {
            this.popListTest.ShowDialog();
        }
    }
}