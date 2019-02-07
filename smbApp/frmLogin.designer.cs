using Smobiler.Core;

namespace smbApp
{
    partial class Login : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel_top = new Smobiler.Core.Controls.Panel();
            this.imgLogin = new Smobiler.Core.Controls.Image();
            this.panel_content = new Smobiler.Core.Controls.Panel();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.txtPassWord = new Smobiler.Core.Controls.TextBox();
            this.btnLogin = new Smobiler.Core.Controls.Button();
            this.fUser = new Smobiler.Core.Controls.FontIcon();
            this.fPwd = new Smobiler.Core.Controls.FontIcon();
            this.checkRemb = new Smobiler.Core.Controls.CheckBox();
            this.labLogin = new Smobiler.Core.Controls.Label();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.White;
            this.panel_top.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgLogin});
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(12, 53);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(300, 170);
            // 
            // imgLogin
            // 
            this.imgLogin.Location = new System.Drawing.Point(100, 50);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.ResourceID = "logon.png";
            this.imgLogin.Size = new System.Drawing.Size(100, 100);
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.White;
            this.panel_content.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtUserName,
            this.txtPassWord,
            this.btnLogin,
            this.fUser,
            this.fPwd,
            this.checkRemb,
            this.labLogin});
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(12, 53);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(300, 330);
            // 
            // txtUserName
            // 
            this.txtUserName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.Location = new System.Drawing.Point(75, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtUserName.Size = new System.Drawing.Size(190, 30);
            this.txtUserName.WaterMarkText = "+86 请输入手机号码";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPassWord.BorderRadius = 10;
            this.txtPassWord.Location = new System.Drawing.Point(75, 71);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtPassWord.SecurityMode = true;
            this.txtPassWord.Size = new System.Drawing.Size(190, 30);
            this.txtPassWord.WaterMarkText = "请输入6-12位密码";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FontSize = 18F;
            this.btnLogin.Location = new System.Drawing.Point(27, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(238, 44);
            this.btnLogin.Text = "登录";
            this.btnLogin.Press += new System.EventHandler(this.btnLogin_Press);
            // 
            // fUser
            // 
            this.fUser.ForeColor = System.Drawing.Color.Maroon;
            this.fUser.Location = new System.Drawing.Point(27, 26);
            this.fUser.Name = "fUser";
            this.fUser.ResourceID = "user";
            this.fUser.Size = new System.Drawing.Size(30, 30);
            // 
            // fPwd
            // 
            this.fPwd.ForeColor = System.Drawing.Color.Maroon;
            this.fPwd.Location = new System.Drawing.Point(27, 71);
            this.fPwd.Name = "fPwd";
            this.fPwd.ResourceID = "unlock-alt";
            this.fPwd.Size = new System.Drawing.Size(30, 30);
            // 
            // checkRemb
            // 
            this.checkRemb.Checked = true;
            this.checkRemb.Location = new System.Drawing.Point(27, 118);
            this.checkRemb.Name = "checkRemb";
            this.checkRemb.Size = new System.Drawing.Size(30, 30);
            this.checkRemb.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkRemb.TintColor = System.Drawing.Color.Maroon;
            // 
            // labLogin
            // 
            this.labLogin.Location = new System.Drawing.Point(75, 118);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(100, 30);
            this.labLogin.Text = "是否记住登录密码";
            // 
            // Login
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel_top,
            this.panel_content});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.Login_KeyDown);
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.Name = "Login";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel_top;
        private Smobiler.Core.Controls.Panel panel_content;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.TextBox txtPassWord;
        private Smobiler.Core.Controls.Button btnLogin;
        private Smobiler.Core.Controls.Image imgLogin;
        private Smobiler.Core.Controls.FontIcon fUser;
        private Smobiler.Core.Controls.FontIcon fPwd;
        private Smobiler.Core.Controls.CheckBox checkRemb;
        private Smobiler.Core.Controls.Label labLogin;
    }
}