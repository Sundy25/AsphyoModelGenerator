namespace View.Forms {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnBar = new MetroFramework.Controls.MetroPanel();
            this.cboDatabases = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnChangeConnection = new MetroFramework.Controls.MetroButton();
            this.cboLanguages = new MetroFramework.Controls.MetroComboBox();
            this.lbDatabase = new MetroFramework.Controls.MetroLabel();
            this.pnLeft = new MetroFramework.Controls.MetroPanel();
            this.pnTree = new MetroFramework.Controls.MetroPanel();
            this.pnLabelTree = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pnMain = new MetroFramework.Controls.MetroPanel();
            this.chUseAsphyo = new MetroFramework.Controls.MetroCheckBox();
            this.lbGenerating = new MetroFramework.Controls.MetroLabel();
            this.spGenerating = new MetroFramework.Controls.MetroProgressSpinner();
            this.lbRoute = new MetroFramework.Controls.MetroLabel();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbGenerationOption = new MetroFramework.Controls.MetroLabel();
            this.rbtnGenerateAll = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnGenerateOnlyModels = new MetroFramework.Controls.MetroRadioButton();
            this.btnSavePath = new MetroFramework.Controls.MetroButton();
            this.pnBar.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnLabelTree.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBar
            // 
            this.pnBar.Controls.Add(this.cboDatabases);
            this.pnBar.Controls.Add(this.metroLabel2);
            this.pnBar.Controls.Add(this.btnChangeConnection);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.ForeColor = System.Drawing.Color.White;
            this.pnBar.HorizontalScrollbarBarColor = true;
            this.pnBar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnBar.HorizontalScrollbarSize = 10;
            this.pnBar.Location = new System.Drawing.Point(20, 60);
            this.pnBar.Margin = new System.Windows.Forms.Padding(5);
            this.pnBar.Name = "pnBar";
            this.pnBar.Padding = new System.Windows.Forms.Padding(5);
            this.pnBar.Size = new System.Drawing.Size(1148, 64);
            this.pnBar.TabIndex = 0;
            this.pnBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnBar.VerticalScrollbarBarColor = true;
            this.pnBar.VerticalScrollbarHighlightOnWheel = false;
            this.pnBar.VerticalScrollbarSize = 10;
            // 
            // cboDatabases
            // 
            this.cboDatabases.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDatabases.ForeColor = System.Drawing.Color.White;
            this.cboDatabases.FormattingEnabled = true;
            this.cboDatabases.ItemHeight = 23;
            this.cboDatabases.Location = new System.Drawing.Point(128, 18);
            this.cboDatabases.Name = "cboDatabases";
            this.cboDatabases.Size = new System.Drawing.Size(192, 29);
            this.cboDatabases.TabIndex = 14;
            this.cboDatabases.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboDatabases.UseCustomForeColor = true;
            this.cboDatabases.UseSelectable = true;
            this.cboDatabases.SelectionChangeCommitted += new System.EventHandler(this.cboDatabases_SelectionChangeCommitted);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(3, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Select a Database:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // btnChangeConnection
            // 
            this.btnChangeConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeConnection.ForeColor = System.Drawing.Color.White;
            this.btnChangeConnection.Location = new System.Drawing.Point(973, 18);
            this.btnChangeConnection.Name = "btnChangeConnection";
            this.btnChangeConnection.Size = new System.Drawing.Size(147, 29);
            this.btnChangeConnection.TabIndex = 5;
            this.btnChangeConnection.Text = "Change Connection";
            this.btnChangeConnection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnChangeConnection.UseCustomForeColor = true;
            this.btnChangeConnection.UseSelectable = true;
            this.btnChangeConnection.Click += new System.EventHandler(this.btnChangeConnection_Click);
            // 
            // cboLanguages
            // 
            this.cboLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLanguages.ForeColor = System.Drawing.Color.White;
            this.cboLanguages.FormattingEnabled = true;
            this.cboLanguages.ItemHeight = 23;
            this.cboLanguages.Location = new System.Drawing.Point(665, 43);
            this.cboLanguages.Name = "cboLanguages";
            this.cboLanguages.Size = new System.Drawing.Size(192, 29);
            this.cboLanguages.TabIndex = 3;
            this.cboLanguages.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cboLanguages.UseCustomForeColor = true;
            this.cboLanguages.UseSelectable = true;
            // 
            // lbDatabase
            // 
            this.lbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.ForeColor = System.Drawing.Color.White;
            this.lbDatabase.Location = new System.Drawing.Point(545, 43);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(114, 19);
            this.lbDatabase.TabIndex = 2;
            this.lbDatabase.Text = "Output Language:";
            this.lbDatabase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbDatabase.UseCustomForeColor = true;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.pnTree);
            this.pnLeft.Controls.Add(this.pnLabelTree);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.ForeColor = System.Drawing.Color.White;
            this.pnLeft.HorizontalScrollbarBarColor = true;
            this.pnLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLeft.HorizontalScrollbarSize = 10;
            this.pnLeft.Location = new System.Drawing.Point(20, 124);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(5);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Padding = new System.Windows.Forms.Padding(5);
            this.pnLeft.Size = new System.Drawing.Size(261, 383);
            this.pnLeft.TabIndex = 1;
            this.pnLeft.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnLeft.UseCustomForeColor = true;
            this.pnLeft.VerticalScrollbarBarColor = true;
            this.pnLeft.VerticalScrollbarHighlightOnWheel = false;
            this.pnLeft.VerticalScrollbarSize = 10;
            // 
            // pnTree
            // 
            this.pnTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTree.ForeColor = System.Drawing.Color.White;
            this.pnTree.HorizontalScrollbarBarColor = true;
            this.pnTree.HorizontalScrollbarHighlightOnWheel = false;
            this.pnTree.HorizontalScrollbarSize = 10;
            this.pnTree.Location = new System.Drawing.Point(5, 30);
            this.pnTree.Name = "pnTree";
            this.pnTree.Size = new System.Drawing.Size(251, 348);
            this.pnTree.TabIndex = 1;
            this.pnTree.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnTree.VerticalScrollbarBarColor = true;
            this.pnTree.VerticalScrollbarHighlightOnWheel = false;
            this.pnTree.VerticalScrollbarSize = 10;
            // 
            // pnLabelTree
            // 
            this.pnLabelTree.Controls.Add(this.metroLabel4);
            this.pnLabelTree.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLabelTree.ForeColor = System.Drawing.Color.White;
            this.pnLabelTree.HorizontalScrollbarBarColor = true;
            this.pnLabelTree.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLabelTree.HorizontalScrollbarSize = 10;
            this.pnLabelTree.Location = new System.Drawing.Point(5, 5);
            this.pnLabelTree.Name = "pnLabelTree";
            this.pnLabelTree.Size = new System.Drawing.Size(251, 25);
            this.pnLabelTree.TabIndex = 7;
            this.pnLabelTree.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnLabelTree.VerticalScrollbarBarColor = true;
            this.pnLabelTree.VerticalScrollbarHighlightOnWheel = false;
            this.pnLabelTree.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(0, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(178, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Select the tables to generate:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // pnMain
            // 
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.chUseAsphyo);
            this.pnMain.Controls.Add(this.lbGenerating);
            this.pnMain.Controls.Add(this.cboLanguages);
            this.pnMain.Controls.Add(this.spGenerating);
            this.pnMain.Controls.Add(this.lbDatabase);
            this.pnMain.Controls.Add(this.lbRoute);
            this.pnMain.Controls.Add(this.btnGenerate);
            this.pnMain.Controls.Add(this.metroLabel1);
            this.pnMain.Controls.Add(this.lbGenerationOption);
            this.pnMain.Controls.Add(this.rbtnGenerateAll);
            this.pnMain.Controls.Add(this.rbtnGenerateOnlyModels);
            this.pnMain.Controls.Add(this.btnSavePath);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.HorizontalScrollbarBarColor = true;
            this.pnMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMain.HorizontalScrollbarSize = 10;
            this.pnMain.Location = new System.Drawing.Point(281, 124);
            this.pnMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnMain.Name = "pnMain";
            this.pnMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnMain.Size = new System.Drawing.Size(887, 383);
            this.pnMain.TabIndex = 2;
            this.pnMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnMain.VerticalScrollbarBarColor = true;
            this.pnMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnMain.VerticalScrollbarSize = 10;
            // 
            // chUseAsphyo
            // 
            this.chUseAsphyo.AutoSize = true;
            this.chUseAsphyo.Checked = true;
            this.chUseAsphyo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chUseAsphyo.ForeColor = System.Drawing.Color.White;
            this.chUseAsphyo.Location = new System.Drawing.Point(59, 121);
            this.chUseAsphyo.Name = "chUseAsphyo";
            this.chUseAsphyo.Size = new System.Drawing.Size(196, 15);
            this.chUseAsphyo.TabIndex = 12;
            this.chUseAsphyo.Text = "Generate with Asphyo references";
            this.chUseAsphyo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chUseAsphyo.UseCustomForeColor = true;
            this.chUseAsphyo.UseSelectable = true;
            // 
            // lbGenerating
            // 
            this.lbGenerating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGenerating.AutoSize = true;
            this.lbGenerating.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbGenerating.ForeColor = System.Drawing.Color.White;
            this.lbGenerating.Location = new System.Drawing.Point(723, 306);
            this.lbGenerating.Name = "lbGenerating";
            this.lbGenerating.Size = new System.Drawing.Size(71, 15);
            this.lbGenerating.TabIndex = 11;
            this.lbGenerating.Text = "Generating...";
            this.lbGenerating.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbGenerating.UseCustomForeColor = true;
            this.lbGenerating.Visible = false;
            // 
            // spGenerating
            // 
            this.spGenerating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spGenerating.Location = new System.Drawing.Point(807, 292);
            this.spGenerating.Maximum = 100;
            this.spGenerating.Name = "spGenerating";
            this.spGenerating.Size = new System.Drawing.Size(50, 46);
            this.spGenerating.TabIndex = 10;
            this.spGenerating.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.spGenerating.UseSelectable = true;
            this.spGenerating.Visible = false;
            // 
            // lbRoute
            // 
            this.lbRoute.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbRoute.ForeColor = System.Drawing.Color.White;
            this.lbRoute.Location = new System.Drawing.Point(59, 263);
            this.lbRoute.Name = "lbRoute";
            this.lbRoute.Size = new System.Drawing.Size(203, 19);
            this.lbRoute.TabIndex = 9;
            this.lbRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoute.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbRoute.UseCustomForeColor = true;
            this.lbRoute.WrapToLine = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(5, 347);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(875, 29);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate!";
            this.btnGenerate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGenerate.UseCustomForeColor = true;
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(26, 190);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Select Save Path";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lbGenerationOption
            // 
            this.lbGenerationOption.AutoSize = true;
            this.lbGenerationOption.ForeColor = System.Drawing.Color.White;
            this.lbGenerationOption.Location = new System.Drawing.Point(27, 10);
            this.lbGenerationOption.Name = "lbGenerationOption";
            this.lbGenerationOption.Size = new System.Drawing.Size(115, 19);
            this.lbGenerationOption.TabIndex = 6;
            this.lbGenerationOption.Text = "Generation option";
            this.lbGenerationOption.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbGenerationOption.UseCustomForeColor = true;
            // 
            // rbtnGenerateAll
            // 
            this.rbtnGenerateAll.AutoSize = true;
            this.rbtnGenerateAll.ForeColor = System.Drawing.Color.White;
            this.rbtnGenerateAll.Location = new System.Drawing.Point(59, 47);
            this.rbtnGenerateAll.Name = "rbtnGenerateAll";
            this.rbtnGenerateAll.Size = new System.Drawing.Size(236, 15);
            this.rbtnGenerateAll.TabIndex = 6;
            this.rbtnGenerateAll.Text = "Generate Database Function and Models";
            this.rbtnGenerateAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbtnGenerateAll.UseCustomForeColor = true;
            this.rbtnGenerateAll.UseSelectable = true;
            // 
            // rbtnGenerateOnlyModels
            // 
            this.rbtnGenerateOnlyModels.AutoSize = true;
            this.rbtnGenerateOnlyModels.ForeColor = System.Drawing.Color.White;
            this.rbtnGenerateOnlyModels.Location = new System.Drawing.Point(59, 68);
            this.rbtnGenerateOnlyModels.Name = "rbtnGenerateOnlyModels";
            this.rbtnGenerateOnlyModels.Size = new System.Drawing.Size(140, 15);
            this.rbtnGenerateOnlyModels.TabIndex = 5;
            this.rbtnGenerateOnlyModels.Text = "Generate Only Models";
            this.rbtnGenerateOnlyModels.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbtnGenerateOnlyModels.UseCustomForeColor = true;
            this.rbtnGenerateOnlyModels.UseSelectable = true;
            // 
            // btnSavePath
            // 
            this.btnSavePath.ForeColor = System.Drawing.Color.White;
            this.btnSavePath.Location = new System.Drawing.Point(59, 221);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(203, 30);
            this.btnSavePath.TabIndex = 2;
            this.btnSavePath.Text = "Save Path...";
            this.btnSavePath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSavePath.UseCustomForeColor = true;
            this.btnSavePath.UseSelectable = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 527);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(909, 440);
            this.Name = "Main";
            this.Text = "Asphyo Class Generator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnBar.ResumeLayout(false);
            this.pnBar.PerformLayout();
            this.pnLeft.ResumeLayout(false);
            this.pnLabelTree.ResumeLayout(false);
            this.pnLabelTree.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnBar;
        private MetroFramework.Controls.MetroComboBox cboLanguages;
        private MetroFramework.Controls.MetroLabel lbDatabase;
        private MetroFramework.Controls.MetroPanel pnMain;
        private MetroFramework.Controls.MetroButton btnChangeConnection;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbGenerationOption;
        private MetroFramework.Controls.MetroRadioButton rbtnGenerateAll;
        private MetroFramework.Controls.MetroRadioButton rbtnGenerateOnlyModels;
        private MetroFramework.Controls.MetroButton btnSavePath;
        private MetroFramework.Controls.MetroLabel lbRoute;
        private MetroFramework.Controls.MetroPanel pnTree;
        private MetroFramework.Controls.MetroProgressSpinner spGenerating;
        private MetroFramework.Controls.MetroLabel lbGenerating;
        private MetroFramework.Controls.MetroCheckBox chUseAsphyo;
        private MetroFramework.Controls.MetroComboBox cboDatabases;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel pnLeft;
        private MetroFramework.Controls.MetroPanel pnLabelTree;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

