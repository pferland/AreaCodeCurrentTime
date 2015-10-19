using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrayIconExp
{
    partial class frmTrayIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrayIcon));
            this.label3 = new System.Windows.Forms.Label();
            this.txtAreaCode = new System.Windows.Forms.TextBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.MenuConT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRemaining = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuConT.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area Code:";
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Location = new System.Drawing.Point(99, 6);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(104, 26);
            this.txtAreaCode.KeyDown += new KeyEventHandler(tb_KeyDown);
            this.txtAreaCode.TabIndex = 3;
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMonitor.ForeColor = System.Drawing.Color.Black;
            this.btnMonitor.Location = new System.Drawing.Point(209, 5);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(168, 26);
            this.btnMonitor.TabIndex = 4;
            this.btnMonitor.Text = "Search!";
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.BackColor = System.Drawing.Color.Navy;
            this.lblCurrentTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 44);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(460, 209);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "10:00AM";
            // 
            // MenuConT
            // 
            this.MenuConT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemaining,
            this.mnuExit});
            this.MenuConT.Name = "MenuConT";
            this.MenuConT.Size = new System.Drawing.Size(168, 48);
            this.MenuConT.Text = "ContextMenu";
            // 
            // mnuRemaining
            // 
            this.mnuRemaining.Name = "mnuRemaining";
            this.mnuRemaining.Size = new System.Drawing.Size(167, 22);
            this.mnuRemaining.Text = "Search Area Code";
            this.mnuRemaining.Click += new System.EventHandler(this.mnuRemaining_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(167, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayIcon.BalloonTipText = "Hi!";
            this.TrayIcon.BalloonTipTitle = "Boo";
            this.TrayIcon.ContextMenuStrip = this.MenuConT;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Area Code Search";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // frmTrayIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(540, 87);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.txtAreaCode);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrayIcon";
            this.Text = "Area Code Current Time Zone Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrayIcon_FormClosing);
            this.Load += new System.EventHandler(this.frmTrayIcon_Load);
            this.MenuConT.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TrayIcon_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Show();
        }
        

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnMonitor_Click(sender, e);
            }
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAreaCode;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.ContextMenuStrip MenuConT;
        private System.Windows.Forms.ToolStripMenuItem mnuRemaining;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

