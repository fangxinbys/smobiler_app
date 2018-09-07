using FineUIPro;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Code
{
    public class web
    {
     
      
        public void SetWebHeader(Page page)
        {
            Maticsoft.BLL.tSet bll = new Maticsoft.BLL.tSet();
            Maticsoft.Model.tSet model = bll.GetModel(1);
            HtmlMeta keywords = new HtmlMeta();
            keywords.Name = "keywords";
            keywords.Content = model.KeyWords;
            page.Header.Controls.Add(keywords);
            HtmlMeta description = new HtmlMeta();
            description.Name = "description";
            description.Content = model.Description;
            page.Header.Controls.Add(description);
        }


        public void AddStyle(Page page, int index)
        {
            Literal li = new Literal();

            li.Text = "<style type=\"text/css\"> </style>";
            page.Header.Controls.AddAt(index, li);
        }

      

 

    }
}