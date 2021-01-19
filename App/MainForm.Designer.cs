namespace tarkov_settings
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layoutTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SideMenu = new System.Windows.Forms.ToolStrip();
            this.MiscsButton = new System.Windows.Forms.ToolStripButton();
            this.ColorButton = new System.Windows.Forms.ToolStripButton();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.DVLGroupBox = new System.Windows.Forms.GroupBox();
            this.DVLPanel = new System.Windows.Forms.Panel();
            this.DVLLabel = new System.Windows.Forms.Label();
            this.DVLBar = new System.Windows.Forms.TrackBar();
            this.DVLText = new System.Windows.Forms.TextBox();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContrastBar = new System.Windows.Forms.TrackBar();
            this.ContrastText = new System.Windows.Forms.TextBox();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GammaText = new System.Windows.Forms.TextBox();
            this.GammaBar = new System.Windows.Forms.TrackBar();
            this.GammaLabel = new System.Windows.Forms.Label();
            this.layoutTablePanel.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            this.DVLGroupBox.SuspendLayout();
            this.DVLPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVLBar)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutTablePanel
            // 
            this.layoutTablePanel.ColumnCount = 2;
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.37594F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.62406F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.Controls.Add(this.SideMenu, 0, 0);
            this.layoutTablePanel.Controls.Add(this.ColorPanel, 1, 0);
            this.layoutTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTablePanel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutTablePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.layoutTablePanel.Location = new System.Drawing.Point(0, 0);
            this.layoutTablePanel.Name = "layoutTablePanel";
            this.layoutTablePanel.RowCount = 1;
            this.layoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.4669F));
            this.layoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.5331F));
            this.layoutTablePanel.Size = new System.Drawing.Size(734, 326);
            this.layoutTablePanel.TabIndex = 0;
            // 
            // SideMenu
            // 
            this.SideMenu.AutoSize = false;
            this.SideMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SideMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.SideMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiscsButton,
            this.ColorButton});
            this.SideMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.SideMenu.Location = new System.Drawing.Point(0, 5);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(76, 316);
            this.SideMenu.TabIndex = 1;
            this.SideMenu.Text = "colorSettings";
            // 
            // MiscsButton
            // 
            this.MiscsButton.Enabled = false;
            this.MiscsButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiscsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MiscsButton.Image = global::tarkov_settings.Properties.Resources.nikita;
            this.MiscsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MiscsButton.Name = "MiscsButton";
            this.MiscsButton.Size = new System.Drawing.Size(74, 66);
            this.MiscsButton.Text = "Miscs";
            this.MiscsButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.MiscsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ColorButton
            // 
            this.ColorButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorButton.Image = global::tarkov_settings.Properties.Resources.nikita_rainbow;
            this.ColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(74, 66);
            this.ColorButton.Text = "Color";
            this.ColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.DVLGroupBox);
            this.ColorPanel.Controls.Add(this.colorGroupBox);
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel.Location = new System.Drawing.Point(79, 3);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(652, 320);
            this.ColorPanel.TabIndex = 2;
            // 
            // DVLGroupBox
            // 
            this.DVLGroupBox.Controls.Add(this.DVLPanel);
            this.DVLGroupBox.Location = new System.Drawing.Point(499, 9);
            this.DVLGroupBox.Name = "DVLGroupBox";
            this.DVLGroupBox.Size = new System.Drawing.Size(145, 307);
            this.DVLGroupBox.TabIndex = 13;
            this.DVLGroupBox.TabStop = false;
            this.DVLGroupBox.Text = "DVL";
            // 
            // DVLPanel
            // 
            this.DVLPanel.Controls.Add(this.DVLLabel);
            this.DVLPanel.Controls.Add(this.DVLBar);
            this.DVLPanel.Controls.Add(this.DVLText);
            this.DVLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVLPanel.Location = new System.Drawing.Point(3, 18);
            this.DVLPanel.Name = "DVLPanel";
            this.DVLPanel.Size = new System.Drawing.Size(139, 286);
            this.DVLPanel.TabIndex = 0;
            // 
            // DVLLabel
            // 
            this.DVLLabel.AutoSize = true;
            this.DVLLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DVLLabel.Location = new System.Drawing.Point(13, 11);
            this.DVLLabel.Name = "DVLLabel";
            this.DVLLabel.Size = new System.Drawing.Size(119, 28);
            this.DVLLabel.TabIndex = 10;
            this.DVLLabel.Text = "Digital Vibrance\r\n(Saturation)\r\n";
            this.DVLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DVLLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // DVLBar
            // 
            this.DVLBar.Location = new System.Drawing.Point(56, 42);
            this.DVLBar.Maximum = 63;
            this.DVLBar.Name = "DVLBar";
            this.DVLBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DVLBar.Size = new System.Drawing.Size(45, 184);
            this.DVLBar.TabIndex = 9;
            this.DVLBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DVLBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // DVLText
            // 
            this.DVLText.Location = new System.Drawing.Point(46, 232);
            this.DVLText.Name = "DVLText";
            this.DVLText.ReadOnly = true;
            this.DVLText.Size = new System.Drawing.Size(41, 22);
            this.DVLText.TabIndex = 11;
            this.DVLText.Text = "0";
            this.DVLText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.colorGroupBox.Location = new System.Drawing.Point(3, 9);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(490, 307);
            this.colorGroupBox.TabIndex = 12;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 286);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BrightnessBar);
            this.panel1.Controls.Add(this.BrightnessLabel);
            this.panel1.Controls.Add(this.BrightnessText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 89);
            this.panel1.TabIndex = 0;
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(13, 27);
            this.BrightnessBar.Maximum = 100;
            this.BrightnessBar.Minimum = -100;
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(397, 45);
            this.BrightnessBar.TabIndex = 18;
            this.BrightnessBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessBar.Value = 50;
            this.BrightnessBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrightnessLabel.Location = new System.Drawing.Point(20, 10);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(77, 14);
            this.BrightnessLabel.TabIndex = 21;
            this.BrightnessLabel.Text = "Brightness";
            this.BrightnessLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // BrightnessText
            // 
            this.BrightnessText.Location = new System.Drawing.Point(424, 27);
            this.BrightnessText.Name = "BrightnessText";
            this.BrightnessText.ReadOnly = true;
            this.BrightnessText.Size = new System.Drawing.Size(41, 22);
            this.BrightnessText.TabIndex = 24;
            this.BrightnessText.Text = "0.50";
            this.BrightnessText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ContrastBar);
            this.panel2.Controls.Add(this.ContrastText);
            this.panel2.Controls.Add(this.ContrastLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 89);
            this.panel2.TabIndex = 1;
            // 
            // ContrastBar
            // 
            this.ContrastBar.Location = new System.Drawing.Point(13, 39);
            this.ContrastBar.Maximum = 100;
            this.ContrastBar.Minimum = -100;
            this.ContrastBar.Name = "ContrastBar";
            this.ContrastBar.Size = new System.Drawing.Size(397, 45);
            this.ContrastBar.TabIndex = 19;
            this.ContrastBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ContrastBar.Value = 50;
            this.ContrastBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // ContrastText
            // 
            this.ContrastText.Location = new System.Drawing.Point(424, 39);
            this.ContrastText.Name = "ContrastText";
            this.ContrastText.ReadOnly = true;
            this.ContrastText.Size = new System.Drawing.Size(41, 22);
            this.ContrastText.TabIndex = 25;
            this.ContrastText.Text = "0.50";
            this.ContrastText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContrastLabel.Location = new System.Drawing.Point(20, 22);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(63, 14);
            this.ContrastLabel.TabIndex = 22;
            this.ContrastLabel.Text = "Contrast";
            this.ContrastLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GammaText);
            this.panel3.Controls.Add(this.GammaBar);
            this.panel3.Controls.Add(this.GammaLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 90);
            this.panel3.TabIndex = 2;
            // 
            // GammaText
            // 
            this.GammaText.Location = new System.Drawing.Point(424, 40);
            this.GammaText.Name = "GammaText";
            this.GammaText.ReadOnly = true;
            this.GammaText.Size = new System.Drawing.Size(41, 22);
            this.GammaText.TabIndex = 26;
            this.GammaText.Text = "1.00";
            this.GammaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GammaBar
            // 
            this.GammaBar.Location = new System.Drawing.Point(13, 40);
            this.GammaBar.Maximum = 280;
            this.GammaBar.Minimum = 40;
            this.GammaBar.Name = "GammaBar";
            this.GammaBar.Size = new System.Drawing.Size(397, 45);
            this.GammaBar.TabIndex = 20;
            this.GammaBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GammaBar.Value = 100;
            this.GammaBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // GammaLabel
            // 
            this.GammaLabel.AutoSize = true;
            this.GammaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GammaLabel.Location = new System.Drawing.Point(20, 23);
            this.GammaLabel.Name = "GammaLabel";
            this.GammaLabel.Size = new System.Drawing.Size(42, 14);
            this.GammaLabel.TabIndex = 23;
            this.GammaLabel.Text = "Gamma";
            this.GammaLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 326);
            this.Controls.Add(this.layoutTablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tarkov Settings";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.layoutTablePanel.ResumeLayout(false);
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.ColorPanel.ResumeLayout(false);
            this.DVLGroupBox.ResumeLayout(false);
            this.DVLPanel.ResumeLayout(false);
            this.DVLPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVLBar)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel layoutTablePanel;
        private System.Windows.Forms.ToolStrip SideMenu;
        private System.Windows.Forms.ToolStripButton MiscsButton;
        private System.Windows.Forms.ToolStripButton ColorButton;
        private System.Windows.Forms.Panel ColorPanel;
        
        

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.TextBox DVLText;
        private System.Windows.Forms.Label DVLLabel;
        private System.Windows.Forms.TrackBar DVLBar;
        private System.Windows.Forms.TextBox GammaText;
        private System.Windows.Forms.TextBox ContrastText;
        private System.Windows.Forms.TextBox BrightnessText;
        private System.Windows.Forms.Label GammaLabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TrackBar GammaBar;
        private System.Windows.Forms.TrackBar ContrastBar;
        private System.Windows.Forms.TrackBar BrightnessBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox DVLGroupBox;
        private System.Windows.Forms.Panel DVLPanel;
    }
}

