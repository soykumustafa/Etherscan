namespace Soyku.Etherscan.UI.View.Ropsten
{
    partial class List
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
            this.m_gridView = new System.Windows.Forms.DataGridView();
            this.blockNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txreceiptstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cumulativeGasUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_btnGetAll = new System.Windows.Forms.Button();
            this.m_txtModule = new System.Windows.Forms.TextBox();
            this.m_txtAction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txtAddres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txtStartBlock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txtEndBlock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_txtPage = new System.Windows.Forms.TextBox();
            this.m_comboSort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_txtOffset = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_txtApiKey = new System.Windows.Forms.TextBox();
            this.m_group = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.m_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_gridView
            // 
            this.m_gridView.AutoGenerateColumns = false;
            this.m_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blockNumberDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.hashDataGridViewTextBoxColumn,
            this.nonceDataGridViewTextBoxColumn,
            this.blockHashDataGridViewTextBoxColumn,
            this.transactionIndexDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.gasDataGridViewTextBoxColumn,
            this.gasPriceDataGridViewTextBoxColumn,
            this.isErrorDataGridViewTextBoxColumn,
            this.txreceiptstatusDataGridViewTextBoxColumn,
            this.inputDataGridViewTextBoxColumn,
            this.contractAddressDataGridViewTextBoxColumn,
            this.cumulativeGasUsedDataGridViewTextBoxColumn,
            this.gasUsedDataGridViewTextBoxColumn,
            this.confirmationsDataGridViewTextBoxColumn,
            this.methodIdDataGridViewTextBoxColumn,
            this.functionNameDataGridViewTextBoxColumn});
            this.m_gridView.DataSource = this.employeeBindingSource;
            this.m_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_gridView.Location = new System.Drawing.Point(0, 0);
            this.m_gridView.Name = "m_gridView";
            this.m_gridView.RowHeadersWidth = 51;
            this.m_gridView.RowTemplate.Height = 29;
            this.m_gridView.Size = new System.Drawing.Size(1069, 656);
            this.m_gridView.TabIndex = 0;
            // 
            // blockNumberDataGridViewTextBoxColumn
            // 
            this.blockNumberDataGridViewTextBoxColumn.DataPropertyName = "BlockNumber";
            this.blockNumberDataGridViewTextBoxColumn.HeaderText = "BlockNumber";
            this.blockNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blockNumberDataGridViewTextBoxColumn.Name = "blockNumberDataGridViewTextBoxColumn";
            this.blockNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.Width = 125;
            // 
            // hashDataGridViewTextBoxColumn
            // 
            this.hashDataGridViewTextBoxColumn.DataPropertyName = "Hash";
            this.hashDataGridViewTextBoxColumn.HeaderText = "Hash";
            this.hashDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hashDataGridViewTextBoxColumn.Name = "hashDataGridViewTextBoxColumn";
            this.hashDataGridViewTextBoxColumn.Width = 125;
            // 
            // nonceDataGridViewTextBoxColumn
            // 
            this.nonceDataGridViewTextBoxColumn.DataPropertyName = "Nonce";
            this.nonceDataGridViewTextBoxColumn.HeaderText = "Nonce";
            this.nonceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nonceDataGridViewTextBoxColumn.Name = "nonceDataGridViewTextBoxColumn";
            this.nonceDataGridViewTextBoxColumn.Width = 125;
            // 
            // blockHashDataGridViewTextBoxColumn
            // 
            this.blockHashDataGridViewTextBoxColumn.DataPropertyName = "BlockHash";
            this.blockHashDataGridViewTextBoxColumn.HeaderText = "BlockHash";
            this.blockHashDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blockHashDataGridViewTextBoxColumn.Name = "blockHashDataGridViewTextBoxColumn";
            this.blockHashDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionIndexDataGridViewTextBoxColumn
            // 
            this.transactionIndexDataGridViewTextBoxColumn.DataPropertyName = "TransactionIndex";
            this.transactionIndexDataGridViewTextBoxColumn.HeaderText = "TransactionIndex";
            this.transactionIndexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionIndexDataGridViewTextBoxColumn.Name = "transactionIndexDataGridViewTextBoxColumn";
            this.transactionIndexDataGridViewTextBoxColumn.Width = 125;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            this.fromDataGridViewTextBoxColumn.Width = 125;
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            this.toDataGridViewTextBoxColumn.Width = 125;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 125;
            // 
            // gasDataGridViewTextBoxColumn
            // 
            this.gasDataGridViewTextBoxColumn.DataPropertyName = "Gas";
            this.gasDataGridViewTextBoxColumn.HeaderText = "Gas";
            this.gasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gasDataGridViewTextBoxColumn.Name = "gasDataGridViewTextBoxColumn";
            this.gasDataGridViewTextBoxColumn.Width = 125;
            // 
            // gasPriceDataGridViewTextBoxColumn
            // 
            this.gasPriceDataGridViewTextBoxColumn.DataPropertyName = "GasPrice";
            this.gasPriceDataGridViewTextBoxColumn.HeaderText = "GasPrice";
            this.gasPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gasPriceDataGridViewTextBoxColumn.Name = "gasPriceDataGridViewTextBoxColumn";
            this.gasPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // isErrorDataGridViewTextBoxColumn
            // 
            this.isErrorDataGridViewTextBoxColumn.DataPropertyName = "IsError";
            this.isErrorDataGridViewTextBoxColumn.HeaderText = "IsError";
            this.isErrorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isErrorDataGridViewTextBoxColumn.Name = "isErrorDataGridViewTextBoxColumn";
            this.isErrorDataGridViewTextBoxColumn.Width = 125;
            // 
            // txreceiptstatusDataGridViewTextBoxColumn
            // 
            this.txreceiptstatusDataGridViewTextBoxColumn.DataPropertyName = "Txreceipt_status";
            this.txreceiptstatusDataGridViewTextBoxColumn.HeaderText = "Txreceipt_status";
            this.txreceiptstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.txreceiptstatusDataGridViewTextBoxColumn.Name = "txreceiptstatusDataGridViewTextBoxColumn";
            this.txreceiptstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // inputDataGridViewTextBoxColumn
            // 
            this.inputDataGridViewTextBoxColumn.DataPropertyName = "Input";
            this.inputDataGridViewTextBoxColumn.HeaderText = "Input";
            this.inputDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inputDataGridViewTextBoxColumn.Name = "inputDataGridViewTextBoxColumn";
            this.inputDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractAddressDataGridViewTextBoxColumn
            // 
            this.contractAddressDataGridViewTextBoxColumn.DataPropertyName = "ContractAddress";
            this.contractAddressDataGridViewTextBoxColumn.HeaderText = "ContractAddress";
            this.contractAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractAddressDataGridViewTextBoxColumn.Name = "contractAddressDataGridViewTextBoxColumn";
            this.contractAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // cumulativeGasUsedDataGridViewTextBoxColumn
            // 
            this.cumulativeGasUsedDataGridViewTextBoxColumn.DataPropertyName = "CumulativeGasUsed";
            this.cumulativeGasUsedDataGridViewTextBoxColumn.HeaderText = "CumulativeGasUsed";
            this.cumulativeGasUsedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cumulativeGasUsedDataGridViewTextBoxColumn.Name = "cumulativeGasUsedDataGridViewTextBoxColumn";
            this.cumulativeGasUsedDataGridViewTextBoxColumn.Width = 125;
            // 
            // gasUsedDataGridViewTextBoxColumn
            // 
            this.gasUsedDataGridViewTextBoxColumn.DataPropertyName = "GasUsed";
            this.gasUsedDataGridViewTextBoxColumn.HeaderText = "GasUsed";
            this.gasUsedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gasUsedDataGridViewTextBoxColumn.Name = "gasUsedDataGridViewTextBoxColumn";
            this.gasUsedDataGridViewTextBoxColumn.Width = 125;
            // 
            // confirmationsDataGridViewTextBoxColumn
            // 
            this.confirmationsDataGridViewTextBoxColumn.DataPropertyName = "Confirmations";
            this.confirmationsDataGridViewTextBoxColumn.HeaderText = "Confirmations";
            this.confirmationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.confirmationsDataGridViewTextBoxColumn.Name = "confirmationsDataGridViewTextBoxColumn";
            this.confirmationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // methodIdDataGridViewTextBoxColumn
            // 
            this.methodIdDataGridViewTextBoxColumn.DataPropertyName = "MethodId";
            this.methodIdDataGridViewTextBoxColumn.HeaderText = "MethodId";
            this.methodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.methodIdDataGridViewTextBoxColumn.Name = "methodIdDataGridViewTextBoxColumn";
            this.methodIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // functionNameDataGridViewTextBoxColumn
            // 
            this.functionNameDataGridViewTextBoxColumn.DataPropertyName = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.HeaderText = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.functionNameDataGridViewTextBoxColumn.Name = "functionNameDataGridViewTextBoxColumn";
            this.functionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Soyku.Etherscan.Core.Domain.Ropsten.Employee);
            // 
            // m_btnGetAll
            // 
            this.m_btnGetAll.Location = new System.Drawing.Point(112, 233);
            this.m_btnGetAll.Name = "m_btnGetAll";
            this.m_btnGetAll.Size = new System.Drawing.Size(228, 29);
            this.m_btnGetAll.TabIndex = 1;
            this.m_btnGetAll.Text = "List All";
            this.m_btnGetAll.UseVisualStyleBackColor = true;
            this.m_btnGetAll.Click += new System.EventHandler(this.m_btnGetAll_Click);
            // 
            // m_txtModule
            // 
            this.m_txtModule.Location = new System.Drawing.Point(112, 24);
            this.m_txtModule.Name = "m_txtModule";
            this.m_txtModule.Size = new System.Drawing.Size(228, 27);
            this.m_txtModule.TabIndex = 2;
            this.m_txtModule.Text = "account";
            this.m_txtModule.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // m_txtAction
            // 
            this.m_txtAction.Location = new System.Drawing.Point(443, 24);
            this.m_txtAction.Name = "m_txtAction";
            this.m_txtAction.Size = new System.Drawing.Size(228, 27);
            this.m_txtAction.TabIndex = 3;
            this.m_txtAction.Text = "txlist";
            this.m_txtAction.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Module";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Action";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Addres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // m_txtAddres
            // 
            this.m_txtAddres.Location = new System.Drawing.Point(112, 63);
            this.m_txtAddres.Name = "m_txtAddres";
            this.m_txtAddres.Size = new System.Drawing.Size(559, 27);
            this.m_txtAddres.TabIndex = 6;
            this.m_txtAddres.Text = "0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae";
            this.m_txtAddres.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start Block";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // m_txtStartBlock
            // 
            this.m_txtStartBlock.Location = new System.Drawing.Point(112, 96);
            this.m_txtStartBlock.Name = "m_txtStartBlock";
            this.m_txtStartBlock.Size = new System.Drawing.Size(228, 27);
            this.m_txtStartBlock.TabIndex = 8;
            this.m_txtStartBlock.Text = "0";
            this.m_txtStartBlock.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Block";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // m_txtEndBlock
            // 
            this.m_txtEndBlock.Location = new System.Drawing.Point(443, 96);
            this.m_txtEndBlock.Name = "m_txtEndBlock";
            this.m_txtEndBlock.Size = new System.Drawing.Size(228, 27);
            this.m_txtEndBlock.TabIndex = 10;
            this.m_txtEndBlock.Text = "99999999";
            this.m_txtEndBlock.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Page";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // m_txtPage
            // 
            this.m_txtPage.Location = new System.Drawing.Point(112, 133);
            this.m_txtPage.Name = "m_txtPage";
            this.m_txtPage.Size = new System.Drawing.Size(228, 27);
            this.m_txtPage.TabIndex = 13;
            this.m_txtPage.Text = "2";
            this.m_txtPage.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // m_comboSort
            // 
            this.m_comboSort.FormattingEnabled = true;
            this.m_comboSort.Items.AddRange(new object[] {
            "asc"});
            this.m_comboSort.Location = new System.Drawing.Point(112, 166);
            this.m_comboSort.Name = "m_comboSort";
            this.m_comboSort.Size = new System.Drawing.Size(228, 28);
            this.m_comboSort.TabIndex = 14;
            this.m_comboSort.Text = "asc";
            this.m_comboSort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Offset";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // m_txtOffset
            // 
            this.m_txtOffset.Location = new System.Drawing.Point(443, 133);
            this.m_txtOffset.Name = "m_txtOffset";
            this.m_txtOffset.Size = new System.Drawing.Size(228, 27);
            this.m_txtOffset.TabIndex = 16;
            this.m_txtOffset.Text = "10";
            this.m_txtOffset.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sort";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Api Key";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // m_txtApiKey
            // 
            this.m_txtApiKey.Location = new System.Drawing.Point(112, 200);
            this.m_txtApiKey.Name = "m_txtApiKey";
            this.m_txtApiKey.Size = new System.Drawing.Size(559, 27);
            this.m_txtApiKey.TabIndex = 18;
            this.m_txtApiKey.Text = "YourApiKeyToken";
            this.m_txtApiKey.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // m_group
            // 
            this.m_group.Controls.Add(this.m_btnGetAll);
            this.m_group.Controls.Add(this.label9);
            this.m_group.Controls.Add(this.m_txtModule);
            this.m_group.Controls.Add(this.m_txtApiKey);
            this.m_group.Controls.Add(this.m_txtAction);
            this.m_group.Controls.Add(this.label8);
            this.m_group.Controls.Add(this.label1);
            this.m_group.Controls.Add(this.m_txtOffset);
            this.m_group.Controls.Add(this.label2);
            this.m_group.Controls.Add(this.label7);
            this.m_group.Controls.Add(this.m_txtAddres);
            this.m_group.Controls.Add(this.m_comboSort);
            this.m_group.Controls.Add(this.label3);
            this.m_group.Controls.Add(this.m_txtPage);
            this.m_group.Controls.Add(this.m_txtStartBlock);
            this.m_group.Controls.Add(this.label6);
            this.m_group.Controls.Add(this.label4);
            this.m_group.Controls.Add(this.label5);
            this.m_group.Controls.Add(this.m_txtEndBlock);
            this.m_group.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_group.Location = new System.Drawing.Point(0, 0);
            this.m_group.Name = "m_group";
            this.m_group.Size = new System.Drawing.Size(1069, 290);
            this.m_group.TabIndex = 20;
            this.m_group.TabStop = false;
            this.m_group.Text = "Ropsten List";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 656);
            this.Controls.Add(this.m_group);
            this.Controls.Add(this.m_gridView);
            this.Name = "List";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.m_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.m_group.ResumeLayout(false);
            this.m_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_gridView;
        private System.Windows.Forms.Button m_btnGetAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txreceiptstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cumulativeGasUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox m_txtModule;
        private System.Windows.Forms.TextBox m_txtAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txtAddres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txtStartBlock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txtEndBlock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_txtPage;
        private System.Windows.Forms.ComboBox m_comboSort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_txtOffset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_txtApiKey;
        private System.Windows.Forms.GroupBox m_group;
    }
}