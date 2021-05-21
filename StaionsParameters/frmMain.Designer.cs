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
            this.خصوصیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتبراساسایستگاهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتبراساسخصوصیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picStation = new System.Windows.Forms.PictureBox();
            this.picParameter = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStation,
            this.خصوصیتToolStripMenuItem,
            this.اطلاعاتبراساسایستگاهToolStripMenuItem,
            this.اطلاعاتبراساسخصوصیتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(519, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmStation
            // 
            this.tsmStation.Font = new System.Drawing.Font("B Yekan", 12F);
            this.tsmStation.Name = "tsmStation";
            this.tsmStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmStation.RightToLeftAutoMirrorImage = true;
            this.tsmStation.Size = new System.Drawing.Size(67, 28);
            this.tsmStation.Text = "ایستگاه";
            this.tsmStation.Click += new System.EventHandler(this.tsmStation_Click);
            // 
            // خصوصیتToolStripMenuItem
            // 
            this.خصوصیتToolStripMenuItem.Font = new System.Drawing.Font("B Yekan", 12F);
            this.خصوصیتToolStripMenuItem.Name = "خصوصیتToolStripMenuItem";
            this.خصوصیتToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.خصوصیتToolStripMenuItem.Text = "خصوصیت";
            // 
            // اطلاعاتبراساسایستگاهToolStripMenuItem
            // 
            this.اطلاعاتبراساسایستگاهToolStripMenuItem.Font = new System.Drawing.Font("B Yekan", 12F);
            this.اطلاعاتبراساسایستگاهToolStripMenuItem.Name = "اطلاعاتبراساسایستگاهToolStripMenuItem";
            this.اطلاعاتبراساسایستگاهToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.اطلاعاتبراساسایستگاهToolStripMenuItem.Text = "اطلاعات بر اساس ایستگاه";
            // 
            // اطلاعاتبراساسخصوصیتToolStripMenuItem
            // 
            this.اطلاعاتبراساسخصوصیتToolStripMenuItem.Font = new System.Drawing.Font("B Yekan", 12F);
            this.اطلاعاتبراساسخصوصیتToolStripMenuItem.Name = "اطلاعاتبراساسخصوصیتToolStripMenuItem";
            this.اطلاعاتبراساسخصوصیتToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.اطلاعاتبراساسخصوصیتToolStripMenuItem.Text = "اطلاعات بر اساس خصوصیت";
            // 
            // picStation
            // 
            this.picStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStation.Image = global::StaionsParameters.Properties.Resources.New_Project__1_;
            this.picStation.Location = new System.Drawing.Point(277, 71);
            this.picStation.Name = "picStation";
            this.picStation.Size = new System.Drawing.Size(230, 100);
            this.picStation.TabIndex = 2;
            this.picStation.TabStop = false;
            this.picStation.Click += new System.EventHandler(this.picStation_Click);
            // 
            // picParameter
            // 
            this.picParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picParameter.Image = global::StaionsParameters.Properties.Resources.New_Project;
            this.picParameter.Location = new System.Drawing.Point(12, 71);
            this.picParameter.Name = "picParameter";
            this.picParameter.Size = new System.Drawing.Size(230, 100);
            this.picParameter.TabIndex = 2;
            this.picParameter.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(519, 200);
            this.Controls.Add(this.picStation);
            this.Controls.Add(this.picParameter);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.Text = "برنامه آب هوا";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmStation;
        private System.Windows.Forms.ToolStripMenuItem خصوصیتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتبراساسایستگاهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتبراساسخصوصیتToolStripMenuItem;
        private System.Windows.Forms.PictureBox picParameter;
        private System.Windows.Forms.PictureBox picStation;
    }
}