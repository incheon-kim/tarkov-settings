
namespace tarkov_settings
{
    partial class UpdateNotifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateNotifier));
            this.currentLabel = new System.Windows.Forms.Label();
            this.latestLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateCancelButton = new System.Windows.Forms.Button();
            this.CurrentVersionLabel = new System.Windows.Forms.Label();
            this.LatestVersionLabel = new System.Windows.Forms.Label();
            this.UpdateNotifyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(20, 45);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(70, 14);
            this.currentLabel.TabIndex = 0;
            this.currentLabel.Text = "Current :";
            // 
            // latestLabel
            // 
            this.latestLabel.AutoSize = true;
            this.latestLabel.Location = new System.Drawing.Point(27, 65);
            this.latestLabel.Name = "latestLabel";
            this.latestLabel.Size = new System.Drawing.Size(63, 14);
            this.latestLabel.TabIndex = 1;
            this.latestLabel.Text = "Latest :";
            // 
            // UpdateButton
            // 
            this.UpdateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UpdateButton.Location = new System.Drawing.Point(86, 95);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateCancelButton
            // 
            this.UpdateCancelButton.Location = new System.Drawing.Point(167, 95);
            this.UpdateCancelButton.Name = "UpdateCancelButton";
            this.UpdateCancelButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateCancelButton.TabIndex = 3;
            this.UpdateCancelButton.Text = "Cancel";
            this.UpdateCancelButton.UseVisualStyleBackColor = true;
            this.UpdateCancelButton.Click += new System.EventHandler(this.UpdateCancelButton_Click);
            // 
            // CurrentVersionLabel
            // 
            this.CurrentVersionLabel.AutoSize = true;
            this.CurrentVersionLabel.Location = new System.Drawing.Point(96, 45);
            this.CurrentVersionLabel.Name = "CurrentVersionLabel";
            this.CurrentVersionLabel.Size = new System.Drawing.Size(56, 14);
            this.CurrentVersionLabel.TabIndex = 4;
            this.CurrentVersionLabel.Text = "0.0.0.0";
            // 
            // LatestVersionLabel
            // 
            this.LatestVersionLabel.AutoSize = true;
            this.LatestVersionLabel.Location = new System.Drawing.Point(96, 65);
            this.LatestVersionLabel.Name = "LatestVersionLabel";
            this.LatestVersionLabel.Size = new System.Drawing.Size(56, 14);
            this.LatestVersionLabel.TabIndex = 5;
            this.LatestVersionLabel.Text = "0.0.0.0";
            // 
            // UpdateNotifyLabel
            // 
            this.UpdateNotifyLabel.AutoSize = true;
            this.UpdateNotifyLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateNotifyLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.UpdateNotifyLabel.Location = new System.Drawing.Point(51, 9);
            this.UpdateNotifyLabel.Name = "UpdateNotifyLabel";
            this.UpdateNotifyLabel.Size = new System.Drawing.Size(147, 28);
            this.UpdateNotifyLabel.TabIndex = 6;
            this.UpdateNotifyLabel.Text = "Tarkov Settings\r\nUpdate is Available!";
            this.UpdateNotifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateNotifier
            // 
            this.AcceptButton = this.UpdateButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.UpdateButton;
            this.ClientSize = new System.Drawing.Size(247, 125);
            this.ControlBox = false;
            this.Controls.Add(this.UpdateNotifyLabel);
            this.Controls.Add(this.LatestVersionLabel);
            this.Controls.Add(this.CurrentVersionLabel);
            this.Controls.Add(this.UpdateCancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.latestLabel);
            this.Controls.Add(this.currentLabel);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateNotifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Available";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label latestLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button UpdateCancelButton;
        private System.Windows.Forms.Label CurrentVersionLabel;
        private System.Windows.Forms.Label LatestVersionLabel;
        private System.Windows.Forms.Label UpdateNotifyLabel;
    }
}