
namespace AgAccoutingSystem
{
    partial class ViewSubmissions
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
            this.ConfirmBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.RejectBttn = new System.Windows.Forms.Button();
            this.TransactionsdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmBttn
            // 
            this.ConfirmBttn.Location = new System.Drawing.Point(585, 389);
            this.ConfirmBttn.Name = "ConfirmBttn";
            this.ConfirmBttn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBttn.TabIndex = 0;
            this.ConfirmBttn.Text = "Confirm";
            this.ConfirmBttn.UseVisualStyleBackColor = true;
            this.ConfirmBttn.Click += new System.EventHandler(this.ConfirmBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(585, 418);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(156, 23);
            this.ExitBttn.TabIndex = 1;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // RejectBttn
            // 
            this.RejectBttn.Location = new System.Drawing.Point(666, 389);
            this.RejectBttn.Name = "RejectBttn";
            this.RejectBttn.Size = new System.Drawing.Size(75, 23);
            this.RejectBttn.TabIndex = 3;
            this.RejectBttn.Text = "Reject";
            this.RejectBttn.UseVisualStyleBackColor = true;
            this.RejectBttn.Click += new System.EventHandler(this.RejectBttn_Click);
            // 
            // TransactionsdataGridView
            // 
            this.TransactionsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsdataGridView.Location = new System.Drawing.Point(12, 28);
            this.TransactionsdataGridView.Name = "TransactionsdataGridView";
            this.TransactionsdataGridView.Size = new System.Drawing.Size(1297, 355);
            this.TransactionsdataGridView.TabIndex = 4;
            // 
            // ViewSubmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 451);
            this.Controls.Add(this.TransactionsdataGridView);
            this.Controls.Add(this.RejectBttn);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.ConfirmBttn);
            this.Name = "ViewSubmissions";
            this.Text = "ViewSubmissions";
            this.Load += new System.EventHandler(this.ViewSubmissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConfirmBttn;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button RejectBttn;
        private System.Windows.Forms.DataGridView TransactionsdataGridView;
    }
}