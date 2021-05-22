namespace StaionsParameters.Forms
{
    partial class frmInfoStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoStation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobStation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdInfoStation = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.observeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInfoStation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cobStation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdInfoStation);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(19, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(400, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات بر اساس ایستگاه ها";
            // 
            // cobStation
            // 
            this.cobStation.FormattingEnabled = true;
            this.cobStation.Location = new System.Drawing.Point(157, 33);
            this.cobStation.Name = "cobStation";
            this.cobStation.Size = new System.Drawing.Size(156, 38);
            this.cobStation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(333, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام ایستگاه";
            // 
            // grdInfoStation
            // 
            this.grdInfoStation.AllowUserToAddRows = false;
            this.grdInfoStation.AllowUserToDeleteRows = false;
            this.grdInfoStation.BackgroundColor = System.Drawing.Color.White;
            this.grdInfoStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInfoStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.observeIdDataGridViewTextBoxColumn,
            this.DateDataGridViewTextBoxColumn,
            this.parameterNameDataGridViewTextBoxColumn,
            this.ValueDataGridViewTextBoxColumn});
            this.grdInfoStation.Location = new System.Drawing.Point(6, 82);
            this.grdInfoStation.Name = "grdInfoStation";
            this.grdInfoStation.ReadOnly = true;
            this.grdInfoStation.Size = new System.Drawing.Size(383, 177);
            this.grdInfoStation.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Nazanin", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(238, 265);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Nazanin", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(157, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("B Nazanin", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(319, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // observeIdDataGridViewTextBoxColumn
            // 
            this.observeIdDataGridViewTextBoxColumn.DataPropertyName = "ObserveId";
            this.observeIdDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.observeIdDataGridViewTextBoxColumn.Name = "observeIdDataGridViewTextBoxColumn";
            this.observeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.observeIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // DateDataGridViewTextBoxColumn
            // 
            this.DateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.DateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn";
            this.DateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parameterNameDataGridViewTextBoxColumn
            // 
            this.parameterNameDataGridViewTextBoxColumn.DataPropertyName = "ParameterName";
            this.parameterNameDataGridViewTextBoxColumn.HeaderText = "نام خصوصیت";
            this.parameterNameDataGridViewTextBoxColumn.Name = "parameterNameDataGridViewTextBoxColumn";
            this.parameterNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.parameterNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ValueDataGridViewTextBoxColumn
            // 
            this.ValueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.ValueDataGridViewTextBoxColumn.HeaderText = "مقدار";
            this.ValueDataGridViewTextBoxColumn.Name = "ValueDataGridViewTextBoxColumn";
            this.ValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmInfoStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 348);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بر اساس ایستگاه";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInfoStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cobStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdInfoStation;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn observeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDataGridViewTextBoxColumn;
    }
}