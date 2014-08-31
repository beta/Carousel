namespace Carousel
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.checkRemember = new System.Windows.Forms.CheckBox();
            this.checkAuto = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonConnect.Location = new System.Drawing.Point(12, 117);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(290, 39);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textUsername
            // 
            this.textUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textUsername.Location = new System.Drawing.Point(65, 6);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(237, 39);
            this.textUsername.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(68, 31);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "账号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "密码:";
            // 
            // textPassword
            // 
            this.textPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassword.Location = new System.Drawing.Point(65, 35);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '●';
            this.textPassword.Size = new System.Drawing.Size(237, 39);
            this.textPassword.TabIndex = 1;
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.Location = new System.Drawing.Point(65, 64);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(190, 35);
            this.checkRemember.TabIndex = 3;
            this.checkRemember.Text = "记住登录凭据";
            this.checkRemember.UseVisualStyleBackColor = true;
            this.checkRemember.CheckedChanged += new System.EventHandler(this.checkRemember_CheckedChanged);
            // 
            // checkAuto
            // 
            this.checkAuto.AutoSize = true;
            this.checkAuto.Location = new System.Drawing.Point(65, 91);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.Size = new System.Drawing.Size(142, 35);
            this.checkAuto.TabIndex = 4;
            this.checkAuto.Text = "自动登录";
            this.checkAuto.UseVisualStyleBackColor = true;
            this.checkAuto.CheckedChanged += new System.EventHandler(this.checkAuto_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(2222, 111);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 57);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "Carousel";
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Carousel - 未连接";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseUp);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.notifyMenu.Name = "contextMenuStrip1";
            this.notifyMenu.Size = new System.Drawing.Size(137, 82);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 117);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(290, 39);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "断开连接";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Visible = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(314, 169);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkAuto);
            this.Controls.Add(this.checkRemember);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.buttonConnect);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carousel";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.CheckBox checkRemember;
        private System.Windows.Forms.CheckBox checkAuto;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

