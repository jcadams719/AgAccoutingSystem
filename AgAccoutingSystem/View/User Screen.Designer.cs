
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
            this.GetTransactionBttn = new System.Windows.Forms.Button();
            this.gROUP4DataSet = new AgAccoutingSystem.GROUP4DataSet();
            this.aCCOUNTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTSTableAdapter = new AgAccoutingSystem.GROUP4DataSetTableAdapters.ACCOUNTSTableAdapter();
            this.tableAdapterManager = new AgAccoutingSystem.GROUP4DataSetTableAdapters.TableAdapterManager();
            this.rEGISTERTableAdapter = new AgAccoutingSystem.GROUP4DataSetTableAdapters.REGISTERTableAdapter();
            this.rEGISTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitTransBttn
            // 
            this.SubmitTransBttn.Location = new System.Drawing.Point(335, 393);
            this.SubmitTransBttn.Name = "SubmitTransBttn";
            this.SubmitTransBttn.Size = new System.Drawing.Size(153, 39);
            this.SubmitTransBttn.TabIndex = 0;
            this.SubmitTransBttn.Text = "Submit Transaction";
            this.SubmitTransBttn.UseVisualStyleBackColor = true;
            this.SubmitTransBttn.Click += new System.EventHandler(this.SubmitTransBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(494, 393);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(153, 39);
            this.ExitBttn.TabIndex = 1;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // GetTransactionBttn
            // 
            this.GetTransactionBttn.Location = new System.Drawing.Point(176, 393);
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
            // rEGISTERTableAdapter
            // 
            this.rEGISTERTableAdapter.ClearBeforeFill = true;
            // 
            // rEGISTERBindingSource
            // 
            this.rEGISTERBindingSource.DataMember = "REGISTER";
            this.rEGISTERBindingSource.DataSource = this.gROUP4DataSet;
            // 
            // aCCOUNTSDataGridView
            // 
            this.aCCOUNTSDataGridView.AutoGenerateColumns = false;
            this.aCCOUNTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aCCOUNTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.aCCOUNTSDataGridView.DataSource = this.aCCOUNTSBindingSource;
            this.aCCOUNTSDataGridView.Location = new System.Drawing.Point(12, 12);
            this.aCCOUNTSDataGridView.Name = "aCCOUNTSDataGridView";
            this.aCCOUNTSDataGridView.Size = new System.Drawing.Size(746, 171);
            this.aCCOUNTSDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ACCOUNTID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ACCOUNTID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RESEARCHCENTER";
            this.dataGridViewTextBoxColumn2.HeaderText = "RESEARCHCENTER";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ACCOUNTMANAGER";
            this.dataGridViewTextBoxColumn3.HeaderText = "ACCOUNTMANAGER";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TYPE";
            this.dataGridViewTextBoxColumn4.HeaderText = "TYPE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ACCOUNTHOLDER";
            this.dataGridViewTextBoxColumn5.HeaderText = "ACCOUNTHOLDER";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BALANCE";
            this.dataGridViewTextBoxColumn6.HeaderText = "BALANCE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PERSONINCHARGE";
            this.dataGridViewTextBoxColumn7.HeaderText = "PERSONINCHARGE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 186);
            this.dataGridView1.TabIndex = 4;
            // 
            // User_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.aCCOUNTSDataGridView);
            this.Controls.Add(this.GetTransactionBttn);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.SubmitTransBttn);
            this.Name = "User_Screen";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitTransBttn;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button GetTransactionBttn;
        private GROUP4DataSet gROUP4DataSet;
        private System.Windows.Forms.BindingSource aCCOUNTSBindingSource;
        private GROUP4DataSetTableAdapters.ACCOUNTSTableAdapter aCCOUNTSTableAdapter;
        private GROUP4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GROUP4DataSetTableAdapters.REGISTERTableAdapter rEGISTERTableAdapter;
        private System.Windows.Forms.BindingSource rEGISTERBindingSource;
        private System.Windows.Forms.DataGridView aCCOUNTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}