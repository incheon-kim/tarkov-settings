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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.GammaText = new System.Windows.Forms.TextBox();
            this.ContrastText = new System.Windows.Forms.TextBox();
            this.BrightnessText = new System.Windows.Forms.TextBox();
            this.GammaLabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.GammaBar = new System.Windows.Forms.TrackBar();
            this.ContrastBar = new System.Windows.Forms.TrackBar();
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.DVLText = new System.Windows.Forms.TextBox();
            this.DVLLabel = new System.Windows.Forms.Label();
            this.DVLBar = new System.Windows.Forms.TrackBar();
            this.layoutTablePanel.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVLBar)).BeginInit();
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
            this.layoutTablePanel.Size = new System.Drawing.Size(665, 233);
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
            this.SideMenu.Size = new System.Drawing.Size(69, 223);
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
            this.MiscsButton.Size = new System.Drawing.Size(67, 66);
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
            this.ColorButton.Size = new System.Drawing.Size(67, 66);
            this.ColorButton.Text = "Color";
            this.ColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.colorGroupBox);
            this.ColorPanel.Controls.Add(this.DVLText);
            this.ColorPanel.Controls.Add(this.DVLLabel);
            this.ColorPanel.Controls.Add(this.DVLBar);
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel.Location = new System.Drawing.Point(72, 3);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(590, 227);
            this.ColorPanel.TabIndex = 2;
            this.ColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorPanel_Paint);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.GammaText);
            this.colorGroupBox.Controls.Add(this.ContrastText);
            this.colorGroupBox.Controls.Add(this.BrightnessText);
            this.colorGroupBox.Controls.Add(this.GammaLabel);
            this.colorGroupBox.Controls.Add(this.ContrastLabel);
            this.colorGroupBox.Controls.Add(this.BrightnessLabel);
            this.colorGroupBox.Controls.Add(this.GammaBar);
            this.colorGroupBox.Controls.Add(this.ContrastBar);
            this.colorGroupBox.Controls.Add(this.BrightnessBar);
            this.colorGroupBox.Location = new System.Drawing.Point(12, 3);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(468, 207);
            this.colorGroupBox.TabIndex = 12;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // GammaText
            // 
            this.GammaText.Location = new System.Drawing.Point(409, 168);
            this.GammaText.Name = "GammaText";
            this.GammaText.ReadOnly = true;
            this.GammaText.Size = new System.Drawing.Size(41, 22);
            this.GammaText.TabIndex = 17;
            this.GammaText.Text = "1.00";
            this.GammaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContrastText
            // 
            this.ContrastText.Location = new System.Drawing.Point(409, 101);
            this.ContrastText.Name = "ContrastText";
            this.ContrastText.ReadOnly = true;
            this.ContrastText.Size = new System.Drawing.Size(41, 22);
            this.ContrastText.TabIndex = 16;
            this.ContrastText.Text = "0.50";
            this.ContrastText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BrightnessText
            // 
            this.BrightnessText.Location = new System.Drawing.Point(409, 34);
            this.BrightnessText.Name = "BrightnessText";
            this.BrightnessText.ReadOnly = true;
            this.BrightnessText.Size = new System.Drawing.Size(41, 22);
            this.BrightnessText.TabIndex = 15;
            this.BrightnessText.Text = "0.50";
            this.BrightnessText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GammaLabel
            // 
            this.GammaLabel.AutoSize = true;
            this.GammaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GammaLabel.Location = new System.Drawing.Point(12, 151);
            this.GammaLabel.Name = "GammaLabel";
            this.GammaLabel.Size = new System.Drawing.Size(42, 14);
            this.GammaLabel.TabIndex = 14;
            this.GammaLabel.Text = "Gamma";
            this.GammaLabel.DoubleClick += new System.EventHandler(this.GammaLabel_Click);
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContrastLabel.Location = new System.Drawing.Point(12, 84);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(63, 14);
            this.ContrastLabel.TabIndex = 13;
            this.ContrastLabel.Text = "Contrast";
            this.ContrastLabel.DoubleClick += new System.EventHandler(this.ContrastLabel_Click);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrightnessLabel.Location = new System.Drawing.Point(12, 17);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(77, 14);
            this.BrightnessLabel.TabIndex = 12;
            this.BrightnessLabel.Text = "Brightness";
            this.BrightnessLabel.DoubleClick += new System.EventHandler(this.BrightnessLabel_DoubleClick);
            // 
            // GammaBar
            // 
            this.GammaBar.Location = new System.Drawing.Point(5, 168);
            this.GammaBar.Maximum = 280;
            this.GammaBar.Minimum = 40;
            this.GammaBar.Name = "GammaBar";
            this.GammaBar.Size = new System.Drawing.Size(397, 45);
            this.GammaBar.TabIndex = 11;
            this.GammaBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GammaBar.Value = 100;
            this.GammaBar.ValueChanged += new System.EventHandler(this.GammaBar_ValueChanged);
            // 
            // ContrastBar
            // 
            this.ContrastBar.Location = new System.Drawing.Point(5, 101);
            this.ContrastBar.Maximum = 100;
            this.ContrastBar.Minimum = -100;
            this.ContrastBar.Name = "ContrastBar";
            this.ContrastBar.Size = new System.Drawing.Size(397, 45);
            this.ContrastBar.TabIndex = 10;
            this.ContrastBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ContrastBar.Value = 50;
            this.ContrastBar.ValueChanged += new System.EventHandler(this.ContrastBar_ValueChanged);
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(5, 34);
            this.BrightnessBar.Maximum = 100;
            this.BrightnessBar.Minimum = -100;
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(397, 45);
            this.BrightnessBar.TabIndex = 9;
            this.BrightnessBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessBar.Value = 50;
            this.BrightnessBar.ValueChanged += new System.EventHandler(this.BrightnessBar_ValueChanged);
            // 
            // DVLText
            // 
            this.DVLText.Location = new System.Drawing.Point(522, 199);
            this.DVLText.Name = "DVLText";
            this.DVLText.ReadOnly = true;
            this.DVLText.Size = new System.Drawing.Size(41, 22);
            this.DVLText.TabIndex = 11;
            this.DVLText.Text = "0";
            this.DVLText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DVLLabel
            // 
            this.DVLLabel.AutoSize = true;
            this.DVLLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DVLLabel.Location = new System.Drawing.Point(481, 31);
            this.DVLLabel.Name = "DVLLabel";
            this.DVLLabel.Size = new System.Drawing.Size(119, 28);
            this.DVLLabel.TabIndex = 10;
            this.DVLLabel.Text = "Digital Vibrance\r\n(Saturation)\r\n";
            this.DVLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DVLLabel.Click += new System.EventHandler(this.DVLLabel_Click);
            // 
            // DVLBar
            // 
            this.DVLBar.Location = new System.Drawing.Point(522, 62);
            this.DVLBar.Maximum = 63;
            this.DVLBar.Name = "DVLBar";
            this.DVLBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DVLBar.Size = new System.Drawing.Size(45, 131);
            this.DVLBar.TabIndex = 9;
            this.DVLBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DVLBar.ValueChanged += new System.EventHandler(this.DVLBar_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 233);
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
            this.ColorPanel.PerformLayout();
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVLBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel layoutTablePanel;
        private System.Windows.Forms.ToolStrip SideMenu;
        private System.Windows.Forms.ToolStripButton MiscsButton;
        private System.Windows.Forms.ToolStripButton ColorButton;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.TrackBar DVLBar;
        private System.Windows.Forms.Label DVLLabel;
        private System.Windows.Forms.TextBox DVLText;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.TextBox GammaText;
        private System.Windows.Forms.TextBox ContrastText;
        private System.Windows.Forms.TextBox BrightnessText;
        private System.Windows.Forms.Label GammaLabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TrackBar GammaBar;
        private System.Windows.Forms.TrackBar ContrastBar;
        private System.Windows.Forms.TrackBar BrightnessBar;
    }
}

