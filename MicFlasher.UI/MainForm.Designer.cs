
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
            this.label1 = new System.Windows.Forms.Label();
            this.MicPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MicLabel = new System.Windows.Forms.Label();
            this.LightLabel = new System.Windows.Forms.Label();
            this.LightPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.VoiceMeeterPanel.SuspendLayout();
            this.MicPanel.SuspendLayout();
            this.LightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VoiceMeeterLabel
            // 
            this.VoiceMeeterLabel.AutoSize = true;
            this.VoiceMeeterLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VoiceMeeterLabel.ForeColor = System.Drawing.Color.White;
            this.VoiceMeeterLabel.Location = new System.Drawing.Point(4, 16);
            this.VoiceMeeterLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.VoiceMeeterLabel.Name = "VoiceMeeterLabel";
            this.VoiceMeeterLabel.Size = new System.Drawing.Size(92, 20);
            this.VoiceMeeterLabel.TabIndex = 3;
            this.VoiceMeeterLabel.Text = "VoiceMeeter";
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
            this.VoiceMeeterPanel.Controls.Add(this.label1);
            this.VoiceMeeterPanel.Controls.Add(this.VoiceMeeterLabel);
            this.VoiceMeeterPanel.Location = new System.Drawing.Point(0, 0);
            this.VoiceMeeterPanel.Name = "VoiceMeeterPanel";
            this.VoiceMeeterPanel.Size = new System.Drawing.Size(100, 100);
            this.VoiceMeeterPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "OK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MicPanel
            // 
            this.MicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MicPanel.Controls.Add(this.label2);
            this.MicPanel.Controls.Add(this.MicLabel);
            this.MicPanel.Location = new System.Drawing.Point(102, 0);
            this.MicPanel.Name = "MicPanel";
            this.MicPanel.Size = new System.Drawing.Size(100, 100);
            this.MicPanel.TabIndex = 5;
            this.MicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MicPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Microphone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MicLabel
            // 
            this.MicLabel.AutoSize = true;
            this.MicLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MicLabel.ForeColor = System.Drawing.Color.White;
            this.MicLabel.Location = new System.Drawing.Point(20, 38);
            this.MicLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MicLabel.Name = "MicLabel";
            this.MicLabel.Size = new System.Drawing.Size(63, 41);
            this.MicLabel.TabIndex = 3;
            this.MicLabel.Text = "ON";
            this.MicLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MicLabel.Click += new System.EventHandler(this.MicLabel_Click);
            // 
            // LightLabel
            // 
            this.LightLabel.AutoSize = true;
            this.LightLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LightLabel.ForeColor = System.Drawing.Color.White;
            this.LightLabel.Location = new System.Drawing.Point(21, 38);
            this.LightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LightLabel.Name = "LightLabel";
            this.LightLabel.Size = new System.Drawing.Size(58, 41);
            this.LightLabel.TabIndex = 3;
            this.LightLabel.Text = "OK";
            this.LightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LightPanel
            // 
            this.LightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LightPanel.Controls.Add(this.label3);
            this.LightPanel.Controls.Add(this.LightLabel);
            this.LightPanel.Location = new System.Drawing.Point(204, 0);
            this.LightPanel.Name = "LightPanel";
            this.LightPanel.Size = new System.Drawing.Size(100, 100);
            this.LightPanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "LightStrip";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}