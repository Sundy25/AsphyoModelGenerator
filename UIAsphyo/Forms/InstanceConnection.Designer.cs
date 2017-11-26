namespace View.Forms {
    partial class InstanceConnection {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstanceConnection));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboEngine = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SpinnerConnect = new MetroFramework.Controls.MetroProgressSpinner();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.cboAuthentication = new MetroFramework.Controls.MetroComboBox();
            this.txtServerInstance = new MetroFramework.Controls.MetroTextBox();
            this.lbPassword = new MetroFramework.Controls.MetroLabel();
            this.lbLogin = new MetroFramework.Controls.MetroLabel();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbServerName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroPanel1.Controls.Add(this.txtPort);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cboEngine);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.SpinnerConnect);
            this.metroPanel1.Controls.Add(this.txtPassword);
            this.metroPanel1.Controls.Add(this.txtLogin);
            this.metroPanel1.Controls.Add(this.cboAuthentication);
            this.metroPanel1.Controls.Add(this.txtServerInstance);
            this.metroPanel1.Controls.Add(this.lbPassword);
            this.metroPanel1.Controls.Add(this.lbLogin);
            this.metroPanel1.Controls.Add(this.btnConnect);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.lbServerName);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.ForeColor = System.Drawing.Color.White;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(529, 250);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(57, 2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.Enabled = false;
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(416, 59);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(75, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPort.UseCustomForeColor = true;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(373, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Port:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // cboEngine
            // 
            this.cboEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cboEngine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboEngine.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboEngine.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cboEngine.ForeColor = System.Drawing.Color.White;
            this.cboEngine.FormattingEnabled = true;
            this.cboEngine.ItemHeight = 19;
            this.cboEngine.Location = new System.Drawing.Point(176, 16);
            this.cboEngine.Name = "cboEngine";
            this.cboEngine.Size = new System.Drawing.Size(315, 25);
            this.cboEngine.TabIndex = 1;
            this.cboEngine.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboEngine.UseCustomForeColor = true;
            this.cboEngine.UseSelectable = true;
            this.cboEngine.SelectionChangeCommitted += new System.EventHandler(this.cboEngine_SelectionChangeCommitted);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(13, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Database engine:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // SpinnerConnect
            // 
            this.SpinnerConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SpinnerConnect.Location = new System.Drawing.Point(494, 211);
            this.SpinnerConnect.Maximum = 100;
            this.SpinnerConnect.Name = "SpinnerConnect";
            this.SpinnerConnect.Size = new System.Drawing.Size(27, 21);
            this.SpinnerConnect.TabIndex = 24;
            this.SpinnerConnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SpinnerConnect.UseCustomForeColor = true;
            this.SpinnerConnect.UseSelectable = true;
            this.SpinnerConnect.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Enabled = false;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(174, 180);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(221, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = null;
            this.txtLogin.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogin.CustomButton.TabIndex = 1;
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = false;
            this.txtLogin.Enabled = false;
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Lines = new string[0];
            this.txtLogin.Location = new System.Drawing.Point(174, 151);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(221, 20);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLogin.UseCustomForeColor = true;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboAuthentication
            // 
            this.cboAuthentication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cboAuthentication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAuthentication.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboAuthentication.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cboAuthentication.ForeColor = System.Drawing.Color.White;
            this.cboAuthentication.FormattingEnabled = true;
            this.cboAuthentication.ItemHeight = 19;
            this.cboAuthentication.Location = new System.Drawing.Point(176, 93);
            this.cboAuthentication.Name = "cboAuthentication";
            this.cboAuthentication.Size = new System.Drawing.Size(315, 25);
            this.cboAuthentication.TabIndex = 18;
            this.cboAuthentication.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboAuthentication.UseCustomForeColor = true;
            this.cboAuthentication.UseSelectable = true;
            this.cboAuthentication.SelectionChangeCommitted += new System.EventHandler(this.cboAuthentication_SelectionChangeCommitted);
            // 
            // txtServerInstance
            // 
            this.txtServerInstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // 
            // 
            this.txtServerInstance.CustomButton.Image = null;
            this.txtServerInstance.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtServerInstance.CustomButton.Name = "";
            this.txtServerInstance.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtServerInstance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerInstance.CustomButton.TabIndex = 1;
            this.txtServerInstance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerInstance.CustomButton.UseSelectable = true;
            this.txtServerInstance.CustomButton.Visible = false;
            this.txtServerInstance.ForeColor = System.Drawing.Color.White;
            this.txtServerInstance.Lines = new string[0];
            this.txtServerInstance.Location = new System.Drawing.Point(176, 58);
            this.txtServerInstance.MaxLength = 32767;
            this.txtServerInstance.Name = "txtServerInstance";
            this.txtServerInstance.PasswordChar = '\0';
            this.txtServerInstance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerInstance.SelectedText = "";
            this.txtServerInstance.SelectionLength = 0;
            this.txtServerInstance.SelectionStart = 0;
            this.txtServerInstance.ShortcutsEnabled = true;
            this.txtServerInstance.Size = new System.Drawing.Size(177, 21);
            this.txtServerInstance.TabIndex = 2;
            this.txtServerInstance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtServerInstance.UseCustomForeColor = true;
            this.txtServerInstance.UseSelectable = true;
            this.txtServerInstance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerInstance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbPassword.Enabled = false;
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(78, 180);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 19);
            this.lbPassword.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbPassword.TabIndex = 13;
            this.lbPassword.Text = "Password:";
            this.lbPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbPassword.UseCustomForeColor = true;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbLogin.Enabled = false;
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(78, 151);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(44, 19);
            this.lbLogin.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "Login:";
            this.lbLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbLogin.UseCustomForeColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(416, 211);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnConnect.UseCustomForeColor = true;
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(320, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(13, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Authentication:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // lbServerName
            // 
            this.lbServerName.AutoSize = true;
            this.lbServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbServerName.ForeColor = System.Drawing.Color.White;
            this.lbServerName.Location = new System.Drawing.Point(13, 60);
            this.lbServerName.Name = "lbServerName";
            this.lbServerName.Size = new System.Drawing.Size(87, 19);
            this.lbServerName.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbServerName.TabIndex = 2;
            this.lbServerName.Text = "Server name:";
            this.lbServerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbServerName.UseCustomForeColor = true;
            // 
            // InstanceConnection
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(569, 330);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstanceConnection";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Connect to a Server";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbServerName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lbPassword;
        private MetroFramework.Controls.MetroLabel lbLogin;
        private MetroFramework.Controls.MetroComboBox cboAuthentication;
        private MetroFramework.Controls.MetroTextBox txtServerInstance;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroProgressSpinner SpinnerConnect;
        private MetroFramework.Controls.MetroComboBox cboEngine;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}