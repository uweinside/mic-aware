
namespace MicFlasher.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerHeartbeat = new System.Windows.Forms.Timer(this.components);
            this.VoiceMeeterLabel = new System.Windows.Forms.Label();
            this.timerFlashPulse = new System.Windows.Forms.Timer(this.components);
            this.VoiceMeeterPanel = new System.Windows.Forms.Panel();
            this.MicPanel = new System.Windows.Forms.Panel();
            this.MicLabel = new System.Windows.Forms.Label();
            this.LightLabel = new System.Windows.Forms.Label();
            this.LightPanel = new System.Windows.Forms.Panel();
            this.VoiceMeeterPanel.SuspendLayout();
            this.MicPanel.SuspendLayout();
            this.LightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VoiceMeeterLabel
            // 
            this.VoiceMeeterLabel.AutoSize = true;
            this.VoiceMeeterLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoiceMeeterLabel.ForeColor = System.Drawing.Color.White;
            this.VoiceMeeterLabel.Location = new System.Drawing.Point(20, 28);
            this.VoiceMeeterLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.VoiceMeeterLabel.Name = "VoiceMeeterLabel";
            this.VoiceMeeterLabel.Size = new System.Drawing.Size(64, 41);
            this.VoiceMeeterLabel.TabIndex = 3;
            this.VoiceMeeterLabel.Text = "VM";
            this.VoiceMeeterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VoiceMeeterLabel.Click += new System.EventHandler(this.lblMuteStatus_Click);
            // 
            // timerFlashPulse
            // 
            this.timerFlashPulse.Enabled = true;
            this.timerFlashPulse.Interval = 1000;
            this.timerFlashPulse.Tick += new System.EventHandler(this.timerFlashPulse_Tick);
            // 
            // VoiceMeeterPanel
            // 
            this.VoiceMeeterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.VoiceMeeterPanel.Controls.Add(this.VoiceMeeterLabel);
            this.VoiceMeeterPanel.Location = new System.Drawing.Point(0, 0);
            this.VoiceMeeterPanel.Name = "VoiceMeeterPanel";
            this.VoiceMeeterPanel.Size = new System.Drawing.Size(100, 100);
            this.VoiceMeeterPanel.TabIndex = 4;
            // 
            // MicPanel
            // 
            this.MicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MicPanel.Controls.Add(this.MicLabel);
            this.MicPanel.Location = new System.Drawing.Point(102, 0);
            this.MicPanel.Name = "MicPanel";
            this.MicPanel.Size = new System.Drawing.Size(100, 100);
            this.MicPanel.TabIndex = 5;
            // 
            // MicLabel
            // 
            this.MicLabel.AutoSize = true;
            this.MicLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MicLabel.ForeColor = System.Drawing.Color.White;
            this.MicLabel.Location = new System.Drawing.Point(19, 28);
            this.MicLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MicLabel.Name = "MicLabel";
            this.MicLabel.Size = new System.Drawing.Size(66, 41);
            this.MicLabel.TabIndex = 3;
            this.MicLabel.Text = "Mic";
            this.MicLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LightLabel
            // 
            this.LightLabel.AutoSize = true;
            this.LightLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LightLabel.ForeColor = System.Drawing.Color.White;
            this.LightLabel.Location = new System.Drawing.Point(10, 28);
            this.LightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LightLabel.Name = "LightLabel";
            this.LightLabel.Size = new System.Drawing.Size(84, 41);
            this.LightLabel.TabIndex = 3;
            this.LightLabel.Text = "Light";
            this.LightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LightPanel
            // 
            this.LightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LightPanel.Controls.Add(this.LightLabel);
            this.LightPanel.Location = new System.Drawing.Point(204, 0);
            this.LightPanel.Name = "LightPanel";
            this.LightPanel.Size = new System.Drawing.Size(100, 100);
            this.LightPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 99);
            this.Controls.Add(this.LightPanel);
            this.Controls.Add(this.MicPanel);
            this.Controls.Add(this.VoiceMeeterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MicAware 1.0";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VoiceMeeterPanel.ResumeLayout(false);
            this.VoiceMeeterPanel.PerformLayout();
            this.MicPanel.ResumeLayout(false);
            this.MicPanel.PerformLayout();
            this.LightPanel.ResumeLayout(false);
            this.LightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerHeartbeat;
        private System.Windows.Forms.Label VoiceMeeterLabel;
        private System.Windows.Forms.Timer timerFlashPulse;
        private System.Windows.Forms.Panel VoiceMeeterPanel;
        private System.Windows.Forms.Panel MicPanel;
        private System.Windows.Forms.Label MicLabel;
        private System.Windows.Forms.Label LightLabel;
        private System.Windows.Forms.Panel LightPanel;
    }
}

