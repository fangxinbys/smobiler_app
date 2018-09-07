using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HH.Web.captcha
{
    
    public partial class HHVCode : System.Web.UI.Page
    {
        private string GenerateRandomCode()
        {
            string s = String.Empty;
            Random random = new Random();
            for (int i = 0; i <4; i++)
            {
                s += random.Next(10).ToString();
            }
            return s;
        }

        public void ValidateCode()
        {

            int width = 100;
            int height = 26;
            try
            {
                width = Convert.ToInt32(Request.QueryString["w"]);
                height = Convert.ToInt32(Request.QueryString["h"]);
            }
            catch (Exception)
            {
                // Nothing
            }
            try
            {
               
                string checkCode = GenerateRandomCode();
                Session["HHCaptchaImageText"] = checkCode;

                // 从 Session 中读取验证码，并创建图片
               // HH.Common.CaptchaImage ci = new HH.Common.CaptchaImage(checkCode, width, height, "Consolas");
                CaptchaImage.CaptchaImage ci = new CaptchaImage.CaptchaImage(checkCode, width, height, "Consolas");
                // 输出图片
                Response.Clear();
                Response.ContentType = "image/jpeg";

                ci.Image.Save(Response.OutputStream, ImageFormat.Jpeg);

                ci.Dispose();
                Response.End();
                
            }
            catch (Exception ee)
            {
                string ss = ee.Message;
                Response.ContentType = "text/plain";
                Response.Write("请求错误");
                return;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ValidateCode();

            }
        }
    }
}