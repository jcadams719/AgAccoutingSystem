
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SysAdminRB = new System.Windows.Forms.RadioButton();
            this.UserRB = new System.Windows.Forms.RadioButton();
            this.AccountantRB = new System.Windows.Forms.RadioButton();
            this.DisciplineGB = new System.Windows.Forms.GroupBox();
            this.ChangeBttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminViewTransactionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminAllAccountsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DisciplineGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(438, 585);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(396, 62);
            this.ExitBttn.TabIndex = 0;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // adminViewSubmissionButton
            // 
            this.adminViewSubmissionButton.Location = new System.Drawing.Point(12, 585);
            this.adminViewSubmissionButton.Name = "adminViewSubmissionButton";
            this.adminViewSubmissionButton.Size = new System.Drawing.Size(396, 62);
            this.adminViewSubmissionButton.TabIndex = 6;
            this.adminViewSubmissionButton.Text = "View Transactions";
            this.adminViewSubmissionButton.UseVisualStyleBackColor = true;
            this.adminViewSubmissionButton.Click += new System.EventHandler(this.adminViewSubmissionButton_Click);
            // 
            // adminViewTransactionsDataGrid
            // 
            this.adminViewTransactionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.adminViewTransactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminViewTransactionsDataGrid.Location = new System.Drawing.Point(12, 321);
            this.adminViewTransactionsDataGrid.Name = "adminViewTransactionsDataGrid";
            this.adminViewTransactionsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.adminViewTransactionsDataGrid.Size = new System.Drawing.Size(822, 258);
            this.adminViewTransactionsDataGrid.TabIndex = 5;
            // 
            // adminAllAccountsDataGrid
            // 
            this.adminAllAccountsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.adminAllAccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminAllAccountsDataGrid.Location = new System.Drawing.Point(12, 31);
            this.adminAllAccountsDataGrid.Name = "adminAllAccountsDataGrid";
            this.adminAllAccountsDataGrid.Size = new System.Drawing.Size(434, 258);
            this.adminAllAccountsDataGrid.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(231, 258);
            this.dataGridView1.TabIndex = 7;
            // 
            // SysAdminRB
            // 
            this.SysAdminRB.AutoSize = true;
            this.SysAdminRB.Location = new System.Drawing.Point(6, 20);
            this.SysAdminRB.Name = "SysAdminRB";
            this.SysAdminRB.Size = new System.Drawing.Size(91, 17);
            this.SysAdminRB.TabIndex = 8;
            this.SysAdminRB.TabStop = true;
            this.SysAdminRB.Text = "System Admin";
            this.SysAdminRB.UseVisualStyleBackColor = true;
            // 
            // UserRB
            // 
            this.UserRB.AutoSize = true;
            this.UserRB.Location = new System.Drawing.Point(6, 43);
            this.UserRB.Name = "UserRB";
            this.UserRB.Size = new System.Drawing.Size(47, 17);
            this.UserRB.TabIndex = 9;
            this.UserRB.TabStop = true;
            this.UserRB.Text = "User";
            this.UserRB.UseVisualStyleBackColor = true;
            // 
            // AccountantRB
            // 
            this.AccountantRB.AutoSize = true;
            this.AccountantRB.Location = new System.Drawing.Point(6, 66);
            this.AccountantRB.Name = "AccountantRB";
            this.AccountantRB.Size = new System.Drawing.Size(80, 17);
            this.AccountantRB.TabIndex = 10;
            this.AccountantRB.TabStop = true;
            this.AccountantRB.Text = "Accountant";
            this.AccountantRB.UseVisualStyleBackColor = true;
            // 
            // DisciplineGB
            // 
            this.DisciplineGB.Controls.Add(this.UserRB);
            this.DisciplineGB.Controls.Add(this.AccountantRB);
            this.DisciplineGB.Controls.Add(this.SysAdminRB);
            this.DisciplineGB.Location = new System.Drawing.Point(243, 79);
            this.DisciplineGB.Name = "DisciplineGB";
            this.DisciplineGB.Size = new System.Drawing.Size(123, 107);
            this.DisciplineGB.TabIndex = 11;
            this.DisciplineGB.TabStop = false;
            this.DisciplineGB.Text = "Discipline";
            // 
            // ChangeBttn
            // 
            this.ChangeBttn.Location = new System.Drawing.Point(243, 192);
            this.ChangeBttn.Name = "ChangeBttn";
            this.ChangeBttn.Size = new System.Drawing.Size(123, 29);
            this.ChangeBttn.TabIndex = 12;
            this.ChangeBttn.Text = "Change Discipline";
            this.ChangeBttn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangeBttn);
            this.groupBox1.Controls.Add(this.DisciplineGB);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(452, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 287);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Transactions";
            // 
            // System_Admin_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adminViewSubmissionButton);
            this.Controls.Add(this.adminViewTransactionsDataGrid);
            this.Controls.Add(this.adminAllAccountsDataGrid);
            this.Controls.Add(this.ExitBttn);
            this.Name = "System_Admin_Screen";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.System_Admin_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminViewTransactionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminAllAccountsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DisciplineGB.ResumeLayout(false);
            this.DisciplineGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button adminViewSubmissionButton;
        private System.Windows.Forms.DataGridView adminViewTransactionsDataGrid;
        private System.Windows.Forms.DataGridView adminAllAccountsDataGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton SysAdminRB;
        private System.Windows.Forms.RadioButton UserRB;
        private System.Windows.Forms.RadioButton AccountantRB;
        private System.Windows.Forms.GroupBox DisciplineGB;
        private System.Windows.Forms.Button ChangeBttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}