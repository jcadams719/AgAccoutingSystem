
namespace AgAccoutingSystem
{
    partial class User_Screen
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
            this.SubmitTransBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.GetAccountsBttn = new System.Windows.Forms.Button();
            this.GetTransactionBttn = new System.Windows.Forms.Button();
            this.gROUP4DataSet = new AgAccoutingSystem.GROUP4DataSet();
            this.aCCOUNTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTSTableAdapter = new AgAccoutingSystem.GROUP4DataSetTableAdapters.ACCOUNTSTableAdapter();
            this.tableAdapterManager = new AgAccoutingSystem.GROUP4DataSetTableAdapters.TableAdapterManager();
            this.rEGISTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEGISTERTableAdapter = new AgAccoutingSystem.GROUP4DataSetTableAdapters.REGISTERTableAdapter();
            this.rEGISTERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitTransBttn
            // 
            this.SubmitTransBttn.Location = new System.Drawing.Point(210, 399);
            this.SubmitTransBttn.Name = "SubmitTransBttn";
            this.SubmitTransBttn.Size = new System.Drawing.Size(153, 39);
            this.SubmitTransBttn.TabIndex = 0;
            this.SubmitTransBttn.Text = "Submit Transaction";
            this.SubmitTransBttn.UseVisualStyleBackColor = true;
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(369, 399);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(153, 39);
            this.ExitBttn.TabIndex = 1;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            // 
            // GetAccountsBttn
            // 
            this.GetAccountsBttn.Location = new System.Drawing.Point(12, 12);
            this.GetAccountsBttn.Name = "GetAccountsBttn";
            this.GetAccountsBttn.Size = new System.Drawing.Size(153, 39);
            this.GetAccountsBttn.TabIndex = 2;
            this.GetAccountsBttn.Text = "Get Accounts";
            this.GetAccountsBttn.UseVisualStyleBackColor = true;
            this.GetAccountsBttn.Click += new System.EventHandler(this.GetAccountsBttn_Click);
            // 
            // GetTransactionBttn
            // 
            this.GetTransactionBttn.Location = new System.Drawing.Point(1205, 12);
            this.GetTransactionBttn.Name = "GetTransactionBttn";
            this.GetTransactionBttn.Size = new System.Drawing.Size(153, 39);
            this.GetTransactionBttn.TabIndex = 3;
            this.GetTransactionBttn.Text = "Get Transactions";
            this.GetTransactionBttn.UseVisualStyleBackColor = true;
            this.GetTransactionBttn.Click += new System.EventHandler(this.GetTransactionBttn_Click);
            // 
            // gROUP4DataSet
            // 
            this.gROUP4DataSet.DataSetName = "GROUP4DataSet";
            this.gROUP4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCCOUNTSBindingSource
            // 
            this.aCCOUNTSBindingSource.DataMember = "ACCOUNTS";
            this.aCCOUNTSBindingSource.DataSource = this.gROUP4DataSet;
            // 
            // aCCOUNTSTableAdapter
            // 
            this.aCCOUNTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTSTableAdapter = this.aCCOUNTSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CODESTableAdapter = null;
            this.tableAdapterManager.REGISTERTableAdapter = this.rEGISTERTableAdapter;
            this.tableAdapterManager.UpdateOrder = AgAccoutingSystem.GROUP4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERACCOUNTSTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // rEGISTERBindingSource
            // 
            this.rEGISTERBindingSource.DataMember = "REGISTER";
            this.rEGISTERBindingSource.DataSource = this.gROUP4DataSet;
            // 
            // rEGISTERTableAdapter
            // 
            this.rEGISTERTableAdapter.ClearBeforeFill = true;
            // 
            // rEGISTERDataGridView
            // 
            this.rEGISTERDataGridView.AutoGenerateColumns = false;
            this.rEGISTERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rEGISTERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.rEGISTERDataGridView.DataSource = this.rEGISTERBindingSource;
            this.rEGISTERDataGridView.Location = new System.Drawing.Point(12, 57);
            this.rEGISTERDataGridView.Name = "rEGISTERDataGridView";
            this.rEGISTERDataGridView.Size = new System.Drawing.Size(1346, 306);
            this.rEGISTERDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TRANSACTIONID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TRANSACTIONID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "CODE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ACCOUNTID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ACCOUNTID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DOCUMENT";
            this.dataGridViewTextBoxColumn5.HeaderText = "DOCUMENT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SUBACCT";
            this.dataGridViewTextBoxColumn6.HeaderText = "SUBACCT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VENDOR";
            this.dataGridViewTextBoxColumn7.HeaderText = "VENDOR";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ITEM";
            this.dataGridViewTextBoxColumn8.HeaderText = "ITEM";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DEPOSIT";
            this.dataGridViewTextBoxColumn9.HeaderText = "DEPOSIT";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "EXPENSE";
            this.dataGridViewTextBoxColumn10.HeaderText = "EXPENSE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FISCALYEAR";
            this.dataGridViewTextBoxColumn11.HeaderText = "FISCALYEAR";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn12.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "COMMENT";
            this.dataGridViewTextBoxColumn13.HeaderText = "COMMENT";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // User_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 458);
            this.Controls.Add(this.rEGISTERDataGridView);
            this.Controls.Add(this.GetTransactionBttn);
            this.Controls.Add(this.GetAccountsBttn);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.SubmitTransBttn);
            this.Name = "User_Screen";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitTransBttn;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button GetAccountsBttn;
        private System.Windows.Forms.Button GetTransactionBttn;
        private GROUP4DataSet gROUP4DataSet;
        private System.Windows.Forms.BindingSource aCCOUNTSBindingSource;
        private GROUP4DataSetTableAdapters.ACCOUNTSTableAdapter aCCOUNTSTableAdapter;
        private GROUP4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GROUP4DataSetTableAdapters.REGISTERTableAdapter rEGISTERTableAdapter;
        private System.Windows.Forms.BindingSource rEGISTERBindingSource;
        private System.Windows.Forms.DataGridView rEGISTERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}