namespace NetOne_Cash_Requisition_System
{
    partial class Createvoucherfrm
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
            System.Windows.Forms.Label voucher_idLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label requestor_idLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label description_of_itemsLabel;
            System.Windows.Forms.Label manager_approverLabel;
            System.Windows.Forms.Label hod_approverLabel;
            System.Windows.Forms.Label paid_statusLabel;
            System.Windows.Forms.Label justification_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Createvoucherfrm));
            this.crsDataSet = new NetOne_Cash_Requisition_System.crsDataSet();
            this.voucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voucherTableAdapter = new NetOne_Cash_Requisition_System.crsDataSetTableAdapters.voucherTableAdapter();
            this.tableAdapterManager = new NetOne_Cash_Requisition_System.crsDataSetTableAdapters.TableAdapterManager();
            this.voucher_idTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.requestor_idTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.description_of_itemsTextBox = new System.Windows.Forms.TextBox();
            this.manager_approverTextBox = new System.Windows.Forms.TextBox();
            this.hod_approverTextBox = new System.Windows.Forms.TextBox();
            this.paid_statusTextBox = new System.Windows.Forms.TextBox();
            this.justification_statusTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitvoucherbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            voucher_idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            requestor_idLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            description_of_itemsLabel = new System.Windows.Forms.Label();
            manager_approverLabel = new System.Windows.Forms.Label();
            hod_approverLabel = new System.Windows.Forms.Label();
            paid_statusLabel = new System.Windows.Forms.Label();
            justification_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voucher_idLabel
            // 
            voucher_idLabel.AutoSize = true;
            voucher_idLabel.Location = new System.Drawing.Point(33, 34);
            voucher_idLabel.Name = "voucher_idLabel";
            voucher_idLabel.Size = new System.Drawing.Size(73, 17);
            voucher_idLabel.TabIndex = 1;
            voucher_idLabel.Text = "Voucher ID";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(33, 60);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(35, 17);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date";
            // 
            // requestor_idLabel
            // 
            requestor_idLabel.AutoSize = true;
            requestor_idLabel.Location = new System.Drawing.Point(33, 86);
            requestor_idLabel.Name = "requestor_idLabel";
            requestor_idLabel.Size = new System.Drawing.Size(85, 17);
            requestor_idLabel.TabIndex = 5;
            requestor_idLabel.Text = "Requestor ID";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(33, 112);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(71, 17);
            first_nameLabel.TabIndex = 7;
            first_nameLabel.Text = "First Name";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(33, 138);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(70, 17);
            last_nameLabel.TabIndex = 9;
            last_nameLabel.Text = "Last Name";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(33, 164);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(44, 17);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 190);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(39, 17);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(33, 216);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(77, 17);
            departmentLabel.TabIndex = 15;
            departmentLabel.Text = "Department";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(33, 242);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(53, 17);
            amountLabel.TabIndex = 17;
            amountLabel.Text = "Amount";
            // 
            // description_of_itemsLabel
            // 
            description_of_itemsLabel.AutoSize = true;
            description_of_itemsLabel.Location = new System.Drawing.Point(336, 34);
            description_of_itemsLabel.Name = "description_of_itemsLabel";
            description_of_itemsLabel.Size = new System.Drawing.Size(126, 17);
            description_of_itemsLabel.TabIndex = 19;
            description_of_itemsLabel.Text = "Description of Items";
            // 
            // manager_approverLabel
            // 
            manager_approverLabel.AutoSize = true;
            manager_approverLabel.Location = new System.Drawing.Point(336, 164);
            manager_approverLabel.Name = "manager_approverLabel";
            manager_approverLabel.Size = new System.Drawing.Size(118, 17);
            manager_approverLabel.TabIndex = 21;
            manager_approverLabel.Text = "Manager Approval";
            // 
            // hod_approverLabel
            // 
            hod_approverLabel.AutoSize = true;
            hod_approverLabel.Location = new System.Drawing.Point(336, 190);
            hod_approverLabel.Name = "hod_approverLabel";
            hod_approverLabel.Size = new System.Drawing.Size(93, 17);
            hod_approverLabel.TabIndex = 23;
            hod_approverLabel.Text = "HOD Approval";
            // 
            // paid_statusLabel
            // 
            paid_statusLabel.AutoSize = true;
            paid_statusLabel.Location = new System.Drawing.Point(336, 216);
            paid_statusLabel.Name = "paid_statusLabel";
            paid_statusLabel.Size = new System.Drawing.Size(96, 17);
            paid_statusLabel.TabIndex = 25;
            paid_statusLabel.Text = "Payment Status";
            // 
            // justification_statusLabel
            // 
            justification_statusLabel.AutoSize = true;
            justification_statusLabel.Location = new System.Drawing.Point(336, 242);
            justification_statusLabel.Name = "justification_statusLabel";
            justification_statusLabel.Size = new System.Drawing.Size(114, 17);
            justification_statusLabel.TabIndex = 27;
            justification_statusLabel.Text = "Justification Status";
            // 
            // crsDataSet
            // 
            this.crsDataSet.DataSetName = "crsDataSet";
            this.crsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voucherBindingSource
            // 
            this.voucherBindingSource.DataMember = "voucher";
            this.voucherBindingSource.DataSource = this.crsDataSet;
            // 
            // voucherTableAdapter
            // 
            this.voucherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NetOne_Cash_Requisition_System.crsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.voucherTableAdapter = this.voucherTableAdapter;
            // 
            // voucher_idTextBox
            // 
            this.voucher_idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.voucher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "voucher_id", true));
            this.voucher_idTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_idTextBox.Location = new System.Drawing.Point(139, 31);
            this.voucher_idTextBox.Name = "voucher_idTextBox";
            this.voucher_idTextBox.ReadOnly = true;
            this.voucher_idTextBox.Size = new System.Drawing.Size(155, 21);
            this.voucher_idTextBox.TabIndex = 2;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "date", true));
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(139, 57);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(155, 21);
            this.dateTextBox.TabIndex = 4;
            // 
            // requestor_idTextBox
            // 
            this.requestor_idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.requestor_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "requestor_id", true));
            this.requestor_idTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestor_idTextBox.Location = new System.Drawing.Point(139, 83);
            this.requestor_idTextBox.Name = "requestor_idTextBox";
            this.requestor_idTextBox.ReadOnly = true;
            this.requestor_idTextBox.Size = new System.Drawing.Size(155, 21);
            this.requestor_idTextBox.TabIndex = 6;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_nameTextBox.Location = new System.Drawing.Point(139, 109);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.ReadOnly = true;
            this.first_nameTextBox.Size = new System.Drawing.Size(155, 21);
            this.first_nameTextBox.TabIndex = 8;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_nameTextBox.Location = new System.Drawing.Point(139, 135);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.ReadOnly = true;
            this.last_nameTextBox.Size = new System.Drawing.Size(155, 21);
            this.last_nameTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(139, 161);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(155, 21);
            this.phoneTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(139, 187);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(155, 21);
            this.emailTextBox.TabIndex = 14;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "department", true));
            this.departmentTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTextBox.Location = new System.Drawing.Point(139, 213);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(155, 21);
            this.departmentTextBox.TabIndex = 16;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "amount", true));
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(139, 239);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(155, 21);
            this.amountTextBox.TabIndex = 18;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextBox_KeyPress);
            // 
            // description_of_itemsTextBox
            // 
            this.description_of_itemsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "description_of_items", true));
            this.description_of_itemsTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_of_itemsTextBox.Location = new System.Drawing.Point(490, 31);
            this.description_of_itemsTextBox.Multiline = true;
            this.description_of_itemsTextBox.Name = "description_of_itemsTextBox";
            this.description_of_itemsTextBox.Size = new System.Drawing.Size(155, 124);
            this.description_of_itemsTextBox.TabIndex = 20;
            // 
            // manager_approverTextBox
            // 
            this.manager_approverTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.manager_approverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "manager_approver", true));
            this.manager_approverTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_approverTextBox.Location = new System.Drawing.Point(490, 161);
            this.manager_approverTextBox.Name = "manager_approverTextBox";
            this.manager_approverTextBox.ReadOnly = true;
            this.manager_approverTextBox.Size = new System.Drawing.Size(155, 21);
            this.manager_approverTextBox.TabIndex = 22;
            // 
            // hod_approverTextBox
            // 
            this.hod_approverTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hod_approverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "hod_approver", true));
            this.hod_approverTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hod_approverTextBox.Location = new System.Drawing.Point(490, 187);
            this.hod_approverTextBox.Name = "hod_approverTextBox";
            this.hod_approverTextBox.ReadOnly = true;
            this.hod_approverTextBox.Size = new System.Drawing.Size(155, 21);
            this.hod_approverTextBox.TabIndex = 24;
            // 
            // paid_statusTextBox
            // 
            this.paid_statusTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paid_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "paid_status", true));
            this.paid_statusTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_statusTextBox.Location = new System.Drawing.Point(490, 213);
            this.paid_statusTextBox.Name = "paid_statusTextBox";
            this.paid_statusTextBox.ReadOnly = true;
            this.paid_statusTextBox.Size = new System.Drawing.Size(155, 21);
            this.paid_statusTextBox.TabIndex = 26;
            // 
            // justification_statusTextBox
            // 
            this.justification_statusTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.justification_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucherBindingSource, "justification_status", true));
            this.justification_statusTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justification_statusTextBox.Location = new System.Drawing.Point(490, 239);
            this.justification_statusTextBox.Name = "justification_statusTextBox";
            this.justification_statusTextBox.ReadOnly = true;
            this.justification_statusTextBox.Size = new System.Drawing.Size(155, 21);
            this.justification_statusTextBox.TabIndex = 28;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 25);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVoucherToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newVoucherToolStripMenuItem
            // 
            this.newVoucherToolStripMenuItem.Name = "newVoucherToolStripMenuItem";
            this.newVoucherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newVoucherToolStripMenuItem.Text = "New Voucher";
            this.newVoucherToolStripMenuItem.Click += new System.EventHandler(this.NewVoucherToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Logout";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
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
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // homeMenuToolStripMenuItem
            // 
            this.homeMenuToolStripMenuItem.Name = "homeMenuToolStripMenuItem";
            this.homeMenuToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.homeMenuToolStripMenuItem.Text = "Home Menu";
            this.homeMenuToolStripMenuItem.Click += new System.EventHandler(this.HomeMenuToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.voucher_idTextBox);
            this.groupBox1.Controls.Add(voucher_idLabel);
            this.groupBox1.Controls.Add(this.justification_statusTextBox);
            this.groupBox1.Controls.Add(justification_statusLabel);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.paid_statusTextBox);
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(paid_statusLabel);
            this.groupBox1.Controls.Add(requestor_idLabel);
            this.groupBox1.Controls.Add(this.hod_approverTextBox);
            this.groupBox1.Controls.Add(this.requestor_idTextBox);
            this.groupBox1.Controls.Add(hod_approverLabel);
            this.groupBox1.Controls.Add(first_nameLabel);
            this.groupBox1.Controls.Add(this.manager_approverTextBox);
            this.groupBox1.Controls.Add(this.first_nameTextBox);
            this.groupBox1.Controls.Add(manager_approverLabel);
            this.groupBox1.Controls.Add(last_nameLabel);
            this.groupBox1.Controls.Add(this.description_of_itemsTextBox);
            this.groupBox1.Controls.Add(this.last_nameTextBox);
            this.groupBox1.Controls.Add(description_of_itemsLabel);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(amountLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(departmentLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 277);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voucher Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "CREATE VOUCHER";
            // 
            // submitvoucherbtn
            // 
            this.submitvoucherbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.submitvoucherbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitvoucherbtn.Location = new System.Drawing.Point(174, 415);
            this.submitvoucherbtn.Name = "submitvoucherbtn";
            this.submitvoucherbtn.Size = new System.Drawing.Size(135, 33);
            this.submitvoucherbtn.TabIndex = 32;
            this.submitvoucherbtn.Text = "Submit Voucher";
            this.submitvoucherbtn.UseVisualStyleBackColor = false;
            this.submitvoucherbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(418, 415);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(135, 33);
            this.cancelbtn.TabIndex = 33;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Createvoucherfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 469);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.submitvoucherbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Createvoucherfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Voucher";
            this.Load += new System.EventHandler(this.Createvoucherfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private crsDataSet crsDataSet;
        private System.Windows.Forms.BindingSource voucherBindingSource;
        private crsDataSetTableAdapters.voucherTableAdapter voucherTableAdapter;
        private crsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox voucher_idTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox requestor_idTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox description_of_itemsTextBox;
        private System.Windows.Forms.TextBox manager_approverTextBox;
        private System.Windows.Forms.TextBox hod_approverTextBox;
        private System.Windows.Forms.TextBox paid_statusTextBox;
        private System.Windows.Forms.TextBox justification_statusTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitvoucherbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ToolStripMenuItem homeMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVoucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}