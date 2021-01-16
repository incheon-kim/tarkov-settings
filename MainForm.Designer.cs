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
            this.layoutTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.debugBox = new System.Windows.Forms.TextBox();
            this.layoutTablePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTablePanel
            // 
            this.layoutTablePanel.ColumnCount = 2;
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.88304F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.11696F));
            this.layoutTablePanel.Controls.Add(this.menuPanel, 0, 0);
            this.layoutTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutTablePanel.Location = new System.Drawing.Point(0, 0);
            this.layoutTablePanel.Name = "layoutTablePanel";
            this.layoutTablePanel.RowCount = 1;
            this.layoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTablePanel.Size = new System.Drawing.Size(684, 287);
            this.layoutTablePanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(3, 3);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(129, 281);
            this.menuPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.debugBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 293);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(684, 28);
            this.bottomPanel.TabIndex = 1;
            // 
            // debugBox
            // 
            this.debugBox.BackColor = System.Drawing.Color.DimGray;
            this.debugBox.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.debugBox.ForeColor = System.Drawing.SystemColors.Info;
            this.debugBox.Location = new System.Drawing.Point(584, 0);
            this.debugBox.Margin = new System.Windows.Forms.Padding(0);
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.Size = new System.Drawing.Size(100, 27);
            this.debugBox.TabIndex = 0;
            this.debugBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(684, 321);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.layoutTablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tarkov Settings";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.layoutTablePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTablePanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TextBox debugBox;
    }
}

