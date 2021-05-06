
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountant_Screen));
            this.ExitBttn = new System.Windows.Forms.Button();
            this.ViewSubBttn = new System.Windows.Forms.Button();
            this.accountantViewTransactionsDataGrid = new System.Windows.Forms.DataGridView();
            this.allAccountsDataGrid = new System.Windows.Forms.DataGridView();
            this.ViewTransactionsBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAcctBttn = new System.Windows.Forms.Button();
            this.AgPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.accountantViewTransactionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAccountsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(586, 567);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(253, 60);
            this.ExitBttn.TabIndex = 0;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // ViewSubBttn
            // 
            this.ViewSubBttn.Location = new System.Drawing.Point(301, 567);
            this.ViewSubBttn.Name = "ViewSubBttn";
            this.ViewSubBttn.Size = new System.Drawing.Size(253, 60);
            this.ViewSubBttn.TabIndex = 1;
            this.ViewSubBttn.Text = "View Submissions";
            this.ViewSubBttn.UseVisualStyleBackColor = true;
            this.ViewSubBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountantViewTransactionsDataGrid
            // 
            this.accountantViewTransactionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.accountantViewTransactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountantViewTransactionsDataGrid.Location = new System.Drawing.Point(12, 308);
            this.accountantViewTransactionsDataGrid.Name = "accountantViewTransactionsDataGrid";
            this.accountantViewTransactionsDataGrid.Size = new System.Drawing.Size(827, 253);
            this.accountantViewTransactionsDataGrid.TabIndex = 7;
            // 
            // allAccountsDataGrid
            // 
            this.allAccountsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.allAccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allAccountsDataGrid.Location = new System.Drawing.Point(12, 28);
            this.allAccountsDataGrid.Name = "allAccountsDataGrid";
            this.allAccountsDataGrid.Size = new System.Drawing.Size(425, 253);
            this.allAccountsDataGrid.TabIndex = 6;
            // 
            // ViewTransactionsBttn
            // 
            this.ViewTransactionsBttn.Location = new System.Drawing.Point(12, 567);
            this.ViewTransactionsBttn.Name = "ViewTransactionsBttn";
            this.ViewTransactionsBttn.Size = new System.Drawing.Size(253, 60);
            this.ViewTransactionsBttn.TabIndex = 8;
            this.ViewTransactionsBttn.Text = "View Transactions";
            this.ViewTransactionsBttn.UseVisualStyleBackColor = true;
            this.ViewTransactionsBttn.Click += new System.EventHandler(this.ViewTransactionsBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Transactions";
            // 
            // AddAcctBttn
            // 
            this.AddAcctBttn.Location = new System.Drawing.Point(443, 233);
            this.AddAcctBttn.Name = "AddAcctBttn";
            this.AddAcctBttn.Size = new System.Drawing.Size(111, 48);
            this.AddAcctBttn.TabIndex = 11;
            this.AddAcctBttn.Text = "Add Selected Account";
            this.AddAcctBttn.UseVisualStyleBackColor = true;
            // 
            // AgPicture
            // 
            this.AgPicture.Image = ((System.Drawing.Image)(resources.GetObject("AgPicture.Image")));
            this.AgPicture.Location = new System.Drawing.Point(570, 28);
            this.AgPicture.Name = "AgPicture";
            this.AgPicture.Size = new System.Drawing.Size(269, 253);
            this.AgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AgPicture.TabIndex = 12;
            this.AgPicture.TabStop = false;
            // 
            // Accountant_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 639);
            this.Controls.Add(this.AgPicture);
            this.Controls.Add(this.AddAcctBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.AgPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button ViewSubBttn;
        private System.Windows.Forms.DataGridView accountantViewTransactionsDataGrid;
        private System.Windows.Forms.DataGridView allAccountsDataGrid;
        private System.Windows.Forms.Button ViewTransactionsBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAcctBttn;
        private System.Windows.Forms.PictureBox AgPicture;
    }
}