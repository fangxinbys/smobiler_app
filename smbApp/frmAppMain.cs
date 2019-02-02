using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace smbApp
{
    partial class frmAppMain : Smobiler.Core.Controls.MobileForm
    {
        public frmAppMain() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void imgBtnNav_Press(object sender, EventArgs e)
        {
            userInfo.frmUserInfo frm = new userInfo.frmUserInfo();
            Show(frm);

        }
    }
}