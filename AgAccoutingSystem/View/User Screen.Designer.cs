
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
            this.TransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.aCCOUNTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSet = new AgAccoutingSystem.GROUP4DataSet();
            this.aCCOUNTSTableAdapter = new AgAccoutingSystem.GROUP4DataSetTableAdapters.ACCOUNTSTableAdapter();
            this.tableAdapterManager = new AgAccoutingSystem.GROUP4DataSetTableAdapters.TableAdapterManager();
            this.rEGISTERTableAdapter = new AgAccoutingSystem.GROUP4DataSetTableAdapters.REGISTERTableAdapter();
            this.rEGISTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agDatabase = new AgAccoutingSystem.AgDatabase();
            this.aCCOUNTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTSTableAdapter1 = new AgAccoutingSystem.AgDatabaseTableAdapters.ACCOUNTSTableAdapter();
            this.tableAdapterManager1 = new AgAccoutingSystem.AgDatabaseTableAdapters.TableAdapterManager();
            this.aCCOUNTSDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSDataGridView)).BeginInit();
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
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGridView.Location = new System.Drawing.Point(12, 189);
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.Size = new System.Drawing.Size(746, 186);
            this.TransactionDataGridView.TabIndex = 4;
            // 
            // aCCOUNTSBindingSource
            // 
            this.aCCOUNTSBindingSource.DataMember = "ACCOUNTS";
            this.aCCOUNTSBindingSource.DataSource = this.gROUP4DataSet;
            // 
            // gROUP4DataSet
            // 
            this.gROUP4DataSet.DataSetName = "GROUP4DataSet";
            this.gROUP4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // agDatabase
            // 
            this.agDatabase.DataSetName = "AgDatabase";
            this.agDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCCOUNTSBindingSource1
            // 
            this.aCCOUNTSBindingSource1.DataMember = "ACCOUNTS";
            this.aCCOUNTSBindingSource1.DataSource = this.agDatabase;
            // 
            // aCCOUNTSTableAdapter1
            // 
            this.aCCOUNTSTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ACCOUNTSTableAdapter = this.aCCOUNTSTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CODESTableAdapter = null;
            this.tableAdapterManager1.REGISTERTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = AgAccoutingSystem.AgDatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.USERACCOUNTSTableAdapter = null;
            this.tableAdapterManager1.USERSTableAdapter = null;
            // 
            // aCCOUNTSDataGridView
            // 
            this.aCCOUNTSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.aCCOUNTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aCCOUNTSDataGridView.Location = new System.Drawing.Point(12, 3);
            this.aCCOUNTSDataGridView.Name = "aCCOUNTSDataGridView";
            this.aCCOUNTSDataGridView.Size = new System.Drawing.Size(746, 180);
            this.aCCOUNTSDataGridView.TabIndex = 4;
            // 
            // User_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 452);
            this.Controls.Add(this.aCCOUNTSDataGridView);
            this.Controls.Add(this.TransactionDataGridView);
            this.Controls.Add(this.GetTransactionBttn);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.SubmitTransBttn);
            this.Name = "User_Screen";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTSDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView TransactionDataGridView;
        private AgDatabase agDatabase;
        private System.Windows.Forms.BindingSource aCCOUNTSBindingSource1;
        private AgDatabaseTableAdapters.ACCOUNTSTableAdapter aCCOUNTSTableAdapter1;
        private AgDatabaseTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView aCCOUNTSDataGridView;
    }
}