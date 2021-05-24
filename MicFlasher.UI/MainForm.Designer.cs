
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
            this.lblMuteStatus = new System.Windows.Forms.Label();
            this.timerFlashPulse = new System.Windows.Forms.Timer(this.components);
            this.pnlVoiceMeeter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlVoiceMeeter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMuteStatus
            // 
            this.lblMuteStatus.AutoSize = true;
            this.lblMuteStatus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMuteStatus.ForeColor = System.Drawing.Color.White;
            this.lblMuteStatus.Location = new System.Drawing.Point(37, 44);
            this.lblMuteStatus.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMuteStatus.Name = "lblMuteStatus";
            this.lblMuteStatus.Size = new System.Drawing.Size(69, 45);
            this.lblMuteStatus.TabIndex = 3;
            this.lblMuteStatus.Text = "VM";
            this.lblMuteStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMuteStatus.Click += new System.EventHandler(this.lblMuteStatus_Click);
            // 
            // timerFlashPulse
            // 
            this.timerFlashPulse.Enabled = true;
            this.timerFlashPulse.Interval = 1000;
            this.timerFlashPulse.Tick += new System.EventHandler(this.timerFlashPulse_Tick);
            // 
            // pnlVoiceMeeter
            // 
            this.pnlVoiceMeeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlVoiceMeeter.Controls.Add(this.lblMuteStatus);
            this.pnlVoiceMeeter.Location = new System.Drawing.Point(0, 0);
            this.pnlVoiceMeeter.Name = "pnlVoiceMeeter";
            this.pnlVoiceMeeter.Size = new System.Drawing.Size(140, 140);
            this.pnlVoiceMeeter.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(142, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 140);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 140);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlVoiceMeeter);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MicAware 1.0";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlVoiceMeeter.ResumeLayout(false);
            this.pnlVoiceMeeter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerHeartbeat;
        private System.Windows.Forms.Label lblMuteStatus;
        private System.Windows.Forms.Timer timerFlashPulse;
        private System.Windows.Forms.Panel pnlVoiceMeeter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

