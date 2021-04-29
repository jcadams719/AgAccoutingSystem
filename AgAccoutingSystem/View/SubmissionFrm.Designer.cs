
namespace AgAccoutingSystem
{
    partial class SubmissionFrm
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
            this.SubmitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(416, 379);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(75, 23);
            this.ExitBttn.TabIndex = 0;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // SubmitBttn
            // 
            this.SubmitBttn.Location = new System.Drawing.Point(335, 379);
            this.SubmitBttn.Name = "SubmitBttn";
            this.SubmitBttn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBttn.TabIndex = 1;
            this.SubmitBttn.Text = "Submit";
            this.SubmitBttn.UseVisualStyleBackColor = true;
            this.SubmitBttn.Click += new System.EventHandler(this.SubmitBttn_Click);
            // 
            // SubmissionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitBttn);
            this.Controls.Add(this.ExitBttn);
            this.Name = "SubmissionFrm";
            this.Text = "SubmissionFrm";
            this.Load += new System.EventHandler(this.SubmissionFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button SubmitBttn;
    }
}