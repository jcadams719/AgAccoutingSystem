
namespace AgAccoutingSystem
{
    partial class System_Admin_Screen
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
            this.adminViewSubmissionButton = new System.Windows.Forms.Button();
            this.adminViewTransactionsDataGrid = new System.Windows.Forms.DataGridView();
            this.adminAllAccountsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewTransactionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminAllAccountsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(754, 559);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(415, 62);
            this.ExitBttn.TabIndex = 0;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // adminViewSubmissionButton
            // 
            this.adminViewSubmissionButton.Location = new System.Drawing.Point(35, 559);
            this.adminViewSubmissionButton.Name = "adminViewSubmissionButton";
            this.adminViewSubmissionButton.Size = new System.Drawing.Size(415, 62);
            this.adminViewSubmissionButton.TabIndex = 6;
            this.adminViewSubmissionButton.Text = "View Transactions";
            this.adminViewSubmissionButton.UseVisualStyleBackColor = true;
            this.adminViewSubmissionButton.Click += new System.EventHandler(this.adminViewSubmissionButton_Click);
            // 
            // adminViewTransactionsDataGrid
            // 
            this.adminViewTransactionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.adminViewTransactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminViewTransactionsDataGrid.Location = new System.Drawing.Point(35, 285);
            this.adminViewTransactionsDataGrid.Name = "adminViewTransactionsDataGrid";
            this.adminViewTransactionsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.adminViewTransactionsDataGrid.Size = new System.Drawing.Size(1134, 258);
            this.adminViewTransactionsDataGrid.TabIndex = 5;
            // 
            // adminAllAccountsDataGrid
            // 
            this.adminAllAccountsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.adminAllAccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminAllAccountsDataGrid.Location = new System.Drawing.Point(35, 21);
            this.adminAllAccountsDataGrid.Name = "adminAllAccountsDataGrid";
            this.adminAllAccountsDataGrid.Size = new System.Drawing.Size(434, 258);
            this.adminAllAccountsDataGrid.TabIndex = 4;
            // 
            // System_Admin_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 642);
            this.Controls.Add(this.adminViewSubmissionButton);
            this.Controls.Add(this.adminViewTransactionsDataGrid);
            this.Controls.Add(this.adminAllAccountsDataGrid);
            this.Controls.Add(this.ExitBttn);
            this.Name = "System_Admin_Screen";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.System_Admin_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminViewTransactionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminAllAccountsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button adminViewSubmissionButton;
        private System.Windows.Forms.DataGridView adminViewTransactionsDataGrid;
        private System.Windows.Forms.DataGridView adminAllAccountsDataGrid;
    }
}