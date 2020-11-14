namespace NetOne_Cash_Requisition_System
{
    partial class Reportsfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportsfrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tolbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voucheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionofitemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerapproverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodapproverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificationstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachmentsDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.voucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsDataSet = new NetOne_Cash_Requisition_System.crsDataSet();
            this.searchtxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.voucherTableAdapter = new NetOne_Cash_Requisition_System.crsDataSetTableAdapters.voucherTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVoucherToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newVoucherToolStripMenuItem
            // 
            this.newVoucherToolStripMenuItem.Name = "newVoucherToolStripMenuItem";
            this.newVoucherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newVoucherToolStripMenuItem.Text = "New Voucher";
            this.newVoucherToolStripMenuItem.Click += new System.EventHandler(this.NewVoucherToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // homeMenuToolStripMenuItem
            // 
            this.homeMenuToolStripMenuItem.Name = "homeMenuToolStripMenuItem";
            this.homeMenuToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.homeMenuToolStripMenuItem.Text = "Home Menu";
            this.homeMenuToolStripMenuItem.Click += new System.EventHandler(this.HomeMenuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTS";
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.FromdateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromdateTimePicker.Location = new System.Drawing.Point(469, 103);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(101, 21);
            this.FromdateTimePicker.TabIndex = 2;
            this.FromdateTimePicker.Value = new System.DateTime(2019, 11, 3, 21, 2, 52, 0);
            this.FromdateTimePicker.ValueChanged += new System.EventHandler(this.FromdateTimePicker_ValueChanged);
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.TodateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TodateTimePicker.Location = new System.Drawing.Point(605, 103);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(99, 21);
            this.TodateTimePicker.TabIndex = 3;
            this.TodateTimePicker.ValueChanged += new System.EventHandler(this.TodateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolbl.Location = new System.Drawing.Point(576, 105);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(23, 17);
            this.tolbl.TabIndex = 5;
            this.tolbl.Text = "To";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voucheridDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.requestoridDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.descriptionofitemsDataGridViewTextBoxColumn,
            this.managerapproverDataGridViewTextBoxColumn,
            this.hodapproverDataGridViewTextBoxColumn,
            this.paidstatusDataGridViewTextBoxColumn,
            this.justificationstatusDataGridViewTextBoxColumn,
            this.attachmentsDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.voucherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 294);
            this.dataGridView1.TabIndex = 6;
            // 
            // voucheridDataGridViewTextBoxColumn
            // 
            this.voucheridDataGridViewTextBoxColumn.DataPropertyName = "voucher_id";
            this.voucheridDataGridViewTextBoxColumn.HeaderText = "voucher_id";
            this.voucheridDataGridViewTextBoxColumn.Name = "voucheridDataGridViewTextBoxColumn";
            this.voucheridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestoridDataGridViewTextBoxColumn
            // 
            this.requestoridDataGridViewTextBoxColumn.DataPropertyName = "requestor_id";
            this.requestoridDataGridViewTextBoxColumn.HeaderText = "requestor_id";
            this.requestoridDataGridViewTextBoxColumn.Name = "requestoridDataGridViewTextBoxColumn";
            this.requestoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionofitemsDataGridViewTextBoxColumn
            // 
            this.descriptionofitemsDataGridViewTextBoxColumn.DataPropertyName = "description_of_items";
            this.descriptionofitemsDataGridViewTextBoxColumn.HeaderText = "description_of_items";
            this.descriptionofitemsDataGridViewTextBoxColumn.Name = "descriptionofitemsDataGridViewTextBoxColumn";
            this.descriptionofitemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // managerapproverDataGridViewTextBoxColumn
            // 
            this.managerapproverDataGridViewTextBoxColumn.DataPropertyName = "manager_approver";
            this.managerapproverDataGridViewTextBoxColumn.HeaderText = "manager_approver";
            this.managerapproverDataGridViewTextBoxColumn.Name = "managerapproverDataGridViewTextBoxColumn";
            this.managerapproverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hodapproverDataGridViewTextBoxColumn
            // 
            this.hodapproverDataGridViewTextBoxColumn.DataPropertyName = "hod_approver";
            this.hodapproverDataGridViewTextBoxColumn.HeaderText = "hod_approver";
            this.hodapproverDataGridViewTextBoxColumn.Name = "hodapproverDataGridViewTextBoxColumn";
            this.hodapproverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidstatusDataGridViewTextBoxColumn
            // 
            this.paidstatusDataGridViewTextBoxColumn.DataPropertyName = "paid_status";
            this.paidstatusDataGridViewTextBoxColumn.HeaderText = "paid_status";
            this.paidstatusDataGridViewTextBoxColumn.Name = "paidstatusDataGridViewTextBoxColumn";
            this.paidstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // justificationstatusDataGridViewTextBoxColumn
            // 
            this.justificationstatusDataGridViewTextBoxColumn.DataPropertyName = "justification_status";
            this.justificationstatusDataGridViewTextBoxColumn.HeaderText = "justification_status";
            this.justificationstatusDataGridViewTextBoxColumn.Name = "justificationstatusDataGridViewTextBoxColumn";
            this.justificationstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attachmentsDataGridViewImageColumn
            // 
            this.attachmentsDataGridViewImageColumn.DataPropertyName = "attachments";
            this.attachmentsDataGridViewImageColumn.HeaderText = "attachments";
            this.attachmentsDataGridViewImageColumn.Name = "attachmentsDataGridViewImageColumn";
            this.attachmentsDataGridViewImageColumn.ReadOnly = true;
            // 
            // voucherBindingSource
            // 
            this.voucherBindingSource.DataMember = "voucher";
            this.voucherBindingSource.DataSource = this.crsDataSet;
            // 
            // crsDataSet
            // 
            this.crsDataSet.DataSetName = "crsDataSet";
            this.crsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchtxtbx
            // 
            this.searchtxtbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtbx.Location = new System.Drawing.Point(76, 103);
            this.searchtxtbx.Name = "searchtxtbx";
            this.searchtxtbx.Size = new System.Drawing.Size(225, 21);
            this.searchtxtbx.TabIndex = 7;
            this.searchtxtbx.TextChanged += new System.EventHandler(this.Searchtxtbx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Records Displayed:";
            // 
            // rdlbl
            // 
            this.rdlbl.AutoSize = true;
            this.rdlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlbl.Location = new System.Drawing.Point(140, 145);
            this.rdlbl.Name = "rdlbl";
            this.rdlbl.Size = new System.Drawing.Size(43, 17);
            this.rdlbl.TabIndex = 10;
            this.rdlbl.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(180, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Export To Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(411, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Export To PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // voucherTableAdapter
            // 
            this.voucherTableAdapter.ClearBeforeFill = true;
            // 
            // Reportsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchtxtbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tolbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TodateTimePicker);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportsfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rdlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private crsDataSet crsDataSet;
        private System.Windows.Forms.BindingSource voucherBindingSource;
        private crsDataSetTableAdapters.voucherTableAdapter voucherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionofitemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerapproverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodapproverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn justificationstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn attachmentsDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}