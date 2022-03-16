
namespace FormDesign
{
    partial class DesignUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnBot5 = new System.Windows.Forms.Button();
            this.btnBot4 = new System.Windows.Forms.Button();
            this.btnBot3 = new System.Windows.Forms.Button();
            this.btnBot2 = new System.Windows.Forms.Button();
            this.btnBot1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pctrLogoBanner = new System.Windows.Forms.PictureBox();
            this.lblPageName = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogoBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.lblApplicationName);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 28);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragForm);
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.ForeColor = System.Drawing.Color.White;
            this.lblApplicationName.Location = new System.Drawing.Point(3, 5);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(142, 21);
            this.lblApplicationName.TabIndex = 3;
            this.lblApplicationName.Text = "Bot Management";
            this.lblApplicationName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragForm);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(923, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(953, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.pnlNavBar);
            this.panel2.Controls.Add(this.btnBot5);
            this.panel2.Controls.Add(this.btnBot4);
            this.panel2.Controls.Add(this.btnBot3);
            this.panel2.Controls.Add(this.btnBot2);
            this.panel2.Controls.Add(this.btnBot1);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.pctrLogoBanner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 579);
            this.panel2.TabIndex = 1;
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.pnlNavBar.Location = new System.Drawing.Point(0, 120);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(5, 270);
            this.pnlNavBar.TabIndex = 10;
            // 
            // btnBot5
            // 
            this.btnBot5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnBot5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBot5.FlatAppearance.BorderSize = 0;
            this.btnBot5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot5.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.btnBot5.Image = ((System.Drawing.Image)(resources.GetObject("btnBot5.Image")));
            this.btnBot5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBot5.Location = new System.Drawing.Point(0, 352);
            this.btnBot5.Name = "btnBot5";
            this.btnBot5.Size = new System.Drawing.Size(200, 49);
            this.btnBot5.TabIndex = 9;
            this.btnBot5.Text = "Bot_Name_5";
            this.btnBot5.UseVisualStyleBackColor = false;
            this.btnBot5.Click += new System.EventHandler(this.moveSelection);
            // 
            // btnBot4
            // 
            this.btnBot4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnBot4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBot4.FlatAppearance.BorderSize = 0;
            this.btnBot4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.btnBot4.Image = ((System.Drawing.Image)(resources.GetObject("btnBot4.Image")));
            this.btnBot4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBot4.Location = new System.Drawing.Point(0, 303);
            this.btnBot4.Name = "btnBot4";
            this.btnBot4.Size = new System.Drawing.Size(200, 49);
            this.btnBot4.TabIndex = 8;
            this.btnBot4.Text = "Bot_Name_4";
            this.btnBot4.UseVisualStyleBackColor = false;
            this.btnBot4.Click += new System.EventHandler(this.moveSelection);
            // 
            // btnBot3
            // 
            this.btnBot3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnBot3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBot3.FlatAppearance.BorderSize = 0;
            this.btnBot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.btnBot3.Image = ((System.Drawing.Image)(resources.GetObject("btnBot3.Image")));
            this.btnBot3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBot3.Location = new System.Drawing.Point(0, 254);
            this.btnBot3.Name = "btnBot3";
            this.btnBot3.Size = new System.Drawing.Size(200, 49);
            this.btnBot3.TabIndex = 7;
            this.btnBot3.Text = "Bot_Name_3";
            this.btnBot3.UseVisualStyleBackColor = false;
            this.btnBot3.Click += new System.EventHandler(this.moveSelection);
            // 
            // btnBot2
            // 
            this.btnBot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnBot2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBot2.FlatAppearance.BorderSize = 0;
            this.btnBot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.btnBot2.Image = ((System.Drawing.Image)(resources.GetObject("btnBot2.Image")));
            this.btnBot2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBot2.Location = new System.Drawing.Point(0, 205);
            this.btnBot2.Name = "btnBot2";
            this.btnBot2.Size = new System.Drawing.Size(200, 49);
            this.btnBot2.TabIndex = 6;
            this.btnBot2.Text = "Bot_Name_2";
            this.btnBot2.UseVisualStyleBackColor = false;
            this.btnBot2.Click += new System.EventHandler(this.moveSelection);
            // 
            // btnBot1
            // 
            this.btnBot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnBot1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBot1.FlatAppearance.BorderSize = 0;
            this.btnBot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.btnBot1.Image = ((System.Drawing.Image)(resources.GetObject("btnBot1.Image")));
            this.btnBot1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBot1.Location = new System.Drawing.Point(0, 156);
            this.btnBot1.Name = "btnBot1";
            this.btnBot1.Size = new System.Drawing.Size(200, 49);
            this.btnBot1.TabIndex = 5;
            this.btnBot1.Text = "Bot_Name_1";
            this.btnBot1.UseVisualStyleBackColor = false;
            this.btnBot1.Click += new System.EventHandler(this.moveSelection);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 530);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 49);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.moveSelection);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(139)))), ((int)(((byte)(153)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 107);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 49);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.moveSelection);
            // 
            // pctrLogoBanner
            // 
            this.pctrLogoBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pctrLogoBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctrLogoBanner.Image = ((System.Drawing.Image)(resources.GetObject("pctrLogoBanner.Image")));
            this.pctrLogoBanner.Location = new System.Drawing.Point(0, 0);
            this.pctrLogoBanner.Name = "pctrLogoBanner";
            this.pctrLogoBanner.Size = new System.Drawing.Size(200, 107);
            this.pctrLogoBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogoBanner.TabIndex = 2;
            this.pctrLogoBanner.TabStop = false;
            // 
            // lblPageName
            // 
            this.lblPageName.AutoSize = true;
            this.lblPageName.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPageName.Location = new System.Drawing.Point(206, 31);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(0, 37);
            this.lblPageName.TabIndex = 2;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(200, 71);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(789, 536);
            this.pnlInfo.TabIndex = 3;
            // 
            // DesignUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(989, 607);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblPageName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DesignUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogoBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBot1;
        private System.Windows.Forms.Button btnBot3;
        private System.Windows.Forms.Button btnBot2;
        private System.Windows.Forms.Button btnBot5;
        private System.Windows.Forms.Button btnBot4;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.PictureBox pctrLogoBanner;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Panel pnlInfo;
    }
}

