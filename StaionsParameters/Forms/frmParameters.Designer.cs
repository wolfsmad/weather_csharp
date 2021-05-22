namespace StaionsParameters.Forms
{
    partial class frmParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParameters));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdParameter = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.weatherDbDataSet = new StaionsParameters.WeatherDbDataSet();
            this.tbl_StationsTableAdapter = new StaionsParameters.WeatherDbDataSetTableAdapters.tbl_StationsTableAdapter();
            this.tblStationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parameterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cobStation = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cobStation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdParameter);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(400, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خصوصیات";
            // 
            // grdParameter
            // 
            this.grdParameter.AllowUserToAddRows = false;
            this.grdParameter.AllowUserToDeleteRows = false;
            this.grdParameter.BackgroundColor = System.Drawing.Color.White;
            this.grdParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameterIdDataGridViewTextBoxColumn,
            this.parameterNameDataGridViewTextBoxColumn});
            this.grdParameter.Location = new System.Drawing.Point(6, 82);
            this.grdParameter.Name = "grdParameter";
            this.grdParameter.ReadOnly = true;
            this.grdParameter.Size = new System.Drawing.Size(383, 177);
            this.grdParameter.TabIndex = 4;
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
            // parameterIdDataGridViewTextBoxColumn
            // 
            this.parameterIdDataGridViewTextBoxColumn.DataPropertyName = "ParameterId";
            this.parameterIdDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.parameterIdDataGridViewTextBoxColumn.Name = "parameterIdDataGridViewTextBoxColumn";
            this.parameterIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.parameterIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // parameterNameDataGridViewTextBoxColumn
            // 
            this.parameterNameDataGridViewTextBoxColumn.DataPropertyName = "ParameterName";
            this.parameterNameDataGridViewTextBoxColumn.HeaderText = "نام خصوصیت";
            this.parameterNameDataGridViewTextBoxColumn.Name = "parameterNameDataGridViewTextBoxColumn";
            this.parameterNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.parameterNameDataGridViewTextBoxColumn.Width = 300;
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
            // cobStation
            // 
            this.cobStation.FormattingEnabled = true;
            this.cobStation.Location = new System.Drawing.Point(157, 33);
            this.cobStation.Name = "cobStation";
            this.cobStation.Size = new System.Drawing.Size(156, 38);
            this.cobStation.TabIndex = 5;
            // 
            // frmParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 323);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خصوصیات ایستگاه ها";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private WeatherDbDataSet weatherDbDataSet;
        private WeatherDbDataSetTableAdapters.tbl_StationsTableAdapter tbl_StationsTableAdapter;
        private System.Windows.Forms.BindingSource tblStationsBindingSource;
        private System.Windows.Forms.ComboBox cobStation;
        private System.Windows.Forms.Label label1;
    }
}