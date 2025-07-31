namespace viva_finance
{
    partial class transaction
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
            this.lblTransaction = new System.Windows.Forms.Label();
            this.groupBoxTrans = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.dateTimePickerDebtDate = new System.Windows.Forms.DateTimePicker();
            this.txtToBePaid = new System.Windows.Forms.TextBox();
            this.lblToBePaid = new System.Windows.Forms.Label();
            this.txtAmtReq = new System.Windows.Forms.TextBox();
            this.txtMaxColAmt = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfTrans = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustId = new System.Windows.Forms.ComboBox();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.lblDebitDate = new System.Windows.Forms.Label();
            this.lblAmtReq = new System.Windows.Forms.Label();
            this.lblMaxColAmnt = new System.Windows.Forms.Label();
            this.lblDateOfTrans = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTransId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCollectionAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountRequestedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfDebitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toBePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viva_dbDataSetTransaction = new viva_finance.viva_dbDataSetTransaction();
            this.transactionsTableAdapter = new viva_finance.viva_dbDataSetTransactionTableAdapters.TransactionsTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchCustIdNum = new System.Windows.Forms.Label();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viva_dbDataSetTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(28, 27);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(80, 13);
            this.lblTransaction.TabIndex = 0;
            this.lblTransaction.Text = "Transactions";
            // 
            // groupBoxTrans
            // 
            this.groupBoxTrans.Controls.Add(this.btnSave);
            this.groupBoxTrans.Controls.Add(this.btnCompute);
            this.groupBoxTrans.Controls.Add(this.dateTimePickerDebtDate);
            this.groupBoxTrans.Controls.Add(this.txtToBePaid);
            this.groupBoxTrans.Controls.Add(this.lblToBePaid);
            this.groupBoxTrans.Controls.Add(this.txtAmtReq);
            this.groupBoxTrans.Controls.Add(this.txtMaxColAmt);
            this.groupBoxTrans.Controls.Add(this.dateTimePickerDateOfTrans);
            this.groupBoxTrans.Controls.Add(this.comboBoxCustId);
            this.groupBoxTrans.Controls.Add(this.txtTransId);
            this.groupBoxTrans.Controls.Add(this.lblDebitDate);
            this.groupBoxTrans.Controls.Add(this.lblAmtReq);
            this.groupBoxTrans.Controls.Add(this.lblMaxColAmnt);
            this.groupBoxTrans.Controls.Add(this.lblDateOfTrans);
            this.groupBoxTrans.Controls.Add(this.lblId);
            this.groupBoxTrans.Controls.Add(this.lblTransId);
            this.groupBoxTrans.Location = new System.Drawing.Point(31, 43);
            this.groupBoxTrans.Name = "groupBoxTrans";
            this.groupBoxTrans.Size = new System.Drawing.Size(334, 373);
            this.groupBoxTrans.TabIndex = 1;
            this.groupBoxTrans.TabStop = false;
            this.groupBoxTrans.Text = "Transaction User Input";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(172, 319);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 14;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // dateTimePickerDebtDate
            // 
            this.dateTimePickerDebtDate.Location = new System.Drawing.Point(126, 246);
            this.dateTimePickerDebtDate.Name = "dateTimePickerDebtDate";
            this.dateTimePickerDebtDate.Size = new System.Drawing.Size(202, 20);
            this.dateTimePickerDebtDate.TabIndex = 13;
            // 
            // txtToBePaid
            // 
            this.txtToBePaid.Location = new System.Drawing.Point(126, 293);
            this.txtToBePaid.Name = "txtToBePaid";
            this.txtToBePaid.Size = new System.Drawing.Size(202, 20);
            this.txtToBePaid.TabIndex = 12;
            this.txtToBePaid.TextChanged += new System.EventHandler(this.txtToBePaid_TextChanged);
            // 
            // lblToBePaid
            // 
            this.lblToBePaid.AutoSize = true;
            this.lblToBePaid.Location = new System.Drawing.Point(50, 293);
            this.lblToBePaid.Name = "lblToBePaid";
            this.lblToBePaid.Size = new System.Drawing.Size(69, 13);
            this.lblToBePaid.TabIndex = 11;
            this.lblToBePaid.Text = "Total Interest";
            // 
            // txtAmtReq
            // 
            this.txtAmtReq.Location = new System.Drawing.Point(126, 202);
            this.txtAmtReq.Name = "txtAmtReq";
            this.txtAmtReq.Size = new System.Drawing.Size(202, 20);
            this.txtAmtReq.TabIndex = 10;
            // 
            // txtMaxColAmt
            // 
            this.txtMaxColAmt.Location = new System.Drawing.Point(126, 160);
            this.txtMaxColAmt.Name = "txtMaxColAmt";
            this.txtMaxColAmt.Size = new System.Drawing.Size(202, 20);
            this.txtMaxColAmt.TabIndex = 9;
            this.txtMaxColAmt.TextChanged += new System.EventHandler(this.txtMaxColAmt_TextChanged);
            // 
            // dateTimePickerDateOfTrans
            // 
            this.dateTimePickerDateOfTrans.Location = new System.Drawing.Point(126, 127);
            this.dateTimePickerDateOfTrans.Name = "dateTimePickerDateOfTrans";
            this.dateTimePickerDateOfTrans.Size = new System.Drawing.Size(202, 20);
            this.dateTimePickerDateOfTrans.TabIndex = 8;
            // 
            // comboBoxCustId
            // 
            this.comboBoxCustId.FormattingEnabled = true;
            this.comboBoxCustId.Location = new System.Drawing.Point(126, 87);
            this.comboBoxCustId.Name = "comboBoxCustId";
            this.comboBoxCustId.Size = new System.Drawing.Size(202, 21);
            this.comboBoxCustId.TabIndex = 7;
            this.comboBoxCustId.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustId_SelectedIndexChanged);
            // 
            // txtTransId
            // 
            this.txtTransId.Enabled = false;
            this.txtTransId.Location = new System.Drawing.Point(126, 51);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Size = new System.Drawing.Size(202, 20);
            this.txtTransId.TabIndex = 6;
            this.txtTransId.TextChanged += new System.EventHandler(this.txtTransId_TextChanged);
            // 
            // lblDebitDate
            // 
            this.lblDebitDate.AutoSize = true;
            this.lblDebitDate.Location = new System.Drawing.Point(61, 246);
            this.lblDebitDate.Name = "lblDebitDate";
            this.lblDebitDate.Size = new System.Drawing.Size(58, 13);
            this.lblDebitDate.TabIndex = 5;
            this.lblDebitDate.Text = "Debit Date";
            // 
            // lblAmtReq
            // 
            this.lblAmtReq.AutoSize = true;
            this.lblAmtReq.Location = new System.Drawing.Point(22, 202);
            this.lblAmtReq.Name = "lblAmtReq";
            this.lblAmtReq.Size = new System.Drawing.Size(98, 13);
            this.lblAmtReq.TabIndex = 4;
            this.lblAmtReq.Text = "Amount Requested";
            // 
            // lblMaxColAmnt
            // 
            this.lblMaxColAmnt.AutoSize = true;
            this.lblMaxColAmnt.Location = new System.Drawing.Point(5, 160);
            this.lblMaxColAmnt.Name = "lblMaxColAmnt";
            this.lblMaxColAmnt.Size = new System.Drawing.Size(115, 13);
            this.lblMaxColAmnt.TabIndex = 3;
            this.lblMaxColAmnt.Text = "Max Collection Amount";
            // 
            // lblDateOfTrans
            // 
            this.lblDateOfTrans.AutoSize = true;
            this.lblDateOfTrans.Location = new System.Drawing.Point(19, 127);
            this.lblDateOfTrans.Name = "lblDateOfTrans";
            this.lblDateOfTrans.Size = new System.Drawing.Size(101, 13);
            this.lblDateOfTrans.TabIndex = 2;
            this.lblDateOfTrans.Text = "Date of Transaction";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 87);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(98, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Select Customer ID";
            // 
            // lblTransId
            // 
            this.lblTransId.AutoSize = true;
            this.lblTransId.Location = new System.Drawing.Point(72, 51);
            this.lblTransId.Name = "lblTransId";
            this.lblTransId.Size = new System.Drawing.Size(48, 13);
            this.lblTransId.TabIndex = 0;
            this.lblTransId.Text = "Trans ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transIdDataGridViewTextBoxColumn,
            this.idNumberDataGridViewTextBoxColumn,
            this.dateOfTransactionDataGridViewTextBoxColumn,
            this.maxCollectionAmountDataGridViewTextBoxColumn,
            this.amountRequestedDataGridViewTextBoxColumn,
            this.dateOfDebitDataGridViewTextBoxColumn,
            this.toBePaidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(371, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 364);
            this.dataGridView1.TabIndex = 2;
            // 
            // transIdDataGridViewTextBoxColumn
            // 
            this.transIdDataGridViewTextBoxColumn.DataPropertyName = "TransId";
            this.transIdDataGridViewTextBoxColumn.HeaderText = "TransId";
            this.transIdDataGridViewTextBoxColumn.Name = "transIdDataGridViewTextBoxColumn";
            this.transIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idNumberDataGridViewTextBoxColumn
            // 
            this.idNumberDataGridViewTextBoxColumn.DataPropertyName = "IdNumber";
            this.idNumberDataGridViewTextBoxColumn.HeaderText = "IdNumber";
            this.idNumberDataGridViewTextBoxColumn.Name = "idNumberDataGridViewTextBoxColumn";
            // 
            // dateOfTransactionDataGridViewTextBoxColumn
            // 
            this.dateOfTransactionDataGridViewTextBoxColumn.DataPropertyName = "DateOfTransaction";
            this.dateOfTransactionDataGridViewTextBoxColumn.HeaderText = "DateOfTransaction";
            this.dateOfTransactionDataGridViewTextBoxColumn.Name = "dateOfTransactionDataGridViewTextBoxColumn";
            // 
            // maxCollectionAmountDataGridViewTextBoxColumn
            // 
            this.maxCollectionAmountDataGridViewTextBoxColumn.DataPropertyName = "MaxCollectionAmount";
            this.maxCollectionAmountDataGridViewTextBoxColumn.HeaderText = "MaxCollectionAmount";
            this.maxCollectionAmountDataGridViewTextBoxColumn.Name = "maxCollectionAmountDataGridViewTextBoxColumn";
            // 
            // amountRequestedDataGridViewTextBoxColumn
            // 
            this.amountRequestedDataGridViewTextBoxColumn.DataPropertyName = "AmountRequested";
            this.amountRequestedDataGridViewTextBoxColumn.HeaderText = "AmountRequested";
            this.amountRequestedDataGridViewTextBoxColumn.Name = "amountRequestedDataGridViewTextBoxColumn";
            // 
            // dateOfDebitDataGridViewTextBoxColumn
            // 
            this.dateOfDebitDataGridViewTextBoxColumn.DataPropertyName = "DateOfDebit";
            this.dateOfDebitDataGridViewTextBoxColumn.HeaderText = "DateOfDebit";
            this.dateOfDebitDataGridViewTextBoxColumn.Name = "dateOfDebitDataGridViewTextBoxColumn";
            // 
            // toBePaidDataGridViewTextBoxColumn
            // 
            this.toBePaidDataGridViewTextBoxColumn.DataPropertyName = "toBePaid";
            this.toBePaidDataGridViewTextBoxColumn.HeaderText = "toBePaid";
            this.toBePaidDataGridViewTextBoxColumn.Name = "toBePaidDataGridViewTextBoxColumn";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.viva_dbDataSetTransaction;
            // 
            // viva_dbDataSetTransaction
            // 
            this.viva_dbDataSetTransaction.DataSetName = "viva_dbDataSetTransaction";
            this.viva_dbDataSetTransaction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(842, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchCustIdNum
            // 
            this.lblSearchCustIdNum.AutoSize = true;
            this.lblSearchCustIdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustIdNum.Location = new System.Drawing.Point(371, 55);
            this.lblSearchCustIdNum.Name = "lblSearchCustIdNum";
            this.lblSearchCustIdNum.Size = new System.Drawing.Size(182, 13);
            this.lblSearchCustIdNum.TabIndex = 5;
            this.lblSearchCustIdNum.Text = "Search Customer By id Number";
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Location = new System.Drawing.Point(559, 52);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(277, 20);
            this.txtSearchCust.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(923, 52);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<----";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 494);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearchCust);
            this.Controls.Add(this.lblSearchCustIdNum);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxTrans);
            this.Controls.Add(this.lblTransaction);
            this.Name = "transaction";
            this.Text = "transaction";
            this.Load += new System.EventHandler(this.transaction_Load);
            this.groupBoxTrans.ResumeLayout(false);
            this.groupBoxTrans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viva_dbDataSetTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.GroupBox groupBoxTrans;
        private System.Windows.Forms.Label lblMaxColAmnt;
        private System.Windows.Forms.Label lblDateOfTrans;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTransId;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebtDate;
        private System.Windows.Forms.TextBox txtToBePaid;
        private System.Windows.Forms.Label lblToBePaid;
        private System.Windows.Forms.TextBox txtAmtReq;
        private System.Windows.Forms.TextBox txtMaxColAmt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfTrans;
        private System.Windows.Forms.ComboBox comboBoxCustId;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.Label lblDebitDate;
        private System.Windows.Forms.Label lblAmtReq;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.DataGridView dataGridView1;
        private viva_dbDataSetTransaction viva_dbDataSetTransaction;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private viva_dbDataSetTransactionTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCollectionAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountRequestedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDebitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toBePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchCustIdNum;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Button btnBack;
    }
}