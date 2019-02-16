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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.panel_top = new Smobiler.Core.Controls.Panel();
            this.btnLogin = new Smobiler.Core.Controls.Button();
            this.panelRg = new Smobiler.Core.Controls.Panel();
            this.btnReg = new Smobiler.Core.Controls.Button();
            this.panelPwd = new Smobiler.Core.Controls.Panel();
            this.btnPwd = new Smobiler.Core.Controls.Button();
            this.fUser = new Smobiler.Core.Controls.FontIcon();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.fPwd = new Smobiler.Core.Controls.FontIcon();
            this.txtPassWord = new Smobiler.Core.Controls.TextBox();
            this.checkRemb = new Smobiler.Core.Controls.CheckBox();
            this.labLogin = new Smobiler.Core.Controls.Label();
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnLogin,
            this.panelRg,
            this.panelPwd,
            this.fUser,
            this.txtUserName,
            this.fPwd,
            this.txtPassWord,
            this.checkRemb,
            this.labLogin});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(68, 222);
            this.panel2.Name = "panel2";
            this.panel2.Scrollable = true;
            this.panel2.Size = new System.Drawing.Size(300, 370);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Maroon;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(12, 53);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(0, 130);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FontSize = 18F;
            this.btnLogin.Location = new System.Drawing.Point(17, 277);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 45);
            this.btnLogin.Text = "登录";
            this.btnLogin.Press += new System.EventHandler(this.btnLogin_Press);
            // 
            // panelRg
            // 
            this.panelRg.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnReg});
            this.panelRg.Location = new System.Drawing.Point(17, 330);
            this.panelRg.Name = "panelRg";
            this.panelRg.Size = new System.Drawing.Size(106, 25);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Transparent;
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.ForeColor = System.Drawing.Color.Silver;
            this.btnReg.Location = new System.Drawing.Point(6, 0);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(100, 30);
            this.btnReg.Text = "没有账号？立即注册";
            this.btnReg.Press += new System.EventHandler(this.btnReg_Press);
            // 
            // panelPwd
            // 
            this.panelPwd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnPwd});
            this.panelPwd.Location = new System.Drawing.Point(154, 330);
            this.panelPwd.Name = "panelPwd";
            this.panelPwd.Size = new System.Drawing.Size(106, 25);
            // 
            // btnPwd
            // 
            this.btnPwd.BackColor = System.Drawing.Color.Transparent;
            this.btnPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPwd.ForeColor = System.Drawing.Color.Silver;
            this.btnPwd.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnPwd.Location = new System.Drawing.Point(6, 0);
            this.btnPwd.Name = "btnPwd";
            this.btnPwd.Size = new System.Drawing.Size(100, 30);
            this.btnPwd.Text = "？忘记密码";
            // 
            // fUser
            // 
            this.fUser.ForeColor = System.Drawing.Color.Maroon;
            this.fUser.Location = new System.Drawing.Point(28, 117);
            this.fUser.Name = "fUser";
            this.fUser.ResourceID = "user";
            this.fUser.Size = new System.Drawing.Size(30, 30);
            // 
            // txtUserName
            // 
            this.txtUserName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.Location = new System.Drawing.Point(72, 117);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtUserName.Size = new System.Drawing.Size(195, 30);
            this.txtUserName.WaterMarkText = "请输入手机号码";
            // 
            // fPwd
            // 
            this.fPwd.ForeColor = System.Drawing.Color.Maroon;
            this.fPwd.Location = new System.Drawing.Point(28, 163);
            this.fPwd.Name = "fPwd";
            this.fPwd.ResourceID = "unlock-alt";
            this.fPwd.Size = new System.Drawing.Size(30, 30);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPassWord.BorderRadius = 10;
            this.txtPassWord.Location = new System.Drawing.Point(72, 156);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtPassWord.SecurityMode = true;
            this.txtPassWord.Size = new System.Drawing.Size(195, 30);
            this.txtPassWord.WaterMarkText = "请输入登录密码";
            // 
            // checkRemb
            // 
            this.checkRemb.Location = new System.Drawing.Point(28, 205);
            this.checkRemb.Name = "checkRemb";
            this.checkRemb.Size = new System.Drawing.Size(30, 30);
            this.checkRemb.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkRemb.TintColor = System.Drawing.Color.Maroon;
            // 
            // labLogin
            // 
            this.labLogin.Location = new System.Drawing.Point(72, 205);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(100, 30);
            this.labLogin.Text = "是否记住登录密码";
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel_top,
            this.panel2});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.Login_KeyDown);
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.Name = "Login";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel panel_top;
        private Smobiler.Core.Controls.Button btnLogin;
        private Smobiler.Core.Controls.Panel panelRg;
        private Smobiler.Core.Controls.Button btnReg;
        private Smobiler.Core.Controls.Panel panelPwd;
        private Smobiler.Core.Controls.Button btnPwd;
        private Smobiler.Core.Controls.FontIcon fUser;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.FontIcon fPwd;
        private Smobiler.Core.Controls.TextBox txtPassWord;
        private Smobiler.Core.Controls.CheckBox checkRemb;
        private Smobiler.Core.Controls.Label labLogin;
    }
}