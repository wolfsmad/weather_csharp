namespace StaionsParameters
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmStation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfoStation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfoProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.خصوصیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStationNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPropertyNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStation,
            this.خصوصیتToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(639, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmStation
            // 
            this.tsmStation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInfoStation,
            this.btnInfoProperty});
            this.tsmStation.Font = new System.Drawing.Font("B Yekan", 12F);
            this.tsmStation.Name = "tsmStation";
            this.tsmStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmStation.RightToLeftAutoMirrorImage = true;
            this.tsmStation.Size = new System.Drawing.Size(121, 28);
            this.tsmStation.Text = "عملیات آب و هوا";
            // 
            // btnInfoStation
            // 
            this.btnInfoStation.Name = "btnInfoStation";
            this.btnInfoStation.Size = new System.Drawing.Size(239, 28);
            this.btnInfoStation.Text = "اطلاعات براساس ایستگاه";
            this.btnInfoStation.Click += new System.EventHandler(this.btnInfoStation_Click);
            // 
            // btnInfoProperty
            // 
            this.btnInfoProperty.Name = "btnInfoProperty";
            this.btnInfoProperty.Size = new System.Drawing.Size(239, 28);
            this.btnInfoProperty.Text = "اطلاعات براساس خصوصیت";
            this.btnInfoProperty.Click += new System.EventHandler(this.btnInfoProperty_Click);
            // 
            // خصوصیتToolStripMenuItem
            // 
            this.خصوصیتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStationNew,
            this.btnPropertyNew});
            this.خصوصیتToolStripMenuItem.Font = new System.Drawing.Font("B Yekan", 12F);
            this.خصوصیتToolStripMenuItem.Name = "خصوصیتToolStripMenuItem";
            this.خصوصیتToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.خصوصیتToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // btnStationNew
            // 
            this.btnStationNew.Name = "btnStationNew";
            this.btnStationNew.Size = new System.Drawing.Size(178, 28);
            this.btnStationNew.Text = "تعریف ایستگاه";
            this.btnStationNew.Click += new System.EventHandler(this.btnStationNew_Click);
            // 
            // btnPropertyNew
            // 
            this.btnPropertyNew.Name = "btnPropertyNew";
            this.btnPropertyNew.Size = new System.Drawing.Size(178, 28);
            this.btnPropertyNew.Text = "تعریف خصوصیت";
            this.btnPropertyNew.Click += new System.EventHandler(this.btnPropertyNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 28);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StaionsParameters.Properties.Resources.jz_csweather_060619;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 296);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شرکت هواشناسی";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmStation;
        private System.Windows.Forms.ToolStripMenuItem خصوصیتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnInfoStation;
        private System.Windows.Forms.ToolStripMenuItem btnInfoProperty;
        private System.Windows.Forms.ToolStripMenuItem btnStationNew;
        private System.Windows.Forms.ToolStripMenuItem btnPropertyNew;
    }
}