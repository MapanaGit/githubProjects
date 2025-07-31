namespace viva_finance
{
    partial class customer
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.groupBoxCustomerForm = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxCustType = new System.Windows.Forms.ComboBox();
            this.txtCellOfNextOfKin = new System.Windows.Forms.TextBox();
            this.txtNextOfKin = new System.Windows.Forms.TextBox();
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblNextOfKinName = new System.Windows.Forms.Label();
            this.lblNextOfKinCellNumber = new System.Windows.Forms.Label();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.lblPhysicalAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNoOfNextOfKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viva_dbDataSet = new viva_finance.viva_dbDataSet();
            this.customerTableAdapter = new viva_finance.viva_dbDataSetTableAdapters.CustomerTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCustomerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viva_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 19);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(65, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customers";
            // 
            // groupBoxCustomerForm
            // 
            this.groupBoxCustomerForm.Controls.Add(this.btnDelete);
            this.groupBoxCustomerForm.Controls.Add(this.btnUpdate);
            this.groupBoxCustomerForm.Controls.Add(this.btnSave);
            this.groupBoxCustomerForm.Controls.Add(this.comboBoxCustType);
            this.groupBoxCustomerForm.Controls.Add(this.txtCellOfNextOfKin);
            this.groupBoxCustomerForm.Controls.Add(this.txtNextOfKin);
            this.groupBoxCustomerForm.Controls.Add(this.txtCellNumber);
            this.groupBoxCustomerForm.Controls.Add(this.richTextBoxAddress);
            this.groupBoxCustomerForm.Controls.Add(this.comboBoxGender);
            this.groupBoxCustomerForm.Controls.Add(this.txtSurname);
            this.groupBoxCustomerForm.Controls.Add(this.txtName);
            this.groupBoxCustomerForm.Controls.Add(this.txtId);
            this.groupBoxCustomerForm.Controls.Add(this.lblCustomerType);
            this.groupBoxCustomerForm.Controls.Add(this.lblNextOfKinName);
            this.groupBoxCustomerForm.Controls.Add(this.lblNextOfKinCellNumber);
            this.groupBoxCustomerForm.Controls.Add(this.lblCellNumber);
            this.groupBoxCustomerForm.Controls.Add(this.lblPhysicalAddress);
            this.groupBoxCustomerForm.Controls.Add(this.lblGender);
            this.groupBoxCustomerForm.Controls.Add(this.lblSurname);
            this.groupBoxCustomerForm.Controls.Add(this.lblName);
            this.groupBoxCustomerForm.Controls.Add(this.lbID);
            this.groupBoxCustomerForm.Location = new System.Drawing.Point(12, 37);
            this.groupBoxCustomerForm.Name = "groupBoxCustomerForm";
            this.groupBoxCustomerForm.Size = new System.Drawing.Size(386, 438);
            this.groupBoxCustomerForm.TabIndex = 1;
            this.groupBoxCustomerForm.TabStop = false;
            this.groupBoxCustomerForm.Text = "Customer Input";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(211, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(292, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxCustType
            // 
            this.comboBoxCustType.FormattingEnabled = true;
            this.comboBoxCustType.Items.AddRange(new object[] {
            "Worker",
            "Pensioner",
            "SASSA"});
            this.comboBoxCustType.Location = new System.Drawing.Point(246, 383);
            this.comboBoxCustType.Name = "comboBoxCustType";
            this.comboBoxCustType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustType.TabIndex = 17;
            // 
            // txtCellOfNextOfKin
            // 
            this.txtCellOfNextOfKin.Location = new System.Drawing.Point(134, 347);
            this.txtCellOfNextOfKin.Name = "txtCellOfNextOfKin";
            this.txtCellOfNextOfKin.Size = new System.Drawing.Size(233, 20);
            this.txtCellOfNextOfKin.TabIndex = 16;
            // 
            // txtNextOfKin
            // 
            this.txtNextOfKin.Location = new System.Drawing.Point(134, 318);
            this.txtNextOfKin.Name = "txtNextOfKin";
            this.txtNextOfKin.Size = new System.Drawing.Size(233, 20);
            this.txtNextOfKin.TabIndex = 15;
            // 
            // txtCellNumber
            // 
            this.txtCellNumber.Location = new System.Drawing.Point(134, 284);
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.Size = new System.Drawing.Size(233, 20);
            this.txtCellNumber.TabIndex = 14;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(134, 175);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(233, 96);
            this.richTextBoxAddress.TabIndex = 13;
            this.richTextBoxAddress.Text = "";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(246, 139);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 12;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(134, 102);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(233, 20);
            this.txtSurname.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(134, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(233, 20);
            this.txtId.TabIndex = 9;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(50, 383);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(78, 13);
            this.lblCustomerType.TabIndex = 8;
            this.lblCustomerType.Text = "Customer Type";
            // 
            // lblNextOfKinName
            // 
            this.lblNextOfKinName.AutoSize = true;
            this.lblNextOfKinName.Location = new System.Drawing.Point(67, 318);
            this.lblNextOfKinName.Name = "lblNextOfKinName";
            this.lblNextOfKinName.Size = new System.Drawing.Size(61, 13);
            this.lblNextOfKinName.TabIndex = 7;
            this.lblNextOfKinName.Text = "Next Of Kin";
            // 
            // lblNextOfKinCellNumber
            // 
            this.lblNextOfKinCellNumber.AutoSize = true;
            this.lblNextOfKinCellNumber.Location = new System.Drawing.Point(9, 347);
            this.lblNextOfKinCellNumber.Name = "lblNextOfKinCellNumber";
            this.lblNextOfKinCellNumber.Size = new System.Drawing.Size(119, 13);
            this.lblNextOfKinCellNumber.TabIndex = 6;
            this.lblNextOfKinCellNumber.Text = "Next of Kin Cell Number";
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Location = new System.Drawing.Point(64, 284);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(64, 13);
            this.lblCellNumber.TabIndex = 5;
            this.lblCellNumber.Text = "Cell Number";
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.AutoSize = true;
            this.lblPhysicalAddress.Location = new System.Drawing.Point(41, 175);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(87, 13);
            this.lblPhysicalAddress.TabIndex = 4;
            this.lblPhysicalAddress.Text = "Physical Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(86, 139);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(79, 102);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(93, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(72, 34);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(56, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Id Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.physicalAddressDataGridViewTextBoxColumn,
            this.cellNoDataGridViewTextBoxColumn,
            this.nextOfKinDataGridViewTextBoxColumn,
            this.cellNoOfNextOfKinDataGridViewTextBoxColumn,
            this.customerTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(404, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 423);
            this.dataGridView1.TabIndex = 2;
            // 
            // idNumberDataGridViewTextBoxColumn
            // 
            this.idNumberDataGridViewTextBoxColumn.DataPropertyName = "IdNumber";
            this.idNumberDataGridViewTextBoxColumn.HeaderText = "IdNumber";
            this.idNumberDataGridViewTextBoxColumn.Name = "idNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // physicalAddressDataGridViewTextBoxColumn
            // 
            this.physicalAddressDataGridViewTextBoxColumn.DataPropertyName = "PhysicalAddress";
            this.physicalAddressDataGridViewTextBoxColumn.HeaderText = "PhysicalAddress";
            this.physicalAddressDataGridViewTextBoxColumn.Name = "physicalAddressDataGridViewTextBoxColumn";
            // 
            // cellNoDataGridViewTextBoxColumn
            // 
            this.cellNoDataGridViewTextBoxColumn.DataPropertyName = "CellNo";
            this.cellNoDataGridViewTextBoxColumn.HeaderText = "CellNo";
            this.cellNoDataGridViewTextBoxColumn.Name = "cellNoDataGridViewTextBoxColumn";
            // 
            // nextOfKinDataGridViewTextBoxColumn
            // 
            this.nextOfKinDataGridViewTextBoxColumn.DataPropertyName = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn.HeaderText = "NextOfKin";
            this.nextOfKinDataGridViewTextBoxColumn.Name = "nextOfKinDataGridViewTextBoxColumn";
            // 
            // cellNoOfNextOfKinDataGridViewTextBoxColumn
            // 
            this.cellNoOfNextOfKinDataGridViewTextBoxColumn.DataPropertyName = "CellNoOfNextOfKin";
            this.cellNoOfNextOfKinDataGridViewTextBoxColumn.HeaderText = "CellNoOfNextOfKin";
            this.cellNoOfNextOfKinDataGridViewTextBoxColumn.Name = "cellNoOfNextOfKinDataGridViewTextBoxColumn";
            // 
            // customerTypeDataGridViewTextBoxColumn
            // 
            this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "CustomerType";
            this.customerTypeDataGridViewTextBoxColumn.HeaderText = "CustomerType";
            this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.viva_dbDataSet;
            // 
            // viva_dbDataSet
            // 
            this.viva_dbDataSet.DataSetName = "viva_dbDataSet";
            this.viva_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(941, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<-----";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(860, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(594, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Customer By ID";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxCustomerForm);
            this.Controls.Add(this.lblCustomer);
            this.Name = "customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            this.groupBoxCustomerForm.ResumeLayout(false);
            this.groupBoxCustomerForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viva_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox groupBoxCustomerForm;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblNextOfKinName;
        private System.Windows.Forms.Label lblNextOfKinCellNumber;
        private System.Windows.Forms.Label lblCellNumber;
        private System.Windows.Forms.Label lblPhysicalAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox comboBoxCustType;
        private System.Windows.Forms.TextBox txtCellOfNextOfKin;
        private System.Windows.Forms.TextBox txtNextOfKin;
        private System.Windows.Forms.TextBox txtCellNumber;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private viva_dbDataSet viva_dbDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private viva_dbDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNoOfNextOfKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}