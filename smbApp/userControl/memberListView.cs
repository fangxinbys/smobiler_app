using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
 
using System.Windows.Forms;

namespace smbApp.userControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]

   
    partial class memberListView : Smobiler.Core.Controls.MobileUserControl
    {
         
 
        public memberListView() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
     
        private void panelList_Press(object sender, EventArgs e)
        {
           string Rst = this.imageList.BindDisplayValue.ToString();


           ((work.memberList)Form).UpdateTitle(Rst);

        }
        
    }
}