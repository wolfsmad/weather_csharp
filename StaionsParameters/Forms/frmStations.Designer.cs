namespace Weather
{
    partial class frmStations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdStation = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.weatherDbDataSet = new StaionsParameters.WeatherDbDataSet();
            this.tbl_StationsTableAdapter = new StaionsParameters.WeatherDbDataSetTableAdapters.tbl_StationsTableAdapter();
            this.tblStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.grdStation);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(400, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ایستگاه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(349, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "جستجو";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(175, 37);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 28);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grdStation
            // 
            this.grdStation.AllowUserToAddRows = false;
            this.grdStation.AllowUserToDeleteRows = false;
            this.grdStation.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationIdDataGridViewTextBoxColumn,
            this.stationNameDataGridViewTextBoxColumn});
            this.grdStation.Location = new System.Drawing.Point(6, 82);
            this.grdStation.Name = "grdStation";
            this.grdStation.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStation.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdStation.Size = new System.Drawing.Size(388, 177);
            this.grdStation.TabIndex = 4;
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // weatherDbDataSet
            // 
            this.weatherDbDataSet.DataSetName = "WeatherDbDataSet";
            this.weatherDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_StationsTableAdapter
            // 
            this.tbl_StationsTableAdapter.ClearBeforeFill = true;
            // 
            // tblStationsBindingSource
            // 
            this.tblStationsBindingSource.DataMember = "tbl_Stations";
            this.tblStationsBindingSource.DataSource = this.weatherDbDataSet;
            // 
            // stationNameDataGridViewTextBoxColumn
            // 
            this.stationNameDataGridViewTextBoxColumn.DataPropertyName = "StationName";
            this.stationNameDataGridViewTextBoxColumn.HeaderText = "نام ایستگاه";
            this.stationNameDataGridViewTextBoxColumn.Name = "stationNameDataGridViewTextBoxColumn";
            this.stationNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stationNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // stationIdDataGridViewTextBoxColumn
            // 
            this.stationIdDataGridViewTextBoxColumn.DataPropertyName = "StationId";
            this.stationIdDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.stationIdDataGridViewTextBoxColumn.Name = "stationIdDataGridViewTextBoxColumn";
            this.stationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stationIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // frmStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 325);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایستگاه";
            this.Load += new System.EventHandler(this.frmStations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdStation;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private StaionsParameters.WeatherDbDataSet weatherDbDataSet;
        private StaionsParameters.WeatherDbDataSetTableAdapters.tbl_StationsTableAdapter tbl_StationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblStationsBindingSource;
    }
}