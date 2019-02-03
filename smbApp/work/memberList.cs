using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace smbApp.work
{
    partial class memberList : Smobiler.Core.Controls.MobileForm
    {
        public memberList() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }


        DataTable pageTable;
        private void DataBindMeList()
        {
            pageTable = new DataTable();
            pageTable.Columns.Add("Img");
            pageTable.Columns.Add("Title");
            for(int i = 0; i < 100; i++) { 
            DataRow dr = pageTable.NewRow();
            dr["Img"] = "icon-"+(i+1);
            dr["Title"] = "Title" + (i + 1);
                pageTable.Rows.Add(dr);
            }
            if (pageTable.Rows.Count > 0)
            {
                listViewMember.DataSource = pageTable;
                listViewMember.DataBind();
            }
        }

        private void imgBtnNav_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memberList_Load(object sender, EventArgs e)
        {
            DataBindMeList();
        }
    }
}