
namespace AgAccoutingSystem
{
    partial class Accountant_Screen
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
            this.ExitBttn = new System.Windows.Forms.Button();
            this.ViewSubBttn = new System.Windows.Forms.Button();
            this.accountantViewTransactionsDataGrid = new System.Windows.Forms.DataGridView();
            this.allAccountsDataGrid = new System.Windows.Forms.DataGridView();
            this.ViewTransactionsBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountantViewTransactionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAccountsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(885, 546);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(253, 60);
            this.ExitBttn.TabIndex = 0;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // ViewSubBttn
            // 
            this.ViewSubBttn.Location = new System.Drawing.Point(455, 546);
            this.ViewSubBttn.Name = "ViewSubBttn";
            this.ViewSubBttn.Size = new System.Drawing.Size(253, 60);
            this.ViewSubBttn.TabIndex = 1;
            this.ViewSubBttn.Text = "View Submissions";
            this.ViewSubBttn.UseVisualStyleBackColor = true;
            this.ViewSubBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountantViewTransactionsDataGrid
            // 
            this.accountantViewTransactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountantViewTransactionsDataGrid.Location = new System.Drawing.Point(12, 271);
            this.accountantViewTransactionsDataGrid.Name = "accountantViewTransactionsDataGrid";
            this.accountantViewTransactionsDataGrid.Size = new System.Drawing.Size(1126, 253);
            this.accountantViewTransactionsDataGrid.TabIndex = 7;
            // 
            // allAccountsDataGrid
            // 
            this.allAccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allAccountsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.allAccountsDataGrid.Name = "allAccountsDataGrid";
            this.allAccountsDataGrid.Size = new System.Drawing.Size(446, 253);
            this.allAccountsDataGrid.TabIndex = 6;
            // 
            // ViewTransactionsBttn
            // 
            this.ViewTransactionsBttn.Location = new System.Drawing.Point(12, 546);
            this.ViewTransactionsBttn.Name = "ViewTransactionsBttn";
            this.ViewTransactionsBttn.Size = new System.Drawing.Size(253, 60);
            this.ViewTransactionsBttn.TabIndex = 8;
            this.ViewTransactionsBttn.Text = "View Transactions";
            this.ViewTransactionsBttn.UseVisualStyleBackColor = true;
            this.ViewTransactionsBttn.Click += new System.EventHandler(this.ViewTransactionsBttn_Click);
            // 
            // Accountant_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 618);
            this.Controls.Add(this.ViewTransactionsBttn);
            this.Controls.Add(this.accountantViewTransactionsDataGrid);
            this.Controls.Add(this.allAccountsDataGrid);
            this.Controls.Add(this.ViewSubBttn);
            this.Controls.Add(this.ExitBttn);
            this.Name = "Accountant_Screen";
            this.Text = "Accountant";
            this.Load += new System.EventHandler(this.Accountant_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountantViewTransactionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAccountsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button ViewSubBttn;
        private System.Windows.Forms.DataGridView accountantViewTransactionsDataGrid;
        private System.Windows.Forms.DataGridView allAccountsDataGrid;
        private System.Windows.Forms.Button ViewTransactionsBttn;
    }
}